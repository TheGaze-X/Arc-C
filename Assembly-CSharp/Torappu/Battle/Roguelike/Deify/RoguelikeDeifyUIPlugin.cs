using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Roguelike.Deify
{
	// Token: 0x02002937 RID: 10551
	[Token(Token = "0x2002937")]
	public class RoguelikeDeifyUIPlugin : UIController.Plugin
	{
		// Token: 0x0601181E RID: 71710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601181E")]
		[Address(RVA = "0x9603F0", Offset = "0x95EFF0", VA = "0x1809603F0", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0601181F RID: 71711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601181F")]
		[Address(RVA = "0x9606F0", Offset = "0x95F2F0", VA = "0x1809606F0", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x06011820 RID: 71712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011820")]
		[Address(RVA = "0x960880", Offset = "0x95F480", VA = "0x180960880", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x06011821 RID: 71713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011821")]
		[Address(RVA = "0x960A40", Offset = "0x95F640", VA = "0x180960A40", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06011822 RID: 71714 RVA: 0x0006BC70 File Offset: 0x00069E70
		[Token(Token = "0x6011822")]
		[Address(RVA = "0x95FF80", Offset = "0x95EB80", VA = "0x18095FF80", Slot = "25")]
		public override bool HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011823 RID: 71715 RVA: 0x0006BC88 File Offset: 0x00069E88
		[Token(Token = "0x6011823")]
		[Address(RVA = "0x960060", Offset = "0x95EC60", VA = "0x180960060", Slot = "24")]
		public override bool HookBattleFailedStateSwitch(BattleFailedStateParam param)
		{
			return default(bool);
		}

		// Token: 0x06011824 RID: 71716 RVA: 0x0006BCA0 File Offset: 0x00069EA0
		[Token(Token = "0x6011824")]
		[Address(RVA = "0x960150", Offset = "0x95ED50", VA = "0x180960150", Slot = "35")]
		public override bool HookConfirmFinish(Action finishCallback)
		{
			return default(bool);
		}

		// Token: 0x06011825 RID: 71717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011825")]
		[Address(RVA = "0x960310", Offset = "0x95EF10", VA = "0x180960310")]
		public void OnDeifyBattleStart()
		{
		}

		// Token: 0x06011826 RID: 71718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011826")]
		[Address(RVA = "0x960E40", Offset = "0x95FA40", VA = "0x180960E40")]
		private void _HookBattleUIPanel()
		{
		}

		// Token: 0x06011827 RID: 71719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011827")]
		[Address(RVA = "0x960CC0", Offset = "0x95F8C0", VA = "0x180960CC0")]
		private void _DetachChosenUIPanel()
		{
		}

		// Token: 0x06011828 RID: 71720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011828")]
		[Address(RVA = "0x960DA0", Offset = "0x95F9A0", VA = "0x180960DA0")]
		private void _HideOriUIPanel()
		{
		}

		// Token: 0x06011829 RID: 71721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011829")]
		[Address(RVA = "0x960B90", Offset = "0x95F790", VA = "0x180960B90")]
		private void _ActiveChosenUIPanel()
		{
		}

		// Token: 0x0601182A RID: 71722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601182A")]
		[Address(RVA = "0x960F40", Offset = "0x95FB40", VA = "0x180960F40")]
		private void _OnDeifyBattlePreStart(object args)
		{
		}

		// Token: 0x0601182B RID: 71723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601182B")]
		[Address(RVA = "0x961350", Offset = "0x95FF50", VA = "0x180961350")]
		public RoguelikeDeifyUIPlugin()
		{
		}

		// Token: 0x0601182D RID: 71725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601182D")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x0601182E RID: 71726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601182E")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x0601182F RID: 71727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601182F")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x06011830 RID: 71728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011830")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06011831 RID: 71729 RVA: 0x0006BCB8 File Offset: 0x00069EB8
		[Token(Token = "0x6011831")]
		[Address(RVA = "0x960A00", Offset = "0x95F600", VA = "0x180960A00")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011832 RID: 71730 RVA: 0x0006BCD0 File Offset: 0x00069ED0
		[Token(Token = "0x6011832")]
		[Address(RVA = "0x960A10", Offset = "0x95F610", VA = "0x180960A10")]
		private bool <>xLuaBaseProxy_HookBattleFailedStateSwitch(BattleFailedStateParam P0)
		{
			return default(bool);
		}

		// Token: 0x06011833 RID: 71731 RVA: 0x0006BCE8 File Offset: 0x00069EE8
		[Token(Token = "0x6011833")]
		[Address(RVA = "0x960A20", Offset = "0x95F620", VA = "0x180960A20")]
		private bool <>xLuaBaseProxy_HookConfirmFinish(Action P0)
		{
			return default(bool);
		}

		// Token: 0x04013944 RID: 80196
		[Token(Token = "0x4013944")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly UIController.Event ON_DEIFY_BATTLE_PRE_START;

		// Token: 0x04013945 RID: 80197
		[Token(Token = "0x4013945")]
		[FieldOffset(Offset = "0x4")]
		[HideInInspector]
		public static readonly UIStateEnum ON_BATTLE_FINISH_STATE;

		// Token: 0x04013946 RID: 80198
		[Token(Token = "0x4013946")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x04013947 RID: 80199
		[Token(Token = "0x4013947")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Panel")]
		private RoguelikeDeifyUIBattlePanel _deifyBattlePanel;

		// Token: 0x04013948 RID: 80200
		[Token(Token = "0x4013948")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Panel")]
		private RoguelikeDeifyUIChosenPanel _deifyChosenPanel;

		// Token: 0x04013949 RID: 80201
		[Token(Token = "0x4013949")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeDeifyUIBattlePanel m_battlePanel;

		// Token: 0x0401394A RID: 80202
		[Token(Token = "0x401394A")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeDeifyUIChosenPanel m_chosenPanel;

		// Token: 0x0401394B RID: 80203
		[Token(Token = "0x401394B")]
		[FieldOffset(Offset = "0x50")]
		private GameModeFactory.RoguelikeDeifyGameMode m_gameMode;

		// Token: 0x0401394C RID: 80204
		[Token(Token = "0x401394C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0401394D RID: 80205
		[Token(Token = "0x401394D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0401394E RID: 80206
		[Token(Token = "0x401394E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0401394F RID: 80207
		[Token(Token = "0x401394F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x04013950 RID: 80208
		[Token(Token = "0x4013950")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishedStateSwitch;

		// Token: 0x04013951 RID: 80209
		[Token(Token = "0x4013951")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HookBattleFailedStateSwitch;

		// Token: 0x04013952 RID: 80210
		[Token(Token = "0x4013952")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HookConfirmFinish;

		// Token: 0x04013953 RID: 80211
		[Token(Token = "0x4013953")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDeifyBattleStart;

		// Token: 0x04013954 RID: 80212
		[Token(Token = "0x4013954")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HookBattleUIPanel;

		// Token: 0x04013955 RID: 80213
		[Token(Token = "0x4013955")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DetachChosenUIPanel;

		// Token: 0x04013956 RID: 80214
		[Token(Token = "0x4013956")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HideOriUIPanel;

		// Token: 0x04013957 RID: 80215
		[Token(Token = "0x4013957")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ActiveChosenUIPanel;

		// Token: 0x04013958 RID: 80216
		[Token(Token = "0x4013958")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnDeifyBattlePreStart;

		// Token: 0x04013959 RID: 80217
		[Token(Token = "0x4013959")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
