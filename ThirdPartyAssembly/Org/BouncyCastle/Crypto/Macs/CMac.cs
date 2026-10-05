using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	public class CMac : IMac
	{
		// Token: 0x06001A86 RID: 6790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A86")]
		[Address(RVA = "0x52A1F60", Offset = "0x52A0B60", VA = "0x1852A1F60")]
		public CMac(IBlockCipher cipher)
		{
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x52A1C50", Offset = "0x52A0850", VA = "0x1852A1C50")]
		public CMac(IBlockCipher cipher, int macSizeInBits)
		{
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B9")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001A88")]
			[Address(RVA = "0x52A1FD0", Offset = "0x52A0BD0", VA = "0x1852A1FD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0000CE28 File Offset: 0x0000B028
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x52A1B40", Offset = "0x52A0740", VA = "0x1852A1B40")]
		private static int ShiftLeft(byte[] block, byte[] output)
		{
			return 0;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x52A17B0", Offset = "0x52A03B0", VA = "0x1852A17B0")]
		private static byte[] DoubleLu(byte[] input)
		{
			return null;
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x52A18A0", Offset = "0x52A04A0", VA = "0x1852A18A0", Slot = "4")]
		public void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0000CE40 File Offset: 0x0000B040
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "6")]
		public int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x52A1BA0", Offset = "0x52A07A0", VA = "0x1852A1BA0", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x52A1370", Offset = "0x529FF70", VA = "0x1852A1370", Slot = "8")]
		public void BlockUpdate(byte[] inBytes, int inOff, int len)
		{
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0000CE58 File Offset: 0x0000B058
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x52A15D0", Offset = "0x52A01D0", VA = "0x1852A15D0", Slot = "9")]
		public int DoFinal(byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x52A1AD0", Offset = "0x52A06D0", VA = "0x1852A1AD0", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000DED")]
		private const byte CONSTANT_128 = 135;

		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000DEE")]
		private const byte CONSTANT_64 = 27;

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		[FieldOffset(Offset = "0x10")]
		private byte[] ZEROES;

		// Token: 0x04000DF0 RID: 3568
		[Token(Token = "0x4000DF0")]
		[FieldOffset(Offset = "0x18")]
		private byte[] mac;

		// Token: 0x04000DF1 RID: 3569
		[Token(Token = "0x4000DF1")]
		[FieldOffset(Offset = "0x20")]
		private byte[] buf;

		// Token: 0x04000DF2 RID: 3570
		[Token(Token = "0x4000DF2")]
		[FieldOffset(Offset = "0x28")]
		private int bufOff;

		// Token: 0x04000DF3 RID: 3571
		[Token(Token = "0x4000DF3")]
		[FieldOffset(Offset = "0x30")]
		private IBlockCipher cipher;

		// Token: 0x04000DF4 RID: 3572
		[Token(Token = "0x4000DF4")]
		[FieldOffset(Offset = "0x38")]
		private int macSize;

		// Token: 0x04000DF5 RID: 3573
		[Token(Token = "0x4000DF5")]
		[FieldOffset(Offset = "0x40")]
		private byte[] L;

		// Token: 0x04000DF6 RID: 3574
		[Token(Token = "0x4000DF6")]
		[FieldOffset(Offset = "0x48")]
		private byte[] Lu;

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x50")]
		private byte[] Lu2;
	}
}
