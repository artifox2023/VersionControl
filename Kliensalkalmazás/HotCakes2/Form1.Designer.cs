namespace HotCakes2
{
    partial class Form1
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
            this.TermekekDGV = new System.Windows.Forms.DataGridView();
            this.buttonEditPrice = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditDescription = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TermekekDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TermekekDGV
            // 
            this.TermekekDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TermekekDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TermekekDGV.Location = new System.Drawing.Point(12, 12);
            this.TermekekDGV.Name = "TermekekDGV";
            this.TermekekDGV.RowHeadersWidth = 51;
            this.TermekekDGV.RowTemplate.Height = 24;
            this.TermekekDGV.Size = new System.Drawing.Size(893, 403);
            this.TermekekDGV.TabIndex = 0;
            this.TermekekDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TermekekDGV_CellClick);
            this.TermekekDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.TermekekDGV.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.TermekekDGV_CellLeave);
            // 
            // buttonEditPrice
            // 
            this.buttonEditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditPrice.Location = new System.Drawing.Point(175, 479);
            this.buttonEditPrice.Name = "buttonEditPrice";
            this.buttonEditPrice.Size = new System.Drawing.Size(144, 51);
            this.buttonEditPrice.TabIndex = 1;
            this.buttonEditPrice.Text = "Ár szerkesztése";
            this.buttonEditPrice.UseVisualStyleBackColor = true;
            this.buttonEditPrice.Click += new System.EventHandler(this.Szerkesztés_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(21, 494);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Új termékár megadása:";
            // 
            // buttonEditDescription
            // 
            this.buttonEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditDescription.Location = new System.Drawing.Point(727, 479);
            this.buttonEditDescription.Name = "buttonEditDescription";
            this.buttonEditDescription.Size = new System.Drawing.Size(178, 51);
            this.buttonEditDescription.TabIndex = 5;
            this.buttonEditDescription.Text = "Leírás szerkesztése";
            this.buttonEditDescription.UseVisualStyleBackColor = true;
            this.buttonEditDescription.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(424, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Új termékleírás megadása:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(127, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ft";
            // 
            // textboxDescription
            // 
            this.textboxDescription.Location = new System.Drawing.Point(418, 473);
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.Size = new System.Drawing.Size(303, 96);
            this.textboxDescription.TabIndex = 9;
            this.textboxDescription.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 581);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEditDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonEditPrice);
            this.Controls.Add(this.TermekekDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TermekekDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TermekekDGV;
        private System.Windows.Forms.Button buttonEditPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textboxDescription;
    }
}

