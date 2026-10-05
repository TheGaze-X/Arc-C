using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005291 RID: 21137
	[Token(Token = "0x2005291")]
	public class RoguelikeClassicEndingMonthStatsScoreView : RoguelikeClassicEndingPageView<RoguelikeClassicEndingMonthViewModel>
	{
		// Token: 0x1700491A RID: 18714
		// (get) Token: 0x0601F2FD RID: 127741 RVA: 0x000B1240 File Offset: 0x000AF440
		[Token(Token = "0x1700491A")]
		public override ViewType viewType
		{
			[Token(Token = "0x601F2FD")]
			[Address(RVA = "0x18E2240", Offset = "0x18E0E40", VA = "0x1818E2240", Slot = "4")]
			get
			{
				return ViewType.NONE;
			}
		}

		// Token: 0x1700491B RID: 18715
		// (set) Token: 0x0601F2FE RID: 127742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700491B")]
		public override Action onForward
		{
			[Token(Token = "0x601F2FE")]
			[Address(RVA = "0x18E23A0", Offset = "0x18E0FA0", VA = "0x1818E23A0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x1700491C RID: 18716
		// (set) Token: 0x0601F2FF RID: 127743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700491C")]
		public override Action onBack
		{
			[Token(Token = "0x601F2FF")]
			[Address(RVA = "0x18E22A0", Offset = "0x18E0EA0", VA = "0x1818E22A0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700491D RID: 18717
		// (set) Token: 0x0601F300 RID: 127744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700491D")]
		public override Action onConfirm
		{
			[Token(Token = "0x601F300")]
			[Address(RVA = "0x18E2320", Offset = "0x18E0F20", VA = "0x1818E2320", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x0601F301 RID: 127745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F301")]
		[Address(RVA = "0x18E1E60", Offset = "0x18E0A60", VA = "0x1818E1E60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F302 RID: 127746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F302")]
		[Address(RVA = "0x18E1830", Offset = "0x18E0430", VA = "0x1818E1830", Slot = "11")]
		protected override void Render(RoguelikeEndingControllerBase endingController, RoguelikeClassicEndingMonthViewModel viewModel)
		{
		}

		// Token: 0x0601F303 RID: 127747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F303")]
		[Address(RVA = "0x18E20E0", Offset = "0x18E0CE0", VA = "0x1818E20E0")]
		private void _RenderEndInfoView(RoguelikeClassicEndingMonthViewModel viewModel)
		{
		}

		// Token: 0x0601F304 RID: 127748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F304")]
		[Address(RVA = "0x18E1DF0", Offset = "0x18E09F0", VA = "0x1818E1DF0")]
		private void _ClearCacheTween()
		{
		}

		// Token: 0x0601F305 RID: 127749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F305")]
		[Address(RVA = "0x18E1D30", Offset = "0x18E0930", VA = "0x1818E1D30")]
		private IEnumerator _ApplyInAnim(bool fastMode)
		{
			return null;
		}

		// Token: 0x0601F306 RID: 127750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F306")]
		[Address(RVA = "0x18E15F0", Offset = "0x18E01F0", VA = "0x1818E15F0", Slot = "10")]
		public override void ApplyOutAnim()
		{
		}

		// Token: 0x0601F307 RID: 127751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F307")]
		[Address(RVA = "0x18E1750", Offset = "0x18E0350", VA = "0x1818E1750")]
		public void OnBackClicked()
		{
		}

		// Token: 0x0601F308 RID: 127752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F308")]
		[Address(RVA = "0x18E17C0", Offset = "0x18E03C0", VA = "0x1818E17C0")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x0601F309 RID: 127753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F309")]
		[Address(RVA = "0x18E21C0", Offset = "0x18E0DC0", VA = "0x1818E21C0")]
		public RoguelikeClassicEndingMonthStatsScoreView()
		{
		}

		// Token: 0x04029DB4 RID: 171444
		[Token(Token = "0x4029DB4")]
		private const string MONTH_STATS_IN_ANIM = "anim_month_score_in";

		// Token: 0x04029DB5 RID: 171445
		[Token(Token = "0x4029DB5")]
		private const string MONTH_STATS_OUT_ANIM = "anim_month_score_out";

		// Token: 0x04029DB6 RID: 171446
		[Token(Token = "0x4029DB6")]
		private const float FADE_DURATION = 0.5f;

		// Token: 0x04029DB7 RID: 171447
		[Token(Token = "0x4029DB7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04029DB8 RID: 171448
		[Token(Token = "0x4029DB8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04029DB9 RID: 171449
		[Token(Token = "0x4029DB9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _chatUnlockProgressContent;

		// Token: 0x04029DBA RID: 171450
		[Token(Token = "0x4029DBA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _chatUnlockStatus;

		// Token: 0x04029DBB RID: 171451
		[Token(Token = "0x4029DBB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeClassicEndingMonthEndInfoBaseView _endInfoView;

		// Token: 0x04029DBC RID: 171452
		[Token(Token = "0x4029DBC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _rewardContainer;

		// Token: 0x04029DBD RID: 171453
		[Token(Token = "0x4029DBD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RoguelikeTopicMonthSquadRewardView _rewardView;

		// Token: 0x04029DBE RID: 171454
		[Token(Token = "0x4029DBE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _charViewContainer;

		// Token: 0x04029DBF RID: 171455
		[Token(Token = "0x4029DBF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeClassicEndingMonthStatsCharView _charViewPrefab;

		// Token: 0x04029DC0 RID: 171456
		[Token(Token = "0x4029DC0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _bpViewColor;

		// Token: 0x04029DC1 RID: 171457
		[Token(Token = "0x4029DC1")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeTopicMonthSquadRewardView m_rewardView;

		// Token: 0x04029DC2 RID: 171458
		[Token(Token = "0x4029DC2")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeClassicEndingMonthStatsScoreView.ProgressAdapter m_unlockProgressAdapter;

		// Token: 0x04029DC3 RID: 171459
		[Token(Token = "0x4029DC3")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04029DC4 RID: 171460
		[Token(Token = "0x4029DC4")]
		[FieldOffset(Offset = "0x84")]
		private int m_unlockChatNum;

		// Token: 0x04029DC5 RID: 171461
		[Token(Token = "0x4029DC5")]
		[FieldOffset(Offset = "0x88")]
		private int m_chatCount;

		// Token: 0x04029DC6 RID: 171462
		[Token(Token = "0x4029DC6")]
		[FieldOffset(Offset = "0x8C")]
		private Color m_teamColor;

		// Token: 0x04029DC7 RID: 171463
		[Token(Token = "0x4029DC7")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_hasAnimPlayed;

		// Token: 0x04029DC8 RID: 171464
		[Token(Token = "0x4029DC8")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_displayTween;

		// Token: 0x04029DC9 RID: 171465
		[Token(Token = "0x4029DC9")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_cacheTween;

		// Token: 0x04029DCA RID: 171466
		[Token(Token = "0x4029DCA")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeClassicEndingMonthStatsCharView m_charView;

		// Token: 0x04029DCB RID: 171467
		[Token(Token = "0x4029DCB")]
		[FieldOffset(Offset = "0xB8")]
		private Action m_backAction;

		// Token: 0x04029DCC RID: 171468
		[Token(Token = "0x4029DCC")]
		[FieldOffset(Offset = "0xC0")]
		private Action m_confirmAction;

		// Token: 0x04029DCD RID: 171469
		[Token(Token = "0x4029DCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x04029DCE RID: 171470
		[Token(Token = "0x4029DCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onForward;

		// Token: 0x04029DCF RID: 171471
		[Token(Token = "0x4029DCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onBack;

		// Token: 0x04029DD0 RID: 171472
		[Token(Token = "0x4029DD0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onConfirm;

		// Token: 0x04029DD1 RID: 171473
		[Token(Token = "0x4029DD1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029DD2 RID: 171474
		[Token(Token = "0x4029DD2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029DD3 RID: 171475
		[Token(Token = "0x4029DD3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderEndInfoView;

		// Token: 0x04029DD4 RID: 171476
		[Token(Token = "0x4029DD4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ClearCacheTween;

		// Token: 0x04029DD5 RID: 171477
		[Token(Token = "0x4029DD5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ApplyInAnim;

		// Token: 0x04029DD6 RID: 171478
		[Token(Token = "0x4029DD6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplyOutAnim;

		// Token: 0x04029DD7 RID: 171479
		[Token(Token = "0x4029DD7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x04029DD8 RID: 171480
		[Token(Token = "0x4029DD8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x04029DD9 RID: 171481
		[Token(Token = "0x4029DD9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005292 RID: 21138
		[Token(Token = "0x2005292")]
		private class ProgressAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601F30B RID: 127755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F30B")]
			[Address(RVA = "0x18DE7B0", Offset = "0x18DD3B0", VA = "0x1818DE7B0")]
			public ProgressAdapter(RoguelikeClassicEndingMonthStatsScoreView closure)
			{
			}

			// Token: 0x1700491E RID: 18718
			// (get) Token: 0x0601F30C RID: 127756 RVA: 0x000B1258 File Offset: 0x000AF458
			[Token(Token = "0x1700491E")]
			public override int count
			{
				[Token(Token = "0x601F30C")]
				[Address(RVA = "0x18DE830", Offset = "0x18DD430", VA = "0x1818DE830", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601F30D RID: 127757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F30D")]
			[Address(RVA = "0x18DE610", Offset = "0x18DD210", VA = "0x1818DE610", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04029DDA RID: 171482
			[Token(Token = "0x4029DDA")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeClassicEndingMonthStatsScoreView m_closure;

			// Token: 0x04029DDB RID: 171483
			[Token(Token = "0x4029DDB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029DDC RID: 171484
			[Token(Token = "0x4029DDC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04029DDD RID: 171485
			[Token(Token = "0x4029DDD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
