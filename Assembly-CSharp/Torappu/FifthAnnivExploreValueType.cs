using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200104A RID: 4170
	[Token(Token = "0x200104A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FifthAnnivExploreValueType
	{
		// Token: 0x04005894 RID: 22676
		[Token(Token = "0x4005894")]
		TEAMVALUE_1,
		// Token: 0x04005895 RID: 22677
		[Token(Token = "0x4005895")]
		TEAMVALUE_2,
		// Token: 0x04005896 RID: 22678
		[Token(Token = "0x4005896")]
		TEAMVALUE_3
	}
}
