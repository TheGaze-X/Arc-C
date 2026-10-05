using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011EF RID: 4591
	[Token(Token = "0x20011EF")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeTopicDevNodeType
	{
		// Token: 0x040062AB RID: 25259
		[Token(Token = "0x40062AB")]
		BRANCH,
		// Token: 0x040062AC RID: 25260
		[Token(Token = "0x40062AC")]
		KEY,
		// Token: 0x040062AD RID: 25261
		[Token(Token = "0x40062AD")]
		NONE = 10
	}
}
