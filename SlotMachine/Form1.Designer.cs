namespace SlotMachine
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
            this.btnCek = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbMeyveBir = new System.Windows.Forms.PictureBox();
            this.pbMeyveIki = new System.Windows.Forms.PictureBox();
            this.pbMeyveUc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeyveBir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeyveIki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeyveUc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(48, 254);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(623, 112);
            this.btnCek.TabIndex = 0;
            this.btnCek.Text = "CEK";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbMeyveBir
            // 
            this.pbMeyveBir.Location = new System.Drawing.Point(47, 27);
            this.pbMeyveBir.Name = "pbMeyveBir";
            this.pbMeyveBir.Size = new System.Drawing.Size(189, 186);
            this.pbMeyveBir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMeyveBir.TabIndex = 1;
            this.pbMeyveBir.TabStop = false;
            // 
            // pbMeyveIki
            // 
            this.pbMeyveIki.Location = new System.Drawing.Point(267, 27);
            this.pbMeyveIki.Name = "pbMeyveIki";
            this.pbMeyveIki.Size = new System.Drawing.Size(189, 186);
            this.pbMeyveIki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMeyveIki.TabIndex = 2;
            this.pbMeyveIki.TabStop = false;
            // 
            // pbMeyveUc
            // 
            this.pbMeyveUc.Location = new System.Drawing.Point(482, 27);
            this.pbMeyveUc.Name = "pbMeyveUc";
            this.pbMeyveUc.Size = new System.Drawing.Size(189, 186);
            this.pbMeyveUc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMeyveUc.TabIndex = 3;
            this.pbMeyveUc.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCek;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 386);
            this.Controls.Add(this.pbMeyveUc);
            this.Controls.Add(this.pbMeyveIki);
            this.Controls.Add(this.pbMeyveBir);
            this.Controls.Add(this.btnCek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMeyveBir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeyveIki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeyveUc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbMeyveBir;
        private System.Windows.Forms.PictureBox pbMeyveIki;
        private System.Windows.Forms.PictureBox pbMeyveUc;
    }
}

