using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	internal static class StyleSheetCache
	{
		// Token: 0x060014B9 RID: 5305 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x5A84F30", Offset = "0x5A83B30", VA = "0x185A84F30")]
		internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex)
		{
			return null;
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x5A85110", Offset = "0x5A83D10", VA = "0x185A85110")]
		internal static StylePropertyId[] GetPropertyIds(StyleRule rule)
		{
			return null;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0000B118 File Offset: 0x00009318
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x5A84E40", Offset = "0x5A83A40", VA = "0x185A84E40")]
		private static StylePropertyId GetPropertyId(StyleRule rule, int index)
		{
			return StylePropertyId.Unknown;
		}

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0x0")]
		private static StyleSheetCache.SheetHandleKeyComparer s_Comparer;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache;

		// Token: 0x020002F3 RID: 755
		[Token(Token = "0x20002F3")]
		private struct SheetHandleKey
		{
			// Token: 0x060014BD RID: 5309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014BD")]
			[Address(RVA = "0x5A7BEB0", Offset = "0x5A7AAB0", VA = "0x185A7BEB0")]
			public SheetHandleKey(StyleSheet sheet, int index)
			{
			}

			// Token: 0x04000C5C RID: 3164
			[Token(Token = "0x4000C5C")]
			[FieldOffset(Offset = "0x0")]
			public readonly int sheetInstanceID;

			// Token: 0x04000C5D RID: 3165
			[Token(Token = "0x4000C5D")]
			[FieldOffset(Offset = "0x4")]
			public readonly int index;
		}

		// Token: 0x020002F4 RID: 756
		[Token(Token = "0x20002F4")]
		private class SheetHandleKeyComparer : IEqualityComparer<StyleSheetCache.SheetHandleKey>
		{
			// Token: 0x060014BE RID: 5310 RVA: 0x0000B130 File Offset: 0x00009330
			[Token(Token = "0x60014BE")]
			[Address(RVA = "0x5A7BE50", Offset = "0x5A7AA50", VA = "0x185A7BE50", Slot = "4")]
			public bool Equals(StyleSheetCache.SheetHandleKey x, StyleSheetCache.SheetHandleKey y)
			{
				return default(bool);
			}

			// Token: 0x060014BF RID: 5311 RVA: 0x0000B148 File Offset: 0x00009348
			[Token(Token = "0x60014BF")]
			[Address(RVA = "0x5A7BE70", Offset = "0x5A7AA70", VA = "0x185A7BE70", Slot = "5")]
			public int GetHashCode(StyleSheetCache.SheetHandleKey key)
			{
				return 0;
			}

			// Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014C0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SheetHandleKeyComparer()
			{
			}
		}
	}
}
