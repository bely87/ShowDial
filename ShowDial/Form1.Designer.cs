namespace ShowDial
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.server = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ldap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nom2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Основной номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Порт";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(159, 19);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(260, 20);
            this.server.TabIndex = 6;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(159, 103);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(260, 20);
            this.port.TabIndex = 7;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(159, 77);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(260, 20);
            this.password.TabIndex = 8;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(159, 49);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(260, 20);
            this.login.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ldap);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nom2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.server);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 267);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки для подключения";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ldap
            // 
            this.ldap.Location = new System.Drawing.Point(159, 208);
            this.ldap.Name = "ldap";
            this.ldap.Size = new System.Drawing.Size(260, 20);
            this.ldap.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Подключение LDAP";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(159, 181);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(260, 20);
            this.time.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Показ окна, сек";
            // 
            // nom2
            // 
            this.nom2.Location = new System.Drawing.Point(159, 155);
            this.nom2.Name = "nom2";
            this.nom2.Size = new System.Drawing.Size(260, 20);
            this.nom2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Общий номер";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(159, 129);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(260, 20);
            this.nom.TabIndex = 10;
            // 
            // Tray
            // 
            this.Tray.ContextMenuStrip = this.contextMenuStrip1;
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.Text = "Tray";
            this.Tray.Visible = true;
            this.Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem1.Text = "Выход";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 291);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Настройка приложения";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nom2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ldap;
        private System.Windows.Forms.Label label8;


    }
}

