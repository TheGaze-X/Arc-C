using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CFD RID: 27901
	[Token(Token = "0x2006CFD")]
	public class TemplateActivityMissionGroupViewModel : TemplateActivityViewModel
	{
		// Token: 0x17005E00 RID: 24064
		// (get) Token: 0x06027C73 RID: 162931 RVA: 0x000CF600 File Offset: 0x000CD800
		// (set) Token: 0x06027C74 RID: 162932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E00")]
		public int completedMissionCount
		{
			[Token(Token = "0x6027C73")]
			[Address(RVA = "0x22FEC30", Offset = "0x22FD830", VA = "0x1822FEC30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6027C74")]
			[Address(RVA = "0x22FED00", Offset = "0x22FD900", VA = "0x1822FED00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E01 RID: 24065
		// (get) Token: 0x06027C75 RID: 162933 RVA: 0x000CF618 File Offset: 0x000CD818
		[Token(Token = "0x17005E01")]
		public int missionCount
		{
			[Token(Token = "0x6027C75")]
			[Address(RVA = "0x22FEC90", Offset = "0x22FD890", VA = "0x1822FEC90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06027C76 RID: 162934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C76")]
		[Address(RVA = "0x22FE2E0", Offset = "0x22FCEE0", VA = "0x1822FE2E0")]
		public void SortMissionList()
		{
		}

		// Token: 0x06027C77 RID: 162935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C77")]
		[Address(RVA = "0x22FDCD0", Offset = "0x22FC8D0", VA = "0x1822FDCD0")]
		public List<TemplateMissionViewModel> GetMissionList()
		{
			return null;
		}

		// Token: 0x06027C78 RID: 162936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C78")]
		[Address(RVA = "0x22FDF00", Offset = "0x22FCB00", VA = "0x1822FDF00")]
		public void RefreshMissionState()
		{
		}

		// Token: 0x06027C79 RID: 162937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C79")]
		[Address(RVA = "0x22FE510", Offset = "0x22FD110", VA = "0x1822FE510")]
		public TemplateActivityMissionGroupViewModel(object param)
		{
		}

		// Token: 0x06027C7A RID: 162938 RVA: 0x000CF630 File Offset: 0x000CD830
		[Token(Token = "0x6027C7A")]
		[Address(RVA = "0x22FD680", Offset = "0x22FC280", VA = "0x1822FD680")]
		public bool CheckMissionPlayerDataChanged(PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x04038699 RID: 231065
		[Token(Token = "0x4038699")]
		[FieldOffset(Offset = "0x20")]
		public List<TemplateMissionViewModel> missionList;

		// Token: 0x0403869A RID: 231066
		[Token(Token = "0x403869A")]
		[FieldOffset(Offset = "0x28")]
		public TemplateActivityMissionViewModelPlugin plugin;

		// Token: 0x0403869B RID: 231067
		[Token(Token = "0x403869B")]
		[FieldOffset(Offset = "0x30")]
		public DataBundle meta;

		// Token: 0x0403869C RID: 231068
		[Token(Token = "0x403869C")]
		[FieldOffset(Offset = "0x38")]
		public bool haveMissionToGet;

		// Token: 0x0403869E RID: 231070
		[Token(Token = "0x403869E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_completedMissionCount;

		// Token: 0x0403869F RID: 231071
		[Token(Token = "0x403869F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_completedMissionCount;

		// Token: 0x040386A0 RID: 231072
		[Token(Token = "0x40386A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_missionCount;

		// Token: 0x040386A1 RID: 231073
		[Token(Token = "0x40386A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SortMissionList;

		// Token: 0x040386A2 RID: 231074
		[Token(Token = "0x40386A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMissionList;

		// Token: 0x040386A3 RID: 231075
		[Token(Token = "0x40386A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshMissionState;

		// Token: 0x040386A4 RID: 231076
		[Token(Token = "0x40386A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040386A5 RID: 231077
		[Token(Token = "0x40386A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckMissionPlayerDataChanged;

		// Token: 0x02006CFE RID: 27902
		[Token(Token = "0x2006CFE")]
		private struct MissionStateStruct : IHotfixable
		{
			// Token: 0x06027C7C RID: 162940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027C7C")]
			[Address(RVA = "0x22F9050", Offset = "0x22F7C50", VA = "0x1822F9050")]
			public MissionStateStruct(MissionHoldingState state, int target, int value)
			{
			}

			// Token: 0x06027C7D RID: 162941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027C7D")]
			[Address(RVA = "0x22F9170", Offset = "0x22F7D70", VA = "0x1822F9170")]
			public MissionStateStruct(MissionPlayerState missionPlayerState)
			{
			}

			// Token: 0x06027C7E RID: 162942 RVA: 0x000CF660 File Offset: 0x000CD860
			[Token(Token = "0x6027C7E")]
			[Address(RVA = "0x22F8F30", Offset = "0x22F7B30", VA = "0x1822F8F30")]
			public bool IsEqual(TemplateActivityMissionGroupViewModel.MissionStateStruct targetStruct)
			{
				return default(bool);
			}

			// Token: 0x040386A6 RID: 231078
			[Token(Token = "0x40386A6")]
			[FieldOffset(Offset = "0x0")]
			public MissionHoldingState state;

			// Token: 0x040386A7 RID: 231079
			[Token(Token = "0x40386A7")]
			[FieldOffset(Offset = "0x4")]
			public int target;

			// Token: 0x040386A8 RID: 231080
			[Token(Token = "0x40386A8")]
			[FieldOffset(Offset = "0x8")]
			public int value;

			// Token: 0x040386A9 RID: 231081
			[Token(Token = "0x40386A9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040386AA RID: 231082
			[Token(Token = "0x40386AA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix1_ctor;

			// Token: 0x040386AB RID: 231083
			[Token(Token = "0x40386AB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsEqual;
		}

		// Token: 0x02006CFF RID: 27903
		[Token(Token = "0x2006CFF")]
		public class Input
		{
			// Token: 0x06027C7F RID: 162943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027C7F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x040386AC RID: 231084
			[Token(Token = "0x40386AC")]
			[FieldOffset(Offset = "0x10")]
			public string activityId;

			// Token: 0x040386AD RID: 231085
			[Token(Token = "0x40386AD")]
			[FieldOffset(Offset = "0x18")]
			public List<string> missionGroupIdList;

			// Token: 0x040386AE RID: 231086
			[Token(Token = "0x40386AE")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, DataBundle> missionDataBundleDict;

			// Token: 0x040386AF RID: 231087
			[Token(Token = "0x40386AF")]
			[FieldOffset(Offset = "0x28")]
			public DataBundle meta;

			// Token: 0x040386B0 RID: 231088
			[Token(Token = "0x40386B0")]
			[FieldOffset(Offset = "0x30")]
			public TemplateActivityMissionViewModelPlugin plugin;
		}
	}
}
