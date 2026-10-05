using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001111 RID: 4369
	[Token(Token = "0x2001111")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MissionItemBgType
	{
		// Token: 0x04005DA6 RID: 23974
		[Token(Token = "0x4005DA6")]
		COMMON,
		// Token: 0x04005DA7 RID: 23975
		[Token(Token = "0x4005DA7")]
		Equipment,
		// Token: 0x04005DA8 RID: 23976
		[Token(Token = "0x4005DA8")]
		Char
	}
}
