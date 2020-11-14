namespace Gazi.Kazan.FormsApp
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
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.pnlGosterge = new System.Windows.Forms.Panel();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.pnlGosterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrButton
            // 
            this.tmrButton.Interval = 1000;
            this.tmrButton.Tick += new System.EventHandler(this.tmrButton_Tick);
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // pnlGosterge
            // 
            this.pnlGosterge.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlGosterge.Controls.Add(this.lblSkor);
            this.pnlGosterge.Controls.Add(this.lblSure);
            this.pnlGosterge.Location = new System.Drawing.Point(453, 1);
            this.pnlGosterge.Name = "pnlGosterge";
            this.pnlGosterge.Size = new System.Drawing.Size(168, 379);
            this.pnlGosterge.TabIndex = 0;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(46, 88);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(51, 19);
            this.lblSkor.TabIndex = 1;
            this.lblSkor.Text = "Skor:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(41, 35);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(2, 21);
            this.lblSure.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 381);
            this.Controls.Add(this.pnlGosterge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlGosterge.ResumeLayout(false);
            this.pnlGosterge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Panel pnlGosterge;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSure;
    }
}

