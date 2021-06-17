using Kyoto.Data_Layer.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyoto.User_Interface
{
    public partial class DetailedInformation : Form
    {
        public DetailedInformation(int userid, bool editable, bool isFriend)
        {
            userId = userid;
            isEditable = editable;
            this.isFriend = isFriend;

            InitializeComponent();
        }

        public int userId { get; set; }
        private SQLQuery query = new SQLQuery();
        public bool chatWithId = false, isAccepted = false, edited = false;
        private bool isEditable, isFriend;

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }
        private void minimizeButton_MouseHover(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.DarkGray;
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(31, 31, 31);
        }
        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(31, 31, 31);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void toolBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void DetailedInformation_Load(object sender, EventArgs e)
        {
            avatar.BackgroundImage = new Bitmap("../../User Interface/avatars/" + query.GetUserAvatar(userId));
            nickNameLabel.Text = query.GetUserLogin(userId);

            if (isEditable)
            {
                chatWith.MouseClick += new MouseEventHandler(save_Click);
                avatar.MouseClick += new MouseEventHandler(updateAvatar_Click);
                shortDescLabel.MouseClick += new MouseEventHandler(changeDesc_Click);
                chatWith.Size = new Size((chatWith.Width / 2) - 1, chatWith.Height);
                editNicknamePen.Visible = true;
                nicknameField.Visible = false;
                editNicknamePen.Location = new Point(nickNameLabel.Location.X + nickNameLabel.Width, nickNameLabel.Location.Y);
                chatWith.Text = "Save";
            }
            else if (isFriend)
            {
                chatWith.Text = "Message to " + nickNameLabel.Text;
                chatWith.MouseClick += new MouseEventHandler(chatWith_Click);
                editNicknamePen.Visible = nicknameField.Visible = false;
            }
            else if (!isFriend)
            {
                chatWith.Text = "Add " + nickNameLabel.Text + " to friend list";
                chatWith.MouseClick += new MouseEventHandler(addToFriends_Click);
                editNicknamePen.Visible = nicknameField.Visible = false;
            }

        }
        private void addToFriends_Click(object sender, EventArgs e)
        {
            isAccepted = true;
            this.Close();
        }
        private void changeDesc_Click(object sender, EventArgs e)
        {

        }
        private void updateAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = ("Image Files(*.PNG) |*.PNG;");
            string exePatch = "../../User Interface/avatars/" + userId + ".png";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    avatar.Image = new Bitmap(openDialog.FileName);
                    query.UpdateAvatar(userId, userId + ".png");
                    avatar.BackgroundImageLayout = ImageLayout.Stretch;

                    File.Delete(exePatch);
                    File.Copy(openDialog.FileName.ToString(), exePatch);
                }
                catch (Exception) { }
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (edited)
                    if (nicknameField.Text != String.Empty && query.IsThereSuchUsername(nicknameField.Text))
                        query.UpdateNickname(userId, nicknameField.Text);
            } catch (Exception) { }

            this.Close();
        }
        private void chatWith_Click(object sender, EventArgs e)
        {
            chatWithId = true;
            this.Close();
        }
        private void editNicknamePen_Click(object sender, EventArgs e)
        {
            nicknameField.Visible = true;
            nickNameLabel.Visible = editNicknamePen.Visible = false;
            edited = true;
        }
        private void changePassword_Click(object sender, EventArgs e)
        {

        }
        private void kyotoLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
