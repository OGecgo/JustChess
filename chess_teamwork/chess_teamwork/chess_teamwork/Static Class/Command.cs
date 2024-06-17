using System;
using System.Drawing;
using System.Windows.Forms;

namespace chess_teamwork
{
    internal static class Commands 
    {

        // I disable all buttons which are picturebox
        public static void Stop_Butons(PictureBox[] butons)
        {
            for (int i = 0; i < butons.Length; i++)
            {
                butons[i].Visible = false;
            }
        }

        // I enable all buttons which are picturebox
        public static void Start_Buttons(PictureBox[] butons)
        {
            for (int i = 0; i < butons.Length; i++)
            {
                butons[i].Visible = true;
            }
        }

        // I define the size of the label according to its size
        public static void Take_Label_Size(Label label)
        {
            label.Font.Dispose();
            if (label.Height / 3 > 0)
            {
                // font size is height / 3
                label.Font = new Font(label.Font.FontFamily, label.Height / 3);

            }
            else
            {
                // font size is 1 if height / 3 = 0
                label.Font = new Font(label.Font.FontFamily, 1);
            }
        }


        //
        // My classes
        //

        // the chess class is used for position conversion functions
        public static class ChessPositions
        {
            // check if the points is out of range image
            public static bool Test_Positions(int x, int y, int sizeFoto)
            {
                if ((x + 1) * (y + 1) >= 1 && x <= sizeFoto - 1 && y <= sizeFoto - 1) return true;
                return false;

            }

            //search position with positions mouse and know sizes
            public static int[] Start_Positions_notRealBox(int x, int y, int width, int sizeBox, int sizeFoto)
            {
                // convert the points to points on the chessboard image
                int[] positions = Convert_Position_Real(x, y, width, Convert.ToDouble(sizeFoto));
                // by dividing the position by the size of each box I find which box it is in
                int xBlock, yBlock;
                xBlock = positions[0] / sizeBox;
                yBlock = positions[1] / sizeBox;
                // because it is an integer and not a perfect division it may give a value greater than it should be
                if (xBlock >= 8)
                {
                    xBlock = 7;
                }
                // and then multiplying the box by the size of the box we find the starting position
                positions[0] = xBlock * sizeBox;
                positions[1] = yBlock * sizeBox;
                return positions;
            }


            // convert the position in the image to the position on the pictureBox chessBoard
            public static int[] Convert_Position_Fake(int x, int y, int width, int height, double fotoSize)
            {
                // pass the starting positions
                int[] positions = { x, y };

                // measure the size of the left space
                int emptyPixels = Math.Abs(width - height);
                double emptyPixelsEdges = emptyPixels / 2.0;

                // by dividing the height by the size of the image I find the number by which
                // multiply by the position in the image I will find the position in the picturebox that I want
                double makeSize = height / fotoSize;

                // take into account the gap you created on the left
                positions[0] = Convert.ToInt32((positions[0] * makeSize) + emptyPixelsEdges);
                positions[1] = Convert.ToInt32(positions[1] * makeSize);

                return positions;
            }

            // convert the position in the pictureBox chessBoard to the position on the image 
            public static int[] Convert_Position_Real(int x, int y, int height, double fotoSize)
            {
                // I pass the starting positions
                int[] positions = { x, y };

                // by dividing the size of the image by the height I find the number by which
                // if I multiply by the picturebox I will find the position in the image that I want
                double makeSize = fotoSize / height;

                positions[0] = Convert.ToInt32(positions[0] * makeSize);
                positions[1] = Convert.ToInt32(positions[1] * makeSize);


                return positions;

            }


        }










        // This class is used for painting on the boxes
        public class Draw
        {


            private Draw() { }

            // I draw on the box with which I will move the pawn
            // taking the initial box positions from the actual map and putting in the x y
            public static Bitmap Take_Pawn_On_Box(string pawn)
            {
                if (pawn == null) return null;

                else if (pawn[0] == 'w')
                {
                    switch (pawn)
                    {
                        case "wPawn":
                            return Properties.Resources.wPawn;
                        case "wRook":
                            return Properties.Resources.wRook;
                        case "wKnight":
                            return Properties.Resources.wKnight;
                        case "wBishop":
                            return Properties.Resources.wBishop;
                        case "wQueen":
                            return Properties.Resources.wQueen;
                        case "wKing":
                            return Properties.Resources.wKing;

                    }
                }
                else if ('b' == pawn[0])
                {
                    switch (pawn)
                    {
                        case "bPawn":
                            return Properties.Resources.bPawn;
                        case "bRook":
                            return Properties.Resources.bRook;
                        case "bKnight":
                            return Properties.Resources.bKnight;
                        case "bBishop":
                            return Properties.Resources.bBishop;
                        case "bQueen":
                            return Properties.Resources.bQueen;
                        case "bKing":
                            return Properties.Resources.bKing;
                    }
                }
                return null;

            }







            // color comparison
            public static bool Is_Pixel_Color_Box(Color pixelColor, Color color)
            {
                return pixelColor.R == color.R && pixelColor.G == color.G && pixelColor.B == color.B;
            }
            public static bool Is_Pixel_Color_Box(Color pixelColor, int R, int G, int B)
            {
                return pixelColor.R == R && pixelColor.G == G && pixelColor.B == B;
            }

            // clear the box from the pawn by painting on the real image the color of the box
            public static void Clean_Box(Bitmap Map, int x, int y, int sizeBox)
            {
                // the top left pixel is always the box color
                Color colorTake = Map.GetPixel(x, y);

                for (int i = y; i < sizeBox + y; i++)
                {
                    for (int j = x; j < sizeBox + x; j++)
                    {
                        Map.SetPixel(j, i, colorTake);
                    }
                }
            }


            // I draw on the picture box that it has the notRealBox
            // initial positions of the box are x y
            public static void draw_Chess_Box(Bitmap Map, Bitmap notRealBox, int x, int y)
            {

                // the top left pixel is always the box color
                Color colorTake = Map.GetPixel(x, y);
                // I set the positions to newXY to change them along the way
                int newX = x;
                int newY = y;

                //i check ever pixel in position notRealBox j,i and draw it in corect box from position x,y to x + 134, y + 134 
                //empty pixels
                for (int i = 0; i < notRealBox.Height; i++)
                {
                    for (int j = 0; j < notRealBox.Width; j++)
                    {
                        // I get the color spixel by pixel
                        Color color = notRealBox.GetPixel(j, i);
                        // I paint the background color on the pixels that are quite transparent
                        if (color.A < 240)
                        {
                            color = colorTake;
                        }
                        // here you draw the pixel according to the color given to it
                        Map.SetPixel(newX, newY, color);
                        // let's go to the left pixel
                        newX += 1;
                    }
                    // we went to the expensive bottom row on the left
                    newX = x;
                    newY += 1;
                }
            }
        }

    }
}


