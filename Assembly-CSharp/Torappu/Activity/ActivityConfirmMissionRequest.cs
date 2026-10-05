using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D25 RID: 27941
	[Token(Token = "0x2006D25")]
	public class ActivityConfirmMissionRequest
	{
		// Token: 0x06027D8C RID: 163212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D8C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityConfirmMissionRequest()
		{
		}

		// Token: 0x040387B2 RID: 231346
		[Token(Token = "0x40387B2")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x040387B3 RID: 231347
		[Token(Token = "0x40387B3")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;
	}
}
