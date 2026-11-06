namespace GUI26110603
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUi001 = new Label();
            btnAddStudent = new Button();
            cbxFieldOfStudy = new ComboBox();
            txtName = new TextBox();
            lsxStudents = new ListBox();
            lblStudentCount = new Label();
            nudAge = new NumericUpDown();
            lblUi002 = new Label();
            lblUi003 = new Label();
            btnDeleteSelected = new Button();
            btnDeleteAll = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // 
            // lblUi001
            // 
            lblUi001.AutoSize = true;
            lblUi001.Location = new Point(91, 63);
            lblUi001.Name = "lblUi001";
            lblUi001.Size = new Size(46, 25);
            lblUi001.TabIndex = 0;
            lblUi001.Text = "név:";
            // 
            // btnAddStudent
            // 
            btnAddStudent.AutoSize = true;
            btnAddStudent.Location = new Point(28, 293);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(111, 35);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "hozzáadás";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // cbxFieldOfStudy
            // 
            cbxFieldOfStudy.FormattingEnabled = true;
            cbxFieldOfStudy.Location = new Point(216, 202);
            cbxFieldOfStudy.Name = "cbxFieldOfStudy";
            cbxFieldOfStudy.Size = new Size(156, 33);
            cbxFieldOfStudy.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 32);
            txtName.TabIndex = 1;
            // 
            // lsxStudents
            // 
            lsxStudents.FormattingEnabled = true;
            lsxStudents.Location = new Point(445, 23);
            lsxStudents.Name = "lsxStudents";
            lsxStudents.Size = new Size(269, 404);
            lsxStudents.TabIndex = 4;
            lsxStudents.TabStop = false;
            // 
            // lblStudentCount
            // 
            lblStudentCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStudentCount.Location = new Point(12, 357);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new Size(427, 70);
            lblStudentCount.TabIndex = 0;
            lblStudentCount.Text = "diákok száma: ###";
            lblStudentCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(298, 132);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(74, 32);
            nudAge.TabIndex = 2;
            nudAge.TextAlign = HorizontalAlignment.Right;
            nudAge.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // lblUi002
            // 
            lblUi002.AutoSize = true;
            lblUi002.Location = new Point(63, 134);
            lblUi002.Name = "lblUi002";
            lblUi002.Size = new Size(74, 25);
            lblUi002.TabIndex = 0;
            lblUi002.Text = "életkor:";
            // 
            // lblUi003
            // 
            lblUi003.AutoSize = true;
            lblUi003.Location = new Point(85, 205);
            lblUi003.Name = "lblUi003";
            lblUi003.Size = new Size(52, 25);
            lblUi003.TabIndex = 0;
            lblUi003.Text = "szak:";
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.AutoSize = true;
            btnDeleteSelected.Location = new Point(172, 293);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(75, 35);
            btnDeleteSelected.TabIndex = 0;
            btnDeleteSelected.TabStop = false;
            btnDeleteSelected.Text = "törlés";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.AutoSize = true;
            btnDeleteAll.Location = new Point(280, 293);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(138, 35);
            btnDeleteAll.TabIndex = 10;
            btnDeleteAll.TabStop = false;
            btnDeleteAll.Text = "összes törlése";
            btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 450);
            Controls.Add(nudAge);
            Controls.Add(lsxStudents);
            Controls.Add(txtName);
            Controls.Add(cbxFieldOfStudy);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDeleteSelected);
            Controls.Add(btnAddStudent);
            Controls.Add(lblStudentCount);
            Controls.Add(lblUi003);
            Controls.Add(lblUi002);
            Controls.Add(lblUi001);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "diák nyilvántartó app";
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUi001;
        private Button btnAddStudent;
        private ComboBox cbxFieldOfStudy;
        private TextBox txtName;
        private ListBox lsxStudents;
        private Label lblStudentCount;
        private NumericUpDown nudAge;
        private Label lblUi002;
        private Label lblUi003;
        private Button btnDeleteSelected;
        private Button btnDeleteAll;
    }
}
