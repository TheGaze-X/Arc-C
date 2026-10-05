using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000662 RID: 1634
	[Token(Token = "0x2000662")]
	public class UnmanagedMemoryStream : Stream
	{
		// Token: 0x06003131 RID: 12593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003131")]
		[Address(RVA = "0x4C91090", Offset = "0x4C8FC90", VA = "0x184C91090")]
		protected UnmanagedMemoryStream()
		{
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003132")]
		[Address(RVA = "0x4C91000", Offset = "0x4C8FC00", VA = "0x184C91000")]
		[System.CLSCompliant(false)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length)
		{
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003133")]
		[Address(RVA = "0x4C90F70", Offset = "0x4C8FB70", VA = "0x184C90F70")]
		[System.CLSCompliant(false)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access)
		{
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003134")]
		[Address(RVA = "0x4C8EBA0", Offset = "0x4C8D7A0", VA = "0x184C8EBA0")]
		[System.CLSCompliant(false)]
		protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access)
		{
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x0001A7D8 File Offset: 0x000189D8
		[Token(Token = "0x170007DE")]
		public override bool CanRead
		{
			[Token(Token = "0x6003135")]
			[Address(RVA = "0x4C910F0", Offset = "0x4C8FCF0", VA = "0x184C910F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x0001A7F0 File Offset: 0x000189F0
		[Token(Token = "0x170007DF")]
		public override bool CanSeek
		{
			[Token(Token = "0x6003136")]
			[Address(RVA = "0x4C91100", Offset = "0x4C8FD00", VA = "0x184C91100", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x0001A808 File Offset: 0x00018A08
		[Token(Token = "0x170007E0")]
		public override bool CanWrite
		{
			[Token(Token = "0x6003137")]
			[Address(RVA = "0x4C91110", Offset = "0x4C8FD10", VA = "0x184C91110", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003138")]
		[Address(RVA = "0x4C8E950", Offset = "0x4C8D550", VA = "0x184C8E950", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003139")]
		[Address(RVA = "0x4C8E960", Offset = "0x4C8D560", VA = "0x184C8E960")]
		private void EnsureNotClosed()
		{
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313A")]
		[Address(RVA = "0x4C8E9A0", Offset = "0x4C8D5A0", VA = "0x184C8E9A0")]
		private void EnsureReadable()
		{
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313B")]
		[Address(RVA = "0x4C8EA00", Offset = "0x4C8D600", VA = "0x184C8EA00")]
		private void EnsureWriteable()
		{
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313C")]
		[Address(RVA = "0x4C8E960", Offset = "0x4C8D560", VA = "0x184C8E960", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600313D")]
		[Address(RVA = "0x4C8EA60", Offset = "0x4C8D660", VA = "0x184C8EA60", Slot = "21")]
		public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x0001A820 File Offset: 0x00018A20
		[Token(Token = "0x170007E1")]
		public override long Length
		{
			[Token(Token = "0x600313E")]
			[Address(RVA = "0x4C91130", Offset = "0x4C8FD30", VA = "0x184C91130", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x0001A838 File Offset: 0x00018A38
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E2")]
		public override long Position
		{
			[Token(Token = "0x600313F")]
			[Address(RVA = "0x4C91280", Offset = "0x4C8FE80", VA = "0x184C91280", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6003140")]
			[Address(RVA = "0x4C912F0", Offset = "0x4C8FEF0", VA = "0x184C912F0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007E3")]
		[System.CLSCompliant(false)]
		public unsafe byte* PositionPointer
		{
			[Token(Token = "0x6003141")]
			[Address(RVA = "0x4C91180", Offset = "0x4C8FD80", VA = "0x184C91180")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x0001A850 File Offset: 0x00018A50
		[Token(Token = "0x6003142")]
		[Address(RVA = "0x4C8F9F0", Offset = "0x4C8E5F0", VA = "0x184C8F9F0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x0001A868 File Offset: 0x00018A68
		[Token(Token = "0x6003143")]
		[Address(RVA = "0x4C8F930", Offset = "0x4C8E530", VA = "0x184C8F930", Slot = "33")]
		public override int Read(System.Span<byte> buffer)
		{
			return 0;
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x0001A880 File Offset: 0x00018A80
		[Token(Token = "0x6003144")]
		[Address(RVA = "0x4C8F650", Offset = "0x4C8E250", VA = "0x184C8F650")]
		internal int ReadCore(System.Span<byte> buffer)
		{
			return 0;
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003145")]
		[Address(RVA = "0x4C8F160", Offset = "0x4C8DD60", VA = "0x184C8F160", Slot = "24")]
		public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x0001A898 File Offset: 0x00018A98
		[Token(Token = "0x6003146")]
		[Address(RVA = "0x4C8EE60", Offset = "0x4C8DA60", VA = "0x184C8EE60", Slot = "25")]
		public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, [System.Runtime.InteropServices.Optional] System.Threading.CancellationToken cancellationToken)
		{
			return default(System.Threading.Tasks.ValueTask<int>);
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x0001A8B0 File Offset: 0x00018AB0
		[Token(Token = "0x6003147")]
		[Address(RVA = "0x4C8F490", Offset = "0x4C8E090", VA = "0x184C8F490", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x0001A8C8 File Offset: 0x00018AC8
		[Token(Token = "0x6003148")]
		[Address(RVA = "0x4C8FC50", Offset = "0x4C8E850", VA = "0x184C8FC50", Slot = "30")]
		public override long Seek(long offset, SeekOrigin loc)
		{
			return 0L;
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003149")]
		[Address(RVA = "0x4C8FE40", Offset = "0x4C8EA40", VA = "0x184C8FE40", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314A")]
		[Address(RVA = "0x4C90C20", Offset = "0x4C8F820", VA = "0x184C90C20", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314B")]
		[Address(RVA = "0x4C90EB0", Offset = "0x4C8FAB0", VA = "0x184C90EB0", Slot = "36")]
		public override void Write(System.ReadOnlySpan<byte> buffer)
		{
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314C")]
		[Address(RVA = "0x4C90820", Offset = "0x4C8F420", VA = "0x184C90820")]
		internal void WriteCore(System.ReadOnlySpan<byte> buffer)
		{
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600314D")]
		[Address(RVA = "0x4C90030", Offset = "0x4C8EC30", VA = "0x184C90030", Slot = "28")]
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x0001A8E0 File Offset: 0x00018AE0
		[Token(Token = "0x600314E")]
		[Address(RVA = "0x4C902E0", Offset = "0x4C8EEE0", VA = "0x184C902E0", Slot = "29")]
		public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, [System.Runtime.InteropServices.Optional] System.Threading.CancellationToken cancellationToken)
		{
			return default(System.Threading.Tasks.ValueTask);
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314F")]
		[Address(RVA = "0x4C90540", Offset = "0x4C8F140", VA = "0x184C90540", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x04001B19 RID: 6937
		[Token(Token = "0x4001B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Runtime.InteropServices.SafeBuffer _buffer;

		// Token: 0x04001B1A RID: 6938
		[Token(Token = "0x4001B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private unsafe byte* _mem;

		// Token: 0x04001B1B RID: 6939
		[Token(Token = "0x4001B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long _length;

		// Token: 0x04001B1C RID: 6940
		[Token(Token = "0x4001B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long _capacity;

		// Token: 0x04001B1D RID: 6941
		[Token(Token = "0x4001B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long _position;

		// Token: 0x04001B1E RID: 6942
		[Token(Token = "0x4001B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long _offset;

		// Token: 0x04001B1F RID: 6943
		[Token(Token = "0x4001B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private FileAccess _access;

		// Token: 0x04001B20 RID: 6944
		[Token(Token = "0x4001B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal bool _isOpen;

		// Token: 0x04001B21 RID: 6945
		[Token(Token = "0x4001B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.Threading.Tasks.Task<int> _lastReadTask;
	}
}
