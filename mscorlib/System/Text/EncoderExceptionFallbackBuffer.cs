using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000296 RID: 662
	[Token(Token = "0x2000296")]
	public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x060015AE RID: 5550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EncoderExceptionFallbackBuffer()
		{
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0000FE28 File Offset: 0x0000E028
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x4AF5DC0", Offset = "0x4AF49C0", VA = "0x184AF5DC0", Slot = "4")]
		public override bool Fallback(char charUnknown, int index)
		{
			return default(bool);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0000FE40 File Offset: 0x0000E040
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x4AF5E90", Offset = "0x4AF4A90", VA = "0x184AF5E90", Slot = "5")]
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			return default(bool);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x0000FE58 File Offset: 0x0000E058
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override char GetNextChar()
		{
			return '\0';
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0000FE70 File Offset: 0x0000E070
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool MovePrevious()
		{
			return default(bool);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x0000FE88 File Offset: 0x0000E088
		[Token(Token = "0x1700022A")]
		public override int Remaining
		{
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
			get
			{
				return 0;
			}
		}
	}
}
