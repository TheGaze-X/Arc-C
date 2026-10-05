using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.AVG
{
	// Token: 0x02001F79 RID: 8057
	[Token(Token = "0x2001F79")]
	public interface IChatDelayView : UIRecycleLayoutAdapter.IVirtualView, IHotfixable
	{
		// Token: 0x0600C848 RID: 51272
		[Token(Token = "0x600C848")]
		void ResetDelay(float delay);
	}
}
