using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	internal sealed class NfaContentValidator : ContentValidator
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x4FE1E60", Offset = "0x4FE0A60", VA = "0x184FE1E60")]
		internal NfaContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
		}

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x18")]
		private BitSet firstpos;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x20")]
		private BitSet[] followpos;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x28")]
		private SymbolsDictionary symbols;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x30")]
		private Positions positions;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x38")]
		private int endMarkerPos;
	}
}
