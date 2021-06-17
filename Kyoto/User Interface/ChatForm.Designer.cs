namespace Kyoto
{
    partial class chatterBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatterBox));
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.fullScreenButton = new System.Windows.Forms.Button();
            this.toolBar = new System.Windows.Forms.PictureBox();
            this.burgerMenuButton = new System.Windows.Forms.Button();
            this.burgerPanel = new System.Windows.Forms.PictureBox();
            this.kyotoLabel = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.friendAvatar = new System.Windows.Forms.PictureBox();
            this.fiendShortDesc = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.chatWithNickname = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.profileEditButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.addFriendButton = new System.Windows.Forms.Button();
            this.friendSeach = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.chatWindow = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(819, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(768, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.minimizeButton_MouseHover);
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.fullScreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullScreenButton.BackgroundImage")));
            this.fullScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullScreenButton.FlatAppearance.BorderSize = 0;
            this.fullScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreenButton.Location = new System.Drawing.Point(794, 0);
            this.fullScreenButton.Name = "fullScreenButton";
            this.fullScreenButton.Size = new System.Drawing.Size(25, 25);
            this.fullScreenButton.TabIndex = 7;
            this.fullScreenButton.UseVisualStyleBackColor = false;
            this.fullScreenButton.Click += new System.EventHandler(this.fullScreenButton_Click);
            this.fullScreenButton.MouseLeave += new System.EventHandler(this.fullScreenButton_MouseLeave);
            this.fullScreenButton.MouseHover += new System.EventHandler(this.fullScreenButton_MouseHover);
            // 
            // toolBar
            // 
            this.toolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.toolBar.Location = new System.Drawing.Point(-1, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(845, 25);
            this.toolBar.TabIndex = 8;
            this.toolBar.TabStop = false;
            this.toolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolBar_MouseDown);
            // 
            // burgerMenuButton
            // 
            this.burgerMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.burgerMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("burgerMenuButton.BackgroundImage")));
            this.burgerMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.burgerMenuButton.FlatAppearance.BorderSize = 0;
            this.burgerMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burgerMenuButton.Location = new System.Drawing.Point(0, 0);
            this.burgerMenuButton.Name = "burgerMenuButton";
            this.burgerMenuButton.Size = new System.Drawing.Size(25, 25);
            this.burgerMenuButton.TabIndex = 9;
            this.burgerMenuButton.UseVisualStyleBackColor = false;
            this.burgerMenuButton.Click += new System.EventHandler(this.burgerMenuButton_Click);
            this.burgerMenuButton.MouseLeave += new System.EventHandler(this.burgerMenuButton_MouseLeave);
            this.burgerMenuButton.MouseHover += new System.EventHandler(this.burgerMenuButton_MouseHover);
            // 
            // burgerPanel
            // 
            this.burgerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.burgerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.burgerPanel.Location = new System.Drawing.Point(-1, 12);
            this.burgerPanel.Name = "burgerPanel";
            this.burgerPanel.Size = new System.Drawing.Size(185, 413);
            this.burgerPanel.TabIndex = 10;
            this.burgerPanel.TabStop = false;
            // 
            // kyotoLabel
            // 
            this.kyotoLabel.AutoSize = true;
            this.kyotoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.kyotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kyotoLabel.Location = new System.Drawing.Point(31, 4);
            this.kyotoLabel.Name = "kyotoLabel";
            this.kyotoLabel.Size = new System.Drawing.Size(113, 16);
            this.kyotoLabel.TabIndex = 11;
            this.kyotoLabel.Text = "Kyoto Messanger";
            this.kyotoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kyotoLabel_MouseDown);
            // 
            // messageText
            // 
            this.messageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.messageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageText.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageText.ForeColor = System.Drawing.Color.White;
            this.messageText.Location = new System.Drawing.Point(400, 369);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(297, 43);
            this.messageText.TabIndex = 13;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessageButton.BackColor = System.Drawing.Color.Transparent;
            this.sendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendMessageButton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageButton.ForeColor = System.Drawing.Color.White;
            this.sendMessageButton.Location = new System.Drawing.Point(704, 369);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(128, 43);
            this.sendMessageButton.TabIndex = 14;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = false;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // friendAvatar
            // 
            this.friendAvatar.BackColor = System.Drawing.Color.White;
            this.friendAvatar.Location = new System.Drawing.Point(12, 31);
            this.friendAvatar.Name = "friendAvatar";
            this.friendAvatar.Size = new System.Drawing.Size(50, 50);
            this.friendAvatar.TabIndex = 15;
            this.friendAvatar.TabStop = false;
            // 
            // fiendShortDesc
            // 
            this.fiendShortDesc.BackColor = System.Drawing.Color.Transparent;
            this.fiendShortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiendShortDesc.ForeColor = System.Drawing.Color.White;
            this.fiendShortDesc.Location = new System.Drawing.Point(68, 31);
            this.fiendShortDesc.Name = "fiendShortDesc";
            this.fiendShortDesc.Size = new System.Drawing.Size(121, 50);
            this.fiendShortDesc.TabIndex = 16;
            this.fiendShortDesc.Text = "friendShortDesc";
            this.fiendShortDesc.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingsButton.Location = new System.Drawing.Point(0, 23);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(184, 30);
            this.settingsButton.TabIndex = 17;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // chatWithNickname
            // 
            this.chatWithNickname.AutoSize = true;
            this.chatWithNickname.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatWithNickname.Location = new System.Drawing.Point(397, 35);
            this.chatWithNickname.Name = "chatWithNickname";
            this.chatWithNickname.Size = new System.Drawing.Size(82, 19);
            this.chatWithNickname.TabIndex = 18;
            this.chatWithNickname.Text = "chatWith";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeButton.ForeColor = System.Drawing.Color.Black;
            this.removeButton.Location = new System.Drawing.Point(757, 31);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 19;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // profileEditButton
            // 
            this.profileEditButton.BackColor = System.Drawing.Color.Transparent;
            this.profileEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profileEditButton.Location = new System.Drawing.Point(0, 52);
            this.profileEditButton.Name = "profileEditButton";
            this.profileEditButton.Size = new System.Drawing.Size(184, 30);
            this.profileEditButton.TabIndex = 20;
            this.profileEditButton.Text = "Edit Profile";
            this.profileEditButton.UseVisualStyleBackColor = false;
            this.profileEditButton.Click += new System.EventHandler(this.profileEditButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Transparent;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Location = new System.Drawing.Point(0, 394);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(184, 30);
            this.logOutButton.TabIndex = 21;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // addFriendButton
            // 
            this.addFriendButton.BackColor = System.Drawing.Color.Transparent;
            this.addFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addFriendButton.Location = new System.Drawing.Point(0, 81);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(184, 30);
            this.addFriendButton.TabIndex = 22;
            this.addFriendButton.Text = "Add friend";
            this.addFriendButton.UseVisualStyleBackColor = false;
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            // 
            // friendSeach
            // 
            this.friendSeach.BackColor = System.Drawing.Color.Black;
            this.friendSeach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friendSeach.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendSeach.ForeColor = System.Drawing.Color.White;
            this.friendSeach.Location = new System.Drawing.Point(0, 109);
            this.friendSeach.Multiline = true;
            this.friendSeach.Name = "friendSeach";
            this.friendSeach.Size = new System.Drawing.Size(184, 30);
            this.friendSeach.TabIndex = 23;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Black;
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshButton.Location = new System.Drawing.Point(195, 32);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(28, 25);
            this.refreshButton.TabIndex = 24;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // chatWindow
            // 
            this.chatWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.chatWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatWindow.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatWindow.ForeColor = System.Drawing.Color.White;
            this.chatWindow.FormattingEnabled = true;
            this.chatWindow.ItemHeight = 14;
            this.chatWindow.Location = new System.Drawing.Point(401, 60);
            this.chatWindow.Name = "chatWindow";
            this.chatWindow.Size = new System.Drawing.Size(431, 296);
            this.chatWindow.TabIndex = 25;
            // 
            // chatterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(844, 423);
            this.Controls.Add(this.chatWindow);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.friendSeach);
            this.Controls.Add(this.addFriendButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.profileEditButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.chatWithNickname);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.fiendShortDesc);
            this.Controls.Add(this.friendAvatar);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.kyotoLabel);
            this.Controls.Add(this.burgerMenuButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.fullScreenButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.burgerPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(844, 423);
            this.Name = "chatterBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.chatterBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button fullScreenButton;
        private System.Windows.Forms.PictureBox toolBar;
        private System.Windows.Forms.Button burgerMenuButton;
        private System.Windows.Forms.PictureBox burgerPanel;
        private System.Windows.Forms.Label kyotoLabel;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.PictureBox friendAvatar;
        private System.Windows.Forms.Button fiendShortDesc;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label chatWithNickname;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button profileEditButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button addFriendButton;
        private System.Windows.Forms.TextBox friendSeach;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ListBox chatWindow;
    }
}