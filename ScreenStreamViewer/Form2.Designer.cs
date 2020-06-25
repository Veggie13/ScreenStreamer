namespace ScreenStreamViewer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtAddress = new System.Windows.Forms.TextBox();
            this._spnPort = new System.Windows.Forms.NumericUpDown();
            this._btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._spnPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // _txtAddress
            // 
            this._txtAddress.Location = new System.Drawing.Point(68, 17);
            this._txtAddress.Name = "_txtAddress";
            this._txtAddress.Size = new System.Drawing.Size(100, 20);
            this._txtAddress.TabIndex = 2;
            // 
            // _spnPort
            // 
            this._spnPort.Location = new System.Drawing.Point(68, 50);
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
            // _btnConnect
            // 
            this._btnConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnConnect.Location = new System.Drawing.Point(20, 91);
            this._btnConnect.Name = "_btnConnect";
            this._btnConnect.Size = new System.Drawing.Size(168, 23);
            this._btnConnect.TabIndex = 4;
            this._btnConnect.Text = "Connect";
            this._btnConnect.UseVisualStyleBackColor = true;
            this._btnConnect.Click += new System.EventHandler(this._btnConnect_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 126);
            this.Controls.Add(this._btnConnect);
            this.Controls.Add(this._spnPort);
            this.Controls.Add(this._txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Connection";
            ((System.ComponentModel.ISupportInitialize)(this._spnPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtAddress;
        private System.Windows.Forms.NumericUpDown _spnPort;
        private System.Windows.Forms.Button _btnConnect;
    }
}