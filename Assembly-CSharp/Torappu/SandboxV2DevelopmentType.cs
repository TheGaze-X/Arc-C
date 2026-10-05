using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012BC RID: 4796
	[Token(Token = "0x20012BC")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2DevelopmentType
	{
		// Token: 0x040069F5 RID: 27125
		[Token(Token = "0x40069F5")]
		NONE,
		// Token: 0x040069F6 RID: 27126
		[Token(Token = "0x40069F6")]
		SURVIVE,
		// Token: 0x040069F7 RID: 27127
		[Token(Token = "0x40069F7")]
		COLLECT,
		// Token: 0x040069F8 RID: 27128
		[Token(Token = "0x40069F8")]
		SHOP,
		// Token: 0x040069F9 RID: 27129
		[Token(Token = "0x40069F9")]
		BATTLE,
		// Token: 0x040069FA RID: 27130
		[Token(Token = "0x40069FA")]
		DUNGEON
	}
}
