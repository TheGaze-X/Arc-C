using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007838 RID: 30776
	[Token(Token = "0x2007838")]
	public class Act1VHalfIdleBattleFinishViewModel : IHotfixable
	{
		// Token: 0x170064F9 RID: 25849
		// (get) Token: 0x0602B294 RID: 176788 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B295 RID: 176789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064F9")]
		public string activityId
		{
			[Token(Token = "0x602B294")]
			[Address(RVA = "0x26F7AF0", Offset = "0x26F66F0", VA = "0x1826F7AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B295")]
			[Address(RVA = "0x26F8090", Offset = "0x26F6C90", VA = "0x1826F8090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170064FA RID: 25850
		// (get) Token: 0x0602B296 RID: 176790 RVA: 0x000DAFE8 File Offset: 0x000D91E8
		// (set) Token: 0x0602B297 RID: 176791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064FA")]
		public bool showIncomeView
		{
			[Token(Token = "0x602B296")]
			[Address(RVA = "0x26F7FB0", Offset = "0x26F6BB0", VA = "0x1826F7FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B297")]
			[Address(RVA = "0x26F85D0", Offset = "0x26F71D0", VA = "0x1826F85D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170064FB RID: 25851
		// (get) Token: 0x0602B298 RID: 176792 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B299 RID: 176793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064FB")]
		public string playerName
		{
			[Token(Token = "0x602B298")]
			[Address(RVA = "0x26F7E90", Offset = "0x26F6A90", VA = "0x1826F7E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B299")]
			[Address(RVA = "0x26F8450", Offset = "0x26F7050", VA = "0x1826F8450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170064FC RID: 25852
		// (get) Token: 0x0602B29A RID: 176794 RVA: 0x000DB000 File Offset: 0x000D9200
		// (set) Token: 0x0602B29B RID: 176795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064FC")]
		public DateTime finishTime
		{
			[Token(Token = "0x602B29A")]
			[Address(RVA = "0x26F7CB0", Offset = "0x26F68B0", VA = "0x1826F7CB0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x602B29B")]
			[Address(RVA = "0x26F8200", Offset = "0x26F6E00", VA = "0x1826F8200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170064FD RID: 25853
		// (get) Token: 0x0602B29C RID: 176796 RVA: 0x000DB018 File Offset: 0x000D9218
		// (set) Token: 0x0602B29D RID: 176797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064FD")]
		public CharUISkinStruct skinOfAnyChar
		{
			[Token(Token = "0x602B29C")]
			[Address(RVA = "0x26F8010", Offset = "0x26F6C10", VA = "0x1826F8010")]
			[CompilerGenerated]
			get
			{
				return default(CharUISkinStruct);
			}
			[Token(Token = "0x602B29D")]
			[Address(RVA = "0x26F8640", Offset = "0x26F7240", VA = "0x1826F8640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170064FE RID: 25854
		// (get) Token: 0x0602B29E RID: 176798 RVA: 0x000DB030 File Offset: 0x000D9230
		[Token(Token = "0x170064FE")]
		public PlayerActivity.PlayerAct1VHalfIdleActivity.BossState bossState
		{
			[Token(Token = "0x602B29E")]
			[Address(RVA = "0x26F7B50", Offset = "0x26F6750", VA = "0x1826F7B50")]
			get
			{
				return PlayerActivity.PlayerAct1VHalfIdleActivity.BossState.NO_APPEAR;
			}
		}

		// Token: 0x170064FF RID: 25855
		// (get) Token: 0x0602B29F RID: 176799 RVA: 0x000DB048 File Offset: 0x000D9248
		// (set) Token: 0x0602B2A0 RID: 176800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064FF")]
		public bool hasCharLevelUp
		{
			[Token(Token = "0x602B29F")]
			[Address(RVA = "0x26F7D10", Offset = "0x26F6910", VA = "0x1826F7D10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B2A0")]
			[Address(RVA = "0x26F8270", Offset = "0x26F6E70", VA = "0x1826F8270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006500 RID: 25856
		// (get) Token: 0x0602B2A1 RID: 176801 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B2A2 RID: 176802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006500")]
		public List<Act1VHalfIdleBattleFinishCharCardViewModel> charSquad
		{
			[Token(Token = "0x602B2A1")]
			[Address(RVA = "0x26F7BF0", Offset = "0x26F67F0", VA = "0x1826F7BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B2A2")]
			[Address(RVA = "0x26F8110", Offset = "0x26F6D10", VA = "0x1826F8110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006501 RID: 25857
		// (get) Token: 0x0602B2A3 RID: 176803 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B2A4 RID: 176804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006501")]
		public List<Act1VHalfIdleBattleFinishPlotCardViewModel> plotSquad
		{
			[Token(Token = "0x602B2A3")]
			[Address(RVA = "0x26F7EF0", Offset = "0x26F6AF0", VA = "0x1826F7EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B2A4")]
			[Address(RVA = "0x26F84D0", Offset = "0x26F70D0", VA = "0x1826F84D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006502 RID: 25858
		// (get) Token: 0x0602B2A5 RID: 176805 RVA: 0x000DB060 File Offset: 0x000D9260
		// (set) Token: 0x0602B2A6 RID: 176806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006502")]
		public bool hasStageUnlock
		{
			[Token(Token = "0x602B2A5")]
			[Address(RVA = "0x26F7D70", Offset = "0x26F6970", VA = "0x1826F7D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B2A6")]
			[Address(RVA = "0x26F82E0", Offset = "0x26F6EE0", VA = "0x1826F82E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006503 RID: 25859
		// (get) Token: 0x0602B2A7 RID: 176807 RVA: 0x000DB078 File Offset: 0x000D9278
		// (set) Token: 0x0602B2A8 RID: 176808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006503")]
		public CharWordShowType charWordType
		{
			[Token(Token = "0x602B2A7")]
			[Address(RVA = "0x26F7C50", Offset = "0x26F6850", VA = "0x1826F7C50")]
			[CompilerGenerated]
			get
			{
				return CharWordShowType.HOME_SHOW;
			}
			[Token(Token = "0x602B2A8")]
			[Address(RVA = "0x26F8190", Offset = "0x26F6D90", VA = "0x1826F8190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006504 RID: 25860
		// (get) Token: 0x0602B2A9 RID: 176809 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B2AA RID: 176810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006504")]
		public string milestoneItemId
		{
			[Token(Token = "0x602B2A9")]
			[Address(RVA = "0x26F7DD0", Offset = "0x26F69D0", VA = "0x1826F7DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B2AA")]
			[Address(RVA = "0x26F8350", Offset = "0x26F6F50", VA = "0x1826F8350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006505 RID: 25861
		// (get) Token: 0x0602B2AB RID: 176811 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B2AC RID: 176812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006505")]
		public Act1VHalfIdleMilestoneSnapshot milestoneSnap
		{
			[Token(Token = "0x602B2AB")]
			[Address(RVA = "0x26F7E30", Offset = "0x26F6A30", VA = "0x1826F7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B2AC")]
			[Address(RVA = "0x26F83D0", Offset = "0x26F6FD0", VA = "0x1826F83D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006506 RID: 25862
		// (get) Token: 0x0602B2AD RID: 176813 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B2AE RID: 176814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006506")]
		public List<Act1VHalfIdleStuffDepotItemViewModel> rewardItems
		{
			[Token(Token = "0x602B2AD")]
			[Address(RVA = "0x26F7F50", Offset = "0x26F6B50", VA = "0x1826F7F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B2AE")]
			[Address(RVA = "0x26F8550", Offset = "0x26F7150", VA = "0x1826F8550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602B2AF RID: 176815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2AF")]
		[Address(RVA = "0x26F5EB0", Offset = "0x26F4AB0", VA = "0x1826F5EB0")]
		public void LoadData()
		{
		}

		// Token: 0x0602B2B0 RID: 176816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2B0")]
		[Address(RVA = "0x26F71D0", Offset = "0x26F5DD0", VA = "0x1826F71D0")]
		private void _LoadPlotSquad(string actid, Act1VHalfIdleData actGameData, BattleInOut.InParams inParams, Act1VHalfIdleBattleFinishResponse resp)
		{
		}

		// Token: 0x0602B2B1 RID: 176817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2B1")]
		[Address(RVA = "0x26F6AC0", Offset = "0x26F56C0", VA = "0x1826F6AC0")]
		private void _LoadCharSquad(string activityId, BattleInOut.InParams inParams, Act1VHalfIdleBattleFinishResponse resp)
		{
		}

		// Token: 0x0602B2B2 RID: 176818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2B2")]
		[Address(RVA = "0x26F7690", Offset = "0x26F6290", VA = "0x1826F7690")]
		private void _LoadRewardItems(Act1VHalfIdleBattleFinishResponse resp)
		{
		}

		// Token: 0x0602B2B3 RID: 176819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2B3")]
		[Address(RVA = "0x26F5D70", Offset = "0x26F4970", VA = "0x1826F5D70")]
		public void DoneIncome()
		{
		}

		// Token: 0x0602B2B4 RID: 176820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2B4")]
		[Address(RVA = "0x26F5E10", Offset = "0x26F4A10", VA = "0x1826F5E10")]
		public void DoneUnlockStageToast()
		{
		}

		// Token: 0x0602B2B5 RID: 176821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2B5")]
		[Address(RVA = "0x26F79F0", Offset = "0x26F65F0", VA = "0x1826F79F0")]
		public Act1VHalfIdleBattleFinishViewModel()
		{
		}

		// Token: 0x0403E646 RID: 255558
		[Token(Token = "0x403E646")]
		[FieldOffset(Offset = "0x20")]
		public Act1VHalfIdleBattleFinishIncomeViewModel incomeViewModel;

		// Token: 0x0403E652 RID: 255570
		[Token(Token = "0x403E652")]
		[FieldOffset(Offset = "0x88")]
		private HashSet<string> m_cachedHardStageIdSet;

		// Token: 0x0403E653 RID: 255571
		[Token(Token = "0x403E653")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403E654 RID: 255572
		[Token(Token = "0x403E654")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x0403E655 RID: 255573
		[Token(Token = "0x403E655")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showIncomeView;

		// Token: 0x0403E656 RID: 255574
		[Token(Token = "0x403E656")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_showIncomeView;

		// Token: 0x0403E657 RID: 255575
		[Token(Token = "0x403E657")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_playerName;

		// Token: 0x0403E658 RID: 255576
		[Token(Token = "0x403E658")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_playerName;

		// Token: 0x0403E659 RID: 255577
		[Token(Token = "0x403E659")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_finishTime;

		// Token: 0x0403E65A RID: 255578
		[Token(Token = "0x403E65A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_finishTime;

		// Token: 0x0403E65B RID: 255579
		[Token(Token = "0x403E65B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_skinOfAnyChar;

		// Token: 0x0403E65C RID: 255580
		[Token(Token = "0x403E65C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_skinOfAnyChar;

		// Token: 0x0403E65D RID: 255581
		[Token(Token = "0x403E65D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_bossState;

		// Token: 0x0403E65E RID: 255582
		[Token(Token = "0x403E65E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_hasCharLevelUp;

		// Token: 0x0403E65F RID: 255583
		[Token(Token = "0x403E65F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_hasCharLevelUp;

		// Token: 0x0403E660 RID: 255584
		[Token(Token = "0x403E660")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_charSquad;

		// Token: 0x0403E661 RID: 255585
		[Token(Token = "0x403E661")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_charSquad;

		// Token: 0x0403E662 RID: 255586
		[Token(Token = "0x403E662")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_plotSquad;

		// Token: 0x0403E663 RID: 255587
		[Token(Token = "0x403E663")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_plotSquad;

		// Token: 0x0403E664 RID: 255588
		[Token(Token = "0x403E664")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_hasStageUnlock;

		// Token: 0x0403E665 RID: 255589
		[Token(Token = "0x403E665")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_hasStageUnlock;

		// Token: 0x0403E666 RID: 255590
		[Token(Token = "0x403E666")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_charWordType;

		// Token: 0x0403E667 RID: 255591
		[Token(Token = "0x403E667")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_charWordType;

		// Token: 0x0403E668 RID: 255592
		[Token(Token = "0x403E668")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_milestoneItemId;

		// Token: 0x0403E669 RID: 255593
		[Token(Token = "0x403E669")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_milestoneItemId;

		// Token: 0x0403E66A RID: 255594
		[Token(Token = "0x403E66A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_milestoneSnap;

		// Token: 0x0403E66B RID: 255595
		[Token(Token = "0x403E66B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_milestoneSnap;

		// Token: 0x0403E66C RID: 255596
		[Token(Token = "0x403E66C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_rewardItems;

		// Token: 0x0403E66D RID: 255597
		[Token(Token = "0x403E66D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_rewardItems;

		// Token: 0x0403E66E RID: 255598
		[Token(Token = "0x403E66E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403E66F RID: 255599
		[Token(Token = "0x403E66F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__LoadPlotSquad;

		// Token: 0x0403E670 RID: 255600
		[Token(Token = "0x403E670")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__LoadCharSquad;

		// Token: 0x0403E671 RID: 255601
		[Token(Token = "0x403E671")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__LoadRewardItems;

		// Token: 0x0403E672 RID: 255602
		[Token(Token = "0x403E672")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_DoneIncome;

		// Token: 0x0403E673 RID: 255603
		[Token(Token = "0x403E673")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_DoneUnlockStageToast;

		// Token: 0x0403E674 RID: 255604
		[Token(Token = "0x403E674")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
