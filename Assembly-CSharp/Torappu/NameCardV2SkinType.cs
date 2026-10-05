using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001000 RID: 4096
	[Token(Token = "0x2001000")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NameCardV2SkinType
	{
		// Token: 0x040056DD RID: 22237
		[Token(Token = "0x40056DD")]
		NONE,
		// Token: 0x040056DE RID: 22238
		[Token(Token = "0x40056DE")]
		BASE,
		// Token: 0x040056DF RID: 22239
		[Token(Token = "0x40056DF")]
		SPECIAL
	}
}
