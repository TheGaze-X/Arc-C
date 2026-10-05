using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200567D RID: 22141
	[Token(Token = "0x200567D")]
	public class RL04AlchemyResultView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004C1F RID: 19487
		// (get) Token: 0x060207BB RID: 133051 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060207BC RID: 133052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C1F")]
		public RoguelikeRewardStyle rewardUiStyle
		{
			[Token(Token = "0x60207BB")]
			[Address(RVA = "0x1A9EE80", Offset = "0x1A9DA80", VA = "0x181A9EE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60207BC")]
			[Address(RVA = "0x1A9EEE0", Offset = "0x1A9DAE0", VA = "0x181A9EEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060207BD RID: 133053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207BD")]
		[Address(RVA = "0x1A9DA60", Offset = "0x1A9C660", VA = "0x181A9DA60")]
		public void Show(RL04AlchemyResultViewModel viewModel)
		{
		}

		// Token: 0x060207BE RID: 133054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207BE")]
		[Address(RVA = "0x1A9D800", Offset = "0x1A9C400", VA = "0x181A9D800")]
		public void Hide()
		{
		}

		// Token: 0x060207BF RID: 133055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207BF")]
		[Address(RVA = "0x1A9D860", Offset = "0x1A9C460", VA = "0x181A9D860")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x060207C0 RID: 133056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C0")]
		[Address(RVA = "0x1A9D960", Offset = "0x1A9C560", VA = "0x181A9D960")]
		public void OnOtherRewardItemClick(int index)
		{
		}

		// Token: 0x060207C1 RID: 133057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C1")]
		[Address(RVA = "0x1A9ECC0", Offset = "0x1A9D8C0", VA = "0x181A9ECC0")]
		private void _ShowView(bool show)
		{
		}

		// Token: 0x060207C2 RID: 133058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C2")]
		[Address(RVA = "0x1A9EB20", Offset = "0x1A9D720", VA = "0x181A9EB20")]
		private void _RenderTitle(RL04AlchemyResultViewModel.ResultState status, bool isMultiChoice)
		{
		}

		// Token: 0x060207C3 RID: 133059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C3")]
		[Address(RVA = "0x1A9E600", Offset = "0x1A9D200", VA = "0x181A9E600")]
		private void _RenderRewardData(RL04AlchemyResultViewModel viewModel)
		{
		}

		// Token: 0x060207C4 RID: 133060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C4")]
		[Address(RVA = "0x1A9E260", Offset = "0x1A9CE60", VA = "0x181A9E260")]
		private void _PlayAlchemyResultAudio(RL04AlchemyResultViewModel.ResultState resultState)
		{
		}

		// Token: 0x060207C5 RID: 133061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C5")]
		[Address(RVA = "0x1A9E3A0", Offset = "0x1A9CFA0", VA = "0x181A9E3A0")]
		private void _RenderOtherRewards(RoguelikeRewardListViewModel otherRewardListViewModel)
		{
		}

		// Token: 0x060207C6 RID: 133062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C6")]
		[Address(RVA = "0x1A9DF10", Offset = "0x1A9CB10", VA = "0x181A9DF10")]
		private void _InitOtherListLayout(string topicId)
		{
		}

		// Token: 0x060207C7 RID: 133063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C7")]
		[Address(RVA = "0x1A9E920", Offset = "0x1A9D520", VA = "0x181A9E920")]
		private void _RenderSsrRewards(List<RL04AlchemyResultSsrItemViewModel> ssrRewardListViewModel)
		{
		}

		// Token: 0x060207C8 RID: 133064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C8")]
		[Address(RVA = "0x1A9E0F0", Offset = "0x1A9CCF0", VA = "0x181A9E0F0")]
		private void _InitSsrListLayout()
		{
		}

		// Token: 0x060207C9 RID: 133065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207C9")]
		[Address(RVA = "0x1A9DE00", Offset = "0x1A9CA00", VA = "0x181A9DE00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060207CA RID: 133066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207CA")]
		[Address(RVA = "0x1A9EE20", Offset = "0x1A9DA20", VA = "0x181A9EE20")]
		public RL04AlchemyResultView()
		{
		}

		// Token: 0x0402C032 RID: 180274
		[Token(Token = "0x402C032")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Single Reward")]
		private GameObject _objRewardSingle;

		// Token: 0x0402C033 RID: 180275
		[Token(Token = "0x402C033")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Single Reward")]
		private RectTransform _backBtnForSingleReward;

		// Token: 0x0402C034 RID: 180276
		[Token(Token = "0x402C034")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Multi Choice Reward")]
		private GameObject _objRewardMultiChoice;

		// Token: 0x0402C035 RID: 180277
		[Token(Token = "0x402C035")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Ssr Rewards")]
		private GameObject _objSsrRewards;

		// Token: 0x0402C036 RID: 180278
		[Token(Token = "0x402C036")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Ssr Rewards")]
		private SimpleLayoutContent _ssrListContent;

		// Token: 0x0402C037 RID: 180279
		[Token(Token = "0x402C037")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Other Rewards")]
		private GameObject _objOtherRewards;

		// Token: 0x0402C038 RID: 180280
		[Token(Token = "0x402C038")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Other Rewards")]
		private RoguelikeRewardListLayout _otherListLayout;

		// Token: 0x0402C039 RID: 180281
		[Token(Token = "0x402C039")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Other Rewards")]
		private UIIntEvent _onOtherRewardItemClick;

		// Token: 0x0402C03A RID: 180282
		[Token(Token = "0x402C03A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0402C03B RID: 180283
		[Token(Token = "0x402C03B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402C03C RID: 180284
		[Token(Token = "0x402C03C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtTitle;

		// Token: 0x0402C03E RID: 180286
		[Token(Token = "0x402C03E")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402C03F RID: 180287
		[Token(Token = "0x402C03F")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402C040 RID: 180288
		[Token(Token = "0x402C040")]
		[FieldOffset(Offset = "0x98")]
		private bool m_cachedOtherListLayoutInited;

		// Token: 0x0402C041 RID: 180289
		[Token(Token = "0x402C041")]
		[FieldOffset(Offset = "0x99")]
		private bool m_cachedSsrListLayoutInited;

		// Token: 0x0402C042 RID: 180290
		[Token(Token = "0x402C042")]
		[FieldOffset(Offset = "0xA0")]
		private List<RL04AlchemyResultSsrItemViewModel> m_cachedSsrItemViewList;

		// Token: 0x0402C043 RID: 180291
		[Token(Token = "0x402C043")]
		[FieldOffset(Offset = "0xA8")]
		private RL04AlchemyResultView.SsrRewardsAdapter m_ssrRewardsAdapter;

		// Token: 0x0402C044 RID: 180292
		[Token(Token = "0x402C044")]
		[FieldOffset(Offset = "0xB0")]
		private RL04AlchemyResultView.ShowHideSwitchTween m_switchTween;

		// Token: 0x0402C045 RID: 180293
		[Token(Token = "0x402C045")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rewardUiStyle;

		// Token: 0x0402C046 RID: 180294
		[Token(Token = "0x402C046")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rewardUiStyle;

		// Token: 0x0402C047 RID: 180295
		[Token(Token = "0x402C047")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0402C048 RID: 180296
		[Token(Token = "0x402C048")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0402C049 RID: 180297
		[Token(Token = "0x402C049")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x0402C04A RID: 180298
		[Token(Token = "0x402C04A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnOtherRewardItemClick;

		// Token: 0x0402C04B RID: 180299
		[Token(Token = "0x402C04B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowView;

		// Token: 0x0402C04C RID: 180300
		[Token(Token = "0x402C04C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderTitle;

		// Token: 0x0402C04D RID: 180301
		[Token(Token = "0x402C04D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderRewardData;

		// Token: 0x0402C04E RID: 180302
		[Token(Token = "0x402C04E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayAlchemyResultAudio;

		// Token: 0x0402C04F RID: 180303
		[Token(Token = "0x402C04F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderOtherRewards;

		// Token: 0x0402C050 RID: 180304
		[Token(Token = "0x402C050")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitOtherListLayout;

		// Token: 0x0402C051 RID: 180305
		[Token(Token = "0x402C051")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderSsrRewards;

		// Token: 0x0402C052 RID: 180306
		[Token(Token = "0x402C052")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitSsrListLayout;

		// Token: 0x0402C053 RID: 180307
		[Token(Token = "0x402C053")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C054 RID: 180308
		[Token(Token = "0x402C054")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200567E RID: 22142
		[Token(Token = "0x200567E")]
		private class SsrRewardsAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060207CB RID: 133067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207CB")]
			[Address(RVA = "0x1AA27C0", Offset = "0x1AA13C0", VA = "0x181AA27C0")]
			public SsrRewardsAdapter(RL04AlchemyResultView closure)
			{
			}

			// Token: 0x17004C20 RID: 19488
			// (get) Token: 0x060207CC RID: 133068 RVA: 0x000B6238 File Offset: 0x000B4438
			[Token(Token = "0x17004C20")]
			public override int count
			{
				[Token(Token = "0x60207CC")]
				[Address(RVA = "0x1AA2840", Offset = "0x1AA1440", VA = "0x181AA2840", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060207CD RID: 133069 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60207CD")]
			[Address(RVA = "0x1AA2610", Offset = "0x1AA1210", VA = "0x181AA2610", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C055 RID: 180309
			[Token(Token = "0x402C055")]
			[FieldOffset(Offset = "0x20")]
			private RL04AlchemyResultView m_closure;

			// Token: 0x0402C056 RID: 180310
			[Token(Token = "0x402C056")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C057 RID: 180311
			[Token(Token = "0x402C057")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C058 RID: 180312
			[Token(Token = "0x402C058")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200567F RID: 22143
		[Token(Token = "0x200567F")]
		private class ShowHideSwitchTween : UISwitchTween
		{
			// Token: 0x060207CE RID: 133070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207CE")]
			[Address(RVA = "0x1AA2190", Offset = "0x1AA0D90", VA = "0x181AA2190")]
			public ShowHideSwitchTween(RL04AlchemyResultView closure)
			{
			}

			// Token: 0x060207CF RID: 133071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60207CF")]
			[Address(RVA = "0x1AA1E80", Offset = "0x1AA0A80", VA = "0x181AA1E80", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060207D0 RID: 133072 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60207D0")]
			[Address(RVA = "0x1AA1D60", Offset = "0x1AA0960", VA = "0x181AA1D60", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060207D1 RID: 133073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207D1")]
			[Address(RVA = "0x1AA1CE0", Offset = "0x1AA08E0", VA = "0x181AA1CE0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x060207D2 RID: 133074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207D2")]
			[Address(RVA = "0x1AA1C60", Offset = "0x1AA0860", VA = "0x181AA1C60", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x060207D3 RID: 133075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207D3")]
			[Address(RVA = "0x1AA20C0", Offset = "0x1AA0CC0", VA = "0x181AA20C0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060207D4 RID: 133076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207D4")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x060207D5 RID: 133077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207D5")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x060207D6 RID: 133078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207D6")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402C059 RID: 180313
			[Token(Token = "0x402C059")]
			[FieldOffset(Offset = "0x48")]
			private RL04AlchemyResultView m_closure;

			// Token: 0x0402C05A RID: 180314
			[Token(Token = "0x402C05A")]
			private const float ANIM_DURATION = 0.16f;

			// Token: 0x0402C05B RID: 180315
			[Token(Token = "0x402C05B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C05C RID: 180316
			[Token(Token = "0x402C05C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402C05D RID: 180317
			[Token(Token = "0x402C05D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402C05E RID: 180318
			[Token(Token = "0x402C05E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402C05F RID: 180319
			[Token(Token = "0x402C05F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0402C060 RID: 180320
			[Token(Token = "0x402C060")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
