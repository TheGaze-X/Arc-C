using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D33 RID: 27955
	[Token(Token = "0x2006D33")]
	public class ActivityGetCollectionRewardRequest
	{
		// Token: 0x06027D9E RID: 163230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D9E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityGetCollectionRewardRequest()
		{
		}

		// Token: 0x040387CE RID: 231374
		[Token(Token = "0x40387CE")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x040387CF RID: 231375
		[Token(Token = "0x40387CF")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;
	}
}
