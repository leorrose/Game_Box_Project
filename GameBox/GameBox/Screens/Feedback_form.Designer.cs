﻿namespace GameBox
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
            this.Bt_insert_feedback = new System.Windows.Forms.Button();
            this.Bt_feedback_exit = new System.Windows.Forms.Button();
            this.Bt_feedback_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_feedback_name = new System.Windows.Forms.TextBox();
            this.CB_music = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Tb_Feedback
            // 
            this.Tb_Feedback.BackColor = System.Drawing.Color.SeaShell;
            this.Tb_Feedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tb_Feedback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Feedback.Location = new System.Drawing.Point(85, 107);
            this.Tb_Feedback.Name = "Tb_Feedback";
            this.Tb_Feedback.Size = new System.Drawing.Size(720, 552);
            this.Tb_Feedback.TabIndex = 1;
            this.Tb_Feedback.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(248, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leave A Feedback:";
            // 
            // Bt_insert_feedback
            // 
            this.Bt_insert_feedback.BackgroundImage = global::GameBox.Properties.Resources.Button_background;
            this.Bt_insert_feedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_insert_feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_insert_feedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_insert_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_insert_feedback.Location = new System.Drawing.Point(949, 604);
            this.Bt_insert_feedback.Name = "Bt_insert_feedback";
            this.Bt_insert_feedback.Size = new System.Drawing.Size(206, 55);
            this.Bt_insert_feedback.TabIndex = 3;
            this.Bt_insert_feedback.Text = "Insert Feedback";
            this.Bt_insert_feedback.UseVisualStyleBackColor = true;
            this.Bt_insert_feedback.Click += new System.EventHandler(this.Bt_Insert_feedback_click);
            this.Bt_insert_feedback.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bt_insert_feedback_KeyDown);
            // 
            // Bt_feedback_exit
            // 
            this.Bt_feedback_exit.BackColor = System.Drawing.Color.Black;
            this.Bt_feedback_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_feedback_exit.BackgroundImage")));
            this.Bt_feedback_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_feedback_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_feedback_exit.FlatAppearance.BorderSize = 0;
            this.Bt_feedback_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_feedback_exit.Location = new System.Drawing.Point(1055, 12);
            this.Bt_feedback_exit.Name = "Bt_feedback_exit";
            this.Bt_feedback_exit.Size = new System.Drawing.Size(100, 55);
            this.Bt_feedback_exit.TabIndex = 0;
            this.Bt_feedback_exit.TabStop = false;
            this.Bt_feedback_exit.UseVisualStyleBackColor = false;
            this.Bt_feedback_exit.Click += new System.EventHandler(this.Bt_Feedback_exit_click);
            // 
            // Bt_feedback_back
            // 
            this.Bt_feedback_back.BackColor = System.Drawing.Color.Black;
            this.Bt_feedback_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_feedback_back.BackgroundImage")));
            this.Bt_feedback_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_feedback_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_feedback_back.FlatAppearance.BorderSize = 0;
            this.Bt_feedback_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_feedback_back.Location = new System.Drawing.Point(949, 12);
            this.Bt_feedback_back.Name = "Bt_feedback_back";
            this.Bt_feedback_back.Size = new System.Drawing.Size(100, 55);
            this.Bt_feedback_back.TabIndex = 0;
            this.Bt_feedback_back.TabStop = false;
            this.Bt_feedback_back.UseVisualStyleBackColor = false;
            this.Bt_feedback_back.Click += new System.EventHandler(this.Bt_Feedback_back_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(811, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            // 
            // Tb_feedback_name
            // 
            this.Tb_feedback_name.BackColor = System.Drawing.Color.Salmon;
            this.Tb_feedback_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_feedback_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tb_feedback_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_feedback_name.Location = new System.Drawing.Point(949, 551);
            this.Tb_feedback_name.Name = "Tb_feedback_name";
            this.Tb_feedback_name.Size = new System.Drawing.Size(206, 29);
            this.Tb_feedback_name.TabIndex = 2;
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
            this.CB_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music.Location = new System.Drawing.Point(13, 14);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(157, 53);
            this.CB_music.TabIndex = 0;
            this.CB_music.TabStop = false;
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = false;
            this.CB_music.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Feedback_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.Tb_feedback_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bt_feedback_back);
            this.Controls.Add(this.Bt_feedback_exit);
            this.Controls.Add(this.Bt_insert_feedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Feedback);
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "Feedback_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Tb_Feedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_insert_feedback;
        private System.Windows.Forms.Button Bt_feedback_exit;
        private System.Windows.Forms.Button Bt_feedback_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_feedback_name;
        public System.Windows.Forms.CheckBox CB_music;
    }
}