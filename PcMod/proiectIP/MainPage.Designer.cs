﻿namespace proiectIP
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oraCurenta = new System.Windows.Forms.Label();
            this.timerOraCurenta = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxGate = new System.Windows.Forms.PictureBox();
            this.labelGateState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelWay = new System.Windows.Forms.Label();
            this.labelCarNr = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxEmployeePicture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDenyAcces = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnDisconnectPortar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployeePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackground
            // 
            this.pbBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbBackground.Image")));
            this.pbBackground.Location = new System.Drawing.Point(-13, -5);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1043, 520);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pagina principală";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // oraCurenta
            // 
            this.oraCurenta.AutoSize = true;
            this.oraCurenta.BackColor = System.Drawing.Color.Transparent;
            this.oraCurenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oraCurenta.Location = new System.Drawing.Point(891, 11);
            this.oraCurenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oraCurenta.Name = "oraCurenta";
            this.oraCurenta.Size = new System.Drawing.Size(0, 25);
            this.oraCurenta.TabIndex = 2;
            // 
            // timerOraCurenta
            // 
            this.timerOraCurenta.Enabled = true;
            this.timerOraCurenta.Tick += new System.EventHandler(this.timerOraCurenta_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxGate);
            this.groupBox2.Controls.Add(this.labelGateState);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(467, 319);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalii poartă:";
            // 
            // pictureBoxGate
            // 
            this.pictureBoxGate.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGate.Location = new System.Drawing.Point(12, 114);
            this.pictureBoxGate.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGate.Name = "pictureBoxGate";
            this.pictureBoxGate.Size = new System.Drawing.Size(447, 187);
            this.pictureBoxGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGate.TabIndex = 11;
            this.pictureBoxGate.TabStop = false;
            // 
            // labelGateState
            // 
            this.labelGateState.AutoSize = true;
            this.labelGateState.Location = new System.Drawing.Point(100, 62);
            this.labelGateState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGateState.Name = "labelGateState";
            this.labelGateState.Size = new System.Drawing.Size(38, 16);
            this.labelGateState.TabIndex = 10;
            this.labelGateState.Text = "idle...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stare poartă:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelWay);
            this.groupBox1.Controls.Add(this.labelCarNr);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.pictureBoxEmployeePicture);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(520, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(467, 319);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii angajat:";
            // 
            // labelWay
            // 
            this.labelWay.AutoSize = true;
            this.labelWay.Location = new System.Drawing.Point(68, 202);
            this.labelWay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWay.Name = "labelWay";
            this.labelWay.Size = new System.Drawing.Size(44, 16);
            this.labelWay.TabIndex = 15;
            this.labelWay.Text = "label9";
            // 
            // labelCarNr
            // 
            this.labelCarNr.AutoSize = true;
            this.labelCarNr.Location = new System.Drawing.Point(140, 153);
            this.labelCarNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCarNr.Name = "labelCarNr";
            this.labelCarNr.Size = new System.Drawing.Size(44, 16);
            this.labelCarNr.TabIndex = 14;
            this.labelCarNr.Text = "label8";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(76, 103);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "label7";
            // 
            // pictureBoxEmployeePicture
            // 
            this.pictureBoxEmployeePicture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxEmployeePicture.Location = new System.Drawing.Point(300, 103);
            this.pictureBoxEmployeePicture.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEmployeePicture.Name = "pictureBoxEmployeePicture";
            this.pictureBoxEmployeePicture.Size = new System.Drawing.Size(133, 117);
            this.pictureBoxEmployeePicture.TabIndex = 12;
            this.pictureBoxEmployeePicture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Număr mașină:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nume:";
            // 
            // btnDenyAcces
            // 
            this.btnDenyAcces.BackColor = System.Drawing.Color.Red;
            this.btnDenyAcces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenyAcces.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDenyAcces.Location = new System.Drawing.Point(208, 438);
            this.btnDenyAcces.Margin = new System.Windows.Forms.Padding(4);
            this.btnDenyAcces.Name = "btnDenyAcces";
            this.btnDenyAcces.Size = new System.Drawing.Size(167, 53);
            this.btnDenyAcces.TabIndex = 7;
            this.btnDenyAcces.Text = "DENY ACCESS";
            this.btnDenyAcces.UseVisualStyleBackColor = false;
            this.btnDenyAcces.Click += new System.EventHandler(this.btnDenyAcces_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogs.Location = new System.Drawing.Point(16, 438);
            this.btnLogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(167, 53);
            this.btnLogs.TabIndex = 8;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnDisconnectPortar
            // 
            this.btnDisconnectPortar.Location = new System.Drawing.Point(856, 438);
            this.btnDisconnectPortar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnectPortar.Name = "btnDisconnectPortar";
            this.btnDisconnectPortar.Size = new System.Drawing.Size(156, 53);
            this.btnDisconnectPortar.TabIndex = 9;
            this.btnDisconnectPortar.Text = "Deconectare";
            this.btnDisconnectPortar.UseVisualStyleBackColor = true;
            this.btnDisconnectPortar.Click += new System.EventHandler(this.btnDisconnectPortar_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 512);
            this.Controls.Add(this.btnDisconnectPortar);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnDenyAcces);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.oraCurenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainPage_FormClosing);
            this.Load += new System.EventHandler(this.mainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployeePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oraCurenta;
        private System.Windows.Forms.Timer timerOraCurenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxEmployeePicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDenyAcces;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Label labelGateState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelWay;
        private System.Windows.Forms.Label labelCarNr;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxGate;
        private System.Windows.Forms.Button btnDisconnectPortar;
    }
}
