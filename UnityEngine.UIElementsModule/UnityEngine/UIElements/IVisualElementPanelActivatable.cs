using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	internal interface IVisualElementPanelActivatable
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000594 RID: 1428
		[Token(Token = "0x1700013E")]
		VisualElement element { [Token(Token = "0x6000594")] get; }

		// Token: 0x06000595 RID: 1429
		[Token(Token = "0x6000595")]
		bool CanBeActivated();

		// Token: 0x06000596 RID: 1430
		[Token(Token = "0x6000596")]
		void OnPanelActivate();

		// Token: 0x06000597 RID: 1431
		[Token(Token = "0x6000597")]
		void OnPanelDeactivate();
	}
}
