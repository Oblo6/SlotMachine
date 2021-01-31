namespace SlowMotionZarAt
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEkran = new System.Windows.Forms.Label();
            this.btnZarAt = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblEkran
            // 
            this.lblEkran.AutoSize = true;
            this.lblEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkran.Location = new System.Drawing.Point(60, 42);
            this.lblEkran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEkran.Name = "lblEkran";
            this.lblEkran.Size = new System.Drawing.Size(0, 46);
            this.lblEkran.TabIndex = 0;
            // 
            // btnZarAt
            // 
            this.btnZarAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZarAt.Location = new System.Drawing.Point(27, 25);
            this.btnZarAt.Name = "btnZarAt";
            this.btnZarAt.Size = new System.Drawing.Size(159, 72);
            this.btnZarAt.TabIndex = 1;
            this.btnZarAt.Text = "Zar At";
            this.btnZarAt.UseVisualStyleBackColor = true;
            this.btnZarAt.Click += new System.EventHandler(this.btnZarAt_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 122);
            this.Controls.Add(this.btnZarAt);
            this.Controls.Add(this.lblEkran);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblEkran;
        private System.Windows.Forms.Button btnZarAt;
        private System.Windows.Forms.Timer timer2;
    }
}

