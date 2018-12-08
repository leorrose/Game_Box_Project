namespace GameBox
{
    partial class Feedback_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback_form));
            this.Tb_Feedback = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_feedback_name = new System.Windows.Forms.TextBox();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Tb_Feedback
            // 
            this.Tb_Feedback.BackColor = System.Drawing.Color.SeaShell;
            this.Tb_Feedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Feedback.Location = new System.Drawing.Point(64, 107);
            this.Tb_Feedback.Name = "Tb_Feedback";
            this.Tb_Feedback.Size = new System.Drawing.Size(512, 425);
            this.Tb_Feedback.TabIndex = 1;
            this.Tb_Feedback.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(142, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leave a feedback:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(655, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insert Feedback";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bt_Insert_feedback);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(889, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Bt_Feedback_exit);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImage = global::GameBox.Properties.Resources.Back;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(783, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 44);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Bt_Feedback_back);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(684, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            // 
            // Tb_feedback_name
            // 
            this.Tb_feedback_name.BackColor = System.Drawing.Color.SandyBrown;
            this.Tb_feedback_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_feedback_name.Location = new System.Drawing.Point(655, 451);
            this.Tb_feedback_name.Name = "Tb_feedback_name";
            this.Tb_feedback_name.Size = new System.Drawing.Size(138, 22);
            this.Tb_feedback_name.TabIndex = 7;
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
            this.CB_music.Location = new System.Drawing.Point(13, 12);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(68, 44);
            this.CB_music.TabIndex = 29;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            // 
            // Feedback_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.ControlBox = false;
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.Tb_feedback_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Feedback);
            this.MaximumSize = new System.Drawing.Size(1016, 609);
            this.MinimumSize = new System.Drawing.Size(1016, 609);
            this.Name = "Feedback_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Tb_Feedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_feedback_name;
        private System.Windows.Forms.CheckBox CB_music;
    }
}