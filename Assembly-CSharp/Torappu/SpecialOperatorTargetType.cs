using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001331 RID: 4913
	[Token(Token = "0x2001331")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SpecialOperatorTargetType
	{
		// Token: 0x04006D03 RID: 27907
		[Token(Token = "0x4006D03")]
		NONE,
		// Token: 0x04006D04 RID: 27908
		[Token(Token = "0x4006D04")]
		ROGUE
	}
}
