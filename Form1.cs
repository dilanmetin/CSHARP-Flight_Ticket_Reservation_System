namespace Uçak_Bilet_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Kalkış ve Varış rotası aynı olamaz!");
            }
            else
            {
                listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + " Yolcu Bilgileri ~ Ad Soyad: " + textBox1.Text + " Yolcu Tc: " + maskedTextBox2.Text + " Yolcu Telefon: " + maskedTextBox3.Text);
                MessageBox.Show("Yolcu kaydı yapıldı");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lokasyon = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = lokasyon.ToString();
        }

        
    }
}