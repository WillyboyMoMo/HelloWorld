using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            StartClockAsync(); // 啟動時鐘顯示功能
        }

        // 時鐘顯示的邏輯，更新時間每秒刷新一次
        private async void StartClockAsync()
        {
            while (true)
            {
                labTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                await Task.Delay(1000); // 每秒更新一次時間
            }
        }

        // 計數按鈕的邏輯，每次按下時重新開始計數
        private async void btnCount_Click(object sender, EventArgs e)
        {
            await counter.StartCountingAsync((count) =>
            {
                labCount.Text = count.ToString();
            });
        }
    }
}

