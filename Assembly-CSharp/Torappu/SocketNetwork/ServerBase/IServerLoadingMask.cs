using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014B5 RID: 5301
	[Token(Token = "0x20014B5")]
	public interface IServerLoadingMask
	{
		// Token: 0x06007A62 RID: 31330
		[Token(Token = "0x6007A62")]
		bool Show(ServerLoadingMaskType maskType);

		// Token: 0x06007A63 RID: 31331
		[Token(Token = "0x6007A63")]
		void Hide(ServerLoadingMaskType maskType, Action callback);
	}
}
