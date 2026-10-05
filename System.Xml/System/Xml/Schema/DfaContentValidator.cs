using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	internal sealed class DfaContentValidator : ContentValidator
	{
		// Token: 0x0600086A RID: 2154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x4FE14F0", Offset = "0x4FE00F0", VA = "0x184FE14F0")]
		internal DfaContentValidator(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
		}

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x18")]
		private int[][] transitionTable;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x20")]
		private SymbolsDictionary symbols;
	}
}
