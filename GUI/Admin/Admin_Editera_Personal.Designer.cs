namespace GUI.Admin
{
    partial class Admin_Editera_Personal
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
            this.btnEditera = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxAnvändarNamn = new System.Windows.Forms.TextBox();
            this.textBoxLösenord = new System.Windows.Forms.TextBox();
            this.labelNamn = new System.Windows.Forms.Label();
            this.labelAnvändarNamn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditera
            // 
            this.btnEditera.Location = new System.Drawing.Point(415, 579);
            this.btnEditera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditera.Name = "btnEditera";
            this.btnEditera.Size = new System.Drawing.Size(118, 55);
            this.btnEditera.TabIndex = 0;
            this.btnEditera.Text = "Editera";
            this.btnEditera.UseVisualStyleBackColor = true;
            this.btnEditera.Click += new System.EventHandler(this.btnEditera_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(556, 579);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(115, 54);
            this.btnTaBort.TabIndex = 1;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(459, 174);
            this.btnLäggTill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(118, 55);
            this.btnLäggTill.TabIndex = 2;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(87, 28);
            this.textBoxNamn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(162, 26);
            this.textBoxNamn.TabIndex = 3;
            this.textBoxNamn.TextChanged += new System.EventHandler(this.textBoxNamn_TextChanged);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(87, 64);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(162, 26);
            this.textBoxMail.TabIndex = 4;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // textBoxAnvändarNamn
            // 
            this.textBoxAnvändarNamn.Location = new System.Drawing.Point(415, 30);
            this.textBoxAnvändarNamn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAnvändarNamn.Name = "textBoxAnvändarNamn";
            this.textBoxAnvändarNamn.Size = new System.Drawing.Size(162, 26);
            this.textBoxAnvändarNamn.TabIndex = 5;
            this.textBoxAnvändarNamn.TextChanged += new System.EventHandler(this.textBoxAnvändarNamn_TextChanged);
            // 
            // textBoxLösenord
            // 
            this.textBoxLösenord.Location = new System.Drawing.Point(415, 70);
            this.textBoxLösenord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLösenord.Name = "textBoxLösenord";
            this.textBoxLösenord.Size = new System.Drawing.Size(162, 26);
            this.textBoxLösenord.TabIndex = 6;
            this.textBoxLösenord.TextChanged += new System.EventHandler(this.textBoxLösenord_TextChanged);
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(18, 28);
            this.labelNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(55, 20);
            this.labelNamn.TabIndex = 7;
            this.labelNamn.Text = "Namn:";
            this.labelNamn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAnvändarNamn
            // 
            this.labelAnvändarNamn.AutoSize = true;
            this.labelAnvändarNamn.Location = new System.Drawing.Point(284, 30);
            this.labelAnvändarNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnvändarNamn.Name = "labelAnvändarNamn";
            this.labelAnvändarNamn.Size = new System.Drawing.Size(121, 20);
            this.labelAnvändarNamn.TabIndex = 8;
            this.labelAnvändarNamn.Text = "Användarnamn:";
            this.labelAnvändarNamn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mail:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lösenord:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 251);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(640, 295);
            this.dataGridView1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Titlel:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(22, 579);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(2);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(118, 55);
            this.btnTillbaka.TabIndex = 14;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // Admin_Editera_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 675);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAnvändarNamn);
            this.Controls.Add(this.labelNamn);
            this.Controls.Add(this.textBoxLösenord);
            this.Controls.Add(this.textBoxAnvändarNamn);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnEditera);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_Editera_Personal";
            this.Text = "Admin_Editera_Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditera;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxAnvändarNamn;
        private System.Windows.Forms.TextBox textBoxLösenord;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label labelAnvändarNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTillbaka;
    }
}