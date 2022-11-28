namespace StudentManagement
{
    partial class ErrorAdd
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
            this.txtError = new System.Windows.Forms.TextBox();
            this.btnAddError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(12, 12);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(576, 227);
            this.txtError.TabIndex = 0;
            // 
            // btnAddError
            // 
            this.btnAddError.Location = new System.Drawing.Point(12, 245);
            this.btnAddError.Name = "btnAddError";
            this.btnAddError.Size = new System.Drawing.Size(576, 23);
            this.btnAddError.TabIndex = 1;
            this.btnAddError.Text = "추가하기";
            this.btnAddError.UseVisualStyleBackColor = true;
            this.btnAddError.Click += new System.EventHandler(this.btnAddError_Click);
            // 
            // ErrorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 279);
            this.Controls.Add(this.btnAddError);
            this.Controls.Add(this.txtError);
            this.Name = "ErrorAdd";
            this.Text = "ErrorAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtError;
        private Button btnAddError;
    }
}