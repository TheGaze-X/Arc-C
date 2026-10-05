using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200116C RID: 4460
	[Token(Token = "0x200116C")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeItemRarity
	{
		// Token: 0x04005F8F RID: 24463
		[Token(Token = "0x4005F8F")]
		NONE,
		// Token: 0x04005F90 RID: 24464
		[Token(Token = "0x4005F90")]
		BORN,
		// Token: 0x04005F91 RID: 24465
		[Token(Token = "0x4005F91")]
		NORMAL,
		// Token: 0x04005F92 RID: 24466
		[Token(Token = "0x4005F92")]
		RARE,
		// Token: 0x04005F93 RID: 24467
		[Token(Token = "0x4005F93")]
		SUPER_RARE
	}
}
