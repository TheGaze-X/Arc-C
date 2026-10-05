using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047FA RID: 18426
	[Token(Token = "0x20047FA")]
	public class MonopolyMapNodeContainer : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x0601BDE2 RID: 114146 RVA: 0x000A6830 File Offset: 0x000A4A30
		[Token(Token = "0x17004241")]
		public int nodeCount
		{
			[Token(Token = "0x601BDE2")]
			[Address(RVA = "0x1540810", Offset = "0x153F410", VA = "0x181540810")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601BDE3 RID: 114147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDE3")]
		[Address(RVA = "0x153FCA0", Offset = "0x153E8A0", VA = "0x18153FCA0")]
		public void Render(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BDE4 RID: 114148 RVA: 0x000A6848 File Offset: 0x000A4A48
		[Token(Token = "0x601BDE4")]
		[Address(RVA = "0x153FBB0", Offset = "0x153E7B0", VA = "0x18153FBB0")]
		public Vector2 GetNodeContainerAnchorPos(int nodeIndex)
		{
			return default(Vector2);
		}

		// Token: 0x0601BDE5 RID: 114149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDE5")]
		[Address(RVA = "0x1540010", Offset = "0x153EC10", VA = "0x181540010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BDE6 RID: 114150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDE6")]
		[Address(RVA = "0x1540640", Offset = "0x153F240", VA = "0x181540640")]
		public MonopolyMapNodeContainer()
		{
		}

		// Token: 0x040244AB RID: 148651
		[Token(Token = "0x40244AB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform[] _nodeImageContainers;

		// Token: 0x040244AC RID: 148652
		[Token(Token = "0x40244AC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform[] _nodeContainers;

		// Token: 0x040244AD RID: 148653
		[Token(Token = "0x40244AD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _lineContainer;

		// Token: 0x040244AE RID: 148654
		[Token(Token = "0x40244AE")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x040244AF RID: 148655
		[Token(Token = "0x40244AF")]
		[FieldOffset(Offset = "0x38")]
		private List<RectTransform> m_validNodeContainerList;

		// Token: 0x040244B0 RID: 148656
		[Token(Token = "0x40244B0")]
		[FieldOffset(Offset = "0x40")]
		private List<RectTransform> m_validNodeImageLayerContainerList;

		// Token: 0x040244B1 RID: 148657
		[Token(Token = "0x40244B1")]
		[FieldOffset(Offset = "0x48")]
		private List<MonopolyMapNodeView> m_nodeList;

		// Token: 0x040244B2 RID: 148658
		[Token(Token = "0x40244B2")]
		[FieldOffset(Offset = "0x50")]
		private List<MonopolyMapNodeImageLayerView> m_nodeImageLayerList;

		// Token: 0x040244B3 RID: 148659
		[Token(Token = "0x40244B3")]
		[FieldOffset(Offset = "0x58")]
		private List<MonopolyMapLineView> m_lineList;

		// Token: 0x040244B4 RID: 148660
		[Token(Token = "0x40244B4")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040244B5 RID: 148661
		[Token(Token = "0x40244B5")]
		[FieldOffset(Offset = "0x70")]
		private int m_enterSeqNum;

		// Token: 0x040244B6 RID: 148662
		[Token(Token = "0x40244B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeCount;

		// Token: 0x040244B7 RID: 148663
		[Token(Token = "0x40244B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040244B8 RID: 148664
		[Token(Token = "0x40244B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetNodeContainerAnchorPos;

		// Token: 0x040244B9 RID: 148665
		[Token(Token = "0x40244B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040244BA RID: 148666
		[Token(Token = "0x40244BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
