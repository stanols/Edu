using System;

namespace Edu.DesignPatterns.Behavioral.Command
{
	public class Receiver : IReceiver
	{
		public void DoSomething(string something)
		{
			Console.WriteLine(something);
		}

		public void DoSomethingElse(string somethingElse)
		{
			Console.WriteLine(somethingElse);
		}
	}
}
