using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020010E8 RID: 4328
	[Token(Token = "0x20010E8")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MedalExpireType
	{
		// Token: 0x04005CC0 RID: 23744
		[Token(Token = "0x4005CC0")]
		NONE,
		// Token: 0x04005CC1 RID: 23745
		[Token(Token = "0x4005CC1")]
		INIT,
		// Token: 0x04005CC2 RID: 23746
		[Token(Token = "0x4005CC2")]
		TEMP,
		// Token: 0x04005CC3 RID: 23747
		[Token(Token = "0x4005CC3")]
		PERM
	}
}
