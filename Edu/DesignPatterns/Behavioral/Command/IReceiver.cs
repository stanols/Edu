namespace Edu.DesignPatterns.Behavioral.Command
{
    public interface IReceiver
    {
        void DoSomething(string something);

        void DoSomethingElse(string somethingElse);
    }
}
