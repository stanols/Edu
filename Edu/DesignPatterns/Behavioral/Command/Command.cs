namespace Edu.DesignPatterns.Behavioral.Command
{
	public static class Command
	{
		public static void Execute()
		{
			var invoker = new Invoker();
			invoker.SetOnStart(new SimpleCommand("Hello World!"));
			invoker.SetOnCancel(new ComplexCommand(new Receiver(), "Hello ", "World!"));

			invoker.Start();
			invoker.Cancel();
		}
	}
}
