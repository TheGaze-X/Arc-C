using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.Battle.DataCenter;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002770 RID: 10096
	[Token(Token = "0x2002770")]
	public class AutoChessTutorialManager : IHotfixable
	{
		// Token: 0x0601076D RID: 67437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601076D")]
		[Address(RVA = "0x8365F0", Offset = "0x8351F0", VA = "0x1808365F0")]
		public void Start(AutoChessTutorialManager.AutoChessTutorialManagerConfig cfg)
		{
		}

		// Token: 0x0601076E RID: 67438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601076E")]
		[Address(RVA = "0x837770", Offset = "0x836370", VA = "0x180837770")]
		private void _HandleDataChanged(object arg)
		{
		}

		// Token: 0x0601076F RID: 67439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601076F")]
		[Address(RVA = "0x837D20", Offset = "0x836920", VA = "0x180837D20")]
		private void _RegisterTutorial(string tutorialName)
		{
		}

		// Token: 0x06010770 RID: 67440 RVA: 0x00064488 File Offset: 0x00062688
		[Token(Token = "0x6010770")]
		[Address(RVA = "0x836A80", Offset = "0x835680", VA = "0x180836A80")]
		private bool _CheckTutorialPlayed(string tutorialName)
		{
			return default(bool);
		}

		// Token: 0x06010771 RID: 67441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010771")]
		[Address(RVA = "0x837850", Offset = "0x836450", VA = "0x180837850")]
		private void _HandleStateUpdate()
		{
		}

		// Token: 0x06010772 RID: 67442 RVA: 0x000644A0 File Offset: 0x000626A0
		[Token(Token = "0x6010772")]
		[Address(RVA = "0x838580", Offset = "0x837180", VA = "0x180838580")]
		private bool _TryTriggerTutorialClip_R1_PREPARE_MAIN(AutoChessDataCenter center)
		{
			return default(bool);
		}

		// Token: 0x06010773 RID: 67443 RVA: 0x000644B8 File Offset: 0x000626B8
		[Token(Token = "0x6010773")]
		[Address(RVA = "0x838A10", Offset = "0x837610", VA = "0x180838A10")]
		private bool _TryTriggerTutorialClip_R2_PREPARE_MAIN(AutoChessDataCenter center)
		{
			return default(bool);
		}

		// Token: 0x06010774 RID: 67444 RVA: 0x000644D0 File Offset: 0x000626D0
		[Token(Token = "0x6010774")]
		[Address(RVA = "0x8387F0", Offset = "0x8373F0", VA = "0x1808387F0")]
		private bool _TryTriggerTutorialClip_R2_BATTLE_END(AutoChessDataCenter center)
		{
			return default(bool);
		}

		// Token: 0x06010775 RID: 67445 RVA: 0x000644E8 File Offset: 0x000626E8
		[Token(Token = "0x6010775")]
		[Address(RVA = "0x838C40", Offset = "0x837840", VA = "0x180838C40")]
		private bool _TryTriggerTutorialClip_R3_SP_PREPARE_MAIN(AutoChessDataCenter center)
		{
			return default(bool);
		}

		// Token: 0x06010776 RID: 67446 RVA: 0x00064500 File Offset: 0x00062700
		[Token(Token = "0x6010776")]
		[Address(RVA = "0x838D90", Offset = "0x837990", VA = "0x180838D90")]
		private bool _TryTriggerTutorialClip_R4_PREPARE_MAIN(AutoChessDataCenter center)
		{
			return default(bool);
		}

		// Token: 0x06010777 RID: 67447 RVA: 0x00064518 File Offset: 0x00062718
		[Token(Token = "0x6010777")]
		[Address(RVA = "0x839270", Offset = "0x837E70", VA = "0x180839270")]
		private bool _TryTriggerTutorial(AutoChessDataCenter center, AutoChessTutorialManager.AVGStateTutorialTriggerParam param)
		{
			return default(bool);
		}

		// Token: 0x06010778 RID: 67448 RVA: 0x00064530 File Offset: 0x00062730
		[Token(Token = "0x6010778")]
		[Address(RVA = "0x839080", Offset = "0x837C80", VA = "0x180839080")]
		private bool _TryTriggerTutorialWithCallBack(AutoChessDataCenter center, AutoChessTutorialManager.AVGStateTutorialTriggerParam param, Action<Story> onCompleted)
		{
			return default(bool);
		}

		// Token: 0x06010779 RID: 67449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010779")]
		[Address(RVA = "0x837DB0", Offset = "0x8369B0", VA = "0x180837DB0")]
		private void _TriggerTutorialClip_R1_PREPARE_MAIN_ADDON_1(Story story)
		{
		}

		// Token: 0x0601077A RID: 67450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601077A")]
		[Address(RVA = "0x837FE0", Offset = "0x836BE0", VA = "0x180837FE0")]
		private void _TriggerTutorialClip_R1_PREPARE_MAIN_ADDON_2(Story story)
		{
		}

		// Token: 0x0601077B RID: 67451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601077B")]
		[Address(RVA = "0x838160", Offset = "0x836D60", VA = "0x180838160")]
		private void _TriggerTutorialClip_R2_PREPARE_MAIN_ADDON_1(Story story)
		{
		}

		// Token: 0x0601077C RID: 67452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601077C")]
		[Address(RVA = "0x838380", Offset = "0x836F80", VA = "0x180838380")]
		private void _TriggerTutorialClip_R2_PREPARE_MAIN_ADDON_2(Story story)
		{
		}

		// Token: 0x0601077D RID: 67453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601077D")]
		[Address(RVA = "0x838490", Offset = "0x837090", VA = "0x180838490")]
		private void _TryRaiseAVGSignal(string signal)
		{
		}

		// Token: 0x0601077E RID: 67454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601077E")]
		[Address(RVA = "0x837C10", Offset = "0x836810", VA = "0x180837C10")]
		private void _RegisterTutorialTarget(string targetKey, GridPosition validChessPos)
		{
		}

		// Token: 0x0601077F RID: 67455 RVA: 0x00064548 File Offset: 0x00062748
		[Token(Token = "0x601077F")]
		[Address(RVA = "0x837700", Offset = "0x836300", VA = "0x180837700")]
		private GridPosition _GetValidHandTileRightBorder()
		{
			return default(GridPosition);
		}

		// Token: 0x06010780 RID: 67456 RVA: 0x00064560 File Offset: 0x00062760
		[Token(Token = "0x6010780")]
		[Address(RVA = "0x837690", Offset = "0x836290", VA = "0x180837690")]
		private GridPosition _GetValidHandTileCenter()
		{
			return default(GridPosition);
		}

		// Token: 0x06010781 RID: 67457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010781")]
		[Address(RVA = "0x8379B0", Offset = "0x8365B0", VA = "0x1808379B0")]
		private void _InitBorderPositions()
		{
		}

		// Token: 0x06010782 RID: 67458 RVA: 0x00064578 File Offset: 0x00062778
		[Token(Token = "0x6010782")]
		[Address(RVA = "0x837510", Offset = "0x836110", VA = "0x180837510")]
		private GridPosition _GetFirstBattleFieldCharacterPos()
		{
			return default(GridPosition);
		}

		// Token: 0x06010783 RID: 67459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010783")]
		[Address(RVA = "0x836E80", Offset = "0x835A80", VA = "0x180836E80")]
		private void _FetchTargetAndSignal_R1_PREPARE_MAIN()
		{
		}

		// Token: 0x06010784 RID: 67460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010784")]
		[Address(RVA = "0x836D30", Offset = "0x835930", VA = "0x180836D30")]
		private void _FetchTargetAndSignal_R1_PREPARE_MAIN_ADDON_1()
		{
		}

		// Token: 0x06010785 RID: 67461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010785")]
		[Address(RVA = "0x836E00", Offset = "0x835A00", VA = "0x180836E00")]
		private void _FetchTargetAndSignal_R1_PREPARE_MAIN_ADDON_2()
		{
		}

		// Token: 0x06010786 RID: 67462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010786")]
		[Address(RVA = "0x836B10", Offset = "0x835710", VA = "0x180836B10")]
		private void _FetchTargetAndSignal_DRAG_END(object arg)
		{
		}

		// Token: 0x06010787 RID: 67463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010787")]
		[Address(RVA = "0x836C70", Offset = "0x835870", VA = "0x180836C70")]
		private void _FetchTargetAndSignal_PLACE_ON_BATTLEFIELD(object arg)
		{
		}

		// Token: 0x06010788 RID: 67464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010788")]
		[Address(RVA = "0x837400", Offset = "0x836000", VA = "0x180837400")]
		private void _FetchTargetAndSignal_STATE_CHANGE(object arg)
		{
		}

		// Token: 0x06010789 RID: 67465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010789")]
		[Address(RVA = "0x837020", Offset = "0x835C20", VA = "0x180837020")]
		private void _FetchTargetAndSignal_R2_PREPARE_MAIN()
		{
		}

		// Token: 0x0601078A RID: 67466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601078A")]
		[Address(RVA = "0x836F50", Offset = "0x835B50", VA = "0x180836F50")]
		private void _FetchTargetAndSignal_R2_PREPARE_MAIN_ADDON_1()
		{
		}

		// Token: 0x0601078B RID: 67467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601078B")]
		[Address(RVA = "0x8370A0", Offset = "0x835CA0", VA = "0x1808370A0")]
		private void _FetchTargetAndSignal_R3_SP_PREPARE_MAIN()
		{
		}

		// Token: 0x0601078C RID: 67468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601078C")]
		[Address(RVA = "0x837260", Offset = "0x835E60", VA = "0x180837260")]
		private void _FetchTargetAndSignal_R4_PREPARE_MAIN()
		{
		}

		// Token: 0x0601078D RID: 67469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601078D")]
		[Address(RVA = "0x839420", Offset = "0x838020", VA = "0x180839420")]
		public AutoChessTutorialManager()
		{
		}

		// Token: 0x04012723 RID: 75555
		[Token(Token = "0x4012723")]
		private const int DEFAULT_COL_MIN = 100000;

		// Token: 0x04012724 RID: 75556
		[Token(Token = "0x4012724")]
		private const int DEFAULT_COL_MAX = -1;

		// Token: 0x04012725 RID: 75557
		[Token(Token = "0x4012725")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isTrainningMode;

		// Token: 0x04012726 RID: 75558
		[Token(Token = "0x4012726")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<string> m_tutorialPlayed;

		// Token: 0x04012727 RID: 75559
		[Token(Token = "0x4012727")]
		[FieldOffset(Offset = "0x20")]
		private AutoChessGameStatus.GameStateChecker m_stateChecker;

		// Token: 0x04012728 RID: 75560
		[Token(Token = "0x4012728")]
		[FieldOffset(Offset = "0x28")]
		private List<Func<AutoChessDataCenter, bool>> m_stateRelatedTutorialSignalList;

		// Token: 0x04012729 RID: 75561
		[Token(Token = "0x4012729")]
		[FieldOffset(Offset = "0x30")]
		private AutoChessTutorialManager.BlockSubStateTask m_blockBattleEndStateTask;

		// Token: 0x0401272A RID: 75562
		[Token(Token = "0x401272A")]
		[FieldOffset(Offset = "0x38")]
		private AutoChessTutorialManager.AutoChessTutorialManagerConfig m_cfg;

		// Token: 0x0401272B RID: 75563
		[Token(Token = "0x401272B")]
		[FieldOffset(Offset = "0x40")]
		private bool m_borderInited;

		// Token: 0x0401272C RID: 75564
		[Token(Token = "0x401272C")]
		[FieldOffset(Offset = "0x44")]
		private GridPosition m_validHandTileRightBorder;

		// Token: 0x0401272D RID: 75565
		[Token(Token = "0x401272D")]
		[FieldOffset(Offset = "0x4C")]
		private GridPosition m_validHandTileLeftBorder;

		// Token: 0x0401272E RID: 75566
		[Token(Token = "0x401272E")]
		[FieldOffset(Offset = "0x54")]
		private GridPosition m_validHandTileCenter;

		// Token: 0x0401272F RID: 75567
		[Token(Token = "0x401272F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04012730 RID: 75568
		[Token(Token = "0x4012730")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleDataChanged;

		// Token: 0x04012731 RID: 75569
		[Token(Token = "0x4012731")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorial;

		// Token: 0x04012732 RID: 75570
		[Token(Token = "0x4012732")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckTutorialPlayed;

		// Token: 0x04012733 RID: 75571
		[Token(Token = "0x4012733")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HandleStateUpdate;

		// Token: 0x04012734 RID: 75572
		[Token(Token = "0x4012734")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorialClip_R1_PREPARE_MAIN;

		// Token: 0x04012735 RID: 75573
		[Token(Token = "0x4012735")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorialClip_R2_PREPARE_MAIN;

		// Token: 0x04012736 RID: 75574
		[Token(Token = "0x4012736")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorialClip_R2_BATTLE_END;

		// Token: 0x04012737 RID: 75575
		[Token(Token = "0x4012737")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorialClip_R3_SP_PREPARE_MAIN;

		// Token: 0x04012738 RID: 75576
		[Token(Token = "0x4012738")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorialClip_R4_PREPARE_MAIN;

		// Token: 0x04012739 RID: 75577
		[Token(Token = "0x4012739")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x0401273A RID: 75578
		[Token(Token = "0x401273A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorialWithCallBack;

		// Token: 0x0401273B RID: 75579
		[Token(Token = "0x401273B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TriggerTutorialClip_R1_PREPARE_MAIN_ADDON_1;

		// Token: 0x0401273C RID: 75580
		[Token(Token = "0x401273C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TriggerTutorialClip_R1_PREPARE_MAIN_ADDON_2;

		// Token: 0x0401273D RID: 75581
		[Token(Token = "0x401273D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TriggerTutorialClip_R2_PREPARE_MAIN_ADDON_1;

		// Token: 0x0401273E RID: 75582
		[Token(Token = "0x401273E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TriggerTutorialClip_R2_PREPARE_MAIN_ADDON_2;

		// Token: 0x0401273F RID: 75583
		[Token(Token = "0x401273F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryRaiseAVGSignal;

		// Token: 0x04012740 RID: 75584
		[Token(Token = "0x4012740")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RegisterTutorialTarget;

		// Token: 0x04012741 RID: 75585
		[Token(Token = "0x4012741")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetValidHandTileRightBorder;

		// Token: 0x04012742 RID: 75586
		[Token(Token = "0x4012742")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetValidHandTileCenter;

		// Token: 0x04012743 RID: 75587
		[Token(Token = "0x4012743")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InitBorderPositions;

		// Token: 0x04012744 RID: 75588
		[Token(Token = "0x4012744")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetFirstBattleFieldCharacterPos;

		// Token: 0x04012745 RID: 75589
		[Token(Token = "0x4012745")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_R1_PREPARE_MAIN;

		// Token: 0x04012746 RID: 75590
		[Token(Token = "0x4012746")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_R1_PREPARE_MAIN_ADDON_1;

		// Token: 0x04012747 RID: 75591
		[Token(Token = "0x4012747")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_R1_PREPARE_MAIN_ADDON_2;

		// Token: 0x04012748 RID: 75592
		[Token(Token = "0x4012748")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_DRAG_END;

		// Token: 0x04012749 RID: 75593
		[Token(Token = "0x4012749")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_PLACE_ON_BATTLEFIELD;

		// Token: 0x0401274A RID: 75594
		[Token(Token = "0x401274A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_STATE_CHANGE;

		// Token: 0x0401274B RID: 75595
		[Token(Token = "0x401274B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_R2_PREPARE_MAIN;

		// Token: 0x0401274C RID: 75596
		[Token(Token = "0x401274C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_R2_PREPARE_MAIN_ADDON_1;

		// Token: 0x0401274D RID: 75597
		[Token(Token = "0x401274D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_R3_SP_PREPARE_MAIN;

		// Token: 0x0401274E RID: 75598
		[Token(Token = "0x401274E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__FetchTargetAndSignal_R4_PREPARE_MAIN;

		// Token: 0x0401274F RID: 75599
		[Token(Token = "0x401274F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002771 RID: 10097
		[Token(Token = "0x2002771")]
		public class BlockSubStateTask : GameModeFactory.AutoChessGameMode.BattlePendingTaskBase
		{
			// Token: 0x170023EE RID: 9198
			// (get) Token: 0x0601078F RID: 67471 RVA: 0x00064590 File Offset: 0x00062790
			[Token(Token = "0x170023EE")]
			public override bool taskFinished
			{
				[Token(Token = "0x601078F")]
				[Address(RVA = "0x850210", Offset = "0x84EE10", VA = "0x180850210", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170023EF RID: 9199
			// (get) Token: 0x06010790 RID: 67472 RVA: 0x000645A8 File Offset: 0x000627A8
			[Token(Token = "0x170023EF")]
			public override float maxTaskTime
			{
				[Token(Token = "0x6010790")]
				[Address(RVA = "0x8501B0", Offset = "0x84EDB0", VA = "0x1808501B0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06010791 RID: 67473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010791")]
			[Address(RVA = "0x8500C0", Offset = "0x84ECC0", VA = "0x1808500C0")]
			public void TryBlockSubStateOrNot(bool block)
			{
			}

			// Token: 0x06010792 RID: 67474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010792")]
			[Address(RVA = "0x850150", Offset = "0x84ED50", VA = "0x180850150")]
			public BlockSubStateTask()
			{
			}

			// Token: 0x06010793 RID: 67475 RVA: 0x000645C0 File Offset: 0x000627C0
			[Token(Token = "0x6010793")]
			[Address(RVA = "0x850140", Offset = "0x84ED40", VA = "0x180850140")]
			private bool <>xLuaBaseProxy_get_taskFinished()
			{
				return default(bool);
			}

			// Token: 0x06010794 RID: 67476 RVA: 0x000645D8 File Offset: 0x000627D8
			[Token(Token = "0x6010794")]
			[Address(RVA = "0x850130", Offset = "0x84ED30", VA = "0x180850130")]
			private float <>xLuaBaseProxy_get_maxTaskTime()
			{
				return 0f;
			}

			// Token: 0x04012750 RID: 75600
			[Token(Token = "0x4012750")]
			[FieldOffset(Offset = "0x10")]
			private bool m_blockState;

			// Token: 0x04012751 RID: 75601
			[Token(Token = "0x4012751")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_taskFinished;

			// Token: 0x04012752 RID: 75602
			[Token(Token = "0x4012752")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_maxTaskTime;

			// Token: 0x04012753 RID: 75603
			[Token(Token = "0x4012753")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_TryBlockSubStateOrNot;

			// Token: 0x04012754 RID: 75604
			[Token(Token = "0x4012754")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002772 RID: 10098
		[Token(Token = "0x2002772")]
		public class AutoChessTutorialManagerConfig
		{
			// Token: 0x06010795 RID: 67477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010795")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessTutorialManagerConfig()
			{
			}

			// Token: 0x04012755 RID: 75605
			[Token(Token = "0x4012755")]
			[FieldOffset(Offset = "0x10")]
			public List<int> bossRoundFocusMapBoundPos;

			// Token: 0x04012756 RID: 75606
			[Token(Token = "0x4012756")]
			[FieldOffset(Offset = "0x18")]
			public List<int> bossRoundFocusBossPos;
		}

		// Token: 0x02002773 RID: 10099
		[Token(Token = "0x2002773")]
		private struct AVGStateTutorialTriggerParam
		{
			// Token: 0x06010796 RID: 67478 RVA: 0x000645F0 File Offset: 0x000627F0
			[Token(Token = "0x6010796")]
			[Address(RVA = "0x83E340", Offset = "0x83CF40", VA = "0x18083E340")]
			public bool QualifyStateTutorial(AutoChessDataCenter center, AutoChessTutorialManager manager)
			{
				return default(bool);
			}

			// Token: 0x04012757 RID: 75607
			[Token(Token = "0x4012757")]
			[FieldOffset(Offset = "0x0")]
			public int roundNumber;

			// Token: 0x04012758 RID: 75608
			[Token(Token = "0x4012758")]
			[FieldOffset(Offset = "0x4")]
			public AutoChessGameStateType gameStateType;

			// Token: 0x04012759 RID: 75609
			[Token(Token = "0x4012759")]
			[FieldOffset(Offset = "0x8")]
			public AutoChessGameStatus.SubState gameSubStateType;

			// Token: 0x0401275A RID: 75610
			[Token(Token = "0x401275A")]
			[FieldOffset(Offset = "0xC")]
			public bool allowRepeat;

			// Token: 0x0401275B RID: 75611
			[Token(Token = "0x401275B")]
			[FieldOffset(Offset = "0x10")]
			public string avgTriggerKey;
		}

		// Token: 0x02002774 RID: 10100
		[Token(Token = "0x2002774")]
		private struct AVGStateTutorialTriggerParam_R2_BATTLE_END
		{
			// Token: 0x06010797 RID: 67479 RVA: 0x00064608 File Offset: 0x00062808
			[Token(Token = "0x6010797")]
			[Address(RVA = "0x83E430", Offset = "0x83D030", VA = "0x18083E430")]
			public bool QualifyStateTutorial(AutoChessDataCenter center, AutoChessTutorialManager manager)
			{
				return default(bool);
			}

			// Token: 0x0401275C RID: 75612
			[Token(Token = "0x401275C")]
			[FieldOffset(Offset = "0x0")]
			public int roundNumberHelpBattle;

			// Token: 0x0401275D RID: 75613
			[Token(Token = "0x401275D")]
			[FieldOffset(Offset = "0x4")]
			public int roundNumberSingleBattle;

			// Token: 0x0401275E RID: 75614
			[Token(Token = "0x401275E")]
			[FieldOffset(Offset = "0x8")]
			public AutoChessGameStateType gameStateType;

			// Token: 0x0401275F RID: 75615
			[Token(Token = "0x401275F")]
			[FieldOffset(Offset = "0xC")]
			public AutoChessGameStatus.SubState gameSubStateType;

			// Token: 0x04012760 RID: 75616
			[Token(Token = "0x4012760")]
			[FieldOffset(Offset = "0x10")]
			public bool allowRepeat;

			// Token: 0x04012761 RID: 75617
			[Token(Token = "0x4012761")]
			[FieldOffset(Offset = "0x18")]
			public string avgTriggerKey;
		}
	}
}
