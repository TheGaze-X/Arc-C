using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002E5 RID: 741
	[Token(Token = "0x20002E5")]
	internal static class StylePropertyCache
	{
		// Token: 0x06001475 RID: 5237 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x5A7E0C0", Offset = "0x5A7CCC0", VA = "0x185A7E0C0")]
		public static bool TryGetSyntax(string name, out string syntax)
		{
			return default(bool);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x5A7E030", Offset = "0x5A7CC30", VA = "0x185A7E030")]
		public static bool TryGetNonTerminalValue(string name, out string syntax)
		{
			return default(bool);
		}

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Dictionary<string, string> s_PropertySyntaxCache;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly Dictionary<string, string> s_NonTerminalValues;
	}
}
