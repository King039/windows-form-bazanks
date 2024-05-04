namespace windows_form_bazanks
{
    public partial class Form1 : Form
    {
        private Convector convector;
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Generator generation = new Generator(int.Parse(tbFrom.Text), int.Parse(tbUntil.Text));
                lbResalt.Text = generation.getNumber().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxLong_SelectedIndexChanged(object sender, EventArgs e)
        {
            convector = new Convector(double.Parse(tbNumber.Text));
            switch (cbxLong.SelectedIndex)
            {
                case 0: lResalt.Text = convector.toSm().ToString("F5") + "см"; break;
                case 1: lResalt.Text = convector.toDm().ToString("F5") + "дм"; break;
                case 2: lResalt.Text = convector.toMetr().ToString("F5") + "м"; break;
                case 3: lResalt.Text = convector.toKm().ToString("F5") + "км"; break;
            }
        }

        private void cbxTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            convector = new Convector(double.Parse(tbNumber.Text));
            switch (cbxTemp.SelectedIndex)
            {
                case 0: lResalt.Text = convector.toKelvin().ToString("F5") + "кельвин"; break;
                case 1: lResalt.Text = convector.toFarengait().ToString("F5") + "фаренгейт"; break;
            }
        }

        private void cbxPressure_SelectedIndexChanged(object sender, EventArgs e)
        {
            convector = new Convector(double.Parse(tbNumber.Text));
            switch (cbxPressure.SelectedIndex)
            {
                case 0: lResalt.Text = convector.toMmRtSt.ToString("F5") + ""
            }
        }
    }
}
//доделать   
