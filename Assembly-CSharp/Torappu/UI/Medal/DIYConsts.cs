using System;
using Il2CppDummyDll;

namespace Torappu.UI.Medal
{
	// Token: 0x02004925 RID: 18725
	[Token(Token = "0x2004925")]
	public static class DIYConsts
	{
		// Token: 0x0601C3B4 RID: 115636 RVA: 0x000A79B8 File Offset: 0x000A5BB8
		[Token(Token = "0x601C3B4")]
		[Address(RVA = "0x15ABA40", Offset = "0x15AA640", VA = "0x1815ABA40")]
		public static MedalSize MedalRarityToSize(MedalRarity rarity)
		{
			return MedalSize.NONE;
		}

		// Token: 0x04024EC4 RID: 151236
		[Token(Token = "0x4024EC4")]
		public const string DIY_EDIT_FRAME = "diy#edit";

		// Token: 0x04024EC5 RID: 151237
		[Token(Token = "0x4024EC5")]
		public const string DIY_DEFAULT_FRAME = "diy#default";

		// Token: 0x04024EC6 RID: 151238
		[Token(Token = "0x4024EC6")]
		public const string DIY_ENTRY_FRAME = "diy#entry";

		// Token: 0x04024EC7 RID: 151239
		[Token(Token = "0x4024EC7")]
		public const int MAX_DIY_MEDAL_COUNT = 40;

		// Token: 0x04024EC8 RID: 151240
		[Token(Token = "0x4024EC8")]
		public const string DEFAULT_DIY_INDEX = "1";
	}
}
