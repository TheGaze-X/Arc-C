using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.Battle.Sandbox;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002825 RID: 10277
	[Token(Token = "0x2002825")]
	public class DialogSandboxPlugin : DialogController.DialogControllerGameModePlugin
	{
		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x060111A3 RID: 70051 RVA: 0x00069510 File Offset: 0x00067710
		[Token(Token = "0x170025B7")]
		public override GameModeMeta.GameModeType mode
		{
			[Token(Token = "0x60111A3")]
			[Address(RVA = "0x90AC40", Offset = "0x909840", VA = "0x18090AC40", Slot = "4")]
			get
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x060111A4 RID: 70052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025B8")]
		private SandboxCameraPlugin cameraPlugin
		{
			[Token(Token = "0x60111A4")]
			[Address(RVA = "0x90AB20", Offset = "0x909720", VA = "0x18090AB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060111A5 RID: 70053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111A5")]
		[Address(RVA = "0x907E90", Offset = "0x906A90", VA = "0x180907E90", Slot = "5")]
		public override Dictionary<string, BattleStoryTree.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x060111A6 RID: 70054 RVA: 0x00069528 File Offset: 0x00067728
		[Token(Token = "0x60111A6")]
		[Address(RVA = "0x90A590", Offset = "0x909190", VA = "0x18090A590")]
		private bool _ItemGE(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111A7 RID: 70055 RVA: 0x00069540 File Offset: 0x00067740
		[Token(Token = "0x60111A7")]
		[Address(RVA = "0x90A6C0", Offset = "0x9092C0", VA = "0x18090A6C0")]
		private bool _ItemGT(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111A8 RID: 70056 RVA: 0x00069558 File Offset: 0x00067758
		[Token(Token = "0x60111A8")]
		[Address(RVA = "0x909720", Offset = "0x908320", VA = "0x180909720")]
		private bool _ConditionGE(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111A9 RID: 70057 RVA: 0x00069570 File Offset: 0x00067770
		[Token(Token = "0x60111A9")]
		[Address(RVA = "0x909850", Offset = "0x908450", VA = "0x180909850")]
		private bool _ConditionGT(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111AA RID: 70058 RVA: 0x00069588 File Offset: 0x00067788
		[Token(Token = "0x60111AA")]
		[Address(RVA = "0x908ED0", Offset = "0x907AD0", VA = "0x180908ED0")]
		private bool _AddItem(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111AB RID: 70059 RVA: 0x000695A0 File Offset: 0x000677A0
		[Token(Token = "0x60111AB")]
		[Address(RVA = "0x90A950", Offset = "0x909550", VA = "0x18090A950")]
		private bool _SetCondition(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111AC RID: 70060 RVA: 0x000695B8 File Offset: 0x000677B8
		[Token(Token = "0x60111AC")]
		[Address(RVA = "0x90A480", Offset = "0x909080", VA = "0x18090A480")]
		private bool _ExecuteSave(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111AD RID: 70061 RVA: 0x000695D0 File Offset: 0x000677D0
		[Token(Token = "0x60111AD")]
		[Address(RVA = "0x90A080", Offset = "0x908C80", VA = "0x18090A080")]
		private bool _ExecuteHeader(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111AE RID: 70062 RVA: 0x000695E8 File Offset: 0x000677E8
		[Token(Token = "0x60111AE")]
		[Address(RVA = "0x90A290", Offset = "0x908E90", VA = "0x18090A290")]
		private bool _ExecutePredicate(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111AF RID: 70063 RVA: 0x00069600 File Offset: 0x00067800
		[Token(Token = "0x60111AF")]
		[Address(RVA = "0x909980", Offset = "0x908580", VA = "0x180909980")]
		private bool _ExecuteFogInView(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111B0 RID: 70064 RVA: 0x00069618 File Offset: 0x00067818
		[Token(Token = "0x60111B0")]
		[Address(RVA = "0x909C00", Offset = "0x908800", VA = "0x180909C00")]
		private bool _ExecuteFogNotInView(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111B1 RID: 70065 RVA: 0x00069630 File Offset: 0x00067830
		[Token(Token = "0x60111B1")]
		[Address(RVA = "0x909DB0", Offset = "0x9089B0", VA = "0x180909DB0")]
		private bool _ExecuteGacha(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111B2 RID: 70066 RVA: 0x00069648 File Offset: 0x00067848
		[Token(Token = "0x60111B2")]
		[Address(RVA = "0x909650", Offset = "0x908250", VA = "0x180909650")]
		private bool _CheckRift(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111B3 RID: 70067 RVA: 0x00069660 File Offset: 0x00067860
		[Token(Token = "0x60111B3")]
		[Address(RVA = "0x9094D0", Offset = "0x9080D0", VA = "0x1809094D0")]
		private bool _CheckRiftIDIs(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111B4 RID: 70068 RVA: 0x00069678 File Offset: 0x00067878
		[Token(Token = "0x60111B4")]
		[Address(RVA = "0x909030", Offset = "0x907C30", VA = "0x180909030")]
		private bool _CheckCanOrderRandomRift(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111B5 RID: 70069 RVA: 0x00069690 File Offset: 0x00067890
		[Token(Token = "0x60111B5")]
		[Address(RVA = "0x90A7F0", Offset = "0x9093F0", VA = "0x18090A7F0")]
		private bool _OrderRift(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111B6 RID: 70070 RVA: 0x000696A8 File Offset: 0x000678A8
		[Token(Token = "0x60111B6")]
		[Address(RVA = "0x909260", Offset = "0x907E60", VA = "0x180909260")]
		private bool _CheckFavor(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111B7 RID: 70071 RVA: 0x000696C0 File Offset: 0x000678C0
		[Token(Token = "0x60111B7")]
		[Address(RVA = "0x908CF0", Offset = "0x9078F0", VA = "0x180908CF0")]
		private bool _AddFavor(Command command)
		{
			return default(bool);
		}

		// Token: 0x060111B8 RID: 70072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111B8")]
		[Address(RVA = "0x907D90", Offset = "0x906990", VA = "0x180907D90", Slot = "8")]
		public override string GetBeforeBattleSignal()
		{
			return null;
		}

		// Token: 0x060111B9 RID: 70073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111B9")]
		[Address(RVA = "0x907C90", Offset = "0x906890", VA = "0x180907C90", Slot = "9")]
		public override string GetAfterBattleSignal()
		{
			return null;
		}

		// Token: 0x060111BA RID: 70074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111BA")]
		[Address(RVA = "0x908BB0", Offset = "0x9077B0", VA = "0x180908BB0", Slot = "6")]
		public override void OnSignalStart(string signal, BattleDialogParam param)
		{
		}

		// Token: 0x060111BB RID: 70075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111BB")]
		[Address(RVA = "0x908AF0", Offset = "0x9076F0", VA = "0x180908AF0", Slot = "7")]
		public override void OnDialogEnd()
		{
		}

		// Token: 0x060111BC RID: 70076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111BC")]
		[Address(RVA = "0x908A40", Offset = "0x907640", VA = "0x180908A40", Slot = "10")]
		public override void OnBeforeBattleWaveEnd()
		{
		}

		// Token: 0x060111BD RID: 70077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111BD")]
		[Address(RVA = "0x908600", Offset = "0x907200", VA = "0x180908600", Slot = "11")]
		public override void OnAfterBattleWaveStart()
		{
		}

		// Token: 0x060111BE RID: 70078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111BE")]
		[Address(RVA = "0x90AA70", Offset = "0x909670", VA = "0x18090AA70")]
		public DialogSandboxPlugin()
		{
		}

		// Token: 0x060111BF RID: 70079 RVA: 0x000696D8 File Offset: 0x000678D8
		[Token(Token = "0x60111BF")]
		[Address(RVA = "0x907BC0", Offset = "0x9067C0", VA = "0x180907BC0")]
		private GameModeMeta.GameModeType <>xLuaBaseProxy_get_mode()
		{
			return GameModeMeta.GameModeType.DEFAULT;
		}

		// Token: 0x060111C0 RID: 70080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111C0")]
		[Address(RVA = "0x907BB0", Offset = "0x9067B0", VA = "0x180907BB0")]
		private Dictionary<string, BattleStoryTree.Executor> <>xLuaBaseProxy_GetExecutors()
		{
			return null;
		}

		// Token: 0x060111C1 RID: 70081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111C1")]
		[Address(RVA = "0x907BA0", Offset = "0x9067A0", VA = "0x180907BA0")]
		private string <>xLuaBaseProxy_GetBeforeBattleSignal()
		{
			return null;
		}

		// Token: 0x060111C2 RID: 70082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111C2")]
		[Address(RVA = "0x907B90", Offset = "0x906790", VA = "0x180907B90")]
		private string <>xLuaBaseProxy_GetAfterBattleSignal()
		{
			return null;
		}

		// Token: 0x060111C3 RID: 70083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111C3")]
		[Address(RVA = "0x908CE0", Offset = "0x9078E0", VA = "0x180908CE0")]
		private void <>xLuaBaseProxy_OnSignalStart(string P0, BattleDialogParam P1)
		{
		}

		// Token: 0x060111C4 RID: 70084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111C4")]
		[Address(RVA = "0x908CD0", Offset = "0x9078D0", VA = "0x180908CD0")]
		private void <>xLuaBaseProxy_OnDialogEnd()
		{
		}

		// Token: 0x060111C5 RID: 70085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111C5")]
		[Address(RVA = "0x908CC0", Offset = "0x9078C0", VA = "0x180908CC0")]
		private void <>xLuaBaseProxy_OnBeforeBattleWaveEnd()
		{
		}

		// Token: 0x060111C6 RID: 70086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111C6")]
		[Address(RVA = "0x908CB0", Offset = "0x9078B0", VA = "0x180908CB0")]
		private void <>xLuaBaseProxy_OnAfterBattleWaveStart()
		{
		}

		// Token: 0x040132AD RID: 78509
		[Token(Token = "0x40132AD")]
		[FieldOffset(Offset = "0x18")]
		private NpcBattleInput m_currentNpc;

		// Token: 0x040132AE RID: 78510
		[Token(Token = "0x40132AE")]
		[FieldOffset(Offset = "0x20")]
		private StringBuilder m_builder;

		// Token: 0x040132AF RID: 78511
		[Token(Token = "0x40132AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mode;

		// Token: 0x040132B0 RID: 78512
		[Token(Token = "0x40132B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cameraPlugin;

		// Token: 0x040132B1 RID: 78513
		[Token(Token = "0x40132B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x040132B2 RID: 78514
		[Token(Token = "0x40132B2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ItemGE;

		// Token: 0x040132B3 RID: 78515
		[Token(Token = "0x40132B3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ItemGT;

		// Token: 0x040132B4 RID: 78516
		[Token(Token = "0x40132B4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ConditionGE;

		// Token: 0x040132B5 RID: 78517
		[Token(Token = "0x40132B5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConditionGT;

		// Token: 0x040132B6 RID: 78518
		[Token(Token = "0x40132B6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AddItem;

		// Token: 0x040132B7 RID: 78519
		[Token(Token = "0x40132B7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetCondition;

		// Token: 0x040132B8 RID: 78520
		[Token(Token = "0x40132B8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ExecuteSave;

		// Token: 0x040132B9 RID: 78521
		[Token(Token = "0x40132B9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ExecuteHeader;

		// Token: 0x040132BA RID: 78522
		[Token(Token = "0x40132BA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExecutePredicate;

		// Token: 0x040132BB RID: 78523
		[Token(Token = "0x40132BB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ExecuteFogInView;

		// Token: 0x040132BC RID: 78524
		[Token(Token = "0x40132BC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ExecuteFogNotInView;

		// Token: 0x040132BD RID: 78525
		[Token(Token = "0x40132BD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ExecuteGacha;

		// Token: 0x040132BE RID: 78526
		[Token(Token = "0x40132BE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckRift;

		// Token: 0x040132BF RID: 78527
		[Token(Token = "0x40132BF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckRiftIDIs;

		// Token: 0x040132C0 RID: 78528
		[Token(Token = "0x40132C0")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckCanOrderRandomRift;

		// Token: 0x040132C1 RID: 78529
		[Token(Token = "0x40132C1")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OrderRift;

		// Token: 0x040132C2 RID: 78530
		[Token(Token = "0x40132C2")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CheckFavor;

		// Token: 0x040132C3 RID: 78531
		[Token(Token = "0x40132C3")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__AddFavor;

		// Token: 0x040132C4 RID: 78532
		[Token(Token = "0x40132C4")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetBeforeBattleSignal;

		// Token: 0x040132C5 RID: 78533
		[Token(Token = "0x40132C5")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetAfterBattleSignal;

		// Token: 0x040132C6 RID: 78534
		[Token(Token = "0x40132C6")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnSignalStart;

		// Token: 0x040132C7 RID: 78535
		[Token(Token = "0x40132C7")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnDialogEnd;

		// Token: 0x040132C8 RID: 78536
		[Token(Token = "0x40132C8")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnBeforeBattleWaveEnd;

		// Token: 0x040132C9 RID: 78537
		[Token(Token = "0x40132C9")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnAfterBattleWaveStart;

		// Token: 0x040132CA RID: 78538
		[Token(Token = "0x40132CA")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
