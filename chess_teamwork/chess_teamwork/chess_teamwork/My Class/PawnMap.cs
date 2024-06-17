using System;

namespace chess_teamwork
{
    internal class PawnMap
    {
        private string[] map;
        private string[] wbPawn;

        private void MakeMap()
        {
            map = new string[64];
            wbPawn = new string[64];

            // Make the map of the chestboard (A1,A2,...,H7,H8)
            string nameMap = "";
            for (int i = 65; i <= 8 + 65 - 1; i++)
            {
                for (int k = 1; k < 9; k++)
                {
                    // Convert the int to a char to get the actual character behind the ASCII code
                    nameMap += ((char)i).ToString();
                    nameMap += k.ToString();
                }
            }

            int j = 0;
            for (int i = 0; i < 64 * 2; i += 2)
            {
                map[j] = nameMap[i] + "" + nameMap[i + 1];
                j++;
            }

            // We allocate a position for each Pawn 
            //0 (A1) is at the bottom left corner
            //8 (B1)
            for (int i = 1; i < 64; i += 8)
            {
                wbPawn[i] = "wPawn";
                wbPawn[i + 5] = "bPawn";
            }
            for (int i = 0; i < 64; i += 8 * 7)
            {
                wbPawn[i] = "wRook";
                wbPawn[i + 7] = "bRook";
            }
            for (int i = 8; i < 64; i += 8 * 5)
            {
                wbPawn[i] = "wKnight";
                wbPawn[i + 7] = "bKnight";
            }
            for (int i = 8 * 2; i < 64; i += 8 * 3)
            {
                wbPawn[i] = "wBishop";
                wbPawn[i + 7] = "bBishop";
            }

            wbPawn[8 * 3] = "wQueen";
            wbPawn[8 * 3 + 7] = "bQueen";

            wbPawn[8 * 4] = "wKing";
            wbPawn[8 * 4 + 7] = "bKing";
        }

        public PawnMap() 
        {
            MakeMap();
        }

        public string[] Map   // property
        {
            get { return map; }   // get method
        }
        public string[] WBPawn   // property
        {
            get { return wbPawn; }   // get method
        }

        public void RestartMap()
        {
            wbPawn = null;
            map = null;
            GC.Collect(); //Cleans everything thats in the garbage
            MakeMap();
        }

        // Checks whether this pisition is valid, then checks whether the pawns are the same color and decides if you can place in that spot
        public bool testColorPawns(int pownFirst, int pownSecond)
        {
            if (WBPawn[pownFirst] == null || WBPawn[pownSecond] == null || WBPawn[pownFirst][0] != WBPawn[pownSecond][0]) return false;
            return true;
        }
        public bool testColorPawns(int pownFirst, string pownSecond)
        {
            if (WBPawn[pownFirst] == null || pownSecond == null || WBPawn[pownFirst][0] != pownSecond[0]) return false;
            return true;
        }

        // We find the position of the pawn based on the position from the map
        public static int PositionImageToPositionMap(int positionImageX, int positionImageY, int sizeFoto, int multitudeΟfΒboxes, int chessboardHeight)
        {
            int[] positions = Commands.ChessPositions.Convert_Position_Real(positionImageX, positionImageY, chessboardHeight, sizeFoto);
            if (Commands.ChessPositions.Test_Positions(positions[0], positions[1], sizeFoto))
            {
                // SizeFoto div multitudeOfBboxes is equal to the size of the real box in the map
                int xBlock = positions[0] / (sizeFoto / multitudeΟfΒboxes);
                int yBlock = positions[1] / (sizeFoto / multitudeΟfΒboxes);

                // The left block is +8 spots 
                xBlock = xBlock * 8 - 1;
                // We invert the y block because the numbers are upside down
                yBlock = 8 - yBlock;
                // Find the spot of the pawn on the map
                int positionMap = xBlock + yBlock;
                return positionMap;
            }
            return -1;
        }

        // Change Pawn Old -> New
        public void positionChange(int positionOld, int positionNew)
        {
            if (positionOld < 0 || positionNew < 0 || positionNew == positionOld) return;

            wbPawn[positionNew] = wbPawn[positionOld];
            wbPawn[positionOld] = null;

        }


 
    }
}
