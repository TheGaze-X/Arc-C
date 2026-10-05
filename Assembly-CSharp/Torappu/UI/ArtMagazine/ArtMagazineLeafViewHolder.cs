using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065C4 RID: 26052
	[Token(Token = "0x20065C4")]
	public class ArtMagazineLeafViewHolder : MonoBehaviour, IArtMagazineLeafLayoutDrivenTrigger, IHotfixable
	{
		// Token: 0x17005893 RID: 22675
		// (get) Token: 0x06025709 RID: 153353 RVA: 0x000C7EA8 File Offset: 0x000C60A8
		[Token(Token = "0x17005893")]
		public bool isReadyForSaving
		{
			[Token(Token = "0x6025709")]
			[Address(RVA = "0x2069930", Offset = "0x2068530", VA = "0x182069930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602570A RID: 153354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602570A")]
		[Address(RVA = "0x2069440", Offset = "0x2068040", VA = "0x182069440", Slot = "4")]
		public void OnScaleChanged(float scale)
		{
		}

		// Token: 0x0602570B RID: 153355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602570B")]
		[Address(RVA = "0x20693C0", Offset = "0x2067FC0", VA = "0x1820693C0")]
		public void GenLeafTransformData(ref ArtMagazineLeafView.LeafTransformData leafTransformData)
		{
		}

		// Token: 0x0602570C RID: 153356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602570C")]
		[Address(RVA = "0x2069500", Offset = "0x2068100", VA = "0x182069500")]
		public void Render(ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x0602570D RID: 153357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602570D")]
		[Address(RVA = "0x20698D0", Offset = "0x20684D0", VA = "0x1820698D0")]
		public ArtMagazineLeafViewHolder()
		{
		}

		// Token: 0x040348B6 RID: 215222
		[Token(Token = "0x40348B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x040348B7 RID: 215223
		[Token(Token = "0x40348B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtMagazineLeafElementViewHolderBase _prefabLeafElementViewHolder;

		// Token: 0x040348B8 RID: 215224
		[Token(Token = "0x40348B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtMagazineLeafDecoBkgViewBase _prefabLeafDecoBkgView;

		// Token: 0x040348B9 RID: 215225
		[Token(Token = "0x40348B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArtMagazineLeafCharIllustBkgView _prefabCharIllustBkgView;

		// Token: 0x040348BA RID: 215226
		[Token(Token = "0x40348BA")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedLeafId;

		// Token: 0x040348BB RID: 215227
		[Token(Token = "0x40348BB")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040348BC RID: 215228
		[Token(Token = "0x40348BC")]
		[FieldOffset(Offset = "0x50")]
		private ArtMagazineLeafView m_leafView;

		// Token: 0x040348BD RID: 215229
		[Token(Token = "0x40348BD")]
		[FieldOffset(Offset = "0x58")]
		private float m_cachedScale;

		// Token: 0x040348BE RID: 215230
		[Token(Token = "0x40348BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isReadyForSaving;

		// Token: 0x040348BF RID: 215231
		[Token(Token = "0x40348BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnScaleChanged;

		// Token: 0x040348C0 RID: 215232
		[Token(Token = "0x40348C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenLeafTransformData;

		// Token: 0x040348C1 RID: 215233
		[Token(Token = "0x40348C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040348C2 RID: 215234
		[Token(Token = "0x40348C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
