using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012B7 RID: 4791
	[Token(Token = "0x20012B7")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2QuestLineType
	{
		// Token: 0x040069DB RID: 27099
		[Token(Token = "0x40069DB")]
		NONE,
		// Token: 0x040069DC RID: 27100
		[Token(Token = "0x40069DC")]
		MAIN,
		// Token: 0x040069DD RID: 27101
		[Token(Token = "0x40069DD")]
		SIDE,
		// Token: 0x040069DE RID: 27102
		[Token(Token = "0x40069DE")]
		GUIDE,
		// Token: 0x040069DF RID: 27103
		[Token(Token = "0x40069DF")]
		TRAINING
	}
}
