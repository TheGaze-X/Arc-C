using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E7A RID: 24186
	[Token(Token = "0x2005E7A")]
	public class ItemRepoIssueVoucherViewModel : IHotfixable
	{
		// Token: 0x17005307 RID: 21255
		// (get) Token: 0x060230CD RID: 143565 RVA: 0x000BFC28 File Offset: 0x000BDE28
		// (set) Token: 0x060230CE RID: 143566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005307")]
		public bool needReset
		{
			[Token(Token = "0x60230CD")]
			[Address(RVA = "0x1D97240", Offset = "0x1D95E40", VA = "0x181D97240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60230CE")]
			[Address(RVA = "0x1D977D0", Offset = "0x1D963D0", VA = "0x181D977D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005308 RID: 21256
		// (get) Token: 0x060230CF RID: 143567 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060230D0 RID: 143568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005308")]
		public UIItemViewModel voucherItemModel
		{
			[Token(Token = "0x60230CF")]
			[Address(RVA = "0x1D974B0", Offset = "0x1D960B0", VA = "0x181D974B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60230D0")]
			[Address(RVA = "0x1D97840", Offset = "0x1D96440", VA = "0x181D97840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005309 RID: 21257
		// (get) Token: 0x060230D1 RID: 143569 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060230D2 RID: 143570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005309")]
		public List<ItemRepoIssueVoucherItemViewModel> chooseItems
		{
			[Token(Token = "0x60230D1")]
			[Address(RVA = "0x1D97060", Offset = "0x1D95C60", VA = "0x181D97060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60230D2")]
			[Address(RVA = "0x1D97580", Offset = "0x1D96180", VA = "0x181D97580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700530A RID: 21258
		// (get) Token: 0x060230D3 RID: 143571 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060230D4 RID: 143572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700530A")]
		public ItemRepoIssueVoucherItemViewModel inputItem
		{
			[Token(Token = "0x60230D3")]
			[Address(RVA = "0x1D97120", Offset = "0x1D95D20", VA = "0x181D97120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60230D4")]
			[Address(RVA = "0x1D97670", Offset = "0x1D96270", VA = "0x181D97670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700530B RID: 21259
		// (get) Token: 0x060230D5 RID: 143573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700530B")]
		public List<ItemRepoIssueVoucherItemViewModel> outputItems
		{
			[Token(Token = "0x60230D5")]
			[Address(RVA = "0x1D972A0", Offset = "0x1D95EA0", VA = "0x181D972A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700530C RID: 21260
		// (get) Token: 0x060230D6 RID: 143574 RVA: 0x000BFC40 File Offset: 0x000BDE40
		// (set) Token: 0x060230D7 RID: 143575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700530C")]
		public bool isOutputItemsDirty
		{
			[Token(Token = "0x60230D6")]
			[Address(RVA = "0x1D971E0", Offset = "0x1D95DE0", VA = "0x181D971E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60230D7")]
			[Address(RVA = "0x1D97760", Offset = "0x1D96360", VA = "0x181D97760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700530D RID: 21261
		// (get) Token: 0x060230D8 RID: 143576 RVA: 0x000BFC58 File Offset: 0x000BDE58
		// (set) Token: 0x060230D9 RID: 143577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700530D")]
		public bool isChoosing
		{
			[Token(Token = "0x60230D8")]
			[Address(RVA = "0x1D97180", Offset = "0x1D95D80", VA = "0x181D97180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60230D9")]
			[Address(RVA = "0x1D976F0", Offset = "0x1D962F0", VA = "0x181D976F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700530E RID: 21262
		// (get) Token: 0x060230DA RID: 143578 RVA: 0x000BFC70 File Offset: 0x000BDE70
		// (set) Token: 0x060230DB RID: 143579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700530E")]
		public int chooseLimit
		{
			[Token(Token = "0x60230DA")]
			[Address(RVA = "0x1D970C0", Offset = "0x1D95CC0", VA = "0x181D970C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60230DB")]
			[Address(RVA = "0x1D97600", Offset = "0x1D96200", VA = "0x181D97600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700530F RID: 21263
		// (get) Token: 0x060230DC RID: 143580 RVA: 0x000BFC88 File Offset: 0x000BDE88
		// (set) Token: 0x060230DD RID: 143581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700530F")]
		public int chooseCount
		{
			[Token(Token = "0x60230DC")]
			[Address(RVA = "0x1D97000", Offset = "0x1D95C00", VA = "0x181D97000")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60230DD")]
			[Address(RVA = "0x1D97510", Offset = "0x1D96110", VA = "0x181D97510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060230DE RID: 143582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230DE")]
		[Address(RVA = "0x1D95E20", Offset = "0x1D94A20", VA = "0x181D95E20")]
		public void LoadData(ItemRepoIssueVoucherViewModel.Option option)
		{
		}

		// Token: 0x060230DF RID: 143583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230DF")]
		[Address(RVA = "0x1D96600", Offset = "0x1D95200", VA = "0x181D96600")]
		public void SelectItem(int index, int count)
		{
		}

		// Token: 0x060230E0 RID: 143584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60230E0")]
		[Address(RVA = "0x1D95C00", Offset = "0x1D94800", VA = "0x181D95C00")]
		public List<OptionalChoiceItem> GetOptionalChoiceItemList()
		{
			return null;
		}

		// Token: 0x060230E1 RID: 143585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230E1")]
		[Address(RVA = "0x1D96D20", Offset = "0x1D95920", VA = "0x181D96D20")]
		private void _UpdateSelectedItemInOutput(ItemRepoIssueVoucherItemViewModel selectItem)
		{
		}

		// Token: 0x060230E2 RID: 143586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230E2")]
		[Address(RVA = "0x1D96B70", Offset = "0x1D95770", VA = "0x181D96B70")]
		private void _UpdateOutputItemsIfNecessary()
		{
		}

		// Token: 0x060230E3 RID: 143587 RVA: 0x000BFCA0 File Offset: 0x000BDEA0
		[Token(Token = "0x60230E3")]
		[Address(RVA = "0x1D96A40", Offset = "0x1D95640", VA = "0x181D96A40")]
		private static int _ItemComparison(ItemRepoIssueVoucherItemViewModel x, ItemRepoIssueVoucherItemViewModel y)
		{
			return 0;
		}

		// Token: 0x060230E4 RID: 143588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230E4")]
		[Address(RVA = "0x1D96EF0", Offset = "0x1D95AF0", VA = "0x181D96EF0")]
		public ItemRepoIssueVoucherViewModel()
		{
		}

		// Token: 0x04030445 RID: 197701
		[Token(Token = "0x4030445")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, ItemRepoIssueVoucherItemViewModel> m_itemOfOutput;

		// Token: 0x04030446 RID: 197702
		[Token(Token = "0x4030446")]
		[FieldOffset(Offset = "0x18")]
		private List<ItemRepoIssueVoucherItemViewModel> m_outputItems;

		// Token: 0x0403044F RID: 197711
		[Token(Token = "0x403044F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needReset;

		// Token: 0x04030450 RID: 197712
		[Token(Token = "0x4030450")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_needReset;

		// Token: 0x04030451 RID: 197713
		[Token(Token = "0x4030451")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_voucherItemModel;

		// Token: 0x04030452 RID: 197714
		[Token(Token = "0x4030452")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_voucherItemModel;

		// Token: 0x04030453 RID: 197715
		[Token(Token = "0x4030453")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_chooseItems;

		// Token: 0x04030454 RID: 197716
		[Token(Token = "0x4030454")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_chooseItems;

		// Token: 0x04030455 RID: 197717
		[Token(Token = "0x4030455")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_inputItem;

		// Token: 0x04030456 RID: 197718
		[Token(Token = "0x4030456")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_inputItem;

		// Token: 0x04030457 RID: 197719
		[Token(Token = "0x4030457")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_outputItems;

		// Token: 0x04030458 RID: 197720
		[Token(Token = "0x4030458")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isOutputItemsDirty;

		// Token: 0x04030459 RID: 197721
		[Token(Token = "0x4030459")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_isOutputItemsDirty;

		// Token: 0x0403045A RID: 197722
		[Token(Token = "0x403045A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isChoosing;

		// Token: 0x0403045B RID: 197723
		[Token(Token = "0x403045B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_isChoosing;

		// Token: 0x0403045C RID: 197724
		[Token(Token = "0x403045C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_chooseLimit;

		// Token: 0x0403045D RID: 197725
		[Token(Token = "0x403045D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_chooseLimit;

		// Token: 0x0403045E RID: 197726
		[Token(Token = "0x403045E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_chooseCount;

		// Token: 0x0403045F RID: 197727
		[Token(Token = "0x403045F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_chooseCount;

		// Token: 0x04030460 RID: 197728
		[Token(Token = "0x4030460")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030461 RID: 197729
		[Token(Token = "0x4030461")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x04030462 RID: 197730
		[Token(Token = "0x4030462")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetOptionalChoiceItemList;

		// Token: 0x04030463 RID: 197731
		[Token(Token = "0x4030463")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateSelectedItemInOutput;

		// Token: 0x04030464 RID: 197732
		[Token(Token = "0x4030464")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__UpdateOutputItemsIfNecessary;

		// Token: 0x04030465 RID: 197733
		[Token(Token = "0x4030465")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ItemComparison;

		// Token: 0x04030466 RID: 197734
		[Token(Token = "0x4030466")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E7B RID: 24187
		[Token(Token = "0x2005E7B")]
		public class Option
		{
			// Token: 0x060230E5 RID: 143589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60230E5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04030467 RID: 197735
			[Token(Token = "0x4030467")]
			[FieldOffset(Offset = "0x10")]
			public UIItemViewModel voucherItem;

			// Token: 0x04030468 RID: 197736
			[Token(Token = "0x4030468")]
			[FieldOffset(Offset = "0x18")]
			public OptionalVoucherInfo optionalVoucherInfo;

			// Token: 0x04030469 RID: 197737
			[Token(Token = "0x4030469")]
			[FieldOffset(Offset = "0x20")]
			public string requireItemId;

			// Token: 0x0403046A RID: 197738
			[Token(Token = "0x403046A")]
			[FieldOffset(Offset = "0x28")]
			public long requireItemCount;
		}
	}
}
