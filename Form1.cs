namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Brush brush;
                brush = Brushes.LemonChiffon;
                Graphics graphics = CreateGraphics();
                graphics.FillPie(brush, 20, 20, 40, 40, 30, 20);
                graphics.Dispose();
                //brush = Brushes.DarkViolet;
                brush = Brushes.Red;
                Graphics graphics1 = CreateGraphics();
                graphics1.FillPie(brush, 60, 60, 100, 100, 20, 20);
                graphics1.Dispose();
 
        }
    }
}