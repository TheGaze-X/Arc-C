using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B24 RID: 23332
	[Token(Token = "0x2005B24")]
	public class ShopQCConvertStateBean : PageSingleComponent, IStateBean, IHotfixable
	{
		// Token: 0x06021E17 RID: 138775 RVA: 0x000BB8A8 File Offset: 0x000B9AA8
		[Token(Token = "0x6021E17")]
		[Address(RVA = "0x1C64410", Offset = "0x1C63010", VA = "0x181C64410")]
		public bool InitData(bool useClassicPotentialItem)
		{
			return default(bool);
		}

		// Token: 0x06021E18 RID: 138776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E18")]
		[Address(RVA = "0x1C64E30", Offset = "0x1C63A30", VA = "0x181C64E30")]
		public ShopQCConvertStateBean()
		{
		}

		// Token: 0x0402E6B8 RID: 190136
		[Token(Token = "0x402E6B8")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<ShopQCViewModel> objList;

		// Token: 0x0402E6B9 RID: 190137
		[Token(Token = "0x402E6B9")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public List<UIItemViewModel> itemList;

		// Token: 0x0402E6BA RID: 190138
		[Token(Token = "0x402E6BA")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public bool useClassicPotentialItem;

		// Token: 0x0402E6BB RID: 190139
		[Token(Token = "0x402E6BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402E6BC RID: 190140
		[Token(Token = "0x402E6BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
