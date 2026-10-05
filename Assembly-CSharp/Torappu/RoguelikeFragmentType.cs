using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011A2 RID: 4514
	[Token(Token = "0x20011A2")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeFragmentType
	{
		// Token: 0x040060AA RID: 24746
		[Token(Token = "0x40060AA")]
		NONE,
		// Token: 0x040060AB RID: 24747
		[Token(Token = "0x40060AB")]
		INSPIRATION,
		// Token: 0x040060AC RID: 24748
		[Token(Token = "0x40060AC")]
		WISH,
		// Token: 0x040060AD RID: 24749
		[Token(Token = "0x40060AD")]
		IDEA
	}
}
