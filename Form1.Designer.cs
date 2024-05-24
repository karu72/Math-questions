namespace Rand_Math_Questions
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
            this.butExit = new System.Windows.Forms.Button();
            this.butDiff1 = new System.Windows.Forms.Button();
            this.butDiff2 = new System.Windows.Forms.Button();
            this.butDiff3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(212, 249);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(150, 100);
            this.butExit.TabIndex = 1;
            this.butExit.Text = "AIZVĒRT";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butDiff1
            // 
            this.butDiff1.BackColor = System.Drawing.Color.LawnGreen;
            this.butDiff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiff1.Location = new System.Drawing.Point(83, 88);
            this.butDiff1.Name = "butDiff1";
            this.butDiff1.Size = new System.Drawing.Size(75, 65);
            this.butDiff1.TabIndex = 2;
            this.butDiff1.Text = "1";
            this.butDiff1.UseVisualStyleBackColor = false;
            this.butDiff1.Click += new System.EventHandler(this.butDiff1_Click);
            // 
            // butDiff2
            // 
            this.butDiff2.BackColor = System.Drawing.Color.Gold;
            this.butDiff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiff2.Location = new System.Drawing.Point(250, 88);
            this.butDiff2.Name = "butDiff2";
            this.butDiff2.Size = new System.Drawing.Size(75, 65);
            this.butDiff2.TabIndex = 3;
            this.butDiff2.Text = "2";
            this.butDiff2.UseVisualStyleBackColor = false;
            this.butDiff2.Click += new System.EventHandler(this.butDiff2_Click);
            // 
            // butDiff3
            // 
            this.butDiff3.BackColor = System.Drawing.Color.OrangeRed;
            this.butDiff3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiff3.Location = new System.Drawing.Point(417, 88);
            this.butDiff3.Name = "butDiff3";
            this.butDiff3.Size = new System.Drawing.Size(75, 65);
            this.butDiff3.TabIndex = 4;
            this.butDiff3.Text = "3";
            this.butDiff3.UseVisualStyleBackColor = false;
            this.butDiff3.Click += new System.EventHandler(this.butDiff3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Izvēlies grūtības pakāpi";
            // 
            // labRes
            // 
            this.labRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labRes.Location = new System.Drawing.Point(78, 191);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(414, 45);
            this.labRes.TabIndex = 6;
            this.labRes.Text = "Result";
            this.labRes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labRes.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDiff3);
            this.Controls.Add(this.butDiff2);
            this.Controls.Add(this.butDiff1);
            this.Controls.Add(this.butExit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Rēķināšana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butDiff1;
        private System.Windows.Forms.Button butDiff2;
        private System.Windows.Forms.Button butDiff3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labRes;
    }
}

