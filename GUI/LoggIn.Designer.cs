namespace GUI
{
    partial class LoggIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggIn));
            this.buttonLogaIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLösenord = new System.Windows.Forms.TextBox();
            this.textBoxAnvändarNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelSkapaAlumnKonto = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonLogaIn
            // 
            this.buttonLogaIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogaIn.Location = new System.Drawing.Point(656, 560);
            this.buttonLogaIn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonLogaIn.Name = "buttonLogaIn";
            this.buttonLogaIn.Size = new System.Drawing.Size(194, 50);
            this.buttonLogaIn.TabIndex = 11;
            this.buttonLogaIn.Text = "Logga in";
            this.buttonLogaIn.UseVisualStyleBackColor = false;
            this.buttonLogaIn.Click += new System.EventHandler(this.buttonLogaIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(613, 432);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lösenord ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(603, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Användarnamn";
            // 
            // textBoxLösenord
            // 
            this.textBoxLösenord.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxLösenord.Location = new System.Drawing.Point(612, 482);
            this.textBoxLösenord.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxLösenord.Name = "textBoxLösenord";
            this.textBoxLösenord.PasswordChar = '*';
            this.textBoxLösenord.Size = new System.Drawing.Size(294, 38);
            this.textBoxLösenord.TabIndex = 8;
            this.textBoxLösenord.UseSystemPasswordChar = true;
            this.textBoxLösenord.TextChanged += new System.EventHandler(this.textBoxLösenord_TextChanged);
            // 
            // textBoxAnvändarNamn
            // 
            this.textBoxAnvändarNamn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxAnvändarNamn.Location = new System.Drawing.Point(612, 366);
            this.textBoxAnvändarNamn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxAnvändarNamn.Name = "textBoxAnvändarNamn";
            this.textBoxAnvändarNamn.Size = new System.Drawing.Size(294, 38);
            this.textBoxAnvändarNamn.TabIndex = 7;
            this.textBoxAnvändarNamn.TextChanged += new System.EventHandler(this.textBoxAnvändarNamn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(596, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 85);
            this.label1.TabIndex = 6;
            this.label1.Text = "Logga in";
            // 
            // linkLabelSkapaAlumnKonto
            // 
            this.linkLabelSkapaAlumnKonto.AutoSize = true;
            this.linkLabelSkapaAlumnKonto.Location = new System.Drawing.Point(630, 643);
            this.linkLabelSkapaAlumnKonto.Name = "linkLabelSkapaAlumnKonto";
            this.linkLabelSkapaAlumnKonto.Size = new System.Drawing.Size(261, 32);
            this.linkLabelSkapaAlumnKonto.TabIndex = 12;
            this.linkLabelSkapaAlumnKonto.TabStop = true;
            this.linkLabelSkapaAlumnKonto.Text = "Skapa Alumn konto";
            this.linkLabelSkapaAlumnKonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSkapaAlumnKonto_LinkClicked);
            // 
            // LoggIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1527, 839);
            this.Controls.Add(this.linkLabelSkapaAlumnKonto);
            this.Controls.Add(this.buttonLogaIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLösenord);
            this.Controls.Add(this.textBoxAnvändarNamn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoggIn";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogaIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLösenord;
        private System.Windows.Forms.TextBox textBoxAnvändarNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelSkapaAlumnKonto;
    }
}

