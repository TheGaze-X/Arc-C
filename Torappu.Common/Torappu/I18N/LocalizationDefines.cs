using System;
using Il2CppDummyDll;

namespace Torappu.I18N
{
	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000241")]
	public static class LocalizationDefines
	{
		// Token: 0x04000D48 RID: 3400
		[Token(Token = "0x4000D48")]
		public const LocalizationDefines.CultureType CULTURE_TYPE = LocalizationDefines.CultureType.EN;

		// Token: 0x02000242 RID: 578
		[Token(Token = "0x2000242")]
		public enum CultureType
		{
			// Token: 0x04000D4A RID: 3402
			[Token(Token = "0x4000D4A")]
			INLAND,
			// Token: 0x04000D4B RID: 3403
			[Token(Token = "0x4000D4B")]
			JP,
			// Token: 0x04000D4C RID: 3404
			[Token(Token = "0x4000D4C")]
			KR,
			// Token: 0x04000D4D RID: 3405
			[Token(Token = "0x4000D4D")]
			EN,
			// Token: 0x04000D4E RID: 3406
			[Token(Token = "0x4000D4E")]
			TC
		}
	}
}
