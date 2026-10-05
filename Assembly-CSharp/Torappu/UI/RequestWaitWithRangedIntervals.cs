using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003965 RID: 14693
	[Token(Token = "0x2003965")]
	public class RequestWaitWithRangedIntervals : LoopRequestSender.IRequestWaitStrategy, IHotfixable
	{
		// Token: 0x06017371 RID: 95089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017371")]
		[Address(RVA = "0xF8FF20", Offset = "0xF8EB20", VA = "0x180F8FF20")]
		public RequestWaitWithRangedIntervals(int interval, int times, int fallbackWait, int delay = 0)
		{
		}

		// Token: 0x06017372 RID: 95090 RVA: 0x00095568 File Offset: 0x00093768
		[Token(Token = "0x6017372")]
		[Address(RVA = "0xF8FDF0", Offset = "0xF8E9F0", VA = "0x180F8FDF0", Slot = "4")]
		public bool IsWaitEnough(LoopRequestSender.RequestWaitParam waitParam)
		{
			return default(bool);
		}

		// Token: 0x0401C055 RID: 114773
		[Token(Token = "0x401C055")]
		[FieldOffset(Offset = "0x10")]
		private int m_interval;

		// Token: 0x0401C056 RID: 114774
		[Token(Token = "0x401C056")]
		[FieldOffset(Offset = "0x14")]
		private int m_times;

		// Token: 0x0401C057 RID: 114775
		[Token(Token = "0x401C057")]
		[FieldOffset(Offset = "0x18")]
		private int m_fallbackWait;

		// Token: 0x0401C058 RID: 114776
		[Token(Token = "0x401C058")]
		[FieldOffset(Offset = "0x1C")]
		private int m_delay;

		// Token: 0x0401C059 RID: 114777
		[Token(Token = "0x401C059")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C05A RID: 114778
		[Token(Token = "0x401C05A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsWaitEnough;
	}
}
