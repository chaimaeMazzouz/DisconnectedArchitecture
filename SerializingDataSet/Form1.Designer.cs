namespace SerializingDataSet
{
    partial class Form1
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
            this.XML_btn = new System.Windows.Forms.Button();
            this.JSON_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XML_btn
            // 
            this.XML_btn.Location = new System.Drawing.Point(48, 58);
            this.XML_btn.Name = "XML_btn";
            this.XML_btn.Size = new System.Drawing.Size(122, 43);
            this.XML_btn.TabIndex = 0;
            this.XML_btn.Text = "Write To XML";
            this.XML_btn.UseVisualStyleBackColor = true;
            this.XML_btn.Click += new System.EventHandler(this.XML_btn_Click);
            // 
            // JSON_btn
            // 
            this.JSON_btn.Location = new System.Drawing.Point(246, 58);
            this.JSON_btn.Name = "JSON_btn";
            this.JSON_btn.Size = new System.Drawing.Size(122, 43);
            this.JSON_btn.TabIndex = 1;
            this.JSON_btn.Text = "Write To JSON";
            this.JSON_btn.UseVisualStyleBackColor = true;
            this.JSON_btn.Click += new System.EventHandler(this.JSON_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 156);
            this.Controls.Add(this.JSON_btn);
            this.Controls.Add(this.XML_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button XML_btn;
        private System.Windows.Forms.Button JSON_btn;
    }
}

