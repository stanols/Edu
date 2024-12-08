using System;

namespace Edu.DesignPatterns.Behavioral.Command
{
	public class ComplexCommand : ICommand
	{
		private readonly IReceiver _receiver;
		private readonly string _something;
		private readonly string _somethingElse;

		public ComplexCommand(
			IReceiver receiver,
			string something,
			string somethingElse)
		{
			_receiver = receiver;
			_something = something;
			_somethingElse = somethingElse;
		}

		public void Execute()
		{
			Console.WriteLine("Complex Command: I can run receiver.");

			_receiver.DoSomething(_something);
			_receiver.DoSomethingElse(_somethingElse);
		}
	}
}
