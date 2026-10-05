using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200123B RID: 4667
	[Token(Token = "0x200123B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeGameItemRarity
	{
		// Token: 0x040064DC RID: 25820
		[Token(Token = "0x40064DC")]
		NONE,
		// Token: 0x040064DD RID: 25821
		[Token(Token = "0x40064DD")]
		BORN,
		// Token: 0x040064DE RID: 25822
		[Token(Token = "0x40064DE")]
		NORMAL,
		// Token: 0x040064DF RID: 25823
		[Token(Token = "0x40064DF")]
		RARE,
		// Token: 0x040064E0 RID: 25824
		[Token(Token = "0x40064E0")]
		SUPER_RARE
	}
}
