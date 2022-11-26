namespace StudentManagement
{
    partial class GradeViewDetail
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
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lvCourseStudent = new System.Windows.Forms.ListView();
            this.chStudentNum = new System.Windows.Forms.ColumnHeader();
            this.chStudentName = new System.Windows.Forms.ColumnHeader();
            this.chCourseAttend = new System.Windows.Forms.ColumnHeader();
            this.chCourseTask = new System.Windows.Forms.ColumnHeader();
            this.chCourseMidTerm = new System.Windows.Forms.ColumnHeader();
            this.chCourseFinalTerm = new System.Windows.Forms.ColumnHeader();
            this.chCourseScore = new System.Windows.Forms.ColumnHeader();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblMidTerm = new System.Windows.Forms.Label();
            this.lblFinalTerm = new System.Windows.Forms.Label();
            this.lblStudentScore = new System.Windows.Forms.Label();
            this.txtMidTerm = new System.Windows.Forms.TextBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtSutdentNum = new System.Windows.Forms.TextBox();
            this.txtFinalTerm = new System.Windows.Forms.TextBox();
            this.cbStudentScore = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Location = new System.Drawing.Point(12, 9);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(70, 15);
            this.lblSubjectCode.TabIndex = 0;
            this.lblSubjectCode.Text = "과목 코드 : ";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Location = new System.Drawing.Point(88, 6);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.ReadOnly = true;
            this.txtSubjectCode.Size = new System.Drawing.Size(100, 23);
            this.txtSubjectCode.TabIndex = 1;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(194, 9);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(70, 15);
            this.lblSubjectName.TabIndex = 2;
            this.lblSubjectName.Text = "과목 이름 : ";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(270, 6);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.ReadOnly = true;
            this.txtSubjectName.Size = new System.Drawing.Size(172, 23);
            this.txtSubjectName.TabIndex = 3;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(40, 39);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(42, 15);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "학년 : ";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(40, 69);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(42, 15);
            this.lblSemester.TabIndex = 5;
            this.lblSemester.Text = "학기 : ";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(88, 36);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(100, 23);
            this.txtGrade.TabIndex = 6;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(88, 66);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.ReadOnly = true;
            this.txtSemester.Size = new System.Drawing.Size(100, 23);
            this.txtSemester.TabIndex = 7;
            // 
            // lvCourseStudent
            // 
            this.lvCourseStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStudentNum,
            this.chStudentName,
            this.chCourseAttend,
            this.chCourseTask,
            this.chCourseMidTerm,
            this.chCourseFinalTerm,
            this.chCourseScore});
            this.lvCourseStudent.FullRowSelect = true;
            this.lvCourseStudent.GridLines = true;
            this.lvCourseStudent.Location = new System.Drawing.Point(12, 95);
            this.lvCourseStudent.Name = "lvCourseStudent";
            this.lvCourseStudent.Size = new System.Drawing.Size(545, 230);
            this.lvCourseStudent.TabIndex = 8;
            this.lvCourseStudent.UseCompatibleStateImageBehavior = false;
            this.lvCourseStudent.View = System.Windows.Forms.View.Details;
            this.lvCourseStudent.SelectedIndexChanged += new System.EventHandler(this.lvCourseStudent_SelectedIndexChanged);
            // 
            // chStudentNum
            // 
            this.chStudentNum.Text = "학번";
            this.chStudentNum.Width = 100;
            // 
            // chStudentName
            // 
            this.chStudentName.Text = "이름";
            this.chStudentName.Width = 80;
            // 
            // chCourseAttend
            // 
            this.chCourseAttend.Text = "출석률";
            // 
            // chCourseTask
            // 
            this.chCourseTask.Text = "과제 점수";
            this.chCourseTask.Width = 80;
            // 
            // chCourseMidTerm
            // 
            this.chCourseMidTerm.Text = "중간 점수";
            this.chCourseMidTerm.Width = 80;
            // 
            // chCourseFinalTerm
            // 
            this.chCourseFinalTerm.Text = "기말 점수";
            this.chCourseFinalTerm.Width = 80;
            // 
            // chCourseScore
            // 
            this.chCourseScore.Text = "성적";
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Location = new System.Drawing.Point(563, 95);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(42, 15);
            this.lblStudentNum.TabIndex = 9;
            this.lblStudentNum.Text = "학번 : ";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(717, 95);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(42, 15);
            this.lblStudentName.TabIndex = 10;
            this.lblStudentName.Text = "이름 : ";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(563, 124);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(42, 15);
            this.lblTask.TabIndex = 11;
            this.lblTask.Text = "과제 : ";
            // 
            // lblMidTerm
            // 
            this.lblMidTerm.AutoSize = true;
            this.lblMidTerm.Location = new System.Drawing.Point(563, 153);
            this.lblMidTerm.Name = "lblMidTerm";
            this.lblMidTerm.Size = new System.Drawing.Size(42, 15);
            this.lblMidTerm.TabIndex = 12;
            this.lblMidTerm.Text = "중간 : ";
            // 
            // lblFinalTerm
            // 
            this.lblFinalTerm.AutoSize = true;
            this.lblFinalTerm.Location = new System.Drawing.Point(563, 182);
            this.lblFinalTerm.Name = "lblFinalTerm";
            this.lblFinalTerm.Size = new System.Drawing.Size(42, 15);
            this.lblFinalTerm.TabIndex = 13;
            this.lblFinalTerm.Text = "기말 : ";
            // 
            // lblStudentScore
            // 
            this.lblStudentScore.AutoSize = true;
            this.lblStudentScore.Location = new System.Drawing.Point(563, 211);
            this.lblStudentScore.Name = "lblStudentScore";
            this.lblStudentScore.Size = new System.Drawing.Size(42, 15);
            this.lblStudentScore.TabIndex = 14;
            this.lblStudentScore.Text = "성적 : ";
            // 
            // txtMidTerm
            // 
            this.txtMidTerm.Location = new System.Drawing.Point(611, 150);
            this.txtMidTerm.Name = "txtMidTerm";
            this.txtMidTerm.Size = new System.Drawing.Size(49, 23);
            this.txtMidTerm.TabIndex = 15;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(611, 121);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(49, 23);
            this.txtTask.TabIndex = 16;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(765, 92);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(100, 23);
            this.txtStudentName.TabIndex = 17;
            // 
            // txtSutdentNum
            // 
            this.txtSutdentNum.Location = new System.Drawing.Point(611, 92);
            this.txtSutdentNum.Name = "txtSutdentNum";
            this.txtSutdentNum.ReadOnly = true;
            this.txtSutdentNum.Size = new System.Drawing.Size(100, 23);
            this.txtSutdentNum.TabIndex = 18;
            // 
            // txtFinalTerm
            // 
            this.txtFinalTerm.Location = new System.Drawing.Point(611, 179);
            this.txtFinalTerm.Name = "txtFinalTerm";
            this.txtFinalTerm.Size = new System.Drawing.Size(49, 23);
            this.txtFinalTerm.TabIndex = 19;
            // 
            // cbStudentScore
            // 
            this.cbStudentScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentScore.FormattingEnabled = true;
            this.cbStudentScore.Items.AddRange(new object[] {
            "A+",
            "A0",
            "B+",
            "B0",
            "C+",
            "C0",
            "D+",
            "D0",
            "F",
            "P",
            "NP"});
            this.cbStudentScore.Location = new System.Drawing.Point(611, 208);
            this.cbStudentScore.Name = "cbStudentScore";
            this.cbStudentScore.Size = new System.Drawing.Size(49, 23);
            this.cbStudentScore.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(796, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 31);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "저장하기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GradeViewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 335);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbStudentScore);
            this.Controls.Add(this.txtFinalTerm);
            this.Controls.Add(this.txtSutdentNum);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.txtMidTerm);
            this.Controls.Add(this.lblStudentScore);
            this.Controls.Add(this.lblFinalTerm);
            this.Controls.Add(this.lblMidTerm);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentNum);
            this.Controls.Add(this.lvCourseStudent);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.lblSubjectCode);
            this.Name = "GradeViewDetail";
            this.Text = "GradeViewDetail";
            this.Load += new System.EventHandler(this.GradeViewDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSubjectCode;
        private TextBox txtSubjectCode;
        private Label lblSubjectName;
        private TextBox txtSubjectName;
        private Label lblGrade;
        private Label lblSemester;
        private TextBox txtGrade;
        private TextBox txtSemester;
        private ListView lvCourseStudent;
        private ColumnHeader chStudentNum;
        private ColumnHeader chStudentName;
        private ColumnHeader chCourseAttend;
        private ColumnHeader chCourseTask;
        private ColumnHeader chCourseMidTerm;
        private ColumnHeader chCourseFinalTerm;
        private ColumnHeader chCourseScore;
        private Label lblStudentNum;
        private Label lblStudentName;
        private Label lblTask;
        private Label lblMidTerm;
        private Label lblFinalTerm;
        private Label lblStudentScore;
        private TextBox txtMidTerm;
        private TextBox txtTask;
        private TextBox txtStudentName;
        private TextBox txtSutdentNum;
        private TextBox txtFinalTerm;
        private ComboBox cbStudentScore;
        private Button btnSave;
    }
}