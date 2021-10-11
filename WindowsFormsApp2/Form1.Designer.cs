
namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.com_Parts = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_Z = new System.Windows.Forms.NumericUpDown();
            this.num_Y = new System.Windows.Forms.NumericUpDown();
            this.num_X = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Z = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.com_Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.com_Mode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // com_Parts
            // 
            this.com_Parts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Parts.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.com_Parts.FormattingEnabled = true;
            this.com_Parts.Location = new System.Drawing.Point(307, 23);
            this.com_Parts.Name = "com_Parts";
            this.com_Parts.Size = new System.Drawing.Size(193, 27);
            this.com_Parts.TabIndex = 0;
            this.com_Parts.SelectedIndexChanged += new System.EventHandler(this.com_Parts_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(325, 56);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(69, 26);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(215, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "部件名称：";
            // 
            // txt_X
            // 
            this.txt_X.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_X.Location = new System.Drawing.Point(89, 30);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(63, 29);
            this.txt_X.TabIndex = 3;
            this.txt_X.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_Z);
            this.groupBox1.Controls.Add(this.num_Y);
            this.groupBox1.Controls.Add(this.num_X);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_Z);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Y);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_X);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "位置调整";
            // 
            // num_Z
            // 
            this.num_Z.DecimalPlaces = 1;
            this.num_Z.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Z.Location = new System.Drawing.Point(199, 122);
            this.num_Z.Name = "num_Z";
            this.num_Z.Size = new System.Drawing.Size(57, 21);
            this.num_Z.TabIndex = 7;
            this.num_Z.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // num_Y
            // 
            this.num_Y.DecimalPlaces = 1;
            this.num_Y.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Y.Location = new System.Drawing.Point(199, 78);
            this.num_Y.Name = "num_Y";
            this.num_Y.Size = new System.Drawing.Size(57, 21);
            this.num_Y.TabIndex = 6;
            this.num_Y.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // num_X
            // 
            this.num_X.DecimalPlaces = 1;
            this.num_X.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_X.Location = new System.Drawing.Point(199, 32);
            this.num_X.Name = "num_X";
            this.num_X.Size = new System.Drawing.Size(57, 21);
            this.num_X.TabIndex = 5;
            this.num_X.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(262, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "▼";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(153, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "▲";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "▼";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "▲";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(262, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "▶";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(153, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "◀";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Z
            // 
            this.txt_Z.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Z.Location = new System.Drawing.Point(89, 119);
            this.txt_Z.Name = "txt_Z";
            this.txt_Z.Size = new System.Drawing.Size(63, 29);
            this.txt_Z.TabIndex = 3;
            this.txt_Z.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Z坐标：";
            // 
            // txt_Y
            // 
            this.txt_Y.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Y.Location = new System.Drawing.Point(89, 73);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(63, 29);
            this.txt_Y.TabIndex = 3;
            this.txt_Y.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(11, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y坐标：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "X坐标：";
            // 
            // com_Type
            // 
            this.com_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Type.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.com_Type.FormattingEnabled = true;
            this.com_Type.Items.AddRange(new object[] {
            "移液器",
            "旋转电爪"});
            this.com_Type.Location = new System.Drawing.Point(110, 22);
            this.com_Type.Name = "com_Type";
            this.com_Type.Size = new System.Drawing.Size(101, 27);
            this.com_Type.TabIndex = 0;
            this.com_Type.SelectedIndexChanged += new System.EventHandler(this.com_Type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "部件类型：";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(719, 16);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(79, 38);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "开始校准";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // com_Mode
            // 
            this.com_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Mode.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.com_Mode.FormattingEnabled = true;
            this.com_Mode.Items.AddRange(new object[] {
            "移液器",
            "旋转电爪"});
            this.com_Mode.Location = new System.Drawing.Point(596, 23);
            this.com_Mode.Name = "com_Mode";
            this.com_Mode.Size = new System.Drawing.Size(99, 27);
            this.com_Mode.TabIndex = 0;
            this.com_Mode.SelectedIndexChanged += new System.EventHandler(this.com_Type_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(505, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "校准方式：";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "init.png");
            this.imageList1.Images.SetKeyName(1, "do.png");
            this.imageList1.Images.SetKeyName(2, "del.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(339, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(459, 79);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(21, 250);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(320, 156);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.TabStop = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Location = new System.Drawing.Point(378, 250);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView3.Size = new System.Drawing.Size(317, 156);
            this.dataGridView3.TabIndex = 8;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(717, 342);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 440);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.com_Mode);
            this.Controls.Add(this.com_Parts);
            this.Controls.Add(this.com_Type);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_Parts;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox com_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown num_X;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ComboBox com_Mode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_Z;
        private System.Windows.Forms.NumericUpDown num_Y;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button7;
    }
}

