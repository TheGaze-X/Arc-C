using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E35 RID: 3637
	[Token(Token = "0x2000E35")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActMultiV3IdentityType
	{
		// Token: 0x04004BA7 RID: 19367
		[Token(Token = "0x4004BA7")]
		NONE,
		// Token: 0x04004BA8 RID: 19368
		[Token(Token = "0x4004BA8")]
		HIGH,
		// Token: 0x04004BA9 RID: 19369
		[Token(Token = "0x4004BA9")]
		LOW,
		// Token: 0x04004BAA RID: 19370
		[Token(Token = "0x4004BAA")]
		TEMPORARY,
		// Token: 0x04004BAB RID: 19371
		[Token(Token = "0x4004BAB")]
		ALL
	}
}
