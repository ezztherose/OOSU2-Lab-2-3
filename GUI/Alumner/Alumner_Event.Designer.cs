namespace GUI.Alumner
{
    partial class Alumner_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumner_Event));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Hö = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSök = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.buttonRegistrera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 432);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1332, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1637, 183);
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(0, 834);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1655, 77);
            this.pictureBox5.TabIndex = 93;
            this.pictureBox5.TabStop = false;
            // 
            // Hö
            // 
            this.Hö.AutoSize = true;
            this.Hö.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Hö.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hö.Location = new System.Drawing.Point(580, 859);
            this.Hö.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Hö.Name = "Hö";
            this.Hö.Size = new System.Drawing.Size(410, 43);
            this.Hö.TabIndex = 94;
            this.Hö.Text = "Högskolan i Borås - SIT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 347);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 38);
            this.textBox1.TabIndex = 95;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSök
            // 
            this.buttonSök.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSök.Location = new System.Drawing.Point(370, 341);
            this.buttonSök.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSök.Name = "buttonSök";
            this.buttonSök.Size = new System.Drawing.Size(164, 54);
            this.buttonSök.TabIndex = 96;
            this.buttonSök.Text = "Sök";
            this.buttonSök.UseVisualStyleBackColor = false;
            this.buttonSök.Click += new System.EventHandler(this.buttonSök_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 64);
            this.label1.TabIndex = 97;
            this.label1.Text = "Registrera till event";
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonTillbaka.Location = new System.Drawing.Point(1088, 718);
            this.buttonTillbaka.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(164, 54);
            this.buttonTillbaka.TabIndex = 98;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = false;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // buttonRegistrera
            // 
            this.buttonRegistrera.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRegistrera.Location = new System.Drawing.Point(1294, 718);
            this.buttonRegistrera.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRegistrera.Name = "buttonRegistrera";
            this.buttonRegistrera.Size = new System.Drawing.Size(164, 54);
            this.buttonRegistrera.TabIndex = 99;
            this.buttonRegistrera.Text = "Registrera";
            this.buttonRegistrera.UseVisualStyleBackColor = false;
            this.buttonRegistrera.Click += new System.EventHandler(this.buttonRegistrera_Click);
            // 
            // Alumner_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1632, 911);
            this.Controls.Add(this.buttonRegistrera);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSök);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Hö);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Alumner_Event";
            this.Text = "Alumner_Event";
            this.Load += new System.EventHandler(this.Alumner_Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Hö;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSök;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.Button buttonRegistrera;
    }
}