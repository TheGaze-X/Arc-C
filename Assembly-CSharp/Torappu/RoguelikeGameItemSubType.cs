using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200123A RID: 4666
	[Token(Token = "0x200123A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeGameItemSubType
	{
		// Token: 0x040064D3 RID: 25811
		[Token(Token = "0x40064D3")]
		NONE,
		// Token: 0x040064D4 RID: 25812
		[Token(Token = "0x40064D4")]
		CURSE,
		// Token: 0x040064D5 RID: 25813
		[Token(Token = "0x40064D5")]
		TEMP_TICKET,
		// Token: 0x040064D6 RID: 25814
		[Token(Token = "0x40064D6")]
		TOTEM_UPPER = 4,
		// Token: 0x040064D7 RID: 25815
		[Token(Token = "0x40064D7")]
		TOTEM_LOWER = 8,
		// Token: 0x040064D8 RID: 25816
		[Token(Token = "0x40064D8")]
		SECRET = 16,
		// Token: 0x040064D9 RID: 25817
		[Token(Token = "0x40064D9")]
		SINGLE_RAND_FREE = 32,
		// Token: 0x040064DA RID: 25818
		[Token(Token = "0x40064DA")]
		RED_CAPSULE = 64
	}
}
