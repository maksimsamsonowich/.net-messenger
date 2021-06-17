using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyoto.Data_Layer.Database
{
    class SQLQuery
    {
        Database db = new Database();

        public SQLQuery() { }

        #region Profile Query // struct: [0]id [1]username [2]password [3]conversations [4]avatar
        public bool IsAuthorizationSuccess(string username, string password)
        {
            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Username` = @uLogin AND `Password` = @uPass", db.GetConnection());
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.CloseConnection();

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private DataTable GetTableById(int id)
        {
            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Id` = @uId", db.GetConnection());
            command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.CloseConnection();

            return table;
        }
        private DataTable GetTableByUsername(string username)
        {
            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Username` = @uLogin", db.GetConnection());
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.CloseConnection();

            return table;
        }
        public bool IsThereSuchUsername(string username)
        {
            DataTable table = GetTableByUsername(username);

            if (table.Rows.Count > 0)
                return false;
            else
                return true;
        }
        public bool IsRegistrationSuccess(string username, string password)
        {
            if (!IsThereSuchUsername(username))
                return false;

            bool success;

            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Id`, `Username`, `Password`, `Conversations`, `Avatar`) VALUES (NULL, @uLogin, @uPass, '0', 'default.png');", db.GetConnection());
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = password;

            if (command.ExecuteNonQuery() == 1)
                success = true;
            else
                success = false;

            db.CloseConnection();

            return success;
        }
        public int GetUserId(string username)
        {
            DataTable table = GetTableByUsername(username);

            foreach (DataRow row in table.Rows)
            {
                if (row.ItemArray[1].ToString() == username)
                    return Convert.ToInt32(row.ItemArray[0]);
            }

            return 0;
        }
        public string GetUserLogin(int id)
        {
            DataTable table = GetTableById(id);

            foreach (DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row.ItemArray[0]) == id)
                    return row.ItemArray[1].ToString();
            }

            return null;
        }
        public List<string> GetUserFriends(string username)
        {
            DataTable table = GetTableByUsername(username);

            foreach (DataRow row in table.Rows)
            {
                if (row.ItemArray[1].ToString() == username)
                    return row.ItemArray[3].ToString().Split(':').ToList();
            }

            return null;
        }
        private string GetFrinds(int id)
        {
            DataTable table = GetTableById(id);

            foreach (DataRow row in table.Rows)
            {
                if (row.ItemArray[0].ToString() == id.ToString())
                    return row.ItemArray[3].ToString();
            }

            return null;
        }
        public string GetUserAvatar(int id)
        {
            DataTable table = GetTableById(id);

            foreach (DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row.ItemArray[0]) == id)
                    return row.ItemArray[4].ToString();
            }

            return null;
        }
        public bool RemoveFriend(int userid, string conversations)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Conversations` = '" + conversations + "' WHERE `Id` = " + userid, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.CloseConnection();

            return true;
        }
        public void AddFriend(int userid, int friendid)
        {
            string friends = "";

            if (GetFrinds(userid) == "0")
                friends = friendid.ToString();
            else
                friends = GetFrinds(userid) + ":" + friendid;

            DataTable dt = new DataTable();
            db.OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Conversations` = '" + friends + "' WHERE `Id` = " + userid, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);


            friends = "";
            if (GetFrinds(friendid) == "0")
                friends = userid.ToString();
            else
                friends = GetFrinds(friendid) + ":" + userid;

            command = new MySqlCommand("UPDATE `users` SET `Conversations` = '" + friends + "' WHERE `Id` = " + friendid, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.CloseConnection();
        }
        public void UpdateAvatar(int userid, string avatar)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Avatar` = '" + avatar + "' WHERE `Id` = " + userid, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.CloseConnection();
        }
        public void UpdateNickname(int userid, string nickname)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Username` = '" + nickname + "' WHERE `Id` = " + userid, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.CloseConnection();
        }
        #endregion
        #region Chat Logs Query // struct: [0]from [1]to [2]date [3]message
        public bool uploadMessageToLogs(int senderId, int receiverId, string date, string message)
        {
            bool success;

            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("INSERT INTO `messages` (`fromId`, `toId`, `time`, `message`) VALUES (@sId, @rId, @time, @mess);", db.GetConnection());
            command.Parameters.Add("@sId", MySqlDbType.VarChar).Value = senderId;
            command.Parameters.Add("@rId", MySqlDbType.VarChar).Value = receiverId;
            command.Parameters.Add("@time", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@mess", MySqlDbType.VarChar).Value = message;

            if (command.ExecuteNonQuery() == 1)
                success = true;
            else
                success = false;

            db.CloseConnection();

            return success;
        }
        public List<string> getChatHistory(int senderId, int receiverId)
        {
            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `messages` WHERE `fromId` = @sId AND `toId` = @rId", db.GetConnection());
            command.Parameters.Add("@sId", MySqlDbType.VarChar).Value = senderId;
            command.Parameters.Add("@rId", MySqlDbType.VarChar).Value = receiverId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            List<string> messages = new List<string>();

            if (table.Rows != null || table.Rows.Count != 0)
                foreach (DataRow row in table.Rows)
                {
                    messages.Add("[" + row.ItemArray[2].ToString() + "] " + GetUserLogin(Convert.ToInt32(row.ItemArray[0])) + ": " +
                        row.ItemArray[3].ToString());
                }

            command = new MySqlCommand("SELECT * FROM `messages` WHERE `fromId` = @rId AND `toId` = @sId", db.GetConnection());
            command.Parameters.Add("@sId", MySqlDbType.VarChar).Value = senderId;
            command.Parameters.Add("@rId", MySqlDbType.VarChar).Value = receiverId;

            table.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows != null || table.Rows.Count != 0)
                foreach (DataRow row in table.Rows)
                {
                    messages.Add("[" + row.ItemArray[2].ToString() + "] " + GetUserLogin(Convert.ToInt32(row.ItemArray[0])) + ": " +
                        row.ItemArray[3].ToString());
                }

            db.CloseConnection();

            messages = messages.OrderBy(x => x).ToList();

            if (messages.Count == 0)
                return null;
            else
                return messages;
        }
        #endregion
    }
}
