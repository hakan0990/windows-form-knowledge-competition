namespace BilgiYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, doğru = 0, yanlış = 0;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            soruNo++;
            lblSoruno.Text = soruNo.ToString();


            
            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan Edildi";

                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";

            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangisi İl Ege Bölgemizde Bulunmaz";

                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";



            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar Hangi Yazara Aittir";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Reşat Nuri Güntekin";
                label4.Text = "Sait Faik";
                btnSonraki.Text = "Sonuçlar";
            }

            if (soruNo == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru" + doğru +"\n" +"Yanlış : "+ yanlış);

            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label5.Text = btnA.Text;
            if (label4 == label5)
            {
                doğru++;
                lblDoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlış++;
                lblYanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled= true;
            label5.Text = btnB.Text;

            if (label4.Text == label5.Text)
            {
                doğru++;
                lblDoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlış--;
                lblYanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label5.Text = btnC.Text;
            if (label4 == label5)
            {
                doğru++;
                lblDoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlış++;
                lblYanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label5.Text = btnD.Text;
            if (label4 == label5)
            {
                doğru++;
                lblDoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlış++;
                lblYanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;

            }
        }
    }
}
