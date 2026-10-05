using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002EF RID: 751
	[Token(Token = "0x20002EF")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class ToBase64Transform : ICryptoTransform, System.IDisposable
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x000118B0 File Offset: 0x0000FAB0
		[Token(Token = "0x1700029A")]
		public int InputBlockSize
		{
			[Token(Token = "0x60018CC")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[Token(Token = "0x1700029B")]
		public int OutputBlockSize
		{
			[Token(Token = "0x60018CD")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[Token(Token = "0x1700029C")]
		public bool CanTransformMultipleBlocks
		{
			[Token(Token = "0x60018CE")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x000118F8 File Offset: 0x0000FAF8
		[Token(Token = "0x1700029D")]
		public virtual bool CanReuseTransform
		{
			[Token(Token = "0x60018CF")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00011910 File Offset: 0x0000FB10
		[Token(Token = "0x60018D0")]
		[Address(RVA = "0x4B38110", Offset = "0x4B36D10", VA = "0x184B38110", Slot = "8")]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x4B38420", Offset = "0x4B37020", VA = "0x184B38420", Slot = "9")]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x4B380A0", Offset = "0x4B36CA0", VA = "0x184B380A0", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x4B380A0", Offset = "0x4B36CA0", VA = "0x184B380A0")]
		public void Clear()
		{
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x4B2ACF0", Offset = "0x4B298F0", VA = "0x184B2ACF0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ToBase64Transform()
		{
		}
	}
}
