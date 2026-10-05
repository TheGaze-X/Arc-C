using System;
using Il2CppDummyDll;
using Torappu.UI.Home;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006607 RID: 26119
	[Token(Token = "0x2006607")]
	public class ArtGalleryHomeThemeBottomDetailView : ArtGalleryBottomDetailViewBase
	{
		// Token: 0x0602585E RID: 153694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602585E")]
		[Address(RVA = "0x2083450", Offset = "0x2082050", VA = "0x182083450", Slot = "5")]
		public override void OnUpdate(ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam itemSelectParam)
		{
		}

		// Token: 0x0602585F RID: 153695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602585F")]
		[Address(RVA = "0x20837C0", Offset = "0x20823C0", VA = "0x1820837C0")]
		private void _RenderUnlockCondition()
		{
		}

		// Token: 0x06025860 RID: 153696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025860")]
		[Address(RVA = "0x20832B0", Offset = "0x2081EB0", VA = "0x1820832B0")]
		public void EventOnClickPreview()
		{
		}

		// Token: 0x06025861 RID: 153697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025861")]
		[Address(RVA = "0x20838D0", Offset = "0x20824D0", VA = "0x1820838D0")]
		public ArtGalleryHomeThemeBottomDetailView()
		{
		}

		// Token: 0x04034B36 RID: 215862
		[Token(Token = "0x4034B36")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLockIcon;

		// Token: 0x04034B37 RID: 215863
		[Token(Token = "0x4034B37")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLockDesc;

		// Token: 0x04034B38 RID: 215864
		[Token(Token = "0x4034B38")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUnlockDesc;

		// Token: 0x04034B39 RID: 215865
		[Token(Token = "0x4034B39")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelMultiForm;

		// Token: 0x04034B3A RID: 215866
		[Token(Token = "0x4034B3A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelPreview;

		// Token: 0x04034B3B RID: 215867
		[Token(Token = "0x4034B3B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04034B3C RID: 215868
		[Token(Token = "0x4034B3C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textUnlockConditions;

		// Token: 0x04034B3D RID: 215869
		[Token(Token = "0x4034B3D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x04034B3E RID: 215870
		[Token(Token = "0x4034B3E")]
		[FieldOffset(Offset = "0x58")]
		private ArtGalleryDisplayHomeThemeItemViewModel m_cachedItemViewModel;

		// Token: 0x04034B3F RID: 215871
		[Token(Token = "0x4034B3F")]
		[FieldOffset(Offset = "0x60")]
		private CommonLimitObtainModel m_cachedLimitObtainModel;

		// Token: 0x04034B40 RID: 215872
		[Token(Token = "0x4034B40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04034B41 RID: 215873
		[Token(Token = "0x4034B41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderUnlockCondition;

		// Token: 0x04034B42 RID: 215874
		[Token(Token = "0x4034B42")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClickPreview;

		// Token: 0x04034B43 RID: 215875
		[Token(Token = "0x4034B43")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
