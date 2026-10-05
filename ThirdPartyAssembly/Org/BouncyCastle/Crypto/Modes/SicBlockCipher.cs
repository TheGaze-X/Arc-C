using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	public class SicBlockCipher : IBlockCipher
	{
		// Token: 0x06001A35 RID: 6709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x52AC270", Offset = "0x52AAE70", VA = "0x1852AC270")]
		public SicBlockCipher(IBlockCipher cipher)
		{
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public virtual IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x52ABD70", Offset = "0x52AA970", VA = "0x1852ABD70", Slot = "11")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B3")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001A38")]
			[Address(RVA = "0x52AC350", Offset = "0x52AAF50", VA = "0x1852AC350", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x170003B4")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001A39")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x52ABD20", Offset = "0x52AA920", VA = "0x1852ABD20", Slot = "14")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0x52AC090", Offset = "0x52AAC90", VA = "0x1852AC090", Slot = "15")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x52AC1F0", Offset = "0x52AADF0", VA = "0x1852AC1F0", Slot = "16")]
		public virtual void Reset()
		{
		}

		// Token: 0x04000DD2 RID: 3538
		[Token(Token = "0x4000DD2")]
		[FieldOffset(Offset = "0x10")]
		private readonly IBlockCipher cipher;

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000DD3")]
		[FieldOffset(Offset = "0x18")]
		private readonly int blockSize;

		// Token: 0x04000DD4 RID: 3540
		[Token(Token = "0x4000DD4")]
		[FieldOffset(Offset = "0x20")]
		private readonly byte[] counter;

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000DD5")]
		[FieldOffset(Offset = "0x28")]
		private readonly byte[] counterOut;

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000DD6")]
		[FieldOffset(Offset = "0x30")]
		private byte[] IV;
	}
}
