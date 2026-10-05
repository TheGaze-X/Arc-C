using System;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Messages
{
	// Token: 0x02000546 RID: 1350
	[Token(Token = "0x2000546")]
	public interface IServerMessage
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002CEC RID: 11500
		[Token(Token = "0x170006B5")]
		MessageTypes Type { [Token(Token = "0x6002CEC")] get; }

		// Token: 0x06002CED RID: 11501
		[Token(Token = "0x6002CED")]
		void Parse(object data);
	}
}
