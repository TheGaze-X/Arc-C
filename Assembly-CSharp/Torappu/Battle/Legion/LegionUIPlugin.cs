using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A23 RID: 10787
	[Token(Token = "0x2002A23")]
	public class LegionUIPlugin : UIController.Plugin
	{
		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x06011E70 RID: 73328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002769")]
		public GameModeFactory.LegionGameMode manager
		{
			[Token(Token = "0x6011E70")]
			[Address(RVA = "0x9CDD70", Offset = "0x9CC970", VA = "0x1809CDD70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x06011E71 RID: 73329 RVA: 0x0006D830 File Offset: 0x0006BA30
		[Token(Token = "0x1700276A")]
		public bool isSelectCardShown
		{
			[Token(Token = "0x6011E71")]
			[Address(RVA = "0x9CDCF0", Offset = "0x9CC8F0", VA = "0x1809CDCF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011E72 RID: 73330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011E72")]
		[Address(RVA = "0x9CB170", Offset = "0x9C9D70", VA = "0x1809CB170", Slot = "37")]
		public override UICharacterInfoPanel.HookedCharacterInfoSubPanel[] HookCharacterInfoSubPanels()
		{
			return null;
		}

		// Token: 0x06011E73 RID: 73331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E73")]
		[Address(RVA = "0x9CBAD0", Offset = "0x9CA6D0", VA = "0x1809CBAD0", Slot = "38")]
		public override void OnDummyTouchedToTile(Character character, Tile tile)
		{
		}

		// Token: 0x06011E74 RID: 73332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E74")]
		[Address(RVA = "0x9CC780", Offset = "0x9CB380", VA = "0x1809CC780", Slot = "42")]
		public override void OnUnitBorn(Unit unit)
		{
		}

		// Token: 0x06011E75 RID: 73333 RVA: 0x0006D848 File Offset: 0x0006BA48
		[Token(Token = "0x6011E75")]
		[Address(RVA = "0x9CB1E0", Offset = "0x9C9DE0", VA = "0x1809CB1E0", Slot = "22")]
		public override bool HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011E76 RID: 73334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E76")]
		[Address(RVA = "0x9CC530", Offset = "0x9CB130", VA = "0x1809CC530", Slot = "20")]
		public override void OnSystemMenuCancel()
		{
		}

		// Token: 0x06011E77 RID: 73335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E77")]
		[Address(RVA = "0x9CC3B0", Offset = "0x9CAFB0", VA = "0x1809CC3B0", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x06011E78 RID: 73336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E78")]
		[Address(RVA = "0x9CBFE0", Offset = "0x9CABE0", VA = "0x1809CBFE0", Slot = "16")]
		public override void OnGameReady()
		{
		}

		// Token: 0x06011E79 RID: 73337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E79")]
		[Address(RVA = "0x9CC080", Offset = "0x9CAC80", VA = "0x1809CC080", Slot = "14")]
		public override void OnGameReset(BattleController battleController)
		{
		}

		// Token: 0x06011E7A RID: 73338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E7A")]
		[Address(RVA = "0x9CBB90", Offset = "0x9CA790", VA = "0x1809CBB90", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06011E7B RID: 73339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E7B")]
		[Address(RVA = "0x9CC610", Offset = "0x9CB210", VA = "0x1809CC610", Slot = "13")]
		public override void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x06011E7C RID: 73340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E7C")]
		[Address(RVA = "0x9CB2B0", Offset = "0x9C9EB0", VA = "0x1809CB2B0")]
		public void InitDangerLevel(float interval, int initLevel)
		{
		}

		// Token: 0x06011E7D RID: 73341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E7D")]
		[Address(RVA = "0x9CCE20", Offset = "0x9CBA20", VA = "0x1809CCE20")]
		public void UpdateDangerLevel(int level, int maxLevel, float progressToNextLevel)
		{
		}

		// Token: 0x06011E7E RID: 73342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E7E")]
		[Address(RVA = "0x9CCEF0", Offset = "0x9CBAF0", VA = "0x1809CCEF0", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06011E7F RID: 73343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E7F")]
		[Address(RVA = "0x9CD020", Offset = "0x9CBC20", VA = "0x1809CD020")]
		private void _OnCurWaveWillFinish(float showTime)
		{
		}

		// Token: 0x06011E80 RID: 73344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E80")]
		[Address(RVA = "0x9CCBE0", Offset = "0x9CB7E0", VA = "0x1809CCBE0")]
		private void _OnShowSelectCardPanel(object arg)
		{
		}

		// Token: 0x06011E81 RID: 73345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E81")]
		[Address(RVA = "0x9CD7E0", Offset = "0x9CC3E0", VA = "0x1809CD7E0")]
		private void _SwitchToSelectCardState()
		{
		}

		// Token: 0x06011E82 RID: 73346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E82")]
		[Address(RVA = "0x9CC210", Offset = "0x9CAE10", VA = "0x1809CC210")]
		public void OnGameStarted()
		{
		}

		// Token: 0x06011E83 RID: 73347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E83")]
		[Address(RVA = "0x9CC9D0", Offset = "0x9CB5D0", VA = "0x1809CC9D0")]
		public void StartRedrawCard()
		{
		}

		// Token: 0x06011E84 RID: 73348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E84")]
		[Address(RVA = "0x9CB410", Offset = "0x9CA010", VA = "0x1809CB410")]
		public void OnCardRedrawConfirmed(List<UICard> uiCardList)
		{
		}

		// Token: 0x06011E85 RID: 73349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E85")]
		[Address(RVA = "0x9CB6F0", Offset = "0x9CA2F0", VA = "0x1809CB6F0")]
		public void OnCardSelectConfirmed()
		{
		}

		// Token: 0x06011E86 RID: 73350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E86")]
		[Address(RVA = "0x9CB7F0", Offset = "0x9CA3F0", VA = "0x1809CB7F0")]
		public void OnCardSelectHiden()
		{
		}

		// Token: 0x06011E87 RID: 73351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E87")]
		[Address(RVA = "0x9CB9D0", Offset = "0x9CA5D0", VA = "0x1809CB9D0", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x06011E88 RID: 73352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E88")]
		[Address(RVA = "0x9CD0F0", Offset = "0x9CBCF0", VA = "0x1809CD0F0")]
		private void _PreloadAssets()
		{
		}

		// Token: 0x06011E89 RID: 73353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E89")]
		[Address(RVA = "0x9CB370", Offset = "0x9C9F70", VA = "0x1809CB370", Slot = "40")]
		public override void OnCardMenuShow(Deck.Card card)
		{
		}

		// Token: 0x06011E8A RID: 73354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E8A")]
		[Address(RVA = "0x9CB930", Offset = "0x9CA530", VA = "0x1809CB930", Slot = "39")]
		public override void OnCharacterMenuShow(Character character)
		{
		}

		// Token: 0x06011E8B RID: 73355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E8B")]
		[Address(RVA = "0x9CB8A0", Offset = "0x9CA4A0", VA = "0x1809CB8A0", Slot = "41")]
		public override void OnCharacterMenuHide()
		{
		}

		// Token: 0x06011E8C RID: 73356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E8C")]
		[Address(RVA = "0x9CC950", Offset = "0x9CB550", VA = "0x1809CC950")]
		public void ShowUsedCard()
		{
		}

		// Token: 0x06011E8D RID: 73357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E8D")]
		[Address(RVA = "0x9CC8D0", Offset = "0x9CB4D0", VA = "0x1809CC8D0")]
		public void ShowPendingCard()
		{
		}

		// Token: 0x06011E8E RID: 73358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E8E")]
		[Address(RVA = "0x9CD620", Offset = "0x9CC220", VA = "0x1809CD620")]
		private void _SwitchToCardLibraryState(LegionCardLibraryType cardType)
		{
		}

		// Token: 0x06011E8F RID: 73359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E8F")]
		[Address(RVA = "0x9CB040", Offset = "0x9C9C40", VA = "0x1809CB040")]
		public void CloseLibraryPanel()
		{
		}

		// Token: 0x06011E90 RID: 73360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E90")]
		[Address(RVA = "0x9CC820", Offset = "0x9CB420", VA = "0x1809CC820")]
		public void ShowLegionWidgetPanel(bool isShow)
		{
		}

		// Token: 0x06011E91 RID: 73361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E91")]
		[Address(RVA = "0x9CDBF0", Offset = "0x9CC7F0", VA = "0x1809CDBF0")]
		public LegionUIPlugin()
		{
		}

		// Token: 0x06011E95 RID: 73365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011E95")]
		[Address(RVA = "0x9CCD90", Offset = "0x9CB990", VA = "0x1809CCD90")]
		private UICharacterInfoPanel.HookedCharacterInfoSubPanel[] <>xLuaBaseProxy_HookCharacterInfoSubPanels()
		{
			return null;
		}

		// Token: 0x06011E96 RID: 73366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E96")]
		[Address(RVA = "0x9CCDE0", Offset = "0x9CB9E0", VA = "0x1809CCDE0")]
		private void <>xLuaBaseProxy_OnDummyTouchedToTile(Character P0, Tile P1)
		{
		}

		// Token: 0x06011E97 RID: 73367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E97")]
		[Address(RVA = "0x9CCE10", Offset = "0x9CBA10", VA = "0x1809CCE10")]
		private void <>xLuaBaseProxy_OnUnitBorn(Unit P0)
		{
		}

		// Token: 0x06011E98 RID: 73368 RVA: 0x0006D860 File Offset: 0x0006BA60
		[Token(Token = "0x6011E98")]
		[Address(RVA = "0x9CCDA0", Offset = "0x9CB9A0", VA = "0x1809CCDA0")]
		private bool <>xLuaBaseProxy_HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011E99 RID: 73369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E99")]
		[Address(RVA = "0x9CCE00", Offset = "0x9CBA00", VA = "0x1809CCE00")]
		private void <>xLuaBaseProxy_OnSystemMenuCancel()
		{
		}

		// Token: 0x06011E9A RID: 73370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E9A")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x06011E9B RID: 73371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E9B")]
		[Address(RVA = "0x9CCDF0", Offset = "0x9CB9F0", VA = "0x1809CCDF0")]
		private void <>xLuaBaseProxy_OnGameReady()
		{
		}

		// Token: 0x06011E9C RID: 73372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E9C")]
		[Address(RVA = "0x7D24B0", Offset = "0x7D10B0", VA = "0x1807D24B0")]
		private void <>xLuaBaseProxy_OnGameReset(BattleController P0)
		{
		}

		// Token: 0x06011E9D RID: 73373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E9D")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06011E9E RID: 73374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E9E")]
		[Address(RVA = "0x7D24D0", Offset = "0x7D10D0", VA = "0x1807D24D0")]
		private void <>xLuaBaseProxy_OnUIStateChanged(IUIStateNode P0)
		{
		}

		// Token: 0x06011E9F RID: 73375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E9F")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06011EA0 RID: 73376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EA0")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06011EA1 RID: 73377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EA1")]
		[Address(RVA = "0x9CCDB0", Offset = "0x9CB9B0", VA = "0x1809CCDB0")]
		private void <>xLuaBaseProxy_OnCardMenuShow(Deck.Card P0)
		{
		}

		// Token: 0x06011EA2 RID: 73378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EA2")]
		[Address(RVA = "0x9CCDD0", Offset = "0x9CB9D0", VA = "0x1809CCDD0")]
		private void <>xLuaBaseProxy_OnCharacterMenuShow(Character P0)
		{
		}

		// Token: 0x06011EA3 RID: 73379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EA3")]
		[Address(RVA = "0x9CCDC0", Offset = "0x9CB9C0", VA = "0x1809CCDC0")]
		private void <>xLuaBaseProxy_OnCharacterMenuHide()
		{
		}

		// Token: 0x040142A0 RID: 82592
		[Token(Token = "0x40142A0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_BATTLE_START;

		// Token: 0x040142A1 RID: 82593
		[Token(Token = "0x40142A1")]
		[FieldOffset(Offset = "0x4")]
		public static readonly UIStateEnum UI_STATE_CARD_REDRAW;

		// Token: 0x040142A2 RID: 82594
		[Token(Token = "0x40142A2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UIStateEnum UI_STATE_CARD_SELECT;

		// Token: 0x040142A3 RID: 82595
		[Token(Token = "0x40142A3")]
		[FieldOffset(Offset = "0xC")]
		public static readonly UIStateEnum UI_STATE_CARD_LIBRARY;

		// Token: 0x040142A4 RID: 82596
		[Token(Token = "0x40142A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x040142A5 RID: 82597
		[Token(Token = "0x40142A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UITopBar.BasicStatus _basicStatus;

		// Token: 0x040142A6 RID: 82598
		[Token(Token = "0x40142A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UILegionDangerLevel _dangerLevelInfo;

		// Token: 0x040142A7 RID: 82599
		[Token(Token = "0x40142A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIBattleLegionWidgetsPanel _widgetsPanel;

		// Token: 0x040142A8 RID: 82600
		[Token(Token = "0x40142A8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIBattleLegionIntermissionTipsPanel _intermissionPanel;

		// Token: 0x040142A9 RID: 82601
		[Token(Token = "0x40142A9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICharacterInfoPanel.HookedCharacterInfoSubPanel[] _hookedCharacterInfoSubPanels;

		// Token: 0x040142AA RID: 82602
		[Token(Token = "0x40142AA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Toast")]
		private UILegionBlastCardToastPanel _toastBlastCard;

		// Token: 0x040142AB RID: 82603
		[Token(Token = "0x40142AB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Toast")]
		private UILegionTrapEffectToastPanel _toastTrapEffect;

		// Token: 0x040142AC RID: 82604
		[Token(Token = "0x40142AC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIBattleBlurPanel _blurPanel;

		// Token: 0x040142AD RID: 82605
		[Token(Token = "0x40142AD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LegionUICharacterStatusController _characterStatusController;

		// Token: 0x040142AE RID: 82606
		[Token(Token = "0x40142AE")]
		[FieldOffset(Offset = "0x78")]
		private UIBattleLegionWidgetsPanel m_widgetsPanel;

		// Token: 0x040142AF RID: 82607
		[Token(Token = "0x40142AF")]
		[FieldOffset(Offset = "0x80")]
		private UIBattleLegionIntermissionTipsPanel m_intermissionPanel;

		// Token: 0x040142B0 RID: 82608
		[Token(Token = "0x40142B0")]
		[FieldOffset(Offset = "0x88")]
		private UILegionBlastCardToastPanel m_toastBlastCard;

		// Token: 0x040142B1 RID: 82609
		[Token(Token = "0x40142B1")]
		[FieldOffset(Offset = "0x90")]
		private UILegionTrapEffectToastPanel m_toastTrapEffect;

		// Token: 0x040142B2 RID: 82610
		[Token(Token = "0x40142B2")]
		[FieldOffset(Offset = "0x98")]
		private GameModeFactory.LegionGameMode m_manager;

		// Token: 0x040142B3 RID: 82611
		[Token(Token = "0x40142B3")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isSelectCardShown;

		// Token: 0x040142B4 RID: 82612
		[Token(Token = "0x40142B4")]
		[FieldOffset(Offset = "0xA8")]
		private List<BattleLegionSelectCardParam> m_selectCardParamList;

		// Token: 0x040142B5 RID: 82613
		[Token(Token = "0x40142B5")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2 CARD_LIST_OFFSET_MAX;

		// Token: 0x040142B6 RID: 82614
		[Token(Token = "0x40142B6")]
		[FieldOffset(Offset = "0x18")]
		private static Vector2 CARD_LIST_OFFSET_MIN;

		// Token: 0x040142B7 RID: 82615
		[Token(Token = "0x40142B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_manager;

		// Token: 0x040142B8 RID: 82616
		[Token(Token = "0x40142B8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isSelectCardShown;

		// Token: 0x040142B9 RID: 82617
		[Token(Token = "0x40142B9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HookCharacterInfoSubPanels;

		// Token: 0x040142BA RID: 82618
		[Token(Token = "0x40142BA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDummyTouchedToTile;

		// Token: 0x040142BB RID: 82619
		[Token(Token = "0x40142BB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnUnitBorn;

		// Token: 0x040142BC RID: 82620
		[Token(Token = "0x40142BC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HookGameReadyStateSwitch;

		// Token: 0x040142BD RID: 82621
		[Token(Token = "0x40142BD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnSystemMenuCancel;

		// Token: 0x040142BE RID: 82622
		[Token(Token = "0x40142BE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x040142BF RID: 82623
		[Token(Token = "0x40142BF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x040142C0 RID: 82624
		[Token(Token = "0x40142C0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x040142C1 RID: 82625
		[Token(Token = "0x40142C1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x040142C2 RID: 82626
		[Token(Token = "0x40142C2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x040142C3 RID: 82627
		[Token(Token = "0x40142C3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_InitDangerLevel;

		// Token: 0x040142C4 RID: 82628
		[Token(Token = "0x40142C4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UpdateDangerLevel;

		// Token: 0x040142C5 RID: 82629
		[Token(Token = "0x40142C5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x040142C6 RID: 82630
		[Token(Token = "0x40142C6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnCurWaveWillFinish;

		// Token: 0x040142C7 RID: 82631
		[Token(Token = "0x40142C7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnShowSelectCardPanel;

		// Token: 0x040142C8 RID: 82632
		[Token(Token = "0x40142C8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SwitchToSelectCardState;

		// Token: 0x040142C9 RID: 82633
		[Token(Token = "0x40142C9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnGameStarted;

		// Token: 0x040142CA RID: 82634
		[Token(Token = "0x40142CA")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_StartRedrawCard;

		// Token: 0x040142CB RID: 82635
		[Token(Token = "0x40142CB")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnCardRedrawConfirmed;

		// Token: 0x040142CC RID: 82636
		[Token(Token = "0x40142CC")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnCardSelectConfirmed;

		// Token: 0x040142CD RID: 82637
		[Token(Token = "0x40142CD")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnCardSelectHiden;

		// Token: 0x040142CE RID: 82638
		[Token(Token = "0x40142CE")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040142CF RID: 82639
		[Token(Token = "0x40142CF")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__PreloadAssets;

		// Token: 0x040142D0 RID: 82640
		[Token(Token = "0x40142D0")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnCardMenuShow;

		// Token: 0x040142D1 RID: 82641
		[Token(Token = "0x40142D1")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuShow;

		// Token: 0x040142D2 RID: 82642
		[Token(Token = "0x40142D2")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuHide;

		// Token: 0x040142D3 RID: 82643
		[Token(Token = "0x40142D3")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ShowUsedCard;

		// Token: 0x040142D4 RID: 82644
		[Token(Token = "0x40142D4")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ShowPendingCard;

		// Token: 0x040142D5 RID: 82645
		[Token(Token = "0x40142D5")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__SwitchToCardLibraryState;

		// Token: 0x040142D6 RID: 82646
		[Token(Token = "0x40142D6")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CloseLibraryPanel;

		// Token: 0x040142D7 RID: 82647
		[Token(Token = "0x40142D7")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_ShowLegionWidgetPanel;

		// Token: 0x040142D8 RID: 82648
		[Token(Token = "0x40142D8")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
