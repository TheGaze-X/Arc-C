using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200064F RID: 1615
	[Token(Token = "0x200064F")]
	[System.Serializable]
	public class MemoryStream : Stream
	{
		// Token: 0x0600304F RID: 12367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304F")]
		[Address(RVA = "0x4C7EC20", Offset = "0x4C7D820", VA = "0x184C7EC20")]
		public MemoryStream()
		{
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003050")]
		[Address(RVA = "0x4C7ECC0", Offset = "0x4C7D8C0", VA = "0x184C7ECC0")]
		public MemoryStream(int capacity)
		{
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003051")]
		[Address(RVA = "0x4C7EB30", Offset = "0x4C7D730", VA = "0x184C7EB30")]
		public MemoryStream(byte[] buffer)
		{
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003052")]
		[Address(RVA = "0x4C7EA30", Offset = "0x4C7D630", VA = "0x184C7EA30")]
		public MemoryStream(byte[] buffer, bool writable)
		{
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003053")]
		[Address(RVA = "0x4C7E7B0", Offset = "0x4C7D3B0", VA = "0x184C7E7B0")]
		public MemoryStream(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003054")]
		[Address(RVA = "0x4C7EDF0", Offset = "0x4C7D9F0", VA = "0x184C7EDF0")]
		public MemoryStream(byte[] buffer, int index, int count, bool writable)
		{
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003055")]
		[Address(RVA = "0x4C7E7E0", Offset = "0x4C7D3E0", VA = "0x184C7E7E0")]
		public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
		{
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x0001A268 File Offset: 0x00018468
		[Token(Token = "0x170007C6")]
		public override bool CanRead
		{
			[Token(Token = "0x6003056")]
			[Address(RVA = "0x4C7EE20", Offset = "0x4C7DA20", VA = "0x184C7EE20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06003057 RID: 12375 RVA: 0x0001A280 File Offset: 0x00018480
		[Token(Token = "0x170007C7")]
		public override bool CanSeek
		{
			[Token(Token = "0x6003057")]
			[Address(RVA = "0x4C7EE20", Offset = "0x4C7DA20", VA = "0x184C7EE20", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x0001A298 File Offset: 0x00018498
		[Token(Token = "0x170007C8")]
		public override bool CanWrite
		{
			[Token(Token = "0x6003058")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003059")]
		[Address(RVA = "0x4C7C6C0", Offset = "0x4C7B2C0", VA = "0x184C7C6C0")]
		private void EnsureNotClosed()
		{
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600305A")]
		[Address(RVA = "0x4C7C700", Offset = "0x4C7B300", VA = "0x184C7C700")]
		private void EnsureWriteable()
		{
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600305B")]
		[Address(RVA = "0x4C7C580", Offset = "0x4C7B180", VA = "0x184C7C580", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x0001A2B0 File Offset: 0x000184B0
		[Token(Token = "0x600305C")]
		[Address(RVA = "0x4C7C5F0", Offset = "0x4C7B1F0", VA = "0x184C7C5F0")]
		private bool EnsureCapacity(int value)
		{
			return default(bool);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600305D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600305E")]
		[Address(RVA = "0x4C7C760", Offset = "0x4C7B360", VA = "0x184C7C760", Slot = "21")]
		public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600305F")]
		[Address(RVA = "0x4C7C8A0", Offset = "0x4C7B4A0", VA = "0x184C7C8A0", Slot = "38")]
		public virtual byte[] GetBuffer()
		{
			return null;
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003060")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
		internal byte[] InternalGetBuffer()
		{
			return null;
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x0001A2C8 File Offset: 0x000184C8
		[Token(Token = "0x6003061")]
		[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
		internal int InternalGetPosition()
		{
			return 0;
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x0001A2E0 File Offset: 0x000184E0
		[Token(Token = "0x6003062")]
		[Address(RVA = "0x4C7C970", Offset = "0x4C7B570", VA = "0x184C7C970")]
		internal int InternalReadInt32()
		{
			return 0;
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x0001A2F8 File Offset: 0x000184F8
		[Token(Token = "0x6003063")]
		[Address(RVA = "0x4C7C910", Offset = "0x4C7B510", VA = "0x184C7C910")]
		internal int InternalEmulateRead(int count)
		{
			return 0;
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x0001A310 File Offset: 0x00018510
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C9")]
		public virtual int Capacity
		{
			[Token(Token = "0x6003064")]
			[Address(RVA = "0x4C7EE30", Offset = "0x4C7DA30", VA = "0x184C7EE30", Slot = "39")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003065")]
			[Address(RVA = "0x4C7EF10", Offset = "0x4C7DB10", VA = "0x184C7EF10", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x0001A328 File Offset: 0x00018528
		[Token(Token = "0x170007CA")]
		public override long Length
		{
			[Token(Token = "0x6003066")]
			[Address(RVA = "0x4C7EE70", Offset = "0x4C7DA70", VA = "0x184C7EE70", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x0001A340 File Offset: 0x00018540
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CB")]
		public override long Position
		{
			[Token(Token = "0x6003067")]
			[Address(RVA = "0x4C7EEC0", Offset = "0x4C7DAC0", VA = "0x184C7EEC0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6003068")]
			[Address(RVA = "0x4C7F0F0", Offset = "0x4C7DCF0", VA = "0x184C7F0F0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x0001A358 File Offset: 0x00018558
		[Token(Token = "0x6003069")]
		[Address(RVA = "0x4C7D170", Offset = "0x4C7BD70", VA = "0x184C7D170", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x0001A370 File Offset: 0x00018570
		[Token(Token = "0x600306A")]
		[Address(RVA = "0x4C7D400", Offset = "0x4C7C000", VA = "0x184C7D400", Slot = "33")]
		public override int Read(System.Span<byte> buffer)
		{
			return 0;
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600306B")]
		[Address(RVA = "0x4C7CD90", Offset = "0x4C7B990", VA = "0x184C7CD90", Slot = "24")]
		public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x0001A388 File Offset: 0x00018588
		[Token(Token = "0x600306C")]
		[Address(RVA = "0x4C7CA50", Offset = "0x4C7B650", VA = "0x184C7CA50", Slot = "25")]
		public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, [System.Runtime.InteropServices.Optional] System.Threading.CancellationToken cancellationToken)
		{
			return default(System.Threading.Tasks.ValueTask<int>);
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x0001A3A0 File Offset: 0x000185A0
		[Token(Token = "0x600306D")]
		[Address(RVA = "0x4C7D0F0", Offset = "0x4C7BCF0", VA = "0x184C7D0F0", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x0001A3B8 File Offset: 0x000185B8
		[Token(Token = "0x600306E")]
		[Address(RVA = "0x4C7D5F0", Offset = "0x4C7C1F0", VA = "0x184C7D5F0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin loc)
		{
			return 0L;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306F")]
		[Address(RVA = "0x4C7D870", Offset = "0x4C7C470", VA = "0x184C7D870", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003070")]
		[Address(RVA = "0x4C7D9C0", Offset = "0x4C7C5C0", VA = "0x184C7D9C0", Slot = "41")]
		public virtual byte[] ToArray()
		{
			return null;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003071")]
		[Address(RVA = "0x4C7E480", Offset = "0x4C7D080", VA = "0x184C7E480", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003072")]
		[Address(RVA = "0x4C7E1E0", Offset = "0x4C7CDE0", VA = "0x184C7E1E0", Slot = "36")]
		public override void Write(System.ReadOnlySpan<byte> buffer)
		{
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003073")]
		[Address(RVA = "0x4C7DCF0", Offset = "0x4C7C8F0", VA = "0x184C7DCF0", Slot = "28")]
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x0001A3D0 File Offset: 0x000185D0
		[Token(Token = "0x6003074")]
		[Address(RVA = "0x4C7DA60", Offset = "0x4C7C660", VA = "0x184C7DA60", Slot = "29")]
		public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, [System.Runtime.InteropServices.Optional] System.Threading.CancellationToken cancellationToken)
		{
			return default(System.Threading.Tasks.ValueTask);
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003075")]
		[Address(RVA = "0x4C7DFE0", Offset = "0x4C7CBE0", VA = "0x184C7DFE0", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x4C7E110", Offset = "0x4C7CD10", VA = "0x184C7E110", Slot = "42")]
		public virtual void WriteTo(Stream stream)
		{
		}

		// Token: 0x04001ABF RID: 6847
		[Token(Token = "0x4001ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04001AC0 RID: 6848
		[Token(Token = "0x4001AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _origin;

		// Token: 0x04001AC1 RID: 6849
		[Token(Token = "0x4001AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _position;

		// Token: 0x04001AC2 RID: 6850
		[Token(Token = "0x4001AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _length;

		// Token: 0x04001AC3 RID: 6851
		[Token(Token = "0x4001AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _capacity;

		// Token: 0x04001AC4 RID: 6852
		[Token(Token = "0x4001AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _expandable;

		// Token: 0x04001AC5 RID: 6853
		[Token(Token = "0x4001AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool _writable;

		// Token: 0x04001AC6 RID: 6854
		[Token(Token = "0x4001AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool _exposable;

		// Token: 0x04001AC7 RID: 6855
		[Token(Token = "0x4001AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		private bool _isOpen;

		// Token: 0x04001AC8 RID: 6856
		[Token(Token = "0x4001AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[System.NonSerialized]
		private System.Threading.Tasks.Task<int> _lastReadTask;

		// Token: 0x04001AC9 RID: 6857
		[Token(Token = "0x4001AC9")]
		private const int MemStreamMaxLength = 2147483647;
	}
}
