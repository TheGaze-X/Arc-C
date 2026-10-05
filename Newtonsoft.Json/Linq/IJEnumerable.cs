using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[Preserve]
	public interface IJEnumerable<T> : IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x17000156 RID: 342
		[Token(Token = "0x17000156")]
		IJEnumerable<JToken> this[object key]
		{
			[Token(Token = "0x60006F1")]
			get;
		}
	}
}
