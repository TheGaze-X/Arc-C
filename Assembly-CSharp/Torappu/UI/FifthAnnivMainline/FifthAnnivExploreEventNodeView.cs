using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EEB RID: 20203
	[Token(Token = "0x2004EEB")]
	public class FifthAnnivExploreEventNodeView : FifthAnnivExploreAbstractNodeView
	{
		// Token: 0x0601E233 RID: 123443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E233")]
		[Address(RVA = "0x17CA950", Offset = "0x17C9550", VA = "0x1817CA950", Slot = "4")]
		public override void Render(FifthAnnivExploreMapNodeViewModel nodeViewModel, int currentIndexInRoute)
		{
		}

		// Token: 0x0601E234 RID: 123444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E234")]
		[Address(RVA = "0x17CAAA0", Offset = "0x17C96A0", VA = "0x1817CAAA0")]
		public FifthAnnivExploreEventNodeView()
		{
		}

		// Token: 0x040281B1 RID: 164273
		[Token(Token = "0x40281B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040281B2 RID: 164274
		[Token(Token = "0x40281B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _durationShow;

		// Token: 0x040281B3 RID: 164275
		[Token(Token = "0x40281B3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _delayShow;

		// Token: 0x040281B4 RID: 164276
		[Token(Token = "0x40281B4")]
		[FieldOffset(Offset = "0x28")]
		private bool m_cachedIsCurrent;

		// Token: 0x040281B5 RID: 164277
		[Token(Token = "0x40281B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040281B6 RID: 164278
		[Token(Token = "0x40281B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
