using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079DD RID: 31197
	[Token(Token = "0x20079DD")]
	public class Act13SideLongTermMissionCommitRequest
	{
		// Token: 0x0602BBE8 RID: 179176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBE8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act13SideLongTermMissionCommitRequest()
		{
		}

		// Token: 0x0403F48C RID: 259212
		[Token(Token = "0x403F48C")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403F48D RID: 259213
		[Token(Token = "0x403F48D")]
		[FieldOffset(Offset = "0x18")]
		public string missionId;
	}
}
