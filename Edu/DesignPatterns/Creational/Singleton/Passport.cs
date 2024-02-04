using System;

namespace Edu.DesignPatterns.Creational.Singleton
{
	public sealed class Passport
	{
		private static Passport _instance;
		private static readonly object _idLock = new object();
		private Guid _guid = new Guid();
		public Guid Guid { get { return _guid; } }

		//thread safe
		public static Passport Instance
		{
			get
			{
				lock (_idLock)
				{
					if (_instance == null)
					{
						_instance = new Passport();
					}

					return _instance;
				}
			}
		}

		private Passport()
		{
		}

		//thread safe
		public static Passport GetInstance()
		{
			lock(_idLock)
			{
				if (_instance == null)
				{
					_instance = new Passport();
				}

				return _instance;
			}
		}

		public bool Validate(Guid guid)
		{
			return guid == _guid;
		}
	}
}
