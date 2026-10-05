using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007DE RID: 2014
	[Token(Token = "0x20007DE")]
	public class RetroGetPassRewardRequest
	{
		// Token: 0x06006469 RID: 25705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006469")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RetroGetPassRewardRequest()
		{
		}

		// Token: 0x04003100 RID: 12544
		[Token(Token = "0x4003100")]
		[FieldOffset(Offset = "0x10")]
		public string retroId;

		// Token: 0x04003101 RID: 12545
		[Token(Token = "0x4003101")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;
	}
}
