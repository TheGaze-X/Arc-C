using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CE5 RID: 7397
	[Token(Token = "0x2001CE5")]
	public struct FormulaOrderStruct
	{
		// Token: 0x0600B6D3 RID: 46803 RVA: 0x00045060 File Offset: 0x00043260
		[Token(Token = "0x600B6D3")]
		[Address(RVA = "0x334C4D0", Offset = "0x334B0D0", VA = "0x18334C4D0")]
		public bool Filter(SFormulaViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0400B498 RID: 46232
		[Token(Token = "0x400B498")]
		[FieldOffset(Offset = "0x0")]
		public int filterMask;

		// Token: 0x0400B499 RID: 46233
		[Token(Token = "0x400B499")]
		[FieldOffset(Offset = "0x4")]
		public FormulaSortType sortType;

		// Token: 0x0400B49A RID: 46234
		[Token(Token = "0x400B49A")]
		[FieldOffset(Offset = "0x8")]
		public BuildingData.FormulaItemType formulaType;

		// Token: 0x0400B49B RID: 46235
		[Token(Token = "0x400B49B")]
		[FieldOffset(Offset = "0xC")]
		public bool isInverse;
	}
}
