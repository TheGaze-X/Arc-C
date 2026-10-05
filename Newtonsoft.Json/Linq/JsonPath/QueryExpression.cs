using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	[Preserve]
	internal abstract class QueryExpression
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00005B50 File Offset: 0x00003D50
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C1")]
		public QueryOperator Operator
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return QueryOperator.None;
			}
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009D6 RID: 2518
		[Token(Token = "0x60009D6")]
		public abstract bool IsMatch(JToken t);

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected QueryExpression()
		{
		}
	}
}
