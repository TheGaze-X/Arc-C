using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001285 RID: 4741
	[Token(Token = "0x2001285")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2RacerTalentType
	{
		// Token: 0x04006894 RID: 26772
		[Token(Token = "0x4006894")]
		BORN,
		// Token: 0x04006895 RID: 26773
		[Token(Token = "0x4006895")]
		LEARNED
	}
}
