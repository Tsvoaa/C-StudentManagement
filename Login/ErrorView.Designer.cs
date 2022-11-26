namespace StudentManagement
{
    partial class ErrorView
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
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.lvError = new System.Windows.Forms.ListView();
            this.chCount = new System.Windows.Forms.ColumnHeader();
            this.chContent = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Location = new System.Drawing.Point(12, 9);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(42, 15);
            this.lblStudentNum.TabIndex = 0;
            this.lblStudentNum.Text = "학번 : ";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(166, 9);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(42, 15);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "이름 : ";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(214, 6);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(100, 23);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(60, 6);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.ReadOnly = true;
            this.txtStudentNum.Size = new System.Drawing.Size(100, 23);
            this.txtStudentNum.TabIndex = 3;
            // 
            // lvError
            // 
            this.lvError.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCount,
            this.chContent});
            this.lvError.Location = new System.Drawing.Point(7, 35);
            this.lvError.Name = "lvError";
            this.lvError.Size = new System.Drawing.Size(766, 268);
            this.lvError.TabIndex = 4;
            this.lvError.UseCompatibleStateImageBehavior = false;
            this.lvError.View = System.Windows.Forms.View.Details;
            // 
            // chCount
            // 
            this.chCount.Text = "번호";
            // 
            // chContent
            // 
            this.chContent.Text = "내역";
            this.chContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chContent.Width = 700;
            // 
            // ErrorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 311);
            this.Controls.Add(this.lvError);
            this.Controls.Add(this.txtStudentNum);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentNum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorView";
            this.Text = "ErrorView";
            this.Load += new System.EventHandler(this.ErrorView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStudentNum;
        private Label lblStudentName;
        private TextBox txtStudentName;
        private TextBox txtStudentNum;
        private ListView lvError;
        private ColumnHeader chCount;
        private ColumnHeader chContent;
    }
}