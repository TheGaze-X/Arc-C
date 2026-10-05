using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007607 RID: 30215
	[Token(Token = "0x2007607")]
	public class Act24sideQuestStageItemModel : IHotfixable
	{
		// Token: 0x17006405 RID: 25605
		// (get) Token: 0x0602A89F RID: 174239 RVA: 0x000D8DC8 File Offset: 0x000D6FC8
		[Token(Token = "0x17006405")]
		public bool isUrgent
		{
			[Token(Token = "0x602A89F")]
			[Address(RVA = "0x265FBD0", Offset = "0x265E7D0", VA = "0x18265FBD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006406 RID: 25606
		// (get) Token: 0x0602A8A0 RID: 174240 RVA: 0x000D8DE0 File Offset: 0x000D6FE0
		// (set) Token: 0x0602A8A1 RID: 174241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006406")]
		public bool isMultiBattle
		{
			[Token(Token = "0x602A8A0")]
			[Address(RVA = "0x265FB00", Offset = "0x265E700", VA = "0x18265FB00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602A8A1")]
			[Address(RVA = "0x265FFF0", Offset = "0x265EBF0", VA = "0x18265FFF0")]
			set
			{
			}
		}

		// Token: 0x17006407 RID: 25607
		// (get) Token: 0x0602A8A2 RID: 174242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006407")]
		public string actId
		{
			[Token(Token = "0x602A8A2")]
			[Address(RVA = "0x265F710", Offset = "0x265E310", VA = "0x18265F710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006408 RID: 25608
		// (get) Token: 0x0602A8A3 RID: 174243 RVA: 0x000D8DF8 File Offset: 0x000D6FF8
		// (set) Token: 0x0602A8A4 RID: 174244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006408")]
		public int multipleBattleTimes
		{
			[Token(Token = "0x602A8A3")]
			[Address(RVA = "0x265FCA0", Offset = "0x265E8A0", VA = "0x18265FCA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x602A8A4")]
			[Address(RVA = "0x2660060", Offset = "0x265EC60", VA = "0x182660060")]
			set
			{
			}
		}

		// Token: 0x17006409 RID: 25609
		// (get) Token: 0x0602A8A5 RID: 174245 RVA: 0x000D8E10 File Offset: 0x000D7010
		[Token(Token = "0x17006409")]
		public int completeRankCount
		{
			[Token(Token = "0x602A8A5")]
			[Address(RVA = "0x265F7E0", Offset = "0x265E3E0", VA = "0x18265F7E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700640A RID: 25610
		// (get) Token: 0x0602A8A6 RID: 174246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700640A")]
		public StageData stageData
		{
			[Token(Token = "0x602A8A6")]
			[Address(RVA = "0x265FDB0", Offset = "0x265E9B0", VA = "0x18265FDB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700640B RID: 25611
		// (get) Token: 0x0602A8A7 RID: 174247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700640B")]
		public string stageId
		{
			[Token(Token = "0x602A8A7")]
			[Address(RVA = "0x265FEA0", Offset = "0x265EAA0", VA = "0x18265FEA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700640C RID: 25612
		// (get) Token: 0x0602A8A8 RID: 174248 RVA: 0x000D8E28 File Offset: 0x000D7028
		[Token(Token = "0x1700640C")]
		public int sortId
		{
			[Token(Token = "0x602A8A8")]
			[Address(RVA = "0x265FD40", Offset = "0x265E940", VA = "0x18265FD40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700640D RID: 25613
		// (get) Token: 0x0602A8A9 RID: 174249 RVA: 0x000D8E40 File Offset: 0x000D7040
		[Token(Token = "0x1700640D")]
		public bool isHardStage
		{
			[Token(Token = "0x602A8A9")]
			[Address(RVA = "0x265FA90", Offset = "0x265E690", VA = "0x18265FA90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700640E RID: 25614
		// (get) Token: 0x0602A8AA RID: 174250 RVA: 0x000D8E58 File Offset: 0x000D7058
		[Token(Token = "0x1700640E")]
		public bool isDragonStage
		{
			[Token(Token = "0x602A8AA")]
			[Address(RVA = "0x265FA20", Offset = "0x265E620", VA = "0x18265FA20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700640F RID: 25615
		// (get) Token: 0x0602A8AB RID: 174251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700640F")]
		public string stageName
		{
			[Token(Token = "0x602A8AB")]
			[Address(RVA = "0x265FF10", Offset = "0x265EB10", VA = "0x18265FF10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006410 RID: 25616
		// (get) Token: 0x0602A8AC RID: 174252 RVA: 0x000D8E70 File Offset: 0x000D7070
		[Token(Token = "0x17006410")]
		public int apCost
		{
			[Token(Token = "0x602A8AC")]
			[Address(RVA = "0x265F770", Offset = "0x265E370", VA = "0x18265F770")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006411 RID: 25617
		// (get) Token: 0x0602A8AD RID: 174253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006411")]
		public string stageDesc
		{
			[Token(Token = "0x602A8AD")]
			[Address(RVA = "0x265FE10", Offset = "0x265EA10", VA = "0x18265FE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006412 RID: 25618
		// (get) Token: 0x0602A8AE RID: 174254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006412")]
		public string dangerLv
		{
			[Token(Token = "0x602A8AE")]
			[Address(RVA = "0x265F900", Offset = "0x265E500", VA = "0x18265F900")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006413 RID: 25619
		// (get) Token: 0x0602A8AF RID: 174255 RVA: 0x000D8E88 File Offset: 0x000D7088
		[Token(Token = "0x17006413")]
		public bool isStageComplete
		{
			[Token(Token = "0x602A8AF")]
			[Address(RVA = "0x265FB60", Offset = "0x265E760", VA = "0x18265FB60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006414 RID: 25620
		// (get) Token: 0x0602A8B0 RID: 174256 RVA: 0x000D8EA0 File Offset: 0x000D70A0
		[Token(Token = "0x17006414")]
		public bool isAutoPlayUnlocked
		{
			[Token(Token = "0x602A8B0")]
			[Address(RVA = "0x265F990", Offset = "0x265E590", VA = "0x18265F990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006415 RID: 25621
		// (get) Token: 0x0602A8B1 RID: 174257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006415")]
		public List<Act24sideMeldingSmallItemViewModel> meldingDropList
		{
			[Token(Token = "0x602A8B1")]
			[Address(RVA = "0x265FC40", Offset = "0x265E840", VA = "0x18265FC40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006416 RID: 25622
		// (get) Token: 0x0602A8B2 RID: 174258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006416")]
		public StageRewardViewModel completeRewardModel
		{
			[Token(Token = "0x602A8B2")]
			[Address(RVA = "0x265F8A0", Offset = "0x265E4A0", VA = "0x18265F8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A8B3 RID: 174259 RVA: 0x000D8EB8 File Offset: 0x000D70B8
		[Token(Token = "0x602A8B3")]
		[Address(RVA = "0x265F0E0", Offset = "0x265DCE0", VA = "0x18265F0E0")]
		public int GetTotalRankCount(bool displayWhenUnlocked)
		{
			return 0;
		}

		// Token: 0x0602A8B4 RID: 174260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8B4")]
		[Address(RVA = "0x265F190", Offset = "0x265DD90", VA = "0x18265F190")]
		public void LoadData(string actId, QuestStageData questStageData, StageData stageData, PlayerStage playerStageData)
		{
		}

		// Token: 0x0602A8B5 RID: 174261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8B5")]
		[Address(RVA = "0x265F4A0", Offset = "0x265E0A0", VA = "0x18265F4A0")]
		private void _FetchCompleteReward()
		{
		}

		// Token: 0x0602A8B6 RID: 174262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8B6")]
		[Address(RVA = "0x265F650", Offset = "0x265E250", VA = "0x18265F650")]
		public Act24sideQuestStageItemModel()
		{
		}

		// Token: 0x0403D3D1 RID: 250833
		[Token(Token = "0x403D3D1")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403D3D2 RID: 250834
		[Token(Token = "0x403D3D2")]
		[FieldOffset(Offset = "0x18")]
		private QuestStageData m_questData;

		// Token: 0x0403D3D3 RID: 250835
		[Token(Token = "0x403D3D3")]
		[FieldOffset(Offset = "0x20")]
		private StageData m_stageData;

		// Token: 0x0403D3D4 RID: 250836
		[Token(Token = "0x403D3D4")]
		[FieldOffset(Offset = "0x28")]
		private PlayerStage m_playerStageData;

		// Token: 0x0403D3D5 RID: 250837
		[Token(Token = "0x403D3D5")]
		[FieldOffset(Offset = "0x30")]
		private StageRewardViewModel m_completeReward;

		// Token: 0x0403D3D6 RID: 250838
		[Token(Token = "0x403D3D6")]
		[FieldOffset(Offset = "0x38")]
		private List<Act24sideMeldingSmallItemViewModel> m_meldingDropItemList;

		// Token: 0x0403D3D7 RID: 250839
		[Token(Token = "0x403D3D7")]
		[FieldOffset(Offset = "0x40")]
		private int m_multipleBattleTimes;

		// Token: 0x0403D3D8 RID: 250840
		[Token(Token = "0x403D3D8")]
		[FieldOffset(Offset = "0x44")]
		private bool m_cachedLaunchMultiBattle;

		// Token: 0x0403D3D9 RID: 250841
		[Token(Token = "0x403D3D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUrgent;

		// Token: 0x0403D3DA RID: 250842
		[Token(Token = "0x403D3DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isMultiBattle;

		// Token: 0x0403D3DB RID: 250843
		[Token(Token = "0x403D3DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isMultiBattle;

		// Token: 0x0403D3DC RID: 250844
		[Token(Token = "0x403D3DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403D3DD RID: 250845
		[Token(Token = "0x403D3DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_multipleBattleTimes;

		// Token: 0x0403D3DE RID: 250846
		[Token(Token = "0x403D3DE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_multipleBattleTimes;

		// Token: 0x0403D3DF RID: 250847
		[Token(Token = "0x403D3DF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_completeRankCount;

		// Token: 0x0403D3E0 RID: 250848
		[Token(Token = "0x403D3E0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_stageData;

		// Token: 0x0403D3E1 RID: 250849
		[Token(Token = "0x403D3E1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403D3E2 RID: 250850
		[Token(Token = "0x403D3E2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0403D3E3 RID: 250851
		[Token(Token = "0x403D3E3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isHardStage;

		// Token: 0x0403D3E4 RID: 250852
		[Token(Token = "0x403D3E4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isDragonStage;

		// Token: 0x0403D3E5 RID: 250853
		[Token(Token = "0x403D3E5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_stageName;

		// Token: 0x0403D3E6 RID: 250854
		[Token(Token = "0x403D3E6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_apCost;

		// Token: 0x0403D3E7 RID: 250855
		[Token(Token = "0x403D3E7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_stageDesc;

		// Token: 0x0403D3E8 RID: 250856
		[Token(Token = "0x403D3E8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_dangerLv;

		// Token: 0x0403D3E9 RID: 250857
		[Token(Token = "0x403D3E9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isStageComplete;

		// Token: 0x0403D3EA RID: 250858
		[Token(Token = "0x403D3EA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isAutoPlayUnlocked;

		// Token: 0x0403D3EB RID: 250859
		[Token(Token = "0x403D3EB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_meldingDropList;

		// Token: 0x0403D3EC RID: 250860
		[Token(Token = "0x403D3EC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_completeRewardModel;

		// Token: 0x0403D3ED RID: 250861
		[Token(Token = "0x403D3ED")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetTotalRankCount;

		// Token: 0x0403D3EE RID: 250862
		[Token(Token = "0x403D3EE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D3EF RID: 250863
		[Token(Token = "0x403D3EF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__FetchCompleteReward;

		// Token: 0x0403D3F0 RID: 250864
		[Token(Token = "0x403D3F0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
