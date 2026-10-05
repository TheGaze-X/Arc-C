using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200660E RID: 26126
	[Token(Token = "0x200660E")]
	public class ArtGalleryListModeAvatarItemView : ArtGalleryListModeItemViewBase
	{
		// Token: 0x170058A4 RID: 22692
		// (get) Token: 0x0602587D RID: 153725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170058A4")]
		protected override IArtGalleryDisplayItemViewModel displayItemViewModel
		{
			[Token(Token = "0x602587D")]
			[Address(RVA = "0x2083E40", Offset = "0x2082A40", VA = "0x182083E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602587E RID: 153726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602587E")]
		[Address(RVA = "0x2083A60", Offset = "0x2082660", VA = "0x182083A60", Slot = "5")]
		public override void Render(IArtGalleryDisplayItemViewModel artGalleryDisplayItemViewModel)
		{
		}

		// Token: 0x0602587F RID: 153727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602587F")]
		[Address(RVA = "0x2083D10", Offset = "0x2082910", VA = "0x182083D10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025880 RID: 153728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025880")]
		[Address(RVA = "0x2083DA0", Offset = "0x20829A0", VA = "0x182083DA0")]
		public ArtGalleryListModeAvatarItemView()
		{
		}

		// Token: 0x04034B79 RID: 215929
		[Token(Token = "0x4034B79")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04034B7A RID: 215930
		[Token(Token = "0x4034B7A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x04034B7B RID: 215931
		[Token(Token = "0x4034B7B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelCurSelect;

		// Token: 0x04034B7C RID: 215932
		[Token(Token = "0x4034B7C")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04034B7D RID: 215933
		[Token(Token = "0x4034B7D")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedId;

		// Token: 0x04034B7E RID: 215934
		[Token(Token = "0x4034B7E")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034B7F RID: 215935
		[Token(Token = "0x4034B7F")]
		[FieldOffset(Offset = "0x70")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04034B80 RID: 215936
		[Token(Token = "0x4034B80")]
		[FieldOffset(Offset = "0x78")]
		private ArtGalleryDisplayAvatarItemViewModel m_cachedItemViewModel;

		// Token: 0x04034B81 RID: 215937
		[Token(Token = "0x4034B81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayItemViewModel;

		// Token: 0x04034B82 RID: 215938
		[Token(Token = "0x4034B82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034B83 RID: 215939
		[Token(Token = "0x4034B83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034B84 RID: 215940
		[Token(Token = "0x4034B84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
