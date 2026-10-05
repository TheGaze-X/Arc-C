using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012B9 RID: 4793
	[Token(Token = "0x20012B9")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2QuestLineScopeType
	{
		// Token: 0x040069E7 RID: 27111
		[Token(Token = "0x40069E7")]
		MAIN,
		// Token: 0x040069E8 RID: 27112
		[Token(Token = "0x40069E8")]
		RIFT,
		// Token: 0x040069E9 RID: 27113
		[Token(Token = "0x40069E9")]
		ALL
	}
}
