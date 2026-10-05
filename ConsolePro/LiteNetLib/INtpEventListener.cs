using System;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public interface INtpEventListener
	{
		// Token: 0x06000027 RID: 39
		[Token(Token = "0x6000027")]
		void OnNtpResponse(NtpPacket packet);
	}
}
