using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D95 RID: 19861
	[Token(Token = "0x2004D95")]
	public class NameCardViewModel
	{
		// Token: 0x0601DB75 RID: 121717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB75")]
		[Address(RVA = "0x174E700", Offset = "0x174D300", VA = "0x18174E700")]
		public void InitSelfData()
		{
		}

		// Token: 0x0601DB76 RID: 121718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB76")]
		[Address(RVA = "0x174F330", Offset = "0x174DF30", VA = "0x18174F330")]
		public void RefreshSelfData()
		{
		}

		// Token: 0x0601DB77 RID: 121719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB77")]
		[Address(RVA = "0x174E0D0", Offset = "0x174CCD0", VA = "0x18174E0D0")]
		public void InitFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB78 RID: 121720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DB78")]
		[Address(RVA = "0x174E050", Offset = "0x174CC50", VA = "0x18174E050")]
		public string GetResume()
		{
			return null;
		}

		// Token: 0x0601DB79 RID: 121721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB79")]
		[Address(RVA = "0x174F400", Offset = "0x174E000", VA = "0x18174F400")]
		private void _InitTeamCountList()
		{
		}

		// Token: 0x0601DB7A RID: 121722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB7A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NameCardViewModel()
		{
		}

		// Token: 0x04027461 RID: 160865
		[Token(Token = "0x4027461")]
		[FieldOffset(Offset = "0x10")]
		public bool isSelf;

		// Token: 0x04027462 RID: 160866
		[Token(Token = "0x4027462")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04027463 RID: 160867
		[Token(Token = "0x4027463")]
		[FieldOffset(Offset = "0x20")]
		public DateTime registerDate;

		// Token: 0x04027464 RID: 160868
		[Token(Token = "0x4027464")]
		[FieldOffset(Offset = "0x28")]
		public string nickNameId;

		// Token: 0x04027465 RID: 160869
		[Token(Token = "0x4027465")]
		[FieldOffset(Offset = "0x30")]
		public int level;

		// Token: 0x04027466 RID: 160870
		[Token(Token = "0x4027466")]
		[FieldOffset(Offset = "0x38")]
		public string id;

		// Token: 0x04027467 RID: 160871
		[Token(Token = "0x4027467")]
		[FieldOffset(Offset = "0x40")]
		public string serverName;

		// Token: 0x04027468 RID: 160872
		[Token(Token = "0x4027468")]
		[FieldOffset(Offset = "0x48")]
		public string resume;

		// Token: 0x04027469 RID: 160873
		[Token(Token = "0x4027469")]
		[FieldOffset(Offset = "0x50")]
		public string lastMissionCode;

		// Token: 0x0402746A RID: 160874
		[Token(Token = "0x402746A")]
		[FieldOffset(Offset = "0x58")]
		public int charCount;

		// Token: 0x0402746B RID: 160875
		[Token(Token = "0x402746B")]
		[FieldOffset(Offset = "0x5C")]
		public int furnCount;

		// Token: 0x0402746C RID: 160876
		[Token(Token = "0x402746C")]
		[FieldOffset(Offset = "0x60")]
		public AvatarInfo AvatarInfo;

		// Token: 0x0402746D RID: 160877
		[Token(Token = "0x402746D")]
		[FieldOffset(Offset = "0x68")]
		public List<NameCardViewModel.NameCardTeamViewModel> teamCountList;

		// Token: 0x0402746E RID: 160878
		[Token(Token = "0x402746E")]
		[FieldOffset(Offset = "0x70")]
		public CharUISkinStruct homeIllustChar;

		// Token: 0x0402746F RID: 160879
		[Token(Token = "0x402746F")]
		[FieldOffset(Offset = "0x88")]
		public List<PlayerFriendAssist> sharedCharDataSelf;

		// Token: 0x04027470 RID: 160880
		[Token(Token = "0x4027470")]
		[FieldOffset(Offset = "0x90")]
		public List<SharedCharData> sharedCharDataFriend;

		// Token: 0x04027471 RID: 160881
		[Token(Token = "0x4027471")]
		[FieldOffset(Offset = "0x98")]
		public FriendMedalBoard medalBoard;

		// Token: 0x02004D96 RID: 19862
		[Token(Token = "0x2004D96")]
		public class NameCardTeamViewModel : IComparable<NameCardViewModel.NameCardTeamViewModel>
		{
			// Token: 0x0601DB7B RID: 121723 RVA: 0x000AC5F0 File Offset: 0x000AA7F0
			[Token(Token = "0x601DB7B")]
			[Address(RVA = "0x17456D0", Offset = "0x17442D0", VA = "0x1817456D0", Slot = "4")]
			public int CompareTo(NameCardViewModel.NameCardTeamViewModel anotherTeam)
			{
				return 0;
			}

			// Token: 0x0601DB7C RID: 121724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB7C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NameCardTeamViewModel()
			{
			}

			// Token: 0x04027472 RID: 160882
			[Token(Token = "0x4027472")]
			[FieldOffset(Offset = "0x10")]
			public HandbookTeamData teamData;

			// Token: 0x04027473 RID: 160883
			[Token(Token = "0x4027473")]
			[FieldOffset(Offset = "0x18")]
			public int teamCount;

			// Token: 0x04027474 RID: 160884
			[Token(Token = "0x4027474")]
			[FieldOffset(Offset = "0x1C")]
			public int totalCount;
		}
	}
}
