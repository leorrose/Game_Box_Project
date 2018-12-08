namespace GameBox
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bt_Reports_Exit = new System.Windows.Forms.Button();
            this.Bt_Reports_Back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.CB_music = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(33, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 456);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            // 
            // Bt_Reports_Exit
            // 
            this.Bt_Reports_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Reports_Exit.BackgroundImage")));
            this.Bt_Reports_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Reports_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Reports_Exit.Location = new System.Drawing.Point(894, 12);
            this.Bt_Reports_Exit.Name = "Bt_Reports_Exit";
            this.Bt_Reports_Exit.Size = new System.Drawing.Size(92, 48);
            this.Bt_Reports_Exit.TabIndex = 1;
            this.Bt_Reports_Exit.UseVisualStyleBackColor = true;
            this.Bt_Reports_Exit.Click += new System.EventHandler(this.Bt_Reports_Exit_click);
            // 
            // Bt_Reports_Back
            // 
            this.Bt_Reports_Back.BackColor = System.Drawing.Color.Black;
            this.Bt_Reports_Back.BackgroundImage = global::GameBox.Properties.Resources.Back;
            this.Bt_Reports_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Reports_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Reports_Back.Location = new System.Drawing.Point(796, 12);
            this.Bt_Reports_Back.Name = "Bt_Reports_Back";
            this.Bt_Reports_Back.Size = new System.Drawing.Size(92, 48);
            this.Bt_Reports_Back.TabIndex = 2;
            this.Bt_Reports_Back.UseVisualStyleBackColor = false;
            this.Bt_Reports_Back.Click += new System.EventHandler(this.Bt_reports_Back_click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.Gold;
            this.lb_title.Location = new System.Drawing.Point(55, 12);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(0, 41);
            this.lb_title.TabIndex = 50;
            // 
            // CB_music
            // 
            this.CB_music.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB_music.BackColor = System.Drawing.Color.Transparent;
            this.CB_music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB_music.BackgroundImage")));
            this.CB_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB_music.Checked = true;
            this.CB_music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_music.FlatAppearance.BorderSize = 0;
            this.CB_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_music.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music.Location = new System.Drawing.Point(716, 12);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(68, 48);
            this.CB_music.TabIndex = 51;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.ControlBox = false;
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.Bt_Reports_Back);
            this.Controls.Add(this.Bt_Reports_Exit);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1016, 609);
            this.MinimumSize = new System.Drawing.Size(1016, 609);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_Reports_Exit;
        private System.Windows.Forms.Button Bt_Reports_Back;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.CheckBox CB_music;
    }
}