using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public interface ICanvasElement
	{
		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		void Rebuild(CanvasUpdate executing);

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27
		[Token(Token = "0x17000009")]
		Transform transform { [Token(Token = "0x600001B")] get; }

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		void LayoutComplete();

		// Token: 0x0600001D RID: 29
		[Token(Token = "0x600001D")]
		void GraphicUpdateComplete();

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		bool IsDestroyed();
	}
}
