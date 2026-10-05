using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D67 RID: 15719
	[Token(Token = "0x2003D67")]
	public class TemplateCommonShopStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060187A6 RID: 100262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187A6")]
		[Address(RVA = "0x10E9760", Offset = "0x10E8360", VA = "0x1810E9760")]
		public TemplateCommonShopStateBean()
		{
		}

		// Token: 0x0401DFD3 RID: 122835
		[Token(Token = "0x401DFD3")]
		[FieldOffset(Offset = "0x10")]
		public TemplateShopData shopData;

		// Token: 0x0401DFD4 RID: 122836
		[Token(Token = "0x401DFD4")]
		[FieldOffset(Offset = "0x18")]
		public long nextSyncTs;

		// Token: 0x0401DFD5 RID: 122837
		[Token(Token = "0x401DFD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
