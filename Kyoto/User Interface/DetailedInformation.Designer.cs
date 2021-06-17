
namespace Kyoto.User_Interface
{
    partial class DetailedInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedInformation));
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.toolBar = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.nickNameLabel = new System.Windows.Forms.Label();
            this.shortDescLabel = new System.Windows.Forms.Label();
            this.chatWith = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.kyotoLabel = new System.Windows.Forms.Label();
            this.editNicknamePen = new System.Windows.Forms.PictureBox();
            this.nicknameField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNicknamePen)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(326, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 10;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.minimizeButton_MouseHover);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(353, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 9;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // toolBar
            // 
            this.toolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(378, 25);
            this.toolBar.TabIndex = 12;
            this.toolBar.TabStop = false;
            this.toolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolBar_MouseDown);
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.White;
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.Location = new System.Drawing.Point(8, 31);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(120, 120);
            this.avatar.TabIndex = 13;
            this.avatar.TabStop = false;
            // 
            // nickNameLabel
            // 
            this.nickNameLabel.AutoSize = true;
            this.nickNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nickNameLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickNameLabel.ForeColor = System.Drawing.Color.White;
            this.nickNameLabel.Location = new System.Drawing.Point(134, 31);
            this.nickNameLabel.Name = "nickNameLabel";
            this.nickNameLabel.Size = new System.Drawing.Size(82, 19);
            this.nickNameLabel.TabIndex = 19;
            this.nickNameLabel.Text = "chatWith";
            // 
            // shortDescLabel
            // 
            this.shortDescLabel.AutoSize = true;
            this.shortDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.shortDescLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortDescLabel.ForeColor = System.Drawing.Color.White;
            this.shortDescLabel.Location = new System.Drawing.Point(134, 50);
            this.shortDescLabel.Name = "shortDescLabel";
            this.shortDescLabel.Size = new System.Drawing.Size(39, 16);
            this.shortDescLabel.TabIndex = 20;
            this.shortDescLabel.Text = "desc";
            // 
            // chatWith
            // 
            this.chatWith.BackColor = System.Drawing.Color.Transparent;
            this.chatWith.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chatWith.ForeColor = System.Drawing.Color.White;
            this.chatWith.Location = new System.Drawing.Point(137, 121);
            this.chatWith.Name = "chatWith";
            this.chatWith.Size = new System.Drawing.Size(226, 30);
            this.chatWith.TabIndex = 22;
            this.chatWith.Text = "Message to ";
            this.chatWith.UseVisualStyleBackColor = false;
            // 
            // changePassword
            // 
            this.changePassword.BackColor = System.Drawing.Color.Transparent;
            this.changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePassword.ForeColor = System.Drawing.Color.White;
            this.changePassword.Location = new System.Drawing.Point(252, 121);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(112, 30);
            this.changePassword.TabIndex = 23;
            this.changePassword.Text = "Change password";
            this.changePassword.UseVisualStyleBackColor = false;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // kyotoLabel
            // 
            this.kyotoLabel.AutoSize = true;
            this.kyotoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.kyotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kyotoLabel.ForeColor = System.Drawing.Color.White;
            this.kyotoLabel.Location = new System.Drawing.Point(5, 4);
            this.kyotoLabel.Name = "kyotoLabel";
            this.kyotoLabel.Size = new System.Drawing.Size(113, 16);
            this.kyotoLabel.TabIndex = 24;
            this.kyotoLabel.Text = "Kyoto Messanger";
            this.kyotoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kyotoLabel_MouseDown);
            // 
            // editNicknamePen
            // 
            this.editNicknamePen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editNicknamePen.BackgroundImage")));
            this.editNicknamePen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editNicknamePen.InitialImage = ((System.Drawing.Image)(resources.GetObject("editNicknamePen.InitialImage")));
            this.editNicknamePen.Location = new System.Drawing.Point(222, 32);
            this.editNicknamePen.Name = "editNicknamePen";
            this.editNicknamePen.Size = new System.Drawing.Size(18, 18);
            this.editNicknamePen.TabIndex = 25;
            this.editNicknamePen.TabStop = false;
            this.editNicknamePen.Click += new System.EventHandler(this.editNicknamePen_Click);
            // 
            // nicknameField
            // 
            this.nicknameField.BackColor = System.Drawing.Color.Black;
            this.nicknameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicknameField.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameField.ForeColor = System.Drawing.Color.White;
            this.nicknameField.Location = new System.Drawing.Point(138, 32);
            this.nicknameField.MaxLength = 15;
            this.nicknameField.Multiline = true;
            this.nicknameField.Name = "nicknameField";
            this.nicknameField.Size = new System.Drawing.Size(144, 21);
            this.nicknameField.TabIndex = 26;
            // 
            // DetailedInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(376, 163);
            this.Controls.Add(this.nicknameField);
            this.Controls.Add(this.editNicknamePen);
            this.Controls.Add(this.kyotoLabel);
            this.Controls.Add(this.chatWith);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.shortDescLabel);
            this.Controls.Add(this.nickNameLabel);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.toolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailedInformation";
            this.Text = "DetailedInformation";
            this.Load += new System.EventHandler(this.DetailedInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNicknamePen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox toolBar;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label nickNameLabel;
        private System.Windows.Forms.Label shortDescLabel;
        private System.Windows.Forms.Button chatWith;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Label kyotoLabel;
        private System.Windows.Forms.PictureBox editNicknamePen;
        private System.Windows.Forms.TextBox nicknameField;
    }
}