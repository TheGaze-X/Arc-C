using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B8D RID: 23437
	[Token(Token = "0x2005B8D")]
	public class ShopRecommendState : ShopCommonState
	{
		// Token: 0x06022030 RID: 139312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022030")]
		[Address(RVA = "0x1C73FC0", Offset = "0x1C72BC0", VA = "0x181C73FC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022031 RID: 139313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022031")]
		[Address(RVA = "0x1C74170", Offset = "0x1C72D70", VA = "0x181C74170", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022032 RID: 139314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022032")]
		[Address(RVA = "0x1C73F10", Offset = "0x1C72B10", VA = "0x181C73F10")]
		public void OnClickHandler(string tabId)
		{
		}

		// Token: 0x06022033 RID: 139315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022033")]
		[Address(RVA = "0x1C73E00", Offset = "0x1C72A00", VA = "0x181C73E00")]
		public void OnClickDropHandler(ShopRecommendData recommend)
		{
		}

		// Token: 0x06022034 RID: 139316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022034")]
		[Address(RVA = "0x1C74500", Offset = "0x1C73100", VA = "0x181C74500")]
		private void _FocusOnSelected(ShopRecommendViewModel closureViewModel)
		{
		}

		// Token: 0x06022035 RID: 139317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022035")]
		[Address(RVA = "0x1C73DA0", Offset = "0x1C729A0", VA = "0x181C73DA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022036 RID: 139318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022036")]
		[Address(RVA = "0x1C74A00", Offset = "0x1C73600", VA = "0x181C74A00")]
		private void _UpdateShopStatus()
		{
		}

		// Token: 0x06022037 RID: 139319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022037")]
		[Address(RVA = "0x1C74850", Offset = "0x1C73450", VA = "0x181C74850")]
		private static string _RestrictSelectedTab(ShopRecommendStateBean stateBean, string selectedTag)
		{
			return null;
		}

		// Token: 0x06022038 RID: 139320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022038")]
		[Address(RVA = "0x1C74B20", Offset = "0x1C73720", VA = "0x181C74B20")]
		public ShopRecommendState()
		{
		}

		// Token: 0x0602203A RID: 139322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602203A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602203B RID: 139323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602203B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402E9F8 RID: 190968
		[Token(Token = "0x402E9F8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ShopRecommendStateBean _stateBean;

		// Token: 0x0402E9F9 RID: 190969
		[Token(Token = "0x402E9F9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ShopRecommendTabButton _tabButton;

		// Token: 0x0402E9FA RID: 190970
		[Token(Token = "0x402E9FA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ShopKeeperPanel _shopKeeper;

		// Token: 0x0402E9FB RID: 190971
		[Token(Token = "0x402E9FB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _buttonContainer;

		// Token: 0x0402E9FC RID: 190972
		[Token(Token = "0x402E9FC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _layoutContainer;

		// Token: 0x0402E9FD RID: 190973
		[Token(Token = "0x402E9FD")]
		[FieldOffset(Offset = "0x90")]
		private string m_selectedTab;

		// Token: 0x0402E9FE RID: 190974
		[Token(Token = "0x402E9FE")]
		[FieldOffset(Offset = "0x98")]
		private List<ShopRecommendTabButton> m_buttonList;

		// Token: 0x0402E9FF RID: 190975
		[Token(Token = "0x402E9FF")]
		[FieldOffset(Offset = "0xA0")]
		private ShopRecommendLayoutView m_layout;

		// Token: 0x0402EA00 RID: 190976
		[Token(Token = "0x402EA00")]
		[FieldOffset(Offset = "0xA8")]
		private ShopRecommendState.TabAdapter m_tabAdapter;

		// Token: 0x0402EA01 RID: 190977
		[Token(Token = "0x402EA01")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInitialUpdateStatus;

		// Token: 0x0402EA02 RID: 190978
		[Token(Token = "0x402EA02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402EA03 RID: 190979
		[Token(Token = "0x402EA03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402EA04 RID: 190980
		[Token(Token = "0x402EA04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickHandler;

		// Token: 0x0402EA05 RID: 190981
		[Token(Token = "0x402EA05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickDropHandler;

		// Token: 0x0402EA06 RID: 190982
		[Token(Token = "0x402EA06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FocusOnSelected;

		// Token: 0x0402EA07 RID: 190983
		[Token(Token = "0x402EA07")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402EA08 RID: 190984
		[Token(Token = "0x402EA08")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateShopStatus;

		// Token: 0x0402EA09 RID: 190985
		[Token(Token = "0x402EA09")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RestrictSelectedTab;

		// Token: 0x0402EA0A RID: 190986
		[Token(Token = "0x402EA0A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005B8E RID: 23438
		[Token(Token = "0x2005B8E")]
		private class TabAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602203C RID: 139324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602203C")]
			[Address(RVA = "0x1C84590", Offset = "0x1C83190", VA = "0x181C84590")]
			public TabAdapter(ShopRecommendState closure)
			{
			}

			// Token: 0x0602203D RID: 139325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602203D")]
			[Address(RVA = "0x1C84020", Offset = "0x1C82C20", VA = "0x181C84020", Slot = "8")]
			public override void NotifyDataSetChanged()
			{
			}

			// Token: 0x17004FA0 RID: 20384
			// (get) Token: 0x0602203E RID: 139326 RVA: 0x000BC268 File Offset: 0x000BA468
			[Token(Token = "0x17004FA0")]
			public override int count
			{
				[Token(Token = "0x602203E")]
				[Address(RVA = "0x1C84610", Offset = "0x1C83210", VA = "0x181C84610", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602203F RID: 139327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602203F")]
			[Address(RVA = "0x1C840A0", Offset = "0x1C82CA0", VA = "0x181C840A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06022040 RID: 139328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022040")]
			[Address(RVA = "0xDEAD20", Offset = "0xDE9920", VA = "0x180DEAD20")]
			private void <>xLuaBaseProxy_NotifyDataSetChanged()
			{
			}

			// Token: 0x0402EA0B RID: 190987
			[Token(Token = "0x402EA0B")]
			[FieldOffset(Offset = "0x20")]
			private ShopRecommendState m_closure;

			// Token: 0x0402EA0C RID: 190988
			[Token(Token = "0x402EA0C")]
			[FieldOffset(Offset = "0x28")]
			private bool m_isInitialRender;

			// Token: 0x0402EA0D RID: 190989
			[Token(Token = "0x402EA0D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402EA0E RID: 190990
			[Token(Token = "0x402EA0E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_NotifyDataSetChanged;

			// Token: 0x0402EA0F RID: 190991
			[Token(Token = "0x402EA0F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EA10 RID: 190992
			[Token(Token = "0x402EA10")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
