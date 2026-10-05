using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078CE RID: 30926
	[Token(Token = "0x20078CE")]
	public class Act1LockMainModel
	{
		// Token: 0x0602B5E8 RID: 177640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5E8")]
		[Address(RVA = "0x27278D0", Offset = "0x27264D0", VA = "0x1827278D0")]
		public void Clear()
		{
		}

		// Token: 0x0602B5E9 RID: 177641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5E9")]
		[Address(RVA = "0x2727940", Offset = "0x2726540", VA = "0x182727940")]
		public Act1LockMainModel()
		{
		}

		// Token: 0x0403EB74 RID: 256884
		[Token(Token = "0x403EB74")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403EB75 RID: 256885
		[Token(Token = "0x403EB75")]
		[FieldOffset(Offset = "0x18")]
		public int pointCnt;

		// Token: 0x0403EB76 RID: 256886
		[Token(Token = "0x403EB76")]
		[FieldOffset(Offset = "0x1C")]
		public int missionCnt;

		// Token: 0x0403EB77 RID: 256887
		[Token(Token = "0x403EB77")]
		[FieldOffset(Offset = "0x20")]
		public int finishedCnt;

		// Token: 0x0403EB78 RID: 256888
		[Token(Token = "0x403EB78")]
		[FieldOffset(Offset = "0x28")]
		public List<int> defendedStages;

		// Token: 0x0403EB79 RID: 256889
		[Token(Token = "0x403EB79")]
		[FieldOffset(Offset = "0x30")]
		public bool unlockFinal;
	}
}
