namespace TranscendenceDatabase
{
    partial class Form1
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
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.btnOpen4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen1.Location = new System.Drawing.Point(29, 51);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(272, 51);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.Text = "AimsLeaves";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen2.Location = new System.Drawing.Point(29, 108);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(272, 51);
            this.btnOpen2.TabIndex = 1;
            this.btnOpen2.Text = "DustGatherer";
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // btnOpen3
            // 
            this.btnOpen3.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen3.Location = new System.Drawing.Point(29, 165);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(272, 51);
            this.btnOpen3.TabIndex = 2;
            this.btnOpen3.Text = "SurruptitiousDegree";
            this.btnOpen3.UseVisualStyleBackColor = false;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen3_Click);
            // 
            // btnOpen4
            // 
            this.btnOpen4.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen4.Location = new System.Drawing.Point(29, 222);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(272, 51);
            this.btnOpen4.TabIndex = 3;
            this.btnOpen4.Text = "PureGain";
            this.btnOpen4.UseVisualStyleBackColor = false;
            this.btnOpen4.Click += new System.EventHandler(this.btnOpen4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(363, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "DatabaseOrganisationHypertext_equivalencesare:-";
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Items.AddRange(new object[] {
            "NumericalSpoolerOrganiser",
            "PitchPerfectDataValues",
            "RelevantDataChecklist",
            "RelationalFieldsChecklist",
            "MazerunnerParityBit",
            "MesmeretParityBit",
            "SpotonConsolationReguarding",
            "hCOLUMNUsage",
            "ADCEScrollValues",
            "MaskedEditFormatValues"});
            this.lst1.Location = new System.Drawing.Point(363, 80);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(314, 212);
            this.lst1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 316);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen4);
            this.Controls.Add(this.btnOpen3);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen1);
            this.Name = "Form1";
            this.Text = "TranscendenceDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst1;
    }
}

