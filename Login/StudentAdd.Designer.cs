namespace StudentManagement
{
    partial class StudentAdd
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblArmy = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.cbArmy = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblClasses = new System.Windows.Forms.Label();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름 : ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 43);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(42, 15);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "학번 : ";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(12, 80);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(42, 15);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "학년 : ";
            // 
            // lblArmy
            // 
            this.lblArmy.AutoSize = true;
            this.lblArmy.Location = new System.Drawing.Point(204, 43);
            this.lblArmy.Name = "lblArmy";
            this.lblArmy.Size = new System.Drawing.Size(42, 15);
            this.lblArmy.TabIndex = 3;
            this.lblArmy.Text = "군필 : ";
            this.lblArmy.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(204, 9);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 15);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "성별 : ";
            this.lblGender.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(60, 40);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 23);
            this.txtNumber.TabIndex = 6;
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "1학년",
            "2학년",
            "3학년"});
            this.cbGrade.Location = new System.Drawing.Point(60, 77);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(100, 23);
            this.cbGrade.TabIndex = 7;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // cbArmy
            // 
            this.cbArmy.FormattingEnabled = true;
            this.cbArmy.Items.AddRange(new object[] {
            "군필",
            "미필",
            "해당없음"});
            this.cbArmy.Location = new System.Drawing.Point(252, 40);
            this.cbArmy.Name = "cbArmy";
            this.cbArmy.Size = new System.Drawing.Size(74, 23);
            this.cbArmy.TabIndex = 8;
            this.cbArmy.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "남성",
            "여성"});
            this.cbGender.Location = new System.Drawing.Point(252, 6);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(74, 23);
            this.cbGender.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "추가하기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(216, 80);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(30, 15);
            this.lblClasses.TabIndex = 11;
            this.lblClasses.Text = "반 : ";
            this.lblClasses.Click += new System.EventHandler(this.lblClasses_Click);
            // 
            // cbClasses
            // 
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Items.AddRange(new object[] {
            "1반",
            "2반"});
            this.cbClasses.Location = new System.Drawing.Point(252, 76);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(75, 23);
            this.cbClasses.TabIndex = 12;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(12, 109);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(38, 15);
            this.lbltime.TabIndex = 13;
            this.lbltime.Text = "학기 :";
            // 
            // cbSemester
            // 
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1학기",
            "2학기"});
            this.cbSemester.Location = new System.Drawing.Point(60, 106);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(100, 23);
            this.cbSemester.TabIndex = 14;
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 140);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.cbClasses);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbArmy);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblArmy);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentAdd";
            this.Text = "StudentAdd";
            this.Load += new System.EventHandler(this.StudentAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblNumber;
        private Label lblGrade;
        private Label lblArmy;
        private Label lblGender;
        private TextBox txtName;
        private TextBox txtNumber;
        private ComboBox cbGrade;
        private ComboBox cbArmy;
        private ComboBox cbGender;
        private Button btnAdd;
        private Label lblClasses;
        private ComboBox cbClasses;
        private Label lbltime;
        private ComboBox cbSemester;
    }
}