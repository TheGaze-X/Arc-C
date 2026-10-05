using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001242 RID: 4674
	[Token(Token = "0x2001242")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeGameRelicCheckType
	{
		// Token: 0x04006522 RID: 25890
		[Token(Token = "0x4006522")]
		NONE,
		// Token: 0x04006523 RID: 25891
		[Token(Token = "0x4006523")]
		PROFESSION,
		// Token: 0x04006524 RID: 25892
		[Token(Token = "0x4006524")]
		SUB_PROFESSION,
		// Token: 0x04006525 RID: 25893
		[Token(Token = "0x4006525")]
		UPGRADE
	}
}
