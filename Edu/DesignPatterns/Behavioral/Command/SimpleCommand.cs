using System;

namespace Edu.DesignPatterns.Behavioral.Command
{
    public class SimpleCommand: ICommand
    {
        private readonly string _payload;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"Simple Command: I have {_payload}");
        }
    }
}
