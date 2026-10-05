using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006000 RID: 24576
	[Token(Token = "0x2006000")]
	public class CGGalleryCollectionDisplayItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023854 RID: 145492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023854")]
		[Address(RVA = "0x1E2A1E0", Offset = "0x1E28DE0", VA = "0x181E2A1E0")]
		public void Render(CGGalleryDisplayViewModel display, CGGalleryFilterMode filterMode, bool fullSizePreview)
		{
		}

		// Token: 0x06023855 RID: 145493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023855")]
		[Address(RVA = "0x1E2A090", Offset = "0x1E28C90", VA = "0x181E2A090")]
		public void OnClick()
		{
		}

		// Token: 0x06023856 RID: 145494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023856")]
		[Address(RVA = "0x1E29FF0", Offset = "0x1E28BF0", VA = "0x181E29FF0")]
		public void ClearImage()
		{
		}

		// Token: 0x06023857 RID: 145495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023857")]
		[Address(RVA = "0x1E2A180", Offset = "0x1E28D80", VA = "0x181E2A180")]
		private void OnDestroy()
		{
		}

		// Token: 0x06023858 RID: 145496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023858")]
		[Address(RVA = "0x1E2A8D0", Offset = "0x1E294D0", VA = "0x181E2A8D0")]
		private void _RenderPreview(CGGalleryDisplayViewModel display, bool fullSizePreview)
		{
		}

		// Token: 0x06023859 RID: 145497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023859")]
		[Address(RVA = "0x1E2AB20", Offset = "0x1E29720", VA = "0x181E2AB20")]
		private CGGalleryCGViewModel _SelectPreviewCg(CGGalleryDisplayViewModel display)
		{
			return null;
		}

		// Token: 0x0602385A RID: 145498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602385A")]
		[Address(RVA = "0x1E2A770", Offset = "0x1E29370", VA = "0x181E2A770")]
		private void _RenderMulti(CGGalleryDisplayViewModel display, CGGalleryFilterMode filterMode)
		{
		}

		// Token: 0x0602385B RID: 145499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602385B")]
		[Address(RVA = "0x1E2A3D0", Offset = "0x1E28FD0", VA = "0x181E2A3D0")]
		private void _FitPreviewRect(CGGalleryCGViewModel preview, bool fullSizePreview)
		{
		}

		// Token: 0x0602385C RID: 145500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602385C")]
		[Address(RVA = "0x1E2AC50", Offset = "0x1E29850", VA = "0x181E2AC50")]
		public CGGalleryCollectionDisplayItemView()
		{
		}

		// Token: 0x04031254 RID: 201300
		[Token(Token = "0x4031254")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _previewImage;

		// Token: 0x04031255 RID: 201301
		[Token(Token = "0x4031255")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _previewRect;

		// Token: 0x04031256 RID: 201302
		[Token(Token = "0x4031256")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _previewParent;

		// Token: 0x04031257 RID: 201303
		[Token(Token = "0x4031257")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _favouritePanel;

		// Token: 0x04031258 RID: 201304
		[Token(Token = "0x4031258")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _multiAnimation;

		// Token: 0x04031259 RID: 201305
		[Token(Token = "0x4031259")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _multiCountText;

		// Token: 0x0403125A RID: 201306
		[Token(Token = "0x403125A")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_finder;

		// Token: 0x0403125B RID: 201307
		[Token(Token = "0x403125B")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedDisplayId;

		// Token: 0x0403125C RID: 201308
		[Token(Token = "0x403125C")]
		[FieldOffset(Offset = "0x68")]
		private string m_loadedPreview;

		// Token: 0x0403125D RID: 201309
		[Token(Token = "0x403125D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403125E RID: 201310
		[Token(Token = "0x403125E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403125F RID: 201311
		[Token(Token = "0x403125F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearImage;

		// Token: 0x04031260 RID: 201312
		[Token(Token = "0x4031260")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04031261 RID: 201313
		[Token(Token = "0x4031261")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderPreview;

		// Token: 0x04031262 RID: 201314
		[Token(Token = "0x4031262")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SelectPreviewCg;

		// Token: 0x04031263 RID: 201315
		[Token(Token = "0x4031263")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderMulti;

		// Token: 0x04031264 RID: 201316
		[Token(Token = "0x4031264")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FitPreviewRect;

		// Token: 0x04031265 RID: 201317
		[Token(Token = "0x4031265")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
