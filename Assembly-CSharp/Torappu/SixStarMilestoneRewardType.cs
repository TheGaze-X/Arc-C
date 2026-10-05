using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200136D RID: 4973
	[Token(Token = "0x200136D")]
	[JsonConverter(typeof(StringEnumConverter))]
	[Serializable]
	public enum SixStarMilestoneRewardType
	{
		// Token: 0x04006E3B RID: 28219
		[Token(Token = "0x4006E3B")]
		UNLOCK_STAGE,
		// Token: 0x04006E3C RID: 28220
		[Token(Token = "0x4006E3C")]
		REWARD
	}
}
