using System;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Counter
    {
        private CancellationTokenSource cancellationTokenSource;

        public async Task StartCountingAsync(Action<int> onCountUpdated, int maxCount = 10)
        {
            // 如果已經有計數進行中，先取消
            CancelCounting();

            // 為新計數任務創建 CancellationTokenSource
            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            // 開始計數，從0數到maxCount
            for (int i = 0; i <= maxCount; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return; 
                }

                // 更新當前計數
                onCountUpdated?.Invoke(i);

                await Task.Delay(500); // 每0.5秒更新一次數字
            }
        }

        // 取消當前的計數
        public void CancelCounting()
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
            }
        }
    }
}
