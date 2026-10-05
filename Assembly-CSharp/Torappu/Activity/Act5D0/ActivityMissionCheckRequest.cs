using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071E7 RID: 29159
	[Token(Token = "0x20071E7")]
	public class ActivityMissionCheckRequest
	{
		// Token: 0x060295DB RID: 169435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295DB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityMissionCheckRequest()
		{
		}

		// Token: 0x0403B137 RID: 241975
		[Token(Token = "0x403B137")]
		[FieldOffset(Offset = "0x10")]
		public List<string> missionIds;

		// Token: 0x0403B138 RID: 241976
		[Token(Token = "0x403B138")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;
	}
}
