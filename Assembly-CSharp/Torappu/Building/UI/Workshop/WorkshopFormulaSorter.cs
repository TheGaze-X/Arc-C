using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BD5 RID: 7125
	[Token(Token = "0x2001BD5")]
	public class WorkshopFormulaSorter
	{
		// Token: 0x0600B1C8 RID: 45512 RVA: 0x00043EF0 File Offset: 0x000420F0
		[Token(Token = "0x600B1C8")]
		[Address(RVA = "0x32D2DB0", Offset = "0x32D19B0", VA = "0x1832D2DB0")]
		private static int _SortingKeyRarity(IWorkshopFormula formula)
		{
			return 0;
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x00043F08 File Offset: 0x00042108
		[Token(Token = "0x600B1C9")]
		[Address(RVA = "0x32D2D60", Offset = "0x32D1960", VA = "0x1832D2D60")]
		private static int _SortingKeyPrice(IWorkshopFormula formula)
		{
			return 0;
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x00043F20 File Offset: 0x00042120
		[Token(Token = "0x600B1CA")]
		[Address(RVA = "0x32D2D10", Offset = "0x32D1910", VA = "0x1832D2D10")]
		private static int _SortingKeyId(IWorkshopFormula formula)
		{
			return 0;
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x00043F38 File Offset: 0x00042138
		[Token(Token = "0x600B1CB")]
		[Address(RVA = "0x32D2E30", Offset = "0x32D1A30", VA = "0x1832D2E30")]
		private static int _SortingKeySortId(IWorkshopFormula formula)
		{
			return 0;
		}

		// Token: 0x0600B1CC RID: 45516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1CC")]
		[Address(RVA = "0x32D2C60", Offset = "0x32D1860", VA = "0x1832D2C60")]
		private static Func<IWorkshopFormula, IWorkshopFormula, int> _GetSortingFunctionBySortingKeyFunction(params KeyValuePair<WorkshopFormulaSorter.SortingMethod, Func<IWorkshopFormula, int>>[] compPairs)
		{
			return null;
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1CD")]
		[Address(RVA = "0x32D2630", Offset = "0x32D1230", VA = "0x1832D2630")]
		public Func<IWorkshopFormula, IWorkshopFormula, int> GetSortingFunction(WorkshopFormulaSorter.WorkshopSortingOption option, WorkshopFormulaSorter.SortingMethod method)
		{
			return null;
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1CE")]
		[Address(RVA = "0x32D2E80", Offset = "0x32D1A80", VA = "0x1832D2E80")]
		public WorkshopFormulaSorter()
		{
		}

		// Token: 0x0400AC55 RID: 44117
		[Token(Token = "0x400AC55")]
		[FieldOffset(Offset = "0x10")]
		private List<WorkshopFormulaSorter.CacheItem<IWorkshopFormula>> m_cacheList;

		// Token: 0x02001BD6 RID: 7126
		[Token(Token = "0x2001BD6")]
		public enum WorkshopSortingOption
		{
			// Token: 0x0400AC57 RID: 44119
			[Token(Token = "0x400AC57")]
			RARITY,
			// Token: 0x0400AC58 RID: 44120
			[Token(Token = "0x400AC58")]
			PRICE,
			// Token: 0x0400AC59 RID: 44121
			[Token(Token = "0x400AC59")]
			ID_ORDER,
			// Token: 0x0400AC5A RID: 44122
			[Token(Token = "0x400AC5A")]
			ENUM_COUNT
		}

		// Token: 0x02001BD7 RID: 7127
		[Token(Token = "0x2001BD7")]
		public enum SortingMethod
		{
			// Token: 0x0400AC5C RID: 44124
			[Token(Token = "0x400AC5C")]
			ASCENT,
			// Token: 0x0400AC5D RID: 44125
			[Token(Token = "0x400AC5D")]
			DESCENT,
			// Token: 0x0400AC5E RID: 44126
			[Token(Token = "0x400AC5E")]
			ENUM_COUNT
		}

		// Token: 0x02001BD8 RID: 7128
		[Token(Token = "0x2001BD8")]
		private class CacheItem<T>
		{
			// Token: 0x0600B1CF RID: 45519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1CF")]
			public CacheItem()
			{
			}

			// Token: 0x0400AC5F RID: 44127
			[Token(Token = "0x400AC5F")]
			[FieldOffset(Offset = "0x0")]
			public WorkshopFormulaSorter.WorkshopSortingOption option;

			// Token: 0x0400AC60 RID: 44128
			[Token(Token = "0x400AC60")]
			[FieldOffset(Offset = "0x0")]
			public WorkshopFormulaSorter.SortingMethod method;

			// Token: 0x0400AC61 RID: 44129
			[Token(Token = "0x400AC61")]
			[FieldOffset(Offset = "0x0")]
			public Func<T, T, int> func;
		}
	}
}
