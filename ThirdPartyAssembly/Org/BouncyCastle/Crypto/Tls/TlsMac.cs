using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	public class TlsMac
	{
		// Token: 0x0600166D RID: 5741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166D")]
		[Address(RVA = "0x526CB30", Offset = "0x526B730", VA = "0x18526CB30")]
		public TlsMac(TlsContext context, IDigest digest, byte[] key, int keyOff, int keyLen)
		{
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000320")]
		public virtual byte[] MacSecret
		{
			[Token(Token = "0x600166E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x17000321")]
		public virtual int Size
		{
			[Token(Token = "0x600166F")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x526C870", Offset = "0x526B470", VA = "0x18526C870", Slot = "6")]
		public virtual byte[] CalculateMac(long seqNo, byte type, byte[] message, int offset, int length)
		{
			return null;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x526C5D0", Offset = "0x526B1D0", VA = "0x18526C5D0", Slot = "7")]
		public virtual byte[] CalculateMacConstantTime(long seqNo, byte type, byte[] message, int offset, int length, int fullLength, byte[] dummyData)
		{
			return null;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x6001672")]
		[Address(RVA = "0x526CAF0", Offset = "0x526B6F0", VA = "0x18526CAF0", Slot = "8")]
		protected virtual int GetDigestBlockCount(int inputLength)
		{
			return 0;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x526CB00", Offset = "0x526B700", VA = "0x18526CB00", Slot = "9")]
		protected virtual byte[] Truncate(byte[] bs)
		{
			return null;
		}

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x10")]
		protected readonly TlsContext context;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x18")]
		protected readonly byte[] secret;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x20")]
		protected readonly IMac mac;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x28")]
		protected readonly int digestBlockSize;

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x2C")]
		protected readonly int digestOverhead;

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x30")]
		protected readonly int macLength;
	}
}
