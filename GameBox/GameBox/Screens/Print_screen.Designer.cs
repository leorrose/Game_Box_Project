namespace GameBox
{
    partial class Print_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_screen));
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(282, 197);
            this.label1.MaximumSize = new System.Drawing.Size(600, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "joijioh ouhuih iughiug iohuigh";
            // 
            // Bt_ok
            // 
            this.Bt_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_ok.BackgroundImage")));
            this.Bt_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_ok.Location = new System.Drawing.Point(1050, 636);
            this.Bt_ok.Name = "Bt_ok";
            this.Bt_ok.Size = new System.Drawing.Size(120, 55);
            this.Bt_ok.TabIndex = 1;
            this.Bt_ok.Text = "OK";
            this.Bt_ok.UseVisualStyleBackColor = true;
            this.Bt_ok.Click += new System.EventHandler(this.Bt_ok_Click);
            // 
            // Print_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.Bt_ok);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "Print_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_ok;
    }
}