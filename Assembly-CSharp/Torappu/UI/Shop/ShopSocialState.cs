using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B6C RID: 23404
	[Token(Token = "0x2005B6C")]
	public class ShopSocialState : ShopCommonState
	{
		// Token: 0x06021FAB RID: 139179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FAB")]
		[Address(RVA = "0x1C76B80", Offset = "0x1C75780", VA = "0x181C76B80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021FAC RID: 139180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FAC")]
		[Address(RVA = "0x1C76EC0", Offset = "0x1C75AC0", VA = "0x181C76EC0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06021FAD RID: 139181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FAD")]
		[Address(RVA = "0x1C76D60", Offset = "0x1C75960", VA = "0x181C76D60", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06021FAE RID: 139182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FAE")]
		[Address(RVA = "0x1C76B20", Offset = "0x1C75720", VA = "0x181C76B20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021FAF RID: 139183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FAF")]
		[Address(RVA = "0x1C77790", Offset = "0x1C76390", VA = "0x181C77790")]
		private void _UpdateSocialState()
		{
		}

		// Token: 0x06021FB0 RID: 139184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FB0")]
		[Address(RVA = "0x1C77020", Offset = "0x1C75C20", VA = "0x181C77020")]
		public void SendGetSocialRequest()
		{
		}

		// Token: 0x06021FB1 RID: 139185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FB1")]
		[Address(RVA = "0x1C76E30", Offset = "0x1C75A30", VA = "0x181C76E30")]
		public void OpenSocialDetail()
		{
		}

		// Token: 0x06021FB2 RID: 139186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FB2")]
		[Address(RVA = "0x1C76980", Offset = "0x1C75580", VA = "0x181C76980")]
		public void ApplyData(GetSocialGoodListResponse response)
		{
		}

		// Token: 0x06021FB3 RID: 139187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FB3")]
		[Address(RVA = "0x1C778B0", Offset = "0x1C764B0", VA = "0x181C778B0")]
		public ShopSocialState()
		{
		}

		// Token: 0x06021FB7 RID: 139191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FB7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06021FB8 RID: 139192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FB8")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06021FB9 RID: 139193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FB9")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402E923 RID: 190755
		[Token(Token = "0x402E923")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ShopSocialStateBean _stateBean;

		// Token: 0x0402E924 RID: 190756
		[Token(Token = "0x402E924")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ShopSocialView _itemView;

		// Token: 0x0402E925 RID: 190757
		[Token(Token = "0x402E925")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggle _twoState;

		// Token: 0x0402E926 RID: 190758
		[Token(Token = "0x402E926")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UICommonTrackPoint _socialTrackPoint;

		// Token: 0x0402E927 RID: 190759
		[Token(Token = "0x402E927")]
		[FieldOffset(Offset = "0x88")]
		private TrackPointViewProperty m_socialShopTrackProp;

		// Token: 0x0402E928 RID: 190760
		[Token(Token = "0x402E928")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E929 RID: 190761
		[Token(Token = "0x402E929")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402E92A RID: 190762
		[Token(Token = "0x402E92A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402E92B RID: 190763
		[Token(Token = "0x402E92B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E92C RID: 190764
		[Token(Token = "0x402E92C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateSocialState;

		// Token: 0x0402E92D RID: 190765
		[Token(Token = "0x402E92D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SendGetSocialRequest;

		// Token: 0x0402E92E RID: 190766
		[Token(Token = "0x402E92E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OpenSocialDetail;

		// Token: 0x0402E92F RID: 190767
		[Token(Token = "0x402E92F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E930 RID: 190768
		[Token(Token = "0x402E930")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
