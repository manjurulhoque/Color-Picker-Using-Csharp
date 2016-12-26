namespace ScreenColor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxrgb = new System.Windows.Forms.TextBox();
            this.textBoxhex = new System.Windows.Forms.TextBox();
            this.textBoxhtml = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHtmlCopy = new System.Windows.Forms.Button();
            this.btnHexCopy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "HTML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "RGB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "HEX";
            // 
            // textBoxrgb
            // 
            this.textBoxrgb.Location = new System.Drawing.Point(98, 216);
            this.textBoxrgb.Name = "textBoxrgb";
            this.textBoxrgb.Size = new System.Drawing.Size(119, 20);
            this.textBoxrgb.TabIndex = 4;
            // 
            // textBoxhex
            // 
            this.textBoxhex.Location = new System.Drawing.Point(99, 257);
            this.textBoxhex.Name = "textBoxhex";
            this.textBoxhex.Size = new System.Drawing.Size(119, 20);
            this.textBoxhex.TabIndex = 5;
            // 
            // textBoxhtml
            // 
            this.textBoxhtml.Location = new System.Drawing.Point(99, 177);
            this.textBoxhtml.Name = "textBoxhtml";
            this.textBoxhtml.Size = new System.Drawing.Size(119, 20);
            this.textBoxhtml.TabIndex = 6;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCopy.FlatAppearance.BorderSize = 3;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopy.Location = new System.Drawing.Point(235, 212);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 33);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 32);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::ScreenColor.Properties.Resources.logo;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ScreenColor.Properties.Resources.cross;
            this.button1.Location = new System.Drawing.Point(267, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 29);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(213, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 32);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnHtmlCopy
            // 
            this.btnHtmlCopy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHtmlCopy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHtmlCopy.FlatAppearance.BorderSize = 3;
            this.btnHtmlCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHtmlCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHtmlCopy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHtmlCopy.Location = new System.Drawing.Point(235, 174);
            this.btnHtmlCopy.Name = "btnHtmlCopy";
            this.btnHtmlCopy.Size = new System.Drawing.Size(75, 33);
            this.btnHtmlCopy.TabIndex = 11;
            this.btnHtmlCopy.Text = "Copy";
            this.btnHtmlCopy.UseVisualStyleBackColor = false;
            this.btnHtmlCopy.Click += new System.EventHandler(this.btnHtmlCopy_Click);
            // 
            // btnHexCopy
            // 
            this.btnHexCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHexCopy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHexCopy.FlatAppearance.BorderSize = 3;
            this.btnHexCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHexCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHexCopy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHexCopy.Location = new System.Drawing.Point(235, 251);
            this.btnHexCopy.Name = "btnHexCopy";
            this.btnHexCopy.Size = new System.Drawing.Size(75, 33);
            this.btnHexCopy.TabIndex = 12;
            this.btnHexCopy.Text = "Copy";
            this.btnHexCopy.UseVisualStyleBackColor = false;
            this.btnHexCopy.Click += new System.EventHandler(this.btnHexCopy_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(61, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Color Picker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 289);
            this.Controls.Add(this.btnHexCopy);
            this.Controls.Add(this.btnHtmlCopy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.textBoxhtml);
            this.Controls.Add(this.textBoxhex);
            this.Controls.Add(this.textBoxrgb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxrgb;
        private System.Windows.Forms.TextBox textBoxhex;
        private System.Windows.Forms.TextBox textBoxhtml;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHtmlCopy;
        private System.Windows.Forms.Button btnHexCopy;
        private System.Windows.Forms.Label label5;
    }
}

