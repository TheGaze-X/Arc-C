using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000393 RID: 915
	[Token(Token = "0x2000393")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IContributeClientContextSink
	{
		// Token: 0x06001DC1 RID: 7617
		[Token(Token = "0x6001DC1")]
		System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink);
	}
}
