using System;
using Il2CppDummyDll;

namespace PlatformSupport.Collections.Specialized
{
	// Token: 0x02000471 RID: 1137
	[Token(Token = "0x2000471")]
	public interface INotifyCollectionChanged
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600242F RID: 9263
		// (remove) Token: 0x06002430 RID: 9264
		[Token(Token = "0x14000001")]
		event NotifyCollectionChangedEventHandler CollectionChanged;
	}
}
