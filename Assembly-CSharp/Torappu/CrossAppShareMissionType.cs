using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001113 RID: 4371
	[Token(Token = "0x2001113")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrossAppShareMissionType
	{
		// Token: 0x04005DAC RID: 23980
		[Token(Token = "0x4005DAC")]
		NORMAL,
		// Token: 0x04005DAD RID: 23981
		[Token(Token = "0x4005DAD")]
		ACTIVITY
	}
}
