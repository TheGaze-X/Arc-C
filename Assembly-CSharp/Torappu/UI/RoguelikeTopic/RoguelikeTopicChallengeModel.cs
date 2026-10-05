using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004577 RID: 17783
	[Token(Token = "0x2004577")]
	public class RoguelikeTopicChallengeModel : IHotfixable
	{
		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x0601B146 RID: 110918 RVA: 0x000A4418 File Offset: 0x000A2618
		[Token(Token = "0x17004087")]
		public bool isCompleted
		{
			[Token(Token = "0x601B146")]
			[Address(RVA = "0x14373F0", Offset = "0x1435FF0", VA = "0x1814373F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x0601B147 RID: 110919 RVA: 0x000A4430 File Offset: 0x000A2630
		// (set) Token: 0x0601B148 RID: 110920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004088")]
		public PlayerRoguelikeChallengeStatus challengeStatus
		{
			[Token(Token = "0x601B147")]
			[Address(RVA = "0x1437390", Offset = "0x1435F90", VA = "0x181437390")]
			[CompilerGenerated]
			get
			{
				return PlayerRoguelikeChallengeStatus.LOCKED;
			}
			[Token(Token = "0x601B148")]
			[Address(RVA = "0x14374A0", Offset = "0x14360A0", VA = "0x1814374A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B149 RID: 110921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B149")]
		[Address(RVA = "0x1436E10", Offset = "0x1435A10", VA = "0x181436E10")]
		public void LoadData(string topicId, RoguelikeTopicChallenge challengeData, PlayerRoguelikeV2.OuterData.Challenge playerChallengeData, RoguelikeGameInitData initData, RoguelikeDiceModuleData diceModuleData)
		{
		}

		// Token: 0x0601B14A RID: 110922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B14A")]
		[Address(RVA = "0x14372E0", Offset = "0x1435EE0", VA = "0x1814372E0")]
		public RoguelikeTopicChallengeModel()
		{
		}

		// Token: 0x04022D16 RID: 142614
		[Token(Token = "0x4022D16")]
		[FieldOffset(Offset = "0x10")]
		public string challengeId;

		// Token: 0x04022D17 RID: 142615
		[Token(Token = "0x4022D17")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04022D18 RID: 142616
		[Token(Token = "0x4022D18")]
		[FieldOffset(Offset = "0x20")]
		public string challengeName;

		// Token: 0x04022D19 RID: 142617
		[Token(Token = "0x4022D19")]
		[FieldOffset(Offset = "0x28")]
		public string challengeDesc;

		// Token: 0x04022D1A RID: 142618
		[Token(Token = "0x4022D1A")]
		[FieldOffset(Offset = "0x30")]
		public List<string> challengeConditionDesc;

		// Token: 0x04022D1B RID: 142619
		[Token(Token = "0x4022D1B")]
		[FieldOffset(Offset = "0x38")]
		public List<RoguelikeTopicTaskInfo> taskInfos;

		// Token: 0x04022D1D RID: 142621
		[Token(Token = "0x4022D1D")]
		[FieldOffset(Offset = "0x48")]
		public List<ItemBundle> rewards;

		// Token: 0x04022D1E RID: 142622
		[Token(Token = "0x4022D1E")]
		[FieldOffset(Offset = "0x50")]
		public string challengeUnlockTips;

		// Token: 0x04022D1F RID: 142623
		[Token(Token = "0x4022D1F")]
		[FieldOffset(Offset = "0x58")]
		public string challengeUnlockToast;

		// Token: 0x04022D20 RID: 142624
		[Token(Token = "0x4022D20")]
		[FieldOffset(Offset = "0x60")]
		public int challengeGroupId;

		// Token: 0x04022D21 RID: 142625
		[Token(Token = "0x4022D21")]
		[FieldOffset(Offset = "0x68")]
		public string challengeGroupName;

		// Token: 0x04022D22 RID: 142626
		[Token(Token = "0x4022D22")]
		[FieldOffset(Offset = "0x70")]
		public int initialHp;

		// Token: 0x04022D23 RID: 142627
		[Token(Token = "0x4022D23")]
		[FieldOffset(Offset = "0x74")]
		public int initialPopulation;

		// Token: 0x04022D24 RID: 142628
		[Token(Token = "0x4022D24")]
		[FieldOffset(Offset = "0x78")]
		public int initialGold;

		// Token: 0x04022D25 RID: 142629
		[Token(Token = "0x4022D25")]
		[FieldOffset(Offset = "0x7C")]
		public int initialSquadCapacity;

		// Token: 0x04022D26 RID: 142630
		[Token(Token = "0x4022D26")]
		[FieldOffset(Offset = "0x80")]
		public int initialKey;

		// Token: 0x04022D27 RID: 142631
		[Token(Token = "0x4022D27")]
		[FieldOffset(Offset = "0x84")]
		public int initialDiceCount;

		// Token: 0x04022D28 RID: 142632
		[Token(Token = "0x4022D28")]
		[FieldOffset(Offset = "0x88")]
		public bool isExploring;

		// Token: 0x04022D29 RID: 142633
		[Token(Token = "0x4022D29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCompleted;

		// Token: 0x04022D2A RID: 142634
		[Token(Token = "0x4022D2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_challengeStatus;

		// Token: 0x04022D2B RID: 142635
		[Token(Token = "0x4022D2B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_challengeStatus;

		// Token: 0x04022D2C RID: 142636
		[Token(Token = "0x4022D2C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022D2D RID: 142637
		[Token(Token = "0x4022D2D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
