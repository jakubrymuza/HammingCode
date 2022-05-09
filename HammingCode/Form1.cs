namespace HammingCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label8.Visible = true;
            bool[] vs = new bool[32];
            for(int i = 0; i < vs.Length; i++)
            {
                vs[i] = Random.Shared.Next(0, 2) == 0;
            }
            label21.Text = vs[0] == true ? "1" : "0";
            label22.Text = vs[1] == true ? "1" : "0";
            label23.Text = vs[3] == true ? "1" : "0";
            label24.Text = vs[7] == true ? "1" : "0";
            label25.Text = vs[15] == true ? "1" : "0";
            label26.Text = vs[31] == true ? "1" : "0";
            string res = "";
            for(int i = 0; i < vs.Length; i++)
            {
                res += vs[i] == true ? "1" : "0";
            }
            label20.Text = res;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}