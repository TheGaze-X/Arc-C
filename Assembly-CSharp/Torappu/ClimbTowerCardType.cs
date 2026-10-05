using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F91 RID: 3985
	[Token(Token = "0x2000F91")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ClimbTowerCardType
	{
		// Token: 0x0400549F RID: 21663
		[Token(Token = "0x400549F")]
		SEASON,
		// Token: 0x040054A0 RID: 21664
		[Token(Token = "0x40054A0")]
		TOWER
	}
}
