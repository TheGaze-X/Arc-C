using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	[Preserve]
	internal class JPath
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C0")]
		public List<PathFilter> Filters
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x4DE27B0", Offset = "0x4DE13B0", VA = "0x184DE27B0")]
		public JPath(string expression)
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x4DE0E40", Offset = "0x4DDFA40", VA = "0x184DE0E40")]
		private void ParseMain()
		{
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x4DE1470", Offset = "0x4DE0070", VA = "0x184DE1470")]
		private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query)
		{
			return default(bool);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x4DE0D10", Offset = "0x4DDF910", VA = "0x184DE0D10")]
		private PathFilter ParseIndexer(char indexerOpenChar)
		{
			return null;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x4DDFDB0", Offset = "0x4DDE9B0", VA = "0x184DDFDB0")]
		private PathFilter ParseArrayIndexer(char indexerCloseChar)
		{
			return null;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x4DDFA40", Offset = "0x4DDE640", VA = "0x184DDFA40")]
		private void EatWhitespace()
		{
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x4DE19A0", Offset = "0x4DE05A0", VA = "0x184DE19A0")]
		private PathFilter ParseQuery(char indexerCloseChar)
		{
			return null;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x4DE0720", Offset = "0x4DDF320", VA = "0x184DE0720")]
		private QueryExpression ParseExpression()
		{
			return null;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x4DE2030", Offset = "0x4DE0C30", VA = "0x184DE2030")]
		private object ParseValue()
		{
			return null;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x4DE2560", Offset = "0x4DE1160", VA = "0x184DE2560")]
		private string ReadQuotedString()
		{
			return null;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x4DDFD10", Offset = "0x4DDE910", VA = "0x184DDFD10")]
		private bool Match(string s)
		{
			return default(bool);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x4DE1030", Offset = "0x4DDFC30", VA = "0x184DE1030")]
		private QueryOperator ParseOperator()
		{
			return QueryOperator.None;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x4DE1C50", Offset = "0x4DE0850", VA = "0x184DE1C50")]
		private PathFilter ParseQuotedField(char indexerCloseChar)
		{
			return null;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x4DDFAA0", Offset = "0x4DDE6A0", VA = "0x184DDFAA0")]
		private void EnsureLength(string message)
		{
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x4DDFB20", Offset = "0x4DDE720", VA = "0x184DDFB20")]
		internal IEnumerable<JToken> Evaluate(JToken t, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x4DDFB30", Offset = "0x4DDE730", VA = "0x184DDFB30")]
		internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken t, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _expression;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x20")]
		private int _currentIndex;
	}
}
