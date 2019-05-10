using System;
using System.Threading;
using System.Threading.Tasks;

namespace DF.Test.AsyncTest
{
    public class BL
    {
        private string _alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public async Task<string> DoSomethingsNoAwaitAsync()
        {
            string response = String.Empty;
            
            for (int i = 0; i <= 10; i++)
            {
                // Awaited. So everything stops until this call returns
                await ReturnInput(i);

                // Since this line is not awaited, execution continues in the while block and the work inside NextLetter continues in the background.
                NextLetter(i);
            }

            return response;
        }

        //public async Task<int> DoSomethingAsync()
        //{
        //    return await ReturnInput(2);
        //}


        // Waits for 1 second, then writes input
        private async Task ReturnInput(int input)
        {
            await Task.Delay(1000);
            Console.Write(input.ToString());
        }

        // Finds letter associated with index, waits 5 seconds, then writes to Console
        private async Task NextLetter(int index)
        {
            string response = _alpha[index].ToString();
            await Task.Delay(5000);
            Console.Write(response);
        }
    }
}