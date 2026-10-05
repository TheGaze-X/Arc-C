using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public interface IPlayerDataLink
	{
		// Token: 0x060004CD RID: 1229
		[Token(Token = "0x60004CD")]
		JsonSerializerSettings GetPlayerDataSerializerSetting();
	}
}
