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
        private CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
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
            // 如果有正在運行的計數任務，先取消它
            if (cancellationTokenSource != null)
            {
            cancellationTokenSource.Cancel();
            await Task.Delay(100); // 確保任務已經取消，防止衝突
            }

            // 為新計數任務創建一個新的 CancellationTokenSource
            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;
                
            // 開始計數，從0數到10，每次延遲0.5秒
            for (int i = 0; i <= 10; i++)
                {
                if (token.IsCancellationRequested)
                {
                     return; // 如果收到取消請求，停止計數
                }

                 labCount.Text = i.ToString(); // 更新顯示的數字
                 await Task.Delay(500); // 每0.5秒更新一次數字
                }
            
            
        }
    }
}

