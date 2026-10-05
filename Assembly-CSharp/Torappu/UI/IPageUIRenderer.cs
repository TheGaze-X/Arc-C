using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200360F RID: 13839
	[Token(Token = "0x200360F")]
	public interface IPageUIRenderer : IHotfixable
	{
		// Token: 0x0601608F RID: 90255
		[Token(Token = "0x601608F")]
		void InitSortingInfo(SortingInfo sortingInfo);

		// Token: 0x06016090 RID: 90256
		[Token(Token = "0x6016090")]
		void AdjustToTargetLayer(SortingInfo sortingInfo);

		// Token: 0x06016091 RID: 90257
		[Token(Token = "0x6016091")]
		void RestoreLayers();
	}
}
