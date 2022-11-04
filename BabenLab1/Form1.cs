namespace BabenLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_button_Click(object sender, EventArgs e) //При нажатии на кнопку "выбрать файл"
        {
            //Картинка с расширением .BMP лежит в папке с проектом
            if (openFileDialog.ShowDialog() == DialogResult.OK) //Если выбрана правильная картинка 
            {
                fileStatus_label.Text = System.IO.Path.GetFileName(openFileDialog.FileName); //Выводим имя файла
                Bitmap bitmap = new Bitmap(openFileDialog.FileName); //Считываем картинку
                int w = bitmap.Size.Width, h = bitmap.Size.Height; //Получаем ширину и высоту
                Bitmap r = new Bitmap(w, h), g = new Bitmap(w, h), b = new Bitmap(w, h); //Создаем R G B картинки

                for (int i = 0; i < bitmap.Height; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        var pixel = bitmap.GetPixel(i, j); //получаем каждый пиксель исходный картинки
                        r.SetPixel(i, j, Color.FromArgb(pixel.R, 0, 0)); //в R записываем только красный компонент 
                        g.SetPixel(i, j, Color.FromArgb(0, pixel.G, 0)); //в G зеленый
                        b.SetPixel(i, j, Color.FromArgb(0, 0, pixel.B)); //в B синий
                    }
                }
                r_pictureBox.Image = r; //выводим на экран
                g_pictureBox.Image = g;
                b_pictureBox.Image = b;
            }
            else //если картинка не выбрана
            {
                fileStatus_label.Text = "Файл не выбран";
            }
        }

    }
}