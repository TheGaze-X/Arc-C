using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001117 RID: 4375
	[Token(Token = "0x2001117")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TemplateMissionTitleType
	{
		// Token: 0x04005DBF RID: 23999
		[Token(Token = "0x4005DBF")]
		COMMON,
		// Token: 0x04005DC0 RID: 24000
		[Token(Token = "0x4005DC0")]
		CUSTOM
	}
}
