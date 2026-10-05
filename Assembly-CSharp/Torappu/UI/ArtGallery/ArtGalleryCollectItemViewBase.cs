using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065E5 RID: 26085
	[Token(Token = "0x20065E5")]
	public abstract class ArtGalleryCollectItemViewBase<ViewModel> : MonoBehaviour, IHotfixable where ViewModel : ArtGalleryCollectItemModelBase
	{
		// Token: 0x060257DF RID: 153567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257DF")]
		public void Render(ViewModel viewModel)
		{
		}

		// Token: 0x060257E0 RID: 153568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257E0")]
		public void OnItemClicked()
		{
		}

		// Token: 0x060257E1 RID: 153569 RVA: 0x000C8100 File Offset: 0x000C6300
		[Token(Token = "0x60257E1")]
		public float GetCustomSpacing(bool isFirstSameTypeItem)
		{
			return 0f;
		}

		// Token: 0x060257E2 RID: 153570
		[Token(Token = "0x60257E2")]
		protected abstract void _DoRender(ViewModel viewModel);

		// Token: 0x060257E3 RID: 153571
		[Token(Token = "0x60257E3")]
		protected abstract void _DoJump();

		// Token: 0x060257E4 RID: 153572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257E4")]
		protected virtual void _OnInit()
		{
		}

		// Token: 0x060257E5 RID: 153573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257E5")]
		protected void _InitIfNot()
		{
		}

		// Token: 0x060257E6 RID: 153574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257E6")]
		protected ArtGalleryCollectItemViewBase()
		{
		}

		// Token: 0x04034A0D RID: 215565
		[Token(Token = "0x4034A0D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _firstItemSpace;

		// Token: 0x04034A0E RID: 215566
		[Token(Token = "0x4034A0E")]
		[FieldOffset(Offset = "0x0")]
		protected string m_cachedItemId;

		// Token: 0x04034A0F RID: 215567
		[Token(Token = "0x4034A0F")]
		[FieldOffset(Offset = "0x0")]
		protected ItemType m_cachedItemType;

		// Token: 0x04034A10 RID: 215568
		[Token(Token = "0x4034A10")]
		[FieldOffset(Offset = "0x0")]
		protected bool m_hasInited;

		// Token: 0x04034A11 RID: 215569
		[Token(Token = "0x4034A11")]
		[FieldOffset(Offset = "0x0")]
		protected bool m_cachedCanJump;

		// Token: 0x04034A12 RID: 215570
		[Token(Token = "0x4034A12")]
		[FieldOffset(Offset = "0x0")]
		protected UIPageFinder m_pageFinder;

		// Token: 0x04034A13 RID: 215571
		[Token(Token = "0x4034A13")]
		[FieldOffset(Offset = "0x0")]
		protected UIStateFinder m_stateFinder;

		// Token: 0x04034A14 RID: 215572
		[Token(Token = "0x4034A14")]
		[FieldOffset(Offset = "0x0")]
		protected ILoadAsset m_assetLoader;

		// Token: 0x04034A15 RID: 215573
		[Token(Token = "0x4034A15")]
		[FieldOffset(Offset = "0x0")]
		private string m_cacheRelateSetId;

		// Token: 0x04034A16 RID: 215574
		[Token(Token = "0x4034A16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034A17 RID: 215575
		[Token(Token = "0x4034A17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClicked;

		// Token: 0x04034A18 RID: 215576
		[Token(Token = "0x4034A18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCustomSpacing;

		// Token: 0x04034A19 RID: 215577
		[Token(Token = "0x4034A19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnInit;

		// Token: 0x04034A1A RID: 215578
		[Token(Token = "0x4034A1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034A1B RID: 215579
		[Token(Token = "0x4034A1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
