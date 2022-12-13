namespace alışveriş_indirim_tutar_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox1.Text);

            if (kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label3.Text = toplam + " TL ";
            }
            if(kitapadet>=21&& kitapadet<=40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label3.Text = toplam + " TL ";

            }
            if (kitapadet >= 41)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label3.Text = toplam + " TL ";
            }



        }
    }
}