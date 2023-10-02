namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool MyFunc(int a, out string b)
        {
            b = a.ToString();
            return true;
        }
    }
}