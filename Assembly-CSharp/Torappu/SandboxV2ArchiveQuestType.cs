using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012D4 RID: 4820
	[Token(Token = "0x20012D4")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2ArchiveQuestType
	{
		// Token: 0x04006A7F RID: 27263
		[Token(Token = "0x4006A7F")]
		NONE,
		// Token: 0x04006A80 RID: 27264
		[Token(Token = "0x4006A80")]
		MAIN,
		// Token: 0x04006A81 RID: 27265
		[Token(Token = "0x4006A81")]
		SIDE
	}
}
