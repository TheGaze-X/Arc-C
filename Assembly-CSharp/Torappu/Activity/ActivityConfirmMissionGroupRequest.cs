using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D28 RID: 27944
	[Token(Token = "0x2006D28")]
	public class ActivityConfirmMissionGroupRequest
	{
		// Token: 0x06027D93 RID: 163219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D93")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityConfirmMissionGroupRequest()
		{
		}

		// Token: 0x040387B9 RID: 231353
		[Token(Token = "0x40387B9")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x040387BA RID: 231354
		[Token(Token = "0x40387BA")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;
	}
}
