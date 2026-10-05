using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001359 RID: 4953
	[Token(Token = "0x2001359")]
	public class OverrideUnlockInfo
	{
		// Token: 0x06007320 RID: 29472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007320")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OverrideUnlockInfo()
		{
		}

		// Token: 0x04006DED RID: 28141
		[Token(Token = "0x4006DED")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04006DEE RID: 28142
		[Token(Token = "0x4006DEE")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x04006DEF RID: 28143
		[Token(Token = "0x4006DEF")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x04006DF0 RID: 28144
		[Token(Token = "0x4006DF0")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, List<StageData.ConditionDesc>> unlockDict;
	}
}
