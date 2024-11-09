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
            CancelCounting();

            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            for (int i = 0; i <= maxCount; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                onCountUpdated?.Invoke(i);

                await Task.Delay(500);
            }
        }

        public void CancelCounting()
        {
            cancellationTokenSource?.Cancel();
        }
    }
}
