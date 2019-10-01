using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace MJC_WindowsUI
{
    class MyWindow : Form
    {
        Random random;
        Color randomColor;

        public MyWindow()
        {
            this.random = new Random();
            this.BackColor = Color.SteelBlue;
            this.Size = new Size(300, 300);

            for (int y = 0; y < 10; y++)
            {
                for(int x = 0; x < 10; x++)
                {
                    switch (random.Next(0, 10))
                    {
                        case 0:
                            randomColor = Color.CornflowerBlue;
                            break;
                        case 1:
                            randomColor = Color.DarkRed;
                            break;
                        case 2:
                            randomColor = Color.ForestGreen;
                            break;
                        case 3:
                            randomColor = Color.Yellow;
                            break;
                        case 4:
                            randomColor = Color.Purple;
                            break;
                        case 5:
                            randomColor = Color.Orange;
                            break;
                        case 6:
                            randomColor = Color.Aqua;
                            break;
                        case 7:
                            randomColor = Color.SaddleBrown;
                            break;
                        case 8:
                            randomColor = Color.Pink;
                            break;
                        case 9:
                            randomColor = Color.Gray;
                            break;
                        default:
                            randomColor = Color.White;
                            break;
                    }

                    Button button = new Button();
                    this.Controls.Add(button);
                    button.Location = new Point((x+1) * 22, (y+1) * 22);
                    button.Size = new Size(20, 20);
                    button.BackColor = randomColor;
                    button.MouseEnter += ButtonClickHandler;
                }
            }
        }

        void ButtonClickHandler(object sender, EventArgs args)
        {
            ((Button)sender).BackColor = Color.Black;
        }
    }
}
