using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200209B RID: 8347
	[Token(Token = "0x200209B")]
	public class TimeCondTriggerHolder : TrackTriggerHolder<TimeCondTrigger>, IVersionTrackTriggerHolder
	{
		// Token: 0x0600CD85 RID: 52613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD85")]
		[Address(RVA = "0x35054B0", Offset = "0x35040B0", VA = "0x1835054B0", Slot = "7")]
		protected override void OnTriggerAdded(TimeCondTrigger trigger)
		{
		}

		// Token: 0x0600CD86 RID: 52614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD86")]
		[Address(RVA = "0x3505260", Offset = "0x3503E60", VA = "0x183505260", Slot = "8")]
		public void OnEnterGame()
		{
		}

		// Token: 0x0600CD87 RID: 52615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD87")]
		[Address(RVA = "0x3505200", Offset = "0x3503E00", VA = "0x183505200", Slot = "9")]
		public void OnCrossDay()
		{
		}

		// Token: 0x0600CD88 RID: 52616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD88")]
		[Address(RVA = "0x3505620", Offset = "0x3504220", VA = "0x183505620")]
		public TimeCondTriggerHolder()
		{
		}

		// Token: 0x0400D8D5 RID: 55509
		[Token(Token = "0x400D8D5")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, List<TimeCondTrigger>> m_typedTriggers;

		// Token: 0x0400D8D6 RID: 55510
		[Token(Token = "0x400D8D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTriggerAdded;

		// Token: 0x0400D8D7 RID: 55511
		[Token(Token = "0x400D8D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnterGame;

		// Token: 0x0400D8D8 RID: 55512
		[Token(Token = "0x400D8D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCrossDay;

		// Token: 0x0400D8D9 RID: 55513
		[Token(Token = "0x400D8D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
