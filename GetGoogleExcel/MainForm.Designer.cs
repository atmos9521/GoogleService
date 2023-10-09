
namespace GetGoogleExcel
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.get_google_excel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // get_google_excel_btn
            // 
            this.get_google_excel_btn.Location = new System.Drawing.Point(24, 12);
            this.get_google_excel_btn.Name = "get_google_excel_btn";
            this.get_google_excel_btn.Size = new System.Drawing.Size(185, 63);
            this.get_google_excel_btn.TabIndex = 0;
            this.get_google_excel_btn.Text = "GetGoogleExcel";
            this.get_google_excel_btn.UseVisualStyleBackColor = true;
            this.get_google_excel_btn.Click += new System.EventHandler(this.get_google_excel_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 97);
            this.Controls.Add(this.get_google_excel_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button get_google_excel_btn;
    }
}

