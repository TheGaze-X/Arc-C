using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	[Preserve]
	internal class BooleanQueryExpression : QueryExpression
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C3")]
		public List<PathFilter> Path
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C4")]
		public JValue Value
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x4DDD930", Offset = "0x4DDC530", VA = "0x184DDD930", Slot = "4")]
		public override bool IsMatch(JToken t)
		{
			return default(bool);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x4DDD4D0", Offset = "0x4DDC0D0", VA = "0x184DDD4D0")]
		private bool EqualsWithStringCoercion(JValue value, JValue queryValue)
		{
			return default(bool);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BooleanQueryExpression()
		{
		}
	}
}
