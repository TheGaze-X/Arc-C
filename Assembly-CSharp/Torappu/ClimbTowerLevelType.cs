using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F8E RID: 3982
	[Token(Token = "0x2000F8E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ClimbTowerLevelType
	{
		// Token: 0x04005495 RID: 21653
		[Token(Token = "0x4005495")]
		NORMAL,
		// Token: 0x04005496 RID: 21654
		[Token(Token = "0x4005496")]
		HIGHLEVEL,
		// Token: 0x04005497 RID: 21655
		[Token(Token = "0x4005497")]
		BOSS
	}
}
