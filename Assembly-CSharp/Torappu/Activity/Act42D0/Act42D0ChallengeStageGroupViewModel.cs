using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007360 RID: 29536
	[Token(Token = "0x2007360")]
	public class Act42D0ChallengeStageGroupViewModel : IHotfixable
	{
		// Token: 0x06029C51 RID: 171089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C51")]
		[Address(RVA = "0x2556240", Offset = "0x2554E40", VA = "0x182556240")]
		public void LoadData(string actId, string selectStageId)
		{
		}

		// Token: 0x06029C52 RID: 171090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C52")]
		[Address(RVA = "0x2556610", Offset = "0x2555210", VA = "0x182556610")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06029C53 RID: 171091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029C53")]
		[Address(RVA = "0x2556100", Offset = "0x2554D00", VA = "0x182556100")]
		public Act42D0ChallengeStageViewModel GetStageById(string stageId)
		{
			return null;
		}

		// Token: 0x06029C54 RID: 171092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C54")]
		[Address(RVA = "0x2556900", Offset = "0x2555500", VA = "0x182556900")]
		public Act42D0ChallengeStageGroupViewModel()
		{
		}

		// Token: 0x0403BCB9 RID: 244921
		[Token(Token = "0x403BCB9")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403BCBA RID: 244922
		[Token(Token = "0x403BCBA")]
		[FieldOffset(Offset = "0x18")]
		public string challengeDesc;

		// Token: 0x0403BCBB RID: 244923
		[Token(Token = "0x403BCBB")]
		[FieldOffset(Offset = "0x20")]
		public string challengeName;

		// Token: 0x0403BCBC RID: 244924
		[Token(Token = "0x403BCBC")]
		[FieldOffset(Offset = "0x28")]
		public string stageSelected;

		// Token: 0x0403BCBD RID: 244925
		[Token(Token = "0x403BCBD")]
		[FieldOffset(Offset = "0x30")]
		public List<Act42D0ChallengeStageViewModel> stageViewModelList;

		// Token: 0x0403BCBE RID: 244926
		[Token(Token = "0x403BCBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BCBF RID: 244927
		[Token(Token = "0x403BCBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0403BCC0 RID: 244928
		[Token(Token = "0x403BCC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetStageById;

		// Token: 0x0403BCC1 RID: 244929
		[Token(Token = "0x403BCC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
