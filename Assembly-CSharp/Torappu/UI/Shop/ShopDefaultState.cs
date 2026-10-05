using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B81 RID: 23425
	[Token(Token = "0x2005B81")]
	public class ShopDefaultState : State
	{
		// Token: 0x06021FF8 RID: 139256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FF8")]
		[Address(RVA = "0x1C6FD90", Offset = "0x1C6E990", VA = "0x181C6FD90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021FF9 RID: 139257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FF9")]
		[Address(RVA = "0x1C6FE20", Offset = "0x1C6EA20", VA = "0x181C6FE20")]
		public ShopDefaultState()
		{
		}

		// Token: 0x0402E9B1 RID: 190897
		[Token(Token = "0x402E9B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E9B2 RID: 190898
		[Token(Token = "0x402E9B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
