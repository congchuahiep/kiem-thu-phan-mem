namespace QuanLyDiemHocSinh_Test_54_Hiep
{
    partial class FormMain_54_Hiep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxHocSinh_54_Hiep = new System.Windows.Forms.GroupBox();
            this.buttonAddStudent_54_Hiep = new System.Windows.Forms.Button();
            this.listBoxStudent_54_Hiep = new System.Windows.Forms.ListBox();
            this.groupBoxDetailStudent_54_Hiep = new System.Windows.Forms.GroupBox();
            this.labelStudentId_54_Hiep = new System.Windows.Forms.Label();
            this.labelStudentName_54_Hiep = new System.Windows.Forms.Label();
            this.textBoxStudentId_54_Hiep = new System.Windows.Forms.TextBox();
            this.textBoxStudentName_54_Hiep = new System.Windows.Forms.TextBox();
            this.buttonUpdateStudent_54_Hiep = new System.Windows.Forms.Button();
            this.buttonDeleteStudent_54_Hiep = new System.Windows.Forms.Button();
            this.groupBoxHocSinh_54_Hiep.SuspendLayout();
            this.groupBoxDetailStudent_54_Hiep.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHocSinh_54_Hiep
            // 
            this.groupBoxHocSinh_54_Hiep.Controls.Add(this.buttonAddStudent_54_Hiep);
            this.groupBoxHocSinh_54_Hiep.Controls.Add(this.listBoxStudent_54_Hiep);
            this.groupBoxHocSinh_54_Hiep.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHocSinh_54_Hiep.Name = "groupBoxHocSinh_54_Hiep";
            this.groupBoxHocSinh_54_Hiep.Size = new System.Drawing.Size(314, 385);
            this.groupBoxHocSinh_54_Hiep.TabIndex = 1;
            this.groupBoxHocSinh_54_Hiep.TabStop = false;
            this.groupBoxHocSinh_54_Hiep.Text = "Danh sách học sinh";
            // 
            // buttonAddStudent_54_Hiep
            // 
            this.buttonAddStudent_54_Hiep.Location = new System.Drawing.Point(6, 335);
            this.buttonAddStudent_54_Hiep.Name = "buttonAddStudent_54_Hiep";
            this.buttonAddStudent_54_Hiep.Size = new System.Drawing.Size(302, 44);
            this.buttonAddStudent_54_Hiep.TabIndex = 2;
            this.buttonAddStudent_54_Hiep.Text = "Thêm học sinh";
            this.buttonAddStudent_54_Hiep.UseVisualStyleBackColor = true;
            this.buttonAddStudent_54_Hiep.Click += new System.EventHandler(this.buttonAddStudent_54_Hiep_Click);
            // 
            // listBoxStudent_54_Hiep
            // 
            this.listBoxStudent_54_Hiep.FormattingEnabled = true;
            this.listBoxStudent_54_Hiep.ItemHeight = 20;
            this.listBoxStudent_54_Hiep.Location = new System.Drawing.Point(6, 25);
            this.listBoxStudent_54_Hiep.Name = "listBoxStudent_54_Hiep";
            this.listBoxStudent_54_Hiep.Size = new System.Drawing.Size(302, 304);
            this.listBoxStudent_54_Hiep.TabIndex = 1;
            this.listBoxStudent_54_Hiep.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_54_Hiep_SelectedIndexChanged);
            // 
            // groupBoxDetailStudent_54_Hiep
            // 
            this.groupBoxDetailStudent_54_Hiep.Controls.Add(this.buttonDeleteStudent_54_Hiep);
            this.groupBoxDetailStudent_54_Hiep.Controls.Add(this.buttonUpdateStudent_54_Hiep);
            this.groupBoxDetailStudent_54_Hiep.Controls.Add(this.textBoxStudentName_54_Hiep);
            this.groupBoxDetailStudent_54_Hiep.Controls.Add(this.textBoxStudentId_54_Hiep);
            this.groupBoxDetailStudent_54_Hiep.Controls.Add(this.labelStudentName_54_Hiep);
            this.groupBoxDetailStudent_54_Hiep.Controls.Add(this.labelStudentId_54_Hiep);
            this.groupBoxDetailStudent_54_Hiep.Location = new System.Drawing.Point(349, 12);
            this.groupBoxDetailStudent_54_Hiep.Name = "groupBoxDetailStudent_54_Hiep";
            this.groupBoxDetailStudent_54_Hiep.Size = new System.Drawing.Size(314, 385);
            this.groupBoxDetailStudent_54_Hiep.TabIndex = 2;
            this.groupBoxDetailStudent_54_Hiep.TabStop = false;
            this.groupBoxDetailStudent_54_Hiep.Text = "Thông tin học sinh";
            // 
            // labelStudentId_54_Hiep
            // 
            this.labelStudentId_54_Hiep.AutoSize = true;
            this.labelStudentId_54_Hiep.Location = new System.Drawing.Point(19, 41);
            this.labelStudentId_54_Hiep.Name = "labelStudentId_54_Hiep";
            this.labelStudentId_54_Hiep.Size = new System.Drawing.Size(94, 20);
            this.labelStudentId_54_Hiep.TabIndex = 0;
            this.labelStudentId_54_Hiep.Text = "Mã học sinh";
            // 
            // labelStudentName_54_Hiep
            // 
            this.labelStudentName_54_Hiep.AutoSize = true;
            this.labelStudentName_54_Hiep.Location = new System.Drawing.Point(19, 123);
            this.labelStudentName_54_Hiep.Name = "labelStudentName_54_Hiep";
            this.labelStudentName_54_Hiep.Size = new System.Drawing.Size(99, 20);
            this.labelStudentName_54_Hiep.TabIndex = 1;
            this.labelStudentName_54_Hiep.Text = "Tên học sinh";
            // 
            // textBoxStudentId_54_Hiep
            // 
            this.textBoxStudentId_54_Hiep.Enabled = false;
            this.textBoxStudentId_54_Hiep.Location = new System.Drawing.Point(23, 64);
            this.textBoxStudentId_54_Hiep.Name = "textBoxStudentId_54_Hiep";
            this.textBoxStudentId_54_Hiep.Size = new System.Drawing.Size(269, 26);
            this.textBoxStudentId_54_Hiep.TabIndex = 2;
            // 
            // textBoxStudentName_54_Hiep
            // 
            this.textBoxStudentName_54_Hiep.Enabled = false;
            this.textBoxStudentName_54_Hiep.Location = new System.Drawing.Point(23, 146);
            this.textBoxStudentName_54_Hiep.Name = "textBoxStudentName_54_Hiep";
            this.textBoxStudentName_54_Hiep.Size = new System.Drawing.Size(269, 26);
            this.textBoxStudentName_54_Hiep.TabIndex = 3;
            // 
            // buttonUpdateStudent_54_Hiep
            // 
            this.buttonUpdateStudent_54_Hiep.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonUpdateStudent_54_Hiep.Enabled = false;
            this.buttonUpdateStudent_54_Hiep.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonUpdateStudent_54_Hiep.Location = new System.Drawing.Point(6, 335);
            this.buttonUpdateStudent_54_Hiep.Name = "buttonUpdateStudent_54_Hiep";
            this.buttonUpdateStudent_54_Hiep.Size = new System.Drawing.Size(302, 44);
            this.buttonUpdateStudent_54_Hiep.TabIndex = 3;
            this.buttonUpdateStudent_54_Hiep.Text = "Cập nhật học sinh";
            this.buttonUpdateStudent_54_Hiep.UseVisualStyleBackColor = false;
            this.buttonUpdateStudent_54_Hiep.Click += new System.EventHandler(this.buttonUpdateStudent_54_Hiep_Click);
            // 
            // buttonDeleteStudent_54_Hiep
            // 
            this.buttonDeleteStudent_54_Hiep.BackColor = System.Drawing.Color.MistyRose;
            this.buttonDeleteStudent_54_Hiep.Enabled = false;
            this.buttonDeleteStudent_54_Hiep.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonDeleteStudent_54_Hiep.Location = new System.Drawing.Point(6, 285);
            this.buttonDeleteStudent_54_Hiep.Name = "buttonDeleteStudent_54_Hiep";
            this.buttonDeleteStudent_54_Hiep.Size = new System.Drawing.Size(302, 44);
            this.buttonDeleteStudent_54_Hiep.TabIndex = 4;
            this.buttonDeleteStudent_54_Hiep.Text = "Xoá học sinh";
            this.buttonDeleteStudent_54_Hiep.UseVisualStyleBackColor = false;
            this.buttonDeleteStudent_54_Hiep.Click += new System.EventHandler(this.buttonDeleteStudent_54_Hiep_Click);
            // 
            // FormMain_54_Hiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 864);
            this.Controls.Add(this.groupBoxDetailStudent_54_Hiep);
            this.Controls.Add(this.groupBoxHocSinh_54_Hiep);
            this.Name = "FormMain_54_Hiep";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_54_Hiep_Load);
            this.groupBoxHocSinh_54_Hiep.ResumeLayout(false);
            this.groupBoxDetailStudent_54_Hiep.ResumeLayout(false);
            this.groupBoxDetailStudent_54_Hiep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxHocSinh_54_Hiep;
        private System.Windows.Forms.ListBox listBoxStudent_54_Hiep;
        private System.Windows.Forms.Button buttonAddStudent_54_Hiep;
        private System.Windows.Forms.GroupBox groupBoxDetailStudent_54_Hiep;
        private System.Windows.Forms.TextBox textBoxStudentName_54_Hiep;
        private System.Windows.Forms.TextBox textBoxStudentId_54_Hiep;
        private System.Windows.Forms.Label labelStudentName_54_Hiep;
        private System.Windows.Forms.Label labelStudentId_54_Hiep;
        private System.Windows.Forms.Button buttonDeleteStudent_54_Hiep;
        private System.Windows.Forms.Button buttonUpdateStudent_54_Hiep;
    }
}

