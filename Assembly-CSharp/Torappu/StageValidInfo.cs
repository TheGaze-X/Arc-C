using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200134A RID: 4938
	[Token(Token = "0x200134A")]
	[Serializable]
	public class StageValidInfo : ITimeValidInfo
	{
		// Token: 0x06007305 RID: 29445 RVA: 0x00033030 File Offset: 0x00031230
		[Token(Token = "0x6007305")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x00033048 File Offset: 0x00031248
		[Token(Token = "0x6007306")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007307")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StageValidInfo()
		{
		}

		// Token: 0x04006D76 RID: 28022
		[Token(Token = "0x4006D76")]
		[FieldOffset(Offset = "0x10")]
		public long startTs;

		// Token: 0x04006D77 RID: 28023
		[Token(Token = "0x4006D77")]
		[FieldOffset(Offset = "0x18")]
		public long endTs;
	}
}
