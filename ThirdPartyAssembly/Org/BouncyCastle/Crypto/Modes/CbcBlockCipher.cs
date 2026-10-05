using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	public class CbcBlockCipher : IBlockCipher
	{
		// Token: 0x06001998 RID: 6552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001998")]
		[Address(RVA = "0x527F890", Offset = "0x527E490", VA = "0x18527F890")]
		public CbcBlockCipher(IBlockCipher cipher)
		{
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001999")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600199A")]
		[Address(RVA = "0x527F250", Offset = "0x527DE50", VA = "0x18527F250", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A4")]
		public string AlgorithmName
		{
			[Token(Token = "0x600199B")]
			[Address(RVA = "0x527F970", Offset = "0x527E570", VA = "0x18527F970", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x0000C720 File Offset: 0x0000A920
		[Token(Token = "0x170003A5")]
		public bool IsPartialBlockOkay
		{
			[Token(Token = "0x600199C")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0000C738 File Offset: 0x0000A938
		[Token(Token = "0x600199D")]
		[Address(RVA = "0x527F200", Offset = "0x527DE00", VA = "0x18527F200", Slot = "6")]
		public int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0000C750 File Offset: 0x0000A950
		[Token(Token = "0x600199E")]
		[Address(RVA = "0x527F520", Offset = "0x527E120", VA = "0x18527F520", Slot = "8")]
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600199F")]
		[Address(RVA = "0x527F800", Offset = "0x527E400", VA = "0x18527F800", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0x527F090", Offset = "0x527DC90", VA = "0x18527F090")]
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x60019A1")]
		[Address(RVA = "0x527EF00", Offset = "0x527DB00", VA = "0x18527EF00")]
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x04000D67 RID: 3431
		[Token(Token = "0x4000D67")]
		[FieldOffset(Offset = "0x10")]
		private byte[] IV;

		// Token: 0x04000D68 RID: 3432
		[Token(Token = "0x4000D68")]
		[FieldOffset(Offset = "0x18")]
		private byte[] cbcV;

		// Token: 0x04000D69 RID: 3433
		[Token(Token = "0x4000D69")]
		[FieldOffset(Offset = "0x20")]
		private byte[] cbcNextV;

		// Token: 0x04000D6A RID: 3434
		[Token(Token = "0x4000D6A")]
		[FieldOffset(Offset = "0x28")]
		private int blockSize;

		// Token: 0x04000D6B RID: 3435
		[Token(Token = "0x4000D6B")]
		[FieldOffset(Offset = "0x30")]
		private IBlockCipher cipher;

		// Token: 0x04000D6C RID: 3436
		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0x38")]
		private bool encrypting;
	}
}
