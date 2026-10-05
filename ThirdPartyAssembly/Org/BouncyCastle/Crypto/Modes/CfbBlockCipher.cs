using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000303 RID: 771
	[Token(Token = "0x2000303")]
	public class CfbBlockCipher : IBlockCipher
	{
		// Token: 0x060019B6 RID: 6582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x5281C30", Offset = "0x5280830", VA = "0x185281C30")]
		public CfbBlockCipher(IBlockCipher cipher, int bitBlockSize)
		{
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x5281970", Offset = "0x5280570", VA = "0x185281970", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A7")]
		public string AlgorithmName
		{
			[Token(Token = "0x60019B9")]
			[Address(RVA = "0x5281D50", Offset = "0x5280950", VA = "0x185281D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x170003A8")]
		public bool IsPartialBlockOkay
		{
			[Token(Token = "0x60019BA")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0", Slot = "6")]
		public int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x5281B80", Offset = "0x5280780", VA = "0x185281B80", Slot = "8")]
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x5281740", Offset = "0x5280340", VA = "0x185281740")]
		public int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x5281520", Offset = "0x5280120", VA = "0x185281520")]
		public int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x5281BB0", Offset = "0x52807B0", VA = "0x185281BB0", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x04000D77 RID: 3447
		[Token(Token = "0x4000D77")]
		[FieldOffset(Offset = "0x10")]
		private byte[] IV;

		// Token: 0x04000D78 RID: 3448
		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x18")]
		private byte[] cfbV;

		// Token: 0x04000D79 RID: 3449
		[Token(Token = "0x4000D79")]
		[FieldOffset(Offset = "0x20")]
		private byte[] cfbOutV;

		// Token: 0x04000D7A RID: 3450
		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x28")]
		private bool encrypting;

		// Token: 0x04000D7B RID: 3451
		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x2C")]
		private readonly int blockSize;

		// Token: 0x04000D7C RID: 3452
		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x30")]
		private readonly IBlockCipher cipher;
	}
}
