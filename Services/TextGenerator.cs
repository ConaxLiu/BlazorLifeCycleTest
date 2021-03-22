using System;
using System.Threading.Tasks;

namespace BlazorLifeCycleTest.Services
{
    public class TextGenerator
    {
        public async Task<string> BuildFullName(string firstName, string middleName, string lastName)
        {
            // Delay between 1 to 10 seconds
            Random rnd = new Random();
            int seconds = rnd.Next(1, 10) * 1000;
            await Task.Delay(seconds);
            
            string text = await Task.Run(() => GenFullName(firstName, middleName, lastName));
            return text;
        }

        private string GenFullName(string firstName, string middleName, string lastName)
        {
            return firstName + " " + middleName + " " + lastName;
        }
    }
}
