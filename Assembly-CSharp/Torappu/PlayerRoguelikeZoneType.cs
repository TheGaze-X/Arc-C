using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000B1A RID: 2842
	[Token(Token = "0x2000B1A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PlayerRoguelikeZoneType
	{
		// Token: 0x04003B70 RID: 15216
		[Token(Token = "0x4003B70")]
		NORMAL,
		// Token: 0x04003B71 RID: 15217
		[Token(Token = "0x4003B71")]
		SP
	}
}
