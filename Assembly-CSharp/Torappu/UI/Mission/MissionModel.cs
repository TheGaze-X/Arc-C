using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004871 RID: 18545
	[Token(Token = "0x2004871")]
	public class MissionModel : PageSingleComponent, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0601C01A RID: 114714 RVA: 0x000A6DE8 File Offset: 0x000A4FE8
		[Token(Token = "0x601C01A")]
		[Address(RVA = "0x1559070", Offset = "0x1557C70", VA = "0x181559070")]
		private bool _TryGetCurrStartMissionGroup(out MissionGroup missionGroupData)
		{
			return default(bool);
		}

		// Token: 0x0601C01B RID: 114715 RVA: 0x000A6E00 File Offset: 0x000A5000
		[Token(Token = "0x601C01B")]
		[Address(RVA = "0x1558390", Offset = "0x1556F90", VA = "0x181558390")]
		public bool TryGetCurrStartMissionGroup(out MissionGroup missionGruopData)
		{
			return default(bool);
		}

		// Token: 0x0601C01C RID: 114716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C01C")]
		[Address(RVA = "0x1557140", Offset = "0x1555D40", VA = "0x181557140")]
		public GuideMissionGroupInfo GetCurrGuideMissionGroupInfo()
		{
			return null;
		}

		// Token: 0x0601C01D RID: 114717 RVA: 0x000A6E18 File Offset: 0x000A5018
		[Token(Token = "0x601C01D")]
		[Address(RVA = "0x15578C0", Offset = "0x15564C0", VA = "0x1815578C0")]
		public bool IsResFullOpen()
		{
			return default(bool);
		}

		// Token: 0x0601C01E RID: 114718 RVA: 0x000A6E30 File Offset: 0x000A5030
		[Token(Token = "0x601C01E")]
		[Address(RVA = "0x1557970", Offset = "0x1556570", VA = "0x181557970")]
		public bool IsResFullPause()
		{
			return default(bool);
		}

		// Token: 0x0601C01F RID: 114719 RVA: 0x000A6E48 File Offset: 0x000A5048
		[Token(Token = "0x601C01F")]
		[Address(RVA = "0x1557400", Offset = "0x1556000", VA = "0x181557400")]
		public int GetResFullOpenRemainDay()
		{
			return 0;
		}

		// Token: 0x0601C020 RID: 114720 RVA: 0x000A6E60 File Offset: 0x000A5060
		[Token(Token = "0x601C020")]
		[Address(RVA = "0x1557A20", Offset = "0x1556620", VA = "0x181557A20")]
		public bool IsStartMissionGroupUnlock()
		{
			return default(bool);
		}

		// Token: 0x0601C021 RID: 114721 RVA: 0x000A6E78 File Offset: 0x000A5078
		[Token(Token = "0x601C021")]
		[Address(RVA = "0x1557790", Offset = "0x1556390", VA = "0x181557790")]
		public bool IsAllStartMissionsComplete()
		{
			return default(bool);
		}

		// Token: 0x0601C022 RID: 114722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C022")]
		[Address(RVA = "0x1558080", Offset = "0x1556C80", VA = "0x181558080")]
		public static void RefreshRewardData(MissionType type = MissionType.UNKNOWN, bool ignoreNotify = false)
		{
		}

		// Token: 0x0601C023 RID: 114723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C023")]
		[Address(RVA = "0x1557B00", Offset = "0x1556700", VA = "0x181557B00")]
		public static void RefreshPlayerDataStatic(MissionType missionType = MissionType.UNKNOWN)
		{
		}

		// Token: 0x0601C024 RID: 114724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C024")]
		[Address(RVA = "0x1557BE0", Offset = "0x15567E0", VA = "0x181557BE0")]
		public void RefreshPlayerData(MissionType missionType = MissionType.UNKNOWN)
		{
		}

		// Token: 0x0601C025 RID: 114725 RVA: 0x000A6E90 File Offset: 0x000A5090
		[Token(Token = "0x601C025")]
		[Address(RVA = "0x1558FF0", Offset = "0x1557BF0", VA = "0x181558FF0")]
		private static int _MissionSortingRefVal(MissionViewModel v)
		{
			return 0;
		}

		// Token: 0x0601C026 RID: 114726 RVA: 0x000A6EA8 File Offset: 0x000A50A8
		[Token(Token = "0x601C026")]
		[Address(RVA = "0x1558E40", Offset = "0x1557A40", VA = "0x181558E40")]
		private static int _MissionSortingCompare(MissionViewModel v0, MissionViewModel v1)
		{
			return 0;
		}

		// Token: 0x0601C027 RID: 114727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C027")]
		[Address(RVA = "0x1558410", Offset = "0x1557010", VA = "0x181558410")]
		private void _DealWithMissionData(Dictionary<string, MissionPlayerState> missionPlayerData, MissionType missionType)
		{
		}

		// Token: 0x0601C028 RID: 114728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C028")]
		[Address(RVA = "0x15574B0", Offset = "0x15560B0", VA = "0x1815574B0")]
		public void InitSoCharMission()
		{
		}

		// Token: 0x0601C029 RID: 114729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C029")]
		[Address(RVA = "0x1556940", Offset = "0x1555540", VA = "0x181556940")]
		public void DealWithPlayerData(Dictionary<string, MissionPlayerState> missionPlayerData)
		{
		}

		// Token: 0x0601C02A RID: 114730 RVA: 0x000A6EC0 File Offset: 0x000A50C0
		[Token(Token = "0x601C02A")]
		[Address(RVA = "0x15572E0", Offset = "0x1555EE0", VA = "0x1815572E0")]
		public float GetRandomSeed(string missionName)
		{
			return 0f;
		}

		// Token: 0x0601C02B RID: 114731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C02B")]
		[Address(RVA = "0x15581D0", Offset = "0x1556DD0", VA = "0x1815581D0")]
		public void SetBranchFold(string foldId)
		{
		}

		// Token: 0x0601C02C RID: 114732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C02C")]
		[Address(RVA = "0x15582B0", Offset = "0x1556EB0", VA = "0x1815582B0")]
		public void SetBranchSpread(string foldId)
		{
		}

		// Token: 0x0601C02D RID: 114733 RVA: 0x000A6ED8 File Offset: 0x000A50D8
		[Token(Token = "0x601C02D")]
		[Address(RVA = "0x1557230", Offset = "0x1555E30", VA = "0x181557230")]
		public static float GetHashString(string hashId)
		{
			return 0f;
		}

		// Token: 0x0601C02E RID: 114734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C02E")]
		[Address(RVA = "0x1559190", Offset = "0x1557D90", VA = "0x181559190")]
		public MissionModel()
		{
		}

		// Token: 0x0402488F RID: 149647
		[Token(Token = "0x402488F")]
		[NonSerialized]
		public const float DEFAULT_ITEM_DESC_SCALE = 1.11f;

		// Token: 0x04024890 RID: 149648
		[Token(Token = "0x4024890")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<MissionViewModel> startMissions;

		// Token: 0x04024891 RID: 149649
		[Token(Token = "0x4024891")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public MissionViewModel mainMissions;

		// Token: 0x04024892 RID: 149650
		[Token(Token = "0x4024892")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public List<MissionViewModel> branchMissions;

		// Token: 0x04024893 RID: 149651
		[Token(Token = "0x4024893")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public bool haveNotUnlockedSubMissionFlag;

		// Token: 0x04024894 RID: 149652
		[Token(Token = "0x4024894")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public MissionModel.BranchWrappedGroup branchGroup;

		// Token: 0x04024895 RID: 149653
		[Token(Token = "0x4024895")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public List<MissionViewModel> dailyMissions;

		// Token: 0x04024896 RID: 149654
		[Token(Token = "0x4024896")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public List<MissionViewModel> weeklyMissions;

		// Token: 0x04024897 RID: 149655
		[Token(Token = "0x4024897")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public MissionDailyRewards dailyReward;

		// Token: 0x04024898 RID: 149656
		[Token(Token = "0x4024898")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<MissionType> missionTypeRefresh;

		// Token: 0x04024899 RID: 149657
		[Token(Token = "0x4024899")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public MissionModel.SoCharWrappedGroup socharMissions;

		// Token: 0x0402489A RID: 149658
		[Token(Token = "0x402489A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TryGetCurrStartMissionGroup;

		// Token: 0x0402489B RID: 149659
		[Token(Token = "0x402489B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetCurrStartMissionGroup;

		// Token: 0x0402489C RID: 149660
		[Token(Token = "0x402489C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCurrGuideMissionGroupInfo;

		// Token: 0x0402489D RID: 149661
		[Token(Token = "0x402489D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsResFullOpen;

		// Token: 0x0402489E RID: 149662
		[Token(Token = "0x402489E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsResFullPause;

		// Token: 0x0402489F RID: 149663
		[Token(Token = "0x402489F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetResFullOpenRemainDay;

		// Token: 0x040248A0 RID: 149664
		[Token(Token = "0x40248A0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsStartMissionGroupUnlock;

		// Token: 0x040248A1 RID: 149665
		[Token(Token = "0x40248A1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsAllStartMissionsComplete;

		// Token: 0x040248A2 RID: 149666
		[Token(Token = "0x40248A2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshRewardData;

		// Token: 0x040248A3 RID: 149667
		[Token(Token = "0x40248A3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshPlayerDataStatic;

		// Token: 0x040248A4 RID: 149668
		[Token(Token = "0x40248A4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x040248A5 RID: 149669
		[Token(Token = "0x40248A5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__MissionSortingRefVal;

		// Token: 0x040248A6 RID: 149670
		[Token(Token = "0x40248A6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__MissionSortingCompare;

		// Token: 0x040248A7 RID: 149671
		[Token(Token = "0x40248A7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DealWithMissionData;

		// Token: 0x040248A8 RID: 149672
		[Token(Token = "0x40248A8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_InitSoCharMission;

		// Token: 0x040248A9 RID: 149673
		[Token(Token = "0x40248A9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DealWithPlayerData;

		// Token: 0x040248AA RID: 149674
		[Token(Token = "0x40248AA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetRandomSeed;

		// Token: 0x040248AB RID: 149675
		[Token(Token = "0x40248AB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SetBranchFold;

		// Token: 0x040248AC RID: 149676
		[Token(Token = "0x40248AC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetBranchSpread;

		// Token: 0x040248AD RID: 149677
		[Token(Token = "0x40248AD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetHashString;

		// Token: 0x040248AE RID: 149678
		[Token(Token = "0x40248AE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004872 RID: 18546
		[Token(Token = "0x2004872")]
		public class SoCharWrappedGroup
		{
			// Token: 0x0601C02F RID: 114735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C02F")]
			[Address(RVA = "0x1573070", Offset = "0x1571C70", VA = "0x181573070")]
			public SoCharWrappedGroup()
			{
			}

			// Token: 0x040248AF RID: 149679
			[Token(Token = "0x40248AF")]
			[FieldOffset(Offset = "0x10")]
			public bool isEnabled;

			// Token: 0x040248B0 RID: 149680
			[Token(Token = "0x40248B0")]
			[FieldOffset(Offset = "0x18")]
			public CharQuery focusChar;

			// Token: 0x040248B1 RID: 149681
			[Token(Token = "0x40248B1")]
			[FieldOffset(Offset = "0x30")]
			public bool isCharEnabled;

			// Token: 0x040248B2 RID: 149682
			[Token(Token = "0x40248B2")]
			[FieldOffset(Offset = "0x38")]
			public CharacterData charData;

			// Token: 0x040248B3 RID: 149683
			[Token(Token = "0x40248B3")]
			[FieldOffset(Offset = "0x40")]
			public CharacterIllustViewProperty illustProperty;

			// Token: 0x040248B4 RID: 149684
			[Token(Token = "0x40248B4")]
			[FieldOffset(Offset = "0x48")]
			public List<MissionViewModel> groupMissions;

			// Token: 0x040248B5 RID: 149685
			[Token(Token = "0x40248B5")]
			[FieldOffset(Offset = "0x50")]
			public PlayerCharacter playerCharInfo;

			// Token: 0x040248B6 RID: 149686
			[Token(Token = "0x40248B6")]
			[FieldOffset(Offset = "0x58")]
			public bool hasMissionToReceive;

			// Token: 0x040248B7 RID: 149687
			[Token(Token = "0x40248B7")]
			[FieldOffset(Offset = "0x60")]
			public List<MissionViewModel> ableToMissions;
		}

		// Token: 0x02004873 RID: 18547
		[Token(Token = "0x2004873")]
		public class BranchWrappedGroup : IHotfixable
		{
			// Token: 0x0601C030 RID: 114736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C030")]
			[Address(RVA = "0x1562980", Offset = "0x1561580", VA = "0x181562980")]
			public BranchWrappedGroup(List<MissionViewModel> branchMissionList, bool haveLockedSubMission)
			{
			}

			// Token: 0x0601C031 RID: 114737 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C031")]
			[Address(RVA = "0x1562660", Offset = "0x1561260", VA = "0x181562660")]
			public List<MissionModel.BranchWrappedGroup.RenderViewModel> GetRenderViewModel()
			{
				return null;
			}

			// Token: 0x040248B8 RID: 149688
			[Token(Token = "0x40248B8")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<string, MissionModel.BranchWrappedGroup.Item> items;

			// Token: 0x040248B9 RID: 149689
			[Token(Token = "0x40248B9")]
			[FieldOffset(Offset = "0x18")]
			public List<MissionViewModel> branchMissions;

			// Token: 0x040248BA RID: 149690
			[Token(Token = "0x40248BA")]
			[FieldOffset(Offset = "0x20")]
			public bool havelockedMission;

			// Token: 0x040248BB RID: 149691
			[Token(Token = "0x40248BB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040248BC RID: 149692
			[Token(Token = "0x40248BC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetRenderViewModel;

			// Token: 0x02004874 RID: 18548
			[Token(Token = "0x2004874")]
			public class Item
			{
				// Token: 0x17004295 RID: 17045
				// (get) Token: 0x0601C032 RID: 114738 RVA: 0x000A6EF0 File Offset: 0x000A50F0
				[Token(Token = "0x17004295")]
				public int sortId
				{
					[Token(Token = "0x601C032")]
					[Address(RVA = "0x15654E0", Offset = "0x15640E0", VA = "0x1815654E0")]
					get
					{
						return 0;
					}
				}

				// Token: 0x0601C033 RID: 114739 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601C033")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Item()
				{
				}

				// Token: 0x040248BD RID: 149693
				[Token(Token = "0x40248BD")]
				[FieldOffset(Offset = "0x10")]
				public bool isFoldAble;

				// Token: 0x040248BE RID: 149694
				[Token(Token = "0x40248BE")]
				[FieldOffset(Offset = "0x11")]
				public bool isFold;

				// Token: 0x040248BF RID: 149695
				[Token(Token = "0x40248BF")]
				[FieldOffset(Offset = "0x18")]
				public List<MissionViewModel> missionList;
			}

			// Token: 0x02004875 RID: 18549
			[Token(Token = "0x2004875")]
			public class RenderViewModel
			{
				// Token: 0x0601C034 RID: 114740 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601C034")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RenderViewModel()
				{
				}

				// Token: 0x040248C0 RID: 149696
				[Token(Token = "0x40248C0")]
				[FieldOffset(Offset = "0x10")]
				public MissionViewModel mission;

				// Token: 0x040248C1 RID: 149697
				[Token(Token = "0x40248C1")]
				[FieldOffset(Offset = "0x18")]
				public int count;

				// Token: 0x040248C2 RID: 149698
				[Token(Token = "0x40248C2")]
				[FieldOffset(Offset = "0x1C")]
				public bool isFold;

				// Token: 0x040248C3 RID: 149699
				[Token(Token = "0x40248C3")]
				[FieldOffset(Offset = "0x1D")]
				public bool ableToSpread;

				// Token: 0x040248C4 RID: 149700
				[Token(Token = "0x40248C4")]
				[FieldOffset(Offset = "0x1E")]
				public bool isLast;
			}
		}
	}
}
