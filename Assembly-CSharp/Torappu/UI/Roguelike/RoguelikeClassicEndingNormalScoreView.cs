using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Ending;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005298 RID: 21144
	[Token(Token = "0x2005298")]
	public class RoguelikeClassicEndingNormalScoreView : RoguelikeClassicEndingPageView<RoguelikeClassicEndingNormalViewModel>
	{
		// Token: 0x17004923 RID: 18723
		// (get) Token: 0x0601F324 RID: 127780 RVA: 0x000B12B8 File Offset: 0x000AF4B8
		[Token(Token = "0x17004923")]
		public override ViewType viewType
		{
			[Token(Token = "0x601F324")]
			[Address(RVA = "0x18E38A0", Offset = "0x18E24A0", VA = "0x1818E38A0", Slot = "4")]
			get
			{
				return ViewType.NONE;
			}
		}

		// Token: 0x17004924 RID: 18724
		// (set) Token: 0x0601F325 RID: 127781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004924")]
		public override Action onForward
		{
			[Token(Token = "0x601F325")]
			[Address(RVA = "0x18E3A00", Offset = "0x18E2600", VA = "0x1818E3A00", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17004925 RID: 18725
		// (set) Token: 0x0601F326 RID: 127782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004925")]
		public override Action onBack
		{
			[Token(Token = "0x601F326")]
			[Address(RVA = "0x18E3900", Offset = "0x18E2500", VA = "0x1818E3900", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17004926 RID: 18726
		// (set) Token: 0x0601F327 RID: 127783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004926")]
		public override Action onConfirm
		{
			[Token(Token = "0x601F327")]
			[Address(RVA = "0x18E3980", Offset = "0x18E2580", VA = "0x1818E3980", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x0601F328 RID: 127784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F328")]
		[Address(RVA = "0x18E2CF0", Offset = "0x18E18F0", VA = "0x1818E2CF0", Slot = "11")]
		protected override void Render(RoguelikeEndingControllerBase endingController, RoguelikeClassicEndingNormalViewModel viewModel)
		{
		}

		// Token: 0x0601F329 RID: 127785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F329")]
		[Address(RVA = "0x18E3570", Offset = "0x18E2170", VA = "0x1818E3570")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F32A RID: 127786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F32A")]
		[Address(RVA = "0x18E3500", Offset = "0x18E2100", VA = "0x1818E3500")]
		private void _ClearCacheTween()
		{
		}

		// Token: 0x0601F32B RID: 127787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F32B")]
		[Address(RVA = "0x18E3440", Offset = "0x18E2040", VA = "0x1818E3440")]
		private IEnumerator _ApplyInAnim(bool fastMode)
		{
			return null;
		}

		// Token: 0x0601F32C RID: 127788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F32C")]
		[Address(RVA = "0x18E2AA0", Offset = "0x18E16A0", VA = "0x1818E2AA0", Slot = "10")]
		public override void ApplyOutAnim()
		{
		}

		// Token: 0x0601F32D RID: 127789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F32D")]
		[Address(RVA = "0x18E2C10", Offset = "0x18E1810", VA = "0x1818E2C10")]
		public void OnBackClicked()
		{
		}

		// Token: 0x0601F32E RID: 127790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F32E")]
		[Address(RVA = "0x18E2C80", Offset = "0x18E1880", VA = "0x1818E2C80")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x0601F32F RID: 127791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F32F")]
		[Address(RVA = "0x18E37D0", Offset = "0x18E23D0", VA = "0x1818E37D0")]
		public RoguelikeClassicEndingNormalScoreView()
		{
		}

		// Token: 0x04029E01 RID: 171521
		[Token(Token = "0x4029E01")]
		private const string SCORE_IN_ANIM = "anim_norm_score_in";

		// Token: 0x04029E02 RID: 171522
		[Token(Token = "0x4029E02")]
		private const string SCORE_OUT_ANIM = "anim_norm_score_out";

		// Token: 0x04029E03 RID: 171523
		[Token(Token = "0x4029E03")]
		private const float SCORE_VIEW_WAIT_DELAY = 0.5f;

		// Token: 0x04029E04 RID: 171524
		[Token(Token = "0x4029E04")]
		private const float FADE_DURATION = 0.5f;

		// Token: 0x04029E05 RID: 171525
		[Token(Token = "0x4029E05")]
		private const float SCORE_SOUND_DELAY = 1.5f;

		// Token: 0x04029E06 RID: 171526
		[Token(Token = "0x4029E06")]
		private const float GP_VIEW_PROGRESS_DELAY = 0.83f;

		// Token: 0x04029E07 RID: 171527
		[Token(Token = "0x4029E07")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04029E08 RID: 171528
		[Token(Token = "0x4029E08")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeClassicEndingNormalScoreView.RoguelikeEndingScoreObjConfig _zoneScoreViewConfig;

		// Token: 0x04029E09 RID: 171529
		[Token(Token = "0x4029E09")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeClassicEndingNormalScoreView.RoguelikeEndingScoreObjConfig _stepScoreViewConfig;

		// Token: 0x04029E0A RID: 171530
		[Token(Token = "0x4029E0A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeClassicEndingNormalScoreView.RoguelikeEndingScoreObjConfig _battleScoreViewConfig;

		// Token: 0x04029E0B RID: 171531
		[Token(Token = "0x4029E0B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeClassicEndingNormalScoreView.RoguelikeEndingScoreObjConfig _charScoreViewConfig;

		// Token: 0x04029E0C RID: 171532
		[Token(Token = "0x4029E0C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeClassicEndingNormalScoreView.RoguelikeEndingScoreObjConfig _itemScoreViewConfig;

		// Token: 0x04029E0D RID: 171533
		[Token(Token = "0x4029E0D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RoguelikeClassicEndingNormalScoreView.RoguelikeEndingScoreObjConfig _bossScoreViewConfig;

		// Token: 0x04029E0E RID: 171534
		[Token(Token = "0x4029E0E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RoguelikeClassicEndingNormalScoreView.RoguelikeEndingScoreObjConfig _eliteScoreViewConfig;

		// Token: 0x04029E0F RID: 171535
		[Token(Token = "0x4029E0F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _imgModeGrow;

		// Token: 0x04029E10 RID: 171536
		[Token(Token = "0x4029E10")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _imgModeBkg;

		// Token: 0x04029E11 RID: 171537
		[Token(Token = "0x4029E11")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textModeName;

		// Token: 0x04029E12 RID: 171538
		[Token(Token = "0x4029E12")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textGrade;

		// Token: 0x04029E13 RID: 171539
		[Token(Token = "0x4029E13")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textFactor;

		// Token: 0x04029E14 RID: 171540
		[Token(Token = "0x4029E14")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textTotalScore;

		// Token: 0x04029E15 RID: 171541
		[Token(Token = "0x4029E15")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04029E16 RID: 171542
		[Token(Token = "0x4029E16")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _bpViewContainer;

		// Token: 0x04029E17 RID: 171543
		[Token(Token = "0x4029E17")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RoguelikeTopicEndingAddBPView _bpView;

		// Token: 0x04029E18 RID: 171544
		[Token(Token = "0x4029E18")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RoguelikeClassicEndingNormalScoreGpView _gpView;

		// Token: 0x04029E19 RID: 171545
		[Token(Token = "0x4029E19")]
		[FieldOffset(Offset = "0xA8")]
		private List<RoguelikeEndingScoreObjView> m_scoreViewList;

		// Token: 0x04029E1A RID: 171546
		[Token(Token = "0x4029E1A")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasAnimPlayed;

		// Token: 0x04029E1B RID: 171547
		[Token(Token = "0x4029E1B")]
		[FieldOffset(Offset = "0xB8")]
		private FadeSwitchTween m_displayTween;

		// Token: 0x04029E1C RID: 171548
		[Token(Token = "0x4029E1C")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_inited;

		// Token: 0x04029E1D RID: 171549
		[Token(Token = "0x4029E1D")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_cacheTween;

		// Token: 0x04029E1E RID: 171550
		[Token(Token = "0x4029E1E")]
		[FieldOffset(Offset = "0xD0")]
		private RoguelikeTopicEndingAddBPView m_bpView;

		// Token: 0x04029E1F RID: 171551
		[Token(Token = "0x4029E1F")]
		[FieldOffset(Offset = "0xD8")]
		private WeakReference m_renderCoroutineRef;

		// Token: 0x04029E20 RID: 171552
		[Token(Token = "0x4029E20")]
		[FieldOffset(Offset = "0xE0")]
		private Action m_backAction;

		// Token: 0x04029E21 RID: 171553
		[Token(Token = "0x4029E21")]
		[FieldOffset(Offset = "0xE8")]
		private Action m_confirmAction;

		// Token: 0x04029E22 RID: 171554
		[Token(Token = "0x4029E22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x04029E23 RID: 171555
		[Token(Token = "0x4029E23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onForward;

		// Token: 0x04029E24 RID: 171556
		[Token(Token = "0x4029E24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onBack;

		// Token: 0x04029E25 RID: 171557
		[Token(Token = "0x4029E25")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onConfirm;

		// Token: 0x04029E26 RID: 171558
		[Token(Token = "0x4029E26")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029E27 RID: 171559
		[Token(Token = "0x4029E27")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029E28 RID: 171560
		[Token(Token = "0x4029E28")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearCacheTween;

		// Token: 0x04029E29 RID: 171561
		[Token(Token = "0x4029E29")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ApplyInAnim;

		// Token: 0x04029E2A RID: 171562
		[Token(Token = "0x4029E2A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplyOutAnim;

		// Token: 0x04029E2B RID: 171563
		[Token(Token = "0x4029E2B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x04029E2C RID: 171564
		[Token(Token = "0x4029E2C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x04029E2D RID: 171565
		[Token(Token = "0x4029E2D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005299 RID: 21145
		[Token(Token = "0x2005299")]
		[Serializable]
		private class RoguelikeEndingScoreObjConfig
		{
			// Token: 0x0601F331 RID: 127793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F331")]
			[Address(RVA = "0x18EA820", Offset = "0x18E9420", VA = "0x1818EA820")]
			public RoguelikeEndingScoreObjView Create()
			{
				return null;
			}

			// Token: 0x0601F332 RID: 127794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F332")]
			[Address(RVA = "0x18EA920", Offset = "0x18E9520", VA = "0x1818EA920")]
			public void Render(int count, int score)
			{
			}

			// Token: 0x0601F333 RID: 127795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F333")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoguelikeEndingScoreObjConfig()
			{
			}

			// Token: 0x04029E2E RID: 171566
			[Token(Token = "0x4029E2E")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public RoguelikeEndingScoreObjView _viewPrefab;

			// Token: 0x04029E2F RID: 171567
			[Token(Token = "0x4029E2F")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public RectTransform _viewHolder;

			// Token: 0x04029E30 RID: 171568
			[Token(Token = "0x4029E30")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeEndingScoreObjView m_inst;
		}
	}
}
