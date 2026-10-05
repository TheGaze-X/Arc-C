using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D83 RID: 7555
	[Token(Token = "0x2001D83")]
	public static class Consts
	{
		// Token: 0x0600BA79 RID: 47737 RVA: 0x00045B88 File Offset: 0x00043D88
		[Token(Token = "0x600BA79")]
		[Address(RVA = "0x33717B0", Offset = "0x33703B0", VA = "0x1833717B0")]
		public static int CompareUnlock(MFormulaViewModel a, MFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600BA7A RID: 47738 RVA: 0x00045BA0 File Offset: 0x00043DA0
		[Token(Token = "0x600BA7A")]
		[Address(RVA = "0x33718A0", Offset = "0x33704A0", VA = "0x1833718A0")]
		private static int _CompareRarity(MFormulaViewModel a, MFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600BA7B RID: 47739 RVA: 0x00045BB8 File Offset: 0x00043DB8
		[Token(Token = "0x600BA7B")]
		[Address(RVA = "0x2051E80", Offset = "0x2050A80", VA = "0x182051E80")]
		private static int _CompareTime(MFormulaViewModel a, MFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600BA7C RID: 47740 RVA: 0x00045BD0 File Offset: 0x00043DD0
		[Token(Token = "0x600BA7C")]
		[Address(RVA = "0x3371820", Offset = "0x3370420", VA = "0x183371820")]
		private static int _CompareName(MFormulaViewModel a, MFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600BA7D RID: 47741 RVA: 0x00045BE8 File Offset: 0x00043DE8
		[Token(Token = "0x600BA7D")]
		[Address(RVA = "0x334BE00", Offset = "0x334AA00", VA = "0x18334BE00")]
		private static int _CompareFormulaId(MFormulaViewModel a, MFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600BA7E RID: 47742 RVA: 0x00045C00 File Offset: 0x00043E00
		[Token(Token = "0x600BA7E")]
		[Address(RVA = "0x3371930", Offset = "0x3370530", VA = "0x183371930")]
		private static int _SecCompareRarity(MFormulaViewModel a, MFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600BA7F RID: 47743 RVA: 0x00045C18 File Offset: 0x00043E18
		[Token(Token = "0x600BA7F")]
		[Address(RVA = "0x2051E80", Offset = "0x2050A80", VA = "0x182051E80")]
		private static int _SecCompareTime(MFormulaViewModel a, MFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600BA80 RID: 47744 RVA: 0x00045C30 File Offset: 0x00043E30
		[Token(Token = "0x600BA80")]
		[Address(RVA = "0x334BE00", Offset = "0x334AA00", VA = "0x18334BE00")]
		private static int _SecCompareFormulaId(MFormulaViewModel a, MFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0400B9AC RID: 47532
		[Token(Token = "0x400B9AC")]
		[FieldOffset(Offset = "0x0")]
		public static ListDict<FormulaFilterType, ItemRarity> RARITY_FILTER;

		// Token: 0x0400B9AD RID: 47533
		[Token(Token = "0x400B9AD")]
		[FieldOffset(Offset = "0x8")]
		public static ListDict<FormulaFilterType, KeyValuePair<int, int>> TIME_FILTER;

		// Token: 0x0400B9AE RID: 47534
		[Token(Token = "0x400B9AE")]
		[FieldOffset(Offset = "0x10")]
		public static ListDict<FormulaSortType, Func<MFormulaViewModel, MFormulaViewModel, int>> SORT_LIST;

		// Token: 0x0400B9AF RID: 47535
		[Token(Token = "0x400B9AF")]
		[FieldOffset(Offset = "0x18")]
		public static ListDict<FormulaSortType, Func<MFormulaViewModel, MFormulaViewModel, int>> SECONDARY_SOR_LIST;
	}
}
