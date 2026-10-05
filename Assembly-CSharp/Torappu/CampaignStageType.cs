using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F39 RID: 3897
	[Token(Token = "0x2000F39")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CampaignStageType
	{
		// Token: 0x040052EE RID: 21230
		[Token(Token = "0x40052EE")]
		NONE,
		// Token: 0x040052EF RID: 21231
		[Token(Token = "0x40052EF")]
		PERMANENT,
		// Token: 0x040052F0 RID: 21232
		[Token(Token = "0x40052F0")]
		ROTATE,
		// Token: 0x040052F1 RID: 21233
		[Token(Token = "0x40052F1")]
		TRAINING
	}
}
