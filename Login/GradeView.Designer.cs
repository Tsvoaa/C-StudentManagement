namespace StudentManagement
{
    partial class GradeView
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
            this.lvGrade = new System.Windows.Forms.ListView();
            this.chGradeCode = new System.Windows.Forms.ColumnHeader();
            this.chGradeSubject = new System.Windows.Forms.ColumnHeader();
            this.chGradeScore = new System.Windows.Forms.ColumnHeader();
            this.chWeek = new System.Windows.Forms.ColumnHeader();
            this.chGrade = new System.Windows.Forms.ColumnHeader();
            this.chSemester = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblGradeName = new System.Windows.Forms.Label();
            this.lblGradeScore = new System.Windows.Forms.Label();
            this.lblGradeCode2 = new System.Windows.Forms.Label();
            this.txtGradeCode2 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGradeWeek = new System.Windows.Forms.Label();
            this.txtGradeWeek = new System.Windows.Forms.TextBox();
            this.lblSelectGrade = new System.Windows.Forms.Label();
            this.txtSelectGrade = new System.Windows.Forms.TextBox();
            this.cbSelectWeek = new System.Windows.Forms.ComboBox();
            this.lblSelectWeek = new System.Windows.Forms.Label();
            this.btnAttend = new System.Windows.Forms.Button();
            this.btnNotAttend = new System.Windows.Forms.Button();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvGrade
            // 
            this.lvGrade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGradeCode,
            this.chGradeSubject,
            this.chGradeScore,
            this.chWeek,
            this.chGrade,
            this.chSemester});
            this.lvGrade.FullRowSelect = true;
            this.lvGrade.GridLines = true;
            this.lvGrade.Location = new System.Drawing.Point(12, 12);
            this.lvGrade.Name = "lvGrade";
            this.lvGrade.Size = new System.Drawing.Size(525, 426);
            this.lvGrade.TabIndex = 0;
            this.lvGrade.UseCompatibleStateImageBehavior = false;
            this.lvGrade.View = System.Windows.Forms.View.Details;
            this.lvGrade.SelectedIndexChanged += new System.EventHandler(this.lvGrade_SelectedIndexChanged);
            this.lvGrade.DoubleClick += new System.EventHandler(this.lvGrade_DoubleClick);
            // 
            // chGradeCode
            // 
            this.chGradeCode.Text = "과목코드";
            this.chGradeCode.Width = 80;
            // 
            // chGradeSubject
            // 
            this.chGradeSubject.DisplayIndex = 3;
            this.chGradeSubject.Text = "과목명";
            this.chGradeSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chGradeSubject.Width = 200;
            // 
            // chGradeScore
            // 
            this.chGradeScore.DisplayIndex = 4;
            this.chGradeScore.Text = "학점";
            // 
            // chWeek
            // 
            this.chWeek.DisplayIndex = 5;
            this.chWeek.Text = "수업시수";
            // 
            // chGrade
            // 
            this.chGrade.DisplayIndex = 1;
            this.chGrade.Text = "학년";
            // 
            // chSemester
            // 
            this.chSemester.DisplayIndex = 2;
            this.chSemester.Text = "학기";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(640, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "과목 추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(792, 194);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 23);
            this.txtScore.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(615, 222);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(615, 191);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 23);
            this.txtCode.TabIndex = 4;
            this.txtCode.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(543, 194);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(66, 15);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "과목코드 : ";
            // 
            // lblGradeName
            // 
            this.lblGradeName.AutoSize = true;
            this.lblGradeName.Location = new System.Drawing.Point(555, 225);
            this.lblGradeName.Name = "lblGradeName";
            this.lblGradeName.Size = new System.Drawing.Size(54, 15);
            this.lblGradeName.TabIndex = 6;
            this.lblGradeName.Text = "과목명 : ";
            this.lblGradeName.Click += new System.EventHandler(this.lblGradeName_Click);
            // 
            // lblGradeScore
            // 
            this.lblGradeScore.AutoSize = true;
            this.lblGradeScore.Location = new System.Drawing.Point(744, 197);
            this.lblGradeScore.Name = "lblGradeScore";
            this.lblGradeScore.Size = new System.Drawing.Size(42, 15);
            this.lblGradeScore.TabIndex = 7;
            this.lblGradeScore.Text = "학점 : ";
            // 
            // lblGradeCode2
            // 
            this.lblGradeCode2.AutoSize = true;
            this.lblGradeCode2.Location = new System.Drawing.Point(543, 383);
            this.lblGradeCode2.Name = "lblGradeCode2";
            this.lblGradeCode2.Size = new System.Drawing.Size(66, 15);
            this.lblGradeCode2.TabIndex = 8;
            this.lblGradeCode2.Text = "과목코드 : ";
            // 
            // txtGradeCode2
            // 
            this.txtGradeCode2.Location = new System.Drawing.Point(615, 380);
            this.txtGradeCode2.Name = "txtGradeCode2";
            this.txtGradeCode2.Size = new System.Drawing.Size(100, 23);
            this.txtGradeCode2.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(640, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "과목 삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGradeWeek
            // 
            this.lblGradeWeek.AutoSize = true;
            this.lblGradeWeek.Location = new System.Drawing.Point(720, 226);
            this.lblGradeWeek.Name = "lblGradeWeek";
            this.lblGradeWeek.Size = new System.Drawing.Size(66, 15);
            this.lblGradeWeek.TabIndex = 11;
            this.lblGradeWeek.Text = "수업시수 : ";
            // 
            // txtGradeWeek
            // 
            this.txtGradeWeek.Location = new System.Drawing.Point(792, 223);
            this.txtGradeWeek.Name = "txtGradeWeek";
            this.txtGradeWeek.Size = new System.Drawing.Size(100, 23);
            this.txtGradeWeek.TabIndex = 12;
            // 
            // lblSelectGrade
            // 
            this.lblSelectGrade.AutoSize = true;
            this.lblSelectGrade.Location = new System.Drawing.Point(543, 12);
            this.lblSelectGrade.Name = "lblSelectGrade";
            this.lblSelectGrade.Size = new System.Drawing.Size(66, 15);
            this.lblSelectGrade.TabIndex = 13;
            this.lblSelectGrade.Text = "선택과목 : ";
            this.lblSelectGrade.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // txtSelectGrade
            // 
            this.txtSelectGrade.Location = new System.Drawing.Point(615, 9);
            this.txtSelectGrade.Name = "txtSelectGrade";
            this.txtSelectGrade.ReadOnly = true;
            this.txtSelectGrade.Size = new System.Drawing.Size(100, 23);
            this.txtSelectGrade.TabIndex = 14;
            // 
            // cbSelectWeek
            // 
            this.cbSelectWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectWeek.FormattingEnabled = true;
            this.cbSelectWeek.Location = new System.Drawing.Point(615, 38);
            this.cbSelectWeek.Name = "cbSelectWeek";
            this.cbSelectWeek.Size = new System.Drawing.Size(100, 23);
            this.cbSelectWeek.TabIndex = 15;
            // 
            // lblSelectWeek
            // 
            this.lblSelectWeek.AutoSize = true;
            this.lblSelectWeek.Location = new System.Drawing.Point(543, 41);
            this.lblSelectWeek.Name = "lblSelectWeek";
            this.lblSelectWeek.Size = new System.Drawing.Size(66, 15);
            this.lblSelectWeek.TabIndex = 16;
            this.lblSelectWeek.Text = "선택시수 : ";
            // 
            // btnAttend
            // 
            this.btnAttend.Location = new System.Drawing.Point(640, 67);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Size = new System.Drawing.Size(75, 23);
            this.btnAttend.TabIndex = 17;
            this.btnAttend.Text = "전원출석";
            this.btnAttend.UseVisualStyleBackColor = true;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // btnNotAttend
            // 
            this.btnNotAttend.Location = new System.Drawing.Point(559, 67);
            this.btnNotAttend.Name = "btnNotAttend";
            this.btnNotAttend.Size = new System.Drawing.Size(75, 23);
            this.btnNotAttend.TabIndex = 18;
            this.btnNotAttend.Text = "전원결석";
            this.btnNotAttend.UseVisualStyleBackColor = true;
            this.btnNotAttend.Click += new System.EventHandler(this.btnNotAttend_Click);
            // 
            // cbGrade
            // 
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "1학년",
            "2학년",
            "3학년"});
            this.cbGrade.Location = new System.Drawing.Point(615, 251);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(100, 23);
            this.cbGrade.TabIndex = 19;
            // 
            // cbSemester
            // 
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1학기",
            "2학기"});
            this.cbSemester.Location = new System.Drawing.Point(792, 252);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(100, 23);
            this.cbSemester.TabIndex = 20;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(567, 255);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(42, 15);
            this.lblGrade.TabIndex = 21;
            this.lblGrade.Text = "학년 : ";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(744, 255);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(38, 15);
            this.lblSemester.TabIndex = 22;
            this.lblSemester.Text = "학기 :";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(543, 285);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(66, 15);
            this.lblProfessor.TabIndex = 23;
            this.lblProfessor.Text = "담당교수 : ";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(615, 282);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(100, 23);
            this.txtProfessor.TabIndex = 24;
            // 
            // GradeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.btnNotAttend);
            this.Controls.Add(this.btnAttend);
            this.Controls.Add(this.lblSelectWeek);
            this.Controls.Add(this.cbSelectWeek);
            this.Controls.Add(this.txtSelectGrade);
            this.Controls.Add(this.lblSelectGrade);
            this.Controls.Add(this.txtGradeWeek);
            this.Controls.Add(this.lblGradeWeek);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtGradeCode2);
            this.Controls.Add(this.lblGradeCode2);
            this.Controls.Add(this.lblGradeScore);
            this.Controls.Add(this.lblGradeName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvGrade);
            this.Name = "GradeView";
            this.Text = "GradeView";
            this.Load += new System.EventHandler(this.GradeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvGrade;
        private ColumnHeader chGradeCode;
        private ColumnHeader chGradeSubject;
        private ColumnHeader chGradeScore;
        private Button btnAdd;
        private TextBox txtScore;
        private TextBox txtName;
        private TextBox txtCode;
        private Label lblCode;
        private Label lblGradeName;
        private Label lblGradeScore;
        private Label lblGradeCode2;
        private TextBox txtGradeCode2;
        private Button btnDelete;
        private ColumnHeader chWeek;
        private Label lblGradeWeek;
        private TextBox txtGradeWeek;
        private Label lblSelectGrade;
        private TextBox txtSelectGrade;
        private ComboBox cbSelectWeek;
        private Label lblSelectWeek;
        private Button btnAttend;
        private Button btnNotAttend;
        private ColumnHeader chGrade;
        private ColumnHeader chSemester;
        private ComboBox cbGrade;
        private ComboBox cbSemester;
        private Label lblGrade;
        private Label lblSemester;
        private Label lblProfessor;
        private TextBox txtProfessor;
    }
}