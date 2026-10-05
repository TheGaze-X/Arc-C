using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CC7 RID: 27847
	[Token(Token = "0x2006CC7")]
	public class TemplateActivityMilestoneHolder : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x06027BA6 RID: 162726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BA6")]
		[Address(RVA = "0x22E2DB0", Offset = "0x22E19B0", VA = "0x1822E2DB0", Slot = "4")]
		public void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027BA7 RID: 162727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BA7")]
		[Address(RVA = "0x22E31F0", Offset = "0x22E1DF0", VA = "0x1822E31F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027BA8 RID: 162728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BA8")]
		[Address(RVA = "0x22E2820", Offset = "0x22E1420", VA = "0x1822E2820")]
		public void FocusOnIdx(int targetIndex)
		{
		}

		// Token: 0x06027BA9 RID: 162729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027BA9")]
		[Address(RVA = "0x22E3260", Offset = "0x22E1E60", VA = "0x1822E3260")]
		private Sprite _LoadItemIcon(string itemId)
		{
			return null;
		}

		// Token: 0x06027BAA RID: 162730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BAA")]
		[Address(RVA = "0x22E33D0", Offset = "0x22E1FD0", VA = "0x1822E33D0")]
		public TemplateActivityMilestoneHolder()
		{
		}

		// Token: 0x0403854E RID: 230734
		[Token(Token = "0x403854E")]
		private const int SLIDE_MAX_LENGTH = 10;

		// Token: 0x0403854F RID: 230735
		[Token(Token = "0x403854F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TemplateActivityCommonMileStoneAdapter _adapter;

		// Token: 0x04038550 RID: 230736
		[Token(Token = "0x4038550")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LoopHorizontalScrollRect _content;

		// Token: 0x04038551 RID: 230737
		[Token(Token = "0x4038551")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GridLayoutGroup _layout;

		// Token: 0x04038552 RID: 230738
		[Token(Token = "0x4038552")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgMilestoneIcon;

		// Token: 0x04038553 RID: 230739
		[Token(Token = "0x4038553")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textMilestoneCount;

		// Token: 0x04038554 RID: 230740
		[Token(Token = "0x4038554")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _btnRewardToggle;

		// Token: 0x04038555 RID: 230741
		[Token(Token = "0x4038555")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TemplateActivityMilestoneWidget _widget;

		// Token: 0x04038556 RID: 230742
		[Token(Token = "0x4038556")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _durationTween;

		// Token: 0x04038557 RID: 230743
		[Token(Token = "0x4038557")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _delayTween;

		// Token: 0x04038558 RID: 230744
		[Token(Token = "0x4038558")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x04038559 RID: 230745
		[Token(Token = "0x4038559")]
		[FieldOffset(Offset = "0x60")]
		private UISwitchTween.TweenWrapper m_focusTween;

		// Token: 0x0403855A RID: 230746
		[Token(Token = "0x403855A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403855B RID: 230747
		[Token(Token = "0x403855B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403855C RID: 230748
		[Token(Token = "0x403855C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FocusOnIdx;

		// Token: 0x0403855D RID: 230749
		[Token(Token = "0x403855D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadItemIcon;

		// Token: 0x0403855E RID: 230750
		[Token(Token = "0x403855E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
