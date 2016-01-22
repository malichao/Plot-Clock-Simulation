namespace Plot_Clock_Simulation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_paint = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.trackBar_L1R1 = new System.Windows.Forms.TrackBar();
            this.label_L1R1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_L2R2 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label_L2R2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_show_change = new System.Windows.Forms.CheckBox();
            this.trackBar_d = new System.Windows.Forms.TrackBar();
            this.label_d = new System.Windows.Forms.Label();
            this.labeld = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_point = new System.Windows.Forms.TextBox();
            this.textBox_error = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_mousePos = new System.Windows.Forms.Label();
            this.timer_mouse = new System.Windows.Forms.Timer(this.components);
            this.label_panelPos = new System.Windows.Forms.Label();
            this.label_panelPos_mm = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_goto = new System.Windows.Forms.Label();
            this.text_angleA = new System.Windows.Forms.Label();
            this.text_angleB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label_panel_real = new System.Windows.Forms.Label();
            this.timer_test = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_L1R1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_L2R2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_d)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(19, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 600);
            this.panel1.TabIndex = 0;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_paint
            // 
            this.timer_paint.Tick += new System.EventHandler(this.timer_paint_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 615);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(173, 631);
            this.trackBarA.Maximum = 180;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(134, 45);
            this.trackBarA.TabIndex = 2;
            this.trackBarA.TickFrequency = 18;
            this.trackBarA.Value = 45;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(173, 677);
            this.trackBarB.Maximum = 180;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(134, 45);
            this.trackBarB.TabIndex = 3;
            this.trackBarB.TickFrequency = 18;
            this.trackBarB.Value = 135;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "angleA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 664);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "angleB:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(234, 616);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(11, 12);
            this.labelA.TabIndex = 6;
            this.labelA.Text = "0";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(234, 664);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(11, 12);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "0";
            // 
            // trackBar_L1R1
            // 
            this.trackBar_L1R1.Location = new System.Drawing.Point(334, 630);
            this.trackBar_L1R1.Maximum = 200;
            this.trackBar_L1R1.Minimum = 50;
            this.trackBar_L1R1.Name = "trackBar_L1R1";
            this.trackBar_L1R1.Size = new System.Drawing.Size(134, 45);
            this.trackBar_L1R1.TabIndex = 13;
            this.trackBar_L1R1.TickFrequency = 25;
            this.trackBar_L1R1.Value = 87;
            this.trackBar_L1R1.Scroll += new System.EventHandler(this.trackBar_L1R1_Scroll);
            // 
            // label_L1R1
            // 
            this.label_L1R1.AutoSize = true;
            this.label_L1R1.Location = new System.Drawing.Point(396, 615);
            this.label_L1R1.Name = "label_L1R1";
            this.label_L1R1.Size = new System.Drawing.Size(11, 12);
            this.label_L1R1.TabIndex = 15;
            this.label_L1R1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "L1 R1:";
            // 
            // trackBar_L2R2
            // 
            this.trackBar_L2R2.Location = new System.Drawing.Point(505, 631);
            this.trackBar_L2R2.Maximum = 200;
            this.trackBar_L2R2.Minimum = 50;
            this.trackBar_L2R2.Name = "trackBar_L2R2";
            this.trackBar_L2R2.Size = new System.Drawing.Size(134, 45);
            this.trackBar_L2R2.TabIndex = 13;
            this.trackBar_L2R2.TickFrequency = 25;
            this.trackBar_L2R2.Value = 113;
            this.trackBar_L2R2.Scroll += new System.EventHandler(this.trackBar_L2R2_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "L2 R2:";
            // 
            // label_L2R2
            // 
            this.label_L2R2.AutoSize = true;
            this.label_L2R2.Location = new System.Drawing.Point(567, 616);
            this.label_L2R2.Name = "label_L2R2";
            this.label_L2R2.Size = new System.Drawing.Size(11, 12);
            this.label_L2R2.TabIndex = 15;
            this.label_L2R2.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 678);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "calc area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_show_change
            // 
            this.checkBox_show_change.AutoSize = true;
            this.checkBox_show_change.Checked = true;
            this.checkBox_show_change.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_show_change.Location = new System.Drawing.Point(570, 682);
            this.checkBox_show_change.Name = "checkBox_show_change";
            this.checkBox_show_change.Size = new System.Drawing.Size(90, 16);
            this.checkBox_show_change.TabIndex = 17;
            this.checkBox_show_change.Text = "show change";
            this.checkBox_show_change.UseVisualStyleBackColor = true;
            this.checkBox_show_change.CheckedChanged += new System.EventHandler(this.checkBox_show_change_CheckedChanged);
            // 
            // trackBar_d
            // 
            this.trackBar_d.Location = new System.Drawing.Point(334, 674);
            this.trackBar_d.Maximum = 250;
            this.trackBar_d.Name = "trackBar_d";
            this.trackBar_d.Size = new System.Drawing.Size(134, 45);
            this.trackBar_d.TabIndex = 13;
            this.trackBar_d.TickFrequency = 25;
            this.trackBar_d.Value = 65;
            this.trackBar_d.Scroll += new System.EventHandler(this.trackBar_d_Scroll);
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(343, 659);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(17, 12);
            this.label_d.TabIndex = 14;
            this.label_d.Text = "d:";
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Location = new System.Drawing.Point(396, 659);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(11, 12);
            this.labeld.TabIndex = 15;
            this.labeld.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "Point:";
            // 
            // textbox_point
            // 
            this.textbox_point.Location = new System.Drawing.Point(61, 649);
            this.textbox_point.Name = "textbox_point";
            this.textbox_point.Size = new System.Drawing.Size(106, 21);
            this.textbox_point.TabIndex = 19;
            // 
            // textBox_error
            // 
            this.textBox_error.Location = new System.Drawing.Point(61, 682);
            this.textBox_error.Name = "textBox_error";
            this.textBox_error.Size = new System.Drawing.Size(53, 21);
            this.textBox_error.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 687);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Error:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(940, 631);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "mouse:";
            // 
            // label_mousePos
            // 
            this.label_mousePos.AutoSize = true;
            this.label_mousePos.Location = new System.Drawing.Point(991, 631);
            this.label_mousePos.Name = "label_mousePos";
            this.label_mousePos.Size = new System.Drawing.Size(23, 12);
            this.label_mousePos.TabIndex = 24;
            this.label_mousePos.Text = "0,0";
            // 
            // timer_mouse
            // 
            this.timer_mouse.Tick += new System.EventHandler(this.timer_mouse_Tick);
            // 
            // label_panelPos
            // 
            this.label_panelPos.AutoSize = true;
            this.label_panelPos.Location = new System.Drawing.Point(991, 653);
            this.label_panelPos.Name = "label_panelPos";
            this.label_panelPos.Size = new System.Drawing.Size(23, 12);
            this.label_panelPos.TabIndex = 25;
            this.label_panelPos.Text = "0,0";
            this.label_panelPos.Click += new System.EventHandler(this.label_panelPos_Click);
            // 
            // label_panelPos_mm
            // 
            this.label_panelPos_mm.AutoSize = true;
            this.label_panelPos_mm.Location = new System.Drawing.Point(991, 672);
            this.label_panelPos_mm.Name = "label_panelPos_mm";
            this.label_panelPos_mm.Size = new System.Drawing.Size(23, 12);
            this.label_panelPos_mm.TabIndex = 26;
            this.label_panelPos_mm.Text = "0,0";
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(713, 645);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(100, 21);
            this.textBox_input.TabIndex = 27;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            this.textBox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_input_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(711, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "Input:";
            // 
            // label_goto
            // 
            this.label_goto.AutoSize = true;
            this.label_goto.Location = new System.Drawing.Point(765, 616);
            this.label_goto.Name = "label_goto";
            this.label_goto.Size = new System.Drawing.Size(35, 12);
            this.label_goto.TabIndex = 29;
            this.label_goto.Text = "Input";
            // 
            // text_angleA
            // 
            this.text_angleA.AutoSize = true;
            this.text_angleA.Location = new System.Drawing.Point(754, 669);
            this.text_angleA.Name = "text_angleA";
            this.text_angleA.Size = new System.Drawing.Size(11, 12);
            this.text_angleA.TabIndex = 30;
            this.text_angleA.Text = "0";
            // 
            // text_angleB
            // 
            this.text_angleB.AutoSize = true;
            this.text_angleB.Location = new System.Drawing.Point(754, 687);
            this.text_angleB.Name = "text_angleB";
            this.text_angleB.Size = new System.Drawing.Size(11, 12);
            this.text_angleB.TabIndex = 31;
            this.text_angleB.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 669);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "angleA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(711, 686);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "angleB";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(840, 696);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_panel_real
            // 
            this.label_panel_real.AutoSize = true;
            this.label_panel_real.Location = new System.Drawing.Point(991, 691);
            this.label_panel_real.Name = "label_panel_real";
            this.label_panel_real.Size = new System.Drawing.Size(23, 12);
            this.label_panel_real.TabIndex = 34;
            this.label_panel_real.Text = "0,0";
            // 
            // timer_test
            // 
            this.timer_test.Tick += new System.EventHandler(this.timer_test_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1234, 742);
            this.Controls.Add(this.label_panel_real);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_angleB);
            this.Controls.Add(this.text_angleA);
            this.Controls.Add(this.label_goto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label_panelPos_mm);
            this.Controls.Add(this.trackBar_d);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.checkBox_show_change);
            this.Controls.Add(this.labeld);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_L2R2);
            this.Controls.Add(this.label_L1R1);
            this.Controls.Add(this.trackBar_L2R2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbox_point);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_panelPos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar_L1R1);
            this.Controls.Add(this.label_mousePos);
            this.Controls.Add(this.textBox_error);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plot Clock Simulation2  -Malc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_L1R1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_L2R2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_d)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_paint;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TrackBar trackBar_L1R1;
        private System.Windows.Forms.Label label_L1R1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_L2R2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_L2R2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_show_change;
        private System.Windows.Forms.TrackBar trackBar_d;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_point;
        private System.Windows.Forms.TextBox textBox_error;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_mousePos;
        private System.Windows.Forms.Timer timer_mouse;
        private System.Windows.Forms.Label label_panelPos;
        private System.Windows.Forms.Label label_panelPos_mm;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_goto;
        private System.Windows.Forms.Label text_angleA;
        private System.Windows.Forms.Label text_angleB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_panel_real;
        private System.Windows.Forms.Timer timer_test;
    }
}

