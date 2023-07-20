namespace SayiTahminUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int deneme2 = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> liste = new List<string>();
            liste.Add(textBox1.Text);
            liste.Add(textBox2.Text);
            label3.Text = ("Sayı Tahmin Oyununa\nHoşgeldin " + liste[0] + " " + liste[1]);
            label3.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new();
            veriler veriler = new();
            veriler.sayi = random.Next(1, 10);
            string tahminSayi = textBox3.Text;
            veriler.tahmin = Convert.ToInt32(tahminSayi);
            label8.Text = Convert.ToString(veriler.sayi);
            if (veriler.tahmin < 1 || veriler.tahmin > 10)
            {
                MessageBox.Show("Lütfen 1 ve 10 arasında bir sayı giriniz!!");
            }

            if (veriler.tahmin == veriler.sayi)
            {
                label7.Text = "Doğru Tahmin";
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                deneme2++;
                MessageBox.Show("Tebrikler Bildiniz\n" + deneme2 + ". deneme");
                deneme2 = -1;
            }
            else
            {
                label7.Text = "Yanlış Tahmin";
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
            deneme2++;
            label6.Text = Convert.ToString(deneme2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}