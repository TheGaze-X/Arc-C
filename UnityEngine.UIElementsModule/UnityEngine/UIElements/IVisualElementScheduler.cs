using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	public interface IVisualElementScheduler
	{
		// Token: 0x06000592 RID: 1426
		[Token(Token = "0x6000592")]
		IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent);

		// Token: 0x06000593 RID: 1427
		[Token(Token = "0x6000593")]
		IVisualElementScheduledItem Execute(Action updateEvent);
	}
}
