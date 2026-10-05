using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200129C RID: 4764
	[Token(Token = "0x200129C")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2CraftItemUnlockType
	{
		// Token: 0x04006900 RID: 26880
		[Token(Token = "0x4006900")]
		INITIAL,
		// Token: 0x04006901 RID: 26881
		[Token(Token = "0x4006901")]
		UPGRADE_BASE,
		// Token: 0x04006902 RID: 26882
		[Token(Token = "0x4006902")]
		GAIN,
		// Token: 0x04006903 RID: 26883
		[Token(Token = "0x4006903")]
		GAIN_ITEM
	}
}
