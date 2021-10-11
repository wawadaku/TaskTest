namespace WindowsFormsApp1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_XuanZhuan = new System.Windows.Forms.Button();
            this.btn_CloseJiazhua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PortName = new System.Windows.Forms.TextBox();
            this.txt_BaudRate = new System.Windows.Forms.TextBox();
            this.btn_XuanZ3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_OpenJiaZ1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_XSpeed = new System.Windows.Forms.TextBox();
            this.txt_XDegrees = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_JSpeed = new System.Windows.Forms.TextBox();
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_FX = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Loc = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btn_Setaa = new System.Windows.Forms.Button();
            this.txt_sLocaa = new System.Windows.Forms.TextBox();
            this.txt_sSpeedaa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nLocaa = new System.Windows.Forms.TextBox();
            this.txt_nSpeedaa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "初始化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 21);
            this.textBox1.TabIndex = 3;
            // 
            // btn_XuanZhuan
            // 
            this.btn_XuanZhuan.Location = new System.Drawing.Point(256, 16);
            this.btn_XuanZhuan.Name = "btn_XuanZhuan";
            this.btn_XuanZhuan.Size = new System.Drawing.Size(75, 23);
            this.btn_XuanZhuan.TabIndex = 5;
            this.btn_XuanZhuan.Text = "夹爪复位";
            this.btn_XuanZhuan.UseVisualStyleBackColor = true;
            this.btn_XuanZhuan.Click += new System.EventHandler(this.btn_XuanZhuan_Click);
            // 
            // btn_CloseJiazhua
            // 
            this.btn_CloseJiazhua.Location = new System.Drawing.Point(479, 217);
            this.btn_CloseJiazhua.Name = "btn_CloseJiazhua";
            this.btn_CloseJiazhua.Size = new System.Drawing.Size(109, 34);
            this.btn_CloseJiazhua.TabIndex = 7;
            this.btn_CloseJiazhua.Tag = "打开";
            this.btn_CloseJiazhua.Text = "夹爪关闭速度10";
            this.btn_CloseJiazhua.UseVisualStyleBackColor = true;
            this.btn_CloseJiazhua.Click += new System.EventHandler(this.btn_CloseJiazhua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "波特率：";
            // 
            // txt_PortName
            // 
            this.txt_PortName.Location = new System.Drawing.Point(115, 55);
            this.txt_PortName.Name = "txt_PortName";
            this.txt_PortName.Size = new System.Drawing.Size(67, 21);
            this.txt_PortName.TabIndex = 3;
            this.txt_PortName.Text = "COM3";
            // 
            // txt_BaudRate
            // 
            this.txt_BaudRate.Location = new System.Drawing.Point(115, 79);
            this.txt_BaudRate.Name = "txt_BaudRate";
            this.txt_BaudRate.Size = new System.Drawing.Size(67, 21);
            this.txt_BaudRate.TabIndex = 3;
            this.txt_BaudRate.Text = "115200";
            // 
            // btn_XuanZ3
            // 
            this.btn_XuanZ3.Location = new System.Drawing.Point(479, 51);
            this.btn_XuanZ3.Name = "btn_XuanZ3";
            this.btn_XuanZ3.Size = new System.Drawing.Size(109, 47);
            this.btn_XuanZ3.TabIndex = 9;
            this.btn_XuanZ3.Text = "开盖（速度20）";
            this.btn_XuanZ3.UseVisualStyleBackColor = true;
            this.btn_XuanZ3.Click += new System.EventHandler(this.btn_XuanZ3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "拧盖（速度20）  旋转720度";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_OpenJiaZ1
            // 
            this.btn_OpenJiaZ1.Location = new System.Drawing.Point(602, 217);
            this.btn_OpenJiaZ1.Name = "btn_OpenJiaZ1";
            this.btn_OpenJiaZ1.Size = new System.Drawing.Size(109, 34);
            this.btn_OpenJiaZ1.TabIndex = 7;
            this.btn_OpenJiaZ1.Tag = "关闭";
            this.btn_OpenJiaZ1.Text = "夹爪打开速度10";
            this.btn_OpenJiaZ1.UseVisualStyleBackColor = true;
            this.btn_OpenJiaZ1.Click += new System.EventHandler(this.btn_OpenJiaZ1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "状态：";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "开盖（速度60）";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(602, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 47);
            this.button4.TabIndex = 10;
            this.button4.Text = "拧盖（速度60） 旋转540度";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(479, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 47);
            this.button5.TabIndex = 10;
            this.button5.Text = "开盖（速度100）";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(602, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 47);
            this.button6.TabIndex = 10;
            this.button6.Text = "拧盖（速度100）  旋转180度";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(479, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 47);
            this.button7.TabIndex = 10;
            this.button7.Text = "开盖（速度10）";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(602, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 47);
            this.button8.TabIndex = 10;
            this.button8.Text = "拧盖（速度10）  旋转360度";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(479, 253);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 34);
            this.button9.TabIndex = 11;
            this.button9.Text = "夹爪关闭速度20";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(602, 253);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 34);
            this.button10.TabIndex = 11;
            this.button10.Text = "夹爪打开速度20";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(479, 289);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(109, 34);
            this.button11.TabIndex = 11;
            this.button11.Text = "夹爪关闭速度60";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(602, 289);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 34);
            this.button12.TabIndex = 11;
            this.button12.Text = "夹爪打开速度60";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(479, 325);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(109, 34);
            this.button13.TabIndex = 11;
            this.button13.Text = "夹爪关闭速度100";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(602, 325);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(109, 34);
            this.button14.TabIndex = 11;
            this.button14.Text = "夹爪打开速度100";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(171, 430);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 12;
            this.button15.Text = "计算";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 430);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 13;
            // 
            // txt_XSpeed
            // 
            this.txt_XSpeed.Location = new System.Drawing.Point(88, 486);
            this.txt_XSpeed.Name = "txt_XSpeed";
            this.txt_XSpeed.Size = new System.Drawing.Size(94, 21);
            this.txt_XSpeed.TabIndex = 14;
            this.txt_XSpeed.Text = "100";
            // 
            // txt_XDegrees
            // 
            this.txt_XDegrees.Location = new System.Drawing.Point(88, 459);
            this.txt_XDegrees.Name = "txt_XDegrees";
            this.txt_XDegrees.Size = new System.Drawing.Size(94, 21);
            this.txt_XDegrees.TabIndex = 14;
            this.txt_XDegrees.Text = "360";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "旋转度数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "旋转速度：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "夹爪速度：";
            // 
            // txt_JSpeed
            // 
            this.txt_JSpeed.Location = new System.Drawing.Point(88, 556);
            this.txt_JSpeed.Name = "txt_JSpeed";
            this.txt_JSpeed.Size = new System.Drawing.Size(94, 21);
            this.txt_JSpeed.TabIndex = 14;
            this.txt_JSpeed.Text = "100";
            // 
            // btn_X
            // 
            this.btn_X.Location = new System.Drawing.Point(225, 486);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(75, 23);
            this.btn_X.TabIndex = 15;
            this.btn_X.Tag = "2";
            this.btn_X.Text = "旋转";
            this.btn_X.UseVisualStyleBackColor = true;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // btn_FX
            // 
            this.btn_FX.Location = new System.Drawing.Point(306, 486);
            this.btn_FX.Name = "btn_FX";
            this.btn_FX.Size = new System.Drawing.Size(75, 23);
            this.btn_FX.TabIndex = 15;
            this.btn_FX.Tag = "1";
            this.btn_FX.Text = "反旋";
            this.btn_FX.UseVisualStyleBackColor = true;
            this.btn_FX.Click += new System.EventHandler(this.btn_FX_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(225, 540);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 15;
            this.btn_Open.Tag = "1";
            this.btn_Open.Text = "打开";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(306, 540);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Tag = "2";
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "夹爪位置：";
            // 
            // txt_Loc
            // 
            this.txt_Loc.Location = new System.Drawing.Point(87, 529);
            this.txt_Loc.Name = "txt_Loc";
            this.txt_Loc.Size = new System.Drawing.Size(94, 21);
            this.txt_Loc.TabIndex = 14;
            this.txt_Loc.Text = "150";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(87, 191);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 16;
            this.button16.Text = "逆时针";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(186, 192);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 17;
            this.button17.Text = "顺时针";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // btn_Setaa
            // 
            this.btn_Setaa.Location = new System.Drawing.Point(195, 309);
            this.btn_Setaa.Name = "btn_Setaa";
            this.btn_Setaa.Size = new System.Drawing.Size(75, 23);
            this.btn_Setaa.TabIndex = 18;
            this.btn_Setaa.Text = "设置";
            this.btn_Setaa.UseVisualStyleBackColor = true;
            this.btn_Setaa.Click += new System.EventHandler(this.btn_Setaa_Click);
            // 
            // txt_sLocaa
            // 
            this.txt_sLocaa.Location = new System.Drawing.Point(103, 261);
            this.txt_sLocaa.Name = "txt_sLocaa";
            this.txt_sLocaa.Size = new System.Drawing.Size(51, 21);
            this.txt_sLocaa.TabIndex = 19;
            // 
            // txt_sSpeedaa
            // 
            this.txt_sSpeedaa.Location = new System.Drawing.Point(103, 289);
            this.txt_sSpeedaa.Name = "txt_sSpeedaa";
            this.txt_sSpeedaa.Size = new System.Drawing.Size(51, 21);
            this.txt_sSpeedaa.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "顺时针速度：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "顺时针度数：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "逆时针速度：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "逆时针度数：";
            // 
            // txt_nLocaa
            // 
            this.txt_nLocaa.Location = new System.Drawing.Point(103, 331);
            this.txt_nLocaa.Name = "txt_nLocaa";
            this.txt_nLocaa.Size = new System.Drawing.Size(51, 21);
            this.txt_nLocaa.TabIndex = 19;
            // 
            // txt_nSpeedaa
            // 
            this.txt_nSpeedaa.Location = new System.Drawing.Point(103, 359);
            this.txt_nSpeedaa.Name = "txt_nSpeedaa";
            this.txt_nSpeedaa.Size = new System.Drawing.Size(51, 21);
            this.txt_nSpeedaa.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.txt_nSpeedaa);
            this.Controls.Add(this.txt_sSpeedaa);
            this.Controls.Add(this.txt_nLocaa);
            this.Controls.Add(this.txt_sLocaa);
            this.Controls.Add(this.btn_Setaa);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_FX);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.txt_Loc);
            this.Controls.Add(this.txt_JSpeed);
            this.Controls.Add(this.txt_XDegrees);
            this.Controls.Add(this.txt_XSpeed);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_XuanZ3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_OpenJiaZ1);
            this.Controls.Add(this.btn_CloseJiazhua);
            this.Controls.Add(this.btn_XuanZhuan);
            this.Controls.Add(this.txt_BaudRate);
            this.Controls.Add(this.txt_PortName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "旋转电爪测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_XuanZhuan;
        private System.Windows.Forms.Button btn_CloseJiazhua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PortName;
        private System.Windows.Forms.TextBox txt_BaudRate;
        private System.Windows.Forms.Button btn_XuanZ3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_OpenJiaZ1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_XSpeed;
        private System.Windows.Forms.TextBox txt_XDegrees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_JSpeed;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_FX;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Loc;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btn_Setaa;
        private System.Windows.Forms.TextBox txt_sLocaa;
        private System.Windows.Forms.TextBox txt_sSpeedaa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nLocaa;
        private System.Windows.Forms.TextBox txt_nSpeedaa;
    }
}

