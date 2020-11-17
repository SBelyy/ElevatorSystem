using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    public partial class MainForm : Form
    {

        private bool workSystem;
        private DateTime dateTime;

        private StatusBar statusBar1 = new StatusBar();
        private StatusBarPanel panel1 = new StatusBarPanel();
        private StatusBarPanel panel2 = new StatusBarPanel();

        private List<Floor> floors = new List<Floor>();
        private List<Person> persons = new List<Person>();
        private List<Lift> lifts = new List<Lift>();

        private int numberOfPerson;
        private int numberOfFloor;
        private int positionX;
        private int positionY;

        public DataInput form;

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            createStatusBar();
            workSystem = false;
            dateTime = new DateTime(0, 0);
            positionX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 3;
            positionY = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 155;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!workSystem)
            {
                form = new DataInput();
                form.Tag = this;
                form.ShowDialog();
                timer1.Enabled = true;
            }
            else 
            {
                workSystem = false;
                timer1.Enabled = false;
                dateTime = new DateTime(0, 0);
                ExitData exitData = new ExitData();
                exitData.ShowDialog();
                buttonStart.BackColor = Color.FromArgb(128, 255, 128);
                buttonStart.Text = "Запустить систему";
                stopSystem();
            }
        }

        private void stopSystem() {
            foreach (Lift item in lifts)
            {
                item.Dispose();
            }
            foreach (Person item in persons)
            {
                item.Dispose();
            }
            foreach (Floor item in floors)
            {
                item.Dispose();
            }
            lifts.Clear();
            persons.Clear();
            floors.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreatePerson createPerson = new CreatePerson();
            createPerson.ShowDialog();
        }

        public void createBuild() {

            workSystem = true;
            buttonStart.BackColor = Color.Red;
            buttonStart.Text = "Остановить систему";

            createPersonInBuild();
            createLiftInBuild();
            createFloorInBuild();
           
        }

        private void createPersonInBuild() {
            Person person = new Person();
            person.Location = new Point(positionX + 70, positionY + 12);
            person.Show();
            this.Controls.Add(person);
            persons.Add(person);
        }

        private void createLiftInBuild() {
            Lift lift = new Lift(numberOfFloor);
            lift.Location = new Point(positionX + 320, positionY + 5);
            lift.Show();
            this.Controls.Add(lift);
            lifts.Add(lift);
        }

        private void createFloorInBuild()
        {
            if (numberOfFloor > 9)
            {
                positionY = 135;
                for (int i = 0; i < numberOfFloor; i++)
                {
                    Floor floor = new Floor();
                    floor.Location = new Point(positionX, positionY);
                    floor.Show();
                    this.Controls.Add(floor);
                    positionY += 80;
                    floors.Add(floor);
                }
            }
            else
            {
                for (int i = 0; i < numberOfFloor; i++)
                {
                    Floor floor = new Floor();
                    floor.Location = new Point(positionX, positionY);
                    floor.Show();
                    this.Controls.Add(floor);
                    positionY -= 80;
                    floors.Add(floor);
                }
            }
        }

        private void createStatusBar() {
            panel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            panel1.Text = "Время раоты сиситемы: 00:00:00";
            panel1.AutoSize = StatusBarPanelAutoSize.Spring;

            panel2.BorderStyle = StatusBarPanelBorderStyle.Raised;
            panel2.Text = "Количество перевезённых человек: 1";
            panel2.AutoSize = StatusBarPanelAutoSize.Contents;

            statusBar1.ShowPanels = true;
		
            statusBar1.Panels.Add(panel1);
            statusBar1.Panels.Add(panel2);

            this.Controls.Add(statusBar1);
        }

        public void setNumberOfPerson(int num) {
            numberOfPerson = num;
        }

        public void setNumberOfFloor(int num){
            numberOfFloor = num;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (workSystem) {
                dateTime = dateTime.AddSeconds(1);
                panel1.Text = "Время работы системы: " + dateTime.ToString("HH:mm:ss");
            }
        }
    }
}
