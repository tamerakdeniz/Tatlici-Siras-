using System.Collections;
using System.Xml.Serialization;

namespace tatlicisirasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack sira = new Stack();

        private int sonMusteriNoGetir()
        {
            if (sira.Count == 0)
            {
                return listBox2.Items.Count + 1;
            }
            return sira.Count + 1;
        }

        private int siradakiMusteriGetir()
        {
            Stack gecici = new Stack();
            while (sira.Count != 1)
            {
                gecici.Push(sira.Pop());
            }
            int siradakiMusteri = Convert.ToInt32(sira.Pop());
            while (gecici.Count != 0)
            {
                sira.Push(gecici.Pop());
            }
            listBox1.DataSource = sira.ToArray();
            return siradakiMusteri;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSirayaGir_Click(object sender, EventArgs e)
        {
            int nextSira = sonMusteriNoGetir();
            txtSiraNo.Text = $"Sıra numaranız -> {nextSira}";
            MessageBox.Show($"Sıra numaranız -> {nextSira}");
            sira.Push(nextSira);
            listBox1.DataSource = sira.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var siradakiMusteri = siradakiMusteriGetir();
            listBox2.Items.Add((siradakiMusteri)+ " -> Numaralı Müşteri");
            MessageBox.Show((siradakiMusteri) + " -> Numaralı Müşteri");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}