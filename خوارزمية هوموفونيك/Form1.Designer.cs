namespace خوارزمية_هوموفونيك
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxCipher = new System.Windows.Forms.GroupBox();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.groupBoxDecipher = new System.Windows.Forms.GroupBox();
            this.buttonProb = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxDecipher = new System.Windows.Forms.TextBox();
            this.groupBoxPlain = new System.Windows.Forms.GroupBox();
            this.buttonCipher = new System.Windows.Forms.Button();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCipher.SuspendLayout();
            this.groupBoxDecipher.SuspendLayout();
            this.groupBoxPlain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1170, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxCipher
            // 
            this.groupBoxCipher.Controls.Add(this.buttonDecipher);
            this.groupBoxCipher.Controls.Add(this.textBoxCipher);
            this.groupBoxCipher.Location = new System.Drawing.Point(422, 82);
            this.groupBoxCipher.Name = "groupBoxCipher";
            this.groupBoxCipher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxCipher.Size = new System.Drawing.Size(339, 240);
            this.groupBoxCipher.TabIndex = 1;
            this.groupBoxCipher.TabStop = false;
            this.groupBoxCipher.Text = "النص المشفر";
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Location = new System.Drawing.Point(218, 204);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(100, 30);
            this.buttonDecipher.TabIndex = 1;
            this.buttonDecipher.Text = "فك تشفير";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(18, 23);
            this.textBoxCipher.Multiline = true;
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCipher.Size = new System.Drawing.Size(300, 172);
            this.textBoxCipher.TabIndex = 0;
            // 
            // groupBoxDecipher
            // 
            this.groupBoxDecipher.Controls.Add(this.buttonProb);
            this.groupBoxDecipher.Controls.Add(this.buttonClear);
            this.groupBoxDecipher.Controls.Add(this.textBoxDecipher);
            this.groupBoxDecipher.Location = new System.Drawing.Point(52, 82);
            this.groupBoxDecipher.Name = "groupBoxDecipher";
            this.groupBoxDecipher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxDecipher.Size = new System.Drawing.Size(339, 240);
            this.groupBoxDecipher.TabIndex = 2;
            this.groupBoxDecipher.TabStop = false;
            this.groupBoxDecipher.Text = "النص المفكوك التشفير";
            // 
            // buttonProb
            // 
            this.buttonProb.Location = new System.Drawing.Point(103, 204);
            this.buttonProb.Name = "buttonProb";
            this.buttonProb.Size = new System.Drawing.Size(100, 30);
            this.buttonProb.TabIndex = 2;
            this.buttonProb.Text = "خيارات";
            this.buttonProb.UseVisualStyleBackColor = true;
            this.buttonProb.Click += new System.EventHandler(this.buttonProb_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(219, 204);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "مسح";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxDecipher
            // 
            this.textBoxDecipher.Location = new System.Drawing.Point(19, 21);
            this.textBoxDecipher.Multiline = true;
            this.textBoxDecipher.Name = "textBoxDecipher";
            this.textBoxDecipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDecipher.Size = new System.Drawing.Size(300, 172);
            this.textBoxDecipher.TabIndex = 0;
            // 
            // groupBoxPlain
            // 
            this.groupBoxPlain.Controls.Add(this.buttonCipher);
            this.groupBoxPlain.Controls.Add(this.textBoxPlain);
            this.groupBoxPlain.Location = new System.Drawing.Point(788, 82);
            this.groupBoxPlain.Name = "groupBoxPlain";
            this.groupBoxPlain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxPlain.Size = new System.Drawing.Size(356, 240);
            this.groupBoxPlain.TabIndex = 0;
            this.groupBoxPlain.TabStop = false;
            this.groupBoxPlain.Text = "النص الأصلي";
            // 
            // buttonCipher
            // 
            this.buttonCipher.Location = new System.Drawing.Point(219, 204);
            this.buttonCipher.Name = "buttonCipher";
            this.buttonCipher.Size = new System.Drawing.Size(100, 30);
            this.buttonCipher.TabIndex = 1;
            this.buttonCipher.Text = "تشفير";
            this.buttonCipher.UseVisualStyleBackColor = true;
            this.buttonCipher.Click += new System.EventHandler(this.buttonCipher_Click);
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(19, 26);
            this.textBoxPlain.Multiline = true;
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPlain.Size = new System.Drawing.Size(300, 172);
            this.textBoxPlain.TabIndex = 0;
            this.textBoxPlain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPlain_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 261);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 355);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxPlain);
            this.Controls.Add(this.groupBoxDecipher);
            this.Controls.Add(this.groupBoxCipher);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "هوموفونيك";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCipher.ResumeLayout(false);
            this.groupBoxCipher.PerformLayout();
            this.groupBoxDecipher.ResumeLayout(false);
            this.groupBoxDecipher.PerformLayout();
            this.groupBoxPlain.ResumeLayout(false);
            this.groupBoxPlain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxCipher;
        private System.Windows.Forms.GroupBox groupBoxDecipher;
        private System.Windows.Forms.GroupBox groupBoxPlain;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxDecipher;
        private System.Windows.Forms.Button buttonCipher;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.Button buttonProb;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

