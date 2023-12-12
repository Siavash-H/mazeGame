using System.Timers;

namespace mazeGame
{
    public partial class Form1 : Form
        
    {
        System.Media.SoundPlayer StartUpSound = new System.Media.SoundPlayer(@".\sounds\ding.wav");
        System.Media.SoundPlayer WallSound = new System.Media.SoundPlayer(@".\sounds\chord.wav");
        System.Media.SoundPlayer FinshSound = new System.Media.SoundPlayer(@".\sounds\chimes.wav");
        public Form1()
        {
            InitializeComponent();
            StartUpSound.Play();
            move2Start();
        }

        private void finshLable_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("yeeey, you won!!!", "YesS");
            System.Threading.Thread.Sleep(500);
            FinshSound.Play();
            Close();
        }

        private void move2Start()
        {

            Point startPoint = panel1.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);

        }

        private void mouseEnterWall(object sender, EventArgs e)
        {
            WallSound.Play();
            System.Threading.Thread.Sleep(1000);
            move2Start();
        }

    }
}
