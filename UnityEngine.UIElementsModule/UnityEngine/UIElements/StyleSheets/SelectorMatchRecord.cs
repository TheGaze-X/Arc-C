using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x20002F0")]
	internal struct SelectorMatchRecord
	{
		// Token: 0x060014B3 RID: 5299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x5A7BE20", Offset = "0x5A7AA20", VA = "0x185A7BE20")]
		public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack)
		{
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0000B0D0 File Offset: 0x000092D0
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x5A7BCB0", Offset = "0x5A7A8B0", VA = "0x185A7BCB0")]
		public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b)
		{
			return 0;
		}

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x0")]
		public StyleSheet sheet;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x8")]
		public int styleSheetIndexInStack;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0x10")]
		public StyleComplexSelector complexSelector;
	}
}
