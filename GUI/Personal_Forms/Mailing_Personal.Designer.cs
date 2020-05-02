namespace GUI.Personal_Forms
{
    partial class Mailing_Personal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSkapaLista = new System.Windows.Forms.Button();
            this.btnTaBortLista = new System.Windows.Forms.Button();
            this.btnEditera = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1457, 448);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSkapaLista
            // 
            this.btnSkapaLista.Location = new System.Drawing.Point(1230, 583);
            this.btnSkapaLista.Margin = new System.Windows.Forms.Padding(5);
            this.btnSkapaLista.Name = "btnSkapaLista";
            this.btnSkapaLista.Size = new System.Drawing.Size(258, 74);
            this.btnSkapaLista.TabIndex = 3;
            this.btnSkapaLista.Text = "Skapa lista";
            this.btnSkapaLista.UseVisualStyleBackColor = true;
            this.btnSkapaLista.Click += new System.EventHandler(this.btnSkapaLista_Click);
            // 
            // btnTaBortLista
            // 
            this.btnTaBortLista.Location = new System.Drawing.Point(937, 583);
            this.btnTaBortLista.Margin = new System.Windows.Forms.Padding(5);
            this.btnTaBortLista.Name = "btnTaBortLista";
            this.btnTaBortLista.Size = new System.Drawing.Size(258, 74);
            this.btnTaBortLista.TabIndex = 4;
            this.btnTaBortLista.Text = "Ta bort lista";
            this.btnTaBortLista.UseVisualStyleBackColor = true;
            this.btnTaBortLista.Click += new System.EventHandler(this.btnTaBortLista_Click);
            // 
            // btnEditera
            // 
            this.btnEditera.Location = new System.Drawing.Point(637, 583);
            this.btnEditera.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditera.Name = "btnEditera";
            this.btnEditera.Size = new System.Drawing.Size(258, 74);
            this.btnEditera.TabIndex = 5;
            this.btnEditera.Text = "Editera";
            this.btnEditera.UseVisualStyleBackColor = true;
            this.btnEditera.Click += new System.EventHandler(this.btnEditera_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(1230, 680);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(5);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(258, 74);
            this.btnTillbaka.TabIndex = 6;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 583);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "Se deltagare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mailing_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 870);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnEditera);
            this.Controls.Add(this.btnTaBortLista);
            this.Controls.Add(this.btnSkapaLista);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Mailing_Personal";
            this.Text = "Mailing_Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSkapaLista;
        private System.Windows.Forms.Button btnTaBortLista;
        private System.Windows.Forms.Button btnEditera;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button button1;
    }
}