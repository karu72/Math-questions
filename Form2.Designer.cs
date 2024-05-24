namespace Rand_Math_Questions
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.butAdd = new System.Windows.Forms.Button();
            this.butSub = new System.Windows.Forms.Button();
            this.butMult = new System.Windows.Forms.Button();
            this.butDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAdd
            // 
            this.butAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butAdd.BackgroundImage")));
            this.butAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(46, 93);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(85, 85);
            this.butAdd.TabIndex = 0;
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butSub
            // 
            this.butSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSub.BackgroundImage")));
            this.butSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSub.Location = new System.Drawing.Point(186, 93);
            this.butSub.Name = "butSub";
            this.butSub.Size = new System.Drawing.Size(85, 85);
            this.butSub.TabIndex = 1;
            this.butSub.UseVisualStyleBackColor = true;
            this.butSub.Click += new System.EventHandler(this.butSub_Click);
            // 
            // butMult
            // 
            this.butMult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butMult.BackgroundImage")));
            this.butMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMult.Location = new System.Drawing.Point(313, 93);
            this.butMult.Name = "butMult";
            this.butMult.Size = new System.Drawing.Size(85, 85);
            this.butMult.TabIndex = 2;
            this.butMult.UseVisualStyleBackColor = true;
            this.butMult.Click += new System.EventHandler(this.butMult_Click);
            // 
            // butDiv
            // 
            this.butDiv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butDiv.BackgroundImage")));
            this.butDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiv.Location = new System.Drawing.Point(448, 93);
            this.butDiv.Name = "butDiv";
            this.butDiv.Size = new System.Drawing.Size(85, 85);
            this.butDiv.TabIndex = 3;
            this.butDiv.UseVisualStyleBackColor = true;
            this.butDiv.Click += new System.EventHandler(this.butDiv_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.butDiv);
            this.Controls.Add(this.butMult);
            this.Controls.Add(this.butSub);
            this.Controls.Add(this.butAdd);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form2";
            this.Text = "Rēķināšana";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butSub;
        private System.Windows.Forms.Button butMult;
        private System.Windows.Forms.Button butDiv;
    }
}