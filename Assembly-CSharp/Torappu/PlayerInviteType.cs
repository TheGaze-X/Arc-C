using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000A2E RID: 2606
	[Token(Token = "0x2000A2E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PlayerInviteType
	{
		// Token: 0x040037E9 RID: 14313
		[Token(Token = "0x40037E9")]
		ACTIVITY
	}
}
