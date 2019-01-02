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
            this.extrastop = new System.Windows.Forms.Label();
            this.crosshairstop = new System.Windows.Forms.Label();
            this.hudtop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.Label();
            this.hudControl1 = new Gui_Part_2.HudControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.button10.Location = new System.Drawing.Point(946, 4);
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
            this.label2.Font = new System.Drawing.Font("TF2", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(821, 54);
            this.label2.TabIndex = 14;
            this.label2.Text = "Set Path To Custom Folder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(406, 224);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(377, 265);
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
            this.Uninstall.Location = new System.Drawing.Point(1085, 5);
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
            this.panel1.Controls.Add(this.extrastop);
            this.panel1.Controls.Add(this.crosshairstop);
            this.panel1.Controls.Add(this.hudtop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Options);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 49);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // extrastop
            // 
            this.extrastop.AutoSize = true;
            this.extrastop.Font = new System.Drawing.Font("TF2", 20F);
            this.extrastop.ForeColor = System.Drawing.Color.Transparent;
            this.extrastop.Location = new System.Drawing.Point(592, 13);
            this.extrastop.Name = "extrastop";
            this.extrastop.Size = new System.Drawing.Size(92, 23);
            this.extrastop.TabIndex = 21;
            this.extrastop.Text = "Extras";
            // 
            // crosshairstop
            // 
            this.crosshairstop.AutoSize = true;
            this.crosshairstop.Font = new System.Drawing.Font("TF2", 20F);
            this.crosshairstop.ForeColor = System.Drawing.Color.Transparent;
            this.crosshairstop.Location = new System.Drawing.Point(432, 13);
            this.crosshairstop.Name = "crosshairstop";
            this.crosshairstop.Size = new System.Drawing.Size(136, 23);
            this.crosshairstop.TabIndex = 20;
            this.crosshairstop.Text = "Crosshairs";
            // 
            // hudtop
            // 
            this.hudtop.AutoSize = true;
            this.hudtop.Font = new System.Drawing.Font("TF2", 20F);
            this.hudtop.ForeColor = System.Drawing.Color.Transparent;
            this.hudtop.Location = new System.Drawing.Point(341, 13);
            this.hudtop.Name = "hudtop";
            this.hudtop.Size = new System.Drawing.Size(63, 23);
            this.hudtop.TabIndex = 18;
            this.hudtop.Text = "HUDS";
            this.hudtop.Click += new System.EventHandler(this.hudtop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TF2", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tf2 Tool";
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(1173, 13);
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
            this.Options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options.Location = new System.Drawing.Point(1129, 13);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(38, 23);
            this.Options.TabIndex = 1;
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.button12_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1213, 13);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.Uninstall);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 55);
            this.panel2.TabIndex = 19;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("TF2", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.LimeGreen;
            this.status.Location = new System.Drawing.Point(369, 13);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 31);
            this.status.TabIndex = 18;
            // 
            // hudControl1
            // 
            this.hudControl1.BackColor = System.Drawing.Color.Teal;
            this.hudControl1.Location = new System.Drawing.Point(0, 49);
            this.hudControl1.Name = "hudControl1";
            this.hudControl1.Size = new System.Drawing.Size(1194, 572);
            this.hudControl1.TabIndex = 20;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1257, 677);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.hudControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uwu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label extrastop;
        private System.Windows.Forms.Label crosshairstop;
        private System.Windows.Forms.Label hudtop;
        private HudControl hudControl1;
        private System.Windows.Forms.Label status;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

