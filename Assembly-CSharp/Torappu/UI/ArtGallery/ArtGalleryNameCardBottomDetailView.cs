using System;
using Il2CppDummyDll;
using Torappu.UI.Home;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006608 RID: 26120
	[Token(Token = "0x2006608")]
	public class ArtGalleryNameCardBottomDetailView : ArtGalleryBottomDetailViewBase
	{
		// Token: 0x06025862 RID: 153698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025862")]
		[Address(RVA = "0x2087080", Offset = "0x2085C80", VA = "0x182087080", Slot = "5")]
		public override void OnUpdate(ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam itemSelectParam)
		{
		}

		// Token: 0x06025863 RID: 153699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025863")]
		[Address(RVA = "0x2087450", Offset = "0x2086050", VA = "0x182087450")]
		private void _RenderUnlockCondition()
		{
		}

		// Token: 0x06025864 RID: 153700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025864")]
		[Address(RVA = "0x2086FA0", Offset = "0x2085BA0", VA = "0x182086FA0")]
		public void EventOnClickPreview()
		{
		}

		// Token: 0x06025865 RID: 153701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025865")]
		[Address(RVA = "0x2087560", Offset = "0x2086160", VA = "0x182087560")]
		public ArtGalleryNameCardBottomDetailView()
		{
		}

		// Token: 0x04034B44 RID: 215876
		[Token(Token = "0x4034B44")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLockIcon;

		// Token: 0x04034B45 RID: 215877
		[Token(Token = "0x4034B45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLockDesc;

		// Token: 0x04034B46 RID: 215878
		[Token(Token = "0x4034B46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUnlockDesc;

		// Token: 0x04034B47 RID: 215879
		[Token(Token = "0x4034B47")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelPreview;

		// Token: 0x04034B48 RID: 215880
		[Token(Token = "0x4034B48")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04034B49 RID: 215881
		[Token(Token = "0x4034B49")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textUnlockConditions;

		// Token: 0x04034B4A RID: 215882
		[Token(Token = "0x4034B4A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x04034B4B RID: 215883
		[Token(Token = "0x4034B4B")]
		[FieldOffset(Offset = "0x50")]
		private ArtGalleryDisplayNameCardSkinItemViewModel m_cachedItemViewModel;

		// Token: 0x04034B4C RID: 215884
		[Token(Token = "0x4034B4C")]
		[FieldOffset(Offset = "0x58")]
		private CommonLimitObtainModel m_cachedLimitObtainModel;

		// Token: 0x04034B4D RID: 215885
		[Token(Token = "0x4034B4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04034B4E RID: 215886
		[Token(Token = "0x4034B4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderUnlockCondition;

		// Token: 0x04034B4F RID: 215887
		[Token(Token = "0x4034B4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClickPreview;

		// Token: 0x04034B50 RID: 215888
		[Token(Token = "0x4034B50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
