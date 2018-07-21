using System;

namespace CodeKatas.CSharp.Disposable
{
	/// <summary>
	/// Example of disposing pattern.
	/// </summary>
	public class DisposableEx : IDisposable
	{
		private bool _alreadyDisposed;

		// Destructor when needed
		//~DisposableEx()
		//{
		//	Dispose(false);
		//}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (_alreadyDisposed)
				return;

			if (disposing)
			{
				// free managed resources
			}

			// free unmanaged resources

			_alreadyDisposed = true;
		}

		public void DoSomething()
		{
			if (_alreadyDisposed)
				throw new ObjectDisposedException("Object already disposed!");
		}
	}
}
