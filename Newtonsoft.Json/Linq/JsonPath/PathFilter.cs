using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	[Preserve]
	internal abstract class PathFilter
	{
		// Token: 0x060009D1 RID: 2513
		[Token(Token = "0x60009D1")]
		public abstract IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch);

		// Token: 0x060009D2 RID: 2514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x4DE8F40", Offset = "0x4DE7B40", VA = "0x184DE8F40")]
		protected static JToken GetTokenIndex(JToken t, bool errorWhenNoMatch, int index)
		{
			return null;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected PathFilter()
		{
		}
	}
}
