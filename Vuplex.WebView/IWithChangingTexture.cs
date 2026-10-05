using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public interface IWithChangingTexture
	{
		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000143 RID: 323
		// (remove) Token: 0x06000144 RID: 324
		[Token(Token = "0x14000028")]
		event EventHandler<EventArgs<Texture2D>> TextureChanged;
	}
}
