namespace Airlines_Company
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your flight details were saved successfully!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label4.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
