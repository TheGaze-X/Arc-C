using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Paddings;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000313 RID: 787
	[Token(Token = "0x2000313")]
	public class CbcBlockCipherMac : IMac
	{
		// Token: 0x06001A68 RID: 6760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x52A2860", Offset = "0x52A1460", VA = "0x1852A2860")]
		public CbcBlockCipherMac(IBlockCipher cipher)
		{
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x52A2650", Offset = "0x52A1250", VA = "0x1852A2650")]
		public CbcBlockCipherMac(IBlockCipher cipher, IBlockCipherPadding padding)
		{
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x52A2630", Offset = "0x52A1230", VA = "0x1852A2630")]
		public CbcBlockCipherMac(IBlockCipher cipher, int macSizeInBits)
		{
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x52A26E0", Offset = "0x52A12E0", VA = "0x1852A26E0")]
		public CbcBlockCipherMac(IBlockCipher cipher, int macSizeInBits, IBlockCipherPadding padding)
		{
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B5")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001A6C")]
			[Address(RVA = "0x52A28E0", Offset = "0x52A14E0", VA = "0x1852A28E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x52A2450", Offset = "0x52A1050", VA = "0x1852A2450", Slot = "4")]
		public void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700", Slot = "6")]
		public int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x52A2580", Offset = "0x52A1180", VA = "0x1852A2580", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x52A2020", Offset = "0x52A0C20", VA = "0x1852A2020", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0000CD98 File Offset: 0x0000AF98
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x52A2280", Offset = "0x52A0E80", VA = "0x1852A2280", Slot = "9")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x52A2510", Offset = "0x52A1110", VA = "0x1852A2510", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x10")]
		private byte[] buf;

		// Token: 0x04000DDE RID: 3550
		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x18")]
		private int bufOff;

		// Token: 0x04000DDF RID: 3551
		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x20")]
		private IBlockCipher cipher;

		// Token: 0x04000DE0 RID: 3552
		[Token(Token = "0x4000DE0")]
		[FieldOffset(Offset = "0x28")]
		private IBlockCipherPadding padding;

		// Token: 0x04000DE1 RID: 3553
		[Token(Token = "0x4000DE1")]
		[FieldOffset(Offset = "0x30")]
		private int macSize;
	}
}
