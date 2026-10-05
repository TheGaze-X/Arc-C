using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000314")]
	internal class MacCFBBlockCipher : IBlockCipher
	{
		// Token: 0x06001A73 RID: 6771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x52A9C20", Offset = "0x52A8820", VA = "0x1852A9C20")]
		public MacCFBBlockCipher(IBlockCipher cipher, int bitBlockSize)
		{
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x52A9790", Offset = "0x52A8390", VA = "0x1852A9790", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B6")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001A75")]
			[Address(RVA = "0x52A9D40", Offset = "0x52A8940", VA = "0x1852A9D40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		[Token(Token = "0x170003B7")]
		public bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001A76")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "6")]
		public int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x52A9980", Offset = "0x52A8580", VA = "0x1852A9980", Slot = "8")]
		public int ProcessBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x52A9BB0", Offset = "0x52A87B0", VA = "0x1852A9BB0", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x52A9720", Offset = "0x52A8320", VA = "0x1852A9720")]
		public void GetMacBlock(byte[] mac)
		{
		}

		// Token: 0x04000DE2 RID: 3554
		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x10")]
		private byte[] IV;

		// Token: 0x04000DE3 RID: 3555
		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x18")]
		private byte[] cfbV;

		// Token: 0x04000DE4 RID: 3556
		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x20")]
		private byte[] cfbOutV;

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x28")]
		private readonly int blockSize;

		// Token: 0x04000DE6 RID: 3558
		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x30")]
		private readonly IBlockCipher cipher;
	}
}
