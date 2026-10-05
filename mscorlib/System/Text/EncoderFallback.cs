using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2000298")]
	[System.Serializable]
	public abstract class EncoderFallback
	{
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700022B")]
		public static EncoderFallback ReplacementFallback
		{
			[Token(Token = "0x60015B8")]
			[Address(RVA = "0x4AF6900", Offset = "0x4AF5500", VA = "0x184AF6900")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700022C")]
		public static EncoderFallback ExceptionFallback
		{
			[Token(Token = "0x60015B9")]
			[Address(RVA = "0x4AF6850", Offset = "0x4AF5450", VA = "0x184AF6850")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015BA RID: 5562
		[Token(Token = "0x60015BA")]
		public abstract EncoderFallbackBuffer CreateFallbackBuffer();

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060015BB RID: 5563
		[Token(Token = "0x1700022D")]
		public abstract int MaxCharCount { [Token(Token = "0x60015BB")] get; }

		// Token: 0x060015BC RID: 5564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected EncoderFallback()
		{
		}

		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x0")]
		private static EncoderFallback s_replacementFallback;

		// Token: 0x04000C03 RID: 3075
		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x8")]
		private static EncoderFallback s_exceptionFallback;
	}
}
