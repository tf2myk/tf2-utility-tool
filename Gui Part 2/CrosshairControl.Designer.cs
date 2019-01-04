namespace Gui_Part_2
{
    partial class CrosshairControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.crossdot = new System.Windows.Forms.Button();
            this.wings = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.sniper = new System.Windows.Forms.Button();
            this.crosshair11 = new System.Windows.Forms.Button();
            this.wingsdot = new System.Windows.Forms.Button();
            this.seeker = new System.Windows.Forms.Button();
            this.circledot = new System.Windows.Forms.Button();
            this.bigcross = new System.Windows.Forms.Button();
            this.fatcross = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 585);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.crossdot);
            this.flowLayoutPanel1.Controls.Add(this.wings);
            this.flowLayoutPanel1.Controls.Add(this.dot);
            this.flowLayoutPanel1.Controls.Add(this.circle);
            this.flowLayoutPanel1.Controls.Add(this.sniper);
            this.flowLayoutPanel1.Controls.Add(this.crosshair11);
            this.flowLayoutPanel1.Controls.Add(this.wingsdot);
            this.flowLayoutPanel1.Controls.Add(this.seeker);
            this.flowLayoutPanel1.Controls.Add(this.circledot);
            this.flowLayoutPanel1.Controls.Add(this.bigcross);
            this.flowLayoutPanel1.Controls.Add(this.fatcross);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 397);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // crossdot
            // 
            this.crossdot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.crossdot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.crossdot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.crossdot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crossdot.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossdot.Location = new System.Drawing.Point(3, 3);
            this.crossdot.Name = "crossdot";
            this.crossdot.Size = new System.Drawing.Size(104, 55);
            this.crossdot.TabIndex = 0;
            this.crossdot.Text = "Crossdot";
            this.crossdot.UseVisualStyleBackColor = true;
            this.crossdot.Click += new System.EventHandler(this.crossdot_Click);
            // 
            // wings
            // 
            this.wings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.wings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wings.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wings.Location = new System.Drawing.Point(113, 3);
            this.wings.Name = "wings";
            this.wings.Size = new System.Drawing.Size(104, 55);
            this.wings.TabIndex = 1;
            this.wings.Text = "Wings";
            this.wings.UseVisualStyleBackColor = true;
            this.wings.Click += new System.EventHandler(this.button2_Click);
            // 
            // dot
            // 
            this.dot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.dot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(3, 64);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(104, 55);
            this.dot.TabIndex = 2;
            this.dot.Text = "Dot";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // circle
            // 
            this.circle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circle.Location = new System.Drawing.Point(113, 64);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(104, 55);
            this.circle.TabIndex = 3;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // sniper
            // 
            this.sniper.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sniper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sniper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sniper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sniper.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sniper.Location = new System.Drawing.Point(3, 125);
            this.sniper.Name = "sniper";
            this.sniper.Size = new System.Drawing.Size(104, 55);
            this.sniper.TabIndex = 4;
            this.sniper.Text = "Sniper";
            this.sniper.UseVisualStyleBackColor = true;
            this.sniper.Click += new System.EventHandler(this.sniper_Click);
            // 
            // crosshair11
            // 
            this.crosshair11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.crosshair11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.crosshair11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.crosshair11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crosshair11.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crosshair11.Location = new System.Drawing.Point(113, 125);
            this.crosshair11.Name = "crosshair11";
            this.crosshair11.Size = new System.Drawing.Size(104, 55);
            this.crosshair11.TabIndex = 5;
            this.crosshair11.Text = "crosshair11";
            this.crosshair11.UseVisualStyleBackColor = true;
            this.crosshair11.Click += new System.EventHandler(this.crosshair11_Click);
            // 
            // wingsdot
            // 
            this.wingsdot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.wingsdot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wingsdot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wingsdot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wingsdot.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wingsdot.Location = new System.Drawing.Point(3, 186);
            this.wingsdot.Name = "wingsdot";
            this.wingsdot.Size = new System.Drawing.Size(104, 55);
            this.wingsdot.TabIndex = 6;
            this.wingsdot.Text = "wingsdot";
            this.wingsdot.UseVisualStyleBackColor = true;
            this.wingsdot.Click += new System.EventHandler(this.wingsdot_Click);
            // 
            // seeker
            // 
            this.seeker.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.seeker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.seeker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.seeker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeker.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeker.Location = new System.Drawing.Point(113, 186);
            this.seeker.Name = "seeker";
            this.seeker.Size = new System.Drawing.Size(104, 55);
            this.seeker.TabIndex = 7;
            this.seeker.Text = "Seeker";
            this.seeker.UseVisualStyleBackColor = true;
            this.seeker.Click += new System.EventHandler(this.seeker_Click);
            // 
            // circledot
            // 
            this.circledot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.circledot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.circledot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.circledot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circledot.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circledot.Location = new System.Drawing.Point(3, 247);
            this.circledot.Name = "circledot";
            this.circledot.Size = new System.Drawing.Size(104, 55);
            this.circledot.TabIndex = 8;
            this.circledot.Text = "circledot";
            this.circledot.UseVisualStyleBackColor = true;
            this.circledot.Click += new System.EventHandler(this.circledot_Click);
            // 
            // bigcross
            // 
            this.bigcross.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bigcross.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bigcross.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bigcross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigcross.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigcross.Location = new System.Drawing.Point(113, 247);
            this.bigcross.Name = "bigcross";
            this.bigcross.Size = new System.Drawing.Size(104, 55);
            this.bigcross.TabIndex = 9;
            this.bigcross.Text = "bigcross";
            this.bigcross.UseVisualStyleBackColor = true;
            this.bigcross.Click += new System.EventHandler(this.bigcross_Click);
            // 
            // fatcross
            // 
            this.fatcross.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fatcross.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fatcross.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fatcross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fatcross.Font = new System.Drawing.Font("TF2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatcross.Location = new System.Drawing.Point(3, 308);
            this.fatcross.Name = "fatcross";
            this.fatcross.Size = new System.Drawing.Size(104, 55);
            this.fatcross.TabIndex = 10;
            this.fatcross.Text = "fat cross";
            this.fatcross.UseVisualStyleBackColor = true;
            this.fatcross.Click += new System.EventHandler(this.fatcross_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(223, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1063, 638);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 585);
            this.panel2.TabIndex = 2;
            // 
            // CrosshairControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CrosshairControl";
            this.Size = new System.Drawing.Size(1216, 585);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button crossdot;
        private System.Windows.Forms.Button wings;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button sniper;
        private System.Windows.Forms.Button crosshair11;
        private System.Windows.Forms.Button wingsdot;
        private System.Windows.Forms.Button seeker;
        private System.Windows.Forms.Button circledot;
        private System.Windows.Forms.Button bigcross;
        private System.Windows.Forms.Button fatcross;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
    }
}
