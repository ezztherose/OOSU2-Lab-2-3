namespace GUI.Admin
{
    partial class BjudIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BjudIn));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSök = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnHämtaAllaAlumner = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Hö = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 212);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSök
            // 
            this.buttonSök.Location = new System.Drawing.Point(242, 212);
            this.buttonSök.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSök.Name = "buttonSök";
            this.buttonSök.Size = new System.Drawing.Size(84, 31);
            this.buttonSök.TabIndex = 1;
            this.buttonSök.Text = "Sök";
            this.buttonSök.UseVisualStyleBackColor = true;
            this.buttonSök.Click += new System.EventHandler(this.buttonSök_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 268);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(763, 184);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(488, 491);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(105, 31);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Markera alla";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(609, 491);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(100, 31);
            this.btnTaBort.TabIndex = 4;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(724, 491);
            this.btnSkicka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(90, 31);
            this.btnSkicka.TabIndex = 5;
            this.btnSkicka.Text = "Skicka";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lägg till gäster";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(931, 118);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // btnHämtaAllaAlumner
            // 
            this.btnHämtaAllaAlumner.Location = new System.Drawing.Point(331, 212);
            this.btnHämtaAllaAlumner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHämtaAllaAlumner.Name = "btnHämtaAllaAlumner";
            this.btnHämtaAllaAlumner.Size = new System.Drawing.Size(165, 31);
            this.btnHämtaAllaAlumner.TabIndex = 54;
            this.btnHämtaAllaAlumner.Text = "Hämta alla alumner";
            this.btnHämtaAllaAlumner.UseVisualStyleBackColor = true;
            this.btnHämtaAllaAlumner.Click += new System.EventHandler(this.btnHämtaAllaAlumner_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(-1, 580);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(931, 50);
            this.pictureBox5.TabIndex = 71;
            this.pictureBox5.TabStop = false;
            // 
            // Hö
            // 
            this.Hö.AutoSize = true;
            this.Hö.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Hö.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hö.Location = new System.Drawing.Point(311, 596);
            this.Hö.Name = "Hö";
            this.Hö.Size = new System.Drawing.Size(244, 25);
            this.Hö.TabIndex = 72;
            this.Hö.Text = "Högskolan i Borås - SIT";
            // 
            // BjudIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 630);
            this.Controls.Add(this.Hö);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnHämtaAllaAlumner);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSök);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BjudIn";
            this.Text = "BjudIn";
            this.Load += new System.EventHandler(this.BjudIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSök;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnHämtaAllaAlumner;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Hö;
    }
}