using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200020E RID: 526
	[Token(Token = "0x200020E")]
	public class BufferedBlockCipher : BufferedCipherBase
	{
		// Token: 0x060012B5 RID: 4789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x5221740", Offset = "0x5220340", VA = "0x185221740")]
		protected BufferedBlockCipher()
		{
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x5221790", Offset = "0x5220390", VA = "0x185221790")]
		public BufferedBlockCipher(IBlockCipher cipher)
		{
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029E")]
		public override string AlgorithmName
		{
			[Token(Token = "0x60012B7")]
			[Address(RVA = "0x52218A0", Offset = "0x52204A0", VA = "0x1852218A0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x5220E70", Offset = "0x521FA70", VA = "0x185220E70", Slot = "23")]
		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x5220DE0", Offset = "0x521F9E0", VA = "0x185220DE0", Slot = "24")]
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x5220E40", Offset = "0x521FA40", VA = "0x185220E40", Slot = "26")]
		public override int GetUpdateOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x60012BB")]
		[Address(RVA = "0x5220E30", Offset = "0x521FA30", VA = "0x185220E30", Slot = "25")]
		public override int GetOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x60012BC")]
		[Address(RVA = "0x5221080", Offset = "0x521FC80", VA = "0x185221080", Slot = "28")]
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x5220F70", Offset = "0x521FB70", VA = "0x185220F70", Slot = "27")]
		public override byte[] ProcessByte(byte input)
		{
			return null;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x52211A0", Offset = "0x521FDA0", VA = "0x1852211A0", Slot = "30")]
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x5221310", Offset = "0x521FF10", VA = "0x185221310", Slot = "32")]
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x5220990", Offset = "0x521F590", VA = "0x185220990", Slot = "33")]
		public override byte[] DoFinal()
		{
			return null;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x52207B0", Offset = "0x521F3B0", VA = "0x1852207B0", Slot = "35")]
		public override byte[] DoFinal(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x5220AF0", Offset = "0x521F6F0", VA = "0x185220AF0", Slot = "36")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x52216D0", Offset = "0x52202D0", VA = "0x1852216D0", Slot = "39")]
		public override void Reset()
		{
		}

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0x10")]
		internal byte[] buf;

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x18")]
		internal int bufOff;

		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0x1C")]
		internal bool forEncryption;

		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x20")]
		internal IBlockCipher cipher;
	}
}
