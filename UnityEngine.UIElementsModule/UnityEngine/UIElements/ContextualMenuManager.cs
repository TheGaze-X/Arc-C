using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public abstract class ContextualMenuManager
	{
		// Token: 0x0600006B RID: 107
		[Token(Token = "0x600006B")]
		public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);

		// Token: 0x0600006C RID: 108
		[Token(Token = "0x600006C")]
		protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);
	}
}
