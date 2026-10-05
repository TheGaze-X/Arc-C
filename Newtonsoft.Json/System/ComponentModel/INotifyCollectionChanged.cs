using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Preserve]
	public interface INotifyCollectionChanged
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000009 RID: 9
		// (remove) Token: 0x0600000A RID: 10
		[Token(Token = "0x14000001")]
		event NotifyCollectionChangedEventHandler CollectionChanged;
	}
}
