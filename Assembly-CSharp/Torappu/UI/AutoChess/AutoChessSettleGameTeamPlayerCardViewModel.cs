using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006307 RID: 25351
	[Token(Token = "0x2006307")]
	public class AutoChessSettleGameTeamPlayerCardViewModel : IComparable<AutoChessSettleGameTeamPlayerCardViewModel>, IHotfixable
	{
		// Token: 0x06024886 RID: 149638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024886")]
		[Address(RVA = "0x1F5D0B0", Offset = "0x1F5BCB0", VA = "0x181F5D0B0")]
		public void LoadData(AutoChessSettleGameTeamPlayerCardViewModel.InputParam inputParam)
		{
		}

		// Token: 0x06024887 RID: 149639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024887")]
		[Address(RVA = "0x1F5D6E0", Offset = "0x1F5C2E0", VA = "0x181F5D6E0")]
		public void RefreshFriendInfo(FriendState state, string noteName)
		{
		}

		// Token: 0x06024888 RID: 149640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024888")]
		[Address(RVA = "0x1F5D7F0", Offset = "0x1F5C3F0", VA = "0x181F5D7F0")]
		public void ShowReportPart(bool show)
		{
		}

		// Token: 0x06024889 RID: 149641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024889")]
		[Address(RVA = "0x1F5D780", Offset = "0x1F5C380", VA = "0x181F5D780")]
		public void SetPlayerReported()
		{
		}

		// Token: 0x0602488A RID: 149642 RVA: 0x000C4800 File Offset: 0x000C2A00
		[Token(Token = "0x602488A")]
		[Address(RVA = "0x1F5D870", Offset = "0x1F5C470", VA = "0x181F5D870")]
		private AutoChessSettleGameTeamPlayerRoundType _GetRoundType(AutoChessSettleGamePlayerStatus gameCode)
		{
			return AutoChessSettleGameTeamPlayerRoundType.NONE;
		}

		// Token: 0x0602488B RID: 149643 RVA: 0x000C4818 File Offset: 0x000C2A18
		[Token(Token = "0x602488B")]
		[Address(RVA = "0x1F5D920", Offset = "0x1F5C520", VA = "0x181F5D920")]
		private AutoChessSettleGameTeamPlayerTitleType _GetTitleType(bool isTrainingMode, bool isGameFinished, bool isSelf, bool hasTitle, AutoChessSettleGamePlayerStatus gameCode)
		{
			return AutoChessSettleGameTeamPlayerTitleType.NONE;
		}

		// Token: 0x0602488C RID: 149644 RVA: 0x000C4830 File Offset: 0x000C2A30
		[Token(Token = "0x602488C")]
		[Address(RVA = "0x1F5D010", Offset = "0x1F5BC10", VA = "0x181F5D010", Slot = "4")]
		public int CompareTo(AutoChessSettleGameTeamPlayerCardViewModel other)
		{
			return 0;
		}

		// Token: 0x0602488D RID: 149645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602488D")]
		[Address(RVA = "0x1F5D9F0", Offset = "0x1F5C5F0", VA = "0x181F5D9F0")]
		public AutoChessSettleGameTeamPlayerCardViewModel()
		{
		}

		// Token: 0x04032F59 RID: 208729
		[Token(Token = "0x4032F59")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04032F5A RID: 208730
		[Token(Token = "0x4032F5A")]
		[FieldOffset(Offset = "0x18")]
		public bool isSelf;

		// Token: 0x04032F5B RID: 208731
		[Token(Token = "0x4032F5B")]
		[FieldOffset(Offset = "0x1C")]
		public int position;

		// Token: 0x04032F5C RID: 208732
		[Token(Token = "0x4032F5C")]
		[FieldOffset(Offset = "0x20")]
		public bool isPass;

		// Token: 0x04032F5D RID: 208733
		[Token(Token = "0x4032F5D")]
		[FieldOffset(Offset = "0x28")]
		public CharUISkinStruct illustSkin;

		// Token: 0x04032F5E RID: 208734
		[Token(Token = "0x4032F5E")]
		[FieldOffset(Offset = "0x40")]
		public AutoChessSettleGameTeamPlayerRoundType roundType;

		// Token: 0x04032F5F RID: 208735
		[Token(Token = "0x4032F5F")]
		[FieldOffset(Offset = "0x44")]
		public int roundPassNum;

		// Token: 0x04032F60 RID: 208736
		[Token(Token = "0x4032F60")]
		[FieldOffset(Offset = "0x48")]
		public AutoChessSettleGameTeamPlayerTitleType titleType;

		// Token: 0x04032F61 RID: 208737
		[Token(Token = "0x4032F61")]
		[FieldOffset(Offset = "0x50")]
		public string titleInfo;

		// Token: 0x04032F62 RID: 208738
		[Token(Token = "0x4032F62")]
		[FieldOffset(Offset = "0x58")]
		public string titlePicId;

		// Token: 0x04032F63 RID: 208739
		[Token(Token = "0x4032F63")]
		[FieldOffset(Offset = "0x60")]
		public AutoChessPlayerInfo playerInfo;

		// Token: 0x04032F64 RID: 208740
		[Token(Token = "0x4032F64")]
		[FieldOffset(Offset = "0xB0")]
		public Dictionary<string, AutoChessSettleGameTeamOtherPlayerAvatarInfo> otherPlayerAvatarInfoDict;

		// Token: 0x04032F65 RID: 208741
		[Token(Token = "0x4032F65")]
		[FieldOffset(Offset = "0xB8")]
		public List<string> likedMeUidList;

		// Token: 0x04032F66 RID: 208742
		[Token(Token = "0x4032F66")]
		[FieldOffset(Offset = "0xC0")]
		public FriendState friendState;

		// Token: 0x04032F67 RID: 208743
		[Token(Token = "0x4032F67")]
		[FieldOffset(Offset = "0xC4")]
		public bool canLikeAndAdd;

		// Token: 0x04032F68 RID: 208744
		[Token(Token = "0x4032F68")]
		[FieldOffset(Offset = "0xC5")]
		public bool canReport;

		// Token: 0x04032F69 RID: 208745
		[Token(Token = "0x4032F69")]
		[FieldOffset(Offset = "0xC6")]
		public bool isReportPartShowing;

		// Token: 0x04032F6A RID: 208746
		[Token(Token = "0x4032F6A")]
		[FieldOffset(Offset = "0xC7")]
		public bool reported;

		// Token: 0x04032F6B RID: 208747
		[Token(Token = "0x4032F6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032F6C RID: 208748
		[Token(Token = "0x4032F6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshFriendInfo;

		// Token: 0x04032F6D RID: 208749
		[Token(Token = "0x4032F6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowReportPart;

		// Token: 0x04032F6E RID: 208750
		[Token(Token = "0x4032F6E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetPlayerReported;

		// Token: 0x04032F6F RID: 208751
		[Token(Token = "0x4032F6F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetRoundType;

		// Token: 0x04032F70 RID: 208752
		[Token(Token = "0x4032F70")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTitleType;

		// Token: 0x04032F71 RID: 208753
		[Token(Token = "0x4032F71")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04032F72 RID: 208754
		[Token(Token = "0x4032F72")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006308 RID: 25352
		[Token(Token = "0x2006308")]
		public struct InputParam
		{
			// Token: 0x04032F73 RID: 208755
			[Token(Token = "0x4032F73")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo teamInfo;

			// Token: 0x04032F74 RID: 208756
			[Token(Token = "0x4032F74")]
			[FieldOffset(Offset = "0x8")]
			public AutoChessSeasonSettleGameInfo.AutoChessRecordInfos selfRecordInfo;

			// Token: 0x04032F75 RID: 208757
			[Token(Token = "0x4032F75")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x04032F76 RID: 208758
			[Token(Token = "0x4032F76")]
			[FieldOffset(Offset = "0x18")]
			public string selfUid;

			// Token: 0x04032F77 RID: 208759
			[Token(Token = "0x4032F77")]
			[FieldOffset(Offset = "0x20")]
			public bool isGameFinished;

			// Token: 0x04032F78 RID: 208760
			[Token(Token = "0x4032F78")]
			[FieldOffset(Offset = "0x21")]
			public bool isLocalMode;

			// Token: 0x04032F79 RID: 208761
			[Token(Token = "0x4032F79")]
			[FieldOffset(Offset = "0x28")]
			public ActAutoChessData.ActAutoChessPlayerTitleData titleData;

			// Token: 0x04032F7A RID: 208762
			[Token(Token = "0x4032F7A")]
			[FieldOffset(Offset = "0x30")]
			public List<string> initLikedMeUidList;

			// Token: 0x04032F7B RID: 208763
			[Token(Token = "0x4032F7B")]
			[FieldOffset(Offset = "0x38")]
			public string noteName;

			// Token: 0x04032F7C RID: 208764
			[Token(Token = "0x4032F7C")]
			[FieldOffset(Offset = "0x40")]
			public FriendState friendState;

			// Token: 0x04032F7D RID: 208765
			[Token(Token = "0x4032F7D")]
			[FieldOffset(Offset = "0x44")]
			public bool canLikeAndAdd;

			// Token: 0x04032F7E RID: 208766
			[Token(Token = "0x4032F7E")]
			[FieldOffset(Offset = "0x45")]
			public bool canReport;
		}
	}
}
