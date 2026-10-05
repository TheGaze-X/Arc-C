using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001198 RID: 4504
	[Token(Token = "0x2001198")]
	public class RoguelikeTotemModuleConsts
	{
		// Token: 0x06006F85 RID: 28549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F85")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTotemModuleConsts()
		{
		}

		// Token: 0x04006074 RID: 24692
		[Token(Token = "0x4006074")]
		[FieldOffset(Offset = "0x10")]
		public string totemPredictDescription;

		// Token: 0x04006075 RID: 24693
		[Token(Token = "0x4006075")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<RoguelikeTotemColorType, string> colorCombineDesc;

		// Token: 0x04006076 RID: 24694
		[Token(Token = "0x4006076")]
		[FieldOffset(Offset = "0x20")]
		public string bossCombineDesc;

		// Token: 0x04006077 RID: 24695
		[Token(Token = "0x4006077")]
		[FieldOffset(Offset = "0x28")]
		public string battleNoPredictDescription;

		// Token: 0x04006078 RID: 24696
		[Token(Token = "0x4006078")]
		[FieldOffset(Offset = "0x30")]
		public string shopNoGoodsDescription;
	}
}
