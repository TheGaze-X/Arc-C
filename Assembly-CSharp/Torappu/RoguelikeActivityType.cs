using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001152 RID: 4434
	[Token(Token = "0x2001152")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeActivityType
	{
		// Token: 0x04005F09 RID: 24329
		[Token(Token = "0x4005F09")]
		NONE,
		// Token: 0x04005F0A RID: 24330
		[Token(Token = "0x4005F0A")]
		SEED_MODE
	}
}
