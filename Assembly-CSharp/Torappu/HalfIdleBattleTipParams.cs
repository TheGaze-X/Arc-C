using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001085 RID: 4229
	[Token(Token = "0x2001085")]
	public class HalfIdleBattleTipParams
	{
		// Token: 0x06006E15 RID: 28181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E15")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HalfIdleBattleTipParams()
		{
		}

		// Token: 0x04005A48 RID: 23112
		[Token(Token = "0x4005A48")]
		[FieldOffset(Offset = "0x10")]
		public bool isShow;

		// Token: 0x04005A49 RID: 23113
		[Token(Token = "0x4005A49")]
		[FieldOffset(Offset = "0x14")]
		public HalfIdleBattleTipItemType tipType;
	}
}
