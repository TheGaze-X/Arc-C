using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054E6 RID: 21734
	[Token(Token = "0x20054E6")]
	public class RoguelikeGoodsViewModel : IHotfixable
	{
		// Token: 0x17004AE6 RID: 19174
		// (get) Token: 0x0601FF78 RID: 130936 RVA: 0x000B3F70 File Offset: 0x000B2170
		[Token(Token = "0x17004AE6")]
		public bool isBankEntry
		{
			[Token(Token = "0x601FF78")]
			[Address(RVA = "0x1A13540", Offset = "0x1A12140", VA = "0x181A13540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004AE7 RID: 19175
		// (get) Token: 0x0601FF79 RID: 130937 RVA: 0x000B3F88 File Offset: 0x000B2188
		[Token(Token = "0x17004AE7")]
		public bool isItem
		{
			[Token(Token = "0x601FF79")]
			[Address(RVA = "0x1A135A0", Offset = "0x1A121A0", VA = "0x181A135A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004AE8 RID: 19176
		// (get) Token: 0x0601FF7A RID: 130938 RVA: 0x000B3FA0 File Offset: 0x000B21A0
		[Token(Token = "0x17004AE8")]
		public bool isLockSlot
		{
			[Token(Token = "0x601FF7A")]
			[Address(RVA = "0x1A13600", Offset = "0x1A12200", VA = "0x181A13600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601FF7B RID: 130939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF7B")]
		[Address(RVA = "0x1A134E0", Offset = "0x1A120E0", VA = "0x181A134E0")]
		public RoguelikeGoodsViewModel()
		{
		}

		// Token: 0x0402B1FE RID: 176638
		[Token(Token = "0x402B1FE")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeGoodsViewModel.GoodsItemType goodsType;

		// Token: 0x0402B1FF RID: 176639
		[Token(Token = "0x402B1FF")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402B200 RID: 176640
		[Token(Token = "0x402B200")]
		[FieldOffset(Offset = "0x20")]
		public int index;

		// Token: 0x0402B201 RID: 176641
		[Token(Token = "0x402B201")]
		[FieldOffset(Offset = "0x28")]
		public string instId;

		// Token: 0x0402B202 RID: 176642
		[Token(Token = "0x402B202")]
		[FieldOffset(Offset = "0x30")]
		public string itemId;

		// Token: 0x0402B203 RID: 176643
		[Token(Token = "0x402B203")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x0402B204 RID: 176644
		[Token(Token = "0x402B204")]
		[FieldOffset(Offset = "0x40")]
		public string usage;

		// Token: 0x0402B205 RID: 176645
		[Token(Token = "0x402B205")]
		[FieldOffset(Offset = "0x48")]
		public string description;

		// Token: 0x0402B206 RID: 176646
		[Token(Token = "0x402B206")]
		[FieldOffset(Offset = "0x50")]
		public RoguelikeGameItemType type;

		// Token: 0x0402B207 RID: 176647
		[Token(Token = "0x402B207")]
		[FieldOffset(Offset = "0x54")]
		public RoguelikeGameItemRarity rarity;

		// Token: 0x0402B208 RID: 176648
		[Token(Token = "0x402B208")]
		[FieldOffset(Offset = "0x58")]
		public string priceId;

		// Token: 0x0402B209 RID: 176649
		[Token(Token = "0x402B209")]
		[FieldOffset(Offset = "0x60")]
		public int price;

		// Token: 0x0402B20A RID: 176650
		[Token(Token = "0x402B20A")]
		[FieldOffset(Offset = "0x68")]
		public string iconId;

		// Token: 0x0402B20B RID: 176651
		[Token(Token = "0x402B20B")]
		[FieldOffset(Offset = "0x70")]
		public bool isAffordable;

		// Token: 0x0402B20C RID: 176652
		[Token(Token = "0x402B20C")]
		[FieldOffset(Offset = "0x71")]
		public bool isSoldout;

		// Token: 0x0402B20D RID: 176653
		[Token(Token = "0x402B20D")]
		[FieldOffset(Offset = "0x72")]
		public bool displayPriceChange;

		// Token: 0x0402B20E RID: 176654
		[Token(Token = "0x402B20E")]
		[FieldOffset(Offset = "0x73")]
		public bool isRecycleGoods;

		// Token: 0x0402B20F RID: 176655
		[Token(Token = "0x402B20F")]
		[FieldOffset(Offset = "0x74")]
		public int originPrice;

		// Token: 0x0402B210 RID: 176656
		[Token(Token = "0x402B210")]
		[FieldOffset(Offset = "0x78")]
		public bool canPut;

		// Token: 0x0402B211 RID: 176657
		[Token(Token = "0x402B211")]
		[FieldOffset(Offset = "0x79")]
		public bool isBankOpen;

		// Token: 0x0402B212 RID: 176658
		[Token(Token = "0x402B212")]
		[FieldOffset(Offset = "0x7C")]
		public int typeSortPriority;

		// Token: 0x0402B213 RID: 176659
		[Token(Token = "0x402B213")]
		[FieldOffset(Offset = "0x80")]
		public int typeGoodPriority;

		// Token: 0x0402B214 RID: 176660
		[Token(Token = "0x402B214")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isBankEntry;

		// Token: 0x0402B215 RID: 176661
		[Token(Token = "0x402B215")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isItem;

		// Token: 0x0402B216 RID: 176662
		[Token(Token = "0x402B216")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isLockSlot;

		// Token: 0x0402B217 RID: 176663
		[Token(Token = "0x402B217")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020054E7 RID: 21735
		[Token(Token = "0x20054E7")]
		public enum GoodsItemType
		{
			// Token: 0x0402B219 RID: 176665
			[Token(Token = "0x402B219")]
			Bank,
			// Token: 0x0402B21A RID: 176666
			[Token(Token = "0x402B21A")]
			Item,
			// Token: 0x0402B21B RID: 176667
			[Token(Token = "0x402B21B")]
			Slot
		}
	}
}
