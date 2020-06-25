namespace ScreenStreamer
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
            this.label2 = new System.Windows.Forms.Label();
            this._spnPort = new System.Windows.Forms.NumericUpDown();
            this._btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._spnPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // _spnPort
            // 
            this._spnPort.Location = new System.Drawing.Point(68, 29);
            this._spnPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this._spnPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._spnPort.Name = "_spnPort";
            this._spnPort.Size = new System.Drawing.Size(120, 20);
            this._spnPort.TabIndex = 3;
            this._spnPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // _btnStart
            // 
            this._btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnStart.Location = new System.Drawing.Point(20, 70);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(168, 23);
            this._btnStart.TabIndex = 4;
            this._btnStart.Text = "Start Capture";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 126);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._spnPort);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Connection";
            ((System.ComponentModel.ISupportInitialize)(this._spnPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _spnPort;
        private System.Windows.Forms.Button _btnStart;
    }
}