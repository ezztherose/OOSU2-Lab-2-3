namespace GUI.Personal_Forms
{
    partial class Event_View
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
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            this.dataGridViewEventAlumner = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventAlumner)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Location = new System.Drawing.Point(34, 151);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.RowHeadersWidth = 102;
            this.dataGridViewEvent.RowTemplate.Height = 40;
            this.dataGridViewEvent.Size = new System.Drawing.Size(1037, 239);
            this.dataGridViewEvent.TabIndex = 0;
            // 
            // dataGridViewEventAlumner
            // 
            this.dataGridViewEventAlumner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventAlumner.Location = new System.Drawing.Point(34, 544);
            this.dataGridViewEventAlumner.Name = "dataGridViewEventAlumner";
            this.dataGridViewEventAlumner.RowHeadersWidth = 102;
            this.dataGridViewEventAlumner.RowTemplate.Height = 40;
            this.dataGridViewEventAlumner.Size = new System.Drawing.Size(1037, 239);
            this.dataGridViewEventAlumner.TabIndex = 1;
            this.dataGridViewEventAlumner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEventAlumner_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(872, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Se anmälda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(872, 824);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tillbaka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Event_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 963);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewEventAlumner);
            this.Controls.Add(this.dataGridViewEvent);
            this.Name = "Event_View";
            this.Text = "Event_View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventAlumner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEvent;
        private System.Windows.Forms.DataGridView dataGridViewEventAlumner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}