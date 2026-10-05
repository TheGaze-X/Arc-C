using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D32 RID: 23858
	[Token(Token = "0x2005D32")]
	public class ClimbTowerListState : PopupFadeState
	{
		// Token: 0x060228B8 RID: 141496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228B8")]
		[Address(RVA = "0x1D0BDE0", Offset = "0x1D0A9E0", VA = "0x181D0BDE0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060228B9 RID: 141497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228B9")]
		[Address(RVA = "0x1D0BEE0", Offset = "0x1D0AAE0", VA = "0x181D0BEE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060228BA RID: 141498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228BA")]
		[Address(RVA = "0x1D0C220", Offset = "0x1D0AE20", VA = "0x181D0C220", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060228BB RID: 141499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228BB")]
		[Address(RVA = "0x1D0BE40", Offset = "0x1D0AA40", VA = "0x181D0BE40")]
		private void OnDestroy()
		{
		}

		// Token: 0x060228BC RID: 141500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228BC")]
		[Address(RVA = "0x1D0C3B0", Offset = "0x1D0AFB0", VA = "0x181D0C3B0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060228BD RID: 141501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228BD")]
		[Address(RVA = "0x1D0D400", Offset = "0x1D0C000", VA = "0x181D0D400")]
		private void _TriggerClimbTowerBGM()
		{
		}

		// Token: 0x060228BE RID: 141502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228BE")]
		[Address(RVA = "0x1D0D250", Offset = "0x1D0BE50", VA = "0x181D0D250")]
		private void _TriggerClimbTowerAVG()
		{
		}

		// Token: 0x060228BF RID: 141503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228BF")]
		[Address(RVA = "0x1D0C610", Offset = "0x1D0B210", VA = "0x181D0C610")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060228C0 RID: 141504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228C0")]
		[Address(RVA = "0x1D0CD50", Offset = "0x1D0B950", VA = "0x181D0CD50")]
		private void _OnItemClicked()
		{
		}

		// Token: 0x060228C1 RID: 141505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228C1")]
		[Address(RVA = "0x1D0CFC0", Offset = "0x1D0BBC0", VA = "0x181D0CFC0")]
		private void _OnTowerClicked(ClimbTowerTowerType type, string towerId)
		{
		}

		// Token: 0x060228C2 RID: 141506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228C2")]
		[Address(RVA = "0x1D0CAA0", Offset = "0x1D0B6A0", VA = "0x181D0CAA0")]
		private void _OnGodCardClicked()
		{
		}

		// Token: 0x060228C3 RID: 141507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228C3")]
		[Address(RVA = "0x1D0CB50", Offset = "0x1D0B750", VA = "0x181D0CB50")]
		private void _OnGodCardItemClicked(string cardId)
		{
		}

		// Token: 0x060228C4 RID: 141508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228C4")]
		[Address(RVA = "0x1D0CE00", Offset = "0x1D0BA00", VA = "0x181D0CE00")]
		private void _OnJumpToClimbTowerGodCardDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x060228C5 RID: 141509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228C5")]
		[Address(RVA = "0x1D0CEE0", Offset = "0x1D0BAE0", VA = "0x181D0CEE0")]
		private void _OnMissionClicked()
		{
		}

		// Token: 0x060228C6 RID: 141510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228C6")]
		[Address(RVA = "0x1D0D540", Offset = "0x1D0C140", VA = "0x181D0D540")]
		public ClimbTowerListState()
		{
		}

		// Token: 0x060228C8 RID: 141512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228C8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060228C9 RID: 141513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228C9")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060228CA RID: 141514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228CA")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402F7C7 RID: 194503
		[Token(Token = "0x402F7C7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerEntryMapView _mapView;

		// Token: 0x0402F7C8 RID: 194504
		[Token(Token = "0x402F7C8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerEntryFloatView _floatPanel;

		// Token: 0x0402F7C9 RID: 194505
		[Token(Token = "0x402F7C9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ClimbTowerItemRewardView _prefabReward;

		// Token: 0x0402F7CA RID: 194506
		[Token(Token = "0x402F7CA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _containerReward;

		// Token: 0x0402F7CB RID: 194507
		[Token(Token = "0x402F7CB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _topContainer;

		// Token: 0x0402F7CC RID: 194508
		[Token(Token = "0x402F7CC")]
		[FieldOffset(Offset = "0x98")]
		private ClimbTowerEntryMapProperty m_mapProperty;

		// Token: 0x0402F7CD RID: 194509
		[Token(Token = "0x402F7CD")]
		[FieldOffset(Offset = "0xA0")]
		private ClimbTowerItemRewardProperty m_itemProperty;

		// Token: 0x0402F7CE RID: 194510
		[Token(Token = "0x402F7CE")]
		[FieldOffset(Offset = "0xA8")]
		private ClimbTowerEntryFloatPanelProperty m_floatPanelProperty;

		// Token: 0x0402F7CF RID: 194511
		[Token(Token = "0x402F7CF")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x0402F7D0 RID: 194512
		[Token(Token = "0x402F7D0")]
		[FieldOffset(Offset = "0xB8")]
		private ClimbTowerItemRewardView m_itemView;

		// Token: 0x0402F7D1 RID: 194513
		[Token(Token = "0x402F7D1")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedSelectCardId;

		// Token: 0x0402F7D2 RID: 194514
		[Token(Token = "0x402F7D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F7D3 RID: 194515
		[Token(Token = "0x402F7D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F7D4 RID: 194516
		[Token(Token = "0x402F7D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F7D5 RID: 194517
		[Token(Token = "0x402F7D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402F7D6 RID: 194518
		[Token(Token = "0x402F7D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F7D7 RID: 194519
		[Token(Token = "0x402F7D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TriggerClimbTowerBGM;

		// Token: 0x0402F7D8 RID: 194520
		[Token(Token = "0x402F7D8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TriggerClimbTowerAVG;

		// Token: 0x0402F7D9 RID: 194521
		[Token(Token = "0x402F7D9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F7DA RID: 194522
		[Token(Token = "0x402F7DA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0402F7DB RID: 194523
		[Token(Token = "0x402F7DB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnTowerClicked;

		// Token: 0x0402F7DC RID: 194524
		[Token(Token = "0x402F7DC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnGodCardClicked;

		// Token: 0x0402F7DD RID: 194525
		[Token(Token = "0x402F7DD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnGodCardItemClicked;

		// Token: 0x0402F7DE RID: 194526
		[Token(Token = "0x402F7DE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnJumpToClimbTowerGodCardDetailState;

		// Token: 0x0402F7DF RID: 194527
		[Token(Token = "0x402F7DF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnMissionClicked;

		// Token: 0x0402F7E0 RID: 194528
		[Token(Token = "0x402F7E0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
