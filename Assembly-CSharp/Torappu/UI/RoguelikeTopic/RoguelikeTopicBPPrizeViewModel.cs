using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004573 RID: 17779
	[Token(Token = "0x2004573")]
	public class RoguelikeTopicBPPrizeViewModel : IHotfixable
	{
		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x0601B13F RID: 110911 RVA: 0x000A43E8 File Offset: 0x000A25E8
		[Token(Token = "0x17004084")]
		public bool isItemDetailRewardAvail
		{
			[Token(Token = "0x601B13F")]
			[Address(RVA = "0x1431CC0", Offset = "0x14308C0", VA = "0x181431CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x0601B140 RID: 110912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004085")]
		public string itemId
		{
			[Token(Token = "0x601B140")]
			[Address(RVA = "0x1431DA0", Offset = "0x14309A0", VA = "0x181431DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x0601B141 RID: 110913 RVA: 0x000A4400 File Offset: 0x000A2600
		[Token(Token = "0x17004086")]
		public ItemType itemType
		{
			[Token(Token = "0x601B141")]
			[Address(RVA = "0x1431E50", Offset = "0x1430A50", VA = "0x181431E50")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x0601B142 RID: 110914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B142")]
		[Address(RVA = "0x1431C40", Offset = "0x1430840", VA = "0x181431C40")]
		public RoguelikeTopicBPPrizeViewModel()
		{
		}

		// Token: 0x04022D03 RID: 142595
		[Token(Token = "0x4022D03")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<ItemType> SHOW_BTN_ITEM_TYPE;

		// Token: 0x04022D04 RID: 142596
		[Token(Token = "0x4022D04")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicBPGrandPrize roguelikeTopicBpGrandPrize;

		// Token: 0x04022D05 RID: 142597
		[Token(Token = "0x4022D05")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicBP roguelikeTopicBp;

		// Token: 0x04022D06 RID: 142598
		[Token(Token = "0x4022D06")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicBattlePassStyle style;

		// Token: 0x04022D07 RID: 142599
		[Token(Token = "0x4022D07")]
		[FieldOffset(Offset = "0x28")]
		public bool isValid;

		// Token: 0x04022D08 RID: 142600
		[Token(Token = "0x4022D08")]
		[FieldOffset(Offset = "0x29")]
		public bool bpPurchaseAvailable;

		// Token: 0x04022D09 RID: 142601
		[Token(Token = "0x4022D09")]
		[FieldOffset(Offset = "0x2C")]
		public RoguelikeTopicBPPrizeViewModel.RoguelikeTopicBPPrizeState state;

		// Token: 0x04022D0A RID: 142602
		[Token(Token = "0x4022D0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isItemDetailRewardAvail;

		// Token: 0x04022D0B RID: 142603
		[Token(Token = "0x4022D0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x04022D0C RID: 142604
		[Token(Token = "0x4022D0C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04022D0D RID: 142605
		[Token(Token = "0x4022D0D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004574 RID: 17780
		[Token(Token = "0x2004574")]
		public enum RoguelikeTopicBPPrizeState
		{
			// Token: 0x04022D0F RID: 142607
			[Token(Token = "0x4022D0F")]
			CAN_NOT_RECEIVE,
			// Token: 0x04022D10 RID: 142608
			[Token(Token = "0x4022D10")]
			CAN_RECEIVE,
			// Token: 0x04022D11 RID: 142609
			[Token(Token = "0x4022D11")]
			RECEIVED
		}
	}
}
