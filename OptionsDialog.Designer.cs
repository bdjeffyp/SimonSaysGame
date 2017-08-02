namespace SimonSaysGame
{
    partial class OptionsDialog
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
            this.groupSoundFiles = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textUpSoundFile = new System.Windows.Forms.TextBox();
            this.textLeftSoundFile = new System.Windows.Forms.TextBox();
            this.textRightSoundFile = new System.Windows.Forms.TextBox();
            this.textDownSoundFile = new System.Windows.Forms.TextBox();
            this.btnUpSoundBrowse = new System.Windows.Forms.Button();
            this.btnLeftSoundBrowse = new System.Windows.Forms.Button();
            this.btnRightSoundBrowse = new System.Windows.Forms.Button();
            this.btnDownSoundBrowse = new System.Windows.Forms.Button();
            this.groupKeyConfig = new System.Windows.Forms.GroupBox();
            this.radioArrows = new System.Windows.Forms.RadioButton();
            this.radioWasd = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetScores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupSoundFiles.SuspendLayout();
            this.groupKeyConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSoundFiles
            // 
            this.groupSoundFiles.Controls.Add(this.btnDownSoundBrowse);
            this.groupSoundFiles.Controls.Add(this.btnRightSoundBrowse);
            this.groupSoundFiles.Controls.Add(this.btnLeftSoundBrowse);
            this.groupSoundFiles.Controls.Add(this.btnUpSoundBrowse);
            this.groupSoundFiles.Controls.Add(this.textDownSoundFile);
            this.groupSoundFiles.Controls.Add(this.textRightSoundFile);
            this.groupSoundFiles.Controls.Add(this.textLeftSoundFile);
            this.groupSoundFiles.Controls.Add(this.textUpSoundFile);
            this.groupSoundFiles.Controls.Add(this.label4);
            this.groupSoundFiles.Controls.Add(this.label3);
            this.groupSoundFiles.Controls.Add(this.label2);
            this.groupSoundFiles.Controls.Add(this.label1);
            this.groupSoundFiles.Location = new System.Drawing.Point(13, 13);
            this.groupSoundFiles.Name = "groupSoundFiles";
            this.groupSoundFiles.Size = new System.Drawing.Size(490, 159);
            this.groupSoundFiles.TabIndex = 0;
            this.groupSoundFiles.TabStop = false;
            this.groupSoundFiles.Text = "Sound Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Up:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Right:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Down:";
            // 
            // textUpSoundFile
            // 
            this.textUpSoundFile.Enabled = false;
            this.textUpSoundFile.Location = new System.Drawing.Point(58, 25);
            this.textUpSoundFile.Name = "textUpSoundFile";
            this.textUpSoundFile.Size = new System.Drawing.Size(334, 25);
            this.textUpSoundFile.TabIndex = 4;
            // 
            // textLeftSoundFile
            // 
            this.textLeftSoundFile.Enabled = false;
            this.textLeftSoundFile.Location = new System.Drawing.Point(58, 57);
            this.textLeftSoundFile.Name = "textLeftSoundFile";
            this.textLeftSoundFile.Size = new System.Drawing.Size(334, 25);
            this.textLeftSoundFile.TabIndex = 5;
            // 
            // textRightSoundFile
            // 
            this.textRightSoundFile.Enabled = false;
            this.textRightSoundFile.Location = new System.Drawing.Point(58, 89);
            this.textRightSoundFile.Name = "textRightSoundFile";
            this.textRightSoundFile.Size = new System.Drawing.Size(334, 25);
            this.textRightSoundFile.TabIndex = 6;
            // 
            // textDownSoundFile
            // 
            this.textDownSoundFile.Enabled = false;
            this.textDownSoundFile.Location = new System.Drawing.Point(58, 121);
            this.textDownSoundFile.Name = "textDownSoundFile";
            this.textDownSoundFile.Size = new System.Drawing.Size(334, 25);
            this.textDownSoundFile.TabIndex = 7;
            // 
            // btnUpSoundBrowse
            // 
            this.btnUpSoundBrowse.Enabled = false;
            this.btnUpSoundBrowse.Location = new System.Drawing.Point(398, 25);
            this.btnUpSoundBrowse.Name = "btnUpSoundBrowse";
            this.btnUpSoundBrowse.Size = new System.Drawing.Size(86, 26);
            this.btnUpSoundBrowse.TabIndex = 8;
            this.btnUpSoundBrowse.Text = "Browse...";
            this.btnUpSoundBrowse.UseVisualStyleBackColor = true;
            // 
            // btnLeftSoundBrowse
            // 
            this.btnLeftSoundBrowse.Enabled = false;
            this.btnLeftSoundBrowse.Location = new System.Drawing.Point(398, 57);
            this.btnLeftSoundBrowse.Name = "btnLeftSoundBrowse";
            this.btnLeftSoundBrowse.Size = new System.Drawing.Size(86, 26);
            this.btnLeftSoundBrowse.TabIndex = 9;
            this.btnLeftSoundBrowse.Text = "Browse...";
            this.btnLeftSoundBrowse.UseVisualStyleBackColor = true;
            // 
            // btnRightSoundBrowse
            // 
            this.btnRightSoundBrowse.Enabled = false;
            this.btnRightSoundBrowse.Location = new System.Drawing.Point(398, 89);
            this.btnRightSoundBrowse.Name = "btnRightSoundBrowse";
            this.btnRightSoundBrowse.Size = new System.Drawing.Size(86, 26);
            this.btnRightSoundBrowse.TabIndex = 10;
            this.btnRightSoundBrowse.Text = "Browse...";
            this.btnRightSoundBrowse.UseVisualStyleBackColor = true;
            // 
            // btnDownSoundBrowse
            // 
            this.btnDownSoundBrowse.Enabled = false;
            this.btnDownSoundBrowse.Location = new System.Drawing.Point(398, 121);
            this.btnDownSoundBrowse.Name = "btnDownSoundBrowse";
            this.btnDownSoundBrowse.Size = new System.Drawing.Size(86, 26);
            this.btnDownSoundBrowse.TabIndex = 11;
            this.btnDownSoundBrowse.Text = "Browse...";
            this.btnDownSoundBrowse.UseVisualStyleBackColor = true;
            // 
            // groupKeyConfig
            // 
            this.groupKeyConfig.Controls.Add(this.radioWasd);
            this.groupKeyConfig.Controls.Add(this.radioArrows);
            this.groupKeyConfig.Location = new System.Drawing.Point(13, 179);
            this.groupKeyConfig.Name = "groupKeyConfig";
            this.groupKeyConfig.Size = new System.Drawing.Size(147, 86);
            this.groupKeyConfig.TabIndex = 1;
            this.groupKeyConfig.TabStop = false;
            this.groupKeyConfig.Text = "Key Configuration";
            // 
            // radioArrows
            // 
            this.radioArrows.AutoSize = true;
            this.radioArrows.Checked = true;
            this.radioArrows.Location = new System.Drawing.Point(13, 24);
            this.radioArrows.Name = "radioArrows";
            this.radioArrows.Size = new System.Drawing.Size(92, 21);
            this.radioArrows.TabIndex = 0;
            this.radioArrows.TabStop = true;
            this.radioArrows.Text = "Arrow Keys";
            this.radioArrows.UseVisualStyleBackColor = true;
            // 
            // radioWasd
            // 
            this.radioWasd.AutoSize = true;
            this.radioWasd.Location = new System.Drawing.Point(13, 52);
            this.radioWasd.Name = "radioWasd";
            this.radioWasd.Size = new System.Drawing.Size(92, 21);
            this.radioWasd.TabIndex = 1;
            this.radioWasd.TabStop = true;
            this.radioWasd.Text = "WASD Keys";
            this.radioWasd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetScores);
            this.groupBox1.Location = new System.Drawing.Point(180, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reset High Scores";
            // 
            // btnResetScores
            // 
            this.btnResetScores.BackColor = System.Drawing.Color.Red;
            this.btnResetScores.Location = new System.Drawing.Point(38, 30);
            this.btnResetScores.Name = "btnResetScores";
            this.btnResetScores.Size = new System.Drawing.Size(127, 35);
            this.btnResetScores.TabIndex = 0;
            this.btnResetScores.Text = "Reset Scores";
            this.btnResetScores.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupKeyConfig);
            this.Controls.Add(this.groupSoundFiles);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OptionsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon Says - Options";
            this.groupSoundFiles.ResumeLayout(false);
            this.groupSoundFiles.PerformLayout();
            this.groupKeyConfig.ResumeLayout(false);
            this.groupKeyConfig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSoundFiles;
        private System.Windows.Forms.Button btnDownSoundBrowse;
        private System.Windows.Forms.Button btnRightSoundBrowse;
        private System.Windows.Forms.Button btnLeftSoundBrowse;
        private System.Windows.Forms.Button btnUpSoundBrowse;
        private System.Windows.Forms.TextBox textDownSoundFile;
        private System.Windows.Forms.TextBox textRightSoundFile;
        private System.Windows.Forms.TextBox textLeftSoundFile;
        private System.Windows.Forms.TextBox textUpSoundFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupKeyConfig;
        private System.Windows.Forms.RadioButton radioWasd;
        private System.Windows.Forms.RadioButton radioArrows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetScores;
        private System.Windows.Forms.Button button1;
    }
}