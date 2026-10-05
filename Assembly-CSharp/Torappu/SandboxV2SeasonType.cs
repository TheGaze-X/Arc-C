using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200127F RID: 4735
	[Token(Token = "0x200127F")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2SeasonType
	{
		// Token: 0x04006870 RID: 26736
		[Token(Token = "0x4006870")]
		NONE,
		// Token: 0x04006871 RID: 26737
		[Token(Token = "0x4006871")]
		DRY,
		// Token: 0x04006872 RID: 26738
		[Token(Token = "0x4006872")]
		RAINY,
		// Token: 0x04006873 RID: 26739
		[Token(Token = "0x4006873")]
		CHALLENGE
	}
}
