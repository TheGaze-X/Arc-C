using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200033F RID: 831
	[Token(Token = "0x200033F")]
	public class RC6Engine : IBlockCipher
	{
		// Token: 0x06001C21 RID: 7201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RC6Engine()
		{
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E3")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C22")]
			[Address(RVA = "0x52CA640", Offset = "0x52C9240", VA = "0x1852CA640", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x0000DA10 File Offset: 0x0000BC10
		[Token(Token = "0x170003E4")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001C23")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x52C9C90", Offset = "0x52C8890", VA = "0x1852C9C90", Slot = "12")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C25")]
		[Address(RVA = "0x52C9CF0", Offset = "0x52C88F0", VA = "0x1852C9CF0", Slot = "13")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0000DA40 File Offset: 0x0000BC40
		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x52C9EA0", Offset = "0x52C8AA0", VA = "0x1852C9EA0", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x52CA0F0", Offset = "0x52C8CF0", VA = "0x1852CA0F0")]
		private void SetKey(byte[] key)
		{
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0000DA58 File Offset: 0x0000BC58
		[Token(Token = "0x6001C29")]
		[Address(RVA = "0x52C94D0", Offset = "0x52C80D0", VA = "0x1852C94D0")]
		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0000DA70 File Offset: 0x0000BC70
		[Token(Token = "0x6001C2A")]
		[Address(RVA = "0x52C8D30", Offset = "0x52C7930", VA = "0x1852C8D30")]
		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[Token(Token = "0x6001C2B")]
		[Address(RVA = "0x52C9FF0", Offset = "0x52C8BF0", VA = "0x1852C9FF0")]
		private int RotateLeft(int x, int y)
		{
			return 0;
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		[Token(Token = "0x6001C2C")]
		[Address(RVA = "0x52CA070", Offset = "0x52C8C70", VA = "0x1852CA070")]
		private int RotateRight(int x, int y)
		{
			return 0;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		[Token(Token = "0x6001C2D")]
		[Address(RVA = "0x52C8C80", Offset = "0x52C7880", VA = "0x1852C8C80")]
		private int BytesToWord(byte[] src, int srcOff)
		{
			return 0;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2E")]
		[Address(RVA = "0x52CA4E0", Offset = "0x52C90E0", VA = "0x1852CA4E0")]
		private void WordToBytes(int word, byte[] dst, int dstOff)
		{
		}

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int wordSize;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int bytesPerWord;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _noRounds;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x10")]
		private int[] _S;

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int P32;

		// Token: 0x04000F26 RID: 3878
		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int Q32;

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int LGW;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0x18")]
		private bool forEncryption;
	}
}
