using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000398 RID: 920
	[Token(Token = "0x2000398")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IDynamicMessageSink
	{
		// Token: 0x06001DC6 RID: 7622
		[Token(Token = "0x6001DC6")]
		void ProcessMessageFinish(System.Runtime.Remoting.Messaging.IMessage replyMsg, bool bCliSide, bool bAsync);

		// Token: 0x06001DC7 RID: 7623
		[Token(Token = "0x6001DC7")]
		void ProcessMessageStart(System.Runtime.Remoting.Messaging.IMessage reqMsg, bool bCliSide, bool bAsync);
	}
}
