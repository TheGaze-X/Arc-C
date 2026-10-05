using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FFB RID: 4091
	[Token(Token = "0x2000FFB")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NameCardV2ModuleType
	{
		// Token: 0x040056C5 RID: 22213
		[Token(Token = "0x40056C5")]
		NONE,
		// Token: 0x040056C6 RID: 22214
		[Token(Token = "0x40056C6")]
		BACKGROUND,
		// Token: 0x040056C7 RID: 22215
		[Token(Token = "0x40056C7")]
		ILLUST,
		// Token: 0x040056C8 RID: 22216
		[Token(Token = "0x40056C8")]
		COLLECT,
		// Token: 0x040056C9 RID: 22217
		[Token(Token = "0x40056C9")]
		AVATAR,
		// Token: 0x040056CA RID: 22218
		[Token(Token = "0x40056CA")]
		REMOVABLE,
		// Token: 0x040056CB RID: 22219
		[Token(Token = "0x40056CB")]
		AVATAR_SIMPLE
	}
}
