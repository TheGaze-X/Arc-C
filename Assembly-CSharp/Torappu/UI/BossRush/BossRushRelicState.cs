using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006188 RID: 24968
	[Token(Token = "0x2006188")]
	public class BossRushRelicState : PopupFadeState
	{
		// Token: 0x0602403F RID: 147519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602403F")]
		[Address(RVA = "0x1EA6360", Offset = "0x1EA4F60", VA = "0x181EA6360", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024040 RID: 147520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024040")]
		[Address(RVA = "0x1EA63C0", Offset = "0x1EA4FC0", VA = "0x181EA63C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06024041 RID: 147521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024041")]
		[Address(RVA = "0x1EA67C0", Offset = "0x1EA53C0", VA = "0x181EA67C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06024042 RID: 147522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024042")]
		[Address(RVA = "0x1EA69B0", Offset = "0x1EA55B0", VA = "0x181EA69B0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06024043 RID: 147523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024043")]
		[Address(RVA = "0x1EA6B10", Offset = "0x1EA5710", VA = "0x181EA6B10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024044 RID: 147524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024044")]
		[Address(RVA = "0x1EA7600", Offset = "0x1EA6200", VA = "0x181EA7600")]
		private void _SendRelicSelectRequest(Action callback)
		{
		}

		// Token: 0x06024045 RID: 147525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024045")]
		[Address(RVA = "0x1EA75A0", Offset = "0x1EA61A0", VA = "0x181EA75A0")]
		private void _RaiseTutorialSignal()
		{
		}

		// Token: 0x06024046 RID: 147526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024046")]
		[Address(RVA = "0x1EA6D00", Offset = "0x1EA5900", VA = "0x181EA6D00")]
		private void _OnBackClick()
		{
		}

		// Token: 0x06024047 RID: 147527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024047")]
		[Address(RVA = "0x1EA7200", Offset = "0x1EA5E00", VA = "0x181EA7200")]
		private void _OnTopMenuRoutedToOtherPage(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x06024048 RID: 147528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024048")]
		[Address(RVA = "0x1EA6E00", Offset = "0x1EA5A00", VA = "0x181EA6E00")]
		private void _OnJumpToUpgrade(IStateBean stateBean)
		{
		}

		// Token: 0x06024049 RID: 147529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024049")]
		[Address(RVA = "0x1EA7100", Offset = "0x1EA5D00", VA = "0x181EA7100")]
		private void _OnSelectRelic(BossRushRelicNodeModel relicNodeModel)
		{
		}

		// Token: 0x0602404A RID: 147530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602404A")]
		[Address(RVA = "0x1EA7340", Offset = "0x1EA5F40", VA = "0x181EA7340")]
		private void _OnUpgradeClicked(BossRushRelicNodeModel relicNodeModel)
		{
		}

		// Token: 0x0602404B RID: 147531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602404B")]
		[Address(RVA = "0x1EA79E0", Offset = "0x1EA65E0", VA = "0x181EA79E0")]
		public BossRushRelicState()
		{
		}

		// Token: 0x0602404C RID: 147532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602404C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602404D RID: 147533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602404D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602404E RID: 147534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602404E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403209E RID: 204958
		[Token(Token = "0x403209E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BossRushRelicView _relicView;

		// Token: 0x0403209F RID: 204959
		[Token(Token = "0x403209F")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x040320A0 RID: 204960
		[Token(Token = "0x40320A0")]
		[FieldOffset(Offset = "0x80")]
		private BossRushRelicStateBean m_stateBean;

		// Token: 0x040320A1 RID: 204961
		[Token(Token = "0x40320A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040320A2 RID: 204962
		[Token(Token = "0x40320A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040320A3 RID: 204963
		[Token(Token = "0x40320A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040320A4 RID: 204964
		[Token(Token = "0x40320A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040320A5 RID: 204965
		[Token(Token = "0x40320A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040320A6 RID: 204966
		[Token(Token = "0x40320A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendRelicSelectRequest;

		// Token: 0x040320A7 RID: 204967
		[Token(Token = "0x40320A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RaiseTutorialSignal;

		// Token: 0x040320A8 RID: 204968
		[Token(Token = "0x40320A8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x040320A9 RID: 204969
		[Token(Token = "0x40320A9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnTopMenuRoutedToOtherPage;

		// Token: 0x040320AA RID: 204970
		[Token(Token = "0x40320AA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnJumpToUpgrade;

		// Token: 0x040320AB RID: 204971
		[Token(Token = "0x40320AB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSelectRelic;

		// Token: 0x040320AC RID: 204972
		[Token(Token = "0x40320AC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnUpgradeClicked;

		// Token: 0x040320AD RID: 204973
		[Token(Token = "0x40320AD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
