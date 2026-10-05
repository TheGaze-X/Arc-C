using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000241")]
	public class ByteQueueStream : Stream
	{
		// Token: 0x06001427 RID: 5159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001427")]
		[Address(RVA = "0x5241EE0", Offset = "0x5240AE0", VA = "0x185241EE0")]
		public ByteQueueStream()
		{
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0000AA28 File Offset: 0x00008C28
		[Token(Token = "0x170002CB")]
		public virtual int Available
		{
			[Token(Token = "0x6001428")]
			[Address(RVA = "0x5241FB0", Offset = "0x5240BB0", VA = "0x185241FB0", Slot = "38")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0000AA40 File Offset: 0x00008C40
		[Token(Token = "0x170002CC")]
		public override bool CanRead
		{
			[Token(Token = "0x6001429")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0000AA58 File Offset: 0x00008C58
		[Token(Token = "0x170002CD")]
		public override bool CanSeek
		{
			[Token(Token = "0x600142A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0000AA70 File Offset: 0x00008C70
		[Token(Token = "0x170002CE")]
		public override bool CanWrite
		{
			[Token(Token = "0x600142B")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0000AA88 File Offset: 0x00008C88
		[Token(Token = "0x170002CF")]
		public override long Length
		{
			[Token(Token = "0x600142D")]
			[Address(RVA = "0x5241FD0", Offset = "0x5240BD0", VA = "0x185241FD0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x600142E")]
		[Address(RVA = "0x5241A20", Offset = "0x5240620", VA = "0x185241A20", Slot = "39")]
		public virtual int Peek(byte[] buf)
		{
			return 0;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D0")]
		public override long Position
		{
			[Token(Token = "0x600142F")]
			[Address(RVA = "0x5242020", Offset = "0x5240C20", VA = "0x185242020", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001430")]
			[Address(RVA = "0x5242070", Offset = "0x5240C70", VA = "0x185242070", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x5241C40", Offset = "0x5240840", VA = "0x185241C40", Slot = "40")]
		public virtual int Read(byte[] buf)
		{
			return 0;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		[Token(Token = "0x6001432")]
		[Address(RVA = "0x5241B70", Offset = "0x5240770", VA = "0x185241B70", Slot = "32")]
		public override int Read(byte[] buf, int off, int len)
		{
			return 0;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0000AB00 File Offset: 0x00008D00
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x5241AC0", Offset = "0x52406C0", VA = "0x185241AC0", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0000AB18 File Offset: 0x00008D18
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x5241CB0", Offset = "0x52408B0", VA = "0x185241CB0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x5241D00", Offset = "0x5240900", VA = "0x185241D00", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0000AB30 File Offset: 0x00008D30
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x5241D50", Offset = "0x5240950", VA = "0x185241D50", Slot = "41")]
		public virtual int Skip(int n)
		{
			return 0;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x5241E70", Offset = "0x5240A70", VA = "0x185241E70", Slot = "42")]
		public virtual void Write(byte[] buf)
		{
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x5241EB0", Offset = "0x5240AB0", VA = "0x185241EB0", Slot = "35")]
		public override void Write(byte[] buf, int off, int len)
		{
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001439")]
		[Address(RVA = "0x5241DE0", Offset = "0x52409E0", VA = "0x185241DE0", Slot = "37")]
		public override void WriteByte(byte b)
		{
		}

		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x40009B1")]
		[FieldOffset(Offset = "0x28")]
		private readonly ByteQueue buffer;
	}
}
