using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200033A RID: 826
	[Token(Token = "0x200033A")]
	public class RC2Engine : IBlockCipher
	{
		// Token: 0x06001BE7 RID: 7143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE7")]
		[Address(RVA = "0x52C4A90", Offset = "0x52C3690", VA = "0x1852C4A90")]
		private int[] GenerateWorkingKey(byte[] key, int bits)
		{
			return null;
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE8")]
		[Address(RVA = "0x52C4D80", Offset = "0x52C3980", VA = "0x1852C4D80", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		public virtual void Reset()
		{
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DB")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001BEA")]
			[Address(RVA = "0x52C52A0", Offset = "0x52C3EA0", VA = "0x1852C52A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0000D800 File Offset: 0x0000BA00
		[Token(Token = "0x170003DC")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001BEB")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0000D818 File Offset: 0x0000BA18
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "14")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0000D830 File Offset: 0x0000BA30
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x52C50B0", Offset = "0x52C3CB0", VA = "0x1852C50B0", Slot = "15")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0000D848 File Offset: 0x0000BA48
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x52C51E0", Offset = "0x52C3DE0", VA = "0x1852C51E0")]
		private int RotateWordLeft(int x, int y)
		{
			return 0;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x52C4580", Offset = "0x52C3180", VA = "0x1852C4580")]
		private void EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x52C40A0", Offset = "0x52C2CA0", VA = "0x1852C40A0")]
		private void DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RC2Engine()
		{
		}

		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] piTable;

		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000F04")]
		private const int BLOCK_SIZE = 8;

		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000F05")]
		[FieldOffset(Offset = "0x10")]
		private int[] workingKey;

		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000F06")]
		[FieldOffset(Offset = "0x18")]
		private bool encrypting;
	}
}
