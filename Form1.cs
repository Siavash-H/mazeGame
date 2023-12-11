using System.Timers;

namespace mazeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            move2Start();
        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void finshLable_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("yeeey, you won!!!", "YesS");
            System.Threading.Thread.Sleep(2000);
            Close();
        }

        private void move2Start()
        {

            Point startPoint = panel1.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);

        }

    }
}
