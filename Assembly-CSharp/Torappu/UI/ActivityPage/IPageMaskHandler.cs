using System;
using System.Collections;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityPage
{
	// Token: 0x02006777 RID: 26487
	[Token(Token = "0x2006777")]
	public interface IPageMaskHandler : IHotfixable
	{
		// Token: 0x06025FEA RID: 155626
		[Token(Token = "0x6025FEA")]
		IEnumerator ShowMask();

		// Token: 0x06025FEB RID: 155627
		[Token(Token = "0x6025FEB")]
		void HideMask();

		// Token: 0x06025FEC RID: 155628
		[Token(Token = "0x6025FEC")]
		void ResetMask(bool isShow);

		// Token: 0x170059E6 RID: 23014
		// (get) Token: 0x06025FED RID: 155629
		[Token(Token = "0x170059E6")]
		bool isPlaying { [Token(Token = "0x6025FED")] get; }
	}
}
