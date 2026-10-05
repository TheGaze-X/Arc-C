using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000304")]
	internal class StyleSyntaxParser
	{
		// Token: 0x06001503 RID: 5379 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x5A88FB0", Offset = "0x5A87BB0", VA = "0x185A88FB0")]
		public Expression Parse(string syntax)
		{
			return null;
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x5A87C80", Offset = "0x5A86880", VA = "0x185A87C80")]
		private Expression ParseExpression(StyleSyntaxTokenizer tokenizer)
		{
			return null;
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x5A89170", Offset = "0x5A87D70", VA = "0x185A89170")]
		private void ProcessCombinatorStack()
		{
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x5A88DB0", Offset = "0x5A879B0", VA = "0x185A88DB0")]
		private Expression ParseTerm(StyleSyntaxTokenizer tokenizer)
		{
			return null;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x5A87390", Offset = "0x5A85F90", VA = "0x185A87390")]
		private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer)
		{
			return ExpressionCombinator.None;
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x5A87F20", Offset = "0x5A86B20", VA = "0x185A87F20")]
		private Expression ParseGroup(StyleSyntaxTokenizer tokenizer)
		{
			return null;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x5A875F0", Offset = "0x5A861F0", VA = "0x185A875F0")]
		private Expression ParseDataType(StyleSyntaxTokenizer tokenizer)
		{
			return null;
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600150A")]
		[Address(RVA = "0x5A88570", Offset = "0x5A87170", VA = "0x185A88570")]
		private Expression ParseNonTerminalValue(string syntax)
		{
			return null;
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600150B")]
		[Address(RVA = "0x5A88730", Offset = "0x5A87330", VA = "0x185A88730")]
		private Expression ParseProperty(StyleSyntaxTokenizer tokenizer)
		{
			return null;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150C")]
		[Address(RVA = "0x5A88290", Offset = "0x5A86E90", VA = "0x185A88290")]
		private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier)
		{
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x5A88C40", Offset = "0x5A87840", VA = "0x185A88C40")]
		private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max)
		{
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150E")]
		[Address(RVA = "0x5A872C0", Offset = "0x5A85EC0", VA = "0x185A872C0")]
		private static void EatSpace(StyleSyntaxTokenizer tokenizer)
		{
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x5A87340", Offset = "0x5A85F40", VA = "0x185A87340")]
		private static bool IsExpressionEnd(StyleSyntaxToken token)
		{
			return default(bool);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x5A87320", Offset = "0x5A85F20", VA = "0x185A87320")]
		private static bool IsCombinator(StyleSyntaxToken token)
		{
			return default(bool);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x5A87360", Offset = "0x5A85F60", VA = "0x185A87360")]
		private static bool IsMultiplier(StyleSyntaxToken token)
		{
			return default(bool);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001512")]
		[Address(RVA = "0x5A89440", Offset = "0x5A88040", VA = "0x185A89440")]
		public StyleSyntaxParser()
		{
		}

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x10")]
		private List<Expression> m_ProcessExpressionList;

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x18")]
		private Stack<Expression> m_ExpressionStack;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		[FieldOffset(Offset = "0x20")]
		private Stack<ExpressionCombinator> m_CombinatorStack;

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Expression> m_ParsedExpressionCache;
	}
}
