using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001149 RID: 4425
	[Token(Token = "0x2001149")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReturnAllOpenType
	{
		// Token: 0x04005EDA RID: 24282
		[Token(Token = "0x4005EDA")]
		RESOURCE,
		// Token: 0x04005EDB RID: 24283
		[Token(Token = "0x4005EDB")]
		CAMP
	}
}
