namespace Gui_Part_2
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
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Uninstall = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hudControl1 = new Gui_Part_2.HudControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.Enabled = false;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("TF2", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Transparent;
            this.button10.Location = new System.Drawing.Point(804, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 48);
            this.button10.TabIndex = 10;
            this.button10.Text = "Install";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Download_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TF2", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Version 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TF2", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(278, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Path:";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(376, 15);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(422, 23);
            this.button12.TabIndex = 16;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Uninstall
            // 
            this.Uninstall.FlatAppearance.BorderSize = 0;
            this.Uninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uninstall.Font = new System.Drawing.Font("TF2", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uninstall.ForeColor = System.Drawing.Color.Transparent;
            this.Uninstall.Location = new System.Drawing.Point(943, 4);
            this.Uninstall.Name = "Uninstall";
            this.Uninstall.Size = new System.Drawing.Size(160, 48);
            this.Uninstall.TabIndex = 17;
            this.Uninstall.Text = "Uninstall";
            this.Uninstall.UseVisualStyleBackColor = true;
            this.Uninstall.Click += new System.EventHandler(this.Uninstall_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Options);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 49);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TF2", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "* Huds";
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(1013, 13);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(34, 23);
            this.Minimize.TabIndex = 2;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Options
            // 
            this.Options.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Options.BackgroundImage")));
            this.Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Options.FlatAppearance.BorderSize = 0;
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options.Location = new System.Drawing.Point(969, 13);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(38, 23);
            this.Options.TabIndex = 1;
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1053, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.Uninstall);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 55);
            this.panel2.TabIndex = 19;
            // 
            // hudControl1
            // 
            this.hudControl1.Location = new System.Drawing.Point(8, 60);
            this.hudControl1.Name = "hudControl1";
            this.hudControl1.Size = new System.Drawing.Size(1091, 556);
            this.hudControl1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1106, 677);
            this.Controls.Add(this.hudControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uwu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Uninstall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private HudControl hudControl1;
    }
}

