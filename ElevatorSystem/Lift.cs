using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    class Lift : PictureBox
    {
        private LiftInformation liftInfo;
        private int countButtons;
        private int positionX = 95;
        private int positionY = 40;

        public Lift(int countButtons) {
            this.Image = Image.FromFile(@"E:\proga\c#\lift.jpg");
            this.ClientSize = new Size(65, 70);
            liftInfo = new LiftInformation();

            this.countButtons = countButtons;
            for (int i = 0; i < countButtons; i++) {
                Button newbutton = new Button();
                newbutton.Text = "Этаж " + (i + 1);
                newbutton.Width = 128;
                newbutton.Height = 60;
                newbutton.Location = new Point(positionX, positionY);
                liftInfo.Controls.Add(newbutton);
                positionY += 62;
            }

            this.Click += new System.EventHandler(this.liftClick);

        }
        private void liftClick(object sender, EventArgs e)
        {
            liftInfo.ShowDialog();
        }

    }
}
