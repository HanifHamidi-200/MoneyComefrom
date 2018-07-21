namespace RIME
{
    partial class fSub1
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
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypos1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypos2 = new System.Windows.Forms.TextBox();
            this.btnQNext = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.RichTextBox();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RealAnswer";
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(139, 102);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(191, 20);
            this.txtAnswer2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ProgressAnswer";
            // 
            // txtTypos1
            // 
            this.txtTypos1.BackColor = System.Drawing.Color.Yellow;
            this.txtTypos1.Location = new System.Drawing.Point(139, 153);
            this.txtTypos1.Name = "txtTypos1";
            this.txtTypos1.Size = new System.Drawing.Size(191, 20);
            this.txtTypos1.TabIndex = 5;
            this.txtTypos1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTypos1_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Typos";
            // 
            // txtTypos2
            // 
            this.txtTypos2.Location = new System.Drawing.Point(336, 153);
            this.txtTypos2.Name = "txtTypos2";
            this.txtTypos2.Size = new System.Drawing.Size(191, 20);
            this.txtTypos2.TabIndex = 6;
            // 
            // btnQNext
            // 
            this.btnQNext.Location = new System.Drawing.Point(416, 51);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(88, 45);
            this.btnQNext.TabIndex = 7;
            this.btnQNext.Text = "QNext";
            this.btnQNext.UseVisualStyleBackColor = true;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(592, 51);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(145, 45);
            this.btnDatabase.TabIndex = 8;
            this.btnDatabase.Text = "ChooseDatabase";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(592, 102);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(191, 20);
            this.txtDatabase.TabIndex = 9;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(139, 28);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(191, 58);
            this.txtAnswer1.TabIndex = 10;
            this.txtAnswer1.Text = "";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecord.Location = new System.Drawing.Point(50, 236);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(88, 15);
            this.lblRecord.TabIndex = 11;
            this.lblRecord.Text = "RECORD = [0,0]";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Location = new System.Drawing.Point(158, 236);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 15);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score = 0";
            // 
            // fSub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 322);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.txtTypos2);
            this.Controls.Add(this.txtTypos1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fSub1";
            this.Text = "TypingTuter";
            this.Load += new System.EventHandler(this.fSub1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTypos1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypos2;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.RichTextBox txtAnswer1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblScore;
    }
}