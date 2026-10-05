using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200123C RID: 4668
	[Token(Token = "0x200123C")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeGameMonthTaskClass
	{
		// Token: 0x040064E2 RID: 25826
		[Token(Token = "0x40064E2")]
		NONE,
		// Token: 0x040064E3 RID: 25827
		[Token(Token = "0x40064E3")]
		C,
		// Token: 0x040064E4 RID: 25828
		[Token(Token = "0x40064E4")]
		B,
		// Token: 0x040064E5 RID: 25829
		[Token(Token = "0x40064E5")]
		A
	}
}
