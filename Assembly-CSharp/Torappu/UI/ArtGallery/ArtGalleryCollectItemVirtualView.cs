using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065E4 RID: 26084
	[Token(Token = "0x20065E4")]
	public class ArtGalleryCollectItemVirtualView<ViewType, ViewModel> : UIRecycleLayoutAdapter.VirtualView<ViewType>, IArtGalleryCollectItemVirtualView, IHotfixable, UIRecycleLayoutAdapter.ICustomSpacing where ViewType : ArtGalleryCollectItemViewBase<ViewModel> where ViewModel : ArtGalleryCollectItemModelBase
	{
		// Token: 0x060257D8 RID: 153560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60257D8")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x060257D9 RID: 153561 RVA: 0x000C80D0 File Offset: 0x000C62D0
		[Token(Token = "0x60257D9")]
		public override float GetPreferSize()
		{
			return 0f;
		}

		// Token: 0x060257DA RID: 153562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257DA")]
		public void RefreshView()
		{
		}

		// Token: 0x060257DB RID: 153563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257DB")]
		protected override void OnViewAttached()
		{
		}

		// Token: 0x060257DC RID: 153564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257DC")]
		protected override void OnViewDetached()
		{
		}

		// Token: 0x060257DD RID: 153565 RVA: 0x000C80E8 File Offset: 0x000C62E8
		[Token(Token = "0x60257DD")]
		public float GetCustomSpacing()
		{
			return 0f;
		}

		// Token: 0x060257DE RID: 153566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257DE")]
		public ArtGalleryCollectItemVirtualView()
		{
		}

		// Token: 0x04034A02 RID: 215554
		[Token(Token = "0x4034A02")]
		[FieldOffset(Offset = "0x0")]
		public GameObject prefab;

		// Token: 0x04034A03 RID: 215555
		[Token(Token = "0x4034A03")]
		[FieldOffset(Offset = "0x0")]
		public ViewType singleView;

		// Token: 0x04034A04 RID: 215556
		[Token(Token = "0x4034A04")]
		[FieldOffset(Offset = "0x0")]
		public ViewModel viewModel;

		// Token: 0x04034A05 RID: 215557
		[Token(Token = "0x4034A05")]
		[FieldOffset(Offset = "0x0")]
		public bool isFirstItemBySameType;

		// Token: 0x04034A06 RID: 215558
		[Token(Token = "0x4034A06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x04034A07 RID: 215559
		[Token(Token = "0x4034A07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPreferSize;

		// Token: 0x04034A08 RID: 215560
		[Token(Token = "0x4034A08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x04034A09 RID: 215561
		[Token(Token = "0x4034A09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x04034A0A RID: 215562
		[Token(Token = "0x4034A0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x04034A0B RID: 215563
		[Token(Token = "0x4034A0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCustomSpacing;

		// Token: 0x04034A0C RID: 215564
		[Token(Token = "0x4034A0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
