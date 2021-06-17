namespace Kyoto
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.loginFormTextBox = new System.Windows.Forms.TextBox();
            this.loginFormTextLabel = new System.Windows.Forms.Label();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.toolBar = new System.Windows.Forms.PictureBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.goToLoginButton = new System.Windows.Forms.Button();
            this.kyotoLabel = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.registrate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPicture
            // 
            this.logoPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPicture.BackgroundImage")));
            this.logoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPicture.Location = new System.Drawing.Point(137, 102);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(128, 124);
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // loginFormTextBox
            // 
            this.loginFormTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginFormTextBox.Font = new System.Drawing.Font("HelvLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormTextBox.Location = new System.Drawing.Point(105, 277);
            this.loginFormTextBox.MaxLength = 15;
            this.loginFormTextBox.Name = "loginFormTextBox";
            this.loginFormTextBox.Size = new System.Drawing.Size(194, 23);
            this.loginFormTextBox.TabIndex = 1;
            this.loginFormTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // loginFormTextLabel
            // 
            this.loginFormTextLabel.AutoSize = true;
            this.loginFormTextLabel.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormTextLabel.ForeColor = System.Drawing.Color.White;
            this.loginFormTextLabel.Location = new System.Drawing.Point(102, 254);
            this.loginFormTextLabel.Name = "loginFormTextLabel";
            this.loginFormTextLabel.Size = new System.Drawing.Size(193, 16);
            this.loginFormTextLabel.TabIndex = 2;
            this.loginFormTextLabel.Text = "Введите имя пользователя:";
            // 
            // nextStepButton
            // 
            this.nextStepButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextStepButton.BackColor = System.Drawing.Color.Black;
            this.nextStepButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextStepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextStepButton.Image = ((System.Drawing.Image)(resources.GetObject("nextStepButton.Image")));
            this.nextStepButton.Location = new System.Drawing.Point(-3, 393);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(411, 55);
            this.nextStepButton.TabIndex = 3;
            this.nextStepButton.UseVisualStyleBackColor = false;
            this.nextStepButton.MouseLeave += new System.EventHandler(this.nextStepButton_MouseLeave);
            this.nextStepButton.MouseHover += new System.EventHandler(this.nextStepButton_MouseHover);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(378, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 4;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(353, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.minimizeButton_MouseHover);
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.toolBar.Location = new System.Drawing.Point(-3, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(406, 25);
            this.toolBar.TabIndex = 6;
            this.toolBar.TabStop = false;
            this.toolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolBar_MouseDown);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.ForeColor = System.Drawing.Color.Crimson;
            this.warningLabel.Location = new System.Drawing.Point(102, 304);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(44, 13);
            this.warningLabel.TabIndex = 7;
            this.warningLabel.Text = "warning";
            // 
            // goToLoginButton
            // 
            this.goToLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.goToLoginButton.FlatAppearance.BorderSize = 0;
            this.goToLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLoginButton.Font = new System.Drawing.Font("HelvLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToLoginButton.ForeColor = System.Drawing.Color.White;
            this.goToLoginButton.Location = new System.Drawing.Point(103, 254);
            this.goToLoginButton.Name = "goToLoginButton";
            this.goToLoginButton.Size = new System.Drawing.Size(200, 48);
            this.goToLoginButton.TabIndex = 10;
            this.goToLoginButton.Text = "Начать общение";
            this.goToLoginButton.UseVisualStyleBackColor = false;
            this.goToLoginButton.Click += new System.EventHandler(this.goToLoginButton_Click);
            // 
            // kyotoLabel
            // 
            this.kyotoLabel.AutoSize = true;
            this.kyotoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.kyotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kyotoLabel.ForeColor = System.Drawing.Color.White;
            this.kyotoLabel.Location = new System.Drawing.Point(3, 4);
            this.kyotoLabel.Name = "kyotoLabel";
            this.kyotoLabel.Size = new System.Drawing.Size(113, 16);
            this.kyotoLabel.TabIndex = 12;
            this.kyotoLabel.Text = "Kyoto Messanger";
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.ForeColor = System.Drawing.Color.White;
            this.regLabel.Location = new System.Drawing.Point(108, 354);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(140, 13);
            this.regLabel.TabIndex = 13;
            this.regLabel.Text = "Don`t have an account yet?";
            // 
            // registrate
            // 
            this.registrate.AutoSize = true;
            this.registrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrate.ForeColor = System.Drawing.Color.Aqua;
            this.registrate.Location = new System.Drawing.Point(250, 354);
            this.registrate.Name = "registrate";
            this.registrate.Size = new System.Drawing.Size(49, 13);
            this.registrate.TabIndex = 14;
            this.registrate.Text = "Register!";
            this.registrate.Click += new System.EventHandler(this.registrate_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.registrate);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.kyotoLabel);
            this.Controls.Add(this.goToLoginButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.nextStepButton);
            this.Controls.Add(this.loginFormTextLabel);
            this.Controls.Add(this.loginFormTextBox);
            this.Controls.Add(this.logoPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kyoto";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.TextBox loginFormTextBox;
        private System.Windows.Forms.Label loginFormTextLabel;
        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.PictureBox toolBar;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button goToLoginButton;
        private System.Windows.Forms.Label kyotoLabel;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.Label registrate;
    }
}

