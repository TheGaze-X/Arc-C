using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012B2 RID: 4786
	[Token(Token = "0x20012B2")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2QuestRouteType
	{
		// Token: 0x040069BA RID: 27066
		[Token(Token = "0x40069BA")]
		NONE,
		// Token: 0x040069BB RID: 27067
		[Token(Token = "0x40069BB")]
		ENEMY_RUSH,
		// Token: 0x040069BC RID: 27068
		[Token(Token = "0x40069BC")]
		EVENT,
		// Token: 0x040069BD RID: 27069
		[Token(Token = "0x40069BD")]
		NODE,
		// Token: 0x040069BE RID: 27070
		[Token(Token = "0x40069BE")]
		NPC
	}
}
