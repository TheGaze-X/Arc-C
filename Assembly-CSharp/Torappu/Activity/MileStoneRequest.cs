using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D8D RID: 28045
	[Token(Token = "0x2006D8D")]
	public class MileStoneRequest
	{
		// Token: 0x06027F37 RID: 163639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F37")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MileStoneRequest()
		{
		}

		// Token: 0x040389E6 RID: 231910
		[Token(Token = "0x40389E6")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040389E7 RID: 231911
		[Token(Token = "0x40389E7")]
		[FieldOffset(Offset = "0x18")]
		public string rewardId;
	}
}
