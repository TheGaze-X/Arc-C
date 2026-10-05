using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001146 RID: 4422
	[Token(Token = "0x2001146")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReturnMissionGroupType
	{
		// Token: 0x04005EC6 RID: 24262
		[Token(Token = "0x4005EC6")]
		DAILY,
		// Token: 0x04005EC7 RID: 24263
		[Token(Token = "0x4005EC7")]
		NORMAL,
		// Token: 0x04005EC8 RID: 24264
		[Token(Token = "0x4005EC8")]
		DIFF
	}
}
