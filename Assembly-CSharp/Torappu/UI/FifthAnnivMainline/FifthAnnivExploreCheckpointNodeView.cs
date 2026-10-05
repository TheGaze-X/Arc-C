using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EE6 RID: 20198
	[Token(Token = "0x2004EE6")]
	public class FifthAnnivExploreCheckpointNodeView : FifthAnnivExploreAbstractNodeView
	{
		// Token: 0x0601E222 RID: 123426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E222")]
		[Address(RVA = "0x17C9900", Offset = "0x17C8500", VA = "0x1817C9900", Slot = "4")]
		public override void Render(FifthAnnivExploreMapNodeViewModel nodeViewModel, int currentIndexInRoute)
		{
		}

		// Token: 0x0601E223 RID: 123427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E223")]
		[Address(RVA = "0x17C9D10", Offset = "0x17C8910", VA = "0x1817C9D10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E224 RID: 123428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E224")]
		[Address(RVA = "0x17C9E20", Offset = "0x17C8A20", VA = "0x1817C9E20")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601E225 RID: 123429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E225")]
		[Address(RVA = "0x17C9F00", Offset = "0x17C8B00", VA = "0x1817C9F00")]
		public FifthAnnivExploreCheckpointNodeView()
		{
		}

		// Token: 0x04028191 RID: 164241
		[Token(Token = "0x4028191")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgNode;

		// Token: 0x04028192 RID: 164242
		[Token(Token = "0x4028192")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelCircle;

		// Token: 0x04028193 RID: 164243
		[Token(Token = "0x4028193")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x04028194 RID: 164244
		[Token(Token = "0x4028194")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _delayShow;

		// Token: 0x04028195 RID: 164245
		[Token(Token = "0x4028195")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_isInited;

		// Token: 0x04028196 RID: 164246
		[Token(Token = "0x4028196")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_cachedIsCurrent;

		// Token: 0x04028197 RID: 164247
		[Token(Token = "0x4028197")]
		[FieldOffset(Offset = "0x40")]
		private FifthAnnivExploreMapViewConfig m_mapViewConfig;

		// Token: 0x04028198 RID: 164248
		[Token(Token = "0x4028198")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028199 RID: 164249
		[Token(Token = "0x4028199")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402819A RID: 164250
		[Token(Token = "0x402819A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402819B RID: 164251
		[Token(Token = "0x402819B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x0402819C RID: 164252
		[Token(Token = "0x402819C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
