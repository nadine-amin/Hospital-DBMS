﻿namespace DBapplication
{
    partial class D_ViewSchedule
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
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.view_schedule_btn = new System.Windows.Forms.Button();
            this.doctor_view_schedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_view_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(244, 341);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 96;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(133, 341);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 95;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // view_schedule_btn
            // 
            this.view_schedule_btn.Location = new System.Drawing.Point(172, 262);
            this.view_schedule_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_schedule_btn.Name = "view_schedule_btn";
            this.view_schedule_btn.Size = new System.Drawing.Size(139, 25);
            this.view_schedule_btn.TabIndex = 94;
            this.view_schedule_btn.Text = "View Schedule";
            this.view_schedule_btn.UseVisualStyleBackColor = true;
            // 
            // doctor_view_schedule
            // 
            this.doctor_view_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctor_view_schedule.Location = new System.Drawing.Point(16, 30);
            this.doctor_view_schedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctor_view_schedule.Name = "doctor_view_schedule";
            this.doctor_view_schedule.RowHeadersWidth = 51;
            this.doctor_view_schedule.Size = new System.Drawing.Size(451, 213);
            this.doctor_view_schedule.TabIndex = 97;
            // 
            // D_ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 388);
            this.Controls.Add(this.doctor_view_schedule);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.view_schedule_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "D_ViewSchedule";
            this.Text = "D_ViewSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.doctor_view_schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button view_schedule_btn;
        private System.Windows.Forms.DataGridView doctor_view_schedule;
    }
}