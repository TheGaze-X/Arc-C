using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x0600155D RID: 5469 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x4ADB9A0", Offset = "0x4ADA5A0", VA = "0x184ADB9A0", Slot = "4")]
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			return default(bool);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
		public override char GetNextChar()
		{
			return '\0';
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x0000FB10 File Offset: 0x0000DD10
		[Token(Token = "0x17000219")]
		public override int Remaining
		{
			[Token(Token = "0x600155F")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x4ADB9B0", Offset = "0x4ADA5B0", VA = "0x184ADB9B0")]
		private void Throw(byte[] bytesUnknown, int index)
		{
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DecoderExceptionFallbackBuffer()
		{
		}
	}
}
