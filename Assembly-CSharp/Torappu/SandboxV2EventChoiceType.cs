using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012C1 RID: 4801
	[Token(Token = "0x20012C1")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2EventChoiceType
	{
		// Token: 0x04006A12 RID: 27154
		[Token(Token = "0x4006A12")]
		NONE,
		// Token: 0x04006A13 RID: 27155
		[Token(Token = "0x4006A13")]
		NEXT,
		// Token: 0x04006A14 RID: 27156
		[Token(Token = "0x4006A14")]
		LEAVE,
		// Token: 0x04006A15 RID: 27157
		[Token(Token = "0x4006A15")]
		MISSION
	}
}
