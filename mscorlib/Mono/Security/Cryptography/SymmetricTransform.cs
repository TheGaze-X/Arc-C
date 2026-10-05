using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	internal abstract class SymmetricTransform : System.Security.Cryptography.ICryptoTransform, System.IDisposable
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x4AD73B0", Offset = "0x4AD5FB0", VA = "0x184AD73B0")]
		public SymmetricTransform(System.Security.Cryptography.SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x4AD6880", Offset = "0x4AD5480", VA = "0x184AD6880", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4AD6C70", Offset = "0x4AD5870", VA = "0x184AD6C70", Slot = "10")]
		private void Dispose()
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4AD61A0", Offset = "0x4AD4DA0", VA = "0x184AD61A0", Slot = "11")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x1700002C")]
		public virtual bool CanTransformMultipleBlocks
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x1700002D")]
		public virtual bool CanReuseTransform
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x1700002E")]
		public virtual int InputBlockSize
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x1700002F")]
		public virtual int OutputBlockSize
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x4AD7250", Offset = "0x4AD5E50", VA = "0x184AD7250", Slot = "16")]
		protected virtual void Transform(byte[] input, byte[] output)
		{
		}

		// Token: 0x060001CF RID: 463
		[Token(Token = "0x60001CF")]
		protected abstract void ECB(byte[] input, byte[] output);

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4AD5C00", Offset = "0x4AD4800", VA = "0x184AD5C00", Slot = "18")]
		protected virtual void CBC(byte[] input, byte[] output)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x4AD5D70", Offset = "0x4AD4970", VA = "0x184AD5D70", Slot = "19")]
		protected virtual void CFB(byte[] input, byte[] output)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x4AD6B30", Offset = "0x4AD5730", VA = "0x184AD6B30", Slot = "20")]
		protected virtual void OFB(byte[] input, byte[] output)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x4AD5F80", Offset = "0x4AD4B80", VA = "0x184AD5F80", Slot = "21")]
		protected virtual void CTS(byte[] input, byte[] output)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x4AD5FE0", Offset = "0x4AD4BE0", VA = "0x184AD5FE0")]
		private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x4AD6E40", Offset = "0x4AD5A40", VA = "0x184AD6E40", Slot = "22")]
		public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x17000030")]
		private bool KeepLastBlock
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x4AD7770", Offset = "0x4AD6370", VA = "0x184AD7770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x4AD6900", Offset = "0x4AD5500", VA = "0x184AD6900")]
		private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x4AD6B90", Offset = "0x4AD5790", VA = "0x184AD6B90")]
		private void Random(byte[] buffer, int start, int length)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x4AD6CE0", Offset = "0x4AD58E0", VA = "0x184AD6CE0")]
		private void ThrowBadPaddingException(System.Security.Cryptography.PaddingMode padding, int length, int position)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x4AD6510", Offset = "0x4AD5110", VA = "0x184AD6510", Slot = "23")]
		protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x4AD6220", Offset = "0x4AD4E20", VA = "0x184AD6220", Slot = "24")]
		protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x4AD7190", Offset = "0x4AD5D90", VA = "0x184AD7190", Slot = "25")]
		public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x10")]
		protected System.Security.Cryptography.SymmetricAlgorithm algo;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x18")]
		protected bool encrypt;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x1C")]
		protected int BlockSizeByte;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x20")]
		protected byte[] temp;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x28")]
		protected byte[] temp2;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x30")]
		private byte[] workBuff;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x38")]
		private byte[] workout;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x40")]
		protected System.Security.Cryptography.PaddingMode padmode;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x44")]
		protected int FeedBackByte;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x48")]
		private bool m_disposed;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x49")]
		protected bool lastBlock;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x50")]
		private System.Security.Cryptography.RandomNumberGenerator _rng;
	}
}
