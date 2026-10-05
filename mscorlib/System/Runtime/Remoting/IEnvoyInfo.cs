using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000362 RID: 866
	[Token(Token = "0x2000362")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IEnvoyInfo
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001C68 RID: 7272
		[Token(Token = "0x1700033A")]
		System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks { [Token(Token = "0x6001C68")] get; }
	}
}
