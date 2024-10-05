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
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            StartClock(); // 啟動時鐘顯示功能
        }

        private void btnCount_Click(object sender, EventArgs e)
        {

            Task.Run(() =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        labCount.Text = i.ToString(); // 更新 labCount 顯示計數
                    }));
                    Thread.Sleep(500); // 每次增加1的時間間隔為500毫秒
                }
            });
        }
        private void StartClock()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 每秒更新
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"); // 更新 labTime 顯示當前時間
        }
    }
}
