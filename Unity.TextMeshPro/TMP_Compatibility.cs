using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public static class TMP_Compatibility
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x58820F0", Offset = "0x5880CF0", VA = "0x1858820F0")]
		public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue)
		{
			return (TextAlignmentOptions)0;
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		public enum AnchorPositions
		{
			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000154")]
			TopLeft,
			// Token: 0x04000155 RID: 341
			[Token(Token = "0x4000155")]
			Top,
			// Token: 0x04000156 RID: 342
			[Token(Token = "0x4000156")]
			TopRight,
			// Token: 0x04000157 RID: 343
			[Token(Token = "0x4000157")]
			Left,
			// Token: 0x04000158 RID: 344
			[Token(Token = "0x4000158")]
			Center,
			// Token: 0x04000159 RID: 345
			[Token(Token = "0x4000159")]
			Right,
			// Token: 0x0400015A RID: 346
			[Token(Token = "0x400015A")]
			BottomLeft,
			// Token: 0x0400015B RID: 347
			[Token(Token = "0x400015B")]
			Bottom,
			// Token: 0x0400015C RID: 348
			[Token(Token = "0x400015C")]
			BottomRight,
			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			BaseLine,
			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			None
		}
	}
}
