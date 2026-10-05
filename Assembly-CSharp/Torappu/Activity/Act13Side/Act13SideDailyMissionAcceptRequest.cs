using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079D3 RID: 31187
	[Token(Token = "0x20079D3")]
	public class Act13SideDailyMissionAcceptRequest
	{
		// Token: 0x0602BBDE RID: 179166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBDE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act13SideDailyMissionAcceptRequest()
		{
		}

		// Token: 0x0403F47C RID: 259196
		[Token(Token = "0x403F47C")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403F47D RID: 259197
		[Token(Token = "0x403F47D")]
		[FieldOffset(Offset = "0x18")]
		public int poolIdx;
	}
}
