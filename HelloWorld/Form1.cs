using HelloWorld;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        private Counter counters;

        public Form1()
        {
            InitializeComponent();
            counters = new Counter();
            StartClockAsync();
        }

        private async void StartClockAsync()
        {
            while (true)
            {
                labTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                await Task.Delay(1000);
            }
        }

        private async void btnCount_Click(object sender, EventArgs e)
        {
            await counters.StartCountingAsync((count) =>
            {
                labCount.Text = count.ToString();
            });
        }
    }
}
