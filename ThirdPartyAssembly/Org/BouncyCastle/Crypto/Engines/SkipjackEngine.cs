using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200034A RID: 842
	[Token(Token = "0x200034A")]
	public class SkipjackEngine : IBlockCipher
	{
		// Token: 0x06001CAC RID: 7340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x52D8860", Offset = "0x52D7460", VA = "0x1852D8860", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F0")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001CAD")]
			[Address(RVA = "0x52D8E20", Offset = "0x52D7A20", VA = "0x1852D8E20", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0000DE48 File Offset: 0x0000C048
		[Token(Token = "0x170003F1")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001CAE")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0000DE60 File Offset: 0x0000C060
		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "13")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0000DE78 File Offset: 0x0000C078
		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x52D8C60", Offset = "0x52D7860", VA = "0x1852D8C60", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0000DE90 File Offset: 0x0000C090
		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x52D85C0", Offset = "0x52D71C0", VA = "0x1852D85C0")]
		private int G(int k, int w)
		{
			return 0;
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x52D8390", Offset = "0x52D6F90", VA = "0x1852D8390", Slot = "16")]
		public virtual int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x52D8710", Offset = "0x52D7310", VA = "0x1852D8710")]
		private int H(int k, int w)
		{
			return 0;
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x52D8160", Offset = "0x52D6D60", VA = "0x1852D8160", Slot = "17")]
		public virtual int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SkipjackEngine()
		{
		}

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		private const int BLOCK_SIZE = 8;

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly short[] ftable;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x10")]
		private int[] key0;

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x18")]
		private int[] key1;

		// Token: 0x04000F6F RID: 3951
		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x20")]
		private int[] key2;

		// Token: 0x04000F70 RID: 3952
		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x28")]
		private int[] key3;

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x30")]
		private bool encrypting;
	}
}
