namespace SquaresRemover
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private Bitmap original;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            original = new Bitmap(openFileDialog.FileName);
            originalPicture.BackgroundImage = original;
            var p1 = new SquaresCleaner(original).Clean(SquaresCleaner.CleanMode.NotBlack);
            var p2 = new SquaresCleaner(p1).Clean(SquaresCleaner.CleanMode.Hue);

            processedPicture.BackgroundImage = p1;
            processed2Picture.BackgroundImage = p2;
        }
    }
}
