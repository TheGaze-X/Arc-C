using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200033E RID: 830
	[Token(Token = "0x200033E")]
	public class RC564Engine : IBlockCipher
	{
		// Token: 0x06001C12 RID: 7186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x52C7A80", Offset = "0x52C6680", VA = "0x1852C7A80")]
		public RC564Engine()
		{
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E1")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C13")]
			[Address(RVA = "0x52C8C50", Offset = "0x52C7850", VA = "0x1852C8C50", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x0000D950 File Offset: 0x0000BB50
		[Token(Token = "0x170003E2")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001C14")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0000D968 File Offset: 0x0000BB68
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x52C83C0", Offset = "0x52C6FC0", VA = "0x1852C83C0", Slot = "12")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x52C8410", Offset = "0x52C7010", VA = "0x1852C8410", Slot = "13")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0000D980 File Offset: 0x0000BB80
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x52C85F0", Offset = "0x52C71F0", VA = "0x1852C85F0", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C18")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x52C8720", Offset = "0x52C7320", VA = "0x1852C8720")]
		private void SetKey(byte[] key)
		{
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0000D998 File Offset: 0x0000BB98
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x52C7FA0", Offset = "0x52C6BA0", VA = "0x1852C7FA0")]
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x52C7B80", Offset = "0x52C6780", VA = "0x1852C7B80")]
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x52C8620", Offset = "0x52C7220", VA = "0x1852C8620")]
		private long RotateLeft(long x, long y)
		{
			return 0L;
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x52C86A0", Offset = "0x52C72A0", VA = "0x1852C86A0")]
		private long RotateRight(long x, long y)
		{
			return 0L;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x52C7AD0", Offset = "0x52C66D0", VA = "0x1852C7AD0")]
		private long BytesToWord(byte[] src, int srcOff)
		{
			return 0L;
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x52C8B10", Offset = "0x52C7710", VA = "0x1852C8B10")]
		private void WordToBytes(long word, byte[] dst, int dstOff)
		{
		}

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int wordSize;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int bytesPerWord;

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x10")]
		private int _noRounds;

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x18")]
		private long[] _S;

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly long P64;

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly long Q64;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x20")]
		private bool forEncryption;
	}
}
