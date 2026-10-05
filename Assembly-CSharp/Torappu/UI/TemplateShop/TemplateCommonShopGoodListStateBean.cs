using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D68 RID: 15720
	[Token(Token = "0x2003D68")]
	public abstract class TemplateCommonShopGoodListStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060187A7 RID: 100263
		[Token(Token = "0x60187A7")]
		public abstract void LoadData(TemplateShopData data, long nextSyncTs);

		// Token: 0x060187A8 RID: 100264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187A8")]
		[Address(RVA = "0x10E9700", Offset = "0x10E8300", VA = "0x1810E9700")]
		protected TemplateCommonShopGoodListStateBean()
		{
		}

		// Token: 0x0401DFD6 RID: 122838
		[Token(Token = "0x401DFD6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
