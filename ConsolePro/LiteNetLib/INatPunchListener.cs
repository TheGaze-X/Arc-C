using System;
using System.Net;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public interface INatPunchListener
	{
		// Token: 0x06000071 RID: 113
		[Token(Token = "0x6000071")]
		void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

		// Token: 0x06000072 RID: 114
		[Token(Token = "0x6000072")]
		void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);
	}
}
