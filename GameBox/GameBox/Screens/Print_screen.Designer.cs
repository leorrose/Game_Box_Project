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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_screen));
            this.Lb_Print = new System.Windows.Forms.Label();
            this.Bt_ok = new System.Windows.Forms.Button();
            this.PB_Gifs = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_why_to_register = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Gifs)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Print
            // 
            this.Lb_Print.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Print.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Print.ForeColor = System.Drawing.Color.LightPink;
            this.Lb_Print.Location = new System.Drawing.Point(197, 40);
            this.Lb_Print.MaximumSize = new System.Drawing.Size(600, 500);
            this.Lb_Print.Name = "Lb_Print";
            this.Lb_Print.Size = new System.Drawing.Size(496, 125);
            this.Lb_Print.TabIndex = 0;
            this.Lb_Print.Text = "tips and ads";
            this.Lb_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_ok
            // 
            this.Bt_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_ok.BackgroundImage")));
            this.Bt_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_ok.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_ok.Location = new System.Drawing.Point(761, 393);
            this.Bt_ok.Name = "Bt_ok";
            this.Bt_ok.Size = new System.Drawing.Size(109, 48);
            this.Bt_ok.TabIndex = 0;
            this.Bt_ok.TabStop = false;
            this.Bt_ok.Text = "OK";
            this.Bt_ok.UseVisualStyleBackColor = true;
            this.Bt_ok.Click += new System.EventHandler(this.Bt_ok_Click);
            // 
            // PB_Gifs
            // 
            this.PB_Gifs.BackColor = System.Drawing.Color.Transparent;
            this.PB_Gifs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Gifs.Location = new System.Drawing.Point(300, 216);
            this.PB_Gifs.Name = "PB_Gifs";
            this.PB_Gifs.Size = new System.Drawing.Size(288, 182);
            this.PB_Gifs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Gifs.TabIndex = 2;
            this.PB_Gifs.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.BackColor = System.Drawing.Color.Transparent;
            this.lb_time.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.LightPink;
            this.lb_time.Location = new System.Drawing.Point(805, 401);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(27, 30);
            this.lb_time.TabIndex = 3;
            this.lb_time.Text = "5";
            this.lb_time.Visible = false;
            // 
            // lb_why_to_register
            // 
            this.lb_why_to_register.AutoSize = true;
            this.lb_why_to_register.BackColor = System.Drawing.Color.Transparent;
            this.lb_why_to_register.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_why_to_register.ForeColor = System.Drawing.Color.LightPink;
            this.lb_why_to_register.Location = new System.Drawing.Point(197, 40);
            this.lb_why_to_register.MaximumSize = new System.Drawing.Size(600, 500);
            this.lb_why_to_register.Name = "lb_why_to_register";
            this.lb_why_to_register.Size = new System.Drawing.Size(195, 30);
            this.lb_why_to_register.TabIndex = 4;
            this.lb_why_to_register.Text = "why to register";
            this.lb_why_to_register.Visible = false;
            // 
            // Print_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.ControlBox = false;
            this.Controls.Add(this.lb_why_to_register);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.PB_Gifs);
            this.Controls.Add(this.Bt_ok);
            this.Controls.Add(this.Lb_Print);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Print_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Gifs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Print;
        private System.Windows.Forms.Button Bt_ok;
        private System.Windows.Forms.PictureBox PB_Gifs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_why_to_register;
    }
}