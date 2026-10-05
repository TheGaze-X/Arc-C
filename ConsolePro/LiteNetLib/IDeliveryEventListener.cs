using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public interface IDeliveryEventListener
	{
		// Token: 0x06000026 RID: 38
		[Token(Token = "0x6000026")]
		void OnMessageDelivered(NetPeer peer, object userData);
	}
}
