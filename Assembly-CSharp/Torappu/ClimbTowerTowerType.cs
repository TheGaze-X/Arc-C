using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F90 RID: 3984
	[Token(Token = "0x2000F90")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ClimbTowerTowerType
	{
		// Token: 0x0400549C RID: 21660
		[Token(Token = "0x400549C")]
		TRAINING,
		// Token: 0x0400549D RID: 21661
		[Token(Token = "0x400549D")]
		NORMAL
	}
}
