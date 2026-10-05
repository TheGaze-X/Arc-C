using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x020078FF RID: 30975
	[Token(Token = "0x20078FF")]
	public class GamecityBattleUIPlugin : UIController.Plugin
	{
		// Token: 0x170065C2 RID: 26050
		// (get) Token: 0x0602B6F0 RID: 177904 RVA: 0x000DBDB0 File Offset: 0x000D9FB0
		// (set) Token: 0x0602B6F1 RID: 177905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065C2")]
		public bool isQuit
		{
			[Token(Token = "0x602B6F0")]
			[Address(RVA = "0x2762B80", Offset = "0x2761780", VA = "0x182762B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B6F1")]
			[Address(RVA = "0x2762C70", Offset = "0x2761870", VA = "0x182762C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170065C3 RID: 26051
		// (get) Token: 0x0602B6F2 RID: 177906 RVA: 0x000DBDC8 File Offset: 0x000D9FC8
		[Token(Token = "0x170065C3")]
		public override bool needPerspectiveAlwaysOn
		{
			[Token(Token = "0x602B6F2")]
			[Address(RVA = "0x2762C00", Offset = "0x2761800", VA = "0x182762C00", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B6F3 RID: 177907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6F3")]
		[Address(RVA = "0x2761790", Offset = "0x2760390", VA = "0x182761790", Slot = "16")]
		public override void OnGameReady()
		{
		}

		// Token: 0x0602B6F4 RID: 177908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6F4")]
		[Address(RVA = "0x2761500", Offset = "0x2760100", VA = "0x182761500", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0602B6F5 RID: 177909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6F5")]
		[Address(RVA = "0x2761A90", Offset = "0x2760690", VA = "0x182761A90", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x0602B6F6 RID: 177910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6F6")]
		[Address(RVA = "0x27624E0", Offset = "0x27610E0", VA = "0x1827624E0", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x0602B6F7 RID: 177911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6F7")]
		[Address(RVA = "0x2761B70", Offset = "0x2760770", VA = "0x182761B70", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x0602B6F8 RID: 177912 RVA: 0x000DBDE0 File Offset: 0x000D9FE0
		[Token(Token = "0x602B6F8")]
		[Address(RVA = "0x2760AA0", Offset = "0x275F6A0", VA = "0x182760AA0", Slot = "44")]
		public override bool CanPressBackButton()
		{
			return default(bool);
		}

		// Token: 0x0602B6F9 RID: 177913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6F9")]
		[Address(RVA = "0x2761460", Offset = "0x2760060", VA = "0x182761460", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x0602B6FA RID: 177914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6FA")]
		[Address(RVA = "0x2762040", Offset = "0x2760C40", VA = "0x182762040", Slot = "49")]
		public override void ShowGameModeText(int value, Transform spawnPoint, Color color)
		{
		}

		// Token: 0x0602B6FB RID: 177915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6FB")]
		[Address(RVA = "0x27622F0", Offset = "0x2760EF0", VA = "0x1827622F0", Slot = "43")]
		public override void UpdateDisableMask(BattleFunctionDisableMask mask)
		{
		}

		// Token: 0x0602B6FC RID: 177916 RVA: 0x000DBDF8 File Offset: 0x000D9FF8
		[Token(Token = "0x602B6FC")]
		[Address(RVA = "0x2760CE0", Offset = "0x275F8E0", VA = "0x182760CE0", Slot = "47")]
		public override bool HookBattleAccomplishPerform(out UIAnimationPerform perform)
		{
			return default(bool);
		}

		// Token: 0x0602B6FD RID: 177917 RVA: 0x000DBE10 File Offset: 0x000DA010
		[Token(Token = "0x602B6FD")]
		[Address(RVA = "0x2760FD0", Offset = "0x275FBD0", VA = "0x182760FD0", Slot = "35")]
		public override bool HookConfirmFinish(Action finishCallback)
		{
			return default(bool);
		}

		// Token: 0x0602B6FE RID: 177918 RVA: 0x000DBE28 File Offset: 0x000DA028
		[Token(Token = "0x602B6FE")]
		[Address(RVA = "0x2760D70", Offset = "0x275F970", VA = "0x182760D70", Slot = "25")]
		public override bool HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602B6FF RID: 177919 RVA: 0x000DBE40 File Offset: 0x000DA040
		[Token(Token = "0x602B6FF")]
		[Address(RVA = "0x2760E30", Offset = "0x275FA30", VA = "0x182760E30", Slot = "24")]
		public override bool HookBattleFailedStateSwitch(BattleFailedStateParam param)
		{
			return default(bool);
		}

		// Token: 0x0602B700 RID: 177920 RVA: 0x000DBE58 File Offset: 0x000DA058
		[Token(Token = "0x602B700")]
		[Address(RVA = "0x2760EE0", Offset = "0x275FAE0", VA = "0x182760EE0", Slot = "32")]
		public override bool HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602B701 RID: 177921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B701")]
		[Address(RVA = "0x2761D90", Offset = "0x2760990", VA = "0x182761D90", Slot = "13")]
		public override void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x0602B702 RID: 177922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B702")]
		[Address(RVA = "0x2760C20", Offset = "0x275F820", VA = "0x182760C20", Slot = "34")]
		public override UICharacterMenuState.IUICharacterMenuPanel GetHookUICharacterMenuPanel(Character character)
		{
			return null;
		}

		// Token: 0x0602B703 RID: 177923 RVA: 0x000DBE70 File Offset: 0x000DA070
		[Token(Token = "0x602B703")]
		[Address(RVA = "0x2761190", Offset = "0x275FD90", VA = "0x182761190", Slot = "46")]
		public override bool HookPredefinedUILocation(Camera uiCam, PredefinedLocation location, out Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x0602B704 RID: 177924 RVA: 0x000DBE88 File Offset: 0x000DA088
		[Token(Token = "0x602B704")]
		[Address(RVA = "0x2761390", Offset = "0x275FF90", VA = "0x182761390", Slot = "50")]
		public override bool HookShowCharacter(Character character)
		{
			return default(bool);
		}

		// Token: 0x0602B705 RID: 177925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B705")]
		[Address(RVA = "0x2762740", Offset = "0x2761340", VA = "0x182762740")]
		private void _InitLayout()
		{
		}

		// Token: 0x0602B706 RID: 177926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B706")]
		[Address(RVA = "0x2761FA0", Offset = "0x2760BA0", VA = "0x182761FA0")]
		public void SetGameCityScore(int value)
		{
		}

		// Token: 0x0602B707 RID: 177927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B707")]
		[Address(RVA = "0x27625D0", Offset = "0x27611D0", VA = "0x1827625D0")]
		public void UpgradeRank(ActArcadeData.Rank rank, float score)
		{
		}

		// Token: 0x0602B708 RID: 177928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B708")]
		[Address(RVA = "0x2761E30", Offset = "0x2760A30", VA = "0x182761E30")]
		public void OnWaveStart()
		{
		}

		// Token: 0x0602B709 RID: 177929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B709")]
		[Address(RVA = "0x2761CF0", Offset = "0x27608F0", VA = "0x182761CF0")]
		public void OnMenuButtonClick()
		{
		}

		// Token: 0x0602B70A RID: 177930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B70A")]
		[Address(RVA = "0x2762A50", Offset = "0x2761650", VA = "0x182762A50")]
		public GamecityBattleUIPlugin()
		{
		}

		// Token: 0x0602B70C RID: 177932 RVA: 0x000DBEA0 File Offset: 0x000DA0A0
		[Token(Token = "0x602B70C")]
		[Address(RVA = "0x27622E0", Offset = "0x2760EE0", VA = "0x1827622E0")]
		private bool <>xLuaBaseProxy_get_needPerspectiveAlwaysOn()
		{
			return default(bool);
		}

		// Token: 0x0602B70D RID: 177933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B70D")]
		[Address(RVA = "0x9CCDF0", Offset = "0x9CB9F0", VA = "0x1809CCDF0")]
		private void <>xLuaBaseProxy_OnGameReady()
		{
		}

		// Token: 0x0602B70E RID: 177934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B70E")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x0602B70F RID: 177935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B70F")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x0602B710 RID: 177936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B710")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x0602B711 RID: 177937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B711")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x0602B712 RID: 177938 RVA: 0x000DBEB8 File Offset: 0x000DA0B8
		[Token(Token = "0x602B712")]
		[Address(RVA = "0xDD4300", Offset = "0xDD2F00", VA = "0x180DD4300")]
		private bool <>xLuaBaseProxy_CanPressBackButton()
		{
			return default(bool);
		}

		// Token: 0x0602B713 RID: 177939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B713")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x0602B714 RID: 177940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B714")]
		[Address(RVA = "0x27622B0", Offset = "0x2760EB0", VA = "0x1827622B0")]
		private void <>xLuaBaseProxy_ShowGameModeText(int P0, Transform P1, Color P2)
		{
		}

		// Token: 0x0602B715 RID: 177941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B715")]
		[Address(RVA = "0xDC9070", Offset = "0xDC7C70", VA = "0x180DC9070")]
		private void <>xLuaBaseProxy_UpdateDisableMask(BattleFunctionDisableMask P0)
		{
		}

		// Token: 0x0602B716 RID: 177942 RVA: 0x000DBED0 File Offset: 0x000DA0D0
		[Token(Token = "0x602B716")]
		[Address(RVA = "0xDC6480", Offset = "0xDC5080", VA = "0x180DC6480")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishPerform(out UIAnimationPerform P0)
		{
			return default(bool);
		}

		// Token: 0x0602B717 RID: 177943 RVA: 0x000DBEE8 File Offset: 0x000DA0E8
		[Token(Token = "0x602B717")]
		[Address(RVA = "0x960A20", Offset = "0x95F620", VA = "0x180960A20")]
		private bool <>xLuaBaseProxy_HookConfirmFinish(Action P0)
		{
			return default(bool);
		}

		// Token: 0x0602B718 RID: 177944 RVA: 0x000DBF00 File Offset: 0x000DA100
		[Token(Token = "0x602B718")]
		[Address(RVA = "0x960A00", Offset = "0x95F600", VA = "0x180960A00")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602B719 RID: 177945 RVA: 0x000DBF18 File Offset: 0x000DA118
		[Token(Token = "0x602B719")]
		[Address(RVA = "0x960A10", Offset = "0x95F610", VA = "0x180960A10")]
		private bool <>xLuaBaseProxy_HookBattleFailedStateSwitch(BattleFailedStateParam P0)
		{
			return default(bool);
		}

		// Token: 0x0602B71A RID: 177946 RVA: 0x000DBF30 File Offset: 0x000DA130
		[Token(Token = "0x602B71A")]
		[Address(RVA = "0x7D2470", Offset = "0x7D1070", VA = "0x1807D2470")]
		private bool <>xLuaBaseProxy_HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602B71B RID: 177947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B71B")]
		[Address(RVA = "0x7D24D0", Offset = "0x7D10D0", VA = "0x1807D24D0")]
		private void <>xLuaBaseProxy_OnUIStateChanged(IUIStateNode P0)
		{
		}

		// Token: 0x0602B71C RID: 177948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B71C")]
		[Address(RVA = "0xD9C3C0", Offset = "0xD9AFC0", VA = "0x180D9C3C0")]
		private UICharacterMenuState.IUICharacterMenuPanel <>xLuaBaseProxy_GetHookUICharacterMenuPanel(Character P0)
		{
			return null;
		}

		// Token: 0x0602B71D RID: 177949 RVA: 0x000DBF48 File Offset: 0x000DA148
		[Token(Token = "0x602B71D")]
		[Address(RVA = "0xD51FB0", Offset = "0xD50BB0", VA = "0x180D51FB0")]
		private bool <>xLuaBaseProxy_HookPredefinedUILocation(Camera P0, PredefinedLocation P1, out Vector3 P2)
		{
			return default(bool);
		}

		// Token: 0x0602B71E RID: 177950 RVA: 0x000DBF60 File Offset: 0x000DA160
		[Token(Token = "0x602B71E")]
		[Address(RVA = "0x27622A0", Offset = "0x2760EA0", VA = "0x1827622A0")]
		private bool <>xLuaBaseProxy_HookShowCharacter(Character P0)
		{
			return default(bool);
		}

		// Token: 0x0403ED0F RID: 257295
		[Token(Token = "0x403ED0F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum ON_GAME_CITY_START_STATE;

		// Token: 0x0403ED10 RID: 257296
		[Token(Token = "0x403ED10")]
		[FieldOffset(Offset = "0x4")]
		public static readonly UIStateEnum ON_GAME_CITY_WAVE_STATE;

		// Token: 0x0403ED11 RID: 257297
		[Token(Token = "0x403ED11")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UIStateEnum ON_GAME_CITY_SYSTEM_MENU;

		// Token: 0x0403ED12 RID: 257298
		[Token(Token = "0x403ED12")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x0403ED13 RID: 257299
		[Token(Token = "0x403ED13")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Topbar")]
		private GameCityTopBarPanel _topBarPanel;

		// Token: 0x0403ED14 RID: 257300
		[Token(Token = "0x403ED14")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Topbar")]
		private RectTransform _scorePanelTransform;

		// Token: 0x0403ED15 RID: 257301
		[Token(Token = "0x403ED15")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Topbar")]
		private RectTransform _pauseButtonTransform;

		// Token: 0x0403ED16 RID: 257302
		[Token(Token = "0x403ED16")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Topbar")]
		private RectTransform _speedSwitcherTransform;

		// Token: 0x0403ED17 RID: 257303
		[Token(Token = "0x403ED17")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Topbar")]
		private RectTransform _menuButtonTransform;

		// Token: 0x0403ED18 RID: 257304
		[Token(Token = "0x403ED18")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Topbar")]
		private Button _menuButton;

		// Token: 0x0403ED19 RID: 257305
		[Token(Token = "0x403ED19")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Top")]
		private RectTransform _menuPanel;

		// Token: 0x0403ED1A RID: 257306
		[Token(Token = "0x403ED1A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ScoreUI")]
		private UINumericTextWithoutModifier _extraTextToShow;

		// Token: 0x0403ED1B RID: 257307
		[Token(Token = "0x403ED1B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Banner")]
		private RectTransform _battleStartPerform;

		// Token: 0x0403ED1C RID: 257308
		[Token(Token = "0x403ED1C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Banner")]
		private UIAnimationPerform _battleFinishPerform;

		// Token: 0x0403ED1D RID: 257309
		[Token(Token = "0x403ED1D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Special")]
		private UIBattleGameCityMinerCharacterMenuPanel _minerCharacterMenuPanel;

		// Token: 0x0403ED1E RID: 257310
		[Token(Token = "0x403ED1E")]
		[FieldOffset(Offset = "0x88")]
		private GamecityBattleUIPlugin.EmptyWavePlugin m_wavePlugin;

		// Token: 0x0403ED1F RID: 257311
		[Token(Token = "0x403ED1F")]
		[FieldOffset(Offset = "0x90")]
		private GameModeFactory.GameCityGameMode m_gameMode;

		// Token: 0x0403ED20 RID: 257312
		[Token(Token = "0x403ED20")]
		[FieldOffset(Offset = "0x98")]
		private UIBattleGameCityMinerCharacterMenuPanel m_minerPanel;

		// Token: 0x0403ED22 RID: 257314
		[Token(Token = "0x403ED22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isQuit;

		// Token: 0x0403ED23 RID: 257315
		[Token(Token = "0x403ED23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isQuit;

		// Token: 0x0403ED24 RID: 257316
		[Token(Token = "0x403ED24")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_needPerspectiveAlwaysOn;

		// Token: 0x0403ED25 RID: 257317
		[Token(Token = "0x403ED25")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0403ED26 RID: 257318
		[Token(Token = "0x403ED26")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0403ED27 RID: 257319
		[Token(Token = "0x403ED27")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0403ED28 RID: 257320
		[Token(Token = "0x403ED28")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403ED29 RID: 257321
		[Token(Token = "0x403ED29")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0403ED2A RID: 257322
		[Token(Token = "0x403ED2A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CanPressBackButton;

		// Token: 0x0403ED2B RID: 257323
		[Token(Token = "0x403ED2B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403ED2C RID: 257324
		[Token(Token = "0x403ED2C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ShowGameModeText;

		// Token: 0x0403ED2D RID: 257325
		[Token(Token = "0x403ED2D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateDisableMask;

		// Token: 0x0403ED2E RID: 257326
		[Token(Token = "0x403ED2E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishPerform;

		// Token: 0x0403ED2F RID: 257327
		[Token(Token = "0x403ED2F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HookConfirmFinish;

		// Token: 0x0403ED30 RID: 257328
		[Token(Token = "0x403ED30")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishedStateSwitch;

		// Token: 0x0403ED31 RID: 257329
		[Token(Token = "0x403ED31")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HookBattleFailedStateSwitch;

		// Token: 0x0403ED32 RID: 257330
		[Token(Token = "0x403ED32")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_HookBattleSystemMenuSwitch;

		// Token: 0x0403ED33 RID: 257331
		[Token(Token = "0x403ED33")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x0403ED34 RID: 257332
		[Token(Token = "0x403ED34")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetHookUICharacterMenuPanel;

		// Token: 0x0403ED35 RID: 257333
		[Token(Token = "0x403ED35")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_HookPredefinedUILocation;

		// Token: 0x0403ED36 RID: 257334
		[Token(Token = "0x403ED36")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_HookShowCharacter;

		// Token: 0x0403ED37 RID: 257335
		[Token(Token = "0x403ED37")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__InitLayout;

		// Token: 0x0403ED38 RID: 257336
		[Token(Token = "0x403ED38")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SetGameCityScore;

		// Token: 0x0403ED39 RID: 257337
		[Token(Token = "0x403ED39")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_UpgradeRank;

		// Token: 0x0403ED3A RID: 257338
		[Token(Token = "0x403ED3A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnWaveStart;

		// Token: 0x0403ED3B RID: 257339
		[Token(Token = "0x403ED3B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnMenuButtonClick;

		// Token: 0x0403ED3C RID: 257340
		[Token(Token = "0x403ED3C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007900 RID: 30976
		[Token(Token = "0x2007900")]
		private class EmptyWavePlugin : IHotfixable, Scheduler.IWavePlugin
		{
			// Token: 0x170065C4 RID: 26052
			// (get) Token: 0x0602B71F RID: 177951 RVA: 0x000DBF78 File Offset: 0x000DA178
			[Token(Token = "0x170065C4")]
			public bool hasWaveBeforeBattle
			{
				[Token(Token = "0x602B71F")]
				[Address(RVA = "0x275AD20", Offset = "0x2759920", VA = "0x18275AD20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170065C5 RID: 26053
			// (get) Token: 0x0602B720 RID: 177952 RVA: 0x000DBF90 File Offset: 0x000DA190
			[Token(Token = "0x170065C5")]
			public bool hasWaveAfterBattle
			{
				[Token(Token = "0x602B720")]
				[Address(RVA = "0x275ACC0", Offset = "0x27598C0", VA = "0x18275ACC0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602B721 RID: 177953 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B721")]
			[Address(RVA = "0x275ABD0", Offset = "0x27597D0", VA = "0x18275ABD0", Slot = "6")]
			public IEnumerator WaveBeforeBattle()
			{
				return null;
			}

			// Token: 0x0602B722 RID: 177954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B722")]
			[Address(RVA = "0x275AB40", Offset = "0x2759740", VA = "0x18275AB40", Slot = "7")]
			public IEnumerator WaveAfterBattle()
			{
				return null;
			}

			// Token: 0x0602B723 RID: 177955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B723")]
			[Address(RVA = "0x275AC60", Offset = "0x2759860", VA = "0x18275AC60")]
			public EmptyWavePlugin()
			{
			}

			// Token: 0x0403ED3D RID: 257341
			[Token(Token = "0x403ED3D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_hasWaveBeforeBattle;

			// Token: 0x0403ED3E RID: 257342
			[Token(Token = "0x403ED3E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_hasWaveAfterBattle;

			// Token: 0x0403ED3F RID: 257343
			[Token(Token = "0x403ED3F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_WaveBeforeBattle;

			// Token: 0x0403ED40 RID: 257344
			[Token(Token = "0x403ED40")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_WaveAfterBattle;

			// Token: 0x0403ED41 RID: 257345
			[Token(Token = "0x403ED41")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
