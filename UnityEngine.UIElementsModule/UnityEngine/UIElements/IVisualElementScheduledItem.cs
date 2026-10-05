using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public interface IVisualElementScheduledItem
	{
		// Token: 0x0600058D RID: 1421
		[Token(Token = "0x600058D")]
		void Resume();

		// Token: 0x0600058E RID: 1422
		[Token(Token = "0x600058E")]
		void Pause();

		// Token: 0x0600058F RID: 1423
		[Token(Token = "0x600058F")]
		void ExecuteLater(long delayMs);

		// Token: 0x06000590 RID: 1424
		[Token(Token = "0x6000590")]
		IVisualElementScheduledItem StartingIn(long delayMs);

		// Token: 0x06000591 RID: 1425
		[Token(Token = "0x6000591")]
		IVisualElementScheduledItem Every(long intervalMs);
	}
}
