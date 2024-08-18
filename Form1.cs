using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handbags
{
    public partial class Handbags : Form
    {

        //Constants for minimum and maximum amount of rows
        const int MIN_SIZE = 2;
        const int MAX_SIZE = 10;


        public Handbags()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the click event method for the draw bags button. It takes the amount of rows entered by the user in the textbox
        /// and draws the specified amount of rows in the picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawBags_Click(object sender, EventArgs e)
        {
            //Get the number of rows the user has entered in the textbox and convert to an int.
            int numberOfRows;
            bool isValid = int.TryParse(textBoxHandbagRows.Text, out numberOfRows);

            //Check that user has entered a valid amount between 2 and 10, if not then throw an error message
            if (!isValid || numberOfRows < MIN_SIZE || numberOfRows > MAX_SIZE)
            {
                MessageBox.Show("Please enter a valid number between 2 and 10");
                pictureBox1.Invalidate();
                textBoxHandbagRows.Clear();
                textBoxHandbagRows.Focus();
                return;
            }

            else
            {
                //Create a graphics object
                Graphics graphics = pictureBox1.CreateGraphics();
                //Clear the picturebox
                graphics.Clear(pictureBox1.BackColor);

                //Declare variables for hand bag sizing
                int handBagSize = 20;
                int gapSize = 5;
                int startX = 10;
                int startY = 10;

                //2x for loops for both row and column
                for (int row = 1; row <= numberOfRows; row++)
                {
                    for (int column = 1; column <= 10; column++)
                    {
                        int x = startX + (column - 1) * (handBagSize + gapSize);
                        int y = startY + (row - 1) * (handBagSize + gapSize);

                        //Create color object
                        Color color = (column % 3 == 0) ? Color.Purple : Color.Red;

                        //Create brushes and use them to fill rectangles
                        using (Brush brush = new SolidBrush(color))
                        {
                            graphics.FillRectangle(brush, x, y, handBagSize, handBagSize);
                        }
                        using (Pen pen = new Pen(Color.Black))
                        {
                            graphics.DrawRectangle(pen, x, y, handBagSize, handBagSize);
                        }

                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            textBoxHandbagRows.Clear();
            textBoxHandbagRows.Focus();
        }
    }
}
