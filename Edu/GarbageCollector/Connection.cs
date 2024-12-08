using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Edu.GarbageCollector
{
	public class Connection : IDisposable
	{
		private bool _disposedValue;

		[DllImport("kernel32.dll", SetLastError = true)]
		static extern SafeFileHandle CreateFile(
			string lpFileName,
			uint dwDesiredAccess,
			uint dwShareMode,
			IntPtr lpSecurityAttributes,
			uint dwCreationDisposition,
			uint dwFlagsAndAttributes,
			IntPtr hTemplateFile);

		private SafeFileHandle _safeFileHandle;

		public Connection()
		{
		}

		public void CreateFile()
		{
			_safeFileHandle = CreateFile(
				"test.scv",
				0,
				0,
				IntPtr.Zero,
				1,
				0,
				IntPtr.Zero);
		}

		public int GetCustomHashCode()
		{
			return _safeFileHandle.GetHashCode();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposedValue)
			{
				if (disposing)
				{
					_safeFileHandle.Dispose();
					_safeFileHandle = null;
				}

				_disposedValue = true;
			}
		}
	}
}
