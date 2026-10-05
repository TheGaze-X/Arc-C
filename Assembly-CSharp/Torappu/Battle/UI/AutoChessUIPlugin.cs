using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003332 RID: 13106
	[Token(Token = "0x2003332")]
	public class AutoChessUIPlugin : UIController.Plugin
	{
		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x06014E4A RID: 85578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003197")]
		private AutoChessDummyHud dummyPlugin
		{
			[Token(Token = "0x6014E4A")]
			[Address(RVA = "0xD54BF0", Offset = "0xD537F0", VA = "0x180D54BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014E4B RID: 85579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E4B")]
		[Address(RVA = "0xD512C0", Offset = "0xD4FEC0", VA = "0x180D512C0")]
		public void OnBeginDrag_StateOnly(object arg)
		{
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x06014E4C RID: 85580 RVA: 0x00089250 File Offset: 0x00087450
		[Token(Token = "0x17003198")]
		public override Vector3 hudScale
		{
			[Token(Token = "0x6014E4C")]
			[Address(RVA = "0xD54CF0", Offset = "0xD538F0", VA = "0x180D54CF0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x06014E4D RID: 85581 RVA: 0x00089268 File Offset: 0x00087468
		[Token(Token = "0x17003199")]
		public override bool needReleaseIllust
		{
			[Token(Token = "0x6014E4D")]
			[Address(RVA = "0xD54D70", Offset = "0xD53970", VA = "0x180D54D70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x06014E4E RID: 85582 RVA: 0x00089280 File Offset: 0x00087480
		[Token(Token = "0x1700319A")]
		public override bool showCharacterStatusInDummy
		{
			[Token(Token = "0x6014E4E")]
			[Address(RVA = "0xD54DD0", Offset = "0xD539D0", VA = "0x180D54DD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x06014E4F RID: 85583 RVA: 0x00089298 File Offset: 0x00087498
		[Token(Token = "0x1700319B")]
		public override bool slowMotionInCharacterMenuState
		{
			[Token(Token = "0x6014E4F")]
			[Address(RVA = "0xD54E30", Offset = "0xD53A30", VA = "0x180D54E30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014E50 RID: 85584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014E50")]
		[Address(RVA = "0xD51080", Offset = "0xD4FC80", VA = "0x180D51080", Slot = "37")]
		public override UICharacterInfoPanel.HookedCharacterInfoSubPanel[] HookCharacterInfoSubPanels()
		{
			return null;
		}

		// Token: 0x06014E51 RID: 85585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014E51")]
		[Address(RVA = "0xD50E20", Offset = "0xD4FA20", VA = "0x180D50E20", Slot = "34")]
		public override UICharacterMenuState.IUICharacterMenuPanel GetHookUICharacterMenuPanel(Character character)
		{
			return null;
		}

		// Token: 0x06014E52 RID: 85586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E52")]
		[Address(RVA = "0xD51480", Offset = "0xD50080", VA = "0x180D51480", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06014E53 RID: 85587 RVA: 0x000892B0 File Offset: 0x000874B0
		[Token(Token = "0x6014E53")]
		[Address(RVA = "0xD51260", Offset = "0xD4FE60", VA = "0x180D51260", Slot = "26")]
		public override bool HookUIShowCardState()
		{
			return default(bool);
		}

		// Token: 0x06014E54 RID: 85588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E54")]
		[Address(RVA = "0xD51930", Offset = "0xD50530", VA = "0x180D51930", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x06014E55 RID: 85589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E55")]
		[Address(RVA = "0xD51A90", Offset = "0xD50690", VA = "0x180D51A90", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014E56 RID: 85590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E56")]
		[Address(RVA = "0xD52490", Offset = "0xD51090", VA = "0x180D52490", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06014E57 RID: 85591 RVA: 0x000892C8 File Offset: 0x000874C8
		[Token(Token = "0x6014E57")]
		[Address(RVA = "0xD50F20", Offset = "0xD4FB20", VA = "0x180D50F20", Slot = "48")]
		public override bool HookCharacterInfoSubPanelSkillParse(Blackboard blackboard, BattleCharacterData data, ref string description)
		{
			return default(bool);
		}

		// Token: 0x06014E58 RID: 85592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E58")]
		[Address(RVA = "0xD513E0", Offset = "0xD4FFE0", VA = "0x180D513E0", Slot = "39")]
		public override void OnCharacterMenuShow(Character character)
		{
		}

		// Token: 0x06014E59 RID: 85593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E59")]
		[Address(RVA = "0xD51350", Offset = "0xD4FF50", VA = "0x180D51350", Slot = "41")]
		public override void OnCharacterMenuHide()
		{
		}

		// Token: 0x06014E5A RID: 85594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E5A")]
		[Address(RVA = "0xD51BE0", Offset = "0xD507E0", VA = "0x180D51BE0", Slot = "13")]
		public override void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x06014E5B RID: 85595 RVA: 0x000892E0 File Offset: 0x000874E0
		[Token(Token = "0x6014E5B")]
		[Address(RVA = "0xD510E0", Offset = "0xD4FCE0", VA = "0x180D510E0", Slot = "46")]
		public override bool HookPredefinedUILocation(Camera uiCam, PredefinedLocation location, out Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x06014E5C RID: 85596 RVA: 0x000892F8 File Offset: 0x000874F8
		[Token(Token = "0x6014E5C")]
		[Address(RVA = "0xD50C30", Offset = "0xD4F830", VA = "0x180D50C30")]
		public Vector3 GetAutoChessShopCenterWorldPos()
		{
			return default(Vector3);
		}

		// Token: 0x06014E5D RID: 85597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E5D")]
		[Address(RVA = "0xD52760", Offset = "0xD51360", VA = "0x180D52760")]
		private void _OnBattleStarted(object arg)
		{
		}

		// Token: 0x06014E5E RID: 85598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E5E")]
		[Address(RVA = "0xD52830", Offset = "0xD51430", VA = "0x180D52830")]
		private void _OnDataChanged(object arg)
		{
		}

		// Token: 0x06014E5F RID: 85599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E5F")]
		[Address(RVA = "0xD530E0", Offset = "0xD51CE0", VA = "0x180D530E0")]
		private void _OnGameStateChanged()
		{
		}

		// Token: 0x06014E60 RID: 85600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E60")]
		[Address(RVA = "0xD533A0", Offset = "0xD51FA0", VA = "0x180D533A0")]
		private void _OnUIStateChanged()
		{
		}

		// Token: 0x06014E61 RID: 85601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E61")]
		[Address(RVA = "0xD535F0", Offset = "0xD521F0", VA = "0x180D535F0")]
		private void _RefreshCostPanelState()
		{
		}

		// Token: 0x06014E62 RID: 85602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E62")]
		[Address(RVA = "0xD53430", Offset = "0xD52030", VA = "0x180D53430")]
		private void _RefreshCharacterMenuState()
		{
		}

		// Token: 0x06014E63 RID: 85603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E63")]
		[Address(RVA = "0xD537F0", Offset = "0xD523F0", VA = "0x180D537F0")]
		private void _RefreshMask()
		{
		}

		// Token: 0x06014E64 RID: 85604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E64")]
		[Address(RVA = "0xD51E20", Offset = "0xD50A20", VA = "0x180D51E20")]
		public void ReqShowCharacterMenu(Character character, bool foldIllust)
		{
		}

		// Token: 0x06014E65 RID: 85605 RVA: 0x00089310 File Offset: 0x00087510
		[Token(Token = "0x6014E65")]
		[Address(RVA = "0xD53AD0", Offset = "0xD526D0", VA = "0x180D53AD0")]
		private bool _RefreshTmpCharacterShow()
		{
			return default(bool);
		}

		// Token: 0x06014E66 RID: 85606 RVA: 0x00089328 File Offset: 0x00087528
		[Token(Token = "0x6014E66")]
		[Address(RVA = "0xD53920", Offset = "0xD52520", VA = "0x180D53920")]
		private bool _RefreshTmpCharacterShowByShop()
		{
			return default(bool);
		}

		// Token: 0x06014E67 RID: 85607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E67")]
		[Address(RVA = "0xD51DB0", Offset = "0xD509B0", VA = "0x180D51DB0")]
		public void ReqHideCharacterMenu()
		{
		}

		// Token: 0x06014E68 RID: 85608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E68")]
		[Address(RVA = "0xD54920", Offset = "0xD53520", VA = "0x180D54920")]
		private void _SwitchToDefault()
		{
		}

		// Token: 0x06014E69 RID: 85609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E69")]
		[Address(RVA = "0xD52C70", Offset = "0xD51870", VA = "0x180D52C70")]
		private void _OnDummyUpdate(object arg)
		{
		}

		// Token: 0x06014E6A RID: 85610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E6A")]
		[Address(RVA = "0xD52AB0", Offset = "0xD516B0", VA = "0x180D52AB0")]
		private void _OnDummyRemoved(object arg)
		{
		}

		// Token: 0x06014E6B RID: 85611 RVA: 0x00089340 File Offset: 0x00087540
		[Token(Token = "0x6014E6B")]
		[Address(RVA = "0xD54170", Offset = "0xD52D70", VA = "0x180D54170")]
		private bool _SetDummyHud(Tile tile, Character character, AutoChessDummyHud hud)
		{
			return default(bool);
		}

		// Token: 0x06014E6C RID: 85612 RVA: 0x00089358 File Offset: 0x00087558
		[Token(Token = "0x6014E6C")]
		[Address(RVA = "0xD53F70", Offset = "0xD52B70", VA = "0x180D53F70")]
		private bool _SetBattleStateDummy(ChessInst chessInst, Character character, AutoChessDummyHud hud)
		{
			return default(bool);
		}

		// Token: 0x06014E6D RID: 85613 RVA: 0x00089370 File Offset: 0x00087570
		[Token(Token = "0x6014E6D")]
		[Address(RVA = "0xD54800", Offset = "0xD53400", VA = "0x180D54800")]
		private bool _SetPrepareStateDummy(ChessInst chessInst, Character character, AutoChessDummyHud hud)
		{
			return default(bool);
		}

		// Token: 0x06014E6E RID: 85614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E6E")]
		[Address(RVA = "0xD545C0", Offset = "0xD531C0", VA = "0x180D545C0")]
		private void _SetHandDummy(ChessInst chessInst, Character character, AutoChessDummyHud hud, int chessLevel)
		{
		}

		// Token: 0x06014E6F RID: 85615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E6F")]
		[Address(RVA = "0xD53D10", Offset = "0xD52910", VA = "0x180D53D10")]
		private void _SetBattleFieldDummy(ChessInst chessInst, Character character, AutoChessDummyHud hud, int chessLevel)
		{
		}

		// Token: 0x06014E70 RID: 85616 RVA: 0x00089388 File Offset: 0x00087588
		[Token(Token = "0x6014E70")]
		[Address(RVA = "0xD52610", Offset = "0xD51210", VA = "0x180D52610")]
		private bool _CheckInstContainsEquipIndex(int instId, int index, out bool isGold)
		{
			return default(bool);
		}

		// Token: 0x06014E71 RID: 85617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E71")]
		[Address(RVA = "0xD549F0", Offset = "0xD535F0", VA = "0x180D549F0")]
		public AutoChessUIPlugin()
		{
		}

		// Token: 0x06014E72 RID: 85618 RVA: 0x000893A0 File Offset: 0x000875A0
		[Token(Token = "0x6014E72")]
		[Address(RVA = "0xD522C0", Offset = "0xD50EC0", VA = "0x180D522C0")]
		private Vector3 <>xLuaBaseProxy_get_hudScale()
		{
			return default(Vector3);
		}

		// Token: 0x06014E73 RID: 85619 RVA: 0x000893B8 File Offset: 0x000875B8
		[Token(Token = "0x6014E73")]
		[Address(RVA = "0xD52370", Offset = "0xD50F70", VA = "0x180D52370")]
		private bool <>xLuaBaseProxy_get_needReleaseIllust()
		{
			return default(bool);
		}

		// Token: 0x06014E74 RID: 85620 RVA: 0x000893D0 File Offset: 0x000875D0
		[Token(Token = "0x6014E74")]
		[Address(RVA = "0xD523D0", Offset = "0xD50FD0", VA = "0x180D523D0")]
		private bool <>xLuaBaseProxy_get_showCharacterStatusInDummy()
		{
			return default(bool);
		}

		// Token: 0x06014E75 RID: 85621 RVA: 0x000893E8 File Offset: 0x000875E8
		[Token(Token = "0x6014E75")]
		[Address(RVA = "0xD52430", Offset = "0xD51030", VA = "0x180D52430")]
		private bool <>xLuaBaseProxy_get_slowMotionInCharacterMenuState()
		{
			return default(bool);
		}

		// Token: 0x06014E76 RID: 85622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014E76")]
		[Address(RVA = "0xD51F50", Offset = "0xD50B50", VA = "0x180D51F50")]
		private UICharacterInfoPanel.HookedCharacterInfoSubPanel[] <>xLuaBaseProxy_HookCharacterInfoSubPanels()
		{
			return null;
		}

		// Token: 0x06014E77 RID: 85623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014E77")]
		[Address(RVA = "0xD51ED0", Offset = "0xD50AD0", VA = "0x180D51ED0")]
		private UICharacterMenuState.IUICharacterMenuPanel <>xLuaBaseProxy_GetHookUICharacterMenuPanel(Character P0)
		{
			return null;
		}

		// Token: 0x06014E78 RID: 85624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E78")]
		[Address(RVA = "0xD520E0", Offset = "0xD50CE0", VA = "0x180D520E0")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06014E79 RID: 85625 RVA: 0x00089400 File Offset: 0x00087600
		[Token(Token = "0x6014E79")]
		[Address(RVA = "0xD51FC0", Offset = "0xD50BC0", VA = "0x180D51FC0")]
		private bool <>xLuaBaseProxy_HookUIShowCardState()
		{
			return default(bool);
		}

		// Token: 0x06014E7A RID: 85626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E7A")]
		[Address(RVA = "0xD52140", Offset = "0xD50D40", VA = "0x180D52140")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x06014E7B RID: 85627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E7B")]
		[Address(RVA = "0xD521A0", Offset = "0xD50DA0", VA = "0x180D521A0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x06014E7C RID: 85628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E7C")]
		[Address(RVA = "0xD52260", Offset = "0xD50E60", VA = "0x180D52260")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06014E7D RID: 85629 RVA: 0x00089418 File Offset: 0x00087618
		[Token(Token = "0x6014E7D")]
		[Address(RVA = "0xD51F40", Offset = "0xD50B40", VA = "0x180D51F40")]
		private bool <>xLuaBaseProxy_HookCharacterInfoSubPanelSkillParse(Blackboard P0, BattleCharacterData P1, ref string P2)
		{
			return default(bool);
		}

		// Token: 0x06014E7E RID: 85630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E7E")]
		[Address(RVA = "0xD52080", Offset = "0xD50C80", VA = "0x180D52080")]
		private void <>xLuaBaseProxy_OnCharacterMenuShow(Character P0)
		{
		}

		// Token: 0x06014E7F RID: 85631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E7F")]
		[Address(RVA = "0xD52020", Offset = "0xD50C20", VA = "0x180D52020")]
		private void <>xLuaBaseProxy_OnCharacterMenuHide()
		{
		}

		// Token: 0x06014E80 RID: 85632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E80")]
		[Address(RVA = "0xD52200", Offset = "0xD50E00", VA = "0x180D52200")]
		private void <>xLuaBaseProxy_OnUIStateChanged(IUIStateNode P0)
		{
		}

		// Token: 0x06014E81 RID: 85633 RVA: 0x00089430 File Offset: 0x00087630
		[Token(Token = "0x6014E81")]
		[Address(RVA = "0xD51FB0", Offset = "0xD50BB0", VA = "0x180D51FB0")]
		private bool <>xLuaBaseProxy_HookPredefinedUILocation(Camera P0, PredefinedLocation P1, out Vector3 P2)
		{
			return default(bool);
		}

		// Token: 0x04018DA3 RID: 101795
		[Token(Token = "0x4018DA3")]
		public const UIStateEnum UI_STATE_DRAG_STATE = UIStateEnum.PLUGIN_0;

		// Token: 0x04018DA4 RID: 101796
		[Token(Token = "0x4018DA4")]
		public const UIStateEnum UI_STATE_HIGHLIGHT_STATE = UIStateEnum.PLUGIN_1;

		// Token: 0x04018DA5 RID: 101797
		[Token(Token = "0x4018DA5")]
		public const UIStateEnum UI_STATE_ACCOMPLISHED_STATE = UIStateEnum.PLUGIN_2;

		// Token: 0x04018DA6 RID: 101798
		[Token(Token = "0x4018DA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x04018DA7 RID: 101799
		[Token(Token = "0x4018DA7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessCharacterMenuPanel _characterMenuPanel;

		// Token: 0x04018DA8 RID: 101800
		[Token(Token = "0x4018DA8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _dummyHudPrefabName;

		// Token: 0x04018DA9 RID: 101801
		[Token(Token = "0x4018DA9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICharacterInfoPanel.HookedCharacterInfoSubPanel[] _hookedCharacterInfoSubPanels;

		// Token: 0x04018DAA RID: 101802
		[Token(Token = "0x4018DAA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _hudScale;

		// Token: 0x04018DAB RID: 101803
		[Token(Token = "0x4018DAB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _bottomMask;

		// Token: 0x04018DAC RID: 101804
		[Token(Token = "0x4018DAC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _fullScreenMask;

		// Token: 0x04018DAD RID: 101805
		[Token(Token = "0x4018DAD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _boundBarAnchor;

		// Token: 0x04018DAE RID: 101806
		[Token(Token = "0x4018DAE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _shopCenterAnchor;

		// Token: 0x04018DAF RID: 101807
		[Token(Token = "0x4018DAF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIStageInfo _startStageInfo;

		// Token: 0x04018DB0 RID: 101808
		[Token(Token = "0x4018DB0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_showCharacterMenu;

		// Token: 0x04018DB1 RID: 101809
		[Token(Token = "0x4018DB1")]
		[FieldOffset(Offset = "0x88")]
		private Character m_tmpCharacterShowedMenu;

		// Token: 0x04018DB2 RID: 101810
		[Token(Token = "0x4018DB2")]
		[FieldOffset(Offset = "0x90")]
		private Character m_characterShowedMenu;

		// Token: 0x04018DB3 RID: 101811
		[Token(Token = "0x4018DB3")]
		[FieldOffset(Offset = "0x98")]
		private bool m_characterMenuFoldIllust;

		// Token: 0x04018DB4 RID: 101812
		[Token(Token = "0x4018DB4")]
		[FieldOffset(Offset = "0xA0")]
		private AutoChessGameStatus.GameStateChecker m_gameStateChecker;

		// Token: 0x04018DB5 RID: 101813
		[Token(Token = "0x4018DB5")]
		[FieldOffset(Offset = "0xA8")]
		private AutoChessGameStatus.UIStateChecker m_uIStateChecker;

		// Token: 0x04018DB6 RID: 101814
		[Token(Token = "0x4018DB6")]
		[FieldOffset(Offset = "0xB0")]
		private AutoChessMapInfoChecker m_mapInfoChecker;

		// Token: 0x04018DB7 RID: 101815
		[Token(Token = "0x4018DB7")]
		[FieldOffset(Offset = "0xB8")]
		private AutoChessDummyHud m_dummyPluginPrefab;

		// Token: 0x04018DB8 RID: 101816
		[Token(Token = "0x4018DB8")]
		[FieldOffset(Offset = "0xC0")]
		private AutoChessCharacterMenuPanel m_characterMenuPanel;

		// Token: 0x04018DB9 RID: 101817
		[Token(Token = "0x4018DB9")]
		[FieldOffset(Offset = "0xC8")]
		private ListDict<Tile, AutoChessDummyHud> m_dummyHudMap;

		// Token: 0x04018DBA RID: 101818
		[Token(Token = "0x4018DBA")]
		private const BattleFunctionDisableMask m_initFunctionDisableMask = (BattleFunctionDisableMask)61563;

		// Token: 0x04018DBB RID: 101819
		[Token(Token = "0x4018DBB")]
		[FieldOffset(Offset = "0xD0")]
		public Action<object> onBeginDrag;

		// Token: 0x04018DBC RID: 101820
		[Token(Token = "0x4018DBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dummyPlugin;

		// Token: 0x04018DBD RID: 101821
		[Token(Token = "0x4018DBD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBeginDrag_StateOnly;

		// Token: 0x04018DBE RID: 101822
		[Token(Token = "0x4018DBE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hudScale;

		// Token: 0x04018DBF RID: 101823
		[Token(Token = "0x4018DBF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_needReleaseIllust;

		// Token: 0x04018DC0 RID: 101824
		[Token(Token = "0x4018DC0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_showCharacterStatusInDummy;

		// Token: 0x04018DC1 RID: 101825
		[Token(Token = "0x4018DC1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_slowMotionInCharacterMenuState;

		// Token: 0x04018DC2 RID: 101826
		[Token(Token = "0x4018DC2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HookCharacterInfoSubPanels;

		// Token: 0x04018DC3 RID: 101827
		[Token(Token = "0x4018DC3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetHookUICharacterMenuPanel;

		// Token: 0x04018DC4 RID: 101828
		[Token(Token = "0x4018DC4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04018DC5 RID: 101829
		[Token(Token = "0x4018DC5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HookUIShowCardState;

		// Token: 0x04018DC6 RID: 101830
		[Token(Token = "0x4018DC6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x04018DC7 RID: 101831
		[Token(Token = "0x4018DC7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x04018DC8 RID: 101832
		[Token(Token = "0x4018DC8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x04018DC9 RID: 101833
		[Token(Token = "0x4018DC9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HookCharacterInfoSubPanelSkillParse;

		// Token: 0x04018DCA RID: 101834
		[Token(Token = "0x4018DCA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuShow;

		// Token: 0x04018DCB RID: 101835
		[Token(Token = "0x4018DCB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuHide;

		// Token: 0x04018DCC RID: 101836
		[Token(Token = "0x4018DCC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x04018DCD RID: 101837
		[Token(Token = "0x4018DCD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HookPredefinedUILocation;

		// Token: 0x04018DCE RID: 101838
		[Token(Token = "0x4018DCE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetAutoChessShopCenterWorldPos;

		// Token: 0x04018DCF RID: 101839
		[Token(Token = "0x4018DCF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnBattleStarted;

		// Token: 0x04018DD0 RID: 101840
		[Token(Token = "0x4018DD0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnDataChanged;

		// Token: 0x04018DD1 RID: 101841
		[Token(Token = "0x4018DD1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnGameStateChanged;

		// Token: 0x04018DD2 RID: 101842
		[Token(Token = "0x4018DD2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnUIStateChanged;

		// Token: 0x04018DD3 RID: 101843
		[Token(Token = "0x4018DD3")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RefreshCostPanelState;

		// Token: 0x04018DD4 RID: 101844
		[Token(Token = "0x4018DD4")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RefreshCharacterMenuState;

		// Token: 0x04018DD5 RID: 101845
		[Token(Token = "0x4018DD5")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RefreshMask;

		// Token: 0x04018DD6 RID: 101846
		[Token(Token = "0x4018DD6")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ReqShowCharacterMenu;

		// Token: 0x04018DD7 RID: 101847
		[Token(Token = "0x4018DD7")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RefreshTmpCharacterShow;

		// Token: 0x04018DD8 RID: 101848
		[Token(Token = "0x4018DD8")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RefreshTmpCharacterShowByShop;

		// Token: 0x04018DD9 RID: 101849
		[Token(Token = "0x4018DD9")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ReqHideCharacterMenu;

		// Token: 0x04018DDA RID: 101850
		[Token(Token = "0x4018DDA")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__SwitchToDefault;

		// Token: 0x04018DDB RID: 101851
		[Token(Token = "0x4018DDB")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnDummyUpdate;

		// Token: 0x04018DDC RID: 101852
		[Token(Token = "0x4018DDC")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnDummyRemoved;

		// Token: 0x04018DDD RID: 101853
		[Token(Token = "0x4018DDD")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__SetDummyHud;

		// Token: 0x04018DDE RID: 101854
		[Token(Token = "0x4018DDE")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__SetBattleStateDummy;

		// Token: 0x04018DDF RID: 101855
		[Token(Token = "0x4018DDF")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__SetPrepareStateDummy;

		// Token: 0x04018DE0 RID: 101856
		[Token(Token = "0x4018DE0")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__SetHandDummy;

		// Token: 0x04018DE1 RID: 101857
		[Token(Token = "0x4018DE1")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__SetBattleFieldDummy;

		// Token: 0x04018DE2 RID: 101858
		[Token(Token = "0x4018DE2")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CheckInstContainsEquipIndex;

		// Token: 0x04018DE3 RID: 101859
		[Token(Token = "0x4018DE3")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
