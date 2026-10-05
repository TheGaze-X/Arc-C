using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public interface ISingletonMonoHost
	{
		// Token: 0x060001C1 RID: 449
		[Token(Token = "0x60001C1")]
		TSingleton GetOrCreateSingleton<TSingleton, THost>(Func<TSingleton> creator) where TSingleton : class where THost : SingletonMonoBehaviour<THost>, ISingletonMonoHost;
	}
}
