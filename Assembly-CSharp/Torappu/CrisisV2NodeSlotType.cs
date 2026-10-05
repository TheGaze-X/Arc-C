using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FB1 RID: 4017
	[Token(Token = "0x2000FB1")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrisisV2NodeSlotType
	{
		// Token: 0x0400553E RID: 21822
		[Token(Token = "0x400553E")]
		NONE,
		// Token: 0x0400553F RID: 21823
		[Token(Token = "0x400553F")]
		START,
		// Token: 0x04005540 RID: 21824
		[Token(Token = "0x4005540")]
		NORMAL,
		// Token: 0x04005541 RID: 21825
		[Token(Token = "0x4005541")]
		KEYPOINT,
		// Token: 0x04005542 RID: 21826
		[Token(Token = "0x4005542")]
		TREASURE
	}
}
