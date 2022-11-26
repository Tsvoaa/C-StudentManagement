namespace StudentManagement
{
    partial class StudentGradeDetail
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
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblGradeScore = new System.Windows.Forms.Label();
            this.txtGradeScore = new System.Windows.Forms.TextBox();
            this.lblStudentScore = new System.Windows.Forms.Label();
            this.lvDetail = new System.Windows.Forms.ListView();
            this.chWeek = new System.Windows.Forms.ColumnHeader();
            this.chAttend = new System.Windows.Forms.ColumnHeader();
            this.lblRound = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.cbStudentScore = new System.Windows.Forms.ComboBox();
            this.lblMidTerm = new System.Windows.Forms.Label();
            this.lblFinalTerm = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.txtMidTerm = new System.Windows.Forms.TextBox();
            this.txtFinalTerm = new System.Windows.Forms.TextBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(40, 9);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(42, 15);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "과목 : ";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(88, 6);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(140, 23);
            this.txtGrade.TabIndex = 1;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(88, 34);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(140, 23);
            this.txtProfessor.TabIndex = 2;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(12, 37);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(70, 15);
            this.lblProfessor.TabIndex = 3;
            this.lblProfessor.Text = "담당 교수 : ";
            // 
            // lblGradeScore
            // 
            this.lblGradeScore.AutoSize = true;
            this.lblGradeScore.Location = new System.Drawing.Point(40, 95);
            this.lblGradeScore.Name = "lblGradeScore";
            this.lblGradeScore.Size = new System.Drawing.Size(42, 15);
            this.lblGradeScore.TabIndex = 4;
            this.lblGradeScore.Text = "학점 : ";
            // 
            // txtGradeScore
            // 
            this.txtGradeScore.Location = new System.Drawing.Point(88, 92);
            this.txtGradeScore.Name = "txtGradeScore";
            this.txtGradeScore.ReadOnly = true;
            this.txtGradeScore.Size = new System.Drawing.Size(72, 23);
            this.txtGradeScore.TabIndex = 5;
            // 
            // lblStudentScore
            // 
            this.lblStudentScore.AutoSize = true;
            this.lblStudentScore.Location = new System.Drawing.Point(436, 41);
            this.lblStudentScore.Name = "lblStudentScore";
            this.lblStudentScore.Size = new System.Drawing.Size(42, 15);
            this.lblStudentScore.TabIndex = 7;
            this.lblStudentScore.Text = "성적 : ";
            // 
            // lvDetail
            // 
            this.lvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWeek,
            this.chAttend});
            this.lvDetail.Location = new System.Drawing.Point(12, 313);
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(776, 125);
            this.lvDetail.TabIndex = 8;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            this.lvDetail.View = System.Windows.Forms.View.Details;
            // 
            // chWeek
            // 
            this.chWeek.Text = "수업주차";
            this.chWeek.Width = 100;
            // 
            // chAttend
            // 
            this.chAttend.Text = "출석";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(12, 66);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(70, 15);
            this.lblRound.TabIndex = 9;
            this.lblRound.Text = "수업 시수 : ";
            // 
            // txtRound
            // 
            this.txtRound.Location = new System.Drawing.Point(88, 63);
            this.txtRound.Name = "txtRound";
            this.txtRound.ReadOnly = true;
            this.txtRound.Size = new System.Drawing.Size(72, 23);
            this.txtRound.TabIndex = 10;
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
            "F"});
            this.cbStudentScore.Location = new System.Drawing.Point(484, 38);
            this.cbStudentScore.Name = "cbStudentScore";
            this.cbStudentScore.Size = new System.Drawing.Size(72, 23);
            this.cbStudentScore.TabIndex = 11;
            // 
            // lblMidTerm
            // 
            this.lblMidTerm.AutoSize = true;
            this.lblMidTerm.Location = new System.Drawing.Point(286, 14);
            this.lblMidTerm.Name = "lblMidTerm";
            this.lblMidTerm.Size = new System.Drawing.Size(70, 15);
            this.lblMidTerm.TabIndex = 12;
            this.lblMidTerm.Text = "중간 고사 : ";
            // 
            // lblFinalTerm
            // 
            this.lblFinalTerm.AutoSize = true;
            this.lblFinalTerm.Location = new System.Drawing.Point(286, 41);
            this.lblFinalTerm.Name = "lblFinalTerm";
            this.lblFinalTerm.Size = new System.Drawing.Size(66, 15);
            this.lblFinalTerm.TabIndex = 13;
            this.lblFinalTerm.Text = "기말 고사 :";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(436, 14);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(42, 15);
            this.lblTask.TabIndex = 14;
            this.lblTask.Text = "과제 : ";
            // 
            // txtMidTerm
            // 
            this.txtMidTerm.Location = new System.Drawing.Point(358, 9);
            this.txtMidTerm.Name = "txtMidTerm";
            this.txtMidTerm.Size = new System.Drawing.Size(72, 23);
            this.txtMidTerm.TabIndex = 15;
            // 
            // txtFinalTerm
            // 
            this.txtFinalTerm.Location = new System.Drawing.Point(358, 38);
            this.txtFinalTerm.Name = "txtFinalTerm";
            this.txtFinalTerm.Size = new System.Drawing.Size(72, 23);
            this.txtFinalTerm.TabIndex = 16;
            this.txtFinalTerm.TextChanged += new System.EventHandler(this.txtFinalTerm_TextChanged);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(484, 9);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(72, 23);
            this.txtTask.TabIndex = 17;
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(40, 177);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(100, 23);
            this.txtStudentNum.TabIndex = 18;
            this.txtStudentNum.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(484, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "저장하기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StudentGradeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStudentNum);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.txtFinalTerm);
            this.Controls.Add(this.txtMidTerm);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblFinalTerm);
            this.Controls.Add(this.lblMidTerm);
            this.Controls.Add(this.cbStudentScore);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lvDetail);
            this.Controls.Add(this.lblStudentScore);
            this.Controls.Add(this.txtGradeScore);
            this.Controls.Add(this.lblGradeScore);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Name = "StudentGradeDetail";
            this.Text = "StudentGradeDetail";
            this.Load += new System.EventHandler(this.StudentGradeDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGrade;
        private TextBox txtGrade;
        private TextBox txtProfessor;
        private Label lblProfessor;
        private Label lblGradeScore;
        private TextBox txtGradeScore;
        private Label lblStudentScore;
        private ListView lvDetail;
        private ColumnHeader chWeek;
        private ColumnHeader chAttend;
        private Label lblRound;
        private TextBox txtRound;
        private ComboBox cbStudentScore;
        private Label lblMidTerm;
        private Label lblFinalTerm;
        private Label lblTask;
        private TextBox txtMidTerm;
        private TextBox txtFinalTerm;
        private TextBox txtTask;
        private TextBox txtStudentNum;
        private Button btnSave;
    }
}