namespace Rand_Math_Questions
{
    partial class Form3
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
            this.labX = new System.Windows.Forms.Label();
            this.labOpp = new System.Windows.Forms.Label();
            this.labEquals = new System.Windows.Forms.Label();
            this.labY = new System.Windows.Forms.Label();
            this.butSubmit = new System.Windows.Forms.Button();
            this.butReroll = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.labAns = new System.Windows.Forms.Label();
            this.labClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labX
            // 
            this.labX.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labX.Location = new System.Drawing.Point(68, 98);
            this.labX.Name = "labX";
            this.labX.Size = new System.Drawing.Size(100, 60);
            this.labX.TabIndex = 0;
            this.labX.Text = "X";
            this.labX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labOpp
            // 
            this.labOpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOpp.Location = new System.Drawing.Point(165, 103);
            this.labOpp.Name = "labOpp";
            this.labOpp.Size = new System.Drawing.Size(85, 55);
            this.labOpp.TabIndex = 3;
            this.labOpp.Text = "+";
            this.labOpp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labEquals
            // 
            this.labEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEquals.Location = new System.Drawing.Point(342, 103);
            this.labEquals.Name = "labEquals";
            this.labEquals.Size = new System.Drawing.Size(85, 55);
            this.labEquals.TabIndex = 4;
            this.labEquals.Text = "=";
            this.labEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labY
            // 
            this.labY.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labY.Location = new System.Drawing.Point(247, 98);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(100, 60);
            this.labY.TabIndex = 5;
            this.labY.Text = "Y";
            this.labY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butSubmit
            // 
            this.butSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmit.Location = new System.Drawing.Point(213, 220);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(160, 100);
            this.butSubmit.TabIndex = 7;
            this.butSubmit.Text = "Pārbaudīt atbildi";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // butReroll
            // 
            this.butReroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReroll.Location = new System.Drawing.Point(67, 225);
            this.butReroll.Name = "butReroll";
            this.butReroll.Size = new System.Drawing.Size(140, 90);
            this.butReroll.TabIndex = 8;
            this.butReroll.Text = "Jauns uzdevums";
            this.butReroll.UseVisualStyleBackColor = true;
            this.butReroll.Click += new System.EventHandler(this.butReroll_Click);
            // 
            // butBack
            // 
            this.butBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.Location = new System.Drawing.Point(379, 225);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(140, 90);
            this.butBack.TabIndex = 9;
            this.butBack.Text = "Atpakaļ";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns.Location = new System.Drawing.Point(433, 104);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(127, 49);
            this.txtAns.TabIndex = 10;
            this.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labAns
            // 
            this.labAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAns.Location = new System.Drawing.Point(433, 104);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(127, 49);
            this.labAns.TabIndex = 11;
            this.labAns.Text = "ANS";
            this.labAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labAns.Visible = false;
            this.labAns.Click += new System.EventHandler(this.labAns_Click);
            // 
            // labClick
            // 
            this.labClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labClick.Location = new System.Drawing.Point(135, 9);
            this.labClick.Name = "labClick";
            this.labClick.Size = new System.Drawing.Size(306, 59);
            this.labClick.TabIndex = 12;
            this.labClick.Text = "Klikšķini atbildes logā, lai redzētu pareizo atbildi.";
            this.labClick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labClick);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butReroll);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.labY);
            this.Controls.Add(this.labEquals);
            this.Controls.Add(this.labOpp);
            this.Controls.Add(this.labX);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.txtAns);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form3";
            this.Text = "Rēķināšana";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labX;
        private System.Windows.Forms.Label labOpp;
        private System.Windows.Forms.Label labEquals;
        private System.Windows.Forms.Label labY;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.Button butReroll;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label labAns;
        private System.Windows.Forms.Label labClick;
    }
}