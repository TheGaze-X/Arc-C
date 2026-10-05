using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079D7 RID: 31191
	[Token(Token = "0x20079D7")]
	public class Act13SideDailyMissionCommitRequest
	{
		// Token: 0x0602BBE2 RID: 179170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBE2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act13SideDailyMissionCommitRequest()
		{
		}

		// Token: 0x0403F480 RID: 259200
		[Token(Token = "0x403F480")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403F481 RID: 259201
		[Token(Token = "0x403F481")]
		[FieldOffset(Offset = "0x18")]
		public int boardIdx;
	}
}
