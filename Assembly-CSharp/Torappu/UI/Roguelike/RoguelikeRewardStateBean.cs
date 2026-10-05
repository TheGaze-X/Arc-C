using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005410 RID: 21520
	[Token(Token = "0x2005410")]
	public class RoguelikeRewardStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601FA7E RID: 129662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FA7E")]
		[Address(RVA = "0x19634D0", Offset = "0x19620D0", VA = "0x1819634D0")]
		public static RoguelikeRewardEarnViewModel InitWithViewModel(string topicId, RoguelikeStageEarn earn)
		{
			return null;
		}

		// Token: 0x0601FA7F RID: 129663 RVA: 0x000B29E0 File Offset: 0x000B0BE0
		[Token(Token = "0x601FA7F")]
		[Address(RVA = "0x1961400", Offset = "0x1960000", VA = "0x181961400")]
		public static RoguelikeSortItemViewStruct CreateRewardItemViewStruct(string topicId, RoguelikeItemBundle item, RoguelikeRewardExtraInfoFactory factory, out RoguelikeRewardShowType singleShowType)
		{
			return default(RoguelikeSortItemViewStruct);
		}

		// Token: 0x0601FA80 RID: 129664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FA80")]
		[Address(RVA = "0x1962E80", Offset = "0x1961A80", VA = "0x181962E80")]
		public static RoguelikeRewardListViewModel InitRewardWithViewModel(string topicId, List<RoguelikeReward> rewardList, RoguelikeRewardExtraInfoFactory factory, bool showReceiptBtn = true, bool showStoreInfo = true)
		{
			return null;
		}

		// Token: 0x0601FA81 RID: 129665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA81")]
		[Address(RVA = "0x1963A60", Offset = "0x1962660", VA = "0x181963A60")]
		public RoguelikeRewardStateBean()
		{
		}

		// Token: 0x0402AADE RID: 174814
		[Token(Token = "0x402AADE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitWithViewModel;

		// Token: 0x0402AADF RID: 174815
		[Token(Token = "0x402AADF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateRewardItemViewStruct;

		// Token: 0x0402AAE0 RID: 174816
		[Token(Token = "0x402AAE0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitRewardWithViewModel;

		// Token: 0x0402AAE1 RID: 174817
		[Token(Token = "0x402AAE1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
