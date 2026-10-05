using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001139 RID: 4409
	[Token(Token = "0x2001139")]
	[Serializable]
	public class RetroTrailData
	{
		// Token: 0x06006F0F RID: 28431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RetroTrailData()
		{
		}

		// Token: 0x04005E7E RID: 24190
		[Token(Token = "0x4005E7E")]
		[FieldOffset(Offset = "0x10")]
		public string retroId;

		// Token: 0x04005E7F RID: 24191
		[Token(Token = "0x4005E7F")]
		[FieldOffset(Offset = "0x18")]
		public long trailStartTime;

		// Token: 0x04005E80 RID: 24192
		[Token(Token = "0x4005E80")]
		[FieldOffset(Offset = "0x20")]
		public List<RetroTrailRewardItem> trailRewardList;

		// Token: 0x04005E81 RID: 24193
		[Token(Token = "0x4005E81")]
		[FieldOffset(Offset = "0x28")]
		public List<string> stageList;

		// Token: 0x04005E82 RID: 24194
		[Token(Token = "0x4005E82")]
		[FieldOffset(Offset = "0x30")]
		public string relatedChar;

		// Token: 0x04005E83 RID: 24195
		[Token(Token = "0x4005E83")]
		[FieldOffset(Offset = "0x38")]
		public string relatedFullPotentialItemId;

		// Token: 0x04005E84 RID: 24196
		[Token(Token = "0x4005E84")]
		[FieldOffset(Offset = "0x40")]
		public string themeColor;

		// Token: 0x04005E85 RID: 24197
		[Token(Token = "0x4005E85")]
		[FieldOffset(Offset = "0x48")]
		public string fullPotentialItemId;
	}
}
