using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x02000306 RID: 774
	[Token(Token = "0x2000306")]
	internal struct StyleSyntaxToken
	{
		// Token: 0x06001513 RID: 5395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x5A895B0", Offset = "0x5A881B0", VA = "0x185A895B0")]
		public StyleSyntaxToken(StyleSyntaxTokenType t)
		{
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x5A895E0", Offset = "0x5A881E0", VA = "0x185A895E0")]
		public StyleSyntaxToken(StyleSyntaxTokenType type, string text)
		{
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x5A89610", Offset = "0x5A88210", VA = "0x185A89610")]
		public StyleSyntaxToken(StyleSyntaxTokenType type, int number)
		{
		}

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x0")]
		public StyleSyntaxTokenType type;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x8")]
		public string text;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x10")]
		public int number;
	}
}
