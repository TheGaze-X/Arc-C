using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001004 RID: 4100
	[Token(Token = "0x2001004")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MailArchiveItemType
	{
		// Token: 0x040056FF RID: 22271
		[Token(Token = "0x40056FF")]
		NORMAL,
		// Token: 0x04005700 RID: 22272
		[Token(Token = "0x4005700")]
		BIRTHDAY,
		// Token: 0x04005701 RID: 22273
		[Token(Token = "0x4005701")]
		OPEN_SERVER
	}
}
