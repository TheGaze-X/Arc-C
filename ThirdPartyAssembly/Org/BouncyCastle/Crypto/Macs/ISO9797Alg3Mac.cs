using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	public class ISO9797Alg3Mac : IMac
	{
		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x52A9670", Offset = "0x52A8270", VA = "0x1852A9670")]
		public ISO9797Alg3Mac(IBlockCipher cipher)
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x52A9360", Offset = "0x52A7F60", VA = "0x1852A9360")]
		public ISO9797Alg3Mac(IBlockCipher cipher, IBlockCipherPadding padding)
		{
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x52A9650", Offset = "0x52A8250", VA = "0x1852A9650")]
		public ISO9797Alg3Mac(IBlockCipher cipher, int macSizeInBits)
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x52A93F0", Offset = "0x52A7FF0", VA = "0x1852A93F0")]
		public ISO9797Alg3Mac(IBlockCipher cipher, int macSizeInBits, IBlockCipherPadding padding)
		{
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BC")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001AAD")]
			[Address(RVA = "0x52A96F0", Offset = "0x52A82F0", VA = "0x1852A96F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x52A8B50", Offset = "0x52A7750", VA = "0x1852A8B50", Slot = "4")]
		public void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0000CF00 File Offset: 0x0000B100
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "6")]
		public int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0x52A92B0", Offset = "0x52A7EB0", VA = "0x1852A92B0", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB1")]
		[Address(RVA = "0x52A85F0", Offset = "0x52A71F0", VA = "0x1852A85F0", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0000CF18 File Offset: 0x0000B118
		[Token(Token = "0x6001AB2")]
		[Address(RVA = "0x52A8860", Offset = "0x52A7460", VA = "0x1852A8860", Slot = "9")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB3")]
		[Address(RVA = "0x52A9240", Offset = "0x52A7E40", VA = "0x1852A9240", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x04000E09 RID: 3593
		[Token(Token = "0x4000E09")]
		[FieldOffset(Offset = "0x10")]
		private byte[] mac;

		// Token: 0x04000E0A RID: 3594
		[Token(Token = "0x4000E0A")]
		[FieldOffset(Offset = "0x18")]
		private byte[] buf;

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x20")]
		private int bufOff;

		// Token: 0x04000E0C RID: 3596
		[Token(Token = "0x4000E0C")]
		[FieldOffset(Offset = "0x28")]
		private IBlockCipher cipher;

		// Token: 0x04000E0D RID: 3597
		[Token(Token = "0x4000E0D")]
		[FieldOffset(Offset = "0x30")]
		private IBlockCipherPadding padding;

		// Token: 0x04000E0E RID: 3598
		[Token(Token = "0x4000E0E")]
		[FieldOffset(Offset = "0x38")]
		private int macSize;

		// Token: 0x04000E0F RID: 3599
		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x40")]
		private KeyParameter lastKey2;

		// Token: 0x04000E10 RID: 3600
		[Token(Token = "0x4000E10")]
		[FieldOffset(Offset = "0x48")]
		private KeyParameter lastKey3;
	}
}
