namespace ScreenStreamViewer
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
            this._imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _imageBox
            // 
            this._imageBox.Location = new System.Drawing.Point(12, 12);
            this._imageBox.Name = "_imageBox";
            this._imageBox.Size = new System.Drawing.Size(566, 324);
            this._imageBox.TabIndex = 0;
            this._imageBox.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(610, 400);
            this.Controls.Add(this._imageBox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _imageBox;
    }
}

