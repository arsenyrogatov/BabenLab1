namespace BabenLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileStatus_label.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                int w = bitmap.Size.Width, h = bitmap.Size.Height;
                Bitmap r = new Bitmap(w,h), g = new Bitmap(w, h), b = new Bitmap(w, h);

                for (int i = 0; i < bitmap.Height; i++)
                {
                    for(int j = 0; j < bitmap.Width; j++)
                    {
                        var pixel = bitmap.GetPixel(i, j);
                        r.SetPixel(i, j, Color.FromArgb(pixel.R, 0,0));
                        g.SetPixel(i, j, Color.FromArgb(0, pixel.G, 0));
                        b.SetPixel(i, j, Color.FromArgb(0, 0, pixel.B));
                    }
                }
                r_pictureBox.Image = r;
                g_pictureBox.Image =g;
                b_pictureBox.Image =b;
            }
            else
            {
                fileStatus_label.Text = "Файл не выбран";
            }
        }

    }
}