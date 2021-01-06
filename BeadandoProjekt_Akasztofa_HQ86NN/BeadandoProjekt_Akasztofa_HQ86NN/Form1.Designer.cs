namespace BeadandoProjekt_Akasztofa_HQ86NN
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
            this.ujjatek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hibak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.feladvany = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ujjatek
            // 
            this.ujjatek.Location = new System.Drawing.Point(12, 12);
            this.ujjatek.Name = "ujjatek";
            this.ujjatek.Size = new System.Drawing.Size(89, 39);
            this.ujjatek.TabIndex = 0;
            this.ujjatek.Text = "új játék";
            this.ujjatek.UseVisualStyleBackColor = true;
            this.ujjatek.Click += new System.EventHandler(this.ujjatek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(625, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "hibák:";
            // 
            // hibak
            // 
            this.hibak.Location = new System.Drawing.Point(688, 12);
            this.hibak.Name = "hibak";
            this.hibak.Size = new System.Drawing.Size(100, 20);
            this.hibak.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feladvány";
            // 
            // feladvany
            // 
            this.feladvany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feladvany.Location = new System.Drawing.Point(183, 37);
            this.feladvany.Name = "feladvany";
            this.feladvany.Size = new System.Drawing.Size(174, 31);
            this.feladvany.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.feladvany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hibak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ujjatek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ujjatek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hibak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox feladvany;
    }
}

