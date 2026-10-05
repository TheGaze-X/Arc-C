using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065F0 RID: 26096
	[Token(Token = "0x20065F0")]
	public class ArtGalleryCollectNcSkinView : ArtGalleryCollectItemViewBase<ArtGalleryCollectNcSkinModel>
	{
		// Token: 0x06025818 RID: 153624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025818")]
		[Address(RVA = "0x207D0D0", Offset = "0x207BCD0", VA = "0x18207D0D0", Slot = "4")]
		protected override void _DoRender(ArtGalleryCollectNcSkinModel model)
		{
		}

		// Token: 0x06025819 RID: 153625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025819")]
		[Address(RVA = "0x207CFE0", Offset = "0x207BBE0", VA = "0x18207CFE0", Slot = "5")]
		protected override void _DoJump()
		{
		}

		// Token: 0x0602581A RID: 153626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602581A")]
		[Address(RVA = "0x207D4F0", Offset = "0x207C0F0", VA = "0x18207D4F0")]
		public ArtGalleryCollectNcSkinView()
		{
		}

		// Token: 0x04034A9A RID: 215706
		[Token(Token = "0x4034A9A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04034A9B RID: 215707
		[Token(Token = "0x4034A9B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04034A9C RID: 215708
		[Token(Token = "0x4034A9C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _picSmall;

		// Token: 0x04034A9D RID: 215709
		[Token(Token = "0x4034A9D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _picLarge;

		// Token: 0x04034A9E RID: 215710
		[Token(Token = "0x4034A9E")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedTmpl;

		// Token: 0x04034A9F RID: 215711
		[Token(Token = "0x4034A9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__DoRender;

		// Token: 0x04034AA0 RID: 215712
		[Token(Token = "0x4034AA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoJump;

		// Token: 0x04034AA1 RID: 215713
		[Token(Token = "0x4034AA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
