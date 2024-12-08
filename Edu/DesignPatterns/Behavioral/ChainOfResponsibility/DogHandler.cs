namespace Edu.DesignPatterns.Behavioral.ChainOfResponsibility
{
	public class DogHandler : BaseHandler
	{
		public DogHandler() : base()
		{
		}

		public override object Handle(object request)
		{
			if (!(request is string))
			{
				return base.Handle(request);
			}

			var requestString = request as string;

			if (requestString == "MeatBall")
			{
				return $"I am dog, I eat {requestString}";
			}

			return base.Handle(request);
		}
	}
}
