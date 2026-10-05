using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Mission;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F03 RID: 20227
	[Token(Token = "0x2004F03")]
	public class FifthAnnivExploreMissionViewModel : IHotfixable
	{
		// Token: 0x0601E279 RID: 123513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E279")]
		[Address(RVA = "0x17D58A0", Offset = "0x17D44A0", VA = "0x1817D58A0")]
		public void LoadData()
		{
		}

		// Token: 0x0601E27A RID: 123514 RVA: 0x000ADAD8 File Offset: 0x000ABCD8
		[Token(Token = "0x601E27A")]
		[Address(RVA = "0x17D6380", Offset = "0x17D4F80", VA = "0x1817D6380")]
		private int _MissionSortingCompare(FifthAnnivExploreMissionViewModel.MissionObjHolderViewModel vm0, FifthAnnivExploreMissionViewModel.MissionObjHolderViewModel vm1)
		{
			return 0;
		}

		// Token: 0x0601E27B RID: 123515 RVA: 0x000ADAF0 File Offset: 0x000ABCF0
		[Token(Token = "0x601E27B")]
		[Address(RVA = "0x17D6590", Offset = "0x17D5190", VA = "0x1817D6590")]
		private static int _MissionSortingRefVal(FifthAnnivExploreMissionViewModel.MissionObjHolderViewModel vm)
		{
			return 0;
		}

		// Token: 0x0601E27C RID: 123516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E27C")]
		[Address(RVA = "0x17D5690", Offset = "0x17D4290", VA = "0x1817D5690")]
		public List<string> GetAllToCollectMissionIds()
		{
			return null;
		}

		// Token: 0x0601E27D RID: 123517 RVA: 0x000ADB08 File Offset: 0x000ABD08
		[Token(Token = "0x601E27D")]
		[Address(RVA = "0x17D55C0", Offset = "0x17D41C0", VA = "0x1817D55C0")]
		public bool CanCollect(string missionId)
		{
			return default(bool);
		}

		// Token: 0x0601E27E RID: 123518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E27E")]
		[Address(RVA = "0x17D6250", Offset = "0x17D4E50", VA = "0x1817D6250")]
		private static Dictionary<string, FifthAnnivExploreMissionData> _GetFifthAnnivMainLineMissionData()
		{
			return null;
		}

		// Token: 0x0601E27F RID: 123519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E27F")]
		[Address(RVA = "0x17D62D0", Offset = "0x17D4ED0", VA = "0x1817D62D0")]
		private static Dictionary<string, PlayerMainlineExplore.PlayerExploreOuterContextMissionState> _GetFifthAnnivMainLinePlayerMissionData()
		{
			return null;
		}

		// Token: 0x0601E280 RID: 123520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E280")]
		[Address(RVA = "0x17D6630", Offset = "0x17D5230", VA = "0x1817D6630")]
		public FifthAnnivExploreMissionViewModel()
		{
		}

		// Token: 0x04028244 RID: 164420
		[Token(Token = "0x4028244")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, FifthAnnivExploreMissionViewModel.MissionObjHolderViewModel> missionModelDict;

		// Token: 0x04028245 RID: 164421
		[Token(Token = "0x4028245")]
		[FieldOffset(Offset = "0x18")]
		public List<FifthAnnivExploreMissionViewModel.MissionObjHolderViewModel> missionModelList;

		// Token: 0x04028246 RID: 164422
		[Token(Token = "0x4028246")]
		[FieldOffset(Offset = "0x20")]
		public bool hasRewardToCollect;

		// Token: 0x04028247 RID: 164423
		[Token(Token = "0x4028247")]
		[FieldOffset(Offset = "0x28")]
		public List<string> toCollectMissionIds;

		// Token: 0x04028248 RID: 164424
		[Token(Token = "0x4028248")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04028249 RID: 164425
		[Token(Token = "0x4028249")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402824A RID: 164426
		[Token(Token = "0x402824A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__MissionSortingCompare;

		// Token: 0x0402824B RID: 164427
		[Token(Token = "0x402824B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MissionSortingRefVal;

		// Token: 0x0402824C RID: 164428
		[Token(Token = "0x402824C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetAllToCollectMissionIds;

		// Token: 0x0402824D RID: 164429
		[Token(Token = "0x402824D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CanCollect;

		// Token: 0x0402824E RID: 164430
		[Token(Token = "0x402824E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetFifthAnnivMainLineMissionData;

		// Token: 0x0402824F RID: 164431
		[Token(Token = "0x402824F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetFifthAnnivMainLinePlayerMissionData;

		// Token: 0x04028250 RID: 164432
		[Token(Token = "0x4028250")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F04 RID: 20228
		[Token(Token = "0x2004F04")]
		public class MissionObjHolderViewModel
		{
			// Token: 0x0601E281 RID: 123521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E281")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionObjHolderViewModel()
			{
			}

			// Token: 0x04028251 RID: 164433
			[Token(Token = "0x4028251")]
			[FieldOffset(Offset = "0x10")]
			public MissionViewModel missionModel;

			// Token: 0x04028252 RID: 164434
			[Token(Token = "0x4028252")]
			[FieldOffset(Offset = "0x18")]
			public bool isCollectBtn;
		}
	}
}
