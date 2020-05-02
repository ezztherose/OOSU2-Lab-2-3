namespace GUI
{
    partial class Skapa_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skapa_Event));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonSkapaEvent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxBeskrivning = new System.Windows.Forms.RichTextBox();
            this.textBoxSlutTid = new System.Windows.Forms.TextBox();
            this.textBoxStartTid = new System.Windows.Forms.TextBox();
            this.textBoxPlats = new System.Windows.Forms.TextBox();
            this.textBoxENamn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEvent = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Hö = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(845, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // buttonSkapaEvent
            // 
            this.buttonSkapaEvent.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSkapaEvent.Location = new System.Drawing.Point(619, 480);
            this.buttonSkapaEvent.Name = "buttonSkapaEvent";
            this.buttonSkapaEvent.Size = new System.Drawing.Size(144, 40);
            this.buttonSkapaEvent.TabIndex = 42;
            this.buttonSkapaEvent.Text = "Skapa Event";
            this.buttonSkapaEvent.UseVisualStyleBackColor = false;
            this.buttonSkapaEvent.Click += new System.EventHandler(this.buttonSkapaEvent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(373, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 39);
            this.label6.TabIndex = 41;
            this.label6.Text = "Beskrivning";
            // 
            // richTextBoxBeskrivning
            // 
            this.richTextBoxBeskrivning.Location = new System.Drawing.Point(378, 220);
            this.richTextBoxBeskrivning.Name = "richTextBoxBeskrivning";
            this.richTextBoxBeskrivning.Size = new System.Drawing.Size(387, 199);
            this.richTextBoxBeskrivning.TabIndex = 40;
            this.richTextBoxBeskrivning.Text = "";
            this.richTextBoxBeskrivning.TextChanged += new System.EventHandler(this.richTextBoxBeskrivning_TextChanged);
            // 
            // textBoxSlutTid
            // 
            this.textBoxSlutTid.BackColor = System.Drawing.Color.White;
            this.textBoxSlutTid.Location = new System.Drawing.Point(232, 361);
            this.textBoxSlutTid.Name = "textBoxSlutTid";
            this.textBoxSlutTid.Size = new System.Drawing.Size(88, 26);
            this.textBoxSlutTid.TabIndex = 39;
            this.textBoxSlutTid.TextChanged += new System.EventHandler(this.textBoxSlutTid_TextChanged);
            // 
            // textBoxStartTid
            // 
            this.textBoxStartTid.BackColor = System.Drawing.Color.White;
            this.textBoxStartTid.Location = new System.Drawing.Point(113, 361);
            this.textBoxStartTid.Name = "textBoxStartTid";
            this.textBoxStartTid.Size = new System.Drawing.Size(87, 26);
            this.textBoxStartTid.TabIndex = 38;
            this.textBoxStartTid.TextChanged += new System.EventHandler(this.textBoxStartTid_TextChanged);
            // 
            // textBoxPlats
            // 
            this.textBoxPlats.BackColor = System.Drawing.Color.White;
            this.textBoxPlats.Location = new System.Drawing.Point(101, 258);
            this.textBoxPlats.Name = "textBoxPlats";
            this.textBoxPlats.Size = new System.Drawing.Size(207, 26);
            this.textBoxPlats.TabIndex = 37;
            this.textBoxPlats.TextChanged += new System.EventHandler(this.textBoxPlats_TextChanged);
            // 
            // textBoxENamn
            // 
            this.textBoxENamn.BackColor = System.Drawing.Color.White;
            this.textBoxENamn.Location = new System.Drawing.Point(101, 202);
            this.textBoxENamn.Name = "textBoxENamn";
            this.textBoxENamn.Size = new System.Drawing.Size(207, 26);
            this.textBoxENamn.TabIndex = 36;
            this.textBoxENamn.TextChanged += new System.EventHandler(this.textBoxENamn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(30, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 39);
            this.label5.TabIndex = 35;
            this.label5.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(226, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 39);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sluttid ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(106, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 39);
            this.label3.TabIndex = 33;
            this.label3.Text = "Starttid ";
            // 
            // dateTimePickerEvent
            // 
            this.dateTimePickerEvent.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerEvent.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dateTimePickerEvent.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEvent.Location = new System.Drawing.Point(113, 418);
            this.dateTimePickerEvent.MinDate = new System.DateTime(2020, 2, 8, 0, 0, 0, 0);
            this.dateTimePickerEvent.Name = "dateTimePickerEvent";
            this.dateTimePickerEvent.Size = new System.Drawing.Size(207, 45);
            this.dateTimePickerEvent.TabIndex = 32;
            this.dateTimePickerEvent.ValueChanged += new System.EventHandler(this.dateTimePickerEvent_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(27, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "Plats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(18, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "Namn:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 118);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(-3, 568);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(931, 50);
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // Hö
            // 
            this.Hö.AutoSize = true;
            this.Hö.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Hö.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hö.Location = new System.Drawing.Point(329, 579);
            this.Hö.Name = "Hö";
            this.Hö.Size = new System.Drawing.Size(410, 43);
            this.Hö.TabIndex = 71;
            this.Hö.Text = "Högskolan i Borås - SIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(327, 64);
            this.label7.TabIndex = 72;
            this.label7.Text = "Skapa event";
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.BackColor = System.Drawing.SystemColors.Window;
            this.btnTillbaka.Location = new System.Drawing.Point(456, 480);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(144, 40);
            this.btnTillbaka.TabIndex = 73;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = false;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // Skapa_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(928, 619);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Hö);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonSkapaEvent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxBeskrivning);
            this.Controls.Add(this.textBoxSlutTid);
            this.Controls.Add(this.textBoxStartTid);
            this.Controls.Add(this.textBoxPlats);
            this.Controls.Add(this.textBoxENamn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Skapa_Event";
            this.Text = "Skapa_Event";
            this.Load += new System.EventHandler(this.Skapa_Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonSkapaEvent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxBeskrivning;
        private System.Windows.Forms.TextBox textBoxSlutTid;
        private System.Windows.Forms.TextBox textBoxStartTid;
        private System.Windows.Forms.TextBox textBoxPlats;
        private System.Windows.Forms.TextBox textBoxENamn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Hö;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTillbaka;
    }
}