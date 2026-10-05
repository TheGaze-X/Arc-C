using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	public interface IWillRenderCanvasTask : IHotfixable
	{
		// Token: 0x06000962 RID: 2402
		[Token(Token = "0x6000962")]
		void Pause();

		// Token: 0x06000963 RID: 2403
		[Token(Token = "0x6000963")]
		void Resume();

		// Token: 0x06000964 RID: 2404
		[Token(Token = "0x6000964")]
		void Release();
	}
}
