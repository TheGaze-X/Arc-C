using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x020002F3 RID: 755
	[Token(Token = "0x20002F3")]
	public class PaddedBufferedBlockCipher : BufferedBlockCipher
	{
		// Token: 0x0600194E RID: 6478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194E")]
		[Address(RVA = "0x5293C90", Offset = "0x5292890", VA = "0x185293C90")]
		public PaddedBufferedBlockCipher(IBlockCipher cipher, IBlockCipherPadding padding)
		{
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194F")]
		[Address(RVA = "0x5293B90", Offset = "0x5292790", VA = "0x185293B90")]
		public PaddedBufferedBlockCipher(IBlockCipher cipher)
		{
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001950")]
		[Address(RVA = "0x52935A0", Offset = "0x52921A0", VA = "0x1852935A0", Slot = "23")]
		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		[Token(Token = "0x6001951")]
		[Address(RVA = "0x5293550", Offset = "0x5292150", VA = "0x185293550", Slot = "25")]
		public override int GetOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x52825D0", Offset = "0x52811D0", VA = "0x1852825D0", Slot = "26")]
		public override int GetUpdateOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x52937B0", Offset = "0x52923B0", VA = "0x1852937B0", Slot = "28")]
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0000C528 File Offset: 0x0000A728
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x5293880", Offset = "0x5292480", VA = "0x185293880", Slot = "32")]
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0000C540 File Offset: 0x0000A740
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x5293140", Offset = "0x5291D40", VA = "0x185293140", Slot = "36")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x04000D53 RID: 3411
		[Token(Token = "0x4000D53")]
		[FieldOffset(Offset = "0x28")]
		private readonly IBlockCipherPadding padding;
	}
}
