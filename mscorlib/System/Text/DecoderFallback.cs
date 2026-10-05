using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	[System.Serializable]
	public abstract class DecoderFallback
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700021A")]
		public static DecoderFallback ReplacementFallback
		{
			[Token(Token = "0x6001565")]
			[Address(RVA = "0x4ADC530", Offset = "0x4ADB130", VA = "0x184ADC530")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700021B")]
		public static DecoderFallback ExceptionFallback
		{
			[Token(Token = "0x6001566")]
			[Address(RVA = "0x4ADC480", Offset = "0x4ADB080", VA = "0x184ADC480")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001567 RID: 5479
		[Token(Token = "0x6001567")]
		public abstract DecoderFallbackBuffer CreateFallbackBuffer();

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06001568 RID: 5480
		[Token(Token = "0x1700021C")]
		public abstract int MaxCharCount { [Token(Token = "0x6001568")] get; }

		// Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected DecoderFallback()
		{
		}

		// Token: 0x04000BE9 RID: 3049
		[Token(Token = "0x4000BE9")]
		[FieldOffset(Offset = "0x0")]
		private static DecoderFallback s_replacementFallback;

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x8")]
		private static DecoderFallback s_exceptionFallback;
	}
}
