using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x02007085 RID: 28805
	[Token(Token = "0x2007085")]
	public class ActMultiV3BattleFinishCompleteInfoView : ActMultiV3BattleFinishPhaseView
	{
		// Token: 0x170060D2 RID: 24786
		// (get) Token: 0x06028EBD RID: 167613 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028EBE RID: 167614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060D2")]
		public Action onNextClick
		{
			[Token(Token = "0x6028EBD")]
			[Address(RVA = "0x244A900", Offset = "0x2449500", VA = "0x18244A900")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028EBE")]
			[Address(RVA = "0x244A960", Offset = "0x2449560", VA = "0x18244A960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028EBF RID: 167615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028EBF")]
		[Address(RVA = "0x244A2D0", Offset = "0x2448ED0", VA = "0x18244A2D0", Slot = "5")]
		public override IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06028EC0 RID: 167616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028EC0")]
		[Address(RVA = "0x24497E0", Offset = "0x24483E0", VA = "0x1824497E0")]
		public IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x06028EC1 RID: 167617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EC1")]
		[Address(RVA = "0x244A800", Offset = "0x2449400", VA = "0x18244A800")]
		private void _OnAnimEnterComplete()
		{
		}

		// Token: 0x06028EC2 RID: 167618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EC2")]
		[Address(RVA = "0x2449890", Offset = "0x2448490", VA = "0x182449890", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06028EC3 RID: 167619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EC3")]
		[Address(RVA = "0x244A710", Offset = "0x2449310", VA = "0x18244A710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028EC4 RID: 167620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EC4")]
		[Address(RVA = "0x244A380", Offset = "0x2448F80", VA = "0x18244A380")]
		private void _CreateModeViewIfNeed(ActMultiV3BattleFinishViewModel viewModel)
		{
		}

		// Token: 0x06028EC5 RID: 167621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EC5")]
		[Address(RVA = "0x244A5E0", Offset = "0x24491E0", VA = "0x18244A5E0")]
		private void _InitAnimIfNot(bool isEarlyQuit)
		{
		}

		// Token: 0x06028EC6 RID: 167622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EC6")]
		[Address(RVA = "0x2449700", Offset = "0x2448300", VA = "0x182449700")]
		public void EventOnBtnNextClick()
		{
		}

		// Token: 0x06028EC7 RID: 167623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EC7")]
		[Address(RVA = "0x244A860", Offset = "0x2449460", VA = "0x18244A860")]
		public ActMultiV3BattleFinishCompleteInfoView()
		{
		}

		// Token: 0x0403A618 RID: 239128
		[Token(Token = "0x403A618")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403A619 RID: 239129
		[Token(Token = "0x403A619")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _enterQuitAnim;

		// Token: 0x0403A61A RID: 239130
		[Token(Token = "0x403A61A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _nextAnim;

		// Token: 0x0403A61B RID: 239131
		[Token(Token = "0x403A61B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _hideAnim;

		// Token: 0x0403A61C RID: 239132
		[Token(Token = "0x403A61C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _btnNextRaycastGO;

		// Token: 0x0403A61D RID: 239133
		[Token(Token = "0x403A61D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _btnNextNormalPartGO;

		// Token: 0x0403A61E RID: 239134
		[Token(Token = "0x403A61E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _btnNextQuitPartGO;

		// Token: 0x0403A61F RID: 239135
		[Token(Token = "0x403A61F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _earlyQuitGO;

		// Token: 0x0403A620 RID: 239136
		[Token(Token = "0x403A620")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _selfQuitHintGO;

		// Token: 0x0403A621 RID: 239137
		[Token(Token = "0x403A621")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _mateQuitHintGO;

		// Token: 0x0403A622 RID: 239138
		[Token(Token = "0x403A622")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x0403A623 RID: 239139
		[Token(Token = "0x403A623")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _normalTitleGO;

		// Token: 0x0403A624 RID: 239140
		[Token(Token = "0x403A624")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _earlyQuitTitleGO;

		// Token: 0x0403A625 RID: 239141
		[Token(Token = "0x403A625")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _textModeName;

		// Token: 0x0403A626 RID: 239142
		[Token(Token = "0x403A626")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ActMultiV3BattleFinishRewardView _rewardView;

		// Token: 0x0403A627 RID: 239143
		[Token(Token = "0x403A627")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private ActMultiV3BattleFinishIllustView _illustView;

		// Token: 0x0403A628 RID: 239144
		[Token(Token = "0x403A628")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private ActMultiV3DifficultyIconView _diffIconPrefab;

		// Token: 0x0403A629 RID: 239145
		[Token(Token = "0x403A629")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _diffIconContainer;

		// Token: 0x0403A62A RID: 239146
		[Token(Token = "0x403A62A")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private ActMultiV3BattleFinishModeViewBase[] _modePrefabList;

		// Token: 0x0403A62B RID: 239147
		[Token(Token = "0x403A62B")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private RectTransform _modeViewContainer;

		// Token: 0x0403A62C RID: 239148
		[Token(Token = "0x403A62C")]
		[FieldOffset(Offset = "0x110")]
		private bool m_hasInited;

		// Token: 0x0403A62D RID: 239149
		[Token(Token = "0x403A62D")]
		[FieldOffset(Offset = "0x111")]
		private bool m_hasInitAnim;

		// Token: 0x0403A62E RID: 239150
		[Token(Token = "0x403A62E")]
		[FieldOffset(Offset = "0x118")]
		private Tween m_animTween;

		// Token: 0x0403A62F RID: 239151
		[Token(Token = "0x403A62F")]
		[FieldOffset(Offset = "0x120")]
		private ActMultiV3BattleFinishModeViewBase m_modeView;

		// Token: 0x0403A630 RID: 239152
		[Token(Token = "0x403A630")]
		[FieldOffset(Offset = "0x128")]
		private ActMultiV3DifficultyIconView m_diffIconView;

		// Token: 0x0403A632 RID: 239154
		[Token(Token = "0x403A632")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNextClick;

		// Token: 0x0403A633 RID: 239155
		[Token(Token = "0x403A633")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNextClick;

		// Token: 0x0403A634 RID: 239156
		[Token(Token = "0x403A634")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403A635 RID: 239157
		[Token(Token = "0x403A635")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403A636 RID: 239158
		[Token(Token = "0x403A636")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnAnimEnterComplete;

		// Token: 0x0403A637 RID: 239159
		[Token(Token = "0x403A637")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403A638 RID: 239160
		[Token(Token = "0x403A638")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A639 RID: 239161
		[Token(Token = "0x403A639")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateModeViewIfNeed;

		// Token: 0x0403A63A RID: 239162
		[Token(Token = "0x403A63A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitAnimIfNot;

		// Token: 0x0403A63B RID: 239163
		[Token(Token = "0x403A63B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBtnNextClick;

		// Token: 0x0403A63C RID: 239164
		[Token(Token = "0x403A63C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
