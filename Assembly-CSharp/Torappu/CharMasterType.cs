using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F72 RID: 3954
	[Token(Token = "0x2000F72")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CharMasterType
	{
		// Token: 0x040053F4 RID: 21492
		[Token(Token = "0x40053F4")]
		NONE,
		// Token: 0x040053F5 RID: 21493
		[Token(Token = "0x40053F5")]
		SYSTEM,
		// Token: 0x040053F6 RID: 21494
		[Token(Token = "0x40053F6")]
		BATTLE
	}
}
