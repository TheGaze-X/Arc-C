using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003D2 RID: 978
	[Token(Token = "0x20003D2")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IMessageSink
	{
		// Token: 0x06001EBC RID: 7868
		[Token(Token = "0x6001EBC")]
		IMessage SyncProcessMessage(IMessage msg);

		// Token: 0x06001EBD RID: 7869
		[Token(Token = "0x6001EBD")]
		IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
	}
}
