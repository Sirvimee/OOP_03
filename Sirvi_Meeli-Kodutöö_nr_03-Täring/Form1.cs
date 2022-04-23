namespace Sirvi_Meeli_Kodutöö_nr_03_Täring
{
    
    public partial class Form1 : Form
    {
        int a2; //juku arv1
        int a3; //juku arv2
        int b2; //peetri arv1
        int b3; //peetri arv2
        int juku_punktid;
        int peetri_punktid;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //algus
            juku_nr1.Text = "";
            juku_nr2.Text = "";
            txt_punktid_1.Text = "";
            peeter_nr1.Text = "";
            peeter_nr2.Text = "";
            txt_punktid_2.Text = "";
            txt_tulemus.Text = "";

            btn_juku.Enabled = false;
            btn_peeter.Enabled = false;
            btn_alusta.Enabled = true;
        }

        private void btn_alusta_Click(object sender, EventArgs e)
        {
            //tühjenda
            juku_nr1.Text = "";
            juku_nr2.Text = "";
            txt_punktid_1.Text = "";
            peeter_nr1.Text = "";
            peeter_nr2.Text = "";
            txt_punktid_2.Text = "";
            txt_tulemus.Text = "";

            btn_juku.Enabled = true;
            btn_peeter.Enabled = false;
            btn_alusta.Enabled = true;
        }

        private void btn_juku_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            a2 = rand.Next(1, 6);
            a3 = rand.Next(1, 6);
            juku_nr1.Text = Convert.ToString(a2);
            juku_nr2.Text = Convert.ToString(a3);
            juku_punktid = a2 + a3;
            txt_punktid_1.Text = Convert.ToString(juku_punktid);

            btn_juku.Enabled = false;
            btn_peeter.Enabled = true;
            btn_alusta.Enabled = false;
        }

        private void btn_peeter_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            b2 = rand.Next(1, 6);
            b3 = rand.Next(1, 6);
            peeter_nr1.Text = Convert.ToString(b2);
            peeter_nr2.Text = Convert.ToString(b3);
            peetri_punktid = b2 + b3;
            txt_punktid_2.Text = Convert.ToString(peetri_punktid);

            if (juku_punktid < peetri_punktid)
            {
                txt_tulemus.Text = "Võitis Peeter";
            }
            else if (juku_punktid > peetri_punktid)
            {
                txt_tulemus.Text = "Võitis Juku";
            }
            else
            {
                txt_tulemus.Text = "Viik";
            }

            btn_juku.Enabled = false;
            btn_peeter.Enabled = false;
            btn_alusta.Enabled = true;
        }
    }
}