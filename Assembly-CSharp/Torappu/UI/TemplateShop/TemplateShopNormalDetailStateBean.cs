using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D78 RID: 15736
	[Token(Token = "0x2003D78")]
	public class TemplateShopNormalDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060187D3 RID: 100307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187D3")]
		[Address(RVA = "0x111A280", Offset = "0x1118E80", VA = "0x18111A280")]
		public TemplateShopNormalDetailStateBean()
		{
		}

		// Token: 0x0401E021 RID: 122913
		[Token(Token = "0x401E021")]
		[FieldOffset(Offset = "0x10")]
		public TemplateCommonShopGoodViewModel shopViewModel;

		// Token: 0x0401E022 RID: 122914
		[Token(Token = "0x401E022")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
