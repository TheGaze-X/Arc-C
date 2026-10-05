using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	public class OfbBlockCipher : IBlockCipher
	{
		// Token: 0x06001A22 RID: 6690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x5291FE0", Offset = "0x5290BE0", VA = "0x185291FE0")]
		public OfbBlockCipher(IBlockCipher cipher, int blockSize)
		{
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A23")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x5291AD0", Offset = "0x52906D0", VA = "0x185291AD0", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AF")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001A25")]
			[Address(RVA = "0x5292100", Offset = "0x5290D00", VA = "0x185292100", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Token(Token = "0x170003B0")]
		public bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001A26")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0000CC18 File Offset: 0x0000AE18
		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "6")]
		public int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x5291D30", Offset = "0x5290930", VA = "0x185291D30", Slot = "8")]
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x5291F60", Offset = "0x5290B60", VA = "0x185291F60", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x04000DC6 RID: 3526
		[Token(Token = "0x4000DC6")]
		[FieldOffset(Offset = "0x10")]
		private byte[] IV;

		// Token: 0x04000DC7 RID: 3527
		[Token(Token = "0x4000DC7")]
		[FieldOffset(Offset = "0x18")]
		private byte[] ofbV;

		// Token: 0x04000DC8 RID: 3528
		[Token(Token = "0x4000DC8")]
		[FieldOffset(Offset = "0x20")]
		private byte[] ofbOutV;

		// Token: 0x04000DC9 RID: 3529
		[Token(Token = "0x4000DC9")]
		[FieldOffset(Offset = "0x28")]
		private readonly int blockSize;

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000DCA")]
		[FieldOffset(Offset = "0x30")]
		private readonly IBlockCipher cipher;
	}
}
