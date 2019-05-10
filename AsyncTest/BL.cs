using System;
using System.Threading;
using System.Threading.Tasks;

namespace DF.Test.AsyncTest
{
    public class BL
    {
        private string _alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private int _alphaCounter = 1;
        private int _counter = 1;

        public async Task<string> DoSomethingsNoAwaitAsync()
        {
            string response = String.Empty;

            while (_counter <= 10)
            {
                // Awaited. So everything stops until this call returns
                await ReturnInput(_counter);

                // Since this line is not awaited, execution continues in the while block and the work inside NextLetter continues in the background.
                NextLetter(_counter);

                _counter++;
            }

            return response;
        }

        //public async Task<int> DoSomethingAsync()
        //{
        //    return await ReturnInput(2);
        //}

        private async Task ReturnInput(int input)
        {
            await Task.Delay(1000);
            Console.Write(input.ToString());
        }

        private async Task NextLetter(int index)
        {
            string response = _alpha[index].ToString();
            await Task.Delay(5000);
            Console.Write(response);
        }
    }
}