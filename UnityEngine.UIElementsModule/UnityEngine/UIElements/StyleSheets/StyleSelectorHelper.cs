using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002F1 RID: 753
	[Token(Token = "0x20002F1")]
	internal static class StyleSelectorHelper
	{
		// Token: 0x060014B5 RID: 5301 RVA: 0x0000B0E8 File Offset: 0x000092E8
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x5A84BC0", Offset = "0x5A837C0", VA = "0x185A84BC0")]
		public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector)
		{
			return default(MatchResultInfo);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0000B100 File Offset: 0x00009300
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x5A849D0", Offset = "0x5A835D0", VA = "0x185A849D0")]
		public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult)
		{
			return default(bool);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x5A842A0", Offset = "0x5A82EA0", VA = "0x185A842A0")]
		private static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record)
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x5A84640", Offset = "0x5A83240", VA = "0x185A84640")]
		public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex)
		{
		}
	}
}
