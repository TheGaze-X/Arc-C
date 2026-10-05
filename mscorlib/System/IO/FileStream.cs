using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace System.IO
{
	// Token: 0x0200067E RID: 1662
	[Token(Token = "0x200067E")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class FileStream : Stream
	{
		// Token: 0x06003280 RID: 12928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003280")]
		[Address(RVA = "0x4C97300", Offset = "0x4C95F00", VA = "0x184C97300")]
		[System.Obsolete("Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) instead")]
		public FileStream(System.IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize)
		{
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003281")]
		[Address(RVA = "0x4C96600", Offset = "0x4C95200", VA = "0x184C96600")]
		internal FileStream(System.IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
		{
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003282")]
		[Address(RVA = "0x4C971B0", Offset = "0x4C95DB0", VA = "0x184C971B0")]
		public FileStream(string path, FileMode mode)
		{
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003283")]
		[Address(RVA = "0x4C967D0", Offset = "0x4C953D0", VA = "0x184C967D0")]
		public FileStream(string path, FileMode mode, FileAccess access)
		{
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003284")]
		[Address(RVA = "0x4C97240", Offset = "0x4C95E40", VA = "0x184C97240")]
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
		{
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003285")]
		[Address(RVA = "0x4C965C0", Offset = "0x4C951C0", VA = "0x184C965C0")]
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
		{
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003286")]
		[Address(RVA = "0x4C97270", Offset = "0x4C95E70", VA = "0x184C97270")]
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
		{
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003287")]
		[Address(RVA = "0x4C972C0", Offset = "0x4C95EC0", VA = "0x184C972C0")]
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
		{
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003288")]
		[Address(RVA = "0x4C971F0", Offset = "0x4C95DF0", VA = "0x184C971F0")]
		internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous)
		{
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003289")]
		[Address(RVA = "0x4C96810", Offset = "0x4C95410", VA = "0x184C96810")]
		internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options)
		{
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328A")]
		[Address(RVA = "0x4C94B60", Offset = "0x4C93760", VA = "0x184C94B60")]
		private void Init(Microsoft.Win32.SafeHandles.SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
		{
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x0001B078 File Offset: 0x00019278
		[Token(Token = "0x17000815")]
		public override bool CanRead
		{
			[Token(Token = "0x600328B")]
			[Address(RVA = "0x4C974C0", Offset = "0x4C960C0", VA = "0x184C974C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x0001B090 File Offset: 0x00019290
		[Token(Token = "0x17000816")]
		public override bool CanWrite
		{
			[Token(Token = "0x600328C")]
			[Address(RVA = "0x4C974E0", Offset = "0x4C960E0", VA = "0x184C974E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x0001B0A8 File Offset: 0x000192A8
		[Token(Token = "0x17000817")]
		public override bool CanSeek
		{
			[Token(Token = "0x600328D")]
			[Address(RVA = "0x4C974D0", Offset = "0x4C960D0", VA = "0x184C974D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000818")]
		public virtual string Name
		{
			[Token(Token = "0x600328E")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x0001B0C0 File Offset: 0x000192C0
		[Token(Token = "0x17000819")]
		public override long Length
		{
			[Token(Token = "0x600328F")]
			[Address(RVA = "0x4C97500", Offset = "0x4C96100", VA = "0x184C97500", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x0001B0D8 File Offset: 0x000192D8
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081A")]
		public override long Position
		{
			[Token(Token = "0x6003290")]
			[Address(RVA = "0x4C976D0", Offset = "0x4C962D0", VA = "0x184C976D0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6003291")]
			[Address(RVA = "0x4C978F0", Offset = "0x4C964F0", VA = "0x184C978F0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700081B")]
		public virtual Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle
		{
			[Token(Token = "0x6003292")]
			[Address(RVA = "0x4C978B0", Offset = "0x4C964B0", VA = "0x184C978B0", Slot = "39")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003293")]
		[Address(RVA = "0x4C94390", Offset = "0x4C92F90", VA = "0x184C94390")]
		private void ExposeHandle()
		{
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x0001B0F0 File Offset: 0x000192F0
		[Token(Token = "0x6003294")]
		[Address(RVA = "0x4C94F10", Offset = "0x4C93B10", VA = "0x184C94F10", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003295")]
		[Address(RVA = "0x4C95DD0", Offset = "0x4C949D0", VA = "0x184C95DD0", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x0001B108 File Offset: 0x00019308
		[Token(Token = "0x6003296")]
		[Address(RVA = "0x4C95360", Offset = "0x4C93F60", VA = "0x184C95360", Slot = "32")]
		public override int Read([System.Runtime.InteropServices.In] [System.Runtime.InteropServices.Out] byte[] array, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x0001B120 File Offset: 0x00019320
		[Token(Token = "0x6003297")]
		[Address(RVA = "0x4C951E0", Offset = "0x4C93DE0", VA = "0x184C951E0")]
		private int ReadInternal(byte[] dest, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003298")]
		[Address(RVA = "0x4C93240", Offset = "0x4C91E40", VA = "0x184C93240", Slot = "22")]
		public override System.IAsyncResult BeginRead(byte[] array, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject)
		{
			return null;
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x0001B138 File Offset: 0x00019338
		[Token(Token = "0x6003299")]
		[Address(RVA = "0x4C93F60", Offset = "0x4C92B60", VA = "0x184C93F60", Slot = "23")]
		public override int EndRead(System.IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x4C96220", Offset = "0x4C94E20", VA = "0x184C96220", Slot = "35")]
		public override void Write(byte[] array, int offset, int count)
		{
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329B")]
		[Address(RVA = "0x4C95F60", Offset = "0x4C94B60", VA = "0x184C95F60")]
		private void WriteInternal(byte[] src, int offset, int count)
		{
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600329C")]
		[Address(RVA = "0x4C936B0", Offset = "0x4C922B0", VA = "0x184C936B0", Slot = "26")]
		public override System.IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject)
		{
			return null;
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329D")]
		[Address(RVA = "0x4C94180", Offset = "0x4C92D80", VA = "0x184C94180", Slot = "27")]
		public override void EndWrite(System.IAsyncResult asyncResult)
		{
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x0001B150 File Offset: 0x00019350
		[Token(Token = "0x600329E")]
		[Address(RVA = "0x4C957B0", Offset = "0x4C943B0", VA = "0x184C957B0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329F")]
		[Address(RVA = "0x4C95AE0", Offset = "0x4C946E0", VA = "0x184C95AE0", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x4C94670", Offset = "0x4C93270", VA = "0x184C94670", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A1")]
		[Address(RVA = "0x4C80F70", Offset = "0x4C7FB70", VA = "0x184C80F70", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A2")]
		[Address(RVA = "0x4C93C40", Offset = "0x4C92840", VA = "0x184C93C40", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032A3")]
		[Address(RVA = "0x4C943C0", Offset = "0x4C92FC0", VA = "0x184C943C0", Slot = "21")]
		public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032A4")]
		[Address(RVA = "0x4C94F00", Offset = "0x4C93B00", VA = "0x184C94F00", Slot = "24")]
		public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032A5")]
		[Address(RVA = "0x4C95DC0", Offset = "0x4C949C0", VA = "0x184C95DC0", Slot = "28")]
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x0001B168 File Offset: 0x00019368
		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x4C952B0", Offset = "0x4C93EB0", VA = "0x184C952B0")]
		private int ReadSegment(byte[] dest, int dest_offset, int count)
		{
			return 0;
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x0001B180 File Offset: 0x00019380
		[Token(Token = "0x60032A7")]
		[Address(RVA = "0x4C961B0", Offset = "0x4C94DB0", VA = "0x184C961B0")]
		private int WriteSegment(byte[] src, int src_offset, int count)
		{
			return 0;
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A8")]
		[Address(RVA = "0x4C94470", Offset = "0x4C93070", VA = "0x184C94470")]
		private void FlushBuffer()
		{
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A9")]
		[Address(RVA = "0x4C94460", Offset = "0x4C93060", VA = "0x184C94460")]
		private void FlushBufferIfDirty()
		{
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032AA")]
		[Address(RVA = "0x4C95770", Offset = "0x4C94370", VA = "0x184C95770")]
		private void RefillBuffer()
		{
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x0001B198 File Offset: 0x00019398
		[Token(Token = "0x60032AB")]
		[Address(RVA = "0x4C950A0", Offset = "0x4C93CA0", VA = "0x184C950A0")]
		private int ReadData(System.Runtime.InteropServices.SafeHandle safeHandle, byte[] buf, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032AC")]
		[Address(RVA = "0x4C948A0", Offset = "0x4C934A0", VA = "0x184C948A0")]
		private void InitBuffer(int size, bool isZeroSize)
		{
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032AD")]
		[Address(RVA = "0x4C947E0", Offset = "0x4C933E0", VA = "0x184C947E0")]
		private string GetSecureFileName(string filename)
		{
			return null;
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032AE")]
		[Address(RVA = "0x4C94700", Offset = "0x4C93300", VA = "0x184C94700")]
		private string GetSecureFileName(string filename, bool full)
		{
			return null;
		}

		// Token: 0x04001B96 RID: 7062
		[Token(Token = "0x4001B96")]
		internal const int DefaultBufferSize = 4096;

		// Token: 0x04001B97 RID: 7063
		[Token(Token = "0x4001B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte[] buf_recycle;

		// Token: 0x04001B98 RID: 7064
		[Token(Token = "0x4001B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object buf_recycle_lock;

		// Token: 0x04001B99 RID: 7065
		[Token(Token = "0x4001B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] buf;

		// Token: 0x04001B9A RID: 7066
		[Token(Token = "0x4001B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string name;

		// Token: 0x04001B9B RID: 7067
		[Token(Token = "0x4001B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Microsoft.Win32.SafeHandles.SafeFileHandle safeHandle;

		// Token: 0x04001B9C RID: 7068
		[Token(Token = "0x4001B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isExposed;

		// Token: 0x04001B9D RID: 7069
		[Token(Token = "0x4001B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long append_startpos;

		// Token: 0x04001B9E RID: 7070
		[Token(Token = "0x4001B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FileAccess access;

		// Token: 0x04001B9F RID: 7071
		[Token(Token = "0x4001B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool owner;

		// Token: 0x04001BA0 RID: 7072
		[Token(Token = "0x4001BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		private bool async;

		// Token: 0x04001BA1 RID: 7073
		[Token(Token = "0x4001BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		private bool canseek;

		// Token: 0x04001BA2 RID: 7074
		[Token(Token = "0x4001BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		private bool anonymous;

		// Token: 0x04001BA3 RID: 7075
		[Token(Token = "0x4001BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool buf_dirty;

		// Token: 0x04001BA4 RID: 7076
		[Token(Token = "0x4001BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int buf_size;

		// Token: 0x04001BA5 RID: 7077
		[Token(Token = "0x4001BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int buf_length;

		// Token: 0x04001BA6 RID: 7078
		[Token(Token = "0x4001BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int buf_offset;

		// Token: 0x04001BA7 RID: 7079
		[Token(Token = "0x4001BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private long buf_start;

		// Token: 0x0200067F RID: 1663
		// (Invoke) Token: 0x060032B1 RID: 12977
		[Token(Token = "0x200067F")]
		private delegate int ReadDelegate(byte[] buffer, int offset, int count);

		// Token: 0x02000680 RID: 1664
		// (Invoke) Token: 0x060032B5 RID: 12981
		[Token(Token = "0x2000680")]
		private delegate void WriteDelegate(byte[] buffer, int offset, int count);
	}
}
