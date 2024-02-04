namespace Edu.DesignPatterns.Creational.Singleton
{
	public sealed class Government
	{
		private static Government _instance;
		private static double _taxes = 0;

		public double Taxes
		{
			get
			{
				return _taxes;
			}
		}

		//not thread safe
		public static Government Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new Government();
				}

				return _instance;
			}
		}

		private Government()
		{
		}

		//not thread safe
		public static Government GetInstance()
		{
			if (_instance == null)
			{
				_instance = new Government();
			}

			return _instance;
		}

		public void PayTaxes(double amount)
		{
			_taxes += amount;
		}
	}
}
