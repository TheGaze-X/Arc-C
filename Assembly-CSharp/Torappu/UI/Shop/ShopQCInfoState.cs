using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B89 RID: 23433
	[Token(Token = "0x2005B89")]
	public class ShopQCInfoState : PopupFloatState
	{
		// Token: 0x0602201F RID: 139295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602201F")]
		[Address(RVA = "0x1C731B0", Offset = "0x1C71DB0", VA = "0x181C731B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022020 RID: 139296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022020")]
		[Address(RVA = "0x1C73210", Offset = "0x1C71E10", VA = "0x181C73210")]
		public ShopQCInfoState()
		{
		}

		// Token: 0x0402E9DB RID: 190939
		[Token(Token = "0x402E9DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E9DC RID: 190940
		[Token(Token = "0x402E9DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
