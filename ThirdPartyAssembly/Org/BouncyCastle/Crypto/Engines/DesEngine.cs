using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000332 RID: 818
	[Token(Token = "0x2000332")]
	public class DesEngine : IBlockCipher
	{
		// Token: 0x06001B81 RID: 7041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public virtual int[] GetWorkingKey()
		{
			return null;
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x52BC170", Offset = "0x52BAD70", VA = "0x1852BC170", Slot = "11")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D0")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001B83")]
			[Address(RVA = "0x52BCA40", Offset = "0x52BB640", VA = "0x1852BCA40", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x0000D428 File Offset: 0x0000B628
		[Token(Token = "0x170003D1")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001B84")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0000D440 File Offset: 0x0000B640
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "14")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x52BC3C0", Offset = "0x52BAFC0", VA = "0x1852BC3C0", Slot = "15")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x52BBBF0", Offset = "0x52BA7F0", VA = "0x1852BBBF0")]
		protected static int[] GenerateWorkingKey(bool encrypting, byte[] key)
		{
			return null;
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x52BB730", Offset = "0x52BA330", VA = "0x1852BB730")]
		internal static void DesFunc(int[] wKey, byte[] input, int inOff, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DesEngine()
		{
		}

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		internal const int BLOCK_SIZE = 8;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0x10")]
		private int[] workingKey;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly short[] bytebit;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] bigbyte;

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] pc1;

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] totrot;

		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000EC4")]
		[FieldOffset(Offset = "0x20")]
		private static readonly byte[] pc2;

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x28")]
		private static readonly uint[] SP1;

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x30")]
		private static readonly uint[] SP2;

		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x38")]
		private static readonly uint[] SP3;

		// Token: 0x04000EC8 RID: 3784
		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x40")]
		private static readonly uint[] SP4;

		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x48")]
		private static readonly uint[] SP5;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x50")]
		private static readonly uint[] SP6;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x58")]
		private static readonly uint[] SP7;

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x60")]
		private static readonly uint[] SP8;
	}
}
