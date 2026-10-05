using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO.JsonEncoders
{
	// Token: 0x0200052E RID: 1326
	[Token(Token = "0x200052E")]
	public interface IJsonEncoder
	{
		// Token: 0x06002C10 RID: 11280
		[Token(Token = "0x6002C10")]
		List<object> Decode(string json);

		// Token: 0x06002C11 RID: 11281
		[Token(Token = "0x6002C11")]
		string Encode(List<object> obj);
	}
}
