using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Sandbox;
using Torappu.UI;
using Torappu.UI.SandboxPerm.SandboxV2;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033CB RID: 13259
	[Token(Token = "0x20033CB")]
	public class SandboxUIPlugin : UIController.Plugin
	{
		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x06015274 RID: 86644 RVA: 0x0008A8A0 File Offset: 0x00088AA0
		[Token(Token = "0x17003235")]
		public SandboxBattleStyle battleStyle
		{
			[Token(Token = "0x6015274")]
			[Address(RVA = "0xD9DDD0", Offset = "0xD9C9D0", VA = "0x180D9DDD0")]
			get
			{
				return SandboxBattleStyle.DEFAULT;
			}
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x06015275 RID: 86645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003236")]
		public UIBattleSandboxPausePanel pausePanel
		{
			[Token(Token = "0x6015275")]
			[Address(RVA = "0xD9DF40", Offset = "0xD9CB40", VA = "0x180D9DF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x06015276 RID: 86646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003237")]
		public UIBattleSandboxConstruct constructPlugin
		{
			[Token(Token = "0x6015276")]
			[Address(RVA = "0xD9DEC0", Offset = "0xD9CAC0", VA = "0x180D9DEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x06015277 RID: 86647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003238")]
		public UIBattleSandboxUICardList cardListWidget
		{
			[Token(Token = "0x6015277")]
			[Address(RVA = "0xD9DE40", Offset = "0xD9CA40", VA = "0x180D9DE40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x06015278 RID: 86648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003239")]
		public UIBattleSandboxBagState bagState
		{
			[Token(Token = "0x6015278")]
			[Address(RVA = "0xD9DC50", Offset = "0xD9C850", VA = "0x180D9DC50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015279 RID: 86649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015279")]
		[Address(RVA = "0xD9B740", Offset = "0xD9A340", VA = "0x180D9B740", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0601527A RID: 86650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601527A")]
		[Address(RVA = "0xD9BE20", Offset = "0xD9AA20", VA = "0x180D9BE20", Slot = "14")]
		public override void OnGameReset(BattleController battleController)
		{
		}

		// Token: 0x0601527B RID: 86651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601527B")]
		[Address(RVA = "0xD9ACD0", Offset = "0xD998D0", VA = "0x180D9ACD0", Slot = "29")]
		public override RectTransform HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x0601527C RID: 86652 RVA: 0x0008A8B8 File Offset: 0x00088AB8
		[Token(Token = "0x601527C")]
		[Address(RVA = "0xD9ADA0", Offset = "0xD999A0", VA = "0x180D9ADA0", Slot = "30")]
		public override bool HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x0601527D RID: 86653 RVA: 0x0008A8D0 File Offset: 0x00088AD0
		[Token(Token = "0x601527D")]
		[Address(RVA = "0xD9AC40", Offset = "0xD99840", VA = "0x180D9AC40", Slot = "31")]
		public override bool HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x0601527E RID: 86654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601527E")]
		[Address(RVA = "0xD9C0C0", Offset = "0xD9ACC0", VA = "0x180D9C0C0")]
		public void OnItemCountChanged(object arg)
		{
		}

		// Token: 0x0601527F RID: 86655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601527F")]
		[Address(RVA = "0xD9C410", Offset = "0xD9B010", VA = "0x180D9C410", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06015280 RID: 86656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015280")]
		[Address(RVA = "0xD9C630", Offset = "0xD9B230", VA = "0x180D9C630")]
		private void _HookUITopBar()
		{
		}

		// Token: 0x06015281 RID: 86657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015281")]
		[Address(RVA = "0xD9B250", Offset = "0xD99E50", VA = "0x180D9B250")]
		public void OnBackpackButtonClicked()
		{
		}

		// Token: 0x06015282 RID: 86658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015282")]
		[Address(RVA = "0xD9BF40", Offset = "0xD9AB40", VA = "0x180D9BF40", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x06015283 RID: 86659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015283")]
		[Address(RVA = "0xD9B080", Offset = "0xD99C80", VA = "0x180D9B080", Slot = "37")]
		public override UICharacterInfoPanel.HookedCharacterInfoSubPanel[] HookCharacterInfoSubPanels()
		{
			return null;
		}

		// Token: 0x06015284 RID: 86660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015284")]
		[Address(RVA = "0xD9B330", Offset = "0xD99F30", VA = "0x180D9B330", Slot = "39")]
		public override void OnCharacterMenuShow(Character character)
		{
		}

		// Token: 0x06015285 RID: 86661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015285")]
		[Address(RVA = "0xD9C240", Offset = "0xD9AE40", VA = "0x180D9C240", Slot = "13")]
		public override void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x06015286 RID: 86662 RVA: 0x0008A8E8 File Offset: 0x00088AE8
		[Token(Token = "0x6015286")]
		[Address(RVA = "0xD9AF90", Offset = "0xD99B90", VA = "0x180D9AF90", Slot = "32")]
		public override bool HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015287 RID: 86663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015287")]
		[Address(RVA = "0xD9AB00", Offset = "0xD99700", VA = "0x180D9AB00", Slot = "34")]
		public override UICharacterMenuState.IUICharacterMenuPanel GetHookUICharacterMenuPanel(Character character)
		{
			return null;
		}

		// Token: 0x06015288 RID: 86664 RVA: 0x0008A900 File Offset: 0x00088B00
		[Token(Token = "0x6015288")]
		[Address(RVA = "0xD9AE30", Offset = "0xD99A30", VA = "0x180D9AE30", Slot = "24")]
		public override bool HookBattleFailedStateSwitch(BattleFailedStateParam param)
		{
			return default(bool);
		}

		// Token: 0x06015289 RID: 86665 RVA: 0x0008A918 File Offset: 0x00088B18
		[Token(Token = "0x6015289")]
		[Address(RVA = "0xD9B100", Offset = "0xD99D00", VA = "0x180D9B100", Slot = "27")]
		public override bool HookOnBattleFinishServiceStateEnter()
		{
			return default(bool);
		}

		// Token: 0x0601528A RID: 86666 RVA: 0x0008A930 File Offset: 0x00088B30
		[Token(Token = "0x601528A")]
		[Address(RVA = "0xD9B190", Offset = "0xD99D90", VA = "0x180D9B190", Slot = "45")]
		public override bool HookPauseMask(bool isPause)
		{
			return default(bool);
		}

		// Token: 0x0601528B RID: 86667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601528B")]
		[Address(RVA = "0xD9B4F0", Offset = "0xD9A0F0", VA = "0x180D9B4F0", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x0601528C RID: 86668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601528C")]
		[Address(RVA = "0xD9CC30", Offset = "0xD9B830", VA = "0x180D9CC30")]
		private void _PreloadAssets()
		{
		}

		// Token: 0x0601528D RID: 86669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601528D")]
		[Address(RVA = "0xD9CE00", Offset = "0xD9BA00", VA = "0x180D9CE00")]
		private void _RegisterEventListenerWhenInit()
		{
		}

		// Token: 0x0601528E RID: 86670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601528E")]
		[Address(RVA = "0xD9D4D0", Offset = "0xD9C0D0", VA = "0x180D9D4D0")]
		private void _ShowConfirmDialog(object obj)
		{
		}

		// Token: 0x0601528F RID: 86671 RVA: 0x0008A948 File Offset: 0x00088B48
		[Token(Token = "0x601528F")]
		[Address(RVA = "0xD9D040", Offset = "0xD9BC40", VA = "0x180D9D040")]
		private SandboxV2ConfirmDialogConfirmVisualType _RouteConfirmVisualType()
		{
			return SandboxV2ConfirmDialogConfirmVisualType.GREEN;
		}

		// Token: 0x06015290 RID: 86672 RVA: 0x0008A960 File Offset: 0x00088B60
		[Token(Token = "0x6015290")]
		[Address(RVA = "0xD9D120", Offset = "0xD9BD20", VA = "0x180D9D120")]
		private SandboxV2ConfirmDialogThemeType _RouteThemeType()
		{
			return SandboxV2ConfirmDialogThemeType.LIGHT;
		}

		// Token: 0x06015291 RID: 86673 RVA: 0x0008A978 File Offset: 0x00088B78
		[Token(Token = "0x6015291")]
		[Address(RVA = "0xD9CED0", Offset = "0xD9BAD0", VA = "0x180D9CED0")]
		private SandboxV2ConfirmIconType _RouteConfirmIconType()
		{
			return SandboxV2ConfirmIconType.COMMON;
		}

		// Token: 0x06015292 RID: 86674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015292")]
		[Address(RVA = "0xD9D250", Offset = "0xD9BE50", VA = "0x180D9D250")]
		private void _RouteTitleAndDesc(SandboxInput input, out string title, out string desc)
		{
		}

		// Token: 0x06015293 RID: 86675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015293")]
		[Address(RVA = "0xD9CBB0", Offset = "0xD9B7B0", VA = "0x180D9CBB0")]
		private void _OnConfirmFinish()
		{
		}

		// Token: 0x06015294 RID: 86676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015294")]
		[Address(RVA = "0xD9CB30", Offset = "0xD9B730", VA = "0x180D9CB30")]
		private void _OnConfirmCancel()
		{
		}

		// Token: 0x06015295 RID: 86677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015295")]
		[Address(RVA = "0xD9DBD0", Offset = "0xD9C7D0", VA = "0x180D9DBD0")]
		public SandboxUIPlugin()
		{
		}

		// Token: 0x06015298 RID: 86680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015298")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06015299 RID: 86681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015299")]
		[Address(RVA = "0x7D24B0", Offset = "0x7D10B0", VA = "0x1807D24B0")]
		private void <>xLuaBaseProxy_OnGameReset(BattleController P0)
		{
		}

		// Token: 0x0601529A RID: 86682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601529A")]
		[Address(RVA = "0xD9C3E0", Offset = "0xD9AFE0", VA = "0x180D9C3E0")]
		private RectTransform <>xLuaBaseProxy_HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x0601529B RID: 86683 RVA: 0x0008A990 File Offset: 0x00088B90
		[Token(Token = "0x601529B")]
		[Address(RVA = "0xD9C3F0", Offset = "0xD9AFF0", VA = "0x180D9C3F0")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x0601529C RID: 86684 RVA: 0x0008A9A8 File Offset: 0x00088BA8
		[Token(Token = "0x601529C")]
		[Address(RVA = "0xD9C3D0", Offset = "0xD9AFD0", VA = "0x180D9C3D0")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x0601529D RID: 86685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601529D")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x0601529E RID: 86686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601529E")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x0601529F RID: 86687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601529F")]
		[Address(RVA = "0x9CCD90", Offset = "0x9CB990", VA = "0x1809CCD90")]
		private UICharacterInfoPanel.HookedCharacterInfoSubPanel[] <>xLuaBaseProxy_HookCharacterInfoSubPanels()
		{
			return null;
		}

		// Token: 0x060152A0 RID: 86688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152A0")]
		[Address(RVA = "0x9CCDD0", Offset = "0x9CB9D0", VA = "0x1809CCDD0")]
		private void <>xLuaBaseProxy_OnCharacterMenuShow(Character P0)
		{
		}

		// Token: 0x060152A1 RID: 86689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152A1")]
		[Address(RVA = "0x7D24D0", Offset = "0x7D10D0", VA = "0x1807D24D0")]
		private void <>xLuaBaseProxy_OnUIStateChanged(IUIStateNode P0)
		{
		}

		// Token: 0x060152A2 RID: 86690 RVA: 0x0008A9C0 File Offset: 0x00088BC0
		[Token(Token = "0x60152A2")]
		[Address(RVA = "0x7D2470", Offset = "0x7D1070", VA = "0x1807D2470")]
		private bool <>xLuaBaseProxy_HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x060152A3 RID: 86691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60152A3")]
		[Address(RVA = "0xD9C3C0", Offset = "0xD9AFC0", VA = "0x180D9C3C0")]
		private UICharacterMenuState.IUICharacterMenuPanel <>xLuaBaseProxy_GetHookUICharacterMenuPanel(Character P0)
		{
			return null;
		}

		// Token: 0x060152A4 RID: 86692 RVA: 0x0008A9D8 File Offset: 0x00088BD8
		[Token(Token = "0x60152A4")]
		[Address(RVA = "0x960A10", Offset = "0x95F610", VA = "0x180960A10")]
		private bool <>xLuaBaseProxy_HookBattleFailedStateSwitch(BattleFailedStateParam P0)
		{
			return default(bool);
		}

		// Token: 0x060152A5 RID: 86693 RVA: 0x0008A9F0 File Offset: 0x00088BF0
		[Token(Token = "0x60152A5")]
		[Address(RVA = "0xD9C400", Offset = "0xD9B000", VA = "0x180D9C400")]
		private bool <>xLuaBaseProxy_HookOnBattleFinishServiceStateEnter()
		{
			return default(bool);
		}

		// Token: 0x060152A6 RID: 86694 RVA: 0x0008AA08 File Offset: 0x00088C08
		[Token(Token = "0x60152A6")]
		[Address(RVA = "0xA032B0", Offset = "0xA01EB0", VA = "0x180A032B0")]
		private bool <>xLuaBaseProxy_HookPauseMask(bool P0)
		{
			return default(bool);
		}

		// Token: 0x060152A7 RID: 86695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152A7")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x040193D4 RID: 103380
		[Token(Token = "0x40193D4")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly UIStateEnum UI_STATE_BAG;

		// Token: 0x040193D5 RID: 103381
		[Token(Token = "0x40193D5")]
		[FieldOffset(Offset = "0x4")]
		[NonSerialized]
		public static readonly UIStateEnum UI_STATE_SYSTEM_MENU;

		// Token: 0x040193D6 RID: 103382
		[Token(Token = "0x40193D6")]
		private const string ANIM_BAG_ADD = "sandbox_backpack_item_plus";

		// Token: 0x040193D7 RID: 103383
		[Token(Token = "0x40193D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIBattleSandboxStateNode[] _states;

		// Token: 0x040193D8 RID: 103384
		[Token(Token = "0x40193D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICharacterInfoPanel.HookedCharacterInfoSubPanel[] _hookedCharacterInfoSubPanels;

		// Token: 0x040193D9 RID: 103385
		[Token(Token = "0x40193D9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("CharacterMenu")]
		private Sprite _defaultWithdrawBtnSprite;

		// Token: 0x040193DA RID: 103386
		[Token(Token = "0x40193DA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("CharacterMenu")]
		private Sprite _buildingWithdrawBtnSprite;

		// Token: 0x040193DB RID: 103387
		[Token(Token = "0x40193DB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("TopBar")]
		private SandboxUIPlugin.TopBarStatusStyle[] _topBarStatuses;

		// Token: 0x040193DC RID: 103388
		[Token(Token = "0x40193DC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("TopBar")]
		private SandboxUIPlugin.MenuBtnStatusStyle[] _menuSystemBtns;

		// Token: 0x040193DD RID: 103389
		[Token(Token = "0x40193DD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("TopBar")]
		private Sprite _defaultMenuSysBtnSprite;

		// Token: 0x040193DE RID: 103390
		[Token(Token = "0x40193DE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("TopBar")]
		private Button _backpackButton;

		// Token: 0x040193DF RID: 103391
		[Token(Token = "0x40193DF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIBattleBlurPanel _blurPanel;

		// Token: 0x040193E0 RID: 103392
		[Token(Token = "0x40193E0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIBattleSandboxPausePanel _pausePanel;

		// Token: 0x040193E1 RID: 103393
		[Token(Token = "0x40193E1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIBattleSandboxUICardList _cardListWidget;

		// Token: 0x040193E2 RID: 103394
		[Token(Token = "0x40193E2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationWrapper _bagPackAnim;

		// Token: 0x040193E3 RID: 103395
		[Token(Token = "0x40193E3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIBattleSandboxConstruct _constructPlugin;

		// Token: 0x040193E4 RID: 103396
		[Token(Token = "0x40193E4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIBattleSandboxItemNotification itemNotification;

		// Token: 0x040193E5 RID: 103397
		[Token(Token = "0x40193E5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("BattleFailedMask")]
		private SandboxBattleFailedMask _battleFailedMask;

		// Token: 0x040193E6 RID: 103398
		[Token(Token = "0x40193E6")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SandboxExitBattleDeco _deco;

		// Token: 0x040193E7 RID: 103399
		[Token(Token = "0x40193E7")]
		[FieldOffset(Offset = "0xA8")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x040193E8 RID: 103400
		[Token(Token = "0x40193E8")]
		[FieldOffset(Offset = "0xB0")]
		private UIBattleSandboxTopBarStatus m_curTopbarStatus;

		// Token: 0x040193E9 RID: 103401
		[Token(Token = "0x40193E9")]
		[FieldOffset(Offset = "0xB8")]
		private SandboxBattleStyle m_battleStyle;

		// Token: 0x040193EA RID: 103402
		[Token(Token = "0x40193EA")]
		[FieldOffset(Offset = "0xC0")]
		private UIBattleSandboxUICardList m_cardListWidget;

		// Token: 0x040193EB RID: 103403
		[Token(Token = "0x40193EB")]
		[FieldOffset(Offset = "0xC8")]
		private UIBattleSandboxConstruct m_constructPlugin;

		// Token: 0x040193EC RID: 103404
		[Token(Token = "0x40193EC")]
		[FieldOffset(Offset = "0xD0")]
		private SandboxBattleFailedMask m_failedPanel;

		// Token: 0x040193ED RID: 103405
		[Token(Token = "0x40193ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_battleStyle;

		// Token: 0x040193EE RID: 103406
		[Token(Token = "0x40193EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_pausePanel;

		// Token: 0x040193EF RID: 103407
		[Token(Token = "0x40193EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_constructPlugin;

		// Token: 0x040193F0 RID: 103408
		[Token(Token = "0x40193F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cardListWidget;

		// Token: 0x040193F1 RID: 103409
		[Token(Token = "0x40193F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_bagState;

		// Token: 0x040193F2 RID: 103410
		[Token(Token = "0x40193F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x040193F3 RID: 103411
		[Token(Token = "0x40193F3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x040193F4 RID: 103412
		[Token(Token = "0x40193F4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelInit;

		// Token: 0x040193F5 RID: 103413
		[Token(Token = "0x40193F5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelShow;

		// Token: 0x040193F6 RID: 103414
		[Token(Token = "0x40193F6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelHide;

		// Token: 0x040193F7 RID: 103415
		[Token(Token = "0x40193F7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnItemCountChanged;

		// Token: 0x040193F8 RID: 103416
		[Token(Token = "0x40193F8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x040193F9 RID: 103417
		[Token(Token = "0x40193F9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HookUITopBar;

		// Token: 0x040193FA RID: 103418
		[Token(Token = "0x40193FA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnBackpackButtonClicked;

		// Token: 0x040193FB RID: 103419
		[Token(Token = "0x40193FB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x040193FC RID: 103420
		[Token(Token = "0x40193FC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HookCharacterInfoSubPanels;

		// Token: 0x040193FD RID: 103421
		[Token(Token = "0x40193FD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuShow;

		// Token: 0x040193FE RID: 103422
		[Token(Token = "0x40193FE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x040193FF RID: 103423
		[Token(Token = "0x40193FF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_HookBattleSystemMenuSwitch;

		// Token: 0x04019400 RID: 103424
		[Token(Token = "0x4019400")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetHookUICharacterMenuPanel;

		// Token: 0x04019401 RID: 103425
		[Token(Token = "0x4019401")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_HookBattleFailedStateSwitch;

		// Token: 0x04019402 RID: 103426
		[Token(Token = "0x4019402")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_HookOnBattleFinishServiceStateEnter;

		// Token: 0x04019403 RID: 103427
		[Token(Token = "0x4019403")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_HookPauseMask;

		// Token: 0x04019404 RID: 103428
		[Token(Token = "0x4019404")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04019405 RID: 103429
		[Token(Token = "0x4019405")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__PreloadAssets;

		// Token: 0x04019406 RID: 103430
		[Token(Token = "0x4019406")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RegisterEventListenerWhenInit;

		// Token: 0x04019407 RID: 103431
		[Token(Token = "0x4019407")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ShowConfirmDialog;

		// Token: 0x04019408 RID: 103432
		[Token(Token = "0x4019408")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RouteConfirmVisualType;

		// Token: 0x04019409 RID: 103433
		[Token(Token = "0x4019409")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__RouteThemeType;

		// Token: 0x0401940A RID: 103434
		[Token(Token = "0x401940A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__RouteConfirmIconType;

		// Token: 0x0401940B RID: 103435
		[Token(Token = "0x401940B")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RouteTitleAndDesc;

		// Token: 0x0401940C RID: 103436
		[Token(Token = "0x401940C")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnConfirmFinish;

		// Token: 0x0401940D RID: 103437
		[Token(Token = "0x401940D")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnConfirmCancel;

		// Token: 0x0401940E RID: 103438
		[Token(Token = "0x401940E")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033CC RID: 13260
		[Token(Token = "0x20033CC")]
		[Serializable]
		private struct TopBarStatusStyle
		{
			// Token: 0x0401940F RID: 103439
			[Token(Token = "0x401940F")]
			[FieldOffset(Offset = "0x0")]
			public SandboxBattleStyle style;

			// Token: 0x04019410 RID: 103440
			[Token(Token = "0x4019410")]
			[FieldOffset(Offset = "0x8")]
			public UIBattleSandboxTopBarStatus status;
		}

		// Token: 0x020033CD RID: 13261
		[Token(Token = "0x20033CD")]
		[Serializable]
		private struct MenuBtnStatusStyle
		{
			// Token: 0x04019411 RID: 103441
			[Token(Token = "0x4019411")]
			[FieldOffset(Offset = "0x0")]
			public SandboxBattleStyle style;

			// Token: 0x04019412 RID: 103442
			[Token(Token = "0x4019412")]
			[FieldOffset(Offset = "0x8")]
			public Sprite btnSprite;
		}
	}
}
