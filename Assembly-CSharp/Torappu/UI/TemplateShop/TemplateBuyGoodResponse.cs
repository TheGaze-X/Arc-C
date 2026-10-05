using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D51 RID: 15697
	[Token(Token = "0x2003D51")]
	public class TemplateBuyGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x06018730 RID: 100144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018730")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public TemplateBuyGoodResponse()
		{
		}

		// Token: 0x0401DE9B RID: 122523
		[Token(Token = "0x401DE9B")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> itemList;
	}
}
