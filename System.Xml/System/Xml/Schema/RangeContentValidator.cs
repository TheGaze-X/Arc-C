using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	internal sealed class RangeContentValidator : ContentValidator
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x4FE5E60", Offset = "0x4FE4A60", VA = "0x184FE5E60")]
		internal RangeContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount)
		{
		}

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x18")]
		private BitSet firstpos;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x20")]
		private BitSet[] followpos;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x28")]
		private BitSet positionsWithRangeTerminals;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x30")]
		private SymbolsDictionary symbols;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x38")]
		private Positions positions;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x40")]
		private int minMaxNodesCount;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x44")]
		private int endMarkerPos;
	}
}
