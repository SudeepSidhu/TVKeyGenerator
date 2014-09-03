namespace TV_Key_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPatch = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPatch
            // 
            this.btnPatch.Location = new System.Drawing.Point(109, 41);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(139, 27);
            this.btnPatch.TabIndex = 0;
            this.btnPatch.Text = "Find + Install a key";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // txtOut
            // 
            this.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOut.Location = new System.Drawing.Point(12, 16);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(332, 13);
            this.txtOut.TabIndex = 1;
            this.txtOut.TabStop = false;
            this.txtOut.Text = "Ready to go!";
            this.txtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 77);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnPatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T:V Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.TextBox txtOut;
    }
}

