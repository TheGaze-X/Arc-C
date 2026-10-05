using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003490 RID: 13456
	[Token(Token = "0x2003490")]
	public class AutoChessModeUnlockPushMsg
	{
		// Token: 0x0601574B RID: 87883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601574B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessModeUnlockPushMsg()
		{
		}

		// Token: 0x04019AF8 RID: 105208
		[Token(Token = "0x4019AF8")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04019AF9 RID: 105209
		[Token(Token = "0x4019AF9")]
		[FieldOffset(Offset = "0x18")]
		public string modeId;
	}
}
