using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FB3 RID: 4019
	[Token(Token = "0x2000FB3")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrisisV2RunePackType
	{
		// Token: 0x04005548 RID: 21832
		[Token(Token = "0x4005548")]
		NONE,
		// Token: 0x04005549 RID: 21833
		[Token(Token = "0x4005549")]
		HIGHEST_TOTAL_SCORE
	}
}
