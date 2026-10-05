using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001025 RID: 4133
	[Token(Token = "0x2001025")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MagazineLeafType
	{
		// Token: 0x040057C0 RID: 22464
		[Token(Token = "0x40057C0")]
		DEFAULT,
		// Token: 0x040057C1 RID: 22465
		[Token(Token = "0x40057C1")]
		ROGUE,
		// Token: 0x040057C2 RID: 22466
		[Token(Token = "0x40057C2")]
		SANDBOX,
		// Token: 0x040057C3 RID: 22467
		[Token(Token = "0x40057C3")]
		AMIYA
	}
}
