using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006DA3 RID: 28067
	[Token(Token = "0x2006DA3")]
	public class ActivityConfirmCheckinRequest
	{
		// Token: 0x06027F9A RID: 163738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F9A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityConfirmCheckinRequest()
		{
		}

		// Token: 0x04038A78 RID: 232056
		[Token(Token = "0x4038A78")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x04038A79 RID: 232057
		[Token(Token = "0x4038A79")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;

		// Token: 0x04038A7A RID: 232058
		[Token(Token = "0x4038A7A")]
		[FieldOffset(Offset = "0x20")]
		public string dynOpt;
	}
}
