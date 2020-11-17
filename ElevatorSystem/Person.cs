using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ElevatorSystem
{
    class Person : PictureBox
    {

        public Person() {
            this.Image = Image.FromFile(@"E:\proga\c#\person.jpg");
            this.ClientSize = new Size(34, 60);
            this.Click += new System.EventHandler(this.personClick);
        }

        private void personClick(object sender, EventArgs e) {
            PersonInformation personInformation = new PersonInformation();
            personInformation.ShowDialog();
        }
    }
}
