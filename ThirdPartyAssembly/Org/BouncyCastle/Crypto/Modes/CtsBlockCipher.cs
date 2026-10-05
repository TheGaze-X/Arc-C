using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000304")]
	public class CtsBlockCipher : BufferedBlockCipher
	{
		// Token: 0x060019C0 RID: 6592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x5282AB0", Offset = "0x52816B0", VA = "0x185282AB0")]
		public CtsBlockCipher(IBlockCipher cipher)
		{
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0000C900 File Offset: 0x0000AB00
		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x52825D0", Offset = "0x52811D0", VA = "0x1852825D0", Slot = "26")]
		public override int GetUpdateOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x5220E30", Offset = "0x521FA30", VA = "0x185220E30", Slot = "25")]
		public override int GetOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0000C930 File Offset: 0x0000AB30
		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x5282610", Offset = "0x5281210", VA = "0x185282610", Slot = "28")]
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x5282700", Offset = "0x5281300", VA = "0x185282700", Slot = "32")]
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x5281FE0", Offset = "0x5280BE0", VA = "0x185281FE0", Slot = "36")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x04000D7D RID: 3453
		[Token(Token = "0x4000D7D")]
		[FieldOffset(Offset = "0x28")]
		private readonly int blockSize;
	}
}
