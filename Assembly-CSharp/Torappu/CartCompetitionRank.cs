using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000CBC RID: 3260
	[Token(Token = "0x2000CBC")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CartCompetitionRank
	{
		// Token: 0x0400429E RID: 17054
		[Token(Token = "0x400429E")]
		NONE,
		// Token: 0x0400429F RID: 17055
		[Token(Token = "0x400429F")]
		B,
		// Token: 0x040042A0 RID: 17056
		[Token(Token = "0x40042A0")]
		A,
		// Token: 0x040042A1 RID: 17057
		[Token(Token = "0x40042A1")]
		S,
		// Token: 0x040042A2 RID: 17058
		[Token(Token = "0x40042A2")]
		SS
	}
}
