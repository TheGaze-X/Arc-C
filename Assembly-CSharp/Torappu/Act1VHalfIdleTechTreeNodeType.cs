using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000C88 RID: 3208
	[Token(Token = "0x2000C88")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Act1VHalfIdleTechTreeNodeType
	{
		// Token: 0x04004180 RID: 16768
		[Token(Token = "0x4004180")]
		NONE,
		// Token: 0x04004181 RID: 16769
		[Token(Token = "0x4004181")]
		NORMAL,
		// Token: 0x04004182 RID: 16770
		[Token(Token = "0x4004182")]
		DIFFICULTY
	}
}
