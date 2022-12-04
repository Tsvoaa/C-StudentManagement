namespace StudentManagement
{
    partial class StudentForm
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
            this.lvStudent = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chStdNum = new System.Windows.Forms.ColumnHeader();
            this.chGrade = new System.Windows.Forms.ColumnHeader();
            this.chClass = new System.Windows.Forms.ColumnHeader();
            this.chAbsence = new System.Windows.Forms.ColumnHeader();
            this.chOther = new System.Windows.Forms.ColumnHeader();
            this.gbGrade = new System.Windows.Forms.GroupBox();
            this.rbGradeAll = new System.Windows.Forms.RadioButton();
            this.rbGrade3 = new System.Windows.Forms.RadioButton();
            this.rbGrade2 = new System.Windows.Forms.RadioButton();
            this.rbGrade1 = new System.Windows.Forms.RadioButton();
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.rbClassAll = new System.Windows.Forms.RadioButton();
            this.rbClass2 = new System.Windows.Forms.RadioButton();
            this.rbClass1 = new System.Windows.Forms.RadioButton();
            this.btnViewGrade = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.gbGrade.SuspendLayout();
            this.gbClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStudent
            // 
            this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chStdNum,
            this.chGrade,
            this.chClass,
            this.chAbsence,
            this.chOther});
            this.lvStudent.FullRowSelect = true;
            this.lvStudent.GridLines = true;
            this.lvStudent.Location = new System.Drawing.Point(12, 108);
            this.lvStudent.MultiSelect = false;
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(605, 487);
            this.lvStudent.TabIndex = 0;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            this.lvStudent.SelectedIndexChanged += new System.EventHandler(this.lvStudent_SelectedIndexChanged);
            this.lvStudent.DoubleClick += new System.EventHandler(this.lvStudent_DoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "이름";
            // 
            // chStdNum
            // 
            this.chStdNum.Text = "학번";
            this.chStdNum.Width = 120;
            // 
            // chGrade
            // 
            this.chGrade.Text = "학년";
            // 
            // chClass
            // 
            this.chClass.Text = "반";
            // 
            // chAbsence
            // 
            this.chAbsence.Text = "출석률";
            // 
            // chOther
            // 
            this.chOther.Text = "비고";
            this.chOther.Width = 240;
            // 
            // gbGrade
            // 
            this.gbGrade.Controls.Add(this.rbGradeAll);
            this.gbGrade.Controls.Add(this.rbGrade3);
            this.gbGrade.Controls.Add(this.rbGrade2);
            this.gbGrade.Controls.Add(this.rbGrade1);
            this.gbGrade.Location = new System.Drawing.Point(12, 12);
            this.gbGrade.Name = "gbGrade";
            this.gbGrade.Size = new System.Drawing.Size(242, 45);
            this.gbGrade.TabIndex = 1;
            this.gbGrade.TabStop = false;
            this.gbGrade.Text = "학년";
            // 
            // rbGradeAll
            // 
            this.rbGradeAll.AutoSize = true;
            this.rbGradeAll.Checked = true;
            this.rbGradeAll.Location = new System.Drawing.Point(6, 20);
            this.rbGradeAll.Name = "rbGradeAll";
            this.rbGradeAll.Size = new System.Drawing.Size(49, 19);
            this.rbGradeAll.TabIndex = 3;
            this.rbGradeAll.TabStop = true;
            this.rbGradeAll.Text = "전체";
            this.rbGradeAll.UseVisualStyleBackColor = true;
            this.rbGradeAll.CheckedChanged += new System.EventHandler(this.rbGradeAll_CheckedChanged);
            // 
            // rbGrade3
            // 
            this.rbGrade3.AutoSize = true;
            this.rbGrade3.Location = new System.Drawing.Point(185, 20);
            this.rbGrade3.Name = "rbGrade3";
            this.rbGrade3.Size = new System.Drawing.Size(56, 19);
            this.rbGrade3.TabIndex = 2;
            this.rbGrade3.TabStop = true;
            this.rbGrade3.Text = "3학년";
            this.rbGrade3.UseVisualStyleBackColor = true;
            this.rbGrade3.CheckedChanged += new System.EventHandler(this.rbGrade3_CheckedChanged);
            // 
            // rbGrade2
            // 
            this.rbGrade2.AutoSize = true;
            this.rbGrade2.Location = new System.Drawing.Point(123, 20);
            this.rbGrade2.Name = "rbGrade2";
            this.rbGrade2.Size = new System.Drawing.Size(56, 19);
            this.rbGrade2.TabIndex = 1;
            this.rbGrade2.TabStop = true;
            this.rbGrade2.Text = "2학년";
            this.rbGrade2.UseVisualStyleBackColor = true;
            this.rbGrade2.CheckedChanged += new System.EventHandler(this.rbGrade2_CheckedChanged);
            // 
            // rbGrade1
            // 
            this.rbGrade1.AutoSize = true;
            this.rbGrade1.Location = new System.Drawing.Point(61, 20);
            this.rbGrade1.Name = "rbGrade1";
            this.rbGrade1.Size = new System.Drawing.Size(56, 19);
            this.rbGrade1.TabIndex = 0;
            this.rbGrade1.TabStop = true;
            this.rbGrade1.Text = "1학년";
            this.rbGrade1.UseVisualStyleBackColor = true;
            this.rbGrade1.CheckedChanged += new System.EventHandler(this.rbGrade1_CheckedChanged);
            // 
            // gbClass
            // 
            this.gbClass.Controls.Add(this.rbClassAll);
            this.gbClass.Controls.Add(this.rbClass2);
            this.gbClass.Controls.Add(this.rbClass1);
            this.gbClass.Location = new System.Drawing.Point(260, 12);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(157, 45);
            this.gbClass.TabIndex = 2;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "반";
            // 
            // rbClassAll
            // 
            this.rbClassAll.AutoSize = true;
            this.rbClassAll.Checked = true;
            this.rbClassAll.Location = new System.Drawing.Point(6, 20);
            this.rbClassAll.Name = "rbClassAll";
            this.rbClassAll.Size = new System.Drawing.Size(49, 19);
            this.rbClassAll.TabIndex = 4;
            this.rbClassAll.TabStop = true;
            this.rbClassAll.Text = "전체";
            this.rbClassAll.UseVisualStyleBackColor = true;
            this.rbClassAll.CheckedChanged += new System.EventHandler(this.rbClassAll_CheckedChanged);
            // 
            // rbClass2
            // 
            this.rbClass2.AutoSize = true;
            this.rbClass2.Location = new System.Drawing.Point(111, 20);
            this.rbClass2.Name = "rbClass2";
            this.rbClass2.Size = new System.Drawing.Size(44, 19);
            this.rbClass2.TabIndex = 1;
            this.rbClass2.TabStop = true;
            this.rbClass2.Text = "2반";
            this.rbClass2.UseVisualStyleBackColor = true;
            this.rbClass2.CheckedChanged += new System.EventHandler(this.rbClass2_CheckedChanged);
            // 
            // rbClass1
            // 
            this.rbClass1.AutoSize = true;
            this.rbClass1.Location = new System.Drawing.Point(61, 20);
            this.rbClass1.Name = "rbClass1";
            this.rbClass1.Size = new System.Drawing.Size(44, 19);
            this.rbClass1.TabIndex = 0;
            this.rbClass1.TabStop = true;
            this.rbClass1.Text = "1반";
            this.rbClass1.UseVisualStyleBackColor = true;
            this.rbClass1.CheckedChanged += new System.EventHandler(this.rbClass1_CheckedChanged);
            // 
            // btnViewGrade
            // 
            this.btnViewGrade.Location = new System.Drawing.Point(545, 12);
            this.btnViewGrade.Name = "btnViewGrade";
            this.btnViewGrade.Size = new System.Drawing.Size(75, 23);
            this.btnViewGrade.TabIndex = 3;
            this.btnViewGrade.Text = "과목 보기";
            this.btnViewGrade.UseVisualStyleBackColor = true;
            this.btnViewGrade.Click += new System.EventHandler(this.btnViewGrade_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(545, 41);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "학생 추가";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 607);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnViewGrade);
            this.Controls.Add(this.gbClass);
            this.Controls.Add(this.gbGrade);
            this.Controls.Add(this.lvStudent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.gbGrade.ResumeLayout(false);
            this.gbGrade.PerformLayout();
            this.gbClass.ResumeLayout(false);
            this.gbClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvStudent;
        private ColumnHeader chName;
        private ColumnHeader chStdNum;
        private ColumnHeader chGrade;
        private ColumnHeader chClass;
        private ColumnHeader chAbsence;
        private ColumnHeader chOther;
        private GroupBox gbGrade;
        private RadioButton rbGrade3;
        private RadioButton rbGrade2;
        private RadioButton rbGrade1;
        private GroupBox gbClass;
        private RadioButton rbClass2;
        private RadioButton rbClass1;
        private RadioButton rbGradeAll;
        private RadioButton rbClassAll;
        private Button btnViewGrade;
        private Button btnAddStudent;
    }
}