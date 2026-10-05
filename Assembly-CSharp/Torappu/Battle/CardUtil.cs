using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021BE RID: 8638
	[Token(Token = "0x20021BE")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CardUtil
	{
		// Token: 0x0600D7AA RID: 55210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7AA")]
		[Address(RVA = "0x35BEF60", Offset = "0x35BDB60", VA = "0x1835BEF60")]
		public static void CollectBySelectOrderSelectorList(ref List<Deck.Card> resultCards, PlayerSide side, List<CardUtil.SelectOrderSelector> selectors, Deck.Card sourceCard, int targetCnt)
		{
		}

		// Token: 0x0600D7AB RID: 55211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7AB")]
		[Address(RVA = "0x35BF160", Offset = "0x35BDD60", VA = "0x1835BF160")]
		public static void CollectBySelectOrderSelector(ref List<Deck.Card> resultCards, PlayerSide side, CardUtil.SelectOrderSelector selector, Deck.Card sourceCard)
		{
		}

		// Token: 0x0600D7AC RID: 55212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7AC")]
		[Address(RVA = "0x35BF540", Offset = "0x35BE140", VA = "0x1835BF540")]
		public static void CollectBySelectOrder(ref List<Deck.Card> resultCards, int selectCount, PlayerSide side, CardUtil.SelectOrderMask selectOrderMask, DeckSelector selector, Deck.Card sourceCard)
		{
		}

		// Token: 0x0600D7AD RID: 55213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7AD")]
		[Address(RVA = "0x35BED80", Offset = "0x35BD980", VA = "0x1835BED80")]
		public static void CollectByDeckSelector(ref List<Deck.Card> cards, Deck.Card sourceCard, DeckSelector selector)
		{
		}

		// Token: 0x0600D7AE RID: 55214 RVA: 0x0004DF40 File Offset: 0x0004C140
		[Token(Token = "0x600D7AE")]
		[Address(RVA = "0x35BFB00", Offset = "0x35BE700", VA = "0x1835BFB00")]
		private static bool _IsInOrder(int maxCnt, CardUtil.OrderParam param, CardUtil.SelectOrder selectOrder, int currentIndex, List<Deck.Card> cards)
		{
			return default(bool);
		}

		// Token: 0x0600D7AF RID: 55215 RVA: 0x0004DF58 File Offset: 0x0004C158
		[Token(Token = "0x600D7AF")]
		[Address(RVA = "0x35BF980", Offset = "0x35BE580", VA = "0x1835BF980")]
		private static bool _IsInOrderMask(int maxCnt, CardUtil.OrderParam param, CardUtil.SelectOrderMask selectOrderMask, int currentIndex, List<Deck.Card> cards)
		{
			return default(bool);
		}

		// Token: 0x0400E825 RID: 59429
		[Token(Token = "0x400E825")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CollectBySelectOrderSelectorList;

		// Token: 0x0400E826 RID: 59430
		[Token(Token = "0x400E826")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CollectBySelectOrderSelector;

		// Token: 0x0400E827 RID: 59431
		[Token(Token = "0x400E827")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CollectBySelectOrder;

		// Token: 0x0400E828 RID: 59432
		[Token(Token = "0x400E828")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CollectByDeckSelector;

		// Token: 0x0400E829 RID: 59433
		[Token(Token = "0x400E829")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsInOrder;

		// Token: 0x0400E82A RID: 59434
		[Token(Token = "0x400E82A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsInOrderMask;

		// Token: 0x020021BF RID: 8639
		[Token(Token = "0x20021BF")]
		[Serializable]
		public class SelectOrderSelector
		{
			// Token: 0x0600D7B0 RID: 55216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D7B0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SelectOrderSelector()
			{
			}

			// Token: 0x0400E82B RID: 59435
			[Token(Token = "0x400E82B")]
			[FieldOffset(Offset = "0x10")]
			public CardUtil.SelectOrderMask selectOrder;

			// Token: 0x0400E82C RID: 59436
			[Token(Token = "0x400E82C")]
			[FieldOffset(Offset = "0x18")]
			public DeckSelector deckSelector;
		}

		// Token: 0x020021C0 RID: 8640
		[Token(Token = "0x20021C0")]
		public enum SelectOrder
		{
			// Token: 0x0400E82E RID: 59438
			[Token(Token = "0x400E82E")]
			NONE,
			// Token: 0x0400E82F RID: 59439
			[Token(Token = "0x400E82F")]
			FROM_LEFT,
			// Token: 0x0400E830 RID: 59440
			[Token(Token = "0x400E830")]
			MIDDLE,
			// Token: 0x0400E831 RID: 59441
			[Token(Token = "0x400E831")]
			FROM_RIGHT,
			// Token: 0x0400E832 RID: 59442
			[Token(Token = "0x400E832")]
			NEXT_TO_RIGHT,
			// Token: 0x0400E833 RID: 59443
			[Token(Token = "0x400E833")]
			NEXT_TO_LEFT,
			// Token: 0x0400E834 RID: 59444
			[Token(Token = "0x400E834")]
			ENUM
		}

		// Token: 0x020021C1 RID: 8641
		[Token(Token = "0x20021C1")]
		public enum SelectOrderMask
		{
			// Token: 0x0400E836 RID: 59446
			[Token(Token = "0x400E836")]
			NONE,
			// Token: 0x0400E837 RID: 59447
			[Token(Token = "0x400E837")]
			FROM_LEFT = 2,
			// Token: 0x0400E838 RID: 59448
			[Token(Token = "0x400E838")]
			MIDDLE = 4,
			// Token: 0x0400E839 RID: 59449
			[Token(Token = "0x400E839")]
			FROM_RIGHT = 8,
			// Token: 0x0400E83A RID: 59450
			[Token(Token = "0x400E83A")]
			NEXT_TO_RIGHT = 16,
			// Token: 0x0400E83B RID: 59451
			[Token(Token = "0x400E83B")]
			NEXT_TO_LEFT = 32,
			// Token: 0x0400E83C RID: 59452
			[Token(Token = "0x400E83C")]
			NEXT_TO = 48,
			// Token: 0x0400E83D RID: 59453
			[Token(Token = "0x400E83D")]
			FROM_LEFT_OR_RIGHT = 10
		}

		// Token: 0x020021C2 RID: 8642
		[Token(Token = "0x20021C2")]
		public struct OrderParam
		{
			// Token: 0x0400E83E RID: 59454
			[Token(Token = "0x400E83E")]
			[FieldOffset(Offset = "0x0")]
			public int cnt;

			// Token: 0x0400E83F RID: 59455
			[Token(Token = "0x400E83F")]
			[FieldOffset(Offset = "0x8")]
			public Deck.Card sourceCard;
		}
	}
}
