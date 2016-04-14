namespace ShowDial
{
    partial class ShowDial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDial));
            this.name = new System.Windows.Forms.Label();
            this.otdel = new System.Windows.Forms.Label();
            this.dolj = new System.Windows.Forms.Label();
            this.kompa = new System.Windows.Forms.Label();
            this.nom1 = new System.Windows.Forms.Label();
            this.kab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(3, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(180, 25);
            this.name.TabIndex = 0;
            this.name.Text = "00000000000000";
            // 
            // otdel
            // 
            this.otdel.AutoSize = true;
            this.otdel.Location = new System.Drawing.Point(3, 50);
            this.otdel.Name = "otdel";
            this.otdel.Size = new System.Drawing.Size(132, 25);
            this.otdel.TabIndex = 1;
            this.otdel.Text = "0000000000";
            // 
            // dolj
            // 
            this.dolj.AutoSize = true;
            this.dolj.Location = new System.Drawing.Point(3, 25);
            this.dolj.Name = "dolj";
            this.dolj.Size = new System.Drawing.Size(144, 25);
            this.dolj.TabIndex = 2;
            this.dolj.Text = "00000000000";
            // 
            // kompa
            // 
            this.kompa.AutoSize = true;
            this.kompa.Location = new System.Drawing.Point(3, 75);
            this.kompa.Name = "kompa";
            this.kompa.Size = new System.Drawing.Size(156, 25);
            this.kompa.TabIndex = 3;
            this.kompa.Text = "000000000000";
            // 
            // nom1
            // 
            this.nom1.AutoSize = true;
            this.nom1.Location = new System.Drawing.Point(3, 100);
            this.nom1.Name = "nom1";
            this.nom1.Size = new System.Drawing.Size(84, 25);
            this.nom1.TabIndex = 4;
            this.nom1.Text = "000000";
            // 
            // kab
            // 
            this.kab.AutoSize = true;
            this.kab.Location = new System.Drawing.Point(3, 125);
            this.kab.Name = "kab";
            this.kab.Size = new System.Drawing.Size(96, 25);
            this.kab.TabIndex = 6;
            this.kab.Text = "0000000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 137);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dolj, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.otdel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kompa, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nom1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.kab, 0, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(147, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 154);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(26, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Скрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowDial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowDial";
            this.Text = "ShowDial";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ShowDial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label otdel;
        private System.Windows.Forms.Label dolj;
        private System.Windows.Forms.Label kompa;
        private System.Windows.Forms.Label kab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label nom1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}