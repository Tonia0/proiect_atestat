
namespace proiect_atestat
{
    partial class Form2
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
            this.text_sfarsit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_sfarsit
            // 
            this.text_sfarsit.AutoSize = true;
            this.text_sfarsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sfarsit.Location = new System.Drawing.Point(120, 182);
            this.text_sfarsit.Name = "text_sfarsit";
            this.text_sfarsit.Size = new System.Drawing.Size(357, 31);
            this.text_sfarsit.TabIndex = 0;
            this.text_sfarsit.Text = "Permisul tău a fost reținut.\r\n";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 617);
            this.Controls.Add(this.text_sfarsit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_sfarsit;
    }
}