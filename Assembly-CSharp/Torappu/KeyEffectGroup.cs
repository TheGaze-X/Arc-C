using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001015 RID: 4117
	[Token(Token = "0x2001015")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum KeyEffectGroup
	{
		// Token: 0x04005773 RID: 22387
		[Token(Token = "0x4005773")]
		BATTLE,
		// Token: 0x04005774 RID: 22388
		[Token(Token = "0x4005774")]
		OUT_BATTLE,
		// Token: 0x04005775 RID: 22389
		[Token(Token = "0x4005775")]
		ALL
	}
}
