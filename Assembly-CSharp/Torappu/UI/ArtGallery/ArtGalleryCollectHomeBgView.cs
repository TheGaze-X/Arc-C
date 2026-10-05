using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065EE RID: 26094
	[Token(Token = "0x20065EE")]
	public class ArtGalleryCollectHomeBgView : ArtGalleryCollectItemViewBase<ArtGalleryCollectHomeBgModel>
	{
		// Token: 0x06025812 RID: 153618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025812")]
		[Address(RVA = "0x207AEC0", Offset = "0x2079AC0", VA = "0x18207AEC0", Slot = "4")]
		protected override void _DoRender(ArtGalleryCollectHomeBgModel model)
		{
		}

		// Token: 0x06025813 RID: 153619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025813")]
		[Address(RVA = "0x207ADD0", Offset = "0x20799D0", VA = "0x18207ADD0", Slot = "5")]
		protected override void _DoJump()
		{
		}

		// Token: 0x06025814 RID: 153620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025814")]
		[Address(RVA = "0x207B230", Offset = "0x2079E30", VA = "0x18207B230")]
		public ArtGalleryCollectHomeBgView()
		{
		}

		// Token: 0x04034A8C RID: 215692
		[Token(Token = "0x4034A8C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04034A8D RID: 215693
		[Token(Token = "0x4034A8D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04034A8E RID: 215694
		[Token(Token = "0x4034A8E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _itemPic;

		// Token: 0x04034A8F RID: 215695
		[Token(Token = "0x4034A8F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _iconMulti;

		// Token: 0x04034A90 RID: 215696
		[Token(Token = "0x4034A90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__DoRender;

		// Token: 0x04034A91 RID: 215697
		[Token(Token = "0x4034A91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoJump;

		// Token: 0x04034A92 RID: 215698
		[Token(Token = "0x4034A92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
