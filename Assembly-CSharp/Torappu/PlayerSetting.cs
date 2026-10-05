using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B77 RID: 2935
	[Token(Token = "0x2000B77")]
	public class PlayerSetting
	{
		// Token: 0x06006816 RID: 26646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006816")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSetting()
		{
		}

		// Token: 0x04003CF7 RID: 15607
		[Token(Token = "0x4003CF7")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("perf")]
		public PlayerSettingPerf settingPerf;
	}
}
