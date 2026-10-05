using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class JsonFormatter
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4E06820", Offset = "0x4E05420", VA = "0x184E06820")]
		public static string prettyPrint(string input)
		{
			return null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4E067A0", Offset = "0x4E053A0", VA = "0x184E067A0")]
		private static void buildIndents(int indents, StringBuilder output)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x4E06800", Offset = "0x4E05400", VA = "0x184E06800")]
		private bool inString()
		{
			return default(bool);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4E06910", Offset = "0x4E05510", VA = "0x184E06910")]
		public string print(string input)
		{
			return null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4E06700", Offset = "0x4E05300", VA = "0x184E06700")]
		public JsonFormatter()
		{
		}

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		private const int defaultIndent = 0;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		private const string indent = "\t";

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		private const string space = " ";

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x10")]
		private bool inDoubleString;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x11")]
		private bool inSingleString;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x12")]
		private bool inVariableAssignment;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x14")]
		private char prevChar;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x18")]
		private Stack<JsonFormatter.JsonContextType> context;

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		private enum JsonContextType
		{
			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			Object,
			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			Array
		}
	}
}
