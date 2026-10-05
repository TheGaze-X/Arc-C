using System;
using Il2CppDummyDll;
using Torappu.UI.Home;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006606 RID: 26118
	[Token(Token = "0x2006606")]
	public class ArtGalleryHomeBackgroundBottomDetailView : ArtGalleryBottomDetailViewBase
	{
		// Token: 0x0602585A RID: 153690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602585A")]
		[Address(RVA = "0x2082C80", Offset = "0x2081880", VA = "0x182082C80", Slot = "5")]
		public override void OnUpdate(ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam itemSelectParam)
		{
		}

		// Token: 0x0602585B RID: 153691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602585B")]
		[Address(RVA = "0x2083080", Offset = "0x2081C80", VA = "0x182083080")]
		private void _RenderUnlockCondition()
		{
		}

		// Token: 0x0602585C RID: 153692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602585C")]
		[Address(RVA = "0x2082AE0", Offset = "0x20816E0", VA = "0x182082AE0")]
		public void EventOnClickPreview()
		{
		}

		// Token: 0x0602585D RID: 153693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602585D")]
		[Address(RVA = "0x2083190", Offset = "0x2081D90", VA = "0x182083190")]
		public ArtGalleryHomeBackgroundBottomDetailView()
		{
		}

		// Token: 0x04034B26 RID: 215846
		[Token(Token = "0x4034B26")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLockIcon;

		// Token: 0x04034B27 RID: 215847
		[Token(Token = "0x4034B27")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLockDesc;

		// Token: 0x04034B28 RID: 215848
		[Token(Token = "0x4034B28")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUnlockDesc;

		// Token: 0x04034B29 RID: 215849
		[Token(Token = "0x4034B29")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelMultiForm;

		// Token: 0x04034B2A RID: 215850
		[Token(Token = "0x4034B2A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelMusic;

		// Token: 0x04034B2B RID: 215851
		[Token(Token = "0x4034B2B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelPreview;

		// Token: 0x04034B2C RID: 215852
		[Token(Token = "0x4034B2C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04034B2D RID: 215853
		[Token(Token = "0x4034B2D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textUnlockConditions;

		// Token: 0x04034B2E RID: 215854
		[Token(Token = "0x4034B2E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x04034B2F RID: 215855
		[Token(Token = "0x4034B2F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textMusicName;

		// Token: 0x04034B30 RID: 215856
		[Token(Token = "0x4034B30")]
		[FieldOffset(Offset = "0x68")]
		private ArtGalleryDisplayHomeBackgroundItemViewModel m_cachedItemViewModel;

		// Token: 0x04034B31 RID: 215857
		[Token(Token = "0x4034B31")]
		[FieldOffset(Offset = "0x70")]
		private CommonLimitObtainModel m_cachedLimitObtainModel;

		// Token: 0x04034B32 RID: 215858
		[Token(Token = "0x4034B32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04034B33 RID: 215859
		[Token(Token = "0x4034B33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderUnlockCondition;

		// Token: 0x04034B34 RID: 215860
		[Token(Token = "0x4034B34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClickPreview;

		// Token: 0x04034B35 RID: 215861
		[Token(Token = "0x4034B35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
