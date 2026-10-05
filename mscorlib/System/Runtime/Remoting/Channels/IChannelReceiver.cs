using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020003A3 RID: 931
	[Token(Token = "0x20003A3")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IChannelReceiver : IChannel
	{
		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001DF2 RID: 7666
		[Token(Token = "0x17000382")]
		object ChannelData { [Token(Token = "0x6001DF2")] get; }

		// Token: 0x06001DF3 RID: 7667
		[Token(Token = "0x6001DF3")]
		void StartListening(object data);
	}
}
