using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EED RID: 20205
	[Token(Token = "0x2004EED")]
	public class FifthAnnivExploreNodeShadowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E238 RID: 123448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E238")]
		[Address(RVA = "0x17D6EA0", Offset = "0x17D5AA0", VA = "0x1817D6EA0")]
		public void Render(FifthAnnivExploreMapNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601E239 RID: 123449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E239")]
		[Address(RVA = "0x17D71F0", Offset = "0x17D5DF0", VA = "0x1817D71F0")]
		private void _PlayShowAnim(float delay)
		{
		}

		// Token: 0x0601E23A RID: 123450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E23A")]
		[Address(RVA = "0x17D72D0", Offset = "0x17D5ED0", VA = "0x1817D72D0")]
		public FifthAnnivExploreNodeShadowView()
		{
		}

		// Token: 0x040281C3 RID: 164291
		[Token(Token = "0x40281C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Graphic _graphicNode;

		// Token: 0x040281C4 RID: 164292
		[Token(Token = "0x40281C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040281C5 RID: 164293
		[Token(Token = "0x40281C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _durationFadein;

		// Token: 0x040281C6 RID: 164294
		[Token(Token = "0x40281C6")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _delayFirstNodeShow;

		// Token: 0x040281C7 RID: 164295
		[Token(Token = "0x40281C7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _delayShow;

		// Token: 0x040281C8 RID: 164296
		[Token(Token = "0x40281C8")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040281C9 RID: 164297
		[Token(Token = "0x40281C9")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 m_cachedPos;

		// Token: 0x040281CA RID: 164298
		[Token(Token = "0x40281CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040281CB RID: 164299
		[Token(Token = "0x40281CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayShowAnim;

		// Token: 0x040281CC RID: 164300
		[Token(Token = "0x40281CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
