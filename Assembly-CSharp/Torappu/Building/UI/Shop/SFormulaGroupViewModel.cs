using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CE6 RID: 7398
	[Token(Token = "0x2001CE6")]
	public class SFormulaGroupViewModel
	{
		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x0600B6D4 RID: 46804 RVA: 0x00045078 File Offset: 0x00043278
		// (set) Token: 0x0600B6D5 RID: 46805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015EE")]
		public FormulaOrderStruct orderStruct
		{
			[Token(Token = "0x600B6D4")]
			[Address(RVA = "0x4E6DD0", Offset = "0x4E59D0", VA = "0x1804E6DD0")]
			get
			{
				return default(FormulaOrderStruct);
			}
			[Token(Token = "0x600B6D5")]
			[Address(RVA = "0x334D770", Offset = "0x334C370", VA = "0x18334D770")]
			set
			{
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x0600B6D6 RID: 46806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015EF")]
		public List<SFormulaViewModel> restrictedList
		{
			[Token(Token = "0x600B6D6")]
			[Address(RVA = "0x334D5A0", Offset = "0x334C1A0", VA = "0x18334D5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6D7")]
		[Address(RVA = "0x334D4A0", Offset = "0x334C0A0", VA = "0x18334D4A0")]
		public SFormulaGroupViewModel()
		{
		}

		// Token: 0x0400B49C RID: 46236
		[Token(Token = "0x400B49C")]
		[FieldOffset(Offset = "0x10")]
		private FormulaOrderStruct m_orderStruct;

		// Token: 0x0400B49D RID: 46237
		[Token(Token = "0x400B49D")]
		[FieldOffset(Offset = "0x20")]
		private List<SFormulaViewModel> m_cachedList;

		// Token: 0x0400B49E RID: 46238
		[Token(Token = "0x400B49E")]
		[FieldOffset(Offset = "0x28")]
		private readonly SFormulaViewModel UNSELECTED_FORMULA;

		// Token: 0x0400B49F RID: 46239
		[Token(Token = "0x400B49F")]
		[FieldOffset(Offset = "0x30")]
		public List<SFormulaViewModel> rawFormulas;

		// Token: 0x0400B4A0 RID: 46240
		[Token(Token = "0x400B4A0")]
		[FieldOffset(Offset = "0x38")]
		public string selectedFormulaId;
	}
}
