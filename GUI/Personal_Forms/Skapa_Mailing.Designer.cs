namespace GUI.Personal_Forms
{
    partial class Skapa_Mailing
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
            this.dataGridViewAlla = new System.Windows.Forms.DataGridView();
            this.dataGridViewValda = new System.Windows.Forms.DataGridView();
            this.btnLäggTillAlumn = new System.Windows.Forms.Button();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSkapa = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValda)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlla
            // 
            this.dataGridViewAlla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlla.Location = new System.Drawing.Point(39, 251);
            this.dataGridViewAlla.Name = "dataGridViewAlla";
            this.dataGridViewAlla.RowHeadersWidth = 102;
            this.dataGridViewAlla.RowTemplate.Height = 40;
            this.dataGridViewAlla.Size = new System.Drawing.Size(1406, 285);
            this.dataGridViewAlla.TabIndex = 0;
            // 
            // dataGridViewValda
            // 
            this.dataGridViewValda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValda.Location = new System.Drawing.Point(40, 660);
            this.dataGridViewValda.Name = "dataGridViewValda";
            this.dataGridViewValda.RowHeadersWidth = 102;
            this.dataGridViewValda.RowTemplate.Height = 40;
            this.dataGridViewValda.Size = new System.Drawing.Size(1405, 285);
            this.dataGridViewValda.TabIndex = 1;
            this.dataGridViewValda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewValda_CellContentClick);
            // 
            // btnLäggTillAlumn
            // 
            this.btnLäggTillAlumn.Location = new System.Drawing.Point(1248, 559);
            this.btnLäggTillAlumn.Name = "btnLäggTillAlumn";
            this.btnLäggTillAlumn.Size = new System.Drawing.Size(197, 80);
            this.btnLäggTillAlumn.TabIndex = 2;
            this.btnLäggTillAlumn.Text = "Lägg till alumn";
            this.btnLäggTillAlumn.UseVisualStyleBackColor = true;
            this.btnLäggTillAlumn.Click += new System.EventHandler(this.btnLäggTillAlumn_Click);
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(40, 135);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(320, 38);
            this.textBoxNamn.TabIndex = 3;
            this.textBoxNamn.TextChanged += new System.EventHandler(this.textBoxNamn_TextChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(694, 88);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(656, 130);
            this.textBoxMessage.TabIndex = 4;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message";
            // 
            // btnSkapa
            // 
            this.btnSkapa.Location = new System.Drawing.Point(1248, 986);
            this.btnSkapa.Name = "btnSkapa";
            this.btnSkapa.Size = new System.Drawing.Size(197, 80);
            this.btnSkapa.TabIndex = 7;
            this.btnSkapa.Text = "Skapa";
            this.btnSkapa.UseVisualStyleBackColor = true;
            this.btnSkapa.Click += new System.EventHandler(this.btnSkapa_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(1025, 986);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(197, 80);
            this.btnTillbaka.TabIndex = 8;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // Skapa_Mailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 1153);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnSkapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.btnLäggTillAlumn);
            this.Controls.Add(this.dataGridViewValda);
            this.Controls.Add(this.dataGridViewAlla);
            this.Name = "Skapa_Mailing";
            this.Text = "Skapa_Mailing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlla;
        private System.Windows.Forms.DataGridView dataGridViewValda;
        private System.Windows.Forms.Button btnLäggTillAlumn;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSkapa;
        private System.Windows.Forms.Button btnTillbaka;
    }
}