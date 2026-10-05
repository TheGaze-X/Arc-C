using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065EC RID: 26092
	[Token(Token = "0x20065EC")]
	public class ArtGalleryCollectCharSkinView : ArtGalleryCollectItemViewBase<ArtGalleryCollectCharSkinModel>
	{
		// Token: 0x0602580B RID: 153611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602580B")]
		[Address(RVA = "0x20712C0", Offset = "0x206FEC0", VA = "0x1820712C0", Slot = "4")]
		protected override void _DoRender(ArtGalleryCollectCharSkinModel model)
		{
		}

		// Token: 0x0602580C RID: 153612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602580C")]
		[Address(RVA = "0x20711D0", Offset = "0x206FDD0", VA = "0x1820711D0", Slot = "5")]
		protected override void _DoJump()
		{
		}

		// Token: 0x0602580D RID: 153613 RVA: 0x000C8118 File Offset: 0x000C6318
		[Token(Token = "0x602580D")]
		[Address(RVA = "0x2071A90", Offset = "0x2070690", VA = "0x182071A90")]
		private bool _TryRenderDynPortrait(CharUISkinStruct skinStruct)
		{
			return default(bool);
		}

		// Token: 0x0602580E RID: 153614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602580E")]
		[Address(RVA = "0x2071C70", Offset = "0x2070870", VA = "0x182071C70")]
		public ArtGalleryCollectCharSkinView()
		{
		}

		// Token: 0x04034A7E RID: 215678
		[Token(Token = "0x4034A7E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04034A7F RID: 215679
		[Token(Token = "0x4034A7F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _charName;

		// Token: 0x04034A80 RID: 215680
		[Token(Token = "0x4034A80")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04034A81 RID: 215681
		[Token(Token = "0x4034A81")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _portraitImage;

		// Token: 0x04034A82 RID: 215682
		[Token(Token = "0x4034A82")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _dynContainer;

		// Token: 0x04034A83 RID: 215683
		[Token(Token = "0x4034A83")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04034A84 RID: 215684
		[Token(Token = "0x4034A84")]
		[FieldOffset(Offset = "0x90")]
		private UICharacterDynPortrait m_dynPortrait;

		// Token: 0x04034A85 RID: 215685
		[Token(Token = "0x4034A85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__DoRender;

		// Token: 0x04034A86 RID: 215686
		[Token(Token = "0x4034A86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoJump;

		// Token: 0x04034A87 RID: 215687
		[Token(Token = "0x4034A87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryRenderDynPortrait;

		// Token: 0x04034A88 RID: 215688
		[Token(Token = "0x4034A88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
