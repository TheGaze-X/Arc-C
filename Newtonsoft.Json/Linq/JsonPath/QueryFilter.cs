using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	[Preserve]
	internal class QueryFilter : PathFilter
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C5")]
		public QueryExpression Expression
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x4DEA0E0", Offset = "0x4DE8CE0", VA = "0x184DEA0E0", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QueryFilter()
		{
		}
	}
}
