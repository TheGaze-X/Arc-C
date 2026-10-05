using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000397 RID: 919
	[Token(Token = "0x2000397")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IContributeServerContextSink
	{
		// Token: 0x06001DC5 RID: 7621
		[Token(Token = "0x6001DC5")]
		System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink);
	}
}
