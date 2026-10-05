using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002DA RID: 730
	[Token(Token = "0x20002DA")]
	public class CryptoStream : System.IO.Stream, System.IDisposable
	{
		// Token: 0x06001828 RID: 6184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x4B25890", Offset = "0x4B24490", VA = "0x184B25890")]
		public CryptoStream(System.IO.Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
		{
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x4B25550", Offset = "0x4B24150", VA = "0x184B25550")]
		public CryptoStream(System.IO.Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen)
		{
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x00011418 File Offset: 0x0000F618
		[Token(Token = "0x17000277")]
		public override bool CanRead
		{
			[Token(Token = "0x600182A")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00011430 File Offset: 0x0000F630
		[Token(Token = "0x17000278")]
		public override bool CanSeek
		{
			[Token(Token = "0x600182B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x00011448 File Offset: 0x0000F648
		[Token(Token = "0x17000279")]
		public override bool CanWrite
		{
			[Token(Token = "0x600182C")]
			[Address(RVA = "0x2218060", Offset = "0x2216C60", VA = "0x182218060", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00011460 File Offset: 0x0000F660
		[Token(Token = "0x1700027A")]
		public override long Length
		{
			[Token(Token = "0x600182D")]
			[Address(RVA = "0x4B259E0", Offset = "0x4B245E0", VA = "0x184B259E0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x00011478 File Offset: 0x0000F678
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027B")]
		public override long Position
		{
			[Token(Token = "0x600182E")]
			[Address(RVA = "0x4B25A40", Offset = "0x4B24640", VA = "0x184B25A40", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600182F")]
			[Address(RVA = "0x4B25AA0", Offset = "0x4B246A0", VA = "0x184B25AA0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x00011490 File Offset: 0x0000F690
		[Token(Token = "0x1700027C")]
		public bool HasFlushedFinalBlock
		{
			[Token(Token = "0x6001830")]
			[Address(RVA = "0x4B259D0", Offset = "0x4B245D0", VA = "0x184B259D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001831")]
		[Address(RVA = "0x4B24790", Offset = "0x4B23390", VA = "0x184B24790")]
		public void FlushFinalBlock()
		{
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001832")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001833")]
		[Address(RVA = "0x4B24610", Offset = "0x4B23210", VA = "0x184B24610", Slot = "21")]
		public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000114A8 File Offset: 0x0000F6A8
		[Token(Token = "0x6001834")]
		[Address(RVA = "0x4B24FC0", Offset = "0x4B23BC0", VA = "0x184B24FC0", Slot = "30")]
		public override long Seek(long offset, System.IO.SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x4B25020", Offset = "0x4B23C20", VA = "0x184B25020", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x4B24D10", Offset = "0x4B23910", VA = "0x184B24D10", Slot = "24")]
		public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x4B23F60", Offset = "0x4B22B60", VA = "0x184B23F60", Slot = "22")]
		public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000114C0 File Offset: 0x0000F6C0
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x4B245C0", Offset = "0x4B231C0", VA = "0x184B245C0", Slot = "23")]
		public override int EndRead(System.IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x4B24BC0", Offset = "0x4B237C0", VA = "0x184B24BC0")]
		private System.Threading.Tasks.Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x000114D8 File Offset: 0x0000F6D8
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x4B24E70", Offset = "0x4B23A70", VA = "0x184B24E70", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183B")]
		[Address(RVA = "0x4B25460", Offset = "0x4B24060", VA = "0x184B25460", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x4B24EE0", Offset = "0x4B23AE0", VA = "0x184B24EE0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x4B24100", Offset = "0x4B22D00", VA = "0x184B24100")]
		private void CheckReadArguments(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600183E")]
		[Address(RVA = "0x4B24A60", Offset = "0x4B23660", VA = "0x184B24A60")]
		private System.Threading.Tasks.Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken, bool useAsync)
		{
			return null;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x4B25300", Offset = "0x4B23F00", VA = "0x184B25300", Slot = "28")]
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x4B24030", Offset = "0x4B22C30", VA = "0x184B24030", Slot = "26")]
		public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x4B24600", Offset = "0x4B23200", VA = "0x184B24600", Slot = "27")]
		public override void EndWrite(System.IAsyncResult asyncResult)
		{
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x4B251C0", Offset = "0x4B23DC0", VA = "0x184B251C0")]
		private System.Threading.Tasks.Task WriteAsyncInternal(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x4B254B0", Offset = "0x4B240B0", VA = "0x184B254B0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x4B242F0", Offset = "0x4B22EF0", VA = "0x184B242F0")]
		private void CheckWriteArguments(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x4B25080", Offset = "0x4B23C80", VA = "0x184B25080")]
		private System.Threading.Tasks.Task WriteAsyncCore(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken, bool useAsync)
		{
			return null;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x4B244E0", Offset = "0x4B230E0", VA = "0x184B244E0")]
		public void Clear()
		{
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x4B24520", Offset = "0x4B23120", VA = "0x184B24520", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x4B249A0", Offset = "0x4B235A0", VA = "0x184B249A0")]
		private void InitializeBuffer()
		{
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700027D")]
		private System.Threading.SemaphoreSlim AsyncActiveSemaphore
		{
			[Token(Token = "0x6001849")]
			[Address(RVA = "0x4B258B0", Offset = "0x4B244B0", VA = "0x184B258B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D41 RID: 3393
		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x28")]
		private readonly System.IO.Stream _stream;

		// Token: 0x04000D42 RID: 3394
		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x30")]
		private readonly ICryptoTransform _transform;

		// Token: 0x04000D43 RID: 3395
		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x38")]
		private readonly CryptoStreamMode _transformMode;

		// Token: 0x04000D44 RID: 3396
		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x40")]
		private byte[] _inputBuffer;

		// Token: 0x04000D45 RID: 3397
		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x48")]
		private int _inputBufferIndex;

		// Token: 0x04000D46 RID: 3398
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x4C")]
		private int _inputBlockSize;

		// Token: 0x04000D47 RID: 3399
		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x50")]
		private byte[] _outputBuffer;

		// Token: 0x04000D48 RID: 3400
		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x58")]
		private int _outputBufferIndex;

		// Token: 0x04000D49 RID: 3401
		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x5C")]
		private int _outputBlockSize;

		// Token: 0x04000D4A RID: 3402
		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x60")]
		private bool _canRead;

		// Token: 0x04000D4B RID: 3403
		[Token(Token = "0x4000D4B")]
		[FieldOffset(Offset = "0x61")]
		private bool _canWrite;

		// Token: 0x04000D4C RID: 3404
		[Token(Token = "0x4000D4C")]
		[FieldOffset(Offset = "0x62")]
		private bool _finalBlockTransformed;

		// Token: 0x04000D4D RID: 3405
		[Token(Token = "0x4000D4D")]
		[FieldOffset(Offset = "0x68")]
		private System.Threading.SemaphoreSlim _lazyAsyncActiveSemaphore;

		// Token: 0x04000D4E RID: 3406
		[Token(Token = "0x4000D4E")]
		[FieldOffset(Offset = "0x70")]
		private readonly bool _leaveOpen;
	}
}
