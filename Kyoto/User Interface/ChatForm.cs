#region ProjectLibs
using Kyoto.Data_Layer.Database;
using Kyoto.User_Interface;
#endregion
#region System
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
#endregion
#region QDP Libs
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
#endregion


namespace Kyoto
{
    public partial class chatterBox : Form
    {

        #region UDPsettingup
        private UdpClient client;
        private IPAddress groupAddress;
        private const int port = 8001;
        private const int TTL = 20;
        private bool alive = false;
        private string HOST = "235.5.5.1";
        public int messageTo { get; set; }
        #endregion

        private class Conversation
        {
            public PictureBox friendAvatar { get; set; }
            public Button friendDesc { get; set; }
            public string friendNickname { get; set; }
            public int id { get; set; }
            public Conversation(string nickname, PictureBox pictureBox, Button button, int id)
            {
                friendAvatar = pictureBox;
                friendDesc = button;
                friendNickname = nickname;
                this.id = id;
            }
        }

        private int userIdentificator;

        public chatterBox(int userIdentificator)
        {
            InitializeComponent();

            this.userIdentificator = userIdentificator;
            groupAddress = IPAddress.Parse(HOST);
        }

        private SQLQuery query = new SQLQuery();
        private List<Conversation> conversations = new List<Conversation>();
        private bool burgerMenuIndicator = false;
        private int chatWith = 0, toRemove = 0;

        private void chatterBox_Load(object sender, EventArgs e)
        {
            chatterBox_Reload();

            chatWindow.Size = new Size(592, 296);
            chatWindow.Location = new Point(240, 56);
            messageText.Size = new Size(458, 43);
            messageText.Location = new Point(240, 369);
            chatWithNickname.Location = new Point(240, 34);

            ChatConnection();
        }
        private void chatterBox_Reload()
        {
            ConverfationsFilling(query.GetUserFriends(query.GetUserLogin(userIdentificator)));
            burgerPanel.Visible = kyotoLabel.Visible = friendAvatar.Visible = fiendShortDesc.Visible =
                settingsButton.Visible = removeButton.Visible = profileEditButton.Visible = logOutButton.Visible =
                addFriendButton.Visible = friendSeach.Visible = false;

            chatWithNickname.Text = "Welcome to Kyoto!";

            if (conversations.Count == 0)
                refreshButton.Visible = false;
            else
                refreshButton.Visible = true;
        }
        private void ConverfationsFilling(List<string> friends)
        {
            if (friends.Count == 0 || friends == null || friends.ElementAt(0) == "0")
                return;

            int locationY = -25;
            foreach (var creation in friends)
            {
                locationY += 55;

                var pictureBox = new PictureBox();
                pictureBox.Location = new Point(friendAvatar.Location.X, locationY);
                pictureBox.BackColor = Color.White;
                pictureBox.Size = new Size(friendAvatar.Width, friendAvatar.Height);
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox.BackgroundImage = new Bitmap("../../User Interface/avatars/" + query.GetUserAvatar((Convert.ToInt32(creation))));
                pictureBox.MouseClick += new MouseEventHandler(detailedInformation_Click);
                this.Controls.Add(pictureBox);

                var button = new Button();
                button.Location = new Point(fiendShortDesc.Location.X, locationY);
                button.BackColor = Color.Transparent;
                button.Size = new Size(fiendShortDesc.Width, fiendShortDesc.Height);
                button.FlatStyle = FlatStyle.Popup;
                button.Text = query.GetUserLogin(Convert.ToInt32(creation));
                button.MouseClick += new MouseEventHandler(friend_Click);
                this.Controls.Add(button);
                conversations.Add(new Conversation(button.Text, pictureBox, button, (Convert.ToInt32(creation))));
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            UserDisconnect();
            Application.Exit();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
        private void fullScreenButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }
        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }
        private void fullScreenButton_MouseHover(object sender, EventArgs e)
        {
            fullScreenButton.BackColor = Color.DarkGray;
        }
        private void minimizeButton_MouseHover(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.DarkGray;
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(31, 31, 31);
        }
        private void fullScreenButton_MouseLeave(object sender, EventArgs e)
        {
            fullScreenButton.BackColor = Color.FromArgb(31, 31, 31);
        }
        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(31, 31, 31);
        }
        private void burgerMenuButton_MouseHover(object sender, EventArgs e)
        {
            burgerMenuButton.BackColor = Color.DarkGray;
        }
        private void burgerMenuButton_MouseLeave(object sender, EventArgs e)
        {
            burgerMenuButton.BackColor = Color.FromArgb(31, 31, 31);
        }
        private void burgerMenuButton_Click(object sender, EventArgs e)
        {
            if (burgerMenuIndicator)
            {
                burgerMenuButton.Location = new Point(0, 0);

                profileEditButton.Visible = logOutButton.Visible = settingsButton.Visible = kyotoLabel.Visible =
                    burgerMenuIndicator = burgerPanel.Visible = addFriendButton.Visible = friendSeach.Visible = false;

                foreach (var friend in conversations)
                {
                    friend.friendAvatar.Location = new Point(friend.friendAvatar.Location.X - 178, friend.friendAvatar.Location.Y);
                    friend.friendDesc.Location = new Point(friend.friendDesc.Location.X - 178, friend.friendDesc.Location.Y);
                }

                refreshButton.Location = new Point(refreshButton.Location.X - 178, refreshButton.Location.Y);

                chatWindow.Size = new Size(592, 296);
                chatWindow.Location = new Point(240, 56);
                messageText.Size = new Size(458, 43);
                messageText.Location = new Point(240, 369);
                chatWithNickname.Location = new Point(240, 34);
            }
            else
            {
                burgerMenuButton.Location = new Point(159, 0);
                
                profileEditButton.Visible = logOutButton.Visible = settingsButton.Visible = kyotoLabel.Visible =
                    burgerMenuIndicator = burgerPanel.Visible = addFriendButton.Visible = true;
                friendSeach.Visible = false;
                addFriendButton.Text = "Add friends";
                addFriendButton.Location = new Point(0, 81);

                foreach (var friend in conversations)
                {
                    friend.friendAvatar.Location = new Point(friend.friendAvatar.Location.X + 178, friend.friendAvatar.Location.Y);
                    friend.friendDesc.Location = new Point(friend.friendDesc.Location.X + 178, friend.friendDesc.Location.Y);
                }

                refreshButton.Location = new Point(refreshButton.Location.X + 178, refreshButton.Location.Y);

                chatWindow.Size = new Size(431, 296);
                chatWindow.Location = new Point(401, 56);
                messageText.Size = new Size(297, 43);
                messageText.Location = new Point(401, 369);
                chatWithNickname.Location = new Point(405, 34);
            }
        }
        private void friend_Click(object sender, MouseEventArgs e)
        {
            foreach (var friend in conversations)
            {
                if ((Button)sender == friend.friendDesc)
                {
                    chatWith = friend.id;
                    chatWindow.Items.Clear();
                    chatWithNickname.Text = "Chat with: " + friend.friendNickname;
                }
            }

            List<string> messages = query.getChatHistory(userIdentificator, chatWith);

            if (messages != null)
                foreach (var message in messages)
                    chatWindow.Items.Add(message);
        }
        private void detailedInformation_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (var friend in conversations)
                    if ((PictureBox)sender == friend.friendAvatar)
                        toRemove = friend.id;
                
                removeButton.Visible = true;
                removeButton.Location = this.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
            else if (e.Button == MouseButtons.Left)
            {
                object currentObject = null;

                foreach (var friend in conversations)
                    if ((PictureBox)sender == friend.friendAvatar)
                    {
                        toRemove = friend.id;
                        currentObject = friend.friendDesc;
                    }

                removeButton.Visible = false;
                DetailedInformation detailed = new DetailedInformation(toRemove, false, true);
                detailed.FormClosed += (object s, FormClosedEventArgs ev) =>
                {
                    if (detailed.chatWithId)
                        friend_Click(currentObject, e);
                };

                detailed.Show();
            }
        }
        private bool removeControls()
        {
            foreach(var user in conversations)
            {
                this.Controls.Remove(user.friendAvatar);
                this.Controls.Remove(user.friendDesc);
            }

            conversations.Clear();

            return true;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (var friend in conversations)
            {
                if (friend.id == toRemove)
                {
                    string users = "";

                    conversations.Remove(friend);
                    this.Controls.Remove(friend.friendAvatar);
                    this.Controls.Remove(friend.friendDesc);

                    foreach (var friends in conversations)
                        users += friends.id + ":";

                    if (users.EndsWith(":"))
                        users = users.Remove(users.Length - 1);

                    if (conversations.Count == 0)
                        query.RemoveFriend(userIdentificator, "0");
                    else
                        query.RemoveFriend(userIdentificator, users);

                    users = "";

                    List<string> temp = query.GetUserFriends(query.GetUserLogin(toRemove));
                    if (temp.Count == 1 & temp[0] == userIdentificator.ToString())
                        query.RemoveFriend(toRemove, "0");
                    else
                    {
                        foreach (var user in temp)
                            if (user != userIdentificator.ToString())
                                users += user + ":";

                        if (users.EndsWith(":"))
                            users = users.Remove(users.Length - 1);

                        query.RemoveFriend(toRemove, users);
                    }

                    if (removeControls())
                        chatterBox_Reload();

                    return;
                }
            }
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            UserDisconnect();

            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
        private void profileEditButton_Click(object sender, EventArgs e)
        {
            DetailedInformation detailed = new DetailedInformation(userIdentificator, true, true);
            detailed.Show();
        }
        private void kyotoLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private bool IsAlreadyFriends(string usernickname)
        {
            foreach (var user in conversations)
                if (user.friendNickname == usernickname)
                    return true;

            return false;
        }
        private void addFriendButton_Click(object sender, EventArgs e)
        {
            if (friendSeach.Text != String.Empty)
                if (!query.IsThereSuchUsername(friendSeach.Text) && query.GetUserId(friendSeach.Text) != userIdentificator &&
                    !IsAlreadyFriends(friendSeach.Text))
                {
                    DetailedInformation detailed = new DetailedInformation(query.GetUserId(friendSeach.Text), false, false);
                    detailed.FormClosed += (object s, FormClosedEventArgs ev) =>
                    {
                        if (detailed.isAccepted)
                            query.AddFriend(userIdentificator, detailed.userId);

                        if (removeControls())
                            chatterBox_Reload();
                    };
                    detailed.Show();
                    burgerMenuButton_Click(sender, e);
                    friendSeach.Visible = true;
                } else
                {
                    friendSeach.BackColor = Color.FromArgb(128, 0, 0);
                    friendSeach.Text = "";

                    return;
                }

            if (!friendSeach.Visible)
            {
                friendSeach.Visible = true;
                friendSeach.Location = new Point(0, 81);
                addFriendButton.Text = "Find";
                addFriendButton.Location = new Point(0, 109);
            }
            else
            {
                friendSeach.Visible = false;
                addFriendButton.Location = new Point(0, 81);
                friendSeach.Text = null;
                friendSeach.BackColor = Color.Black;
                addFriendButton.Text = "Add friends";
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (removeControls())
                chatterBox_Reload();
        }

        #region UDPQuery // struct: [0]senderId~[1]receiverId~[2]message
        private void ChatConnection()
        {
            client = new UdpClient(port);

            client.JoinMulticastGroup(groupAddress, TTL);

            Task receiveTask = new Task(ReceiveMessages);
            receiveTask.Start();

            string message = query.GetUserLogin(userIdentificator) + " is online!";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, port);
        }
        private bool isThatForMe(string[] message)
        {
            if (message == null || message.Length == 1)
                return false;

            if (message[1] == userIdentificator.ToString() && message[0] == chatWith.ToString())
                return true;
            else
                return false;
        }
        private string constructMessage(string message)
        {
            return userIdentificator.ToString() + "~" + chatWith.ToString() + "~" + message;
        }
        private string[] getFullMessage(string message)
        {
            return message.Split('~');
        }
        private string discipherMessage(string message)
        {
            string[] text = getFullMessage(message);

            return query.GetUserLogin(Convert.ToInt32(text[1])) + ": " + messageFormat(text[2]);
        }
        private string messageFormat(string message)
        {
            return message.Insert(35, "\n");
        }
        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);

                    this.Invoke(new MethodInvoker(() =>
                    {
                        if (chatWith == 0) { }
                        else
                            if (isThatForMe(getFullMessage(message)))
                                chatWindow.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " + discipherMessage(message));
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
            }
        }
        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (messageText.Text == String.Empty || chatWith == 0)
                    return;

                query.uploadMessageToLogs(userIdentificator, chatWith, DateTime.Now.ToShortTimeString(), messageText.Text);

                chatWindow.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " + query.GetUserLogin(userIdentificator) + ": " + messageText.Text);

                string message = constructMessage(messageText.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, port);
                messageText.Clear();
            }
            catch (Exception) { }
        }
        private void ExitChat()
        {
            string message = query.GetUserLogin(userIdentificator) + " disconnected!";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, port);
            client.DropMulticastGroup(groupAddress);

            alive = false;
            client.Close();
        }
        private void UserDisconnect()
        {
            if (alive == true) ExitChat();
        }
        #endregion
    }
}
