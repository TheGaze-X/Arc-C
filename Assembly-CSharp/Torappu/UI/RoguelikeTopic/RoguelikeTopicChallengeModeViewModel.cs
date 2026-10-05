using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004578 RID: 17784
	[Token(Token = "0x2004578")]
	public class RoguelikeTopicChallengeModeViewModel : IHotfixable
	{
		// Token: 0x0601B14B RID: 110923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B14B")]
		[Address(RVA = "0x1435430", Offset = "0x1434030", VA = "0x181435430")]
		public void LoadData(string topic, RoguelikeTopicModeViewModel outerModel)
		{
		}

		// Token: 0x0601B14C RID: 110924 RVA: 0x000A4448 File Offset: 0x000A2648
		[Token(Token = "0x601B14C")]
		[Address(RVA = "0x1436250", Offset = "0x1434E50", VA = "0x181436250")]
		public bool SetSelectedChallenge(string challengeId)
		{
			return default(bool);
		}

		// Token: 0x0601B14D RID: 110925 RVA: 0x000A4460 File Offset: 0x000A2660
		[Token(Token = "0x601B14D")]
		[Address(RVA = "0x1435300", Offset = "0x1433F00", VA = "0x181435300")]
		public PlayerRoguelikeChallengeStatus GetSelectedChallengeStatus()
		{
			return PlayerRoguelikeChallengeStatus.LOCKED;
		}

		// Token: 0x0601B14E RID: 110926 RVA: 0x000A4478 File Offset: 0x000A2678
		[Token(Token = "0x601B14E")]
		[Address(RVA = "0x1435210", Offset = "0x1433E10", VA = "0x181435210")]
		public PlayerRoguelikeChallengeStatus GetChallengeStatus(string challengeId)
		{
			return PlayerRoguelikeChallengeStatus.LOCKED;
		}

		// Token: 0x0601B14F RID: 110927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B14F")]
		[Address(RVA = "0x1436330", Offset = "0x1434F30", VA = "0x181436330")]
		private void _InitSelectedChallengeId()
		{
		}

		// Token: 0x0601B150 RID: 110928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B150")]
		[Address(RVA = "0x14364C0", Offset = "0x14350C0", VA = "0x1814364C0")]
		private void _LoadChallengeBookRelated(RoguelikeTopicDetail topicDetail, PlayerRoguelikeV2.OuterData playerData)
		{
		}

		// Token: 0x0601B151 RID: 110929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B151")]
		[Address(RVA = "0x1436770", Offset = "0x1435370", VA = "0x181436770")]
		public RoguelikeTopicChallengeModeViewModel()
		{
		}

		// Token: 0x04022D2E RID: 142638
		[Token(Token = "0x4022D2E")]
		[FieldOffset(Offset = "0x10")]
		public bool isValid;

		// Token: 0x04022D2F RID: 142639
		[Token(Token = "0x4022D2F")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x04022D30 RID: 142640
		[Token(Token = "0x4022D30")]
		[FieldOffset(Offset = "0x20")]
		public string currExploringChallengeId;

		// Token: 0x04022D31 RID: 142641
		[Token(Token = "0x4022D31")]
		[FieldOffset(Offset = "0x28")]
		public string currSelectedChallengeId;

		// Token: 0x04022D32 RID: 142642
		[Token(Token = "0x4022D32")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<string, RoguelikeTopicChallengeModel> challengeList;

		// Token: 0x04022D33 RID: 142643
		[Token(Token = "0x4022D33")]
		[FieldOffset(Offset = "0x38")]
		public string tipButtonName;

		// Token: 0x04022D34 RID: 142644
		[Token(Token = "0x4022D34")]
		[FieldOffset(Offset = "0x40")]
		public string collectionButtonName;

		// Token: 0x04022D35 RID: 142645
		[Token(Token = "0x4022D35")]
		[FieldOffset(Offset = "0x48")]
		public string medalGroupName;

		// Token: 0x04022D36 RID: 142646
		[Token(Token = "0x4022D36")]
		[FieldOffset(Offset = "0x50")]
		public string taskTargetTitleName;

		// Token: 0x04022D37 RID: 142647
		[Token(Token = "0x4022D37")]
		[FieldOffset(Offset = "0x58")]
		public string taskConditionName;

		// Token: 0x04022D38 RID: 142648
		[Token(Token = "0x4022D38")]
		[FieldOffset(Offset = "0x60")]
		public string taskRewardName;

		// Token: 0x04022D39 RID: 142649
		[Token(Token = "0x4022D39")]
		[FieldOffset(Offset = "0x68")]
		public string taskTitleName;

		// Token: 0x04022D3A RID: 142650
		[Token(Token = "0x4022D3A")]
		[FieldOffset(Offset = "0x70")]
		public string taskModeTitleName;

		// Token: 0x04022D3B RID: 142651
		[Token(Token = "0x4022D3B")]
		[FieldOffset(Offset = "0x78")]
		public bool challengeBookAccessible;

		// Token: 0x04022D3C RID: 142652
		[Token(Token = "0x4022D3C")]
		[FieldOffset(Offset = "0x79")]
		public bool challengeBookHasNewItem;

		// Token: 0x04022D3D RID: 142653
		[Token(Token = "0x4022D3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022D3E RID: 142654
		[Token(Token = "0x4022D3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedChallenge;

		// Token: 0x04022D3F RID: 142655
		[Token(Token = "0x4022D3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSelectedChallengeStatus;

		// Token: 0x04022D40 RID: 142656
		[Token(Token = "0x4022D40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetChallengeStatus;

		// Token: 0x04022D41 RID: 142657
		[Token(Token = "0x4022D41")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitSelectedChallengeId;

		// Token: 0x04022D42 RID: 142658
		[Token(Token = "0x4022D42")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadChallengeBookRelated;

		// Token: 0x04022D43 RID: 142659
		[Token(Token = "0x4022D43")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
