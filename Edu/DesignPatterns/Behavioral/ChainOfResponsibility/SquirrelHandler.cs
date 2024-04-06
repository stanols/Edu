namespace Edu.DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class SquirrelHandler :  BaseHandler
    {
        public SquirrelHandler() : base()
        {
        }

        public override object Handle(object request)
        {
            if (!(request is string))
            {
                return base.Handle(request);
            }

            var requestString = request as string;

            if (requestString == "Nut")
            {
                return $"I am Squirrel, I eat {requestString}";
            }

            return base.Handle(request);
        }
    }
}
