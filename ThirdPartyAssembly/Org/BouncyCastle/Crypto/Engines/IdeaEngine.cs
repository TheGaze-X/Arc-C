using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	public class IdeaEngine : IBlockCipher
	{
		// Token: 0x06001BBF RID: 7103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public IdeaEngine()
		{
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x52C0E30", Offset = "0x52BFA30", VA = "0x1852C0E30", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D7")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001BC1")]
			[Address(RVA = "0x52C19B0", Offset = "0x52C05B0", VA = "0x1852C19B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x170003D8")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001BC2")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[Token(Token = "0x6001BC3")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "13")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		[Token(Token = "0x6001BC4")]
		[Address(RVA = "0x52C17E0", Offset = "0x52C03E0", VA = "0x1852C17E0", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0000D710 File Offset: 0x0000B910
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x52C0830", Offset = "0x52BF430", VA = "0x1852C0830")]
		private int BytesToWord(byte[] input, int inOff)
		{
			return 0;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x52C1920", Offset = "0x52C0520", VA = "0x1852C1920")]
		private void WordToBytes(int word, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0000D728 File Offset: 0x0000B928
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x52C16E0", Offset = "0x52C02E0", VA = "0x1852C16E0")]
		private int Mul(int x, int y)
		{
			return 0;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x52C0A80", Offset = "0x52BF680", VA = "0x1852C0A80")]
		private void IdeaFunc(int[] workingKey, byte[] input, int inOff, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x52C0870", Offset = "0x52BF470", VA = "0x1852C0870")]
		private int[] ExpandKey(byte[] uKey)
		{
			return null;
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0000D740 File Offset: 0x0000B940
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x52C1590", Offset = "0x52C0190", VA = "0x1852C1590")]
		private int MulInv(int x)
		{
			return 0;
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0000D758 File Offset: 0x0000B958
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x52C07D0", Offset = "0x52BF3D0", VA = "0x1852C07D0")]
		private int AddInv(int x)
		{
			return 0;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x52C1070", Offset = "0x52BFC70", VA = "0x1852C1070")]
		private int[] InvertKey(int[] inKey)
		{
			return null;
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x52C0A40", Offset = "0x52BF640", VA = "0x1852C0A40")]
		private int[] GenerateWorkingKey(bool forEncryption, byte[] userKey)
		{
			return null;
		}

		// Token: 0x04000EEE RID: 3822
		[Token(Token = "0x4000EEE")]
		private const int BLOCK_SIZE = 8;

		// Token: 0x04000EEF RID: 3823
		[Token(Token = "0x4000EEF")]
		[FieldOffset(Offset = "0x10")]
		private int[] workingKey;

		// Token: 0x04000EF0 RID: 3824
		[Token(Token = "0x4000EF0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MASK;

		// Token: 0x04000EF1 RID: 3825
		[Token(Token = "0x4000EF1")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int BASE;
	}
}
