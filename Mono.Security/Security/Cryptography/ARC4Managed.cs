using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public class ARC4Managed : RC4, ICryptoTransform, IDisposable
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x4A908E0", Offset = "0x4A8F4E0", VA = "0x184A908E0")]
		public ARC4Managed()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x4A90180", Offset = "0x4A8ED80", VA = "0x184A90180", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x4A900B0", Offset = "0x4A8ECB0", VA = "0x184A900B0", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007B")]
		public override byte[] Key
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x4A909E0", Offset = "0x4A8F5E0", VA = "0x184A909E0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x4A90A90", Offset = "0x4A8F690", VA = "0x184A90A90", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x1700007C")]
		public bool CanReuseTransform
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4A90060", Offset = "0x4A8EC60", VA = "0x184A90060", Slot = "23")]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV)
		{
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x4A8FFF0", Offset = "0x4A8EBF0", VA = "0x184A8FFF0", Slot = "25")]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV)
		{
			return null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x4A90200", Offset = "0x4A8EE00", VA = "0x184A90200", Slot = "27")]
		public override void GenerateIV()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4A90270", Offset = "0x4A8EE70", VA = "0x184A90270", Slot = "26")]
		public override void GenerateKey()
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x1700007D")]
		public bool CanTransformMultipleBlocks
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x1700007E")]
		public int InputBlockSize
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "28")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x1700007F")]
		public int OutputBlockSize
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "29")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4A904D0", Offset = "0x4A8F0D0", VA = "0x184A904D0")]
		private void KeySetup(byte[] key)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x4A8FE30", Offset = "0x4A8EA30", VA = "0x184A8FE30")]
		private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4A905B0", Offset = "0x4A8F1B0", VA = "0x184A905B0", Slot = "32")]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4A90380", Offset = "0x4A8EF80", VA = "0x184A90380")]
		private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4A90760", Offset = "0x4A8F360", VA = "0x184A90760", Slot = "33")]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x48")]
		private byte[] key;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x50")]
		private byte[] state;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x58")]
		private byte x;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x59")]
		private byte y;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_disposed;
	}
}
