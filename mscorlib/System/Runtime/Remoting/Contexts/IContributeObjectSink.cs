using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IContributeObjectSink
	{
		// Token: 0x06001DC4 RID: 7620
		[Token(Token = "0x6001DC4")]
		System.Runtime.Remoting.Messaging.IMessageSink GetObjectSink(System.MarshalByRefObject obj, System.Runtime.Remoting.Messaging.IMessageSink nextSink);
	}
}
