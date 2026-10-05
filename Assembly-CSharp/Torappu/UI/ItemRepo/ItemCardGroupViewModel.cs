using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E73 RID: 24179
	[Token(Token = "0x2005E73")]
	public class ItemCardGroupViewModel
	{
		// Token: 0x170052FF RID: 21247
		// (get) Token: 0x060230B1 RID: 143537 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060230B2 RID: 143538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052FF")]
		public List<UIItemViewModel> items
		{
			[Token(Token = "0x60230B1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60230B2")]
			[Address(RVA = "0x1D8F060", Offset = "0x1D8DC60", VA = "0x181D8F060")]
			set
			{
			}
		}

		// Token: 0x060230B3 RID: 143539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60230B3")]
		[Address(RVA = "0x1D8EEA0", Offset = "0x1D8DAA0", VA = "0x181D8EEA0")]
		public UIItemViewModel GetTargetItem(int position)
		{
			return null;
		}

		// Token: 0x17005300 RID: 21248
		// (get) Token: 0x060230B4 RID: 143540 RVA: 0x000BFBB0 File Offset: 0x000BDDB0
		// (set) Token: 0x060230B5 RID: 143541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005300")]
		public ClassifyFilter classifyFilter
		{
			[Token(Token = "0x60230B4")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return ClassifyFilter.ALL;
			}
			[Token(Token = "0x60230B5")]
			[Address(RVA = "0x1D8F050", Offset = "0x1D8DC50", VA = "0x181D8F050")]
			set
			{
			}
		}

		// Token: 0x060230B6 RID: 143542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230B6")]
		[Address(RVA = "0x1D8EEF0", Offset = "0x1D8DAF0", VA = "0x181D8EEF0")]
		public void RefreshClassify()
		{
		}

		// Token: 0x060230B7 RID: 143543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230B7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ItemCardGroupViewModel()
		{
		}

		// Token: 0x04030418 RID: 197656
		[Token(Token = "0x4030418")]
		[FieldOffset(Offset = "0x10")]
		private List<UIItemViewModel> m_items;

		// Token: 0x04030419 RID: 197657
		[Token(Token = "0x4030419")]
		[FieldOffset(Offset = "0x18")]
		public List<UIItemViewModel> activeItems;

		// Token: 0x0403041A RID: 197658
		[Token(Token = "0x403041A")]
		[FieldOffset(Offset = "0x20")]
		private ClassifyFilter m_classifyFilter;
	}
}
