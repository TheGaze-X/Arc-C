using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CDE RID: 7390
	[Token(Token = "0x2001CDE")]
	public static class Consts
	{
		// Token: 0x0600B6C2 RID: 46786 RVA: 0x00044FA0 File Offset: 0x000431A0
		[Token(Token = "0x600B6C2")]
		[Address(RVA = "0x334BD90", Offset = "0x334A990", VA = "0x18334BD90")]
		public static int CompareUnlock(SFormulaViewModel a, SFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x00044FB8 File Offset: 0x000431B8
		[Token(Token = "0x600B6C3")]
		[Address(RVA = "0x334BF00", Offset = "0x334AB00", VA = "0x18334BF00")]
		private static int _CompareReserve(SFormulaViewModel a, SFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x00044FD0 File Offset: 0x000431D0
		[Token(Token = "0x600B6C4")]
		[Address(RVA = "0x334BE70", Offset = "0x334AA70", VA = "0x18334BE70")]
		private static int _CompareRarity(SFormulaViewModel a, SFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x00044FE8 File Offset: 0x000431E8
		[Token(Token = "0x600B6C5")]
		[Address(RVA = "0x334BE30", Offset = "0x334AA30", VA = "0x18334BE30")]
		private static int _ComparePrice(SFormulaViewModel a, SFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x00045000 File Offset: 0x00043200
		[Token(Token = "0x600B6C6")]
		[Address(RVA = "0x334BF30", Offset = "0x334AB30", VA = "0x18334BF30")]
		private static int _CompareTime(SFormulaViewModel a, SFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x00045018 File Offset: 0x00043218
		[Token(Token = "0x600B6C7")]
		[Address(RVA = "0x334BE00", Offset = "0x334AA00", VA = "0x18334BE00")]
		private static int _CompareFormulaId(SFormulaViewModel a, SFormulaViewModel b)
		{
			return 0;
		}

		// Token: 0x0400B477 RID: 46199
		[Token(Token = "0x400B477")]
		[FieldOffset(Offset = "0x0")]
		public static ListDict<FormulaFilterType, ItemRarity> RARITY_FILTER;

		// Token: 0x0400B478 RID: 46200
		[Token(Token = "0x400B478")]
		[FieldOffset(Offset = "0x8")]
		public static ListDict<FormulaFilterType, KeyValuePair<double, double>> TIME_FILTER;

		// Token: 0x0400B479 RID: 46201
		[Token(Token = "0x400B479")]
		[FieldOffset(Offset = "0x10")]
		public static ListDict<FormulaSortType, Func<SFormulaViewModel, SFormulaViewModel, int>> SORT_LIST;
	}
}
