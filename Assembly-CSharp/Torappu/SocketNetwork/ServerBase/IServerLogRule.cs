using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014B6 RID: 5302
	[Token(Token = "0x20014B6")]
	public interface IServerLogRule
	{
		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06007A64 RID: 31332
		[Token(Token = "0x17000E98")]
		string prefix { [Token(Token = "0x6007A64")] get; }

		// Token: 0x06007A65 RID: 31333
		[Token(Token = "0x6007A65")]
		bool AllowedRevMsg(Protocol protocol);

		// Token: 0x06007A66 RID: 31334
		[Token(Token = "0x6007A66")]
		bool AllowedSendMsg(Protocol protocol);

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06007A67 RID: 31335
		[Token(Token = "0x17000E99")]
		bool logDetail { [Token(Token = "0x6007A67")] get; }
	}
}
