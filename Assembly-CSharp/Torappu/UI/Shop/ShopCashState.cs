using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B7F RID: 23423
	[Token(Token = "0x2005B7F")]
	public class ShopCashState : ShopCommonState
	{
		// Token: 0x06021FEC RID: 139244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FEC")]
		[Address(RVA = "0x1C6F930", Offset = "0x1C6E530", VA = "0x181C6F930")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021FED RID: 139245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FED")]
		[Address(RVA = "0x1C6F640", Offset = "0x1C6E240", VA = "0x181C6F640", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021FEE RID: 139246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FEE")]
		[Address(RVA = "0x1C6F6A0", Offset = "0x1C6E2A0", VA = "0x181C6F6A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021FEF RID: 139247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FEF")]
		[Address(RVA = "0x1C6FA50", Offset = "0x1C6E650", VA = "0x181C6FA50")]
		private void _UpdateShopCashState()
		{
		}

		// Token: 0x06021FF0 RID: 139248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FF0")]
		[Address(RVA = "0x1C6F510", Offset = "0x1C6E110", VA = "0x181C6F510")]
		public void ApplyData(GetCashGoodListResponse response)
		{
		}

		// Token: 0x06021FF1 RID: 139249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FF1")]
		[Address(RVA = "0x1C6FB70", Offset = "0x1C6E770", VA = "0x181C6FB70")]
		public ShopCashState()
		{
		}

		// Token: 0x06021FF3 RID: 139251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FF3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E9A4 RID: 190884
		[Token(Token = "0x402E9A4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CashStateBean _stateBean;

		// Token: 0x0402E9A5 RID: 190885
		[Token(Token = "0x402E9A5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CashShopListView _listView;

		// Token: 0x0402E9A6 RID: 190886
		[Token(Token = "0x402E9A6")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0402E9A7 RID: 190887
		[Token(Token = "0x402E9A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E9A8 RID: 190888
		[Token(Token = "0x402E9A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E9A9 RID: 190889
		[Token(Token = "0x402E9A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E9AA RID: 190890
		[Token(Token = "0x402E9AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateShopCashState;

		// Token: 0x0402E9AB RID: 190891
		[Token(Token = "0x402E9AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E9AC RID: 190892
		[Token(Token = "0x402E9AC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
