namespace akasztófa
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
            this.button1 = new System.Windows.Forms.Button();
            this.feladvany = new System.Windows.Forms.TextBox();
            this.hibaszam = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.RadioButton();
            this.uzenet = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // feladvany
            // 
            this.feladvany.Location = new System.Drawing.Point(187, 45);
            this.feladvany.Name = "feladvany";
            this.feladvany.Size = new System.Drawing.Size(100, 20);
            this.feladvany.TabIndex = 1;
            // 
            // hibaszam
            // 
            this.hibaszam.Location = new System.Drawing.Point(294, 13);
            this.hibaszam.Name = "hibaszam";
            this.hibaszam.Size = new System.Drawing.Size(100, 20);
            this.hibaszam.TabIndex = 2;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(136, 12);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(85, 17);
            this.l.TabIndex = 3;
            this.l.TabStop = true;
            this.l.Text = "radioButton1";
            this.l.UseVisualStyleBackColor = true;
            // 
            // uzenet
            // 
            this.uzenet.AutoSize = true;
            this.uzenet.Location = new System.Drawing.Point(187, 72);
            this.uzenet.Name = "uzenet";
            this.uzenet.Size = new System.Drawing.Size(0, 13);
            this.uzenet.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uzenet);
            this.Controls.Add(this.l);
            this.Controls.Add(this.hibaszam);
            this.Controls.Add(this.feladvany);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox feladvany;
        private System.Windows.Forms.TextBox hibaszam;
        private System.Windows.Forms.RadioButton l;
        private System.Windows.Forms.Label uzenet;
        private System.Windows.Forms.Button button2;
    }
}

