using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_teamwork
{
    public interface DBChessInsert
    {
        // Gets the values from the players the time and the day
        void insertGameDB(string player1, string player2, string time, string day);
    }
}
