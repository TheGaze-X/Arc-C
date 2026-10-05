using System;
using System.Collections;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044A9 RID: 17577
	[Token(Token = "0x20044A9")]
	public class RoguelikeTopicChallengeEndingScoreView : RoguelikeClassicEndingPageView<RoguelikeTopicChallengeEndingViewModel>
	{
		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x0601AD99 RID: 109977 RVA: 0x000A37A0 File Offset: 0x000A19A0
		[Token(Token = "0x17003FB9")]
		public override ViewType viewType
		{
			[Token(Token = "0x601AD99")]
			[Address(RVA = "0x14038C0", Offset = "0x14024C0", VA = "0x1814038C0", Slot = "4")]
			get
			{
				return ViewType.NONE;
			}
		}

		// Token: 0x17003FBA RID: 16314
		// (set) Token: 0x0601AD9A RID: 109978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FBA")]
		public override Action onForward
		{
			[Token(Token = "0x601AD9A")]
			[Address(RVA = "0x1403A20", Offset = "0x1402620", VA = "0x181403A20", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17003FBB RID: 16315
		// (set) Token: 0x0601AD9B RID: 109979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FBB")]
		public override Action onBack
		{
			[Token(Token = "0x601AD9B")]
			[Address(RVA = "0x1403920", Offset = "0x1402520", VA = "0x181403920", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17003FBC RID: 16316
		// (set) Token: 0x0601AD9C RID: 109980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FBC")]
		public override Action onConfirm
		{
			[Token(Token = "0x601AD9C")]
			[Address(RVA = "0x14039A0", Offset = "0x14025A0", VA = "0x1814039A0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x0601AD9D RID: 109981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD9D")]
		[Address(RVA = "0x1402C30", Offset = "0x1401830", VA = "0x181402C30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AD9E RID: 109982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD9E")]
		[Address(RVA = "0x1402670", Offset = "0x1401270", VA = "0x181402670", Slot = "11")]
		protected override void Render(RoguelikeEndingControllerBase endingController, RoguelikeTopicChallengeEndingViewModel viewModel)
		{
		}

		// Token: 0x0601AD9F RID: 109983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD9F")]
		[Address(RVA = "0x1402D00", Offset = "0x1401900", VA = "0x181402D00")]
		private void _RenderChallengeCard(RoguelikeTopicChallengeEndingViewModel viewModel, RoguelikeTopicChallenge challengeData)
		{
		}

		// Token: 0x0601ADA0 RID: 109984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADA0")]
		[Address(RVA = "0x1403370", Offset = "0x1401F70", VA = "0x181403370")]
		private void _RenderTasks(RoguelikeTopicChallengeEndingViewModel viewModel, RoguelikeTopicChallenge challengeData)
		{
		}

		// Token: 0x0601ADA1 RID: 109985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADA1")]
		[Address(RVA = "0x1402EC0", Offset = "0x1401AC0", VA = "0x181402EC0")]
		private void _RenderDownSide(RoguelikeTopicChallengeEndingViewModel viewModel)
		{
		}

		// Token: 0x0601ADA2 RID: 109986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADA2")]
		[Address(RVA = "0x1402BC0", Offset = "0x14017C0", VA = "0x181402BC0")]
		private void _ClearCacheTween()
		{
		}

		// Token: 0x0601ADA3 RID: 109987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ADA3")]
		[Address(RVA = "0x1402B00", Offset = "0x1401700", VA = "0x181402B00")]
		private IEnumerator _ApplyInAnim(bool fastMode)
		{
			return null;
		}

		// Token: 0x0601ADA4 RID: 109988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADA4")]
		[Address(RVA = "0x1402430", Offset = "0x1401030", VA = "0x181402430", Slot = "10")]
		public override void ApplyOutAnim()
		{
		}

		// Token: 0x0601ADA5 RID: 109989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADA5")]
		[Address(RVA = "0x1402590", Offset = "0x1401190", VA = "0x181402590")]
		public void OnBackClicked()
		{
		}

		// Token: 0x0601ADA6 RID: 109990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADA6")]
		[Address(RVA = "0x1402600", Offset = "0x1401200", VA = "0x181402600")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x0601ADA7 RID: 109991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADA7")]
		[Address(RVA = "0x1403840", Offset = "0x1402440", VA = "0x181403840")]
		public RoguelikeTopicChallengeEndingScoreView()
		{
		}

		// Token: 0x04022635 RID: 140853
		[Token(Token = "0x4022635")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04022636 RID: 140854
		[Token(Token = "0x4022636")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04022637 RID: 140855
		[Token(Token = "0x4022637")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Challenge Card")]
		private Image _cover;

		// Token: 0x04022638 RID: 140856
		[Token(Token = "0x4022638")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Challenge Card")]
		private Text _name;

		// Token: 0x04022639 RID: 140857
		[Token(Token = "0x4022639")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Challenge Card")]
		private GameObject _completeTag;

		// Token: 0x0402263A RID: 140858
		[Token(Token = "0x402263A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Tasks")]
		private RoguelikeTopicChallengeEndingTaskView[] _tasks;

		// Token: 0x0402263B RID: 140859
		[Token(Token = "0x402263B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Tasks")]
		private GameObject _incompletePanel;

		// Token: 0x0402263C RID: 140860
		[Token(Token = "0x402263C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Tasks")]
		private GameObject _completePanel;

		// Token: 0x0402263D RID: 140861
		[Token(Token = "0x402263D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Tasks")]
		private GameObject _normalPanel;

		// Token: 0x0402263E RID: 140862
		[Token(Token = "0x402263E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Tasks")]
		private GameObject _repeatPanel;

		// Token: 0x0402263F RID: 140863
		[Token(Token = "0x402263F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Down Side")]
		private RoguelikeTopicChallengeEndingExpView _expView;

		// Token: 0x04022640 RID: 140864
		[Token(Token = "0x4022640")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Down Side")]
		private GameObject _splitPanel;

		// Token: 0x04022641 RID: 140865
		[Token(Token = "0x4022641")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Down Side")]
		private RectTransform _rewardsRoot;

		// Token: 0x04022642 RID: 140866
		[Token(Token = "0x4022642")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Down Side")]
		private GameObject _rewardItemHolder;

		// Token: 0x04022643 RID: 140867
		[Token(Token = "0x4022643")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _taskThemeColor;

		// Token: 0x04022644 RID: 140868
		[Token(Token = "0x4022644")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _rewardCardScale;

		// Token: 0x04022645 RID: 140869
		[Token(Token = "0x4022645")]
		private const string CHALLENGE_STATS_IN_ANIM = "anim_challenge_score_in";

		// Token: 0x04022646 RID: 140870
		[Token(Token = "0x4022646")]
		private const string CHALLENGE_STATS_OUT_ANIM = "anim_challenge_score_out";

		// Token: 0x04022647 RID: 140871
		[Token(Token = "0x4022647")]
		private const float FADE_DURATION = 0.5f;

		// Token: 0x04022648 RID: 140872
		[Token(Token = "0x4022648")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_hasAnimPlayed;

		// Token: 0x04022649 RID: 140873
		[Token(Token = "0x4022649")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_displayTween;

		// Token: 0x0402264A RID: 140874
		[Token(Token = "0x402264A")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_cacheTween;

		// Token: 0x0402264B RID: 140875
		[Token(Token = "0x402264B")]
		[FieldOffset(Offset = "0xB0")]
		private Action m_backAction;

		// Token: 0x0402264C RID: 140876
		[Token(Token = "0x402264C")]
		[FieldOffset(Offset = "0xB8")]
		private Action m_confirmAction;

		// Token: 0x0402264D RID: 140877
		[Token(Token = "0x402264D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402264E RID: 140878
		[Token(Token = "0x402264E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onForward;

		// Token: 0x0402264F RID: 140879
		[Token(Token = "0x402264F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onBack;

		// Token: 0x04022650 RID: 140880
		[Token(Token = "0x4022650")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onConfirm;

		// Token: 0x04022651 RID: 140881
		[Token(Token = "0x4022651")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022652 RID: 140882
		[Token(Token = "0x4022652")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022653 RID: 140883
		[Token(Token = "0x4022653")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderChallengeCard;

		// Token: 0x04022654 RID: 140884
		[Token(Token = "0x4022654")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderTasks;

		// Token: 0x04022655 RID: 140885
		[Token(Token = "0x4022655")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderDownSide;

		// Token: 0x04022656 RID: 140886
		[Token(Token = "0x4022656")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearCacheTween;

		// Token: 0x04022657 RID: 140887
		[Token(Token = "0x4022657")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ApplyInAnim;

		// Token: 0x04022658 RID: 140888
		[Token(Token = "0x4022658")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ApplyOutAnim;

		// Token: 0x04022659 RID: 140889
		[Token(Token = "0x4022659")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x0402265A RID: 140890
		[Token(Token = "0x402265A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x0402265B RID: 140891
		[Token(Token = "0x402265B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
