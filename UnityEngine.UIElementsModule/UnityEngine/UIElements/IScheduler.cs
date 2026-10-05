using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	internal interface IScheduler
	{
		// Token: 0x0600023F RID: 575
		[Token(Token = "0x600023F")]
		void Unschedule(ScheduledItem item);

		// Token: 0x06000240 RID: 576
		[Token(Token = "0x6000240")]
		void Schedule(ScheduledItem item);

		// Token: 0x06000241 RID: 577
		[Token(Token = "0x6000241")]
		void UpdateScheduledEvents();
	}
}
