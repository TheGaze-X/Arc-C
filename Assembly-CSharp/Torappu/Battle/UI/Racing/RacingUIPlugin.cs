using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Racing
{
	// Token: 0x02003429 RID: 13353
	[Token(Token = "0x2003429")]
	public class RacingUIPlugin : UIController.Plugin
	{
		// Token: 0x060155E4 RID: 87524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155E4")]
		[Address(RVA = "0xDD36B0", Offset = "0xDD22B0", VA = "0x180DD36B0", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x060155E5 RID: 87525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155E5")]
		[Address(RVA = "0xDD3C00", Offset = "0xDD2800", VA = "0x180DD3C00", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x060155E6 RID: 87526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155E6")]
		[Address(RVA = "0xDD3990", Offset = "0xDD2590", VA = "0x180DD3990", Slot = "16")]
		public override void OnGameReady()
		{
		}

		// Token: 0x060155E7 RID: 87527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155E7")]
		[Address(RVA = "0xDD3B30", Offset = "0xDD2730", VA = "0x180DD3B30", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x060155E8 RID: 87528 RVA: 0x0008B860 File Offset: 0x00089A60
		[Token(Token = "0x60155E8")]
		[Address(RVA = "0xDD2FC0", Offset = "0xDD1BC0", VA = "0x180DD2FC0", Slot = "44")]
		public override bool CanPressBackButton()
		{
			return default(bool);
		}

		// Token: 0x060155E9 RID: 87529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155E9")]
		[Address(RVA = "0xDD4360", Offset = "0xDD2F60", VA = "0x180DD4360", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x060155EA RID: 87530 RVA: 0x0008B878 File Offset: 0x00089A78
		[Token(Token = "0x60155EA")]
		[Address(RVA = "0xDD30B0", Offset = "0xDD1CB0", VA = "0x180DD30B0", Slot = "25")]
		public override bool HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x060155EB RID: 87531 RVA: 0x0008B890 File Offset: 0x00089A90
		[Token(Token = "0x60155EB")]
		[Address(RVA = "0xDD3160", Offset = "0xDD1D60", VA = "0x180DD3160", Slot = "32")]
		public override bool HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x060155EC RID: 87532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155EC")]
		[Address(RVA = "0xDD40A0", Offset = "0xDD2CA0", VA = "0x180DD40A0")]
		public void OnStartCountdownComplete()
		{
		}

		// Token: 0x060155ED RID: 87533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60155ED")]
		[Address(RVA = "0xDD3430", Offset = "0xDD2030", VA = "0x180DD3430")]
		public Tween OnFinishCountdownComplete()
		{
			return null;
		}

		// Token: 0x060155EE RID: 87534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60155EE")]
		[Address(RVA = "0xDD4660", Offset = "0xDD3260", VA = "0x180DD4660")]
		private Sprite _GetPlayerInsectIcon(string racerId)
		{
			return null;
		}

		// Token: 0x060155EF RID: 87535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60155EF")]
		[Address(RVA = "0xDD4970", Offset = "0xDD3570", VA = "0x180DD4970")]
		private string _GetRacerItemIdByRacerId(string racerId, SandboxV2Data dataTable)
		{
			return null;
		}

		// Token: 0x060155F0 RID: 87536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F0")]
		[Address(RVA = "0xDD4AE0", Offset = "0xDD36E0", VA = "0x180DD4AE0")]
		private void _InitRacingTopbar()
		{
		}

		// Token: 0x060155F1 RID: 87537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F1")]
		[Address(RVA = "0xDD5DF0", Offset = "0xDD49F0", VA = "0x180DD5DF0")]
		private void _UpdateTopbarInfo()
		{
		}

		// Token: 0x060155F2 RID: 87538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F2")]
		[Address(RVA = "0xDD5A70", Offset = "0xDD4670", VA = "0x180DD5A70")]
		private void _UpdateButtons()
		{
		}

		// Token: 0x060155F3 RID: 87539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F3")]
		[Address(RVA = "0xDD43F0", Offset = "0xDD2FF0", VA = "0x180DD43F0")]
		private void _ActiveButtons(bool value)
		{
		}

		// Token: 0x060155F4 RID: 87540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F4")]
		[Address(RVA = "0xDD5370", Offset = "0xDD3F70", VA = "0x180DD5370")]
		private void _OnGainRacingItem(string itemId, string itemName)
		{
		}

		// Token: 0x060155F5 RID: 87541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F5")]
		[Address(RVA = "0xDD3D80", Offset = "0xDD2980", VA = "0x180DD3D80")]
		public void OnRacingItemButtonClicked()
		{
		}

		// Token: 0x060155F6 RID: 87542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F6")]
		[Address(RVA = "0xDD3240", Offset = "0xDD1E40", VA = "0x180DD3240")]
		public void OnCameraModeButtonClicked()
		{
		}

		// Token: 0x060155F7 RID: 87543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F7")]
		[Address(RVA = "0xDD5660", Offset = "0xDD4260", VA = "0x180DD5660")]
		private void _RegisterEventListenerWhenInit()
		{
		}

		// Token: 0x060155F8 RID: 87544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F8")]
		[Address(RVA = "0xDD5730", Offset = "0xDD4330", VA = "0x180DD5730")]
		private void _ShowExitConfirmDialog(object obj)
		{
		}

		// Token: 0x060155F9 RID: 87545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155F9")]
		[Address(RVA = "0xDD52F0", Offset = "0xDD3EF0", VA = "0x180DD52F0")]
		private void _OnConfirmFinish()
		{
		}

		// Token: 0x060155FA RID: 87546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155FA")]
		[Address(RVA = "0xDD5270", Offset = "0xDD3E70", VA = "0x180DD5270")]
		private void _OnConfirmCancel()
		{
		}

		// Token: 0x060155FB RID: 87547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155FB")]
		[Address(RVA = "0xDD6660", Offset = "0xDD5260", VA = "0x180DD6660")]
		public RacingUIPlugin()
		{
		}

		// Token: 0x06015600 RID: 87552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015600")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06015601 RID: 87553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015601")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x06015602 RID: 87554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015602")]
		[Address(RVA = "0x9CCDF0", Offset = "0x9CB9F0", VA = "0x1809CCDF0")]
		private void <>xLuaBaseProxy_OnGameReady()
		{
		}

		// Token: 0x06015603 RID: 87555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015603")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x06015604 RID: 87556 RVA: 0x0008B8A8 File Offset: 0x00089AA8
		[Token(Token = "0x6015604")]
		[Address(RVA = "0xDD4300", Offset = "0xDD2F00", VA = "0x180DD4300")]
		private bool <>xLuaBaseProxy_CanPressBackButton()
		{
			return default(bool);
		}

		// Token: 0x06015605 RID: 87557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015605")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06015606 RID: 87558 RVA: 0x0008B8C0 File Offset: 0x00089AC0
		[Token(Token = "0x6015606")]
		[Address(RVA = "0x960A00", Offset = "0x95F600", VA = "0x180960A00")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015607 RID: 87559 RVA: 0x0008B8D8 File Offset: 0x00089AD8
		[Token(Token = "0x6015607")]
		[Address(RVA = "0x7D2470", Offset = "0x7D1070", VA = "0x1807D2470")]
		private bool <>xLuaBaseProxy_HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x040198F6 RID: 104694
		[Token(Token = "0x40198F6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum RACING_START_COUNTDOWN_STATE;

		// Token: 0x040198F7 RID: 104695
		[Token(Token = "0x40198F7")]
		[FieldOffset(Offset = "0x4")]
		public static readonly UIStateEnum RACING_FINISH_COUNTDOWN_STATE;

		// Token: 0x040198F8 RID: 104696
		[Token(Token = "0x40198F8")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UIStateEnum RACING_SYSTEM_MENU_STATE;

		// Token: 0x040198F9 RID: 104697
		[Token(Token = "0x40198F9")]
		private const string OTHER_PLAYER_HANDLE_PATH = "UI/SandboxV2/[UC]Common/Battle/Widget/sandbox_racing_handle_other.prefab";

		// Token: 0x040198FA RID: 104698
		[Token(Token = "0x40198FA")]
		private const string CIRCLE_PREFAB_PATH = "UI/SandboxV2/[UC]Common/Battle/Widget/sandbox_racing_circle.prefab";

		// Token: 0x040198FB RID: 104699
		[Token(Token = "0x40198FB")]
		private const string INIT_RACING_TIME = "00:00.00";

		// Token: 0x040198FC RID: 104700
		[Token(Token = "0x40198FC")]
		private const float IMAGE_FADE_TIME = 0.3f;

		// Token: 0x040198FD RID: 104701
		[Token(Token = "0x40198FD")]
		private const float DARK_BACKGROUND_ALPHA = 0.5f;

		// Token: 0x040198FE RID: 104702
		[Token(Token = "0x40198FE")]
		private const float INVALID_ITEM_IMAGE_FADE_DELAY_TIME = 0.05f;

		// Token: 0x040198FF RID: 104703
		[Token(Token = "0x40198FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x04019900 RID: 104704
		[Token(Token = "0x4019900")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasObject _racingBattleAtlas;

		// Token: 0x04019901 RID: 104705
		[Token(Token = "0x4019901")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Battle Transition")]
		private GameObject _battleTransitionHolder;

		// Token: 0x04019902 RID: 104706
		[Token(Token = "0x4019902")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Battle Transition")]
		private Image _battleTransitionBgImage;

		// Token: 0x04019903 RID: 104707
		[Token(Token = "0x4019903")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Battle Transition")]
		private UIAnimationLocation _gameFinishAnim;

		// Token: 0x04019904 RID: 104708
		[Token(Token = "0x4019904")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Racing Progress")]
		private GameObject _racingInfoHolder;

		// Token: 0x04019905 RID: 104709
		[Token(Token = "0x4019905")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Racing Progress")]
		private Slider _sliderRacingProgress;

		// Token: 0x04019906 RID: 104710
		[Token(Token = "0x4019906")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Racing Progress")]
		private Transform _otherPlayerHandleHolder;

		// Token: 0x04019907 RID: 104711
		[Token(Token = "0x4019907")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Racing Progress")]
		private Transform _circlesHolder;

		// Token: 0x04019908 RID: 104712
		[Token(Token = "0x4019908")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Racing Progress")]
		private string _unfinishedCircleImg;

		// Token: 0x04019909 RID: 104713
		[Token(Token = "0x4019909")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Racing Progress")]
		private string _finishedCircleImg;

		// Token: 0x0401990A RID: 104714
		[Token(Token = "0x401990A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Racing Progress")]
		private Image _playerIcon;

		// Token: 0x0401990B RID: 104715
		[Token(Token = "0x401990B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Racing Progress")]
		private Text _textMaxPlayerNum;

		// Token: 0x0401990C RID: 104716
		[Token(Token = "0x401990C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Racing Progress")]
		private Text _textPlayerRanking;

		// Token: 0x0401990D RID: 104717
		[Token(Token = "0x401990D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Racing Progress")]
		private Text _textRacingTime;

		// Token: 0x0401990E RID: 104718
		[Token(Token = "0x401990E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Racing Progress")]
		private UIAnimationLocation _topbarShowAnim;

		// Token: 0x0401990F RID: 104719
		[Token(Token = "0x401990F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Buttons")]
		private Sprite _btnSystemMenu;

		// Token: 0x04019910 RID: 104720
		[Token(Token = "0x4019910")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Buttons")]
		private Button _racingItemButton;

		// Token: 0x04019911 RID: 104721
		[Token(Token = "0x4019911")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Buttons")]
		private UIAnimationLocation _useItemAnim;

		// Token: 0x04019912 RID: 104722
		[Token(Token = "0x4019912")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Buttons")]
		private UIAnimationLocation _gainItemAnim;

		// Token: 0x04019913 RID: 104723
		[Token(Token = "0x4019913")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Buttons")]
		private UIAtlasImage _itemIcon;

		// Token: 0x04019914 RID: 104724
		[Token(Token = "0x4019914")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Buttons")]
		private Text _itemName;

		// Token: 0x04019915 RID: 104725
		[Token(Token = "0x4019915")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Buttons")]
		private UIAtlasImage _invalidItemImage;

		// Token: 0x04019916 RID: 104726
		[Token(Token = "0x4019916")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Buttons")]
		private GameObject _validItemHolder;

		// Token: 0x04019917 RID: 104727
		[Token(Token = "0x4019917")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Buttons")]
		private UISwitchToggle _cameraModeButton;

		// Token: 0x04019918 RID: 104728
		[Token(Token = "0x4019918")]
		[FieldOffset(Offset = "0x110")]
		private bool m_racingStarted;

		// Token: 0x04019919 RID: 104729
		[Token(Token = "0x4019919")]
		[FieldOffset(Offset = "0x118")]
		private GameModeFactory.RacingGameMode m_gameMode;

		// Token: 0x0401991A RID: 104730
		[Token(Token = "0x401991A")]
		[FieldOffset(Offset = "0x120")]
		private List<UIAtlasImage> m_circles;

		// Token: 0x0401991B RID: 104731
		[Token(Token = "0x401991B")]
		[FieldOffset(Offset = "0x128")]
		private Dictionary<uint, GameObject> m_racingHandleDict;

		// Token: 0x0401991C RID: 104732
		[Token(Token = "0x401991C")]
		[FieldOffset(Offset = "0x130")]
		private FP m_realRacingTime;

		// Token: 0x0401991D RID: 104733
		[Token(Token = "0x401991D")]
		[FieldOffset(Offset = "0x138")]
		private Tween m_racingUseItemTween;

		// Token: 0x0401991E RID: 104734
		[Token(Token = "0x401991E")]
		[FieldOffset(Offset = "0x140")]
		private Tween m_racingGainItemTween;

		// Token: 0x0401991F RID: 104735
		[Token(Token = "0x401991F")]
		[FieldOffset(Offset = "0x148")]
		private SandboxV2RacingItemInfo m_lastItemInfo;

		// Token: 0x04019920 RID: 104736
		[Token(Token = "0x4019920")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04019921 RID: 104737
		[Token(Token = "0x4019921")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x04019922 RID: 104738
		[Token(Token = "0x4019922")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x04019923 RID: 104739
		[Token(Token = "0x4019923")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x04019924 RID: 104740
		[Token(Token = "0x4019924")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CanPressBackButton;

		// Token: 0x04019925 RID: 104741
		[Token(Token = "0x4019925")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x04019926 RID: 104742
		[Token(Token = "0x4019926")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishedStateSwitch;

		// Token: 0x04019927 RID: 104743
		[Token(Token = "0x4019927")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HookBattleSystemMenuSwitch;

		// Token: 0x04019928 RID: 104744
		[Token(Token = "0x4019928")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnStartCountdownComplete;

		// Token: 0x04019929 RID: 104745
		[Token(Token = "0x4019929")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnFinishCountdownComplete;

		// Token: 0x0401992A RID: 104746
		[Token(Token = "0x401992A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetPlayerInsectIcon;

		// Token: 0x0401992B RID: 104747
		[Token(Token = "0x401992B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetRacerItemIdByRacerId;

		// Token: 0x0401992C RID: 104748
		[Token(Token = "0x401992C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitRacingTopbar;

		// Token: 0x0401992D RID: 104749
		[Token(Token = "0x401992D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateTopbarInfo;

		// Token: 0x0401992E RID: 104750
		[Token(Token = "0x401992E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateButtons;

		// Token: 0x0401992F RID: 104751
		[Token(Token = "0x401992F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ActiveButtons;

		// Token: 0x04019930 RID: 104752
		[Token(Token = "0x4019930")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnGainRacingItem;

		// Token: 0x04019931 RID: 104753
		[Token(Token = "0x4019931")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnRacingItemButtonClicked;

		// Token: 0x04019932 RID: 104754
		[Token(Token = "0x4019932")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnCameraModeButtonClicked;

		// Token: 0x04019933 RID: 104755
		[Token(Token = "0x4019933")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RegisterEventListenerWhenInit;

		// Token: 0x04019934 RID: 104756
		[Token(Token = "0x4019934")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ShowExitConfirmDialog;

		// Token: 0x04019935 RID: 104757
		[Token(Token = "0x4019935")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnConfirmFinish;

		// Token: 0x04019936 RID: 104758
		[Token(Token = "0x4019936")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnConfirmCancel;

		// Token: 0x04019937 RID: 104759
		[Token(Token = "0x4019937")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
