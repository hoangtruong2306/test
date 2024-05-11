namespace Hoang_815
{
    partial class frm2
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
            this.pictureB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureB
            // 
            this.pictureB.Location = new System.Drawing.Point(2, 5);
            this.pictureB.Name = "pictureB";
            this.pictureB.Size = new System.Drawing.Size(798, 450);
            this.pictureB.TabIndex = 0;
            this.pictureB.TabStop = false;
            this.pictureB.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureB_Paint);
            this.pictureB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureB_MouseDown);
            this.pictureB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureB_MouseMove);
            this.pictureB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureB_MouseUp);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureB);
            this.Name = "frm2";
            this.Text = "frm2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureB;
    }
}