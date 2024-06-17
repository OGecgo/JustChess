using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_teamwork.Inteface
{
    public interface SetNameTimePlayer
    {
        string Player1 { get; set; }
        string Player2 { get; set; }
        string GameTime { get; set; }
    }
}
