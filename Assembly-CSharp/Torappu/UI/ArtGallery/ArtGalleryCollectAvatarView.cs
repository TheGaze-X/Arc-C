using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065EB RID: 26091
	[Token(Token = "0x20065EB")]
	public class ArtGalleryCollectAvatarView : ArtGalleryCollectItemViewBase<ArtGalleryCollectAvatarModel>
	{
		// Token: 0x06025807 RID: 153607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025807")]
		[Address(RVA = "0x20705D0", Offset = "0x206F1D0", VA = "0x1820705D0", Slot = "4")]
		protected override void _DoRender(ArtGalleryCollectAvatarModel model)
		{
		}

		// Token: 0x06025808 RID: 153608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025808")]
		[Address(RVA = "0x20704E0", Offset = "0x206F0E0", VA = "0x1820704E0", Slot = "5")]
		protected override void _DoJump()
		{
		}

		// Token: 0x06025809 RID: 153609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025809")]
		[Address(RVA = "0x20708C0", Offset = "0x206F4C0", VA = "0x1820708C0", Slot = "6")]
		protected override void _OnInit()
		{
		}

		// Token: 0x0602580A RID: 153610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602580A")]
		[Address(RVA = "0x2070A70", Offset = "0x206F670", VA = "0x182070A70")]
		public ArtGalleryCollectAvatarView()
		{
		}

		// Token: 0x04034A73 RID: 215667
		[Token(Token = "0x4034A73")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04034A74 RID: 215668
		[Token(Token = "0x4034A74")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04034A75 RID: 215669
		[Token(Token = "0x4034A75")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _avatarHolder;

		// Token: 0x04034A76 RID: 215670
		[Token(Token = "0x4034A76")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x04034A77 RID: 215671
		[Token(Token = "0x4034A77")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04034A78 RID: 215672
		[Token(Token = "0x4034A78")]
		[FieldOffset(Offset = "0x88")]
		private PlayerAvatarView m_avatar;

		// Token: 0x04034A79 RID: 215673
		[Token(Token = "0x4034A79")]
		[FieldOffset(Offset = "0x90")]
		private AvatarInfo m_cachedAvatarInfo;

		// Token: 0x04034A7A RID: 215674
		[Token(Token = "0x4034A7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__DoRender;

		// Token: 0x04034A7B RID: 215675
		[Token(Token = "0x4034A7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoJump;

		// Token: 0x04034A7C RID: 215676
		[Token(Token = "0x4034A7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnInit;

		// Token: 0x04034A7D RID: 215677
		[Token(Token = "0x4034A7D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
