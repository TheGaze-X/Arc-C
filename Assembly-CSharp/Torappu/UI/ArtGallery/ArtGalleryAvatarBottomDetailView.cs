using System;
using Il2CppDummyDll;
using Torappu.UI.Home;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006603 RID: 26115
	[Token(Token = "0x2006603")]
	public class ArtGalleryAvatarBottomDetailView : ArtGalleryBottomDetailViewBase
	{
		// Token: 0x0602584E RID: 153678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602584E")]
		[Address(RVA = "0x206F510", Offset = "0x206E110", VA = "0x18206F510", Slot = "5")]
		public override void OnUpdate(ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam selectParam)
		{
		}

		// Token: 0x0602584F RID: 153679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602584F")]
		[Address(RVA = "0x206F960", Offset = "0x206E560", VA = "0x18206F960")]
		private void _UpdateUnlockStatus(string itemId)
		{
		}

		// Token: 0x06025850 RID: 153680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025850")]
		[Address(RVA = "0x206F770", Offset = "0x206E370", VA = "0x18206F770")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025851 RID: 153681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025851")]
		[Address(RVA = "0x206FA30", Offset = "0x206E630", VA = "0x18206FA30")]
		public ArtGalleryAvatarBottomDetailView()
		{
		}

		// Token: 0x04034B0C RID: 215820
		[Token(Token = "0x4034B0C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _avatarHolder;

		// Token: 0x04034B0D RID: 215821
		[Token(Token = "0x4034B0D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x04034B0E RID: 215822
		[Token(Token = "0x4034B0E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x04034B0F RID: 215823
		[Token(Token = "0x4034B0F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _textToggle;

		// Token: 0x04034B10 RID: 215824
		[Token(Token = "0x4034B10")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04034B11 RID: 215825
		[Token(Token = "0x4034B11")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04034B12 RID: 215826
		[Token(Token = "0x4034B12")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDescLock;

		// Token: 0x04034B13 RID: 215827
		[Token(Token = "0x4034B13")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04034B14 RID: 215828
		[Token(Token = "0x4034B14")]
		[FieldOffset(Offset = "0x58")]
		private PlayerAvatarView m_avatar;

		// Token: 0x04034B15 RID: 215829
		[Token(Token = "0x4034B15")]
		[FieldOffset(Offset = "0x60")]
		private CommonLimitObtainModel m_obtainModel;

		// Token: 0x04034B16 RID: 215830
		[Token(Token = "0x4034B16")]
		[FieldOffset(Offset = "0x68")]
		private AvatarInfo m_cachedAvatarInfo;

		// Token: 0x04034B17 RID: 215831
		[Token(Token = "0x4034B17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04034B18 RID: 215832
		[Token(Token = "0x4034B18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateUnlockStatus;

		// Token: 0x04034B19 RID: 215833
		[Token(Token = "0x4034B19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034B1A RID: 215834
		[Token(Token = "0x4034B1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
