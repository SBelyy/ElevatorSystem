using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    class Floor : PictureBox
    {
        public Floor() {
            this.Image = Image.FromFile(@"E:\proga\c#\floor.jpg");
            this.ClientSize = new Size(434, 80);
        }

    }
}
