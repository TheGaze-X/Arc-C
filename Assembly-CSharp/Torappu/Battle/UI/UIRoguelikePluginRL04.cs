using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200334A RID: 13130
	[Token(Token = "0x200334A")]
	public class UIRoguelikePluginRL04 : UIController.Plugin
	{
		// Token: 0x06014F24 RID: 85796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F24")]
		[Address(RVA = "0xD61580", Offset = "0xD60180", VA = "0x180D61580", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x06014F25 RID: 85797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F25")]
		[Address(RVA = "0xD618B0", Offset = "0xD604B0", VA = "0x180D618B0", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06014F26 RID: 85798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F26")]
		[Address(RVA = "0xD61A80", Offset = "0xD60680", VA = "0x180D61A80", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014F27 RID: 85799 RVA: 0x00089A00 File Offset: 0x00087C00
		[Token(Token = "0x6014F27")]
		[Address(RVA = "0xD61300", Offset = "0xD5FF00", VA = "0x180D61300", Slot = "22")]
		public override bool HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014F28 RID: 85800 RVA: 0x00089A18 File Offset: 0x00087C18
		[Token(Token = "0x6014F28")]
		[Address(RVA = "0xD61140", Offset = "0xD5FD40", VA = "0x180D61140", Slot = "35")]
		public override bool HookConfirmFinish(Action finishCallback)
		{
			return default(bool);
		}

		// Token: 0x06014F29 RID: 85801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014F29")]
		[Address(RVA = "0xD60FD0", Offset = "0xD5FBD0", VA = "0x180D60FD0", Slot = "29")]
		public override RectTransform HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x06014F2A RID: 85802 RVA: 0x00089A30 File Offset: 0x00087C30
		[Token(Token = "0x6014F2A")]
		[Address(RVA = "0xD61070", Offset = "0xD5FC70", VA = "0x180D61070", Slot = "30")]
		public override bool HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06014F2B RID: 85803 RVA: 0x00089A48 File Offset: 0x00087C48
		[Token(Token = "0x6014F2B")]
		[Address(RVA = "0xD60F30", Offset = "0xD5FB30", VA = "0x180D60F30", Slot = "31")]
		public override bool HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x06014F2C RID: 85804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F2C")]
		[Address(RVA = "0xD61C30", Offset = "0xD60830", VA = "0x180D61C30")]
		private void _InitFailedPanel()
		{
		}

		// Token: 0x06014F2D RID: 85805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F2D")]
		[Address(RVA = "0xD61D10", Offset = "0xD60910", VA = "0x180D61D10")]
		public UIRoguelikePluginRL04()
		{
		}

		// Token: 0x06014F2F RID: 85807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F2F")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06014F30 RID: 85808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F30")]
		[Address(RVA = "0xD520E0", Offset = "0xD50CE0", VA = "0x180D520E0")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06014F31 RID: 85809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F31")]
		[Address(RVA = "0xD521A0", Offset = "0xD50DA0", VA = "0x180D521A0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x06014F32 RID: 85810 RVA: 0x00089A60 File Offset: 0x00087C60
		[Token(Token = "0x6014F32")]
		[Address(RVA = "0xD57EA0", Offset = "0xD56AA0", VA = "0x180D57EA0")]
		private bool <>xLuaBaseProxy_HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014F33 RID: 85811 RVA: 0x00089A78 File Offset: 0x00087C78
		[Token(Token = "0x6014F33")]
		[Address(RVA = "0xD57D40", Offset = "0xD56940", VA = "0x180D57D40")]
		private bool <>xLuaBaseProxy_HookConfirmFinish(Action P0)
		{
			return default(bool);
		}

		// Token: 0x06014F34 RID: 85812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014F34")]
		[Address(RVA = "0xD57A80", Offset = "0xD56680", VA = "0x180D57A80")]
		private RectTransform <>xLuaBaseProxy_HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x06014F35 RID: 85813 RVA: 0x00089A90 File Offset: 0x00087C90
		[Token(Token = "0x6014F35")]
		[Address(RVA = "0xD57AE0", Offset = "0xD566E0", VA = "0x180D57AE0")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06014F36 RID: 85814 RVA: 0x00089AA8 File Offset: 0x00087CA8
		[Token(Token = "0x6014F36")]
		[Address(RVA = "0xD57A20", Offset = "0xD56620", VA = "0x180D57A20")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x04018E93 RID: 102035
		[Token(Token = "0x4018E93")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly UIStateEnum UI_STATE_MOVE_CAMERA;

		// Token: 0x04018E94 RID: 102036
		[Token(Token = "0x4018E94")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("BattleFailedMask")]
		private UIRoguelikeBattleFailedMask _battleFailedMaskPrefab;

		// Token: 0x04018E95 RID: 102037
		[Token(Token = "0x4018E95")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIGoldStealBattleToastPanelRL04 _goldStealBattleToastPrefab;

		// Token: 0x04018E96 RID: 102038
		[Token(Token = "0x4018E96")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIDisasterContinueBattleToastPanelRL04 _disasterContinueBattleToastPrefab;

		// Token: 0x04018E97 RID: 102039
		[Token(Token = "0x4018E97")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UISkzddPreachBattleToastPanelRL04 _skzddPreachBattleToastPrefab;

		// Token: 0x04018E98 RID: 102040
		[Token(Token = "0x4018E98")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x04018E99 RID: 102041
		[Token(Token = "0x4018E99")]
		[FieldOffset(Offset = "0x50")]
		private UIGoldStealBattleToastPanelRL04 m_goldStealToast;

		// Token: 0x04018E9A RID: 102042
		[Token(Token = "0x4018E9A")]
		[FieldOffset(Offset = "0x58")]
		private UIDisasterContinueBattleToastPanelRL04 m_disasterContinueToast;

		// Token: 0x04018E9B RID: 102043
		[Token(Token = "0x4018E9B")]
		[FieldOffset(Offset = "0x60")]
		private UISkzddPreachBattleToastPanelRL04 m_skzddPreachToast;

		// Token: 0x04018E9C RID: 102044
		[Token(Token = "0x4018E9C")]
		[FieldOffset(Offset = "0x68")]
		private UIRoguelikeBattleFailedMask m_failedPanel;

		// Token: 0x04018E9D RID: 102045
		[Token(Token = "0x4018E9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04018E9E RID: 102046
		[Token(Token = "0x4018E9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04018E9F RID: 102047
		[Token(Token = "0x4018E9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x04018EA0 RID: 102048
		[Token(Token = "0x4018EA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HookGameReadyStateSwitch;

		// Token: 0x04018EA1 RID: 102049
		[Token(Token = "0x4018EA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HookConfirmFinish;

		// Token: 0x04018EA2 RID: 102050
		[Token(Token = "0x4018EA2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelInit;

		// Token: 0x04018EA3 RID: 102051
		[Token(Token = "0x4018EA3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelShow;

		// Token: 0x04018EA4 RID: 102052
		[Token(Token = "0x4018EA4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelHide;

		// Token: 0x04018EA5 RID: 102053
		[Token(Token = "0x4018EA5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitFailedPanel;

		// Token: 0x04018EA6 RID: 102054
		[Token(Token = "0x4018EA6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200334B RID: 13131
		[Token(Token = "0x200334B")]
		public enum ToastTypeRL04
		{
			// Token: 0x04018EA8 RID: 102056
			[Token(Token = "0x4018EA8")]
			GOLD_STEAL = 7,
			// Token: 0x04018EA9 RID: 102057
			[Token(Token = "0x4018EA9")]
			DISASTER_CONTINUE,
			// Token: 0x04018EAA RID: 102058
			[Token(Token = "0x4018EAA")]
			SKZDD_PREACH
		}
	}
}
