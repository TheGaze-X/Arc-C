using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42side
{
	// Token: 0x020072FB RID: 29435
	[Token(Token = "0x20072FB")]
	public class Act42sideSubmitTaskRequest
	{
		// Token: 0x06029A5B RID: 170587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A5B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act42sideSubmitTaskRequest()
		{
		}

		// Token: 0x0403B925 RID: 244005
		[Token(Token = "0x403B925")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403B926 RID: 244006
		[Token(Token = "0x403B926")]
		[FieldOffset(Offset = "0x18")]
		public string taskId;
	}
}
