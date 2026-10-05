using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047FB RID: 18427
	[Token(Token = "0x20047FB")]
	public class MonopolyMapNodeImageLayerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BDE7 RID: 114151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDE7")]
		[Address(RVA = "0x1540880", Offset = "0x153F480", VA = "0x181540880")]
		public void Render(MonopolyMapNodeItemModel nodeModel, MonopolyCardPanelModel cardPanelModel, bool isFastMode)
		{
		}

		// Token: 0x0601BDE8 RID: 114152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDE8")]
		[Address(RVA = "0x1540C50", Offset = "0x153F850", VA = "0x181540C50")]
		private void _RenderResourceIcon(string nodeIconId)
		{
		}

		// Token: 0x0601BDE9 RID: 114153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDE9")]
		[Address(RVA = "0x1540DB0", Offset = "0x153F9B0", VA = "0x181540DB0")]
		public MonopolyMapNodeImageLayerView()
		{
		}

		// Token: 0x040244BB RID: 148667
		[Token(Token = "0x40244BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _nodeIcon;

		// Token: 0x040244BC RID: 148668
		[Token(Token = "0x40244BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _nodeRefreshRootCanvas;

		// Token: 0x040244BD RID: 148669
		[Token(Token = "0x40244BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _nodeRefreshFadeDuration;

		// Token: 0x040244BE RID: 148670
		[Token(Token = "0x40244BE")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_refreshTween;

		// Token: 0x040244BF RID: 148671
		[Token(Token = "0x40244BF")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040244C0 RID: 148672
		[Token(Token = "0x40244C0")]
		[FieldOffset(Offset = "0x48")]
		private string m_cacheResourceId;

		// Token: 0x040244C1 RID: 148673
		[Token(Token = "0x40244C1")]
		[FieldOffset(Offset = "0x50")]
		private string m_cacheNodeIconId;

		// Token: 0x040244C2 RID: 148674
		[Token(Token = "0x40244C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040244C3 RID: 148675
		[Token(Token = "0x40244C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderResourceIcon;

		// Token: 0x040244C4 RID: 148676
		[Token(Token = "0x40244C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
