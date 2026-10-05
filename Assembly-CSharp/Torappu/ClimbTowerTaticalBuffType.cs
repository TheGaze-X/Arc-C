using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F8F RID: 3983
	[Token(Token = "0x2000F8F")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ClimbTowerTaticalBuffType
	{
		// Token: 0x04005499 RID: 21657
		[Token(Token = "0x4005499")]
		A,
		// Token: 0x0400549A RID: 21658
		[Token(Token = "0x400549A")]
		B
	}
}
