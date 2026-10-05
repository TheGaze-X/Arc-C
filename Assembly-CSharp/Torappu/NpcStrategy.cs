using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000EB6 RID: 3766
	[Token(Token = "0x2000EB6")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NpcStrategy
	{
		// Token: 0x04004FA0 RID: 20384
		[Token(Token = "0x4004FA0")]
		DEFAULT,
		// Token: 0x04004FA1 RID: 20385
		[Token(Token = "0x4004FA1")]
		CHOOSE_WIN,
		// Token: 0x04004FA2 RID: 20386
		[Token(Token = "0x4004FA2")]
		CHOOSE_ODD,
		// Token: 0x04004FA3 RID: 20387
		[Token(Token = "0x4004FA3")]
		FOLLOW_FEWER,
		// Token: 0x04004FA4 RID: 20388
		[Token(Token = "0x4004FA4")]
		FOLLOW_MORE
	}
}
