using System.Data.SQLite;
using System.Windows.Forms;

namespace chess_teamwork
{
    public class  BaseChess : DBChessExport, DBChessInsert
    {

        //Base in SQLite
        SQLiteConnection connection;

        public BaseChess()
        {
            string connectionString = "Data source=DBChessBoard.db;Version=3;";
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string createTableSQL = $"CREATE TABLE IF NOT EXISTS DBChessBoard (" +
                                    $"Payers TEXT, " +
                                    $"TimeDay TEXT)";

            SQLiteCommand command = new SQLiteCommand(createTableSQL, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void insertGameDB(string player1, string player2, string time, string day)
        {
            connection.Open();
            string insertSQL = $"INSERT INTO DBChessBoard (" +
                                $"Payers, TimeDay) " +
                                $"VALUES (@Payers, @TimeDay)";

            SQLiteCommand command = new SQLiteCommand(insertSQL, connection);

            command.Parameters.AddWithValue("@Payers", player1 + " vs " + player2);
            command.Parameters.AddWithValue("@TimeDay","Time::" + time + " Day::" + day);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void exportGameDB(RichTextBox richTextBoxLeft, RichTextBox richTextBoxRight)
        {


            connection.Open();
            string selectIDSQL = $"SELECT * FROM DBChessBoard ;"; ;

            SQLiteCommand command = new SQLiteCommand(selectIDSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
                richTextBoxLeft.Text += i.ToString() + "* " + reader.GetString(0) + "\n";
                richTextBoxRight.Text += i.ToString() + "* " + reader.GetString(1) + "\n";

            }
            connection.Close();
        }
    }
}
