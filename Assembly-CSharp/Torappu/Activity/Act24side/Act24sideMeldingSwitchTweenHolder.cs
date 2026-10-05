using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075AF RID: 30127
	[Token(Token = "0x20075AF")]
	public class Act24sideMeldingSwitchTweenHolder : Act24sideMeldingSwitchTweenAbstractHolder
	{
		// Token: 0x0602A65D RID: 173661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A65D")]
		[Address(RVA = "0x2611320", Offset = "0x260FF20", VA = "0x182611320")]
		private void _SetQuickInputBlockShow(bool show)
		{
		}

		// Token: 0x0602A65E RID: 173662 RVA: 0x000D83D8 File Offset: 0x000D65D8
		[Token(Token = "0x602A65E")]
		[Address(RVA = "0x26111D0", Offset = "0x260FDD0", VA = "0x1826111D0")]
		private bool _IsInputProgressTweening()
		{
			return default(bool);
		}

		// Token: 0x0602A65F RID: 173663 RVA: 0x000D83F0 File Offset: 0x000D65F0
		[Token(Token = "0x602A65F")]
		[Address(RVA = "0x26112A0", Offset = "0x260FEA0", VA = "0x1826112A0")]
		private bool _IsSwitchBoxTweening()
		{
			return default(bool);
		}

		// Token: 0x0602A660 RID: 173664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A660")]
		[Address(RVA = "0x2610AD0", Offset = "0x260F6D0", VA = "0x182610AD0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0602A661 RID: 173665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A661")]
		[Address(RVA = "0x2610EC0", Offset = "0x260FAC0", VA = "0x182610EC0", Slot = "5")]
		public override void RefreshData(Act24sideMeldingViewModel model)
		{
		}

		// Token: 0x0602A662 RID: 173666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A662")]
		[Address(RVA = "0x26110D0", Offset = "0x260FCD0", VA = "0x1826110D0", Slot = "6")]
		public override void TryPauseInputProgressTweening()
		{
		}

		// Token: 0x0602A663 RID: 173667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A663")]
		[Address(RVA = "0x2611150", Offset = "0x260FD50", VA = "0x182611150", Slot = "7")]
		public override void TryQuickInputMeldings()
		{
		}

		// Token: 0x0602A664 RID: 173668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A664")]
		[Address(RVA = "0x2610F40", Offset = "0x260FB40", VA = "0x182610F40", Slot = "8")]
		public override void ResetGachaBoxTween(bool isShow)
		{
		}

		// Token: 0x0602A665 RID: 173669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A665")]
		[Address(RVA = "0x2611040", Offset = "0x260FC40", VA = "0x182611040", Slot = "11")]
		public override void SetGachaBoxTween(bool isShow)
		{
		}

		// Token: 0x0602A666 RID: 173670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A666")]
		[Address(RVA = "0x2610FD0", Offset = "0x260FBD0", VA = "0x182610FD0", Slot = "9")]
		public override void ResetProgressTween()
		{
		}

		// Token: 0x0602A667 RID: 173671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A667")]
		[Address(RVA = "0x2610E50", Offset = "0x260FA50", VA = "0x182610E50", Slot = "10")]
		public override void PlayProgressTween()
		{
		}

		// Token: 0x0602A668 RID: 173672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A668")]
		[Address(RVA = "0x26113A0", Offset = "0x260FFA0", VA = "0x1826113A0")]
		public Act24sideMeldingSwitchTweenHolder()
		{
		}

		// Token: 0x0403D01B RID: 249883
		[Token(Token = "0x403D01B")]
		private const float SWITCH_GACHA_ANIM_DURATION = 0.5f;

		// Token: 0x0403D01C RID: 249884
		[Token(Token = "0x403D01C")]
		private const float SLOT_LIGHT_UP_ANIM_DURATION = 0.83f;

		// Token: 0x0403D01D RID: 249885
		[Token(Token = "0x403D01D")]
		private const float SLOT_SWITCH_ANIM_DURATION = 2f;

		// Token: 0x0403D01E RID: 249886
		[Token(Token = "0x403D01E")]
		private const float TOTEM_SHOW_START_TIME = 0.5f;

		// Token: 0x0403D01F RID: 249887
		[Token(Token = "0x403D01F")]
		private const float TOTEM_SHOW_DURATION = 1f;

		// Token: 0x0403D020 RID: 249888
		[Token(Token = "0x403D020")]
		private const float TOTEM_HIDE_DURATION = 1f;

		// Token: 0x0403D021 RID: 249889
		[Token(Token = "0x403D021")]
		private const string TOTEM_MAT_AMOUNT_NAME = "_Amount";

		// Token: 0x0403D022 RID: 249890
		[Token(Token = "0x403D022")]
		private const float TOTEM_SHOW_AMOUNT = 0f;

		// Token: 0x0403D023 RID: 249891
		[Token(Token = "0x403D023")]
		private const float TOTEM_HIDE_AMOUNT = 1.1f;

		// Token: 0x0403D024 RID: 249892
		[Token(Token = "0x403D024")]
		private const string FORMAT_MELDING_COUNT = "{0}/{1}";

		// Token: 0x0403D025 RID: 249893
		[Token(Token = "0x403D025")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIAnimationLocation> _slotLightItemAnimList;

		// Token: 0x0403D026 RID: 249894
		[Token(Token = "0x403D026")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _gachaBoxSwitchAnim;

		// Token: 0x0403D027 RID: 249895
		[Token(Token = "0x403D027")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _slotSwitchAnim;

		// Token: 0x0403D028 RID: 249896
		[Token(Token = "0x403D028")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgTotum1;

		// Token: 0x0403D029 RID: 249897
		[Token(Token = "0x403D029")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgTotum2;

		// Token: 0x0403D02A RID: 249898
		[Token(Token = "0x403D02A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtMeldingProgress;

		// Token: 0x0403D02B RID: 249899
		[Token(Token = "0x403D02B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _sliderInputMeldingProgress;

		// Token: 0x0403D02C RID: 249900
		[Token(Token = "0x403D02C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Slider _sliderSlot;

		// Token: 0x0403D02D RID: 249901
		[Token(Token = "0x403D02D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objBlockerQuickInput;

		// Token: 0x0403D02E RID: 249902
		[Token(Token = "0x403D02E")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween.TweenWrapper m_gachaBoxSwitchTween;

		// Token: 0x0403D02F RID: 249903
		[Token(Token = "0x403D02F")]
		[FieldOffset(Offset = "0x78")]
		private Act24sideMeldingSwitchTweenHolder.MeldingProgressSwitchTween m_meldingInputProgressTween;

		// Token: 0x0403D030 RID: 249904
		[Token(Token = "0x403D030")]
		[FieldOffset(Offset = "0x80")]
		private Act24sideMeldingSwitchTweenHolder.GachaBoxSwitchTween m_switchBoxTween;

		// Token: 0x0403D031 RID: 249905
		[Token(Token = "0x403D031")]
		[FieldOffset(Offset = "0x88")]
		private Material m_matTotum1;

		// Token: 0x0403D032 RID: 249906
		[Token(Token = "0x403D032")]
		[FieldOffset(Offset = "0x90")]
		private Material m_matTotum2;

		// Token: 0x0403D033 RID: 249907
		[Token(Token = "0x403D033")]
		[FieldOffset(Offset = "0x98")]
		private UISwitchTween.TweenWrapper m_progressTween;

		// Token: 0x0403D034 RID: 249908
		[Token(Token = "0x403D034")]
		[FieldOffset(Offset = "0xA0")]
		private Act24sideMeldingViewModel m_model;

		// Token: 0x0403D035 RID: 249909
		[Token(Token = "0x403D035")]
		[FieldOffset(Offset = "0xA8")]
		private List<UISwitchTween.TweenWrapper> m_progressSlotLightTweenList;

		// Token: 0x0403D036 RID: 249910
		[Token(Token = "0x403D036")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetQuickInputBlockShow;

		// Token: 0x0403D037 RID: 249911
		[Token(Token = "0x403D037")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IsInputProgressTweening;

		// Token: 0x0403D038 RID: 249912
		[Token(Token = "0x403D038")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__IsSwitchBoxTweening;

		// Token: 0x0403D039 RID: 249913
		[Token(Token = "0x403D039")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403D03A RID: 249914
		[Token(Token = "0x403D03A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403D03B RID: 249915
		[Token(Token = "0x403D03B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryPauseInputProgressTweening;

		// Token: 0x0403D03C RID: 249916
		[Token(Token = "0x403D03C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryQuickInputMeldings;

		// Token: 0x0403D03D RID: 249917
		[Token(Token = "0x403D03D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetGachaBoxTween;

		// Token: 0x0403D03E RID: 249918
		[Token(Token = "0x403D03E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetGachaBoxTween;

		// Token: 0x0403D03F RID: 249919
		[Token(Token = "0x403D03F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ResetProgressTween;

		// Token: 0x0403D040 RID: 249920
		[Token(Token = "0x403D040")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PlayProgressTween;

		// Token: 0x0403D041 RID: 249921
		[Token(Token = "0x403D041")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075B0 RID: 30128
		[Token(Token = "0x20075B0")]
		private class GachaBoxSwitchTween : UISwitchTween
		{
			// Token: 0x0602A669 RID: 173673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A669")]
			[Address(RVA = "0x261C3A0", Offset = "0x261AFA0", VA = "0x18261C3A0")]
			public GachaBoxSwitchTween(Act24sideMeldingSwitchTweenHolder itemView)
			{
			}

			// Token: 0x0602A66A RID: 173674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A66A")]
			[Address(RVA = "0x261B5C0", Offset = "0x261A1C0", VA = "0x18261B5C0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602A66B RID: 173675 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A66B")]
			[Address(RVA = "0x261BA10", Offset = "0x261A610", VA = "0x18261BA10", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602A66C RID: 173676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A66C")]
			[Address(RVA = "0x261BE60", Offset = "0x261AA60", VA = "0x18261BE60", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602A66D RID: 173677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A66D")]
			[Address(RVA = "0x261C2A0", Offset = "0x261AEA0", VA = "0x18261C2A0")]
			private void _ResetTotem(bool isSecond)
			{
			}

			// Token: 0x0602A66E RID: 173678 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A66E")]
			[Address(RVA = "0x261C0E0", Offset = "0x261ACE0", VA = "0x18261C0E0")]
			private Tweener _GetTotemTween(Material mat, bool isShow)
			{
				return null;
			}

			// Token: 0x0602A66F RID: 173679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A66F")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403D042 RID: 249922
			[Token(Token = "0x403D042")]
			[FieldOffset(Offset = "0x48")]
			private Act24sideMeldingSwitchTweenHolder m_closure;

			// Token: 0x0403D043 RID: 249923
			[Token(Token = "0x403D043")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D044 RID: 249924
			[Token(Token = "0x403D044")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403D045 RID: 249925
			[Token(Token = "0x403D045")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403D046 RID: 249926
			[Token(Token = "0x403D046")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0403D047 RID: 249927
			[Token(Token = "0x403D047")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__ResetTotem;

			// Token: 0x0403D048 RID: 249928
			[Token(Token = "0x403D048")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__GetTotemTween;
		}

		// Token: 0x020075B3 RID: 30131
		[Token(Token = "0x20075B3")]
		private class MeldingProgressSwitchTween : IHotfixable
		{
			// Token: 0x0602A677 RID: 173687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A677")]
			[Address(RVA = "0x261DA90", Offset = "0x261C690", VA = "0x18261DA90")]
			public MeldingProgressSwitchTween(Act24sideMeldingSwitchTweenHolder itemView)
			{
			}

			// Token: 0x170063BD RID: 25533
			// (get) Token: 0x0602A678 RID: 173688 RVA: 0x000D8420 File Offset: 0x000D6620
			[Token(Token = "0x170063BD")]
			public bool isTweening
			{
				[Token(Token = "0x602A678")]
				[Address(RVA = "0x261DB10", Offset = "0x261C710", VA = "0x18261DB10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602A679 RID: 173689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A679")]
			[Address(RVA = "0x261C8B0", Offset = "0x261B4B0", VA = "0x18261C8B0")]
			public void KillIfNecessary()
			{
			}

			// Token: 0x0602A67A RID: 173690 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A67A")]
			[Address(RVA = "0x261C940", Offset = "0x261B540", VA = "0x18261C940")]
			public void ResetDirectly()
			{
			}

			// Token: 0x0602A67B RID: 173691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A67B")]
			[Address(RVA = "0x261CDB0", Offset = "0x261B9B0", VA = "0x18261CDB0")]
			public void TweenProgress()
			{
			}

			// Token: 0x0602A67C RID: 173692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A67C")]
			[Address(RVA = "0x261D940", Offset = "0x261C540", VA = "0x18261D940")]
			private void _ResetSlotSlider()
			{
			}

			// Token: 0x0602A67D RID: 173693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A67D")]
			[Address(RVA = "0x261D700", Offset = "0x261C300", VA = "0x18261D700")]
			private void _ResetSlotLightTweens()
			{
			}

			// Token: 0x0602A67E RID: 173694 RVA: 0x000D8438 File Offset: 0x000D6638
			[Token(Token = "0x602A67E")]
			[Address(RVA = "0x261D600", Offset = "0x261C200", VA = "0x18261D600")]
			private bool _NeedAdjustInputProgress(List<Act24sideMeldingProgressChangeInfo> changeInfoList)
			{
				return default(bool);
			}

			// Token: 0x0403D04D RID: 249933
			[Token(Token = "0x403D04D")]
			[FieldOffset(Offset = "0x10")]
			private Act24sideMeldingSwitchTweenHolder m_closure;

			// Token: 0x0403D04E RID: 249934
			[Token(Token = "0x403D04E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D04F RID: 249935
			[Token(Token = "0x403D04F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isTweening;

			// Token: 0x0403D050 RID: 249936
			[Token(Token = "0x403D050")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_KillIfNecessary;

			// Token: 0x0403D051 RID: 249937
			[Token(Token = "0x403D051")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetDirectly;

			// Token: 0x0403D052 RID: 249938
			[Token(Token = "0x403D052")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_TweenProgress;

			// Token: 0x0403D053 RID: 249939
			[Token(Token = "0x403D053")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__ResetSlotSlider;

			// Token: 0x0403D054 RID: 249940
			[Token(Token = "0x403D054")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__ResetSlotLightTweens;

			// Token: 0x0403D055 RID: 249941
			[Token(Token = "0x403D055")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__NeedAdjustInputProgress;
		}
	}
}
