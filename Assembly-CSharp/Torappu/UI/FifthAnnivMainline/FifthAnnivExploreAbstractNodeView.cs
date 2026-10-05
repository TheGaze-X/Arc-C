using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EE5 RID: 20197
	[Token(Token = "0x2004EE5")]
	public abstract class FifthAnnivExploreAbstractNodeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E220 RID: 123424
		[Token(Token = "0x601E220")]
		public abstract void Render(FifthAnnivExploreMapNodeViewModel nodeViewModel, int currentIndexInRoute);

		// Token: 0x0601E221 RID: 123425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E221")]
		[Address(RVA = "0x17C98A0", Offset = "0x17C84A0", VA = "0x1817C98A0")]
		protected FifthAnnivExploreAbstractNodeView()
		{
		}

		// Token: 0x04028190 RID: 164240
		[Token(Token = "0x4028190")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
