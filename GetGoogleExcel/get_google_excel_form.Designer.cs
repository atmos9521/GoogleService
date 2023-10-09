
namespace GetGoogleExcel
{
    partial class get_google_excel_form
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
            this.read_google_excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // read_google_excel
            // 
            this.read_google_excel.Location = new System.Drawing.Point(38, 12);
            this.read_google_excel.Name = "read_google_excel";
            this.read_google_excel.Size = new System.Drawing.Size(192, 62);
            this.read_google_excel.TabIndex = 0;
            this.read_google_excel.Text = "ReadGoogleExcel";
            this.read_google_excel.UseVisualStyleBackColor = true;
            this.read_google_excel.Click += new System.EventHandler(this.read_google_excel_Click);
            // 
            // get_google_excel_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 86);
            this.Controls.Add(this.read_google_excel);
            this.Name = "get_google_excel_form";
            this.Text = "get_google_excel_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.get_google_excel_form_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button read_google_excel;
    }
}