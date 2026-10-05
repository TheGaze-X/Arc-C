using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079D5 RID: 31189
	[Token(Token = "0x20079D5")]
	public class Act13SideDailyMissionCancelRequest
	{
		// Token: 0x0602BBE0 RID: 179168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBE0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act13SideDailyMissionCancelRequest()
		{
		}

		// Token: 0x0403F47E RID: 259198
		[Token(Token = "0x403F47E")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403F47F RID: 259199
		[Token(Token = "0x403F47F")]
		[FieldOffset(Offset = "0x18")]
		public int boardIdx;
	}
}
