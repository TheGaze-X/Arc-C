using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006612 RID: 26130
	[Token(Token = "0x2006612")]
	public class ArtGalleryListModeGridItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602588B RID: 153739 RVA: 0x000C81F0 File Offset: 0x000C63F0
		[Token(Token = "0x602588B")]
		[Address(RVA = "0x2083F60", Offset = "0x2082B60", VA = "0x182083F60")]
		public Vector2 GetViewSize(ArtGalleryDisplayGridVirtualParam gridVirtualParam)
		{
			return default(Vector2);
		}

		// Token: 0x0602588C RID: 153740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602588C")]
		[Address(RVA = "0x20841A0", Offset = "0x2082DA0", VA = "0x1820841A0")]
		public void Render(ArtGalleryDisplayGridVirtualParam gridVirtualParam)
		{
		}

		// Token: 0x0602588D RID: 153741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602588D")]
		[Address(RVA = "0x2084600", Offset = "0x2083200", VA = "0x182084600")]
		private void _RenderTitle(string title)
		{
		}

		// Token: 0x0602588E RID: 153742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602588E")]
		[Address(RVA = "0x2084480", Offset = "0x2083080", VA = "0x182084480")]
		private void _RenderItem(IArtGalleryDisplayItemViewModel itemViewModel)
		{
		}

		// Token: 0x0602588F RID: 153743 RVA: 0x000C8208 File Offset: 0x000C6408
		[Token(Token = "0x602588F")]
		[Address(RVA = "0x2083EA0", Offset = "0x2082AA0", VA = "0x182083EA0")]
		public float GetCustomSpacing(ArtGalleryDisplayGridVirtualParam itemParam)
		{
			return 0f;
		}

		// Token: 0x06025890 RID: 153744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025890")]
		[Address(RVA = "0x20846B0", Offset = "0x20832B0", VA = "0x1820846B0")]
		public ArtGalleryListModeGridItemView()
		{
		}

		// Token: 0x04034BA3 RID: 215971
		[Token(Token = "0x4034BA3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtGalleryListModeItemViewBase _itemViewAsset;

		// Token: 0x04034BA4 RID: 215972
		[Token(Token = "0x4034BA4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _itemViewRoot;

		// Token: 0x04034BA5 RID: 215973
		[Token(Token = "0x4034BA5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelTitle;

		// Token: 0x04034BA6 RID: 215974
		[Token(Token = "0x4034BA6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04034BA7 RID: 215975
		[Token(Token = "0x4034BA7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("virtual view")]
		private LayoutElement _titleLayout;

		// Token: 0x04034BA8 RID: 215976
		[Token(Token = "0x4034BA8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("virtual view")]
		private float _titleTopSpacing;

		// Token: 0x04034BA9 RID: 215977
		[Token(Token = "0x4034BA9")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Group("virtual view")]
		private float _titleBottomSpacing;

		// Token: 0x04034BAA RID: 215978
		[Token(Token = "0x4034BAA")]
		[FieldOffset(Offset = "0x48")]
		private ArtGalleryListModeItemViewBase m_cachedItemView;

		// Token: 0x04034BAB RID: 215979
		[Token(Token = "0x4034BAB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewSize;

		// Token: 0x04034BAC RID: 215980
		[Token(Token = "0x4034BAC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034BAD RID: 215981
		[Token(Token = "0x4034BAD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderTitle;

		// Token: 0x04034BAE RID: 215982
		[Token(Token = "0x4034BAE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderItem;

		// Token: 0x04034BAF RID: 215983
		[Token(Token = "0x4034BAF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCustomSpacing;

		// Token: 0x04034BB0 RID: 215984
		[Token(Token = "0x4034BB0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
