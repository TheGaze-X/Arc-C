using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public interface INetLogger
	{
		// Token: 0x060000A1 RID: 161
		[Token(Token = "0x60000A1")]
		void WriteNet(NetLogLevel level, string str, params object[] args);
	}
}
