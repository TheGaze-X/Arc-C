using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x02000307 RID: 775
	[Token(Token = "0x2000307")]
	internal class StyleSyntaxTokenizer
	{
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x17000529")]
		public StyleSyntaxToken current
		{
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x5A8A8C0", Offset = "0x5A894C0", VA = "0x185A8A8C0")]
			get
			{
				return default(StyleSyntaxToken);
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6001517")]
		[Address(RVA = "0x5A89850", Offset = "0x5A88450", VA = "0x185A89850")]
		public StyleSyntaxToken MoveNext()
		{
			return default(StyleSyntaxToken);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x6001518")]
		[Address(RVA = "0x5A89910", Offset = "0x5A88510", VA = "0x185A89910")]
		public StyleSyntaxToken PeekNext()
		{
			return default(StyleSyntaxToken);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x5A899D0", Offset = "0x5A885D0", VA = "0x185A899D0")]
		public void Tokenize(string syntax)
		{
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x5A896B0", Offset = "0x5A882B0", VA = "0x185A896B0")]
		private static bool IsNextCharacter(string s, int index, char c)
		{
			return default(bool);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x5A896F0", Offset = "0x5A882F0", VA = "0x185A896F0")]
		private static bool IsNextLetterOrDash(string s, int index)
		{
			return default(bool);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x5A897C0", Offset = "0x5A883C0", VA = "0x185A897C0")]
		private static bool IsNextNumber(string s, int index)
		{
			return default(bool);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x5A89650", Offset = "0x5A88250", VA = "0x185A89650")]
		private static int GlobCharacter(string s, int index, char c)
		{
			return 0;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x5A8A830", Offset = "0x5A89430", VA = "0x185A8A830")]
		public StyleSyntaxTokenizer()
		{
		}

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x10")]
		private List<StyleSyntaxToken> m_Tokens;

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x18")]
		private int m_CurrentTokenIndex;
	}
}
