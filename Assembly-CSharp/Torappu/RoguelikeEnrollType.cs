using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011CD RID: 4557
	[Token(Token = "0x20011CD")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeEnrollType
	{
		// Token: 0x040061A3 RID: 24995
		[Token(Token = "0x40061A3")]
		DLC,
		// Token: 0x040061A4 RID: 24996
		[Token(Token = "0x40061A4")]
		REVIEW
	}
}
