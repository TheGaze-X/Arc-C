using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200029C RID: 668
	[Token(Token = "0x200029C")]
	public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x060015DE RID: 5598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x4AF7C80", Offset = "0x4AF6880", VA = "0x184AF7C80")]
		public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
		{
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x4AF7AA0", Offset = "0x4AF66A0", VA = "0x184AF7AA0", Slot = "4")]
		public override bool Fallback(char charUnknown, int index)
		{
			return default(bool);
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x4AF7840", Offset = "0x4AF6440", VA = "0x184AF7840", Slot = "5")]
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			return default(bool);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x4AF7BF0", Offset = "0x4AF67F0", VA = "0x184AF7BF0", Slot = "6")]
		public override char GetNextChar()
		{
			return '\0';
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x4AF7C40", Offset = "0x4AF6840", VA = "0x184AF7C40", Slot = "7")]
		public override bool MovePrevious()
		{
			return default(bool);
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00010008 File Offset: 0x0000E208
		[Token(Token = "0x17000234")]
		public override int Remaining
		{
			[Token(Token = "0x60015E3")]
			[Address(RVA = "0x4AF7CE0", Offset = "0x4AF68E0", VA = "0x184AF7CE0", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x4AF7C60", Offset = "0x4AF6860", VA = "0x184AF7C60", Slot = "9")]
		public override void Reset()
		{
		}

		// Token: 0x04000C12 RID: 3090
		[Token(Token = "0x4000C12")]
		[FieldOffset(Offset = "0x30")]
		private string _strDefault;

		// Token: 0x04000C13 RID: 3091
		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0x38")]
		private int _fallbackCount;

		// Token: 0x04000C14 RID: 3092
		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0x3C")]
		private int _fallbackIndex;
	}
}
