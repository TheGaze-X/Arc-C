using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001118 RID: 4376
	[Token(Token = "0x2001118")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TemplateMissionCoinInfoType
	{
		// Token: 0x04005DC2 RID: 24002
		[Token(Token = "0x4005DC2")]
		COMMON,
		// Token: 0x04005DC3 RID: 24003
		[Token(Token = "0x4005DC3")]
		CUSTOM
	}
}
