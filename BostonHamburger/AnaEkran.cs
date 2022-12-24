namespace BostonHamburger
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
            IsMdiContainer = true;  //Bu form, açýlan formlarý içerisinde barýndýracak.
        }

        public void PencereyiGoster(Form acilacakForm)
        {
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if(form.Text==acilacakForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                acilacakForm.MdiParent = this;
                acilacakForm.Show();
            }
        }
        private void tsmiSiparisOlustur_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new SiparisYonetimi());
        }
        private void tsmiSiparisBilgileri_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new SiparisGoruntuleme());
        }

        private void tsmiMenuEkle_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new MenuYonetimi());
        }

        private void tsmiEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new EkstraMalzemeYonetimi());
        }
    }
}