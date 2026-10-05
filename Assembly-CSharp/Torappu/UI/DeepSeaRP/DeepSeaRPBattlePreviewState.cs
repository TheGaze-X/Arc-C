using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005114 RID: 20756
	[Token(Token = "0x2005114")]
	public class DeepSeaRPBattlePreviewState : PopupFadeState, IHotfixable
	{
		// Token: 0x0601EA66 RID: 125542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EA66")]
		[Address(RVA = "0x18511E0", Offset = "0x184FDE0", VA = "0x1818511E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601EA67 RID: 125543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EA67")]
		[Address(RVA = "0x1852460", Offset = "0x1851060", VA = "0x181852460", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601EA68 RID: 125544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA68")]
		[Address(RVA = "0x1853210", Offset = "0x1851E10", VA = "0x181853210")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x0601EA69 RID: 125545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA69")]
		[Address(RVA = "0x18533C0", Offset = "0x1851FC0", VA = "0x1818533C0")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x0601EA6A RID: 125546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA6A")]
		[Address(RVA = "0x18517E0", Offset = "0x18503E0", VA = "0x1818517E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601EA6B RID: 125547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA6B")]
		[Address(RVA = "0x1852090", Offset = "0x1850C90", VA = "0x181852090", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601EA6C RID: 125548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA6C")]
		[Address(RVA = "0x1851D70", Offset = "0x1850970", VA = "0x181851D70", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601EA6D RID: 125549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA6D")]
		[Address(RVA = "0x18514A0", Offset = "0x18500A0", VA = "0x1818514A0")]
		public void OnBtnStartBattleClick()
		{
		}

		// Token: 0x0601EA6E RID: 125550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA6E")]
		[Address(RVA = "0x18515C0", Offset = "0x18501C0", VA = "0x1818515C0")]
		public void OnBtnStartPracticeClick()
		{
		}

		// Token: 0x0601EA6F RID: 125551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA6F")]
		[Address(RVA = "0x1852120", Offset = "0x1850D20", VA = "0x181852120")]
		public void OnZoneMapEmptyAreaClicked()
		{
		}

		// Token: 0x0601EA70 RID: 125552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA70")]
		[Address(RVA = "0x1851DF0", Offset = "0x18509F0", VA = "0x181851DF0")]
		public void OnReplayStoryOpenClick()
		{
		}

		// Token: 0x0601EA71 RID: 125553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA71")]
		[Address(RVA = "0x1851EF0", Offset = "0x1850AF0", VA = "0x181851EF0")]
		public void OnReplayStoryTrigClick(int index)
		{
		}

		// Token: 0x0601EA72 RID: 125554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA72")]
		[Address(RVA = "0x1851690", Offset = "0x1850290", VA = "0x181851690")]
		public void OnDetailBtnClicked()
		{
		}

		// Token: 0x0601EA73 RID: 125555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA73")]
		[Address(RVA = "0x1851750", Offset = "0x1850350", VA = "0x181851750")]
		public void OnEnemyHandBookOpen()
		{
		}

		// Token: 0x0601EA74 RID: 125556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA74")]
		[Address(RVA = "0x1851CE0", Offset = "0x18508E0", VA = "0x181851CE0")]
		public void OnOpenRewardClick()
		{
		}

		// Token: 0x0601EA75 RID: 125557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA75")]
		[Address(RVA = "0x1852630", Offset = "0x1851230", VA = "0x181852630")]
		public void ToggleAutoBattle()
		{
		}

		// Token: 0x0601EA76 RID: 125558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA76")]
		[Address(RVA = "0x1851240", Offset = "0x184FE40", VA = "0x181851240")]
		public void OnBeHard()
		{
		}

		// Token: 0x0601EA77 RID: 125559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA77")]
		[Address(RVA = "0x1851380", Offset = "0x184FF80", VA = "0x181851380")]
		public void OnBeNormal()
		{
		}

		// Token: 0x0601EA78 RID: 125560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA78")]
		[Address(RVA = "0x1851C00", Offset = "0x1850800", VA = "0x181851C00")]
		public void OnLockedHardBattleClick()
		{
		}

		// Token: 0x0601EA79 RID: 125561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA79")]
		[Address(RVA = "0x1852A10", Offset = "0x1851610", VA = "0x181852A10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EA7A RID: 125562 RVA: 0x000AF2C0 File Offset: 0x000AD4C0
		[Token(Token = "0x601EA7A")]
		[Address(RVA = "0x1852840", Offset = "0x1851440", VA = "0x181852840")]
		private bool _CheckCostBeforeStartBattle()
		{
			return default(bool);
		}

		// Token: 0x0601EA7B RID: 125563 RVA: 0x000AF2D8 File Offset: 0x000AD4D8
		[Token(Token = "0x601EA7B")]
		[Address(RVA = "0x1852700", Offset = "0x1851300", VA = "0x181852700")]
		private bool _CheckApBeforeStartBattle(StageViewModel model)
		{
			return default(bool);
		}

		// Token: 0x0601EA7C RID: 125564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA7C")]
		[Address(RVA = "0x18528D0", Offset = "0x18514D0", VA = "0x1818528D0")]
		private void _GoToSquad(bool isPractice)
		{
		}

		// Token: 0x0601EA7D RID: 125565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA7D")]
		[Address(RVA = "0x1852D80", Offset = "0x1851980", VA = "0x181852D80")]
		private void _OnGoToSquad(string stageId, string hardId, bool isHard, bool isPractice, bool isAuto)
		{
		}

		// Token: 0x0601EA7E RID: 125566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA7E")]
		[Address(RVA = "0x1853500", Offset = "0x1852100", VA = "0x181853500")]
		private void _OpenSquadPage(string stageId, string hardId, bool isPractive, bool isAuto, bool isHard)
		{
		}

		// Token: 0x0601EA7F RID: 125567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA7F")]
		[Address(RVA = "0x1853BB0", Offset = "0x18527B0", VA = "0x181853BB0")]
		public DeepSeaRPBattlePreviewState()
		{
		}

		// Token: 0x0601EA80 RID: 125568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EA80")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601EA81 RID: 125569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA81")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601EA82 RID: 125570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA82")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601EA83 RID: 125571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA83")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x040291A1 RID: 168353
		[Token(Token = "0x40291A1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DeepSeaRPBattleDetailView _battleDetailView;

		// Token: 0x040291A2 RID: 168354
		[Token(Token = "0x40291A2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DeepSeaRPBattleStoryView _battleStoryView;

		// Token: 0x040291A3 RID: 168355
		[Token(Token = "0x40291A3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DeepSeaRPBattlePreviewInfoBasicPanel _battleInfoPanel;

		// Token: 0x040291A4 RID: 168356
		[Token(Token = "0x40291A4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private DeepSeaRPBattlePreviewInfoBasicPanel _battleInfoHardPanel;

		// Token: 0x040291A5 RID: 168357
		[Token(Token = "0x40291A5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _apStatusCanvasGroup;

		// Token: 0x040291A6 RID: 168358
		[Token(Token = "0x40291A6")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x040291A7 RID: 168359
		[Token(Token = "0x40291A7")]
		[FieldOffset(Offset = "0xA0")]
		private DeepSeaRPBattlePreviewStateBean m_stateBean;

		// Token: 0x040291A8 RID: 168360
		[Token(Token = "0x40291A8")]
		[FieldOffset(Offset = "0xA8")]
		private IStateCacheHandler m_runtimeHandler;

		// Token: 0x040291A9 RID: 168361
		[Token(Token = "0x40291A9")]
		[FieldOffset(Offset = "0xB0")]
		private DeepSeaRolePlayPage m_page;

		// Token: 0x040291AA RID: 168362
		[Token(Token = "0x40291AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040291AB RID: 168363
		[Token(Token = "0x40291AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040291AC RID: 168364
		[Token(Token = "0x40291AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x040291AD RID: 168365
		[Token(Token = "0x40291AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x040291AE RID: 168366
		[Token(Token = "0x40291AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040291AF RID: 168367
		[Token(Token = "0x40291AF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040291B0 RID: 168368
		[Token(Token = "0x40291B0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x040291B1 RID: 168369
		[Token(Token = "0x40291B1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnStartBattleClick;

		// Token: 0x040291B2 RID: 168370
		[Token(Token = "0x40291B2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBtnStartPracticeClick;

		// Token: 0x040291B3 RID: 168371
		[Token(Token = "0x40291B3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnZoneMapEmptyAreaClicked;

		// Token: 0x040291B4 RID: 168372
		[Token(Token = "0x40291B4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnReplayStoryOpenClick;

		// Token: 0x040291B5 RID: 168373
		[Token(Token = "0x40291B5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnReplayStoryTrigClick;

		// Token: 0x040291B6 RID: 168374
		[Token(Token = "0x40291B6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDetailBtnClicked;

		// Token: 0x040291B7 RID: 168375
		[Token(Token = "0x40291B7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnEnemyHandBookOpen;

		// Token: 0x040291B8 RID: 168376
		[Token(Token = "0x40291B8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnOpenRewardClick;

		// Token: 0x040291B9 RID: 168377
		[Token(Token = "0x40291B9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ToggleAutoBattle;

		// Token: 0x040291BA RID: 168378
		[Token(Token = "0x40291BA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBeHard;

		// Token: 0x040291BB RID: 168379
		[Token(Token = "0x40291BB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnBeNormal;

		// Token: 0x040291BC RID: 168380
		[Token(Token = "0x40291BC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnLockedHardBattleClick;

		// Token: 0x040291BD RID: 168381
		[Token(Token = "0x40291BD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040291BE RID: 168382
		[Token(Token = "0x40291BE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckCostBeforeStartBattle;

		// Token: 0x040291BF RID: 168383
		[Token(Token = "0x40291BF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CheckApBeforeStartBattle;

		// Token: 0x040291C0 RID: 168384
		[Token(Token = "0x40291C0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GoToSquad;

		// Token: 0x040291C1 RID: 168385
		[Token(Token = "0x40291C1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnGoToSquad;

		// Token: 0x040291C2 RID: 168386
		[Token(Token = "0x40291C2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OpenSquadPage;

		// Token: 0x040291C3 RID: 168387
		[Token(Token = "0x40291C3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
