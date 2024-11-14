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
                brush = Brushes.Black;
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(brush, 0, 0, 20, 20);
                graphics.Dispose();
                //brush = Brushes.DarkViolet;
                brush = Brushes.Red;
                Graphics graphics1 = CreateGraphics();
                graphics1.FillPie(brush, 60, 60, 100, 100, 20, 20);
                graphics1.Dispose();
 
        }
    }
}