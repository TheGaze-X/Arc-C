using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D8A RID: 7562
	[Token(Token = "0x2001D8A")]
	public struct FormulaOrderStruct
	{
		// Token: 0x0600BA8D RID: 47757 RVA: 0x00045C78 File Offset: 0x00043E78
		[Token(Token = "0x600BA8D")]
		[Address(RVA = "0x3372350", Offset = "0x3370F50", VA = "0x183372350")]
		public bool Filter(MFormulaViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0400B9CE RID: 47566
		[Token(Token = "0x400B9CE")]
		[FieldOffset(Offset = "0x0")]
		public int filterMask;

		// Token: 0x0400B9CF RID: 47567
		[Token(Token = "0x400B9CF")]
		[FieldOffset(Offset = "0x4")]
		public FormulaSortType sortType;

		// Token: 0x0400B9D0 RID: 47568
		[Token(Token = "0x400B9D0")]
		[FieldOffset(Offset = "0x8")]
		public BuildingData.FormulaItemType itemType;

		// Token: 0x0400B9D1 RID: 47569
		[Token(Token = "0x400B9D1")]
		[FieldOffset(Offset = "0xC")]
		public bool isInverse;
	}
}
