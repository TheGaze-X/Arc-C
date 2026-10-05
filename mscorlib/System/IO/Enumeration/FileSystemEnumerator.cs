using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.IO.Enumeration
{
	// Token: 0x0200068E RID: 1678
	[Token(Token = "0x200068E")]
	public abstract class FileSystemEnumerator<TResult> : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.Collections.Generic.IEnumerator<TResult>, System.IDisposable, System.Collections.IEnumerator
	{
		// Token: 0x0600332B RID: 13099 RVA: 0x0001B408 File Offset: 0x00019608
		[Token(Token = "0x600332B")]
		[MethodImpl(256)]
		private bool GetDataUWP()
		{
			return default(bool);
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x0001B420 File Offset: 0x00019620
		[Token(Token = "0x600332C")]
		private System.IntPtr CreateRelativeDirectoryHandleUWP(System.ReadOnlySpan<char> relativePath, string fullPath)
		{
			return 0;
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600332D")]
		public FileSystemEnumerator(string directory, [System.Runtime.InteropServices.Optional] EnumerationOptions options)
		{
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600332E")]
		private void CloseDirectoryHandle()
		{
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x0001B438 File Offset: 0x00019638
		[Token(Token = "0x600332F")]
		private System.IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false)
		{
			return 0;
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x0001B450 File Offset: 0x00019650
		[Token(Token = "0x6003330")]
		private bool ContinueOnDirectoryError(int error, bool ignoreNotFound)
		{
			return default(bool);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x0001B468 File Offset: 0x00019668
		[Token(Token = "0x6003331")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003332")]
		private void FindNextEntry()
		{
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x0001B480 File Offset: 0x00019680
		[Token(Token = "0x6003333")]
		private bool DequeueNextDirectory()
		{
			return default(bool);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003334")]
		private void InternalDispose(bool disposing)
		{
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x0001B498 File Offset: 0x00019698
		[Token(Token = "0x6003335")]
		[MethodImpl(256)]
		private bool GetData()
		{
			return default(bool);
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x0001B4B0 File Offset: 0x000196B0
		[Token(Token = "0x6003336")]
		private System.IntPtr CreateRelativeDirectoryHandle(System.ReadOnlySpan<char> relativePath, string fullPath)
		{
			return 0;
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x0001B4C8 File Offset: 0x000196C8
		[Token(Token = "0x6003337")]
		protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry)
		{
			return default(bool);
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0001B4E0 File Offset: 0x000196E0
		[Token(Token = "0x6003338")]
		protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
		{
			return default(bool);
		}

		// Token: 0x06003339 RID: 13113
		[Token(Token = "0x6003339")]
		protected abstract TResult TransformEntry(ref FileSystemEntry entry);

		// Token: 0x0600333A RID: 13114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333A")]
		protected virtual void OnDirectoryFinished(System.ReadOnlySpan<char> directory)
		{
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x0001B4F8 File Offset: 0x000196F8
		[Token(Token = "0x600333B")]
		protected virtual bool ContinueOnError(int error)
		{
			return default(bool);
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x0600333C RID: 13116 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000827")]
		public TResult Current
		{
			[Token(Token = "0x600333C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000828")]
		private object Current
		{
			[Token(Token = "0x600333D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333E")]
		private void DirectoryFinished()
		{
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333F")]
		public void Reset()
		{
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003340")]
		public void Dispose()
		{
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003341")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003342")]
		protected override void Finalize()
		{
		}

		// Token: 0x04001BEB RID: 7147
		[Token(Token = "0x4001BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _originalRootDirectory;

		// Token: 0x04001BEC RID: 7148
		[Token(Token = "0x4001BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _rootDirectory;

		// Token: 0x04001BED RID: 7149
		[Token(Token = "0x4001BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly EnumerationOptions _options;

		// Token: 0x04001BEE RID: 7150
		[Token(Token = "0x4001BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly object _lock;

		// Token: 0x04001BEF RID: 7151
		[Token(Token = "0x4001BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private unsafe Interop.NtDll.FILE_FULL_DIR_INFORMATION* _entry;

		// Token: 0x04001BF0 RID: 7152
		[Token(Token = "0x4001BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult _current;

		// Token: 0x04001BF1 RID: 7153
		[Token(Token = "0x4001BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.IntPtr _buffer;

		// Token: 0x04001BF2 RID: 7154
		[Token(Token = "0x4001BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _bufferLength;

		// Token: 0x04001BF3 RID: 7155
		[Token(Token = "0x4001BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.IntPtr _directoryHandle;

		// Token: 0x04001BF4 RID: 7156
		[Token(Token = "0x4001BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string _currentPath;

		// Token: 0x04001BF5 RID: 7157
		[Token(Token = "0x4001BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _lastEntryFound;

		// Token: 0x04001BF6 RID: 7158
		[Token(Token = "0x4001BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[System.Runtime.CompilerServices.TupleElementNames(new string[]
		{
			"Handle",
			"Path"
		})]
		private System.Collections.Generic.Queue<System.ValueTuple<System.IntPtr, string>> _pending;
	}
}
