using System;

namespace CodeKatas.CSharp.Singleton
{
	/// <summary>
	/// Singleton with lazy implementation.
	/// </summary>
	public sealed class SignletonLazy
	{
		private static readonly Lazy<SignletonLazy> _instance = new Lazy<SignletonLazy>(() => new SignletonLazy());

		public static SignletonLazy Instance => _instance.Value;

		private SignletonLazy()
		{
		}
	}

	/// <summary>
	/// Singleton with double check locking implementation.
	/// </summary>
	public sealed class SingletonDoubleCheckLocking
	{
		private static volatile SingletonDoubleCheckLocking _instance;

		private static readonly object _syncLock = new object();

		public static SingletonDoubleCheckLocking Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_syncLock)
					{
						if (_instance == null)
						{
							_instance = new SingletonDoubleCheckLocking();
						}
					}
				}

				return _instance;
			}
		}

		private SingletonDoubleCheckLocking()
		{
		}
	}

	/// <summary>
	/// Singleton with static implementations.
	/// </summary>
	public sealed class SingletonStatic
	{
		private static readonly SingletonStatic _instance = new SingletonStatic();

		public static SingletonStatic Instance => _instance;

		static SingletonStatic()
		{
		}

		private SingletonStatic()
		{
		}
	}
}
