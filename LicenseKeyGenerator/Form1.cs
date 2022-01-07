namespace LicenseKeyGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(frmGenerate frm = new frmGenerate())
            {
frm.ShowDialog();
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            private void Form1_Load(object sender, EventArgs e)
            {
                using (frmRegistration frm = new frmRegistration())
                {
                }
    }
}

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (frmAbout frm = new frmAbout())
            {
                frm.ShowDialog();
            }
        }