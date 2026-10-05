using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ECC RID: 20172
	[Token(Token = "0x2004ECC")]
	public abstract class FifthAnnivExploreValueAbstractView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E18E RID: 123278
		[Token(Token = "0x601E18E")]
		public abstract void Render(FifthAnnivExploreValueViewConfig config, FifthAnnivExploreValueViewModel viewModel, bool showNum);

		// Token: 0x0601E18F RID: 123279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E18F")]
		[Address(RVA = "0x17DA1F0", Offset = "0x17D8DF0", VA = "0x1817DA1F0")]
		protected FifthAnnivExploreValueAbstractView()
		{
		}

		// Token: 0x040280A6 RID: 164006
		[Token(Token = "0x40280A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
