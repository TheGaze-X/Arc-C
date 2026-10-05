using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000395 RID: 917
	[Token(Token = "0x2000395")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IContributeEnvoySink
	{
		// Token: 0x06001DC3 RID: 7619
		[Token(Token = "0x6001DC3")]
		System.Runtime.Remoting.Messaging.IMessageSink GetEnvoySink(System.MarshalByRefObject obj, System.Runtime.Remoting.Messaging.IMessageSink nextSink);
	}
}
