using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FFD RID: 4093
	[Token(Token = "0x2000FFD")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NameCardV2ModuleSubType
	{
		// Token: 0x040056CF RID: 22223
		[Token(Token = "0x40056CF")]
		NONE,
		// Token: 0x040056D0 RID: 22224
		[Token(Token = "0x40056D0")]
		SIGN,
		// Token: 0x040056D1 RID: 22225
		[Token(Token = "0x40056D1")]
		ASSIST,
		// Token: 0x040056D2 RID: 22226
		[Token(Token = "0x40056D2")]
		MEDAL,
		// Token: 0x040056D3 RID: 22227
		[Token(Token = "0x40056D3")]
		MAINLINE,
		// Token: 0x040056D4 RID: 22228
		[Token(Token = "0x40056D4")]
		EQUIPMENT
	}
}
