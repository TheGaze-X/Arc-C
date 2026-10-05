using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	internal class SignerBucket : Stream
	{
		// Token: 0x06001972 RID: 6514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x5297110", Offset = "0x5295D10", VA = "0x185297110")]
		public SignerBucket(ISigner signer)
		{
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0000C618 File Offset: 0x0000A818
		[Token(Token = "0x6001973")]
		[Address(RVA = "0x5296F40", Offset = "0x5295B40", VA = "0x185296F40", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0000C630 File Offset: 0x0000A830
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x5296EF0", Offset = "0x5295AF0", VA = "0x185296EF0", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x5297090", Offset = "0x5295C90", VA = "0x185297090", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x5297030", Offset = "0x5295C30", VA = "0x185297030", Slot = "37")]
		public override void WriteByte(byte b)
		{
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x0000C648 File Offset: 0x0000A848
		[Token(Token = "0x17000399")]
		public override bool CanRead
		{
			[Token(Token = "0x6001977")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x0000C660 File Offset: 0x0000A860
		[Token(Token = "0x1700039A")]
		public override bool CanWrite
		{
			[Token(Token = "0x6001978")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x0000C678 File Offset: 0x0000A878
		[Token(Token = "0x1700039B")]
		public override bool CanSeek
		{
			[Token(Token = "0x6001979")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0000C690 File Offset: 0x0000A890
		[Token(Token = "0x1700039C")]
		public override long Length
		{
			[Token(Token = "0x600197A")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039D")]
		public override long Position
		{
			[Token(Token = "0x600197B")]
			[Address(RVA = "0x5297180", Offset = "0x5295D80", VA = "0x185297180", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600197C")]
			[Address(RVA = "0x52971D0", Offset = "0x5295DD0", VA = "0x1852971D0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x5296F90", Offset = "0x5295B90", VA = "0x185296F90", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x5296FE0", Offset = "0x5295BE0", VA = "0x185296FE0", Slot = "31")]
		public override void SetLength(long length)
		{
		}

		// Token: 0x04000D59 RID: 3417
		[Token(Token = "0x4000D59")]
		[FieldOffset(Offset = "0x28")]
		protected readonly ISigner signer;
	}
}
