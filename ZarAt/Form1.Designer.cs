namespace ZarAt
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
            this.btnZarAr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZarAr
            // 
            this.btnZarAr.Location = new System.Drawing.Point(12, 12);
            this.btnZarAr.Name = "btnZarAr";
            this.btnZarAr.Size = new System.Drawing.Size(154, 51);
            this.btnZarAr.TabIndex = 0;
            this.btnZarAr.Text = "Zar At";
            this.btnZarAr.UseVisualStyleBackColor = true;
            this.btnZarAr.Click += new System.EventHandler(this.btnZarAr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 73);
            this.Controls.Add(this.btnZarAr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZarAr;
    }
}

