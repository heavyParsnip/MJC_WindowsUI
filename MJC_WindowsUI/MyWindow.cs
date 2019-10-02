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
        //Random field
        Random random;

        public MyWindow()
        {
            //Initialize window parameters
            this.random = new Random();
            this.BackColor = Color.SteelBlue;
            this.Size = new Size(300, 300);

            //Generate buttons
            for (int y = 0; y < 10; y++)
            {
                for(int x = 0; x < 10; x++)
                {
                    Button button = new Button();
                    this.Controls.Add(button);
                    button.Location = new Point((x+1) * 22, (y+1) * 22);
                    button.Size = new Size(20, 20);
                    //Generate a random color
                    button.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                    button.MouseEnter += ButtonClickHandler;
                }
            }
        }

        //Button event handler
        void ButtonClickHandler(object sender, EventArgs args)
        {
            ((Button)sender).BackColor = Color.Black;
        }
    }
}
