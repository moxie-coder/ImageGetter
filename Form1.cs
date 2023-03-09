using System.Windows.Forms;

namespace ImageGetter
{
    public partial class ImageGetter : Form
    {
        public ImageGetter()
        {
            InitializeComponent();
        }

        Image? daImage = null;

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "C:/";
                ofd.Filter = "Picture files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*";
                ofd.FilterIndex = 0;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    daImage = Image.FromFile(ofd.FileName);

                    pictureBox1.Image = daImage;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (daImage != null)
                    daImage?.Dispose();
            }

            base.Dispose(disposing);
        }*/
    }
}