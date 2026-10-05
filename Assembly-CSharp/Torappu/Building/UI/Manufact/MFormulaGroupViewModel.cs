using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D8B RID: 7563
	[Token(Token = "0x2001D8B")]
	public class MFormulaGroupViewModel
	{
		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x0600BA8E RID: 47758 RVA: 0x00045C90 File Offset: 0x00043E90
		// (set) Token: 0x0600BA8F RID: 47759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700169E")]
		public FormulaOrderStruct orderStruct
		{
			[Token(Token = "0x600BA8E")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			get
			{
				return default(FormulaOrderStruct);
			}
			[Token(Token = "0x600BA8F")]
			[Address(RVA = "0x3373310", Offset = "0x3371F10", VA = "0x183373310")]
			set
			{
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x0600BA90 RID: 47760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700169F")]
		public List<MFormulaViewModel> restrictedList
		{
			[Token(Token = "0x600BA90")]
			[Address(RVA = "0x3373160", Offset = "0x3371D60", VA = "0x183373160")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BA91 RID: 47761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA91")]
		[Address(RVA = "0x3372CE0", Offset = "0x33718E0", VA = "0x183372CE0")]
		public void LoadRawFormulas(ManufactInfoViewModel manufactInfo)
		{
		}

		// Token: 0x0600BA92 RID: 47762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA92")]
		[Address(RVA = "0x33730B0", Offset = "0x3371CB0", VA = "0x1833730B0")]
		public MFormulaGroupViewModel()
		{
		}

		// Token: 0x0400B9D2 RID: 47570
		[Token(Token = "0x400B9D2")]
		[FieldOffset(Offset = "0x10")]
		private List<MFormulaViewModel> rawFormulas;

		// Token: 0x0400B9D3 RID: 47571
		[Token(Token = "0x400B9D3")]
		[FieldOffset(Offset = "0x18")]
		private FormulaOrderStruct m_orderStruct;

		// Token: 0x0400B9D4 RID: 47572
		[Token(Token = "0x400B9D4")]
		[FieldOffset(Offset = "0x28")]
		private List<MFormulaViewModel> m_cachedList;

		// Token: 0x0400B9D5 RID: 47573
		[Token(Token = "0x400B9D5")]
		[FieldOffset(Offset = "0x30")]
		public string selectedItemId;
	}
}
