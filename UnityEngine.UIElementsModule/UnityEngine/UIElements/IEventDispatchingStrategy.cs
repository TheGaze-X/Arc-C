using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	internal interface IEventDispatchingStrategy
	{
		// Token: 0x06000B9D RID: 2973
		[Token(Token = "0x6000B9D")]
		bool CanDispatchEvent(EventBase evt);

		// Token: 0x06000B9E RID: 2974
		[Token(Token = "0x6000B9E")]
		void DispatchEvent(EventBase evt, IPanel panel);
	}
}
