using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle.UI
{
	// Token: 0x020070D0 RID: 28880
	[Token(Token = "0x20070D0")]
	public class BossRushPlugin : UIController.Plugin
	{
		// Token: 0x060290AB RID: 168107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290AB")]
		[Address(RVA = "0x2476E20", Offset = "0x2475A20", VA = "0x182476E20", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x060290AC RID: 168108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290AC")]
		[Address(RVA = "0x24770E0", Offset = "0x2475CE0", VA = "0x1824770E0", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x060290AD RID: 168109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290AD")]
		[Address(RVA = "0x2476F40", Offset = "0x2475B40", VA = "0x182476F40", Slot = "16")]
		public override void OnGameReady()
		{
		}

		// Token: 0x060290AE RID: 168110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290AE")]
		[Address(RVA = "0x2477000", Offset = "0x2475C00", VA = "0x182477000", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x060290AF RID: 168111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290AF")]
		[Address(RVA = "0x2477260", Offset = "0x2475E60", VA = "0x182477260", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x060290B0 RID: 168112 RVA: 0x000D4310 File Offset: 0x000D2510
		[Token(Token = "0x60290B0")]
		[Address(RVA = "0x2476B80", Offset = "0x2475780", VA = "0x182476B80", Slot = "44")]
		public override bool CanPressBackButton()
		{
			return default(bool);
		}

		// Token: 0x060290B1 RID: 168113 RVA: 0x000D4328 File Offset: 0x000D2528
		[Token(Token = "0x60290B1")]
		[Address(RVA = "0x2476D30", Offset = "0x2475930", VA = "0x182476D30", Slot = "32")]
		public override bool HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x060290B2 RID: 168114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290B2")]
		[Address(RVA = "0x24773D0", Offset = "0x2475FD0", VA = "0x1824773D0")]
		public BossRushPlugin()
		{
		}

		// Token: 0x060290B4 RID: 168116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290B4")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x060290B5 RID: 168117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290B5")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x060290B6 RID: 168118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290B6")]
		[Address(RVA = "0x9CCDF0", Offset = "0x9CB9F0", VA = "0x1809CCDF0")]
		private void <>xLuaBaseProxy_OnGameReady()
		{
		}

		// Token: 0x060290B7 RID: 168119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290B7")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x060290B8 RID: 168120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290B8")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x060290B9 RID: 168121 RVA: 0x000D4340 File Offset: 0x000D2540
		[Token(Token = "0x60290B9")]
		[Address(RVA = "0xDD4300", Offset = "0xDD2F00", VA = "0x180DD4300")]
		private bool <>xLuaBaseProxy_CanPressBackButton()
		{
			return default(bool);
		}

		// Token: 0x060290BA RID: 168122 RVA: 0x000D4358 File Offset: 0x000D2558
		[Token(Token = "0x60290BA")]
		[Address(RVA = "0x7D2470", Offset = "0x7D1070", VA = "0x1807D2470")]
		private bool <>xLuaBaseProxy_HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x0403A969 RID: 239977
		[Token(Token = "0x403A969")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BossRushHintPanel _bossRushHintPanel;

		// Token: 0x0403A96A RID: 239978
		[Token(Token = "0x403A96A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("TopBar")]
		private BossRushTopbarStatus _bossRushTopbarStatus;

		// Token: 0x0403A96B RID: 239979
		[Token(Token = "0x403A96B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x0403A96C RID: 239980
		[Token(Token = "0x403A96C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIController.Event ON_HINT_DANGER_AREA;

		// Token: 0x0403A96D RID: 239981
		[Token(Token = "0x403A96D")]
		[FieldOffset(Offset = "0x4")]
		public static readonly UIController.Event ON_NEXT_BOSS_WAVE_WILL_START;

		// Token: 0x0403A96E RID: 239982
		[Token(Token = "0x403A96E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UIController.Event ON_START_MOVE_CAMERA;

		// Token: 0x0403A96F RID: 239983
		[Token(Token = "0x403A96F")]
		[FieldOffset(Offset = "0xC")]
		public static readonly UIController.Event ON_BONUS_WAVE_FINISH;

		// Token: 0x0403A970 RID: 239984
		[Token(Token = "0x403A970")]
		[FieldOffset(Offset = "0x10")]
		public static readonly UIStateEnum ON_BOSS_WAVE_START_STATE;

		// Token: 0x0403A971 RID: 239985
		[Token(Token = "0x403A971")]
		[FieldOffset(Offset = "0x14")]
		public static readonly UIStateEnum ON_MOVE_CAMERA_STATE;

		// Token: 0x0403A972 RID: 239986
		[Token(Token = "0x403A972")]
		[FieldOffset(Offset = "0x18")]
		public static readonly UIStateEnum ON_BOSSRUSH_SYSTEM_MENU;

		// Token: 0x0403A973 RID: 239987
		[Token(Token = "0x403A973")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0403A974 RID: 239988
		[Token(Token = "0x403A974")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0403A975 RID: 239989
		[Token(Token = "0x403A975")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0403A976 RID: 239990
		[Token(Token = "0x403A976")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0403A977 RID: 239991
		[Token(Token = "0x403A977")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403A978 RID: 239992
		[Token(Token = "0x403A978")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CanPressBackButton;

		// Token: 0x0403A979 RID: 239993
		[Token(Token = "0x403A979")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HookBattleSystemMenuSwitch;

		// Token: 0x0403A97A RID: 239994
		[Token(Token = "0x403A97A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
