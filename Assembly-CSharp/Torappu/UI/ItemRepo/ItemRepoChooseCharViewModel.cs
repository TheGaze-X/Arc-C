using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ChooseChar;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E76 RID: 24182
	[Token(Token = "0x2005E76")]
	public class ItemRepoChooseCharViewModel : IHotfixable
	{
		// Token: 0x17005301 RID: 21249
		// (get) Token: 0x060230B9 RID: 143545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005301")]
		public List<ItemBundle> itemList
		{
			[Token(Token = "0x60230B9")]
			[Address(RVA = "0x1D92FA0", Offset = "0x1D91BA0", VA = "0x181D92FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005302 RID: 21250
		// (get) Token: 0x060230BA RID: 143546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005302")]
		public List<ItemRepoChooseCharViewModel.ChooseCharItem> ownedStandardItemList
		{
			[Token(Token = "0x60230BA")]
			[Address(RVA = "0x1D93120", Offset = "0x1D91D20", VA = "0x181D93120")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005303 RID: 21251
		// (get) Token: 0x060230BB RID: 143547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005303")]
		public List<ItemRepoChooseCharViewModel.ChooseCharItem> ownedClassicItemList
		{
			[Token(Token = "0x60230BB")]
			[Address(RVA = "0x1D930C0", Offset = "0x1D91CC0", VA = "0x181D930C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005304 RID: 21252
		// (get) Token: 0x060230BC RID: 143548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005304")]
		public List<ItemRepoChooseCharViewModel.ChooseCharItem> notOwnedStandardItemList
		{
			[Token(Token = "0x60230BC")]
			[Address(RVA = "0x1D93060", Offset = "0x1D91C60", VA = "0x181D93060")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005305 RID: 21253
		// (get) Token: 0x060230BD RID: 143549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005305")]
		public List<ItemRepoChooseCharViewModel.ChooseCharItem> notOwnedClassicItemList
		{
			[Token(Token = "0x60230BD")]
			[Address(RVA = "0x1D93000", Offset = "0x1D91C00", VA = "0x181D93000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005306 RID: 21254
		// (get) Token: 0x060230BE RID: 143550 RVA: 0x000BFBC8 File Offset: 0x000BDDC8
		[Token(Token = "0x17005306")]
		public VoucherDisplayType displayType
		{
			[Token(Token = "0x60230BE")]
			[Address(RVA = "0x1D92F40", Offset = "0x1D91B40", VA = "0x181D92F40")]
			get
			{
				return VoucherDisplayType.NONE;
			}
		}

		// Token: 0x060230BF RID: 143551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230BF")]
		[Address(RVA = "0x1D92190", Offset = "0x1D90D90", VA = "0x181D92190")]
		public void LoadData(List<ItemBundle> itemBundles, VoucherDisplayType displayType = VoucherDisplayType.NONE, bool generateSortedItemList = false)
		{
		}

		// Token: 0x060230C0 RID: 143552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230C0")]
		[Address(RVA = "0x1D92D80", Offset = "0x1D91980", VA = "0x181D92D80")]
		private void _SortCharList(List<ItemRepoChooseCharViewModel.ChooseCharItem> charItems)
		{
		}

		// Token: 0x060230C1 RID: 143553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230C1")]
		[Address(RVA = "0x1D92530", Offset = "0x1D91130", VA = "0x181D92530")]
		private void _GenerateSortedItems()
		{
		}

		// Token: 0x060230C2 RID: 143554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230C2")]
		[Address(RVA = "0x1D92B50", Offset = "0x1D91750", VA = "0x181D92B50")]
		private void _LoadItem(string charId, CharacterData charData, bool classicItemDistinguishable)
		{
		}

		// Token: 0x060230C3 RID: 143555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230C3")]
		[Address(RVA = "0x1D92EE0", Offset = "0x1D91AE0", VA = "0x181D92EE0")]
		public ItemRepoChooseCharViewModel()
		{
		}

		// Token: 0x04030420 RID: 197664
		[Token(Token = "0x4030420")]
		[FieldOffset(Offset = "0x10")]
		private List<ItemBundle> m_itemList;

		// Token: 0x04030421 RID: 197665
		[Token(Token = "0x4030421")]
		[FieldOffset(Offset = "0x18")]
		private List<ItemRepoChooseCharViewModel.ChooseCharItem> m_ownedStandardCharList;

		// Token: 0x04030422 RID: 197666
		[Token(Token = "0x4030422")]
		[FieldOffset(Offset = "0x20")]
		private List<ItemRepoChooseCharViewModel.ChooseCharItem> m_ownedClassicCharList;

		// Token: 0x04030423 RID: 197667
		[Token(Token = "0x4030423")]
		[FieldOffset(Offset = "0x28")]
		private List<ItemRepoChooseCharViewModel.ChooseCharItem> m_notOwnedStandardCharList;

		// Token: 0x04030424 RID: 197668
		[Token(Token = "0x4030424")]
		[FieldOffset(Offset = "0x30")]
		private List<ItemRepoChooseCharViewModel.ChooseCharItem> m_notOwnedClassicCharList;

		// Token: 0x04030425 RID: 197669
		[Token(Token = "0x4030425")]
		[FieldOffset(Offset = "0x38")]
		private VoucherDisplayType m_displayType;

		// Token: 0x04030426 RID: 197670
		[Token(Token = "0x4030426")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemList;

		// Token: 0x04030427 RID: 197671
		[Token(Token = "0x4030427")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ownedStandardItemList;

		// Token: 0x04030428 RID: 197672
		[Token(Token = "0x4030428")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ownedClassicItemList;

		// Token: 0x04030429 RID: 197673
		[Token(Token = "0x4030429")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_notOwnedStandardItemList;

		// Token: 0x0403042A RID: 197674
		[Token(Token = "0x403042A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_notOwnedClassicItemList;

		// Token: 0x0403042B RID: 197675
		[Token(Token = "0x403042B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_displayType;

		// Token: 0x0403042C RID: 197676
		[Token(Token = "0x403042C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403042D RID: 197677
		[Token(Token = "0x403042D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SortCharList;

		// Token: 0x0403042E RID: 197678
		[Token(Token = "0x403042E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateSortedItems;

		// Token: 0x0403042F RID: 197679
		[Token(Token = "0x403042F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadItem;

		// Token: 0x04030430 RID: 197680
		[Token(Token = "0x4030430")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E77 RID: 24183
		[Token(Token = "0x2005E77")]
		public struct ChooseCharItem : ICommonChooseCharCardViewModel, IHotfixable
		{
			// Token: 0x060230C4 RID: 143556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60230C4")]
			[Address(RVA = "0x1D8EA00", Offset = "0x1D8D600", VA = "0x181D8EA00", Slot = "4")]
			public string GetCharId()
			{
				return null;
			}

			// Token: 0x060230C5 RID: 143557 RVA: 0x000BFBE0 File Offset: 0x000BDDE0
			[Token(Token = "0x60230C5")]
			[Address(RVA = "0x1D8EB80", Offset = "0x1D8D780", VA = "0x181D8EB80", Slot = "5")]
			public bool IsOwned()
			{
				return default(bool);
			}

			// Token: 0x060230C6 RID: 143558 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60230C6")]
			[Address(RVA = "0x1D8E980", Offset = "0x1D8D580", VA = "0x181D8E980", Slot = "6")]
			public CharacterData GetCharData()
			{
				return null;
			}

			// Token: 0x060230C7 RID: 143559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60230C7")]
			[Address(RVA = "0x1D8EA80", Offset = "0x1D8D680", VA = "0x181D8EA80", Slot = "7")]
			public PlayerCharacter GetPlayerCharacter()
			{
				return null;
			}

			// Token: 0x060230C8 RID: 143560 RVA: 0x000BFBF8 File Offset: 0x000BDDF8
			[Token(Token = "0x60230C8")]
			[Address(RVA = "0x1D8EB00", Offset = "0x1D8D700", VA = "0x181D8EB00", Slot = "8")]
			public bool IsClickable()
			{
				return default(bool);
			}

			// Token: 0x04030431 RID: 197681
			[Token(Token = "0x4030431")]
			[FieldOffset(Offset = "0x0")]
			public string charId;

			// Token: 0x04030432 RID: 197682
			[Token(Token = "0x4030432")]
			[FieldOffset(Offset = "0x8")]
			public CharacterData characterData;

			// Token: 0x04030433 RID: 197683
			[Token(Token = "0x4030433")]
			[FieldOffset(Offset = "0x10")]
			public PlayerCharacter playerCharacter;

			// Token: 0x04030434 RID: 197684
			[Token(Token = "0x4030434")]
			[FieldOffset(Offset = "0x18")]
			public RarityRank rarity;

			// Token: 0x04030435 RID: 197685
			[Token(Token = "0x4030435")]
			[FieldOffset(Offset = "0x1C")]
			public int potentialRank;

			// Token: 0x04030436 RID: 197686
			[Token(Token = "0x4030436")]
			[FieldOffset(Offset = "0x20")]
			public bool isClickable;

			// Token: 0x04030437 RID: 197687
			[Token(Token = "0x4030437")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetCharId;

			// Token: 0x04030438 RID: 197688
			[Token(Token = "0x4030438")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsOwned;

			// Token: 0x04030439 RID: 197689
			[Token(Token = "0x4030439")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetCharData;

			// Token: 0x0403043A RID: 197690
			[Token(Token = "0x403043A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPlayerCharacter;

			// Token: 0x0403043B RID: 197691
			[Token(Token = "0x403043B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsClickable;
		}
	}
}
