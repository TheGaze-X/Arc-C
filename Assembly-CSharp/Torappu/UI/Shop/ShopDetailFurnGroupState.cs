using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A8E RID: 23182
	[Token(Token = "0x2005A8E")]
	public class ShopDetailFurnGroupState : PopupFloatState, IHotfixable, IShopDetailLayer
	{
		// Token: 0x06021B69 RID: 138089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B69")]
		[Address(RVA = "0x1C22040", Offset = "0x1C20C40", VA = "0x181C22040", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021B6A RID: 138090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B6A")]
		[Address(RVA = "0x1C220A0", Offset = "0x1C20CA0", VA = "0x181C220A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021B6B RID: 138091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B6B")]
		[Address(RVA = "0x1C22150", Offset = "0x1C20D50", VA = "0x181C22150")]
		public ShopDetailFurnGroupState()
		{
		}

		// Token: 0x06021B6C RID: 138092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B6C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E1AD RID: 188845
		[Token(Token = "0x402E1AD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ShopDetailFurnGroupView _detailView;

		// Token: 0x0402E1AE RID: 188846
		[Token(Token = "0x402E1AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E1AF RID: 188847
		[Token(Token = "0x402E1AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E1B0 RID: 188848
		[Token(Token = "0x402E1B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
