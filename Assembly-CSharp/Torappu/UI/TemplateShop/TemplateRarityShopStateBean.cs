using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D6F RID: 15727
	[Token(Token = "0x2003D6F")]
	public class TemplateRarityShopStateBean : TemplateCommonShopGoodListStateBean
	{
		// Token: 0x060187C8 RID: 100296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187C8")]
		[Address(RVA = "0x10EB460", Offset = "0x10EA060", VA = "0x1810EB460")]
		public void RefreshBuySituationOnResume()
		{
		}

		// Token: 0x060187C9 RID: 100297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187C9")]
		[Address(RVA = "0x10EA8C0", Offset = "0x10E94C0", VA = "0x1810EA8C0", Slot = "4")]
		public override void LoadData(TemplateShopData data, long _)
		{
		}

		// Token: 0x060187CA RID: 100298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187CA")]
		[Address(RVA = "0x10EB840", Offset = "0x10EA440", VA = "0x1810EB840")]
		public TemplateRarityShopStateBean()
		{
		}

		// Token: 0x0401DFF3 RID: 122867
		[Token(Token = "0x401DFF3")]
		[FieldOffset(Offset = "0x10")]
		public TemplateShopData shopDataCache;

		// Token: 0x0401DFF4 RID: 122868
		[Token(Token = "0x401DFF4")]
		[FieldOffset(Offset = "0x18")]
		public List<TemplateShopRarityViewModel> shopRarityViewModelList;

		// Token: 0x0401DFF5 RID: 122869
		[Token(Token = "0x401DFF5")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, TemplateShopRarityViewModel> shopRarityViewModelDict;

		// Token: 0x0401DFF6 RID: 122870
		[Token(Token = "0x401DFF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshBuySituationOnResume;

		// Token: 0x0401DFF7 RID: 122871
		[Token(Token = "0x401DFF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401DFF8 RID: 122872
		[Token(Token = "0x401DFF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
