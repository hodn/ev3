namespace EV3_WPF
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnTurn = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUp.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(269, 425);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(200, 200);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "˄";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRight.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Location = new System.Drawing.Point(498, 655);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(200, 200);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "˃";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnTurn
            // 
            this.btnTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTurn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTurn.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTurn.ForeColor = System.Drawing.Color.White;
            this.btnTurn.Location = new System.Drawing.Point(269, 655);
            this.btnTurn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(200, 200);
            this.btnTurn.TabIndex = 2;
            this.btnTurn.Text = "↻";
            this.btnTurn.UseVisualStyleBackColor = false;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLeft.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Location = new System.Drawing.Point(35, 655);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(200, 200);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "˂";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.Color.Red;
            this.btnDelAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelAll.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelAll.ForeColor = System.Drawing.Color.White;
            this.btnDelAll.Location = new System.Drawing.Point(35, 68);
            this.btnDelAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(200, 200);
            this.btnDelAll.TabIndex = 4;
            this.btnDelAll.Text = "╳╳";
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(269, 68);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(200, 200);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "╳";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(498, 68);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 200);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "✔";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnDelAll);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.btnTurn);
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(1148, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(728, 924);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ovládání";
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Orange;
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.ForeColor = System.Drawing.Color.White;
            this.b1.Location = new System.Drawing.Point(0, 0);
            this.b1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(200, 200);
            this.b1.TabIndex = 8;
            this.b1.Text = "↻";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Orange;
            this.b2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b2.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.ForeColor = System.Drawing.Color.White;
            this.b2.Location = new System.Drawing.Point(271, 0);
            this.b2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(200, 200);
            this.b2.TabIndex = 9;
            this.b2.Text = "↻";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Orange;
            this.b3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b3.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.ForeColor = System.Drawing.Color.White;
            this.b3.Location = new System.Drawing.Point(548, 0);
            this.b3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(200, 200);
            this.b3.TabIndex = 10;
            this.b3.Text = "↻";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Orange;
            this.b4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b4.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.ForeColor = System.Drawing.Color.White;
            this.b4.Location = new System.Drawing.Point(831, 0);
            this.b4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(200, 200);
            this.b4.TabIndex = 11;
            this.b4.Text = "↻";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.Orange;
            this.b5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b5.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b5.ForeColor = System.Drawing.Color.White;
            this.b5.Location = new System.Drawing.Point(0, 292);
            this.b5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(200, 200);
            this.b5.TabIndex = 13;
            this.b5.Text = "↻";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.Orange;
            this.b6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b6.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b6.ForeColor = System.Drawing.Color.White;
            this.b6.Location = new System.Drawing.Point(271, 292);
            this.b6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(200, 200);
            this.b6.TabIndex = 14;
            this.b6.Text = "↻";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.Orange;
            this.b7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b7.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b7.ForeColor = System.Drawing.Color.White;
            this.b7.Location = new System.Drawing.Point(548, 292);
            this.b7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(200, 200);
            this.b7.TabIndex = 15;
            this.b7.Text = "↻";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.Orange;
            this.b8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b8.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b8.ForeColor = System.Drawing.Color.White;
            this.b8.Location = new System.Drawing.Point(831, 292);
            this.b8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(200, 200);
            this.b8.TabIndex = 16;
            this.b8.Text = "↻";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.Orange;
            this.b9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b9.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b9.ForeColor = System.Drawing.Color.White;
            this.b9.Location = new System.Drawing.Point(0, 588);
            this.b9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(200, 200);
            this.b9.TabIndex = 18;
            this.b9.Text = "↻";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b10
            // 
            this.b10.BackColor = System.Drawing.Color.Orange;
            this.b10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b10.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b10.ForeColor = System.Drawing.Color.White;
            this.b10.Location = new System.Drawing.Point(271, 588);
            this.b10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(200, 200);
            this.b10.TabIndex = 19;
            this.b10.Text = "↻";
            this.b10.UseVisualStyleBackColor = false;
            this.b10.Click += new System.EventHandler(this.b10_Click);
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.Orange;
            this.b11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b11.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b11.ForeColor = System.Drawing.Color.White;
            this.b11.Location = new System.Drawing.Point(548, 588);
            this.b11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(200, 200);
            this.b11.TabIndex = 20;
            this.b11.Text = "↻";
            this.b11.UseVisualStyleBackColor = false;
            this.b11.Click += new System.EventHandler(this.b11_Click);
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.Orange;
            this.b12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b12.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b12.ForeColor = System.Drawing.Color.White;
            this.b12.Location = new System.Drawing.Point(831, 588);
            this.b12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(200, 200);
            this.b12.TabIndex = 21;
            this.b12.Text = "↻";
            this.b12.UseVisualStyleBackColor = false;
            this.b12.Click += new System.EventHandler(this.b12_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.b12);
            this.panel1.Controls.Add(this.b11);
            this.panel1.Controls.Add(this.b10);
            this.panel1.Controls.Add(this.b9);
            this.panel1.Controls.Add(this.b8);
            this.panel1.Controls.Add(this.b7);
            this.panel1.Controls.Add(this.b6);
            this.panel1.Controls.Add(this.b5);
            this.panel1.Controls.Add(this.b4);
            this.panel1.Controls.Add(this.b3);
            this.panel1.Controls.Add(this.b2);
            this.panel1.Controls.Add(this.b1);
            this.panel1.Location = new System.Drawing.Point(28, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 789);
            this.panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(31, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1094, 924);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sekvence";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1032);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ovládání robota";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnTurn;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}