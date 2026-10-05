using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065F1 RID: 26097
	[Token(Token = "0x20065F1")]
	public class ArtGalleryCollectSetAdapter : LoopScrollAdapter<ArtGalleryCollectSetAdapter.ViewHolder, ArtGalleryCollectSetViewModel>, IHotfixable
	{
		// Token: 0x0602581B RID: 153627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602581B")]
		[Address(RVA = "0x207D560", Offset = "0x207C160", VA = "0x18207D560", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602581C RID: 153628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602581C")]
		[Address(RVA = "0x207D610", Offset = "0x207C210", VA = "0x18207D610", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, ArtGalleryCollectSetAdapter.ViewHolder holder, ArtGalleryCollectSetViewModel data)
		{
		}

		// Token: 0x0602581D RID: 153629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602581D")]
		[Address(RVA = "0x207D760", Offset = "0x207C360", VA = "0x18207D760")]
		public ArtGalleryCollectSetAdapter()
		{
		}

		// Token: 0x04034AA2 RID: 215714
		[Token(Token = "0x4034AA2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x04034AA3 RID: 215715
		[Token(Token = "0x4034AA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04034AA4 RID: 215716
		[Token(Token = "0x4034AA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04034AA5 RID: 215717
		[Token(Token = "0x4034AA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065F2 RID: 26098
		[Token(Token = "0x20065F2")]
		public class ViewHolder
		{
			// Token: 0x0602581E RID: 153630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602581E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04034AA6 RID: 215718
			[Token(Token = "0x4034AA6")]
			[FieldOffset(Offset = "0x10")]
			public ArtGalleryCollectSetSingleView view;
		}
	}
}
