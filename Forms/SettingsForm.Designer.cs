namespace EV3_WPF
{
    partial class SettingsForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbboxCOM = new System.Windows.Forms.ComboBox();
            this.lblCOM = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(55, 142);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(235, 76);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "ZAČÍT AKTIVITU";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbboxCOM
            // 
            this.cmbboxCOM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbboxCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbboxCOM.FormattingEnabled = true;
            this.cmbboxCOM.Location = new System.Drawing.Point(36, 70);
            this.cmbboxCOM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbboxCOM.Name = "cmbboxCOM";
            this.cmbboxCOM.Size = new System.Drawing.Size(136, 47);
            this.cmbboxCOM.TabIndex = 1;
            this.cmbboxCOM.DropDown += new System.EventHandler(this.cmbboxCOM_DropDown);
            // 
            // lblCOM
            // 
            this.lblCOM.AutoSize = true;
            this.lblCOM.Location = new System.Drawing.Point(32, 39);
            this.lblCOM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(82, 17);
            this.lblCOM.TabIndex = 2;
            this.lblCOM.Text = "COM PORT";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConnect.Location = new System.Drawing.Point(36, 142);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(137, 76);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "PŘIPOJIT";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.lblCOM);
            this.groupBox1.Controls.Add(this.cmbboxCOM);
            this.groupBox1.Location = new System.Drawing.Point(124, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(219, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bluetooth připojení";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(64, 70);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(189, 36);
            this.lblConnectionStatus.TabIndex = 5;
            this.lblConnectionStatus.Text = "Nepřipojeno";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblConnectionStatus);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(408, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(336, 274);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stav připojení";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Připojení robota";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbboxCOM;
        private System.Windows.Forms.Label lblCOM;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

