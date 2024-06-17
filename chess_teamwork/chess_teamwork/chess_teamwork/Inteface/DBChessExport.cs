using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess_teamwork
{
    public interface DBChessExport
    {
        //  Fills RichTextBoxs with info from the DB
        void exportGameDB(RichTextBox richTextBoxLeft, RichTextBox richTextBoxRight);
    }
}
