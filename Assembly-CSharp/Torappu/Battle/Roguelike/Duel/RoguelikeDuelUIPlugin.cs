using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Roguelike.Duel
{
	// Token: 0x02002931 RID: 10545
	[Token(Token = "0x2002931")]
	public class RoguelikeDuelUIPlugin : UIController.Plugin
	{
		// Token: 0x060117C6 RID: 71622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C6")]
		[Address(RVA = "0x964AE0", Offset = "0x9636E0", VA = "0x180964AE0", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x060117C7 RID: 71623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C7")]
		[Address(RVA = "0x964E90", Offset = "0x963A90", VA = "0x180964E90", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x060117C8 RID: 71624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C8")]
		[Address(RVA = "0x964FE0", Offset = "0x963BE0", VA = "0x180964FE0", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x060117C9 RID: 71625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C9")]
		[Address(RVA = "0x965160", Offset = "0x963D60", VA = "0x180965160", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x060117CA RID: 71626 RVA: 0x0006B958 File Offset: 0x00069B58
		[Token(Token = "0x60117CA")]
		[Address(RVA = "0x964680", Offset = "0x963280", VA = "0x180964680", Slot = "25")]
		public override bool HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x060117CB RID: 71627 RVA: 0x0006B970 File Offset: 0x00069B70
		[Token(Token = "0x60117CB")]
		[Address(RVA = "0x964760", Offset = "0x963360", VA = "0x180964760", Slot = "24")]
		public override bool HookBattleFailedStateSwitch(BattleFailedStateParam param)
		{
			return default(bool);
		}

		// Token: 0x060117CC RID: 71628 RVA: 0x0006B988 File Offset: 0x00069B88
		[Token(Token = "0x60117CC")]
		[Address(RVA = "0x964850", Offset = "0x963450", VA = "0x180964850", Slot = "35")]
		public override bool HookConfirmFinish(Action finishCallback)
		{
			return default(bool);
		}

		// Token: 0x060117CD RID: 71629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117CD")]
		[Address(RVA = "0x964A10", Offset = "0x963610", VA = "0x180964A10")]
		public void OnDuelBattleStart()
		{
		}

		// Token: 0x060117CE RID: 71630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117CE")]
		[Address(RVA = "0x9655E0", Offset = "0x9641E0", VA = "0x1809655E0")]
		private void _HookBattleUIPanel()
		{
		}

		// Token: 0x060117CF RID: 71631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117CF")]
		[Address(RVA = "0x965440", Offset = "0x964040", VA = "0x180965440")]
		private void _DetachChosenUIPanel()
		{
		}

		// Token: 0x060117D0 RID: 71632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117D0")]
		[Address(RVA = "0x965520", Offset = "0x964120", VA = "0x180965520")]
		private void _HideOriUIPanel()
		{
		}

		// Token: 0x060117D1 RID: 71633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117D1")]
		[Address(RVA = "0x965340", Offset = "0x963F40", VA = "0x180965340")]
		private void _ActiveChosenUIPanel()
		{
		}

		// Token: 0x060117D2 RID: 71634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117D2")]
		[Address(RVA = "0x9656E0", Offset = "0x9642E0", VA = "0x1809656E0")]
		private void _OnDuelBattlePreStart(object args)
		{
		}

		// Token: 0x060117D3 RID: 71635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117D3")]
		[Address(RVA = "0x9659F0", Offset = "0x9645F0", VA = "0x1809659F0")]
		private void _OnStartMoveCamera(object args)
		{
		}

		// Token: 0x060117D4 RID: 71636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117D4")]
		[Address(RVA = "0x965BD0", Offset = "0x9647D0", VA = "0x180965BD0")]
		public RoguelikeDuelUIPlugin()
		{
		}

		// Token: 0x060117D6 RID: 71638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117D6")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x060117D7 RID: 71639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117D7")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x060117D8 RID: 71640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117D8")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x060117D9 RID: 71641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117D9")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x060117DA RID: 71642 RVA: 0x0006B9A0 File Offset: 0x00069BA0
		[Token(Token = "0x60117DA")]
		[Address(RVA = "0x960A00", Offset = "0x95F600", VA = "0x180960A00")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x060117DB RID: 71643 RVA: 0x0006B9B8 File Offset: 0x00069BB8
		[Token(Token = "0x60117DB")]
		[Address(RVA = "0x960A10", Offset = "0x95F610", VA = "0x180960A10")]
		private bool <>xLuaBaseProxy_HookBattleFailedStateSwitch(BattleFailedStateParam P0)
		{
			return default(bool);
		}

		// Token: 0x060117DC RID: 71644 RVA: 0x0006B9D0 File Offset: 0x00069BD0
		[Token(Token = "0x60117DC")]
		[Address(RVA = "0x960A20", Offset = "0x95F620", VA = "0x180960A20")]
		private bool <>xLuaBaseProxy_HookConfirmFinish(Action P0)
		{
			return default(bool);
		}

		// Token: 0x040138E7 RID: 80103
		[Token(Token = "0x40138E7")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly UIController.Event ON_START_MOVE_CAMERA;

		// Token: 0x040138E8 RID: 80104
		[Token(Token = "0x40138E8")]
		[FieldOffset(Offset = "0x4")]
		[HideInInspector]
		public static readonly UIController.Event ON_DUEL_BATTLE_PRE_START;

		// Token: 0x040138E9 RID: 80105
		[Token(Token = "0x40138E9")]
		[FieldOffset(Offset = "0x8")]
		[HideInInspector]
		public static readonly UIController.Event ON_REAL_DUEL_START;

		// Token: 0x040138EA RID: 80106
		[Token(Token = "0x40138EA")]
		[FieldOffset(Offset = "0xC")]
		[HideInInspector]
		public static readonly UIStateEnum ON_MOVE_CAMERA_STATE;

		// Token: 0x040138EB RID: 80107
		[Token(Token = "0x40138EB")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public static readonly UIStateEnum ON_BATTLE_FINISH_STATE;

		// Token: 0x040138EC RID: 80108
		[Token(Token = "0x40138EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x040138ED RID: 80109
		[Token(Token = "0x40138ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Panel")]
		private RoguelikeDuelUIBattlePanel _duelBattlePanel;

		// Token: 0x040138EE RID: 80110
		[Token(Token = "0x40138EE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Panel")]
		private RoguelikeDuelUIChosenPanel _duelChosenPanel;

		// Token: 0x040138EF RID: 80111
		[Token(Token = "0x40138EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Mask")]
		private GameObject _globalMask;

		// Token: 0x040138F0 RID: 80112
		[Token(Token = "0x40138F0")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeDuelUIBattlePanel m_battlePanel;

		// Token: 0x040138F1 RID: 80113
		[Token(Token = "0x40138F1")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeDuelUIChosenPanel m_chosenPanel;

		// Token: 0x040138F2 RID: 80114
		[Token(Token = "0x40138F2")]
		[FieldOffset(Offset = "0x58")]
		private GameModeFactory.RoguelikeDuelGameMode m_gameMode;

		// Token: 0x040138F3 RID: 80115
		[Token(Token = "0x40138F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x040138F4 RID: 80116
		[Token(Token = "0x40138F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x040138F5 RID: 80117
		[Token(Token = "0x40138F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x040138F6 RID: 80118
		[Token(Token = "0x40138F6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x040138F7 RID: 80119
		[Token(Token = "0x40138F7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishedStateSwitch;

		// Token: 0x040138F8 RID: 80120
		[Token(Token = "0x40138F8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookBattleFailedStateSwitch;

		// Token: 0x040138F9 RID: 80121
		[Token(Token = "0x40138F9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HookConfirmFinish;

		// Token: 0x040138FA RID: 80122
		[Token(Token = "0x40138FA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDuelBattleStart;

		// Token: 0x040138FB RID: 80123
		[Token(Token = "0x40138FB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HookBattleUIPanel;

		// Token: 0x040138FC RID: 80124
		[Token(Token = "0x40138FC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DetachChosenUIPanel;

		// Token: 0x040138FD RID: 80125
		[Token(Token = "0x40138FD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HideOriUIPanel;

		// Token: 0x040138FE RID: 80126
		[Token(Token = "0x40138FE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ActiveChosenUIPanel;

		// Token: 0x040138FF RID: 80127
		[Token(Token = "0x40138FF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnDuelBattlePreStart;

		// Token: 0x04013900 RID: 80128
		[Token(Token = "0x4013900")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnStartMoveCamera;

		// Token: 0x04013901 RID: 80129
		[Token(Token = "0x4013901")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
