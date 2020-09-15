namespace ChatForm
{
    partial class AntWork
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntWork));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listUser = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listFind = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pod = new System.Windows.Forms.Label();
            this.Mess = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Citata = new System.Windows.Forms.Label();
            this.EnetLogorPass = new System.Windows.Forms.Label();
            this.ErrorTxt = new System.Windows.Forms.Label();
            this.LoginEnter = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.PassEnter = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listUser);
            this.panel1.Location = new System.Drawing.Point(598, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 456);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сейчас в чате:";
            // 
            // listUser
            // 
            this.listUser.BackColor = System.Drawing.Color.PowderBlue;
            this.listUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listUser.FormattingEnabled = true;
            this.listUser.ItemHeight = 14;
            this.listUser.Location = new System.Drawing.Point(6, 40);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(202, 392);
            this.listUser.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.listFind);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.listHistory);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 456);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(3, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 60);
            this.panel5.TabIndex = 9;
            this.panel5.Visible = false;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(195, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(18, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Location = new System.Drawing.Point(2, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Выйти ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label2";
            // 
            // listFind
            // 
            this.listFind.BackColor = System.Drawing.Color.PowderBlue;
            this.listFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFind.FormattingEnabled = true;
            this.listFind.Location = new System.Drawing.Point(5, 45);
            this.listFind.Name = "listFind";
            this.listFind.Size = new System.Drawing.Size(212, 351);
            this.listFind.TabIndex = 9;
            this.listFind.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Image = global::ChatForm.Properties.Resources.hh;
            this.button2.Location = new System.Drawing.Point(-3, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Выгрузить историю";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // listHistory
            // 
            this.listHistory.BackColor = System.Drawing.Color.PowderBlue;
            this.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHistory.FormattingEnabled = true;
            this.listHistory.Location = new System.Drawing.Point(9, 40);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(202, 364);
            this.listHistory.TabIndex = 2;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Coral;
            this.pictureBox6.BackgroundImage = global::ChatForm.Properties.Resources.hh;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Image = global::ChatForm.Properties.Resources.icons8_поиск_48;
            this.pictureBox6.Location = new System.Drawing.Point(179, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(46, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Поиск";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatForm.Properties.Resources.Screenshot_1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChatForm.Properties.Resources.Screenshot_2;
            this.pictureBox2.Location = new System.Drawing.Point(176, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 457);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ChatForm.Properties.Resources.Screenshot_1;
            this.pictureBox3.Location = new System.Drawing.Point(176, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(430, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Image = global::ChatForm.Properties.Resources.Screenshot_1;
            this.label3.Location = new System.Drawing.Point(235, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Чат с коллегами";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Pod);
            this.panel3.Controls.Add(this.Mess);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(223, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 58);
            this.panel3.TabIndex = 5;
            // 
            // Pod
            // 
            this.Pod.AutoSize = true;
            this.Pod.Location = new System.Drawing.Point(303, 10);
            this.Pod.Name = "Pod";
            this.Pod.Size = new System.Drawing.Size(59, 13);
            this.Pod.TabIndex = 2;
            this.Pod.Text = "Shift+Enter";
            this.Pod.Visible = false;
            // 
            // Mess
            // 
            this.Mess.Location = new System.Drawing.Point(0, 15);
            this.Mess.Multiline = true;
            this.Mess.Name = "Mess";
            this.Mess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Mess.Size = new System.Drawing.Size(287, 40);
            this.Mess.TabIndex = 1;
            this.Mess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mess_KeyDown_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::ChatForm.Properties.Resources.hh;
            this.button1.Location = new System.Drawing.Point(288, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Citata);
            this.panel4.Controls.Add(this.EnetLogorPass);
            this.panel4.Controls.Add(this.ErrorTxt);
            this.panel4.Controls.Add(this.LoginEnter);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.Login);
            this.panel4.Controls.Add(this.PassEnter);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(-3, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(798, 432);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Citata
            // 
            this.Citata.AutoSize = true;
            this.Citata.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Citata.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Citata.Image = global::ChatForm.Properties.Resources.fon_button;
            this.Citata.Location = new System.Drawing.Point(216, 116);
            this.Citata.Name = "Citata";
            this.Citata.Size = new System.Drawing.Size(412, 25);
            this.Citata.TabIndex = 46;
            this.Citata.Text = "Чат AntWork - твои коллеги на связи";
            this.Citata.Click += new System.EventHandler(this.Citata_Click);
            // 
            // EnetLogorPass
            // 
            this.EnetLogorPass.AutoSize = true;
            this.EnetLogorPass.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnetLogorPass.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.EnetLogorPass.Image = global::ChatForm.Properties.Resources.fon_button;
            this.EnetLogorPass.Location = new System.Drawing.Point(244, 115);
            this.EnetLogorPass.Name = "EnetLogorPass";
            this.EnetLogorPass.Size = new System.Drawing.Size(355, 23);
            this.EnetLogorPass.TabIndex = 45;
            this.EnetLogorPass.Text = "Введите логин и пароль для входа";
            this.EnetLogorPass.Visible = false;
            this.EnetLogorPass.Click += new System.EventHandler(this.EnetLogorPass_Click);
            // 
            // ErrorTxt
            // 
            this.ErrorTxt.AutoSize = true;
            this.ErrorTxt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorTxt.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.ErrorTxt.Image = global::ChatForm.Properties.Resources.fon_button;
            this.ErrorTxt.Location = new System.Drawing.Point(268, 115);
            this.ErrorTxt.Name = "ErrorTxt";
            this.ErrorTxt.Size = new System.Drawing.Size(292, 23);
            this.ErrorTxt.TabIndex = 44;
            this.ErrorTxt.Text = "Неверный логин или пароль";
            this.ErrorTxt.Visible = false;
            this.ErrorTxt.Click += new System.EventHandler(this.ErrorTxt_Click);
            // 
            // LoginEnter
            // 
            this.LoginEnter.BackColor = System.Drawing.Color.Snow;
            this.LoginEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginEnter.Location = new System.Drawing.Point(281, 174);
            this.LoginEnter.Name = "LoginEnter";
            this.LoginEnter.Size = new System.Drawing.Size(268, 35);
            this.LoginEnter.TabIndex = 43;
            this.LoginEnter.TextChanged += new System.EventHandler(this.LoginEnter_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Coral;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(2, 408);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 23);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "О программе";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Chocolate;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(374, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Войти";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ChatForm.Properties.Resources.fon_button;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(284, 317);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(261, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Image = global::ChatForm.Properties.Resources.fon_button;
            this.label9.Location = new System.Drawing.Point(281, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "Пароль";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Image = global::ChatForm.Properties.Resources.fon_button;
            this.Login.Location = new System.Drawing.Point(281, 147);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(69, 23);
            this.Login.TabIndex = 35;
            this.Login.Text = "Логин";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // PassEnter
            // 
            this.PassEnter.BackColor = System.Drawing.Color.Snow;
            this.PassEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassEnter.Location = new System.Drawing.Point(283, 259);
            this.PassEnter.Name = "PassEnter";
            this.PassEnter.PasswordChar = '*';
            this.PassEnter.Size = new System.Drawing.Size(268, 35);
            this.PassEnter.TabIndex = 34;
            this.PassEnter.TextChanged += new System.EventHandler(this.PassEnter_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ChatForm.Properties.Resources.Без_имени_1;
            this.pictureBox4.Location = new System.Drawing.Point(-13, -17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(833, 509);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.HorizontalScrollbar = true;
            this.listMessage.Location = new System.Drawing.Point(222, 39);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(376, 342);
            this.listMessage.TabIndex = 8;
            // 
            // AntWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChatForm.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(797, 428);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AntWork";
            this.Text = "AntWorkChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AntWork_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AntWork_FormClosed);
            this.Load += new System.EventHandler(this.AntWork_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AntWork_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Citata;
        private System.Windows.Forms.Label EnetLogorPass;
        private System.Windows.Forms.Label ErrorTxt;
        private System.Windows.Forms.TextBox LoginEnter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox PassEnter;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listUser;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listFind;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Mess;
        private System.Windows.Forms.Label Pod;
    }
}

