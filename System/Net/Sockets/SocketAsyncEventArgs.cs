using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	public class SocketAsyncEventArgs : EventArgs, IDisposable
	{
		// Token: 0x170005A6 RID: 1446
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A6")]
		private Exception ConnectByNameError
		{
			[Token(Token = "0x60019FC")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A7")]
		public Socket AcceptSocket
		{
			[Token(Token = "0x60019FD")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019FE")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x0000BA30 File Offset: 0x00009C30
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A8")]
		public int BytesTransferred
		{
			[Token(Token = "0x60019FF")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A00")]
			[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A9")]
		private SocketAsyncOperation LastOperation
		{
			[Token(Token = "0x6001A01")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AA")]
		public EndPoint RemoteEndPoint
		{
			[Token(Token = "0x6001A02")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A03")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x170005AB RID: 1451
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AB")]
		[MonoTODO("unused property")]
		public int SendPacketsSendSize
		{
			[Token(Token = "0x6001A04")]
			[Address(RVA = "0x4A55A30", Offset = "0x4A54630", VA = "0x184A55A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0000BA48 File Offset: 0x00009C48
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AC")]
		public SocketError SocketError
		{
			[Token(Token = "0x6001A05")]
			[Address(RVA = "0x4C2EA10", Offset = "0x4C2D610", VA = "0x184C2EA10")]
			[CompilerGenerated]
			get
			{
				return SocketError.Success;
			}
			[Token(Token = "0x6001A06")]
			[Address(RVA = "0x5008370", Offset = "0x5006F70", VA = "0x185008370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AD RID: 1453
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AD")]
		public SocketFlags SocketFlags
		{
			[Token(Token = "0x6001A07")]
			[Address(RVA = "0x5008380", Offset = "0x5006F80", VA = "0x185008380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AE")]
		public object UserToken
		{
			[Token(Token = "0x6001A08")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A09")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06001A0A RID: 6666 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001A0B RID: 6667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000010")]
		public event EventHandler<SocketAsyncEventArgs> Completed
		{
			[Token(Token = "0x6001A0A")]
			[Address(RVA = "0x50C1290", Offset = "0x50BFE90", VA = "0x1850C1290")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001A0B")]
			[Address(RVA = "0x50C1420", Offset = "0x50C0020", VA = "0x1850C1420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x50C1150", Offset = "0x50BFD50", VA = "0x1850C1150")]
		public SocketAsyncEventArgs()
		{
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x50C11F0", Offset = "0x50BFDF0", VA = "0x1850C11F0")]
		internal SocketAsyncEventArgs(bool flowExecutionContext)
		{
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x50C0D10", Offset = "0x50BF910", VA = "0x1850C0D10", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0F")]
		[Address(RVA = "0x50C0D00", Offset = "0x50BF900", VA = "0x1850C0D00")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x50C0CA0", Offset = "0x50BF8A0", VA = "0x1850C0CA0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
		internal void SetConnectByNameError(Exception error)
		{
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A12")]
		[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
		internal void SetBytesTransferred(int value)
		{
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AF")]
		internal Socket CurrentSocket
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
		internal void SetCurrentSocket(Socket socket)
		{
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x50C1070", Offset = "0x50BFC70", VA = "0x1850C1070")]
		internal void SetLastOperation(SocketAsyncOperation op)
		{
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x50C0C50", Offset = "0x50BF850", VA = "0x1850C0C50")]
		internal void Complete_internal()
		{
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x50C0D50", Offset = "0x50BF950", VA = "0x1850C0D50", Slot = "5")]
		protected virtual void OnCompleted(SocketAsyncEventArgs e)
		{
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B0")]
		public byte[] Buffer
		{
			[Token(Token = "0x6001A18")]
			[Address(RVA = "0x50C1340", Offset = "0x50BFF40", VA = "0x1850C1340")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x170005B1")]
		public Memory<byte> MemoryBuffer
		{
			[Token(Token = "0x6001A19")]
			[Address(RVA = "0x50C1410", Offset = "0x50C0010", VA = "0x1850C1410")]
			get
			{
				return default(Memory<byte>);
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x170005B2")]
		public int Offset
		{
			[Token(Token = "0x6001A1A")]
			[Address(RVA = "0x7CEE30", Offset = "0x7CDA30", VA = "0x1807CEE30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0000BA90 File Offset: 0x00009C90
		[Token(Token = "0x170005B3")]
		public int Count
		{
			[Token(Token = "0x6001A1B")]
			[Address(RVA = "0x4211DF0", Offset = "0x42109F0", VA = "0x184211DF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B4")]
		public IList<ArraySegment<byte>> BufferList
		{
			[Token(Token = "0x6001A1C")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x50C0D80", Offset = "0x50BF980", VA = "0x1850C0D80")]
		public void SetBuffer(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x50C0F70", Offset = "0x50BFB70", VA = "0x1850C0F70")]
		public void SetBuffer(Memory<byte> buffer)
		{
		}

		// Token: 0x040010D0 RID: 4304
		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x10")]
		private bool disposed;

		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x14")]
		internal int in_progress;

		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x18")]
		private EndPoint remote_ep;

		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x20")]
		private Socket current_socket;

		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x28")]
		internal SocketAsyncResult socket_async_result;

		// Token: 0x040010E2 RID: 4322
		[Token(Token = "0x40010E2")]
		[FieldOffset(Offset = "0x88")]
		private Memory<byte> _buffer;

		// Token: 0x040010E3 RID: 4323
		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x98")]
		private int _offset;

		// Token: 0x040010E4 RID: 4324
		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x9C")]
		private int _count;

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0xA0")]
		private bool _bufferIsExplicitArray;

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0xA8")]
		private IList<ArraySegment<byte>> _bufferList;

		// Token: 0x040010E7 RID: 4327
		[Token(Token = "0x40010E7")]
		[FieldOffset(Offset = "0xB0")]
		private List<ArraySegment<byte>> _bufferListInternal;
	}
}
