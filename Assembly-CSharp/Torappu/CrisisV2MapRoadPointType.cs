using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FB2 RID: 4018
	[Token(Token = "0x2000FB2")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrisisV2MapRoadPointType
	{
		// Token: 0x04005544 RID: 21828
		[Token(Token = "0x4005544")]
		NONE,
		// Token: 0x04005545 RID: 21829
		[Token(Token = "0x4005545")]
		NODE,
		// Token: 0x04005546 RID: 21830
		[Token(Token = "0x4005546")]
		BAG
	}
}
