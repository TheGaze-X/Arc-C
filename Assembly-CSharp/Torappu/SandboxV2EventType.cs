using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012C0 RID: 4800
	[Token(Token = "0x20012C0")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2EventType
	{
		// Token: 0x04006A0C RID: 27148
		[Token(Token = "0x4006A0C")]
		NONE,
		// Token: 0x04006A0D RID: 27149
		[Token(Token = "0x4006A0D")]
		EVENT,
		// Token: 0x04006A0E RID: 27150
		[Token(Token = "0x4006A0E")]
		MISSION,
		// Token: 0x04006A0F RID: 27151
		[Token(Token = "0x4006A0F")]
		QUEST_EVENT,
		// Token: 0x04006A10 RID: 27152
		[Token(Token = "0x4006A10")]
		QUEST_MISSION
	}
}
