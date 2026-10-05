using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.JsonEncoders
{
	// Token: 0x02000558 RID: 1368
	[Token(Token = "0x2000558")]
	public interface IJsonEncoder
	{
		// Token: 0x06002D68 RID: 11624
		[Token(Token = "0x6002D68")]
		string Encode(object obj);

		// Token: 0x06002D69 RID: 11625
		[Token(Token = "0x6002D69")]
		IDictionary<string, object> DecodeMessage(string json);
	}
}
