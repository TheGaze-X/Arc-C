using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	public class OpenPgpCfbBlockCipher : IBlockCipher
	{
		// Token: 0x06001A2A RID: 6698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x5292FF0", Offset = "0x5291BF0", VA = "0x185292FF0")]
		public OpenPgpCfbBlockCipher(IBlockCipher cipher)
		{
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B1")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001A2C")]
			[Address(RVA = "0x52930D0", Offset = "0x5291CD0", VA = "0x1852930D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0000CC48 File Offset: 0x0000AE48
		[Token(Token = "0x170003B2")]
		public bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001A2D")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0000CC60 File Offset: 0x0000AE60
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x5292C80", Offset = "0x5291880", VA = "0x185292C80", Slot = "6")]
		public int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0x5292F40", Offset = "0x5291B40", VA = "0x185292F40", Slot = "8")]
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x5292F70", Offset = "0x5291B70", VA = "0x185292F70", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A31")]
		[Address(RVA = "0x5292CD0", Offset = "0x52918D0", VA = "0x185292CD0", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x5292C50", Offset = "0x5291850", VA = "0x185292C50")]
		private byte EncryptByte(byte data, int blockOff)
		{
			return 0;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x5292710", Offset = "0x5291310", VA = "0x185292710")]
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x5292190", Offset = "0x5290D90", VA = "0x185292190")]
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000DCB")]
		[FieldOffset(Offset = "0x10")]
		private byte[] IV;

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000DCC")]
		[FieldOffset(Offset = "0x18")]
		private byte[] FR;

		// Token: 0x04000DCD RID: 3533
		[Token(Token = "0x4000DCD")]
		[FieldOffset(Offset = "0x20")]
		private byte[] FRE;

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000DCE")]
		[FieldOffset(Offset = "0x28")]
		private readonly IBlockCipher cipher;

		// Token: 0x04000DCF RID: 3535
		[Token(Token = "0x4000DCF")]
		[FieldOffset(Offset = "0x30")]
		private readonly int blockSize;

		// Token: 0x04000DD0 RID: 3536
		[Token(Token = "0x4000DD0")]
		[FieldOffset(Offset = "0x34")]
		private int count;

		// Token: 0x04000DD1 RID: 3537
		[Token(Token = "0x4000DD1")]
		[FieldOffset(Offset = "0x38")]
		private bool forEncryption;
	}
}
