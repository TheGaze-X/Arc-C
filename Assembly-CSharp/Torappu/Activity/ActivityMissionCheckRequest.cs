using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D35 RID: 27957
	[Token(Token = "0x2006D35")]
	public class ActivityMissionCheckRequest
	{
		// Token: 0x06027DA0 RID: 163232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DA0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityMissionCheckRequest()
		{
		}

		// Token: 0x040387D1 RID: 231377
		[Token(Token = "0x40387D1")]
		[FieldOffset(Offset = "0x10")]
		public List<string> missionIds;

		// Token: 0x040387D2 RID: 231378
		[Token(Token = "0x40387D2")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;
	}
}
