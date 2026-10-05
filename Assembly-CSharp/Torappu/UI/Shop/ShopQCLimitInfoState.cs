using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B8A RID: 23434
	[Token(Token = "0x2005B8A")]
	public class ShopQCLimitInfoState : PopupFloatState, IHotfixable
	{
		// Token: 0x06022021 RID: 139297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022021")]
		[Address(RVA = "0x1C732D0", Offset = "0x1C71ED0", VA = "0x181C732D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022022 RID: 139298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022022")]
		[Address(RVA = "0x1C73270", Offset = "0x1C71E70", VA = "0x181C73270", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022023 RID: 139299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022023")]
		[Address(RVA = "0x1C73440", Offset = "0x1C72040", VA = "0x181C73440")]
		public ShopQCLimitInfoState()
		{
		}

		// Token: 0x06022024 RID: 139300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022024")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E9DD RID: 190941
		[Token(Token = "0x402E9DD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _detailViewContainer;

		// Token: 0x0402E9DE RID: 190942
		[Token(Token = "0x402E9DE")]
		[FieldOffset(Offset = "0x78")]
		private QCShopLMTGSDetailView _detailView;

		// Token: 0x0402E9DF RID: 190943
		[Token(Token = "0x402E9DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E9E0 RID: 190944
		[Token(Token = "0x402E9E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E9E1 RID: 190945
		[Token(Token = "0x402E9E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
