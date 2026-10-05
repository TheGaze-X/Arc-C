using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000305 RID: 773
	[Token(Token = "0x2000305")]
	public class EaxBlockCipher : IAeadBlockCipher
	{
		// Token: 0x060019C6 RID: 6598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x528A880", Offset = "0x5289480", VA = "0x18528A880")]
		public EaxBlockCipher(IBlockCipher cipher)
		{
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A9")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60019C7")]
			[Address(RVA = "0x528AA30", Offset = "0x5289630", VA = "0x18528AA30", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "18")]
		public virtual IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x4FAE970", Offset = "0x4FAD570", VA = "0x184FAE970", Slot = "19")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x5289CB0", Offset = "0x52888B0", VA = "0x185289CB0", Slot = "20")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x5289BE0", Offset = "0x52887E0", VA = "0x185289BE0")]
		private void InitCipher()
		{
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019CC")]
		[Address(RVA = "0x52896A0", Offset = "0x52882A0", VA = "0x1852896A0")]
		private void CalculateMac()
		{
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019CD")]
		[Address(RVA = "0x528A670", Offset = "0x5289270", VA = "0x18528A670", Slot = "21")]
		public virtual void Reset()
		{
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x528A680", Offset = "0x5289280", VA = "0x18528A680")]
		private void Reset(bool clearMac)
		{
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x528A210", Offset = "0x5288E10", VA = "0x18528A210", Slot = "22")]
		public virtual void ProcessAadByte(byte input)
		{
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x528A2D0", Offset = "0x5288ED0", VA = "0x18528A2D0", Slot = "23")]
		public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
		{
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0000C990 File Offset: 0x0000AB90
		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x528A3B0", Offset = "0x5288FB0", VA = "0x18528A3B0", Slot = "24")]
		public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x528A410", Offset = "0x5289010", VA = "0x18528A410", Slot = "25")]
		public virtual int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x52897A0", Offset = "0x52883A0", VA = "0x1852897A0", Slot = "26")]
		public virtual int DoFinal(byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x5289B10", Offset = "0x5288710", VA = "0x185289B10", Slot = "27")]
		public virtual byte[] GetMac()
		{
			return null;
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x5289BB0", Offset = "0x52887B0", VA = "0x185289BB0", Slot = "28")]
		public virtual int GetUpdateOutputSize(int len)
		{
			return 0;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[Token(Token = "0x60019D6")]
		[Address(RVA = "0x5289B80", Offset = "0x5288780", VA = "0x185289B80", Slot = "29")]
		public virtual int GetOutputSize(int len)
		{
			return 0;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[Token(Token = "0x60019D7")]
		[Address(RVA = "0x528A4C0", Offset = "0x52890C0", VA = "0x18528A4C0")]
		private int Process(byte b, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x60019D8")]
		[Address(RVA = "0x528A800", Offset = "0x5289400", VA = "0x18528A800")]
		private bool VerifyMac(byte[] mac, int off)
		{
			return default(bool);
		}

		// Token: 0x04000D7E RID: 3454
		[Token(Token = "0x4000D7E")]
		[FieldOffset(Offset = "0x10")]
		private SicBlockCipher cipher;

		// Token: 0x04000D7F RID: 3455
		[Token(Token = "0x4000D7F")]
		[FieldOffset(Offset = "0x18")]
		private bool forEncryption;

		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x1C")]
		private int blockSize;

		// Token: 0x04000D81 RID: 3457
		[Token(Token = "0x4000D81")]
		[FieldOffset(Offset = "0x20")]
		private IMac mac;

		// Token: 0x04000D82 RID: 3458
		[Token(Token = "0x4000D82")]
		[FieldOffset(Offset = "0x28")]
		private byte[] nonceMac;

		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		[FieldOffset(Offset = "0x30")]
		private byte[] associatedTextMac;

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0x38")]
		private byte[] macBlock;

		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x40")]
		private int macSize;

		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x48")]
		private byte[] bufBlock;

		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		[FieldOffset(Offset = "0x50")]
		private int bufOff;

		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x54")]
		private bool cipherInitialized;

		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x58")]
		private byte[] initialAssociatedText;

		// Token: 0x02000306 RID: 774
		[Token(Token = "0x2000306")]
		private enum Tag : byte
		{
			// Token: 0x04000D8B RID: 3467
			[Token(Token = "0x4000D8B")]
			N,
			// Token: 0x04000D8C RID: 3468
			[Token(Token = "0x4000D8C")]
			H,
			// Token: 0x04000D8D RID: 3469
			[Token(Token = "0x4000D8D")]
			C
		}
	}
}
