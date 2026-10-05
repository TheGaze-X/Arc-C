using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F4E RID: 3918
	[Token(Token = "0x2000F4E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CGGalleryCGCompositeType
	{
		// Token: 0x04005351 RID: 21329
		[Token(Token = "0x4005351")]
		NONE,
		// Token: 0x04005352 RID: 21330
		[Token(Token = "0x4005352")]
		HORIZONTAL,
		// Token: 0x04005353 RID: 21331
		[Token(Token = "0x4005353")]
		VERTICAL,
		// Token: 0x04005354 RID: 21332
		[Token(Token = "0x4005354")]
		GRID
	}
}
