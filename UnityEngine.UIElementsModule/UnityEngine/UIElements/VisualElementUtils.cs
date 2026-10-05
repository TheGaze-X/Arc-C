using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	internal static class VisualElementUtils
	{
		// Token: 0x060005A8 RID: 1448 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x5AA1BF0", Offset = "0x5AA07F0", VA = "0x185AA1BF0")]
		public static string GetUniqueName(string nameBase)
		{
			return null;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x5AA1950", Offset = "0x5AA0550", VA = "0x185AA1950")]
		internal static int GetFoldoutDepth(this VisualElement element)
		{
			return 0;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x5AA1A70", Offset = "0x5AA0670", VA = "0x185AA1A70")]
		internal static int GetListAndFoldoutDepth(this VisualElement element)
		{
			return 0;
		}

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> s_usedNames;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type s_FoldoutType;
	}
}
