using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	internal class RequestStream : Stream
	{
		// Token: 0x060016B6 RID: 5814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x5088670", Offset = "0x5087270", VA = "0x185088670")]
		internal RequestStream(Stream stream, byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x50885C0", Offset = "0x50871C0", VA = "0x1850885C0")]
		internal RequestStream(Stream stream, byte[] buffer, int offset, int length, long contentlength)
		{
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x170004EF")]
		public override bool CanRead
		{
			[Token(Token = "0x60016B8")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x170004F0")]
		public override bool CanSeek
		{
			[Token(Token = "0x60016B9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x170004F1")]
		public override bool CanWrite
		{
			[Token(Token = "0x60016BA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x0000A638 File Offset: 0x00008838
		[Token(Token = "0x170004F2")]
		public override long Length
		{
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x5088710", Offset = "0x5087310", VA = "0x185088710", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x0000A650 File Offset: 0x00008850
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F3")]
		public override long Position
		{
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x5088760", Offset = "0x5087360", VA = "0x185088760", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60016BD")]
			[Address(RVA = "0x50887B0", Offset = "0x50873B0", VA = "0x1850887B0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x24EF2B0", Offset = "0x24EDEB0", VA = "0x1824EF2B0", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0000A668 File Offset: 0x00008868
		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x5088050", Offset = "0x5086C50", VA = "0x185088050")]
		private int FillFromBuffer(byte[] buffer, int off, int count)
		{
			return 0;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0000A680 File Offset: 0x00008880
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x50883A0", Offset = "0x5086FA0", VA = "0x1850883A0", Slot = "32")]
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x5087A40", Offset = "0x5086640", VA = "0x185087A40", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			return null;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0000A698 File Offset: 0x00008898
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x5087CC0", Offset = "0x50868C0", VA = "0x185087CC0", Slot = "23")]
		public override int EndRead(IAsyncResult ares)
		{
			return 0;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x50884D0", Offset = "0x50870D0", VA = "0x1850884D0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x5088520", Offset = "0x5087120", VA = "0x185088520", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x5088570", Offset = "0x5087170", VA = "0x185088570", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x5087C70", Offset = "0x5086870", VA = "0x185087C70", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			return null;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x5088000", Offset = "0x5086C00", VA = "0x185088000", Slot = "27")]
		public override void EndWrite(IAsyncResult async_result)
		{
		}

		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] buffer;

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int offset;

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int length;

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long remaining_body;

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool disposed;

		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Stream stream;
	}
}
