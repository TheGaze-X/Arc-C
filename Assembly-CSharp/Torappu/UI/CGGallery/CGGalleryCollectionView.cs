using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x0200600A RID: 24586
	[Token(Token = "0x200600A")]
	public class CGGalleryCollectionView : DataBinder<CGGalleryProperty>
	{
		// Token: 0x170053F8 RID: 21496
		// (get) Token: 0x060238B6 RID: 145590 RVA: 0x000C1380 File Offset: 0x000BF580
		// (set) Token: 0x060238B7 RID: 145591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053F8")]
		public int transitionSequence
		{
			[Token(Token = "0x60238B6")]
			[Address(RVA = "0x1E2EB00", Offset = "0x1E2D700", VA = "0x181E2EB00")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60238B7")]
			[Address(RVA = "0x1E2EB60", Offset = "0x1E2D760", VA = "0x181E2EB60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053F9 RID: 21497
		// (get) Token: 0x060238B8 RID: 145592 RVA: 0x000C1398 File Offset: 0x000BF598
		[Token(Token = "0x170053F9")]
		public bool isTransiting
		{
			[Token(Token = "0x60238B8")]
			[Address(RVA = "0x1E2EA90", Offset = "0x1E2D690", VA = "0x181E2EA90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060238B9 RID: 145593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238B9")]
		[Address(RVA = "0x1E2E2B0", Offset = "0x1E2CEB0", VA = "0x181E2E2B0", Slot = "7")]
		public override void OnValueChanged(CGGalleryProperty property)
		{
		}

		// Token: 0x060238BA RID: 145594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238BA")]
		[Address(RVA = "0x1E2E240", Offset = "0x1E2CE40", VA = "0x181E2E240")]
		public void MarkFavouriteDirty()
		{
		}

		// Token: 0x060238BB RID: 145595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238BB")]
		[Address(RVA = "0x1E2E120", Offset = "0x1E2CD20", VA = "0x181E2E120")]
		public void FocusDisplayOnLayout(string displayId)
		{
		}

		// Token: 0x060238BC RID: 145596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238BC")]
		[Address(RVA = "0x1E2E1A0", Offset = "0x1E2CDA0", VA = "0x181E2E1A0")]
		public void GetLocatedInfo(out string storySetId, out string displayId)
		{
		}

		// Token: 0x060238BD RID: 145597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60238BD")]
		[Address(RVA = "0x1E2E3D0", Offset = "0x1E2CFD0", VA = "0x181E2E3D0")]
		private Tween _GenerateSwitchTween(CGGalleryViewModel model)
		{
			return null;
		}

		// Token: 0x060238BE RID: 145598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238BE")]
		[Address(RVA = "0x1E2E690", Offset = "0x1E2D290", VA = "0x181E2E690")]
		private void _UpdateView(CGGalleryViewModel model)
		{
		}

		// Token: 0x060238BF RID: 145599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238BF")]
		[Address(RVA = "0x1E2EA20", Offset = "0x1E2D620", VA = "0x181E2EA20")]
		public CGGalleryCollectionView()
		{
		}

		// Token: 0x040312EC RID: 201452
		[Token(Token = "0x40312EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CGGalleryCollectionDisplayGroupView _displayGroupView;

		// Token: 0x040312ED RID: 201453
		[Token(Token = "0x40312ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CGGalleryCollectionStorylineView _storylineView;

		// Token: 0x040312EE RID: 201454
		[Token(Token = "0x40312EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _fadeOutAnimation;

		// Token: 0x040312EF RID: 201455
		[Token(Token = "0x40312EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _fadeInAnimation;

		// Token: 0x040312F0 RID: 201456
		[Token(Token = "0x40312F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject[] _storylineVariants;

		// Token: 0x040312F1 RID: 201457
		[Token(Token = "0x40312F1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _favouriteVariants;

		// Token: 0x040312F2 RID: 201458
		[Token(Token = "0x40312F2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _storylineCGCountText;

		// Token: 0x040312F3 RID: 201459
		[Token(Token = "0x40312F3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _favouriteCGCountText;

		// Token: 0x040312F4 RID: 201460
		[Token(Token = "0x40312F4")]
		[FieldOffset(Offset = "0x70")]
		private CGGalleryFilterMode m_filterMode;

		// Token: 0x040312F5 RID: 201461
		[Token(Token = "0x40312F5")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_fadeTween;

		// Token: 0x040312F7 RID: 201463
		[Token(Token = "0x40312F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_transitionSequence;

		// Token: 0x040312F8 RID: 201464
		[Token(Token = "0x40312F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_transitionSequence;

		// Token: 0x040312F9 RID: 201465
		[Token(Token = "0x40312F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isTransiting;

		// Token: 0x040312FA RID: 201466
		[Token(Token = "0x40312FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040312FB RID: 201467
		[Token(Token = "0x40312FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MarkFavouriteDirty;

		// Token: 0x040312FC RID: 201468
		[Token(Token = "0x40312FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FocusDisplayOnLayout;

		// Token: 0x040312FD RID: 201469
		[Token(Token = "0x40312FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetLocatedInfo;

		// Token: 0x040312FE RID: 201470
		[Token(Token = "0x40312FE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateSwitchTween;

		// Token: 0x040312FF RID: 201471
		[Token(Token = "0x40312FF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x04031300 RID: 201472
		[Token(Token = "0x4031300")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
