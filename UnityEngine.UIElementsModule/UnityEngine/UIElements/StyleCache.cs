using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	internal static class StyleCache
	{
		// Token: 0x060005BD RID: 1469 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x5A8F530", Offset = "0x5A8E130", VA = "0x185A8F530")]
		public static bool TryGetValue(long hash, out ComputedStyle data)
		{
			return default(bool);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x5A8F220", Offset = "0x5A8DE20", VA = "0x185A8F220")]
		public static void SetValue(long hash, ref ComputedStyle data)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x5A8F410", Offset = "0x5A8E010", VA = "0x185A8F410")]
		public static bool TryGetValue(int hash, out StyleVariableContext data)
		{
			return default(bool);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x5A8F2F0", Offset = "0x5A8DEF0", VA = "0x185A8F2F0")]
		public static void SetValue(int hash, StyleVariableContext data)
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x5A8F4A0", Offset = "0x5A8E0A0", VA = "0x185A8F4A0")]
		public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data)
		{
			return default(bool);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x5A8F380", Offset = "0x5A8DF80", VA = "0x185A8F380")]
		public static void SetValue(int hash, ComputedTransitionProperty[] data)
		{
		}

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<long, ComputedStyle> s_ComputedStyleCache;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, StyleVariableContext> s_StyleVariableContextCache;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<int, ComputedTransitionProperty[]> s_ComputedTransitionsCache;
	}
}
