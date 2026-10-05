using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A0 RID: 416
	[Token(Token = "0x20001A0")]
	public interface IEventHandler
	{
		// Token: 0x06000B77 RID: 2935
		[Token(Token = "0x6000B77")]
		void SendEvent(EventBase e);

		// Token: 0x06000B78 RID: 2936
		[Token(Token = "0x6000B78")]
		void HandleEvent(EventBase evt);
	}
}
