using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI.BattleFinish;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006160 RID: 24928
	[Token(Token = "0x2006160")]
	public class BossRushBattleFinishViewModel : IHotfixable
	{
		// Token: 0x170054E3 RID: 21731
		// (get) Token: 0x06023FB5 RID: 147381 RVA: 0x000C2958 File Offset: 0x000C0B58
		[Token(Token = "0x170054E3")]
		public BattleFinishIllust illust
		{
			[Token(Token = "0x6023FB5")]
			[Address(RVA = "0x1EA07E0", Offset = "0x1E9F3E0", VA = "0x181EA07E0")]
			get
			{
				return default(BattleFinishIllust);
			}
		}

		// Token: 0x170054E4 RID: 21732
		// (get) Token: 0x06023FB6 RID: 147382 RVA: 0x000C2970 File Offset: 0x000C0B70
		[Token(Token = "0x170054E4")]
		public int completedWave
		{
			[Token(Token = "0x6023FB6")]
			[Address(RVA = "0x1EA05B0", Offset = "0x1E9F1B0", VA = "0x181EA05B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170054E5 RID: 21733
		// (get) Token: 0x06023FB7 RID: 147383 RVA: 0x000C2988 File Offset: 0x000C0B88
		[Token(Token = "0x170054E5")]
		public int totalWave
		{
			[Token(Token = "0x6023FB7")]
			[Address(RVA = "0x1EA0C70", Offset = "0x1E9F870", VA = "0x181EA0C70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170054E6 RID: 21734
		// (get) Token: 0x06023FB8 RID: 147384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054E6")]
		public BattleInfoViewModel battleInfoModel
		{
			[Token(Token = "0x6023FB8")]
			[Address(RVA = "0x1EA04F0", Offset = "0x1E9F0F0", VA = "0x181EA04F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054E7 RID: 21735
		// (get) Token: 0x06023FB9 RID: 147385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054E7")]
		public string statusDes
		{
			[Token(Token = "0x6023FB9")]
			[Address(RVA = "0x1EA0AB0", Offset = "0x1E9F6B0", VA = "0x181EA0AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054E8 RID: 21736
		// (get) Token: 0x06023FBA RID: 147386 RVA: 0x000C29A0 File Offset: 0x000C0BA0
		[Token(Token = "0x170054E8")]
		public int currentExp
		{
			[Token(Token = "0x6023FBA")]
			[Address(RVA = "0x1EA0610", Offset = "0x1E9F210", VA = "0x181EA0610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170054E9 RID: 21737
		// (get) Token: 0x06023FBB RID: 147387 RVA: 0x000C29B8 File Offset: 0x000C0BB8
		[Token(Token = "0x170054E9")]
		public int totalExp
		{
			[Token(Token = "0x6023FBB")]
			[Address(RVA = "0x1EA0C10", Offset = "0x1E9F810", VA = "0x181EA0C10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170054EA RID: 21738
		// (get) Token: 0x06023FBC RID: 147388 RVA: 0x000C29D0 File Offset: 0x000C0BD0
		[Token(Token = "0x170054EA")]
		public int milestoneLv
		{
			[Token(Token = "0x6023FBC")]
			[Address(RVA = "0x1EA0A50", Offset = "0x1E9F650", VA = "0x181EA0A50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170054EB RID: 21739
		// (get) Token: 0x06023FBD RID: 147389 RVA: 0x000C29E8 File Offset: 0x000C0BE8
		[Token(Token = "0x170054EB")]
		public float expProgress
		{
			[Token(Token = "0x6023FBD")]
			[Address(RVA = "0x1EA0670", Offset = "0x1E9F270", VA = "0x181EA0670")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170054EC RID: 21740
		// (get) Token: 0x06023FBE RID: 147390 RVA: 0x000C2A00 File Offset: 0x000C0C00
		[Token(Token = "0x170054EC")]
		public int milestoneCount
		{
			[Token(Token = "0x6023FBE")]
			[Address(RVA = "0x1EA0990", Offset = "0x1E9F590", VA = "0x181EA0990")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170054ED RID: 21741
		// (get) Token: 0x06023FBF RID: 147391 RVA: 0x000C2A18 File Offset: 0x000C0C18
		[Token(Token = "0x170054ED")]
		public int firstPassMilestoneCount
		{
			[Token(Token = "0x6023FBF")]
			[Address(RVA = "0x1EA0720", Offset = "0x1E9F320", VA = "0x181EA0720")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170054EE RID: 21742
		// (get) Token: 0x06023FC0 RID: 147392 RVA: 0x000C2A30 File Offset: 0x000C0C30
		[Token(Token = "0x170054EE")]
		public int tokenCount
		{
			[Token(Token = "0x6023FC0")]
			[Address(RVA = "0x1EA0B50", Offset = "0x1E9F750", VA = "0x181EA0B50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170054EF RID: 21743
		// (get) Token: 0x06023FC1 RID: 147393 RVA: 0x000C2A48 File Offset: 0x000C0C48
		[Token(Token = "0x170054EF")]
		public int firstPassTokenCount
		{
			[Token(Token = "0x6023FC1")]
			[Address(RVA = "0x1EA0780", Offset = "0x1E9F380", VA = "0x181EA0780")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170054F0 RID: 21744
		// (get) Token: 0x06023FC2 RID: 147394 RVA: 0x000C2A60 File Offset: 0x000C0C60
		[Token(Token = "0x170054F0")]
		public bool isMilestoneLevelUp
		{
			[Token(Token = "0x6023FC2")]
			[Address(RVA = "0x1EA0870", Offset = "0x1E9F470", VA = "0x181EA0870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170054F1 RID: 21745
		// (get) Token: 0x06023FC3 RID: 147395 RVA: 0x000C2A78 File Offset: 0x000C0C78
		[Token(Token = "0x170054F1")]
		public bool isMilestoneMax
		{
			[Token(Token = "0x6023FC3")]
			[Address(RVA = "0x1EA08D0", Offset = "0x1E9F4D0", VA = "0x181EA08D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170054F2 RID: 21746
		// (get) Token: 0x06023FC4 RID: 147396 RVA: 0x000C2A90 File Offset: 0x000C0C90
		[Token(Token = "0x170054F2")]
		public bool isTokenMax
		{
			[Token(Token = "0x6023FC4")]
			[Address(RVA = "0x1EA0930", Offset = "0x1E9F530", VA = "0x181EA0930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170054F3 RID: 21747
		// (get) Token: 0x06023FC5 RID: 147397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054F3")]
		public string milestoneId
		{
			[Token(Token = "0x6023FC5")]
			[Address(RVA = "0x1EA09F0", Offset = "0x1E9F5F0", VA = "0x181EA09F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054F4 RID: 21748
		// (get) Token: 0x06023FC6 RID: 147398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054F4")]
		public string tokenId
		{
			[Token(Token = "0x6023FC6")]
			[Address(RVA = "0x1EA0BB0", Offset = "0x1E9F7B0", VA = "0x181EA0BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054F5 RID: 21749
		// (get) Token: 0x06023FC7 RID: 147399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054F5")]
		public List<BossRushBattleFinishViewModel.StageInfo> unlockStageInfoList
		{
			[Token(Token = "0x6023FC7")]
			[Address(RVA = "0x1EA0CD0", Offset = "0x1E9F8D0", VA = "0x181EA0CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054F6 RID: 21750
		// (get) Token: 0x06023FC8 RID: 147400 RVA: 0x000C2AA8 File Offset: 0x000C0CA8
		[Token(Token = "0x170054F6")]
		public ActivityBossRushData.BossRushStageType bossRushStageType
		{
			[Token(Token = "0x6023FC8")]
			[Address(RVA = "0x1EA0550", Offset = "0x1E9F150", VA = "0x181EA0550")]
			get
			{
				return ActivityBossRushData.BossRushStageType.NONE;
			}
		}

		// Token: 0x06023FC9 RID: 147401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FC9")]
		[Address(RVA = "0x1E9F440", Offset = "0x1E9E040", VA = "0x181E9F440")]
		public void LoadData()
		{
		}

		// Token: 0x06023FCA RID: 147402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FCA")]
		[Address(RVA = "0x1EA0150", Offset = "0x1E9ED50", VA = "0x181EA0150")]
		private void _LoadNewStageInfo(ActivityBossRushData actData, string[] unlockStages)
		{
		}

		// Token: 0x06023FCB RID: 147403 RVA: 0x000C2AC0 File Offset: 0x000C0CC0
		[Token(Token = "0x6023FCB")]
		[Address(RVA = "0x1E9FE10", Offset = "0x1E9EA10", VA = "0x181E9FE10")]
		private int _GetTotalWave(ActivityBossRushData bossRushData, string stageId)
		{
			return 0;
		}

		// Token: 0x06023FCC RID: 147404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FCC")]
		[Address(RVA = "0x1E9FF60", Offset = "0x1E9EB60", VA = "0x181E9FF60")]
		private BattleInfoViewModel _LoadBattleInfo(string stageId)
		{
			return null;
		}

		// Token: 0x06023FCD RID: 147405 RVA: 0x000C2AD8 File Offset: 0x000C0CD8
		[Token(Token = "0x6023FCD")]
		[Address(RVA = "0x1EA03C0", Offset = "0x1E9EFC0", VA = "0x181EA03C0")]
		private ActivityBossRushData.BossRushStageType _LoadStageType(ActivityBossRushData actData)
		{
			return ActivityBossRushData.BossRushStageType.NONE;
		}

		// Token: 0x06023FCE RID: 147406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FCE")]
		[Address(RVA = "0x1EA0490", Offset = "0x1E9F090", VA = "0x181EA0490")]
		public BossRushBattleFinishViewModel()
		{
		}

		// Token: 0x04031FB3 RID: 204723
		[Token(Token = "0x4031FB3")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x04031FB4 RID: 204724
		[Token(Token = "0x4031FB4")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x04031FB5 RID: 204725
		[Token(Token = "0x4031FB5")]
		[FieldOffset(Offset = "0x20")]
		private BattleFinishIllust m_illust;

		// Token: 0x04031FB6 RID: 204726
		[Token(Token = "0x4031FB6")]
		[FieldOffset(Offset = "0x48")]
		private int m_completedWave;

		// Token: 0x04031FB7 RID: 204727
		[Token(Token = "0x4031FB7")]
		[FieldOffset(Offset = "0x4C")]
		private int m_totalWave;

		// Token: 0x04031FB8 RID: 204728
		[Token(Token = "0x4031FB8")]
		[FieldOffset(Offset = "0x50")]
		private BattleInfoViewModel m_battleInfoModel;

		// Token: 0x04031FB9 RID: 204729
		[Token(Token = "0x4031FB9")]
		[FieldOffset(Offset = "0x58")]
		private MilestoneStruct m_milestoneStruct;

		// Token: 0x04031FBA RID: 204730
		[Token(Token = "0x4031FBA")]
		[FieldOffset(Offset = "0x68")]
		private int m_firstPassMilestoneCount;

		// Token: 0x04031FBB RID: 204731
		[Token(Token = "0x4031FBB")]
		[FieldOffset(Offset = "0x6C")]
		private int m_firstPassTokenCount;

		// Token: 0x04031FBC RID: 204732
		[Token(Token = "0x4031FBC")]
		[FieldOffset(Offset = "0x70")]
		private int m_milestoneCount;

		// Token: 0x04031FBD RID: 204733
		[Token(Token = "0x4031FBD")]
		[FieldOffset(Offset = "0x74")]
		private int m_tokenCount;

		// Token: 0x04031FBE RID: 204734
		[Token(Token = "0x4031FBE")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isMilestoneLevelUp;

		// Token: 0x04031FBF RID: 204735
		[Token(Token = "0x4031FBF")]
		[FieldOffset(Offset = "0x79")]
		private bool m_isMilestoneMax;

		// Token: 0x04031FC0 RID: 204736
		[Token(Token = "0x4031FC0")]
		[FieldOffset(Offset = "0x7A")]
		private bool m_isTokenMax;

		// Token: 0x04031FC1 RID: 204737
		[Token(Token = "0x4031FC1")]
		[FieldOffset(Offset = "0x80")]
		private string m_milestoneItemId;

		// Token: 0x04031FC2 RID: 204738
		[Token(Token = "0x4031FC2")]
		[FieldOffset(Offset = "0x88")]
		private string m_tokenItemId;

		// Token: 0x04031FC3 RID: 204739
		[Token(Token = "0x4031FC3")]
		[FieldOffset(Offset = "0x90")]
		private ActivityBossRushData.BossRushStageType m_bossRushStageType;

		// Token: 0x04031FC4 RID: 204740
		[Token(Token = "0x4031FC4")]
		[FieldOffset(Offset = "0x98")]
		private List<BossRushBattleFinishViewModel.StageInfo> m_stageInfoList;

		// Token: 0x04031FC5 RID: 204741
		[Token(Token = "0x4031FC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_illust;

		// Token: 0x04031FC6 RID: 204742
		[Token(Token = "0x4031FC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_completedWave;

		// Token: 0x04031FC7 RID: 204743
		[Token(Token = "0x4031FC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_totalWave;

		// Token: 0x04031FC8 RID: 204744
		[Token(Token = "0x4031FC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_battleInfoModel;

		// Token: 0x04031FC9 RID: 204745
		[Token(Token = "0x4031FC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_statusDes;

		// Token: 0x04031FCA RID: 204746
		[Token(Token = "0x4031FCA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currentExp;

		// Token: 0x04031FCB RID: 204747
		[Token(Token = "0x4031FCB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_totalExp;

		// Token: 0x04031FCC RID: 204748
		[Token(Token = "0x4031FCC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_milestoneLv;

		// Token: 0x04031FCD RID: 204749
		[Token(Token = "0x4031FCD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_expProgress;

		// Token: 0x04031FCE RID: 204750
		[Token(Token = "0x4031FCE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_milestoneCount;

		// Token: 0x04031FCF RID: 204751
		[Token(Token = "0x4031FCF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_firstPassMilestoneCount;

		// Token: 0x04031FD0 RID: 204752
		[Token(Token = "0x4031FD0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_tokenCount;

		// Token: 0x04031FD1 RID: 204753
		[Token(Token = "0x4031FD1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_firstPassTokenCount;

		// Token: 0x04031FD2 RID: 204754
		[Token(Token = "0x4031FD2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isMilestoneLevelUp;

		// Token: 0x04031FD3 RID: 204755
		[Token(Token = "0x4031FD3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_isMilestoneMax;

		// Token: 0x04031FD4 RID: 204756
		[Token(Token = "0x4031FD4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isTokenMax;

		// Token: 0x04031FD5 RID: 204757
		[Token(Token = "0x4031FD5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_milestoneId;

		// Token: 0x04031FD6 RID: 204758
		[Token(Token = "0x4031FD6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_tokenId;

		// Token: 0x04031FD7 RID: 204759
		[Token(Token = "0x4031FD7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_unlockStageInfoList;

		// Token: 0x04031FD8 RID: 204760
		[Token(Token = "0x4031FD8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_bossRushStageType;

		// Token: 0x04031FD9 RID: 204761
		[Token(Token = "0x4031FD9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031FDA RID: 204762
		[Token(Token = "0x4031FDA")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__LoadNewStageInfo;

		// Token: 0x04031FDB RID: 204763
		[Token(Token = "0x4031FDB")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetTotalWave;

		// Token: 0x04031FDC RID: 204764
		[Token(Token = "0x4031FDC")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__LoadBattleInfo;

		// Token: 0x04031FDD RID: 204765
		[Token(Token = "0x4031FDD")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__LoadStageType;

		// Token: 0x04031FDE RID: 204766
		[Token(Token = "0x4031FDE")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006161 RID: 24929
		[Token(Token = "0x2006161")]
		public struct StageInfo
		{
			// Token: 0x04031FDF RID: 204767
			[Token(Token = "0x4031FDF")]
			[FieldOffset(Offset = "0x0")]
			public string stageCode;

			// Token: 0x04031FE0 RID: 204768
			[Token(Token = "0x4031FE0")]
			[FieldOffset(Offset = "0x8")]
			public string stageTypeName;
		}
	}
}
