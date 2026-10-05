using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	internal sealed class RegexTree
	{
		// Token: 0x06000647 RID: 1607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x5116E10", Offset = "0x5115A10", VA = "0x185116E10")]
		internal RegexTree(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options)
		{
		}

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x10")]
		public readonly RegexNode Root;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x18")]
		public readonly Hashtable Caps;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x20")]
		public readonly int[] CapNumList;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x28")]
		public readonly int CapTop;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x30")]
		public readonly Hashtable CapNames;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x38")]
		public readonly string[] CapsList;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x40")]
		public readonly RegexOptions Options;
	}
}
