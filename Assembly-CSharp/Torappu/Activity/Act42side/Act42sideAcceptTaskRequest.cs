using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42side
{
	// Token: 0x020072F9 RID: 29433
	[Token(Token = "0x20072F9")]
	public class Act42sideAcceptTaskRequest
	{
		// Token: 0x06029A59 RID: 170585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A59")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act42sideAcceptTaskRequest()
		{
		}

		// Token: 0x0403B923 RID: 244003
		[Token(Token = "0x403B923")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403B924 RID: 244004
		[Token(Token = "0x403B924")]
		[FieldOffset(Offset = "0x18")]
		public string taskId;
	}
}
