namespace BasicQueuingSystem
{
    partial class CustomerViewcs
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
            this.lblNowServing = new System.Windows.Forms.Label();
            this.lblServing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNowServing
            // 
            this.lblNowServing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowServing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNowServing.Location = new System.Drawing.Point(91, 62);
            this.lblNowServing.Name = "lblNowServing";
            this.lblNowServing.Size = new System.Drawing.Size(205, 35);
            this.lblNowServing.TabIndex = 0;
            this.lblNowServing.Text = "* Now Serving";
            // 
            // lblServing
            // 
            this.lblServing.AutoSize = true;
            this.lblServing.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServing.Location = new System.Drawing.Point(107, 125);
            this.lblServing.Name = "lblServing";
            this.lblServing.Size = new System.Drawing.Size(197, 38);
            this.lblServing.TabIndex = 1;
            this.lblServing.Text = "---------------";
            this.lblServing.Click += new System.EventHandler(this.lblServing_Click);
            // 
            // CustomerViewcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblServing);
            this.Controls.Add(this.lblNowServing);
            this.Name = "CustomerViewcs";
            this.Text = "CustomerViewcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNowServing;
        private System.Windows.Forms.Label lblServing;
    }
}