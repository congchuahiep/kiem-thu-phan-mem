namespace QuanLyDiemHocSinh_54_Hiep
{
    partial class AddStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.labelId_54_Hiep = new System.Windows.Forms.Label();
            this.textBoxId_54_Hiep = new System.Windows.Forms.TextBox();
            this.labelName_54_Hiep = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxName_54_Hiep = new System.Windows.Forms.TextBox();
            this.buttonSave_54_Hiep = new System.Windows.Forms.Button();
            this.buttonCancel_54_Hiep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId_54_Hiep
            // 
            this.labelId_54_Hiep.AutoSize = true;
            this.labelId_54_Hiep.Location = new System.Drawing.Point(33, 40);
            this.labelId_54_Hiep.Name = "labelId_54_Hiep";
            this.labelId_54_Hiep.Size = new System.Drawing.Size(94, 20);
            this.labelId_54_Hiep.TabIndex = 0;
            this.labelId_54_Hiep.Text = "Mã học sinh";
            // 
            // textBoxId_54_Hiep
            // 
            this.textBoxId_54_Hiep.Location = new System.Drawing.Point(138, 37);
            this.textBoxId_54_Hiep.Name = "textBoxId_54_Hiep";
            this.textBoxId_54_Hiep.Size = new System.Drawing.Size(302, 26);
            this.textBoxId_54_Hiep.TabIndex = 1;
            // 
            // labelName_54_Hiep
            // 
            this.labelName_54_Hiep.AutoSize = true;
            this.labelName_54_Hiep.Location = new System.Drawing.Point(33, 86);
            this.labelName_54_Hiep.Name = "labelName_54_Hiep";
            this.labelName_54_Hiep.Size = new System.Drawing.Size(99, 20);
            this.labelName_54_Hiep.TabIndex = 2;
            this.labelName_54_Hiep.Text = "Tên học sinh";
            // 
            // textBoxName_54_Hiep
            // 
            this.textBoxName_54_Hiep.Location = new System.Drawing.Point(138, 83);
            this.textBoxName_54_Hiep.Name = "textBoxName_54_Hiep";
            this.textBoxName_54_Hiep.Size = new System.Drawing.Size(302, 26);
            this.textBoxName_54_Hiep.TabIndex = 3;
            // 
            // buttonSave_54_Hiep
            // 
            this.buttonSave_54_Hiep.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSave_54_Hiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave_54_Hiep.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonSave_54_Hiep.Location = new System.Drawing.Point(63, 137);
            this.buttonSave_54_Hiep.Name = "buttonSave_54_Hiep";
            this.buttonSave_54_Hiep.Size = new System.Drawing.Size(191, 49);
            this.buttonSave_54_Hiep.TabIndex = 4;
            this.buttonSave_54_Hiep.Text = "Lưu";
            this.buttonSave_54_Hiep.UseVisualStyleBackColor = false;
            this.buttonSave_54_Hiep.Click += new System.EventHandler(this.buttonSave_54_Hiep_Click);
            // 
            // buttonCancel_54_Hiep
            // 
            this.buttonCancel_54_Hiep.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCancel_54_Hiep.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCancel_54_Hiep.Location = new System.Drawing.Point(260, 137);
            this.buttonCancel_54_Hiep.Name = "buttonCancel_54_Hiep";
            this.buttonCancel_54_Hiep.Size = new System.Drawing.Size(191, 49);
            this.buttonCancel_54_Hiep.TabIndex = 5;
            this.buttonCancel_54_Hiep.Text = "Huỷ";
            this.buttonCancel_54_Hiep.UseVisualStyleBackColor = false;
            this.buttonCancel_54_Hiep.Click += new System.EventHandler(this.buttonCancel_54_Hiep_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 198);
            this.Controls.Add(this.buttonCancel_54_Hiep);
            this.Controls.Add(this.buttonSave_54_Hiep);
            this.Controls.Add(this.textBoxName_54_Hiep);
            this.Controls.Add(this.labelName_54_Hiep);
            this.Controls.Add(this.textBoxId_54_Hiep);
            this.Controls.Add(this.labelId_54_Hiep);
            this.Name = "AddStudentForm";
            this.Text = "Thêm học sinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId_54_Hiep;
        private System.Windows.Forms.TextBox textBoxId_54_Hiep;
        private System.Windows.Forms.Label labelName_54_Hiep;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxName_54_Hiep;
        private System.Windows.Forms.Button buttonSave_54_Hiep;
        private System.Windows.Forms.Button buttonCancel_54_Hiep;
    }
}