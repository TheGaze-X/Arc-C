using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IChannelSender : IChannel
	{
		// Token: 0x06001DF4 RID: 7668
		[Token(Token = "0x6001DF4")]
		System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
	}
}
