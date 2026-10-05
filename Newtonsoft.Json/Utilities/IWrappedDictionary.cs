using System;
using System.Collections;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[Preserve]
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000376 RID: 886
		[Token(Token = "0x170000A3")]
		object UnderlyingDictionary { [Token(Token = "0x6000376")] get; }
	}
}
