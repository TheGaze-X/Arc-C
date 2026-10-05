using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public interface IWithFallbackVideo
	{
		// Token: 0x1400002B RID: 43
		// (add) Token: 0x0600014C RID: 332
		// (remove) Token: 0x0600014D RID: 333
		[Token(Token = "0x1400002B")]
		event EventHandler<EventArgs<Rect>> VideoRectChanged;

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600014E RID: 334
		[Token(Token = "0x17000020")]
		Texture2D VideoTexture { [Token(Token = "0x600014E")] get; }

		// Token: 0x0600014F RID: 335
		[Token(Token = "0x600014F")]
		void SetFallbackVideoEnabled(bool enabled);
	}
}
