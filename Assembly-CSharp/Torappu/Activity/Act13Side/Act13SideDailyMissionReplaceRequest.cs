using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079D9 RID: 31193
	[Token(Token = "0x20079D9")]
	public class Act13SideDailyMissionReplaceRequest
	{
		// Token: 0x0602BBE4 RID: 179172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBE4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act13SideDailyMissionReplaceRequest()
		{
		}

		// Token: 0x0403F485 RID: 259205
		[Token(Token = "0x403F485")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403F486 RID: 259206
		[Token(Token = "0x403F486")]
		[FieldOffset(Offset = "0x18")]
		public int[] boardIdxs;

		// Token: 0x0403F487 RID: 259207
		[Token(Token = "0x403F487")]
		[FieldOffset(Offset = "0x20")]
		public int poolIdx;
	}
}
