using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007275 RID: 29301
	[Token(Token = "0x2007275")]
	public class Act4D0FinishStoryRequest
	{
		// Token: 0x06029819 RID: 170009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029819")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4D0FinishStoryRequest()
		{
		}

		// Token: 0x0403B4E9 RID: 242921
		[Token(Token = "0x403B4E9")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403B4EA RID: 242922
		[Token(Token = "0x403B4EA")]
		[FieldOffset(Offset = "0x18")]
		public string storyId;
	}
}
