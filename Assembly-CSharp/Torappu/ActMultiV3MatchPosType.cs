using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E37 RID: 3639
	[Token(Token = "0x2000E37")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActMultiV3MatchPosType
	{
		// Token: 0x04004BB3 RID: 19379
		[Token(Token = "0x4004BB3")]
		NORMAL,
		// Token: 0x04004BB4 RID: 19380
		[Token(Token = "0x4004BB4")]
		COACH,
		// Token: 0x04004BB5 RID: 19381
		[Token(Token = "0x4004BB5")]
		STUDENT
	}
}
