using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B83 RID: 23427
	[Token(Token = "0x2005B83")]
	public class ShopFurnState : ShopCommonState
	{
		// Token: 0x06021FFE RID: 139262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FFE")]
		[Address(RVA = "0x1C70100", Offset = "0x1C6ED00", VA = "0x181C70100", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021FFF RID: 139263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FFF")]
		[Address(RVA = "0x1C708F0", Offset = "0x1C6F4F0", VA = "0x181C708F0")]
		private void _RefreshData()
		{
		}

		// Token: 0x06022000 RID: 139264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022000")]
		[Address(RVA = "0x1C70330", Offset = "0x1C6EF30", VA = "0x181C70330")]
		private void _OnListServiceResponse(BuildingGetFurnitureGoodListResponse response, bool isDataUpdated)
		{
		}

		// Token: 0x06022001 RID: 139265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022001")]
		[Address(RVA = "0x1C70A10", Offset = "0x1C6F610", VA = "0x181C70A10")]
		private void _RefreshPlayerData()
		{
		}

		// Token: 0x06022002 RID: 139266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022002")]
		[Address(RVA = "0x1C70BB0", Offset = "0x1C6F7B0", VA = "0x181C70BB0")]
		private void _RefreshView()
		{
		}

		// Token: 0x06022003 RID: 139267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022003")]
		[Address(RVA = "0x1C70D10", Offset = "0x1C6F910", VA = "0x181C70D10")]
		private void _TryOpenItemDetail()
		{
		}

		// Token: 0x06022004 RID: 139268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022004")]
		[Address(RVA = "0x1C70C40", Offset = "0x1C6F840", VA = "0x181C70C40")]
		private IEnumerator _TryApplyDetailCoroutine(string openItemGoodId)
		{
			return null;
		}

		// Token: 0x06022005 RID: 139269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022005")]
		[Address(RVA = "0x1C70160", Offset = "0x1C6ED60", VA = "0x181C70160", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022006 RID: 139270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022006")]
		[Address(RVA = "0x1C702C0", Offset = "0x1C6EEC0", VA = "0x181C702C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022007 RID: 139271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022007")]
		[Address(RVA = "0x1C70E70", Offset = "0x1C6FA70", VA = "0x181C70E70")]
		public ShopFurnState()
		{
		}

		// Token: 0x06022008 RID: 139272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022008")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022009 RID: 139273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022009")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402E9B9 RID: 190905
		[Token(Token = "0x402E9B9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ShopFurnitureStateBean _stateBean;

		// Token: 0x0402E9BA RID: 190906
		[Token(Token = "0x402E9BA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LoopHorizontalScrollRect _layoutContent;

		// Token: 0x0402E9BB RID: 190907
		[Token(Token = "0x402E9BB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ShopFurnAdapter _adapter;

		// Token: 0x0402E9BC RID: 190908
		[Token(Token = "0x402E9BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E9BD RID: 190909
		[Token(Token = "0x402E9BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x0402E9BE RID: 190910
		[Token(Token = "0x402E9BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnListServiceResponse;

		// Token: 0x0402E9BF RID: 190911
		[Token(Token = "0x402E9BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshPlayerData;

		// Token: 0x0402E9C0 RID: 190912
		[Token(Token = "0x402E9C0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x0402E9C1 RID: 190913
		[Token(Token = "0x402E9C1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryOpenItemDetail;

		// Token: 0x0402E9C2 RID: 190914
		[Token(Token = "0x402E9C2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryApplyDetailCoroutine;

		// Token: 0x0402E9C3 RID: 190915
		[Token(Token = "0x402E9C3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E9C4 RID: 190916
		[Token(Token = "0x402E9C4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402E9C5 RID: 190917
		[Token(Token = "0x402E9C5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
