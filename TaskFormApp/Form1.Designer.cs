namespace TaskFormApp
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnCounterPlus = new System.Windows.Forms.Button();
            this.rchFile = new System.Windows.Forms.RichTextBox();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(13, 13);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(114, 40);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnCounterPlus
            // 
            this.btnCounterPlus.Location = new System.Drawing.Point(302, 13);
            this.btnCounterPlus.Name = "btnCounterPlus";
            this.btnCounterPlus.Size = new System.Drawing.Size(114, 40);
            this.btnCounterPlus.TabIndex = 1;
            this.btnCounterPlus.Text = "Counter Plus";
            this.btnCounterPlus.UseVisualStyleBackColor = true;
            this.btnCounterPlus.Click += new System.EventHandler(this.btnCounterPlus_Click);
            // 
            // rchFile
            // 
            this.rchFile.Location = new System.Drawing.Point(13, 70);
            this.rchFile.Name = "rchFile";
            this.rchFile.Size = new System.Drawing.Size(114, 170);
            this.rchFile.TabIndex = 2;
            this.rchFile.Text = "";
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(302, 70);
            this.txtCounter.Multiline = true;
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(114, 38);
            this.txtCounter.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.rchFile);
            this.Controls.Add(this.btnCounterPlus);
            this.Controls.Add(this.btnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnCounterPlus;
        private System.Windows.Forms.RichTextBox rchFile;
        private System.Windows.Forms.TextBox txtCounter;
    }
}

