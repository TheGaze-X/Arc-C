using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EE3 RID: 20195
	[Token(Token = "0x2004EE3")]
	public class FifthAnnivExploreLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E21D RID: 123421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E21D")]
		[Address(RVA = "0x17CB680", Offset = "0x17CA280", VA = "0x1817CB680")]
		public void Render(FifthAnnivExploreLineView.RenderParam renderParam)
		{
		}

		// Token: 0x0601E21E RID: 123422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E21E")]
		[Address(RVA = "0x17CBBA0", Offset = "0x17CA7A0", VA = "0x1817CBBA0")]
		private void _PlayShowAnim()
		{
		}

		// Token: 0x0601E21F RID: 123423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E21F")]
		[Address(RVA = "0x17CBC70", Offset = "0x17CA870", VA = "0x1817CBC70")]
		public FifthAnnivExploreLineView()
		{
		}

		// Token: 0x04028184 RID: 164228
		[Token(Token = "0x4028184")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UILineRenderer _lineRenderer;

		// Token: 0x04028185 RID: 164229
		[Token(Token = "0x4028185")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04028186 RID: 164230
		[Token(Token = "0x4028186")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _durationFadein;

		// Token: 0x04028187 RID: 164231
		[Token(Token = "0x4028187")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _delayFadein;

		// Token: 0x04028188 RID: 164232
		[Token(Token = "0x4028188")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028189 RID: 164233
		[Token(Token = "0x4028189")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isShown;

		// Token: 0x0402818A RID: 164234
		[Token(Token = "0x402818A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402818B RID: 164235
		[Token(Token = "0x402818B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayShowAnim;

		// Token: 0x0402818C RID: 164236
		[Token(Token = "0x402818C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EE4 RID: 20196
		[Token(Token = "0x2004EE4")]
		public struct RenderParam
		{
			// Token: 0x0402818D RID: 164237
			[Token(Token = "0x402818D")]
			[FieldOffset(Offset = "0x0")]
			public FifthAnnivExploreMapLineViewModel lineViewModel;

			// Token: 0x0402818E RID: 164238
			[Token(Token = "0x402818E")]
			[FieldOffset(Offset = "0x8")]
			public bool isShadow;

			// Token: 0x0402818F RID: 164239
			[Token(Token = "0x402818F")]
			[FieldOffset(Offset = "0x9")]
			public bool needShowAnim;
		}
	}
}
