namespace Edu.DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class MonkeyHandler : BaseHandler
    {
        public MonkeyHandler() : base()
        {
        }

        public override object Handle(object request)
        {
            if (!(request is string))
            {
                return base.Handle(request);
            }

            var requestString = request as string;

            if (requestString == "Banana")
            {
                return $"I am Monkey, I eat {requestString}";
            }

            return base.Handle(request);
        }
    }
}
