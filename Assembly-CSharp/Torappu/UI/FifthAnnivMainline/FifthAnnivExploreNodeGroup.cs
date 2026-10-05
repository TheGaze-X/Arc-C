using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EEC RID: 20204
	[Token(Token = "0x2004EEC")]
	public class FifthAnnivExploreNodeGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E235 RID: 123445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E235")]
		[Address(RVA = "0x17D6970", Offset = "0x17D5570", VA = "0x1817D6970")]
		public void Render(FifthAnnivExploreMapNodeViewModel nodeViewModel, int currentIndexInRoute)
		{
		}

		// Token: 0x0601E236 RID: 123446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E236")]
		[Address(RVA = "0x17D6D30", Offset = "0x17D5930", VA = "0x1817D6D30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E237 RID: 123447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E237")]
		[Address(RVA = "0x17D6E40", Offset = "0x17D5A40", VA = "0x1817D6E40")]
		public FifthAnnivExploreNodeGroup()
		{
		}

		// Token: 0x040281B7 RID: 164279
		[Token(Token = "0x40281B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _oriNodeContainer;

		// Token: 0x040281B8 RID: 164280
		[Token(Token = "0x40281B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _currentNodeContainer;

		// Token: 0x040281B9 RID: 164281
		[Token(Token = "0x40281B9")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x040281BA RID: 164282
		[Token(Token = "0x40281BA")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040281BB RID: 164283
		[Token(Token = "0x40281BB")]
		[FieldOffset(Offset = "0x40")]
		private FifthAnnivExploreMapViewConfig m_mapViewConfig;

		// Token: 0x040281BC RID: 164284
		[Token(Token = "0x40281BC")]
		[FieldOffset(Offset = "0x48")]
		private bool m_cachedIsCurrent;

		// Token: 0x040281BD RID: 164285
		[Token(Token = "0x40281BD")]
		[FieldOffset(Offset = "0x4C")]
		private FifthAnnivNodeType m_cachedNodeType;

		// Token: 0x040281BE RID: 164286
		[Token(Token = "0x40281BE")]
		[FieldOffset(Offset = "0x50")]
		private FifthAnnivExploreAbstractNodeView m_oriNodeView;

		// Token: 0x040281BF RID: 164287
		[Token(Token = "0x40281BF")]
		[FieldOffset(Offset = "0x58")]
		private FifthAnnivExploreAbstractNodeView m_currentNodeView;

		// Token: 0x040281C0 RID: 164288
		[Token(Token = "0x40281C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040281C1 RID: 164289
		[Token(Token = "0x40281C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040281C2 RID: 164290
		[Token(Token = "0x40281C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
