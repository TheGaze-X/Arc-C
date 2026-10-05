using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200033D RID: 829
	[Token(Token = "0x200033D")]
	public class RC532Engine : IBlockCipher
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x52C7A80", Offset = "0x52C6680", VA = "0x1852C7A80")]
		public RC532Engine()
		{
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DF")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C04")]
			[Address(RVA = "0x52C7AA0", Offset = "0x52C66A0", VA = "0x1852C7AA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x0000D890 File Offset: 0x0000BA90
		[Token(Token = "0x170003E0")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001C05")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "12")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x52C73B0", Offset = "0x52C5FB0", VA = "0x1852C73B0", Slot = "13")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x52C7680", Offset = "0x52C6280", VA = "0x1852C7680", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x52C76F0", Offset = "0x52C62F0", VA = "0x1852C76F0")]
		private void SetKey(byte[] key)
		{
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x52C7140", Offset = "0x52C5D40", VA = "0x1852C7140")]
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x52C6EA0", Offset = "0x52C5AA0", VA = "0x1852C6EA0")]
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0000D908 File Offset: 0x0000BB08
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x52C76B0", Offset = "0x52C62B0", VA = "0x1852C76B0")]
		private int RotateLeft(int x, int y)
		{
			return 0;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0000D920 File Offset: 0x0000BB20
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x52C76D0", Offset = "0x52C62D0", VA = "0x1852C76D0")]
		private int RotateRight(int x, int y)
		{
			return 0;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0000D938 File Offset: 0x0000BB38
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x52C6E30", Offset = "0x52C5A30", VA = "0x1852C6E30")]
		private int BytesToWord(byte[] src, int srcOff)
		{
			return 0;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x52C79C0", Offset = "0x52C65C0", VA = "0x1852C79C0")]
		private void WordToBytes(int word, byte[] dst, int dstOff)
		{
		}

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x10")]
		private int _noRounds;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x18")]
		private int[] _S;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int P32;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int Q32;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0x20")]
		private bool forEncryption;
	}
}
