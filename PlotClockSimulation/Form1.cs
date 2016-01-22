using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plot_Clock_Simulation
{
    public partial class Form1 : Form
    {
        //scale ratio=1:4
        double L1 = 100, R1 = 100, L2 = 150, R2 = 150;
        double d = 75, m = 0;
        double pointCx = 0, pointCy = 0;
        double pointCxLast = 0, pointCyLast = 0;
        double error = 0;
        double pointDx = 0, pointDy = 0;
        double pointEx = 0, pointEy = 0;
        double angleA = 0, angleB = 0;
        double minA = 45, minB = -45;
        double angleD1 = 0, angleD2 = 0;
        static Bitmap image = new Bitmap(1100, 600);
        int offsetX = 450, offsetY = 550;
        Point mousepos = new Point(0, 0);
        Point mousepos_mm = new Point(0, 0);


        double angleA1 = 0, angleA2 = 0;
        double angleB1 = 0, angleB2 = 0;
        double n1 = 0, n2 = 0;
        double targetPointX = 0, targetPointY = 0;
        Point panelOffset = new Point(23, -30);//23,-30


        Graphics g = Graphics.FromImage(image);
        Pen p = new Pen(Color.Black, 1);
        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        
        void move()
        {
            //panel1.Visible = false;
            pointDx = L1 * Math.Cos(angleA * 3.14159 / 180);
            pointDy = L1 * Math.Sin(angleA * 3.14159 / 180);

            pointEx = L1 * Math.Cos(angleB * 3.14159 / 180) + d;
            pointEy = L1 * Math.Sin(angleB * 3.14159 / 180);

            m = Math.Sqrt((pointEy - pointDy) * (pointEy - pointDy) + (pointEx - pointDx) * (pointEx - pointDx));

            if (m < (L2 + R2))
            {
                angleD1 = Math.Atan2(pointEy - pointDy, pointEx - pointDx);
                angleD1 = angleD1 * 180 / 3.14;
                angleD2 = Math.Acos((L2 * L2 + m * m - R2 * R2) / (2 * L2 * m));
                angleD2 = angleD2 * 180 / 3.14;

                pointCx = pointDx + L2 * Math.Cos((angleD1 + angleD2) * 3.14 / 180);
                pointCy = pointDy + L2 * Math.Sin((angleD1 + angleD2) * 3.14 / 180);


                p.Color = Color.Red;
                p.Width = 3;
                g.DrawLine(p, (float)(offsetX + 0), (float)(offsetY - 0), (float)(offsetX + pointDx), (float)(offsetY - pointDy));
                p.Color = Color.Blue;
                g.DrawLine(p, (float)(offsetX + pointDx), (float)(offsetY - pointDy), (float)(offsetX + pointCx), (float)(offsetY - pointCy));
                p.Color = Color.Blue;
                g.DrawLine(p, (float)(offsetX + pointCx), (float)(offsetY - pointCy), (float)(offsetX + pointEx), (float)(offsetY - pointEy));
                p.Color = Color.Red;
                g.DrawLine(p, (float)(offsetX + pointEx), (float)(offsetY - pointEy), (float)(offsetX + d), (float)(offsetY - 0));
                p.Color = Color.Black;
                p.Width = 4;
                g.DrawPie(p, (float)(offsetX +pointCx-3),(float)(offsetY -  pointCy-3), 6, 6, 0, 360);
                panel1.BackgroundImage = image;

                textbox_point.Text = "(" + (pointCx * 0.4).ToString("#0.00") + "," + (pointCy * 0.4).ToString("#0.00") + ")";
                error = Math.Sqrt(Math.Pow(pointCx - pointCxLast, 2) + Math.Pow(pointCy - pointCyLast, 2)) * 0.4;
                textBox_error.Text = error.ToString("#0.00");
                pointCxLast = pointCx;
                pointCyLast = pointCy;
            
            }
            //panel1.Visible = true;
        }


        void bogenUZS(double bx, double by, double radius, double start, double ende, double sqee)
        {
            double inkr = -0.05;
            double count = 0;

            do
            {
                drawTo(sqee * radius * Math.Cos(start + count) + bx,
                radius * Math.Sin(start + count) + by);
                count += inkr;
            }
            while ((start + count) > ende);

        }

        void bogenGZS(double bx, double by, double radius, double start, double ende, double sqee)
        {
            double inkr = 0.05;
            double count = 0;

            do
            {
                drawTo(sqee * radius * Math.Cos(start + count) + bx,
                radius * Math.Sin(start + count) + by);
                count += inkr;
            }
            while ((start + count) <= ende);
        }



        double lastX = 0, lastY = 0;
        void drawTo(double pX, double pY)
        {
            double dx, dy;
            int count;
            int c;
            // dx dy of new point
            dx = pX - lastX;
            dy = pY - lastY;
            //path lenght in mm, times 4 equals 4 steps per mm
            c = (int)(4 * Math.Sqrt(dx * dx + dy * dy));

            if (c < 1) c = 1;

            for (count = 0; count <= c; )
            {
                // draw line point by point
                setPoint(lastX + (count * dx / c), lastY + (count * dy / c));
                move_drawPoint();
                count++;
            }

            lastX = pX;
            lastY = pY;
        }


        void setPoint(double x, double y)
        {
            x = x / 0.4;//turn unit mm to pixel
            y = y / 0.4;
            n1 = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));
            n2 = Math.Sqrt(Math.Pow(x - d, 2) + Math.Pow(y - 0, 2));
            if ((n1 + n2) > d && (n1 + d) > n2 && (d + n2) > n1)//check if its a triangle
            {
                angleA1 = Math.Acos((n1 * n1 + d * d - n2 * n2) / (2 * n1 * d));
                angleA1 = angleA1 * 180 / 3.14;
                angleA2 = Math.Acos((n1 * n1 + L1 * L1 - L2 * L2) / (2 * n1 * L1));
                angleA2 = angleA2 * 180 / 3.14;
                angleA = angleA1 + angleA2;

                angleB1 = Math.Acos((n2 * n2 + d * d - n1 * n1) / (2 * n2 * d));
                angleB1 = angleB1 * 180 / 3.14;
                angleB2 = Math.Acos((n2 * n2 + R1 * R1 - R2 * R2) / (2 * n2 * R1));
                angleB2 = angleB2 * 180 / 3.14;
                angleB = 180 - (angleB1 + angleB2);

                text_angleA.Text = angleA.ToString("#.##");
                text_angleB.Text = angleB.ToString("#.##");
            }
        }

        void move_drawPoint()
        {
            //panel1.Visible = false;
            pointDx = L1 * Math.Cos(angleA * 3.14159 / 180);
            pointDy = L1 * Math.Sin(angleA * 3.14159 / 180);

            pointEx = L1 * Math.Cos(angleB * 3.14159 / 180) + d;
            pointEy = L1 * Math.Sin(angleB * 3.14159 / 180);

            m = Math.Sqrt((pointEy - pointDy) * (pointEy - pointDy) + (pointEx - pointDx) * (pointEx - pointDx));

            if (m < (L2 + R2))
            {
                angleD1 = Math.Atan2(pointEy - pointDy, pointEx - pointDx);
                angleD1 = angleD1 * 180 / 3.14;
                angleD2 = Math.Acos((L2 * L2 + m * m - R2 * R2) / (2 * L2 * m));
                angleD2 = angleD2 * 180 / 3.14;

                pointCx = pointDx + L2 * Math.Cos((angleD1 + angleD2) * 3.14 / 180);
                pointCy = pointDy + L2 * Math.Sin((angleD1 + angleD2) * 3.14 / 180);

                pointCx = pointDx + L2 * Math.Cos((angleD1 + angleD2) * 3.14 / 180);
                pointCy = pointDy + L2 * Math.Sin((angleD1 + angleD2) * 3.14 / 180);
            }
            p.Color = Color.Green;
            p.Width = 2;
            g.DrawPie(p, (float)(offsetX + pointCx - 1), (float)(offsetY - pointCy - 1), 2, 2, 0, 360);
            panel1.BackgroundImage = image;

            //panel1.Visible = true;
        }

        void drawCoordinate()
        {
            //panel1.Visible = false;
            g.Clear(Color.White);
            p.Color = Color.Black;
            p.Width = 1;
            g.DrawLine(p, 0, offsetY, 800, offsetY);//x
            g.DrawLine(p, offsetX, 0, offsetX, 700);//y

            p.Color = Color.Cyan;
            p.Width = 2;
            g.DrawLine(p, offsetX + 28, offsetY + 20, offsetX - 55, offsetY + 20);
            g.DrawLine(p, offsetX - 55, offsetY + 20, offsetX - 55, offsetY - 20);
            g.DrawLine(p, offsetX - 55, offsetY - 20, offsetX + 28, offsetY - 20);
            g.DrawLine(p, offsetX + 28, offsetY - 20, offsetX + 28, offsetY + 20);

            p.Color = Color.Navy;
            g.DrawLine(p, offsetX + (float)d  - 28, offsetY + 20, offsetX + (float)d  + 55, offsetY + 20);
            g.DrawLine(p, offsetX + (float)d  + 55, offsetY + 20, offsetX + (float)d  + 55, offsetY - 20);
            g.DrawLine(p, offsetX + (float)d  + 55, offsetY - 20, offsetX + (float)d  - 28, offsetY - 20);
            g.DrawLine(p, offsetX + (float)d  - 28, offsetY - 20, offsetX + (float)d  - 28, offsetY + 20);

            p.Color = Color.Orange;
            p.Width = 2;
            g.DrawPie(p, (float)(offsetX - L1), (float)(offsetY - L1), (float)L1*2, (float)L1*2, 135, 180);
            g.DrawPie(p, (float)(offsetX -R1+d), (float)(offsetY - R1), (float)R1*2, (float)R1*2, 225, 180);
            panel1.BackgroundImage = image;
            //panel1.Visible = true;
        }

        void addCoordinate()
        {
            //panel1.Visible = false;
            //g.Clear(Color.White);
            p.Color = Color.Black;
            p.Width = 1;
            g.DrawLine(p, 0, offsetY, 800, offsetY);//x
            g.DrawLine(p, offsetX, 0, offsetX, 700);//y
            p.Color = Color.Orange;
            p.Width = 2;
            g.DrawPie(p, (float)(offsetX - L1), (float)(offsetY - L1), (float)L1 * 2, (float)L1 * 2, 135, 180);
            g.DrawPie(p, (float)(offsetX - R1 + d), (float)(offsetY - R1), (float)R1 * 2, (float)R1 * 2, 225, 180);
            panel1.BackgroundImage = image;
            //panel1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            label_L2R2.Text = (trackBar_L2R2.Value * 0.4).ToString()+" mm";
            label_L1R1.Text = (trackBar_L1R1.Value * 0.4).ToString() + " mm";
            labeld.Text = (trackBar_d.Value* 0.4 ).ToString()+" mm";
            angleA = trackBarA.Value + minA;
            angleB = trackBarB.Value + minB;
            labelA.Text = trackBarA.Value.ToString();
            labelB.Text = trackBarB.Value.ToString();
            d = trackBar_d.Value;
            L1 = R1 = trackBar_L1R1.Value;
            L2 = R2 = trackBar_L2R2.Value;

            drawCoordinate();
            move();

            timer1.Interval = 100;
            //timer1.Enabled = true;
            timer_paint.Interval = 100;
            //timer_paint.Enabled = true;
            timer_mouse.Interval = 50;
            timer_mouse.Enabled = true;
           

            /*
            drawCoordinate();
            for (angleA = 45; angleA < 45 + 180; angleA += 20)
                for (angleB = -45; angleB < (-45 + 180); angleB += 20)
                    //move_drawPoint();
                    move();
            panel1.Visible = true;
            */

        }
        int delta = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            angleA+=delta;
            if (angleA > 225)
            {
                delta*=-1;
                angleB += 10;
            }
            if(angleA<45)
            {
                delta *=-1;
                angleB += 10;
            }
            if (angleB > 135)
                angleB = -45;
        }

        private void timer_paint_Tick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            drawCoordinate();
            move();
            panel1.Visible = true;
            //panel1.Refresh();
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            angleA = 45 + trackBarA.Value;
            labelA.Text = angleA.ToString();
            if (checkBox1.Checked==false)
            {
                panel1.Visible = false;
                drawCoordinate();
                move();
                panel1.Visible = true;
            }

        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            angleB = -45 + trackBarB.Value;
            labelB.Text = angleB.ToString();
            if (checkBox1.Checked==false)
            {
                panel1.Visible = false;
                drawCoordinate();
                move();
                panel1.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Interval = 100;
                timer1.Enabled = true;
                timer_paint.Interval = 100;
                timer_paint.Enabled = true;
            }
            else
            {
                timer1.Interval = 100;
                timer1.Enabled = false;
                timer_paint.Interval = 100;
                timer_paint.Enabled = false;
            }
        }


        private void trackBar_L1R1_Scroll(object sender, EventArgs e)
        {
            L1 = R1 = trackBar_L1R1.Value;
            label_L1R1.Text = (trackBar_L1R1.Value*0.4).ToString()+" mm";
            if (checkBox_show_change.Checked)
            {
                angleB = -45 + trackBarB.Value;
                angleA = 45 + trackBarA.Value;
                panel1.Visible = false;
                drawCoordinate();
                move();
                panel1.Visible = true;
            }
        }

        private void trackBar_L2R2_Scroll(object sender, EventArgs e)
        {
            L2 = R2 = trackBar_L2R2.Value;
            label_L2R2.Text = (trackBar_L2R2.Value*0.4).ToString() + " mm";
            if (checkBox_show_change.Checked)
            {
                angleB = -45 + trackBarB.Value;
                angleA = 45 + trackBarA.Value;
                panel1.Visible = false;
                drawCoordinate();
                move();
                panel1.Visible = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawCoordinate();
            for (angleA = 45; angleA < 45 + 135; angleA += 5)
                for (angleB = 0; angleB < (0 + 135); angleB += 5)
                    move_drawPoint();
            addCoordinate();
            if (checkBox_show_change.Checked)
            {
                angleB = -45 + trackBarB.Value;
                angleA = 45 + trackBarA.Value;
                panel1.Visible = false;
                move();
                panel1.Visible = true;
            }
            panel1.Visible = true;
            panel1.Refresh();
        }

        private void trackBar_d_Scroll(object sender, EventArgs e)
        {
            d = trackBar_d.Value;
            labeld.Text = (trackBar_d.Value*0.4).ToString() + " mm";
            if (checkBox_show_change.Checked)
            {
                angleB = -45 + trackBarB.Value;
                angleA = 45 + trackBarA.Value;
                panel1.Visible = false;
                drawCoordinate();
                move();
                panel1.Visible = true;
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label_mousePos.Text = MousePosition.ToString();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            label_mousePos.Text = MousePosition.ToString();
        }

        private void timer_mouse_Tick(object sender, EventArgs e)
        {
            label_mousePos.Text = MousePosition.ToString();
            mousepos = panel1.PointToClient(MousePosition);
            mousepos.X = -offsetX + mousepos.X;
            mousepos.Y = offsetY - mousepos.Y;
            label_panelPos.Text =mousepos.ToString()+" /pixel";
            mousepos_mm.X = (int)(mousepos.X * 0.4);
            mousepos_mm.Y = (int)(mousepos.Y * 0.4);
            label_panelPos_mm.Text = mousepos_mm.ToString()+" /mm";
            mousepos_mm.X = mousepos_mm.X + panelOffset.X;
            mousepos_mm.Y = mousepos_mm.Y + panelOffset.Y;
            label_panel_real.Text = mousepos_mm.ToString() + " /mm";
        }

        private void label_panelPos_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_show_change_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_change.Checked)
            {
                angleB = -45 + trackBarB.Value;
                angleA = 45 + trackBarA.Value;
                panel1.Visible = false;
                drawCoordinate();
                move();
                panel1.Visible = true;
            }
        }

        private void textBox_input_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (e.KeyChar == (char)13)
            {
                string[] nums = textBox_input.Text.Split(',',' ');
                targetPointX = Convert.ToDouble(nums[0]);
                targetPointY = Convert.ToDouble(nums[1]);
                label_goto.Text = targetPointX.ToString() + ',' + targetPointY.ToString();
                drawCoordinate();
                //setPoint(targetPointX - panelOffset.X, targetPointY - panelOffset.Y);
                setPoint(targetPointX, targetPointY);
                move();
                //move_drawPoint();
                panel1.Refresh();
                textBox_input.Clear();
            }
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = 0;

            lastX = 12 - panelOffset.X;
            lastY = 6 - panelOffset.Y;
            drawTo(12 - panelOffset.X + pos, 6 - panelOffset.Y);
            bogenUZS(7 - panelOffset.X + pos, 10 - panelOffset.Y, 10, 6.7, -0.8, 0.5);
            
            pos += 12;
            lastX = 3 - panelOffset.X + pos;
            lastY = 5 - panelOffset.Y;
            drawTo(3 - panelOffset.X+pos, 5 - panelOffset.Y);
            drawTo(10 - panelOffset.X + pos, 20 - panelOffset.Y);
            drawTo(10 - panelOffset.X + pos, 0 - panelOffset.Y);

            pos += 12;
            lastX = 2 - panelOffset.X + pos;
            lastY = 12 - panelOffset.Y;
            drawTo(2 - panelOffset.X + pos, 12 - panelOffset.Y);
            bogenUZS(8 - panelOffset.X + pos, 14 - panelOffset.Y, 6, 3, -0.8, 1);
            drawTo(1 - panelOffset.X + pos, 0 - panelOffset.Y);
            drawTo(12 - panelOffset.X + pos, 0 - panelOffset.Y);
            
            panel1.Refresh();
        }

        private void timer_test_Tick(object sender, EventArgs e)
        {

        }




        




    }
}
