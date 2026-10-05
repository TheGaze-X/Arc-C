using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000308 RID: 776
	[Token(Token = "0x2000308")]
	public class GOfbBlockCipher : IBlockCipher
	{
		// Token: 0x060019F1 RID: 6641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x528BC40", Offset = "0x528A840", VA = "0x18528BC40")]
		public GOfbBlockCipher(IBlockCipher cipher)
		{
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F2")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x528B5C0", Offset = "0x528A1C0", VA = "0x18528B5C0", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AB")]
		public string AlgorithmName
		{
			[Token(Token = "0x60019F4")]
			[Address(RVA = "0x528BE30", Offset = "0x528AA30", VA = "0x18528BE30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		[Token(Token = "0x170003AC")]
		public bool IsPartialBlockOkay
		{
			[Token(Token = "0x60019F5")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "6")]
		public int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[Token(Token = "0x60019F7")]
		[Address(RVA = "0x528B830", Offset = "0x528A430", VA = "0x18528B830", Slot = "8")]
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x528BBC0", Offset = "0x528A7C0", VA = "0x18528BBC0", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x60019F9")]
		[Address(RVA = "0x528BDB0", Offset = "0x528A9B0", VA = "0x18528BDB0")]
		private int bytesToint(byte[] inBytes, int inOff)
		{
			return 0;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x528BEA0", Offset = "0x528AAA0", VA = "0x18528BEA0")]
		private void intTobytes(int num, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x04000DA5 RID: 3493
		[Token(Token = "0x4000DA5")]
		[FieldOffset(Offset = "0x10")]
		private byte[] IV;

		// Token: 0x04000DA6 RID: 3494
		[Token(Token = "0x4000DA6")]
		[FieldOffset(Offset = "0x18")]
		private byte[] ofbV;

		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		[FieldOffset(Offset = "0x20")]
		private byte[] ofbOutV;

		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		[FieldOffset(Offset = "0x28")]
		private readonly int blockSize;

		// Token: 0x04000DA9 RID: 3497
		[Token(Token = "0x4000DA9")]
		[FieldOffset(Offset = "0x30")]
		private readonly IBlockCipher cipher;

		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x38")]
		private bool firstStep;

		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x3C")]
		private int N3;

		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x40")]
		private int N4;

		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4000DAD")]
		private const int C1 = 16843012;

		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4000DAE")]
		private const int C2 = 16843009;
	}
}
