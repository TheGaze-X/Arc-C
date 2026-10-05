using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012B4 RID: 4788
	[Token(Token = "0x20012B4")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2NpcType
	{
		// Token: 0x040069CA RID: 27082
		[Token(Token = "0x40069CA")]
		NORMAL,
		// Token: 0x040069CB RID: 27083
		[Token(Token = "0x40069CB")]
		FIXED_RIFT,
		// Token: 0x040069CC RID: 27084
		[Token(Token = "0x40069CC")]
		RANDOM_RIFT,
		// Token: 0x040069CD RID: 27085
		[Token(Token = "0x40069CD")]
		PREY_RIFT
	}
}
