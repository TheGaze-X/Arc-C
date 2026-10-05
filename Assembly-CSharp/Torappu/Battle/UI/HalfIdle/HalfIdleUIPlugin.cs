using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.HalfIdle
{
	// Token: 0x02003425 RID: 13349
	[Token(Token = "0x2003425")]
	public class HalfIdleUIPlugin : UIController.Plugin
	{
		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x06015597 RID: 87447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003287")]
		private GameModeFactory.HalfIdleGameMode gameMode
		{
			[Token(Token = "0x6015597")]
			[Address(RVA = "0xDD1770", Offset = "0xDD0370", VA = "0x180DD1770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x06015598 RID: 87448 RVA: 0x0008B5A8 File Offset: 0x000897A8
		[Token(Token = "0x17003288")]
		public override bool forceUpdateCharacterLevel
		{
			[Token(Token = "0x6015598")]
			[Address(RVA = "0xDD16E0", Offset = "0xDD02E0", VA = "0x180DD16E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015599 RID: 87449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015599")]
		[Address(RVA = "0xDD05F0", Offset = "0xDCF1F0", VA = "0x180DD05F0", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x0601559A RID: 87450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601559A")]
		[Address(RVA = "0xDD0870", Offset = "0xDCF470", VA = "0x180DD0870", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0601559B RID: 87451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601559B")]
		[Address(RVA = "0xDD0B70", Offset = "0xDCF770", VA = "0x180DD0B70", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x0601559C RID: 87452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601559C")]
		[Address(RVA = "0xDD0FB0", Offset = "0xDCFBB0", VA = "0x180DD0FB0", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x0601559D RID: 87453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601559D")]
		[Address(RVA = "0xDD0D90", Offset = "0xDCF990", VA = "0x180DD0D90", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x0601559E RID: 87454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601559E")]
		[Address(RVA = "0xDCFF00", Offset = "0xDCEB00", VA = "0x180DCFF00", Slot = "29")]
		public override RectTransform HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x0601559F RID: 87455 RVA: 0x0008B5C0 File Offset: 0x000897C0
		[Token(Token = "0x601559F")]
		[Address(RVA = "0xDCFF70", Offset = "0xDCEB70", VA = "0x180DCFF70", Slot = "30")]
		public override bool HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x060155A0 RID: 87456 RVA: 0x0008B5D8 File Offset: 0x000897D8
		[Token(Token = "0x60155A0")]
		[Address(RVA = "0xDCFE90", Offset = "0xDCEA90", VA = "0x180DCFE90", Slot = "31")]
		public override bool HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x060155A1 RID: 87457 RVA: 0x0008B5F0 File Offset: 0x000897F0
		[Token(Token = "0x60155A1")]
		[Address(RVA = "0xDD0210", Offset = "0xDCEE10", VA = "0x180DD0210", Slot = "45")]
		public override bool HookPauseMask(bool isPause)
		{
			return default(bool);
		}

		// Token: 0x060155A2 RID: 87458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155A2")]
		[Address(RVA = "0xDD0430", Offset = "0xDCF030", VA = "0x180DD0430", Slot = "40")]
		public override void OnCardMenuShow(Deck.Card card)
		{
		}

		// Token: 0x060155A3 RID: 87459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155A3")]
		[Address(RVA = "0xDD0550", Offset = "0xDCF150", VA = "0x180DD0550", Slot = "39")]
		public override void OnCharacterMenuShow(Character character)
		{
		}

		// Token: 0x060155A4 RID: 87460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155A4")]
		[Address(RVA = "0xDD04D0", Offset = "0xDCF0D0", VA = "0x180DD04D0", Slot = "41")]
		public override void OnCharacterMenuHide()
		{
		}

		// Token: 0x060155A5 RID: 87461 RVA: 0x0008B608 File Offset: 0x00089808
		[Token(Token = "0x60155A5")]
		[Address(RVA = "0xDD0010", Offset = "0xDCEC10", VA = "0x180DD0010", Slot = "32")]
		public override bool HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x060155A6 RID: 87462 RVA: 0x0008B620 File Offset: 0x00089820
		[Token(Token = "0x60155A6")]
		[Address(RVA = "0xDD0310", Offset = "0xDCEF10", VA = "0x180DD0310", Slot = "51")]
		public override bool HookShowCard(UICard card)
		{
			return default(bool);
		}

		// Token: 0x060155A7 RID: 87463 RVA: 0x0008B638 File Offset: 0x00089838
		[Token(Token = "0x60155A7")]
		[Address(RVA = "0xDD00E0", Offset = "0xDCECE0", VA = "0x180DD00E0", Slot = "52")]
		public override bool HookDragAndPutDownState(UICard card, out UIStateEnum uiState)
		{
			return default(bool);
		}

		// Token: 0x060155A8 RID: 87464 RVA: 0x0008B650 File Offset: 0x00089850
		[Token(Token = "0x60155A8")]
		[Address(RVA = "0xDCFE00", Offset = "0xDCEA00", VA = "0x180DCFE00", Slot = "25")]
		public override bool HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x060155A9 RID: 87465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155A9")]
		[Address(RVA = "0xDD0EB0", Offset = "0xDCFAB0", VA = "0x180DD0EB0")]
		public void SetTrapBuildingImage(string key, bool show)
		{
		}

		// Token: 0x060155AA RID: 87466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155AA")]
		[Address(RVA = "0xDD1090", Offset = "0xDCFC90", VA = "0x180DD1090")]
		private void _BindBattlePluginEvents()
		{
		}

		// Token: 0x060155AB RID: 87467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155AB")]
		[Address(RVA = "0xDD1470", Offset = "0xDD0070", VA = "0x180DD1470")]
		private void _UnbindBattlePluginEvents()
		{
		}

		// Token: 0x060155AC RID: 87468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155AC")]
		[Address(RVA = "0xDD1300", Offset = "0xDCFF00", VA = "0x180DD1300")]
		private void _OnSystemMenuClosed(object arg)
		{
		}

		// Token: 0x060155AD RID: 87469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155AD")]
		[Address(RVA = "0xDD13A0", Offset = "0xDCFFA0", VA = "0x180DD13A0")]
		private void _OnSystemMenuConfirmed(object arg)
		{
		}

		// Token: 0x060155AE RID: 87470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155AE")]
		[Address(RVA = "0xDD1230", Offset = "0xDCFE30", VA = "0x180DD1230")]
		private void _OnBottomMaskClicked(object arg)
		{
		}

		// Token: 0x060155AF RID: 87471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155AF")]
		[Address(RVA = "0xDD0680", Offset = "0xDCF280", VA = "0x180DD0680")]
		private void OnDestroy()
		{
		}

		// Token: 0x060155B0 RID: 87472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155B0")]
		[Address(RVA = "0xDD1630", Offset = "0xDD0230", VA = "0x180DD1630")]
		public HalfIdleUIPlugin()
		{
		}

		// Token: 0x060155B1 RID: 87473 RVA: 0x0008B668 File Offset: 0x00089868
		[Token(Token = "0x60155B1")]
		[Address(RVA = "0xDD0FA0", Offset = "0xDCFBA0", VA = "0x180DD0FA0")]
		private bool <>xLuaBaseProxy_get_forceUpdateCharacterLevel()
		{
			return default(bool);
		}

		// Token: 0x060155B2 RID: 87474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155B2")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x060155B3 RID: 87475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155B3")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x060155B4 RID: 87476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155B4")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x060155B5 RID: 87477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155B5")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x060155B6 RID: 87478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155B6")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x060155B7 RID: 87479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60155B7")]
		[Address(RVA = "0xD9C3E0", Offset = "0xD9AFE0", VA = "0x180D9C3E0")]
		private RectTransform <>xLuaBaseProxy_HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x060155B8 RID: 87480 RVA: 0x0008B680 File Offset: 0x00089880
		[Token(Token = "0x60155B8")]
		[Address(RVA = "0xD9C3F0", Offset = "0xD9AFF0", VA = "0x180D9C3F0")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x060155B9 RID: 87481 RVA: 0x0008B698 File Offset: 0x00089898
		[Token(Token = "0x60155B9")]
		[Address(RVA = "0xD9C3D0", Offset = "0xD9AFD0", VA = "0x180D9C3D0")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x060155BA RID: 87482 RVA: 0x0008B6B0 File Offset: 0x000898B0
		[Token(Token = "0x60155BA")]
		[Address(RVA = "0xA032B0", Offset = "0xA01EB0", VA = "0x180A032B0")]
		private bool <>xLuaBaseProxy_HookPauseMask(bool P0)
		{
			return default(bool);
		}

		// Token: 0x060155BB RID: 87483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155BB")]
		[Address(RVA = "0x9CCDB0", Offset = "0x9CB9B0", VA = "0x1809CCDB0")]
		private void <>xLuaBaseProxy_OnCardMenuShow(Deck.Card P0)
		{
		}

		// Token: 0x060155BC RID: 87484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155BC")]
		[Address(RVA = "0x9CCDD0", Offset = "0x9CB9D0", VA = "0x1809CCDD0")]
		private void <>xLuaBaseProxy_OnCharacterMenuShow(Character P0)
		{
		}

		// Token: 0x060155BD RID: 87485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155BD")]
		[Address(RVA = "0x9CCDC0", Offset = "0x9CB9C0", VA = "0x1809CCDC0")]
		private void <>xLuaBaseProxy_OnCharacterMenuHide()
		{
		}

		// Token: 0x060155BE RID: 87486 RVA: 0x0008B6C8 File Offset: 0x000898C8
		[Token(Token = "0x60155BE")]
		[Address(RVA = "0x7D2470", Offset = "0x7D1070", VA = "0x1807D2470")]
		private bool <>xLuaBaseProxy_HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x060155BF RID: 87487 RVA: 0x0008B6E0 File Offset: 0x000898E0
		[Token(Token = "0x60155BF")]
		[Address(RVA = "0xDD0F90", Offset = "0xDCFB90", VA = "0x180DD0F90")]
		private bool <>xLuaBaseProxy_HookShowCard(UICard P0)
		{
			return default(bool);
		}

		// Token: 0x060155C0 RID: 87488 RVA: 0x0008B6F8 File Offset: 0x000898F8
		[Token(Token = "0x60155C0")]
		[Address(RVA = "0xDD0F80", Offset = "0xDCFB80", VA = "0x180DD0F80")]
		private bool <>xLuaBaseProxy_HookDragAndPutDownState(UICard P0, out UIStateEnum P1)
		{
			return default(bool);
		}

		// Token: 0x060155C1 RID: 87489 RVA: 0x0008B710 File Offset: 0x00089910
		[Token(Token = "0x60155C1")]
		[Address(RVA = "0x960A00", Offset = "0x95F600", VA = "0x180960A00")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x040198AA RID: 104618
		[Token(Token = "0x40198AA")]
		public const UIStateEnum BUILD_TRAP_STATE = UIStateEnum.PLUGIN_0;

		// Token: 0x040198AB RID: 104619
		[Token(Token = "0x40198AB")]
		public const UIStateEnum DRAG_AND_PUT_DOWN_TRAP_STATE = UIStateEnum.PLUGIN_1;

		// Token: 0x040198AC RID: 104620
		[Token(Token = "0x40198AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Card List")]
		private HalfIdleUIBattleCardListWidget _cardListWidget;

		// Token: 0x040198AD RID: 104621
		[Token(Token = "0x40198AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("States")]
		private UIStateNode[] _states;

		// Token: 0x040198AE RID: 104622
		[Token(Token = "0x40198AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _trapBuildingImageContainer;

		// Token: 0x040198AF RID: 104623
		[Token(Token = "0x40198AF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HalfIdleUIBattleFailedPanel _failedPanel;

		// Token: 0x040198B0 RID: 104624
		[Token(Token = "0x40198B0")]
		[FieldOffset(Offset = "0x48")]
		private FP m_oldPlayTime;

		// Token: 0x040198B1 RID: 104625
		[Token(Token = "0x40198B1")]
		[FieldOffset(Offset = "0x50")]
		private List<GameObject> m_enemyWaveTimeIndicators;

		// Token: 0x040198B2 RID: 104626
		[Token(Token = "0x40198B2")]
		[FieldOffset(Offset = "0x58")]
		private FP m_oldBossWaveRatio;

		// Token: 0x040198B3 RID: 104627
		[Token(Token = "0x40198B3")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040198B4 RID: 104628
		[Token(Token = "0x40198B4")]
		[FieldOffset(Offset = "0x70")]
		private EnableStateWithKey m_isTrapBuildingShow;

		// Token: 0x040198B5 RID: 104629
		[Token(Token = "0x40198B5")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isGiveUp;

		// Token: 0x040198B6 RID: 104630
		[Token(Token = "0x40198B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x040198B7 RID: 104631
		[Token(Token = "0x40198B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_forceUpdateCharacterLevel;

		// Token: 0x040198B8 RID: 104632
		[Token(Token = "0x40198B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040198B9 RID: 104633
		[Token(Token = "0x40198B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x040198BA RID: 104634
		[Token(Token = "0x40198BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x040198BB RID: 104635
		[Token(Token = "0x40198BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x040198BC RID: 104636
		[Token(Token = "0x40198BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x040198BD RID: 104637
		[Token(Token = "0x40198BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelInit;

		// Token: 0x040198BE RID: 104638
		[Token(Token = "0x40198BE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelShow;

		// Token: 0x040198BF RID: 104639
		[Token(Token = "0x40198BF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelHide;

		// Token: 0x040198C0 RID: 104640
		[Token(Token = "0x40198C0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HookPauseMask;

		// Token: 0x040198C1 RID: 104641
		[Token(Token = "0x40198C1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCardMenuShow;

		// Token: 0x040198C2 RID: 104642
		[Token(Token = "0x40198C2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuShow;

		// Token: 0x040198C3 RID: 104643
		[Token(Token = "0x40198C3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuHide;

		// Token: 0x040198C4 RID: 104644
		[Token(Token = "0x40198C4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HookBattleSystemMenuSwitch;

		// Token: 0x040198C5 RID: 104645
		[Token(Token = "0x40198C5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HookShowCard;

		// Token: 0x040198C6 RID: 104646
		[Token(Token = "0x40198C6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HookDragAndPutDownState;

		// Token: 0x040198C7 RID: 104647
		[Token(Token = "0x40198C7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishedStateSwitch;

		// Token: 0x040198C8 RID: 104648
		[Token(Token = "0x40198C8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetTrapBuildingImage;

		// Token: 0x040198C9 RID: 104649
		[Token(Token = "0x40198C9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__BindBattlePluginEvents;

		// Token: 0x040198CA RID: 104650
		[Token(Token = "0x40198CA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UnbindBattlePluginEvents;

		// Token: 0x040198CB RID: 104651
		[Token(Token = "0x40198CB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnSystemMenuClosed;

		// Token: 0x040198CC RID: 104652
		[Token(Token = "0x40198CC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnSystemMenuConfirmed;

		// Token: 0x040198CD RID: 104653
		[Token(Token = "0x40198CD")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnBottomMaskClicked;

		// Token: 0x040198CE RID: 104654
		[Token(Token = "0x40198CE")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040198CF RID: 104655
		[Token(Token = "0x40198CF")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
