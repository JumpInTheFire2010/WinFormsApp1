namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Brush? brush;
        //readonly object locker = new();
        Semaphore semaphore = new Semaphore(1,1);
        public void Printer1()
        {
            semaphore.WaitOne();
                brush = Brushes.LemonChiffon;
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(brush, 0, 0, 200, 200);
                graphics.Dispose();
            semaphore.Release();
                
        }
        public void Printer2()
        {
            semaphore.WaitOne();
                //mre.Reset();
                brush = Brushes.DarkViolet;
                Graphics graphics = CreateGraphics();
                graphics.FillRectangle(brush, 200, 200, 200, 200);
                graphics.Dispose();
            semaphore.Release();

        }
        Mutex mutex = new Mutex(false);
        public void Ch()
        { 
            for(int i = 1;i<6;i++)
            {
                if (i % 2 != 0)
                {
                    mutex.WaitOne(); 
                    
                }
                textBox1.Invoke(() => textBox1.Text += i.ToString());
                if (i % 2==0 || i==5)
                {
                    mutex.ReleaseMutex();
                    Thread.Sleep(1);
                }               
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new(Printer1);
            thread1.Name = "Thread 1";
            Thread thread2 = new(Printer2);
            thread2.Name = "Thread 2";
            thread1.Start();
            thread2.Start();
        }
    }
}