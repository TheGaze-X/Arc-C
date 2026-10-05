using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006555 RID: 25941
	[Token(Token = "0x2006555")]
	public class ArtMagazineDiyLeafThumbnailController : PageSingleComponent, IPageCanvasMarker, IPageComponentMarker, IHotfixable
	{
		// Token: 0x060254CD RID: 152781 RVA: 0x000C7680 File Offset: 0x000C5880
		[Token(Token = "0x60254CD")]
		[Address(RVA = "0x204E250", Offset = "0x204CE50", VA = "0x18204E250", Slot = "12")]
		public bool IsCollectable()
		{
			return default(bool);
		}

		// Token: 0x17005816 RID: 22550
		// (get) Token: 0x060254CE RID: 152782 RVA: 0x000C7698 File Offset: 0x000C5898
		[Token(Token = "0x17005816")]
		public bool isSavingLeafThumbnail
		{
			[Token(Token = "0x60254CE")]
			[Address(RVA = "0x204E860", Offset = "0x204D460", VA = "0x18204E860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060254CF RID: 152783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254CF")]
		[Address(RVA = "0x204E390", Offset = "0x204CF90", VA = "0x18204E390")]
		public void SaveLeafThumbnail(ArtMagazineLeafData leafData, Action callback)
		{
		}

		// Token: 0x060254D0 RID: 152784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60254D0")]
		[Address(RVA = "0x204E570", Offset = "0x204D170", VA = "0x18204E570")]
		private IEnumerator _CoroutineSaveLeafThumbnail(ArtMagazineLeafData leafData, Action callback)
		{
			return null;
		}

		// Token: 0x060254D1 RID: 152785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254D1")]
		[Address(RVA = "0x204E670", Offset = "0x204D270", VA = "0x18204E670")]
		private void _LoadLeafThumbnail(ArtMagazineLeafData leafData)
		{
		}

		// Token: 0x060254D2 RID: 152786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254D2")]
		[Address(RVA = "0x204E2B0", Offset = "0x204CEB0", VA = "0x18204E2B0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060254D3 RID: 152787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254D3")]
		[Address(RVA = "0x204E7C0", Offset = "0x204D3C0", VA = "0x18204E7C0")]
		public ArtMagazineDiyLeafThumbnailController()
		{
		}

		// Token: 0x060254D4 RID: 152788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254D4")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0403455C RID: 214364
		[Token(Token = "0x403455C")]
		private const int JPEG_ENCODE_QUALITY = 50;

		// Token: 0x0403455D RID: 214365
		[Token(Token = "0x403455D")]
		private const float LEAF_PANEL_WIDTH = 1280f;

		// Token: 0x0403455E RID: 214366
		[Token(Token = "0x403455E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtMagazineLeafViewHolder _thumbnailLeafViewHolder;

		// Token: 0x0403455F RID: 214367
		[Token(Token = "0x403455F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera _thumbnailCamera;

		// Token: 0x04034560 RID: 214368
		[Token(Token = "0x4034560")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _thumbnailWidth;

		// Token: 0x04034561 RID: 214369
		[Token(Token = "0x4034561")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _thumbnailHeight;

		// Token: 0x04034562 RID: 214370
		[Token(Token = "0x4034562")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _thumbnailView;

		// Token: 0x04034563 RID: 214371
		[Token(Token = "0x4034563")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _raycastBlocker;

		// Token: 0x04034564 RID: 214372
		[Token(Token = "0x4034564")]
		[FieldOffset(Offset = "0x48")]
		private ArtMagazineLeafViewModel m_leafViewModel;

		// Token: 0x04034565 RID: 214373
		[Token(Token = "0x4034565")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isSavingLeafThumbnail;

		// Token: 0x04034566 RID: 214374
		[Token(Token = "0x4034566")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine m_saveLeafThumbnailCoroutine;

		// Token: 0x04034567 RID: 214375
		[Token(Token = "0x4034567")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCollectable;

		// Token: 0x04034568 RID: 214376
		[Token(Token = "0x4034568")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSavingLeafThumbnail;

		// Token: 0x04034569 RID: 214377
		[Token(Token = "0x4034569")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SaveLeafThumbnail;

		// Token: 0x0403456A RID: 214378
		[Token(Token = "0x403456A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CoroutineSaveLeafThumbnail;

		// Token: 0x0403456B RID: 214379
		[Token(Token = "0x403456B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadLeafThumbnail;

		// Token: 0x0403456C RID: 214380
		[Token(Token = "0x403456C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403456D RID: 214381
		[Token(Token = "0x403456D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
