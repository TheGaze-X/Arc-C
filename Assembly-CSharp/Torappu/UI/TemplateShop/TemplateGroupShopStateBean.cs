using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D6D RID: 15725
	[Token(Token = "0x2003D6D")]
	public class TemplateGroupShopStateBean : TemplateCommonShopGoodListStateBean
	{
		// Token: 0x060187C3 RID: 100291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187C3")]
		[Address(RVA = "0x10EA090", Offset = "0x10E8C90", VA = "0x1810EA090")]
		public void RefreshBuySituationOnResume()
		{
		}

		// Token: 0x060187C4 RID: 100292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187C4")]
		[Address(RVA = "0x10E97C0", Offset = "0x10E83C0", VA = "0x1810E97C0", Slot = "4")]
		public override void LoadData(TemplateShopData data, long nextSyncTs)
		{
		}

		// Token: 0x060187C5 RID: 100293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187C5")]
		[Address(RVA = "0x10EA5A0", Offset = "0x10E91A0", VA = "0x1810EA5A0")]
		public TemplateGroupShopStateBean()
		{
		}

		// Token: 0x0401DFEA RID: 122858
		[Token(Token = "0x401DFEA")]
		[FieldOffset(Offset = "0x10")]
		public TemplateShopData shopDataCache;

		// Token: 0x0401DFEB RID: 122859
		[Token(Token = "0x401DFEB")]
		[FieldOffset(Offset = "0x18")]
		public List<TemplateShopGroupViewModel> shopGroupViewModelList;

		// Token: 0x0401DFEC RID: 122860
		[Token(Token = "0x401DFEC")]
		[FieldOffset(Offset = "0x20")]
		public long nextSyncTime;

		// Token: 0x0401DFED RID: 122861
		[Token(Token = "0x401DFED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshBuySituationOnResume;

		// Token: 0x0401DFEE RID: 122862
		[Token(Token = "0x401DFEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401DFEF RID: 122863
		[Token(Token = "0x401DFEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
