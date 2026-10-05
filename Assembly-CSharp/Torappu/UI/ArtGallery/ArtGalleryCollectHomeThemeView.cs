using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065EF RID: 26095
	[Token(Token = "0x20065EF")]
	public class ArtGalleryCollectHomeThemeView : ArtGalleryCollectItemViewBase<ArtGalleryCollectHomeThemeModel>
	{
		// Token: 0x06025815 RID: 153621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025815")]
		[Address(RVA = "0x207B7F0", Offset = "0x207A3F0", VA = "0x18207B7F0", Slot = "4")]
		protected override void _DoRender(ArtGalleryCollectHomeThemeModel model)
		{
		}

		// Token: 0x06025816 RID: 153622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025816")]
		[Address(RVA = "0x207B700", Offset = "0x207A300", VA = "0x18207B700", Slot = "5")]
		protected override void _DoJump()
		{
		}

		// Token: 0x06025817 RID: 153623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025817")]
		[Address(RVA = "0x207BB60", Offset = "0x207A760", VA = "0x18207BB60")]
		public ArtGalleryCollectHomeThemeView()
		{
		}

		// Token: 0x04034A93 RID: 215699
		[Token(Token = "0x4034A93")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04034A94 RID: 215700
		[Token(Token = "0x4034A94")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04034A95 RID: 215701
		[Token(Token = "0x4034A95")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _itemPic;

		// Token: 0x04034A96 RID: 215702
		[Token(Token = "0x4034A96")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _iconMulti;

		// Token: 0x04034A97 RID: 215703
		[Token(Token = "0x4034A97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__DoRender;

		// Token: 0x04034A98 RID: 215704
		[Token(Token = "0x4034A98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoJump;

		// Token: 0x04034A99 RID: 215705
		[Token(Token = "0x4034A99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
