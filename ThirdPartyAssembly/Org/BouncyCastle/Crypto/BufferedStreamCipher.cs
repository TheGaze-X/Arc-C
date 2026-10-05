using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	public class BufferedStreamCipher : BufferedCipherBase
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x5222AF0", Offset = "0x52216F0", VA = "0x185222AF0")]
		public BufferedStreamCipher(IStreamCipher cipher)
		{
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A1")]
		public override string AlgorithmName
		{
			[Token(Token = "0x60012E4")]
			[Address(RVA = "0x5222BB0", Offset = "0x52217B0", VA = "0x185222BB0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x52225F0", Offset = "0x52211F0", VA = "0x1852225F0", Slot = "23")]
		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "24")]
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x21DABC0", Offset = "0x21D97C0", VA = "0x1821DABC0", Slot = "25")]
		public override int GetOutputSize(int inputLen)
		{
			return 0;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x21DABC0", Offset = "0x21D97C0", VA = "0x1821DABC0", Slot = "26")]
		public override int GetUpdateOutputSize(int inputLen)
		{
			return 0;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x52227B0", Offset = "0x52213B0", VA = "0x1852227B0", Slot = "27")]
		public override byte[] ProcessByte(byte input)
		{
			return null;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x5222850", Offset = "0x5221450", VA = "0x185222850", Slot = "28")]
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x5222940", Offset = "0x5221540", VA = "0x185222940", Slot = "30")]
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x60012EC")]
		[Address(RVA = "0x5222A00", Offset = "0x5221600", VA = "0x185222A00", Slot = "32")]
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012ED")]
		[Address(RVA = "0x5222570", Offset = "0x5221170", VA = "0x185222570", Slot = "33")]
		public override byte[] DoFinal()
		{
			return null;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x52224A0", Offset = "0x52210A0", VA = "0x1852224A0", Slot = "35")]
		public override byte[] DoFinal(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x5222AA0", Offset = "0x52216A0", VA = "0x185222AA0", Slot = "39")]
		public override void Reset()
		{
		}

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x10")]
		private readonly IStreamCipher cipher;
	}
}
