namespace RoundButtons
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roundButton4 = new RoundButtons.RoundButton();
            this.roundButton3 = new RoundButtons.RoundButton();
            this.roundButton2 = new RoundButtons.RoundButton();
            this.roundButton1 = new RoundButtons.RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 88);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roundButton3);
            this.panel2.Controls.Add(this.roundButton2);
            this.panel2.Controls.Add(this.roundButton1);
            this.panel2.Location = new System.Drawing.Point(265, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 68);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panel3.Controls.Add(this.roundButton4);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 344);
            this.panel3.TabIndex = 1;
            // 
            // roundButton4
            // 
            this.roundButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton4.Image = ((System.Drawing.Image)(resources.GetObject("roundButton4.Image")));
            this.roundButton4.Location = new System.Drawing.Point(749, 3);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(24, 24);
            this.roundButton4.TabIndex = 3;
            this.roundButton4.UseVisualStyleBackColor = true;
            this.roundButton4.Click += new System.EventHandler(this.CloseForm);
            // 
            // roundButton3
            // 
            this.roundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton3.Image = ((System.Drawing.Image)(resources.GetObject("roundButton3.Image")));
            this.roundButton3.Location = new System.Drawing.Point(179, 9);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(50, 50);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.Image = ((System.Drawing.Image)(resources.GetObject("roundButton2.Image")));
            this.roundButton2.Location = new System.Drawing.Point(109, 9);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(50, 50);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // roundButton1
            // 
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.Image = ((System.Drawing.Image)(resources.GetObject("roundButton1.Image")));
            this.roundButton1.Location = new System.Drawing.Point(38, 9);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(50, 50);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RoundButton roundButton1;
        private RoundButton roundButton3;
        private RoundButton roundButton2;
        private System.Windows.Forms.Panel panel3;
        private RoundButton roundButton4;
    }
}

