using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001148 RID: 4424
	[Token(Token = "0x2001148")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReturnNewsType
	{
		// Token: 0x04005ED5 RID: 24277
		[Token(Token = "0x4005ED5")]
		NONE,
		// Token: 0x04005ED6 RID: 24278
		[Token(Token = "0x4005ED6")]
		MAIN_SS,
		// Token: 0x04005ED7 RID: 24279
		[Token(Token = "0x4005ED7")]
		ROGUE,
		// Token: 0x04005ED8 RID: 24280
		[Token(Token = "0x4005ED8")]
		SANDBOX
	}
}
