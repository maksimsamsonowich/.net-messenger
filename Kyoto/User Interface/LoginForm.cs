using Kyoto.Data_Layer.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyoto
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            this.nextStepButton.Image = (Image)(new Bitmap(nextStepButton.Image, new Size(32, 32)));
            warningLabel.Visible = false;
        }

        private bool nextFormIndicator = false, isRegistration = false, reg =false;
        private string userLogin = "";
        private int userIdentificator;
        private SQLQuery query = new SQLQuery();

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void loginForm_Load(object sender, EventArgs e)
        {
            loginFormTextLabel.Visible = false;
            loginFormTextBox.Visible = false;
            nextStepButton.Visible = false;

            nextStepButton.MouseClick += new MouseEventHandler(nextStepButton_Click);
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(31, 31, 31);
        }
        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(31, 31, 31);
        }
        private void nextStepButton_MouseHover(object sender, EventArgs e)
        {
            nextStepButton.BackColor = Color.DarkGray;
        }
        private void nextStepButton_MouseLeave(object sender, EventArgs e)
        {
            nextStepButton.BackColor = Color.Black;
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
        private void LoginFault()
        {
            loginFormTextLabel.Text = "Введите имя пользователя:";
            loginFormTextBox.Clear();
            loginFormTextBox.PasswordChar = '\0';
            warningLabel.Text = "Query fault :(";
            warningLabel.Visible = true;

            nextFormIndicator = false;
        }
        private bool IsLoginValid(string login, string password)
        {
            if (query.IsAuthorizationSuccess(login, password)) 
                return true;
            else
                return false;
        }
        private void nextStepButton_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;

            if (nextFormIndicator)
            {
                if (query.IsAuthorizationSuccess(userLogin, loginFormTextBox.Text))
                {
                    this.Hide();
                    userIdentificator = query.GetUserId(userLogin);
                    chatterBox chatter = new chatterBox(userIdentificator);
                    chatter.Show();
                }
                else
                {
                    LoginFault();
                }
            }
            else
            {
                userLogin = loginFormTextBox.Text;
                loginFormTextLabel.Text = "Введите пароль:";
                loginFormTextBox.Clear();
                loginFormTextBox.PasswordChar = '*';
                nextFormIndicator = true;
            }
        }
        private void registration_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;

            if (isRegistration)
            {
                if (query.IsRegistrationSuccess(userLogin, loginFormTextBox.Text) && !query.IsThereSuchUsername(userLogin))
                {
                    this.Hide();
                    userIdentificator = query.GetUserId(userLogin);
                    chatterBox chatter = new chatterBox(userIdentificator);
                    chatter.Show();
                }
                else
                {
                    LoginFault();
                }
            }
            else
            {
                userLogin = loginFormTextBox.Text;
                loginFormTextLabel.Text = "Введите пароль:";
                loginFormTextBox.Clear();
                loginFormTextBox.PasswordChar = '*';
                isRegistration = true;
            }
        }
        private void goToLoginButton_Click(object sender, EventArgs e)
        {
            nextStepButton.Visible = loginFormTextBox.Visible = loginFormTextLabel.Visible = true;
            regLabel.Visible = registrate.Visible = goToLoginButton.Visible = false;
        }
        private void loginForm_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (goToLoginButton.Visible)
                {
                    goToLoginButton_Click(sender, e);
                }
                else
                {
                    if (!reg)
                        nextStepButton_Click(sender, e);
                    else
                        registration_Click(sender, e);
                }
            }

        }
        private void registrate_Click(object sender, EventArgs e)
        {
            nextStepButton.Visible = loginFormTextBox.Visible = loginFormTextLabel.Visible = true;
            regLabel.Visible = registrate.Visible = goToLoginButton.Visible = false;

            nextStepButton.MouseClick -= new MouseEventHandler(nextStepButton_Click);
            nextStepButton.MouseClick += new MouseEventHandler(registration_Click);
        }
    }
}
