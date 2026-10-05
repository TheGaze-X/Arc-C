using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x0200600D RID: 24589
	[Token(Token = "0x200600D")]
	public class CGGalleryImageContainer : MonoBehaviour, DragAndPinchWithTargetContext.IDragAndPinchTarget, IHotfixable
	{
		// Token: 0x170053FB RID: 21499
		// (get) Token: 0x060238CC RID: 145612 RVA: 0x000C13B0 File Offset: 0x000BF5B0
		[Token(Token = "0x170053FB")]
		public Vector2 standardSizeDelta
		{
			[Token(Token = "0x60238CC")]
			[Address(RVA = "0x1E2FDC0", Offset = "0x1E2E9C0", VA = "0x181E2FDC0", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170053FC RID: 21500
		// (get) Token: 0x060238CD RID: 145613 RVA: 0x000C13C8 File Offset: 0x000BF5C8
		// (set) Token: 0x060238CE RID: 145614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053FC")]
		public float scale
		{
			[Token(Token = "0x60238CD")]
			[Address(RVA = "0x1E2FD60", Offset = "0x1E2E960", VA = "0x181E2FD60", Slot = "7")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60238CE")]
			[Address(RVA = "0x1E2FF80", Offset = "0x1E2EB80", VA = "0x181E2FF80", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170053FD RID: 21501
		// (get) Token: 0x060238CF RID: 145615 RVA: 0x000C13E0 File Offset: 0x000BF5E0
		// (set) Token: 0x060238D0 RID: 145616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053FD")]
		public Vector2 anchoredPosition
		{
			[Token(Token = "0x60238CF")]
			[Address(RVA = "0x1E2FBA0", Offset = "0x1E2E7A0", VA = "0x181E2FBA0", Slot = "5")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60238D0")]
			[Address(RVA = "0x1E2FEB0", Offset = "0x1E2EAB0", VA = "0x181E2FEB0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170053FE RID: 21502
		// (get) Token: 0x060238D1 RID: 145617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053FE")]
		public string key
		{
			[Token(Token = "0x60238D1")]
			[Address(RVA = "0x1E2FCB0", Offset = "0x1E2E8B0", VA = "0x181E2FCB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053FF RID: 21503
		// (get) Token: 0x060238D2 RID: 145618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053FF")]
		public CGGalleryImageView imageView
		{
			[Token(Token = "0x60238D2")]
			[Address(RVA = "0x1E2FC50", Offset = "0x1E2E850", VA = "0x181E2FC50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060238D3 RID: 145619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60238D3")]
		[Address(RVA = "0x1E2FA60", Offset = "0x1E2E660", VA = "0x181E2FA60")]
		private RectTransform _GetValidRectTransform()
		{
			return null;
		}

		// Token: 0x060238D4 RID: 145620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238D4")]
		[Address(RVA = "0x1E2F470", Offset = "0x1E2E070", VA = "0x181E2F470")]
		public void InitView()
		{
		}

		// Token: 0x060238D5 RID: 145621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238D5")]
		[Address(RVA = "0x1E2F6F0", Offset = "0x1E2E2F0", VA = "0x181E2F6F0")]
		public void ResetToOrigin()
		{
		}

		// Token: 0x060238D6 RID: 145622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238D6")]
		[Address(RVA = "0x1E2F5D0", Offset = "0x1E2E1D0", VA = "0x181E2F5D0")]
		public void RenderImage(CGGalleryCGViewModel cgViewModel)
		{
		}

		// Token: 0x060238D7 RID: 145623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238D7")]
		[Address(RVA = "0x1E2F900", Offset = "0x1E2E500", VA = "0x181E2F900")]
		public void Show(bool forward, bool reset = false)
		{
		}

		// Token: 0x060238D8 RID: 145624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238D8")]
		[Address(RVA = "0x1E2F310", Offset = "0x1E2DF10", VA = "0x181E2F310")]
		public void Hide(bool forward, bool reset = false)
		{
		}

		// Token: 0x060238D9 RID: 145625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238D9")]
		[Address(RVA = "0x1E2FB40", Offset = "0x1E2E740", VA = "0x181E2FB40")]
		public CGGalleryImageContainer()
		{
		}

		// Token: 0x0403130F RID: 201487
		[Token(Token = "0x403130F")]
		private const string KEY_FORMAT = "{0}_{1}";

		// Token: 0x04031310 RID: 201488
		[Token(Token = "0x4031310")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CGGalleryImageView _imageView;

		// Token: 0x04031311 RID: 201489
		[Token(Token = "0x4031311")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 m_originPos;

		// Token: 0x04031312 RID: 201490
		[Token(Token = "0x4031312")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04031313 RID: 201491
		[Token(Token = "0x4031313")]
		[FieldOffset(Offset = "0x38")]
		private float m_scale;

		// Token: 0x04031314 RID: 201492
		[Token(Token = "0x4031314")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedCgId;

		// Token: 0x04031315 RID: 201493
		[Token(Token = "0x4031315")]
		[FieldOffset(Offset = "0x48")]
		private int m_resetTimes;

		// Token: 0x04031316 RID: 201494
		[Token(Token = "0x4031316")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_standardSizeDelta;

		// Token: 0x04031317 RID: 201495
		[Token(Token = "0x4031317")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_scale;

		// Token: 0x04031318 RID: 201496
		[Token(Token = "0x4031318")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_scale;

		// Token: 0x04031319 RID: 201497
		[Token(Token = "0x4031319")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_anchoredPosition;

		// Token: 0x0403131A RID: 201498
		[Token(Token = "0x403131A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_anchoredPosition;

		// Token: 0x0403131B RID: 201499
		[Token(Token = "0x403131B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_key;

		// Token: 0x0403131C RID: 201500
		[Token(Token = "0x403131C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_imageView;

		// Token: 0x0403131D RID: 201501
		[Token(Token = "0x403131D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetValidRectTransform;

		// Token: 0x0403131E RID: 201502
		[Token(Token = "0x403131E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0403131F RID: 201503
		[Token(Token = "0x403131F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ResetToOrigin;

		// Token: 0x04031320 RID: 201504
		[Token(Token = "0x4031320")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RenderImage;

		// Token: 0x04031321 RID: 201505
		[Token(Token = "0x4031321")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04031322 RID: 201506
		[Token(Token = "0x4031322")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04031323 RID: 201507
		[Token(Token = "0x4031323")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
