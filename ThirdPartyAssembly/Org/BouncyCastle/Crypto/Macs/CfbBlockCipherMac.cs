using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Paddings;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000315")]
	public class CfbBlockCipherMac : IMac
	{
		// Token: 0x06001A7B RID: 6779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x52A3100", Offset = "0x52A1D00", VA = "0x1852A3100")]
		public CfbBlockCipherMac(IBlockCipher cipher)
		{
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x52A3070", Offset = "0x52A1C70", VA = "0x1852A3070")]
		public CfbBlockCipherMac(IBlockCipher cipher, IBlockCipherPadding padding)
		{
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x52A3180", Offset = "0x52A1D80", VA = "0x1852A3180")]
		public CfbBlockCipherMac(IBlockCipher cipher, int cfbBitSize, int macSizeInBits)
		{
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x52A2DF0", Offset = "0x52A19F0", VA = "0x1852A2DF0")]
		public CfbBlockCipherMac(IBlockCipher cipher, int cfbBitSize, int macSizeInBits, IBlockCipherPadding padding)
		{
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B8")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001A7F")]
			[Address(RVA = "0x52A31A0", Offset = "0x52A1DA0", VA = "0x1852A31A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x52A2C90", Offset = "0x52A1890", VA = "0x1852A2C90", Slot = "4")]
		public void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "6")]
		public int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x52A2D60", Offset = "0x52A1960", VA = "0x1852A2D60", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x52A2930", Offset = "0x52A1530", VA = "0x1852A2930", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0000CE10 File Offset: 0x0000B010
		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x52A2A90", Offset = "0x52A1690", VA = "0x1852A2A90", Slot = "9")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A85")]
		[Address(RVA = "0x52A2CD0", Offset = "0x52A18D0", VA = "0x1852A2CD0", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x04000DE7 RID: 3559
		[Token(Token = "0x4000DE7")]
		[FieldOffset(Offset = "0x10")]
		private byte[] mac;

		// Token: 0x04000DE8 RID: 3560
		[Token(Token = "0x4000DE8")]
		[FieldOffset(Offset = "0x18")]
		private byte[] Buffer;

		// Token: 0x04000DE9 RID: 3561
		[Token(Token = "0x4000DE9")]
		[FieldOffset(Offset = "0x20")]
		private int bufOff;

		// Token: 0x04000DEA RID: 3562
		[Token(Token = "0x4000DEA")]
		[FieldOffset(Offset = "0x28")]
		private MacCFBBlockCipher cipher;

		// Token: 0x04000DEB RID: 3563
		[Token(Token = "0x4000DEB")]
		[FieldOffset(Offset = "0x30")]
		private IBlockCipherPadding padding;

		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000DEC")]
		[FieldOffset(Offset = "0x38")]
		private int macSize;
	}
}
