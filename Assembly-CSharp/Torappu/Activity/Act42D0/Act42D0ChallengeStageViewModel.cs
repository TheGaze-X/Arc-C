using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007361 RID: 29537
	[Token(Token = "0x2007361")]
	public class Act42D0ChallengeStageViewModel : IHotfixable
	{
		// Token: 0x06029C55 RID: 171093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C55")]
		[Address(RVA = "0x25569B0", Offset = "0x25555B0", VA = "0x1825569B0")]
		public void LoadData(string actId, Act42D0Data.Act42D0ChallengeInfoData challengeInfoData)
		{
		}

		// Token: 0x06029C56 RID: 171094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C56")]
		[Address(RVA = "0x2556E10", Offset = "0x2555A10", VA = "0x182556E10")]
		public void RefreshPlayerData(string actId, PlayerActivity.PlayerAct42D0Activity.ChallengeStageInfo stageInfo)
		{
		}

		// Token: 0x06029C57 RID: 171095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C57")]
		[Address(RVA = "0x2556FB0", Offset = "0x2555BB0", VA = "0x182556FB0")]
		public Act42D0ChallengeStageViewModel()
		{
		}

		// Token: 0x0403BCC2 RID: 244930
		[Token(Token = "0x403BCC2")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0403BCC3 RID: 244931
		[Token(Token = "0x403BCC3")]
		[FieldOffset(Offset = "0x18")]
		public string stageCode;

		// Token: 0x0403BCC4 RID: 244932
		[Token(Token = "0x403BCC4")]
		[FieldOffset(Offset = "0x20")]
		public string stageName;

		// Token: 0x0403BCC5 RID: 244933
		[Token(Token = "0x403BCC5")]
		[FieldOffset(Offset = "0x28")]
		public string stageDesc;

		// Token: 0x0403BCC6 RID: 244934
		[Token(Token = "0x403BCC6")]
		[FieldOffset(Offset = "0x30")]
		public string levelId;

		// Token: 0x0403BCC7 RID: 244935
		[Token(Token = "0x403BCC7")]
		[FieldOffset(Offset = "0x38")]
		public string loadingPicId;

		// Token: 0x0403BCC8 RID: 244936
		[Token(Token = "0x403BCC8")]
		[FieldOffset(Offset = "0x40")]
		public string openHint;

		// Token: 0x0403BCC9 RID: 244937
		[Token(Token = "0x403BCC9")]
		[FieldOffset(Offset = "0x48")]
		public bool isNew;

		// Token: 0x0403BCCA RID: 244938
		[Token(Token = "0x403BCCA")]
		[FieldOffset(Offset = "0x49")]
		public bool unlocked;

		// Token: 0x0403BCCB RID: 244939
		[Token(Token = "0x403BCCB")]
		[FieldOffset(Offset = "0x4A")]
		public bool allComplete;

		// Token: 0x0403BCCC RID: 244940
		[Token(Token = "0x403BCCC")]
		[FieldOffset(Offset = "0x50")]
		public List<Act42D0ChallengeMissionItemViewModel> missionItemViewModelList;

		// Token: 0x0403BCCD RID: 244941
		[Token(Token = "0x403BCCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BCCE RID: 244942
		[Token(Token = "0x403BCCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0403BCCF RID: 244943
		[Token(Token = "0x403BCCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
