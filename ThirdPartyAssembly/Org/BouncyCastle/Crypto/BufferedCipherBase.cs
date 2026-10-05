using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	public abstract class BufferedCipherBase : IBufferedCipher
	{
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060012C4 RID: 4804
		[Token(Token = "0x1700029F")]
		public abstract string AlgorithmName { [Token(Token = "0x60012C4")] get; }

		// Token: 0x060012C5 RID: 4805
		[Token(Token = "0x60012C5")]
		public abstract void Init(bool forEncryption, ICipherParameters parameters);

		// Token: 0x060012C6 RID: 4806
		[Token(Token = "0x60012C6")]
		public abstract int GetBlockSize();

		// Token: 0x060012C7 RID: 4807
		[Token(Token = "0x60012C7")]
		public abstract int GetOutputSize(int inputLen);

		// Token: 0x060012C8 RID: 4808
		[Token(Token = "0x60012C8")]
		public abstract int GetUpdateOutputSize(int inputLen);

		// Token: 0x060012C9 RID: 4809
		[Token(Token = "0x60012C9")]
		public abstract byte[] ProcessByte(byte input);

		// Token: 0x060012CA RID: 4810 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x5221B60", Offset = "0x5220760", VA = "0x185221B60", Slot = "28")]
		public virtual int ProcessByte(byte input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x5221DE0", Offset = "0x52209E0", VA = "0x185221DE0", Slot = "29")]
		public virtual byte[] ProcessBytes(byte[] input)
		{
			return null;
		}

		// Token: 0x060012CC RID: 4812
		[Token(Token = "0x60012CC")]
		public abstract byte[] ProcessBytes(byte[] input, int inOff, int length);

		// Token: 0x060012CD RID: 4813 RVA: 0x0000A638 File Offset: 0x00008838
		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x5221D50", Offset = "0x5220950", VA = "0x185221D50", Slot = "31")]
		public virtual int ProcessBytes(byte[] input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0000A650 File Offset: 0x00008850
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x5221C50", Offset = "0x5220850", VA = "0x185221C50", Slot = "32")]
		public virtual int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012CF RID: 4815
		[Token(Token = "0x60012CF")]
		public abstract byte[] DoFinal();

		// Token: 0x060012D0 RID: 4816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x52218F0", Offset = "0x52204F0", VA = "0x1852218F0", Slot = "34")]
		public virtual byte[] DoFinal(byte[] input)
		{
			return null;
		}

		// Token: 0x060012D1 RID: 4817
		[Token(Token = "0x60012D1")]
		public abstract byte[] DoFinal(byte[] input, int inOff, int length);

		// Token: 0x060012D2 RID: 4818 RVA: 0x0000A668 File Offset: 0x00008868
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x52219F0", Offset = "0x52205F0", VA = "0x1852219F0", Slot = "36")]
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0000A680 File Offset: 0x00008880
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x5221960", Offset = "0x5220560", VA = "0x185221960", Slot = "37")]
		public virtual int DoFinal(byte[] input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0000A698 File Offset: 0x00008898
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x5221AD0", Offset = "0x52206D0", VA = "0x185221AD0", Slot = "38")]
		public virtual int DoFinal(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012D5 RID: 4821
		[Token(Token = "0x60012D5")]
		public abstract void Reset();

		// Token: 0x060012D6 RID: 4822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected BufferedCipherBase()
		{
		}

		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly byte[] EmptyBuffer;
	}
}
