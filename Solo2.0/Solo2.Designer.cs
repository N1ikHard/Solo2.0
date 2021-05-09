
namespace Solo2._0
{
    partial class Solo2
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
            this.richTextBoxTuped = new System.Windows.Forms.RichTextBox();
            this.LabelTextTuped = new System.Windows.Forms.Label();
            this.labelTypedInfo = new System.Windows.Forms.Label();
            this.labelTyped = new System.Windows.Forms.Label();
            this.labelSpeedInfo = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelTimeInfo = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMistakesInfo = new System.Windows.Forms.Label();
            this.labelMistake = new System.Windows.Forms.Label();
            this.panelDesign1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelDesign2 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelDesign1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxTuped
            // 
            this.richTextBoxTuped.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxTuped.Location = new System.Drawing.Point(12, 137);
            this.richTextBoxTuped.Name = "richTextBoxTuped";
            this.richTextBoxTuped.Size = new System.Drawing.Size(760, 120);
            this.richTextBoxTuped.TabIndex = 0;
            this.richTextBoxTuped.Text = "";
            this.richTextBoxTuped.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxTuped_KeyPress);
            this.richTextBoxTuped.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBoxTuped_KeyUp);
            // 
            // LabelTextTuped
            // 
            this.LabelTextTuped.AutoSize = true;
            this.LabelTextTuped.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTextTuped.ForeColor = System.Drawing.Color.Red;
            this.LabelTextTuped.Location = new System.Drawing.Point(12, 54);
            this.LabelTextTuped.Name = "LabelTextTuped";
            this.LabelTextTuped.Size = new System.Drawing.Size(0, 38);
            this.LabelTextTuped.TabIndex = 1;
            // 
            // labelTypedInfo
            // 
            this.labelTypedInfo.AutoSize = true;
            this.labelTypedInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTypedInfo.ForeColor = System.Drawing.Color.Red;
            this.labelTypedInfo.Location = new System.Drawing.Point(13, 275);
            this.labelTypedInfo.Name = "labelTypedInfo";
            this.labelTypedInfo.Size = new System.Drawing.Size(114, 28);
            this.labelTypedInfo.TabIndex = 2;
            this.labelTypedInfo.Text = "Набранно:";
            // 
            // labelTyped
            // 
            this.labelTyped.AutoSize = true;
            this.labelTyped.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTyped.ForeColor = System.Drawing.Color.Red;
            this.labelTyped.Location = new System.Drawing.Point(122, 275);
            this.labelTyped.Name = "labelTyped";
            this.labelTyped.Size = new System.Drawing.Size(24, 28);
            this.labelTyped.TabIndex = 3;
            this.labelTyped.Text = "0";
            // 
            // labelSpeedInfo
            // 
            this.labelSpeedInfo.AutoSize = true;
            this.labelSpeedInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSpeedInfo.ForeColor = System.Drawing.Color.Red;
            this.labelSpeedInfo.Location = new System.Drawing.Point(506, 275);
            this.labelSpeedInfo.Name = "labelSpeedInfo";
            this.labelSpeedInfo.Size = new System.Drawing.Size(106, 28);
            this.labelSpeedInfo.TabIndex = 2;
            this.labelSpeedInfo.Text = "Скорость:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSpeed.ForeColor = System.Drawing.Color.Red;
            this.labelSpeed.Location = new System.Drawing.Point(605, 275);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(24, 28);
            this.labelSpeed.TabIndex = 3;
            this.labelSpeed.Text = "0";
            // 
            // labelTimeInfo
            // 
            this.labelTimeInfo.AutoSize = true;
            this.labelTimeInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeInfo.ForeColor = System.Drawing.Color.Red;
            this.labelTimeInfo.Location = new System.Drawing.Point(203, 275);
            this.labelTimeInfo.Name = "labelTimeInfo";
            this.labelTimeInfo.Size = new System.Drawing.Size(80, 28);
            this.labelTimeInfo.TabIndex = 2;
            this.labelTimeInfo.Text = "Время:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(275, 275);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(24, 28);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "0";
            // 
            // labelMistakesInfo
            // 
            this.labelMistakesInfo.AutoSize = true;
            this.labelMistakesInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMistakesInfo.ForeColor = System.Drawing.Color.Red;
            this.labelMistakesInfo.Location = new System.Drawing.Point(372, 275);
            this.labelMistakesInfo.Name = "labelMistakesInfo";
            this.labelMistakesInfo.Size = new System.Drawing.Size(98, 28);
            this.labelMistakesInfo.TabIndex = 2;
            this.labelMistakesInfo.Text = "Ошибки:";
            // 
            // labelMistake
            // 
            this.labelMistake.AutoSize = true;
            this.labelMistake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMistake.ForeColor = System.Drawing.Color.Red;
            this.labelMistake.Location = new System.Drawing.Point(462, 275);
            this.labelMistake.Name = "labelMistake";
            this.labelMistake.Size = new System.Drawing.Size(24, 28);
            this.labelMistake.TabIndex = 3;
            this.labelMistake.Text = "0";
            // 
            // panelDesign1
            // 
            this.panelDesign1.BackColor = System.Drawing.Color.Black;
            this.panelDesign1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDesign1.Controls.Add(this.label9);
            this.panelDesign1.Controls.Add(this.panelDesign2);
            this.panelDesign1.Location = new System.Drawing.Point(-1, -7);
            this.panelDesign1.Name = "panelDesign1";
            this.panelDesign1.Size = new System.Drawing.Size(815, 46);
            this.panelDesign1.TabIndex = 4;
            this.panelDesign1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesign1_MouseDown);
            this.panelDesign1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDesign1_MouseMove);
            this.panelDesign1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDesign1_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(2, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "Solo 2.0";
            // 
            // panelDesign2
            // 
            this.panelDesign2.BackgroundImage = global::Solo2._0.Properties.Resources.Крест;
            this.panelDesign2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesign2.Location = new System.Drawing.Point(743, 7);
            this.panelDesign2.Name = "panelDesign2";
            this.panelDesign2.Size = new System.Drawing.Size(38, 37);
            this.panelDesign2.TabIndex = 5;
            this.panelDesign2.Click += new System.EventHandler(this.panelDesign2_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Solo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(788, 323);
            this.Controls.Add(this.labelSpeedInfo);
            this.Controls.Add(this.panelDesign1);
            this.Controls.Add(this.labelMistake);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelMistakesInfo);
            this.Controls.Add(this.labelTimeInfo);
            this.Controls.Add(this.labelTyped);
            this.Controls.Add(this.labelTypedInfo);
            this.Controls.Add(this.LabelTextTuped);
            this.Controls.Add(this.richTextBoxTuped);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Solo2";
            this.Text = "Solo2";
            this.Load += new System.EventHandler(this.Solo2_Load);
            this.panelDesign1.ResumeLayout(false);
            this.panelDesign1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxTuped;
        private System.Windows.Forms.Label LabelTextTuped;
        private System.Windows.Forms.Label labelTypedInfo;
        private System.Windows.Forms.Label labelTyped;
        private System.Windows.Forms.Label labelSpeedInfo;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelTimeInfo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMistakesInfo;
        private System.Windows.Forms.Label labelMistake;
        private System.Windows.Forms.Panel panelDesign1;
        private System.Windows.Forms.Panel panelDesign2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer;
    }
}