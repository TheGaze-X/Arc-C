using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x20002F0")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class FromBase64Transform : ICryptoTransform, System.IDisposable
	{
		// Token: 0x060018D7 RID: 6359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x4B2B5A0", Offset = "0x4B2A1A0", VA = "0x184B2B5A0")]
		public FromBase64Transform()
		{
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x4B2B600", Offset = "0x4B2A200", VA = "0x184B2B600")]
		public FromBase64Transform(FromBase64TransformMode whitespaces)
		{
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x00011928 File Offset: 0x0000FB28
		[Token(Token = "0x1700029E")]
		public int InputBlockSize
		{
			[Token(Token = "0x60018D9")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x00011940 File Offset: 0x0000FB40
		[Token(Token = "0x1700029F")]
		public int OutputBlockSize
		{
			[Token(Token = "0x60018DA")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x00011958 File Offset: 0x0000FB58
		[Token(Token = "0x170002A0")]
		public bool CanTransformMultipleBlocks
		{
			[Token(Token = "0x60018DB")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x00011970 File Offset: 0x0000FB70
		[Token(Token = "0x170002A1")]
		public virtual bool CanReuseTransform
		{
			[Token(Token = "0x60018DC")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00011988 File Offset: 0x0000FB88
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x4B2AD70", Offset = "0x4B29970", VA = "0x184B2AD70", Slot = "8")]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x4B2B190", Offset = "0x4B29D90", VA = "0x184B2B190", Slot = "9")]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x4B2AB30", Offset = "0x4B29730", VA = "0x184B2AB30")]
		private byte[] DiscardWhiteSpaces(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x4B2AAC0", Offset = "0x4B296C0", VA = "0x184B2AAC0", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x1FC1100", Offset = "0x1FBFD00", VA = "0x181FC1100")]
		private void Reset()
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x4B2AAC0", Offset = "0x4B296C0", VA = "0x184B2AAC0")]
		public void Clear()
		{
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x4B2ACA0", Offset = "0x4B298A0", VA = "0x184B2ACA0", Slot = "12")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x4B2ACF0", Offset = "0x4B298F0", VA = "0x184B2ACF0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x04000DA0 RID: 3488
		[Token(Token = "0x4000DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] _inputBuffer;

		// Token: 0x04000DA1 RID: 3489
		[Token(Token = "0x4000DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _inputIndex;

		// Token: 0x04000DA2 RID: 3490
		[Token(Token = "0x4000DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private FromBase64TransformMode _whitespaces;
	}
}
