using System;
using System.Collections;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[Preserve]
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600033A RID: 826
		[Token(Token = "0x1700009B")]
		object UnderlyingCollection { [Token(Token = "0x600033A")] get; }
	}
}
