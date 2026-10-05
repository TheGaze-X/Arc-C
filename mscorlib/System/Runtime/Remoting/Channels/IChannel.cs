using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020003A1 RID: 929
	[Token(Token = "0x20003A1")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IChannel
	{
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001DF0 RID: 7664
		[Token(Token = "0x17000380")]
		string ChannelName { [Token(Token = "0x6001DF0")] get; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001DF1 RID: 7665
		[Token(Token = "0x17000381")]
		int ChannelPriority { [Token(Token = "0x6001DF1")] get; }
	}
}
