using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056C4 RID: 22212
	[Token(Token = "0x20056C4")]
	public class RL04FragmentDetailView : DataBinder<RL04FragmentDetailProperty>, IHotfixable
	{
		// Token: 0x17004C54 RID: 19540
		// (get) Token: 0x06020936 RID: 133430 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020937 RID: 133431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C54")]
		public Action onNextBtnClicked
		{
			[Token(Token = "0x6020936")]
			[Address(RVA = "0x1AAEF80", Offset = "0x1AADB80", VA = "0x181AAEF80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020937")]
			[Address(RVA = "0x1AAF1A0", Offset = "0x1AADDA0", VA = "0x181AAF1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C55 RID: 19541
		// (get) Token: 0x06020938 RID: 133432 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020939 RID: 133433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C55")]
		public Action onPrevBtnClicked
		{
			[Token(Token = "0x6020938")]
			[Address(RVA = "0x1AAEFE0", Offset = "0x1AADBE0", VA = "0x181AAEFE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020939")]
			[Address(RVA = "0x1AAF220", Offset = "0x1AADE20", VA = "0x181AAF220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C56 RID: 19542
		// (get) Token: 0x0602093A RID: 133434 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602093B RID: 133435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C56")]
		public Action onUseBtnClicked
		{
			[Token(Token = "0x602093A")]
			[Address(RVA = "0x1AAF040", Offset = "0x1AADC40", VA = "0x181AAF040")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602093B")]
			[Address(RVA = "0x1AAF2A0", Offset = "0x1AADEA0", VA = "0x181AAF2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C57 RID: 19543
		// (get) Token: 0x0602093C RID: 133436 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602093D RID: 133437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C57")]
		public Action onDropBtnClicked
		{
			[Token(Token = "0x602093C")]
			[Address(RVA = "0x1AAEF20", Offset = "0x1AADB20", VA = "0x181AAEF20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602093D")]
			[Address(RVA = "0x1AAF120", Offset = "0x1AADD20", VA = "0x181AAF120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C58 RID: 19544
		// (get) Token: 0x0602093E RID: 133438 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602093F RID: 133439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C58")]
		public ILoadAsset loader
		{
			[Token(Token = "0x602093E")]
			[Address(RVA = "0x1AAEEC0", Offset = "0x1AADAC0", VA = "0x181AAEEC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602093F")]
			[Address(RVA = "0x1AAF0A0", Offset = "0x1AADCA0", VA = "0x181AAF0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020940 RID: 133440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020940")]
		[Address(RVA = "0x1AADE10", Offset = "0x1AACA10", VA = "0x181AADE10", Slot = "7")]
		public override void OnValueChanged(RL04FragmentDetailProperty property)
		{
		}

		// Token: 0x06020941 RID: 133441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020941")]
		[Address(RVA = "0x1AADAE0", Offset = "0x1AAC6E0", VA = "0x181AADAE0")]
		public void EventOnNextBtnClicked()
		{
		}

		// Token: 0x06020942 RID: 133442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020942")]
		[Address(RVA = "0x1AADBF0", Offset = "0x1AAC7F0", VA = "0x181AADBF0")]
		public void EventOnPrevBtnClicked()
		{
		}

		// Token: 0x06020943 RID: 133443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020943")]
		[Address(RVA = "0x1AADD00", Offset = "0x1AAC900", VA = "0x181AADD00")]
		public void EventOnUseBtnClicked()
		{
		}

		// Token: 0x06020944 RID: 133444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020944")]
		[Address(RVA = "0x1AAD9D0", Offset = "0x1AAC5D0", VA = "0x181AAD9D0")]
		public void EventOnDropBtnClicked()
		{
		}

		// Token: 0x06020945 RID: 133445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020945")]
		[Address(RVA = "0x1AAEAF0", Offset = "0x1AAD6F0", VA = "0x181AAEAF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020946 RID: 133446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020946")]
		[Address(RVA = "0x1AAE960", Offset = "0x1AAD560", VA = "0x181AAE960")]
		private void _GeneratePrevAnim()
		{
		}

		// Token: 0x06020947 RID: 133447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020947")]
		[Address(RVA = "0x1AAE7D0", Offset = "0x1AAD3D0", VA = "0x181AAE7D0")]
		private void _GenerateNextAnim()
		{
		}

		// Token: 0x06020948 RID: 133448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020948")]
		[Address(RVA = "0x1AAEDC0", Offset = "0x1AAD9C0", VA = "0x181AAEDC0")]
		private void _KillSwitchAnimIfNecessary()
		{
		}

		// Token: 0x06020949 RID: 133449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020949")]
		[Address(RVA = "0x1AAE680", Offset = "0x1AAD280", VA = "0x181AAE680")]
		private void _GenerateEnterAnim()
		{
		}

		// Token: 0x0602094A RID: 133450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602094A")]
		[Address(RVA = "0x1AAED30", Offset = "0x1AAD930", VA = "0x181AAED30")]
		private void _KillEnterAnimIfNecessary()
		{
		}

		// Token: 0x0602094B RID: 133451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602094B")]
		[Address(RVA = "0x1AAEE50", Offset = "0x1AADA50", VA = "0x181AAEE50")]
		public RL04FragmentDetailView()
		{
		}

		// Token: 0x0402C243 RID: 180803
		[Token(Token = "0x402C243")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animPrevHide;

		// Token: 0x0402C244 RID: 180804
		[Token(Token = "0x402C244")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animPrevShow;

		// Token: 0x0402C245 RID: 180805
		[Token(Token = "0x402C245")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animNextHide;

		// Token: 0x0402C246 RID: 180806
		[Token(Token = "0x402C246")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animNextShow;

		// Token: 0x0402C247 RID: 180807
		[Token(Token = "0x402C247")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0402C248 RID: 180808
		[Token(Token = "0x402C248")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RL04FragmentDetailCard _prefabDetailCard;

		// Token: 0x0402C249 RID: 180809
		[Token(Token = "0x402C249")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _cardContainer;

		// Token: 0x0402C24A RID: 180810
		[Token(Token = "0x402C24A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RL04FragmentDetailWeightView _weightView;

		// Token: 0x0402C24B RID: 180811
		[Token(Token = "0x402C24B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject[] _panelCanUse;

		// Token: 0x0402C24C RID: 180812
		[Token(Token = "0x402C24C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject[] _panelCheckOnly;

		// Token: 0x0402C24D RID: 180813
		[Token(Token = "0x402C24D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasGroupNextBtn;

		// Token: 0x0402C24E RID: 180814
		[Token(Token = "0x402C24E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _canvasGroupPrevBtn;

		// Token: 0x0402C24F RID: 180815
		[Token(Token = "0x402C24F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CanvasGroup _canvasGroupUseBtn;

		// Token: 0x0402C255 RID: 180821
		[Token(Token = "0x402C255")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_hasInited;

		// Token: 0x0402C256 RID: 180822
		[Token(Token = "0x402C256")]
		[FieldOffset(Offset = "0xE0")]
		private RL04FragmentDetailCard m_detailCard;

		// Token: 0x0402C257 RID: 180823
		[Token(Token = "0x402C257")]
		[FieldOffset(Offset = "0xE8")]
		private IRoguelikeFragmentItemModel m_cachedModel;

		// Token: 0x0402C258 RID: 180824
		[Token(Token = "0x402C258")]
		[FieldOffset(Offset = "0xF0")]
		private RL04FragmentDetailWeightViewModel m_cachedWeightModel;

		// Token: 0x0402C259 RID: 180825
		[Token(Token = "0x402C259")]
		[FieldOffset(Offset = "0xF8")]
		private int m_cachedLastIndex;

		// Token: 0x0402C25A RID: 180826
		[Token(Token = "0x402C25A")]
		[FieldOffset(Offset = "0x100")]
		private FadeSwitchTween m_nextBtnSwitchTween;

		// Token: 0x0402C25B RID: 180827
		[Token(Token = "0x402C25B")]
		[FieldOffset(Offset = "0x108")]
		private FadeSwitchTween m_prevBtnSwitchTween;

		// Token: 0x0402C25C RID: 180828
		[Token(Token = "0x402C25C")]
		[FieldOffset(Offset = "0x110")]
		private FadeSwitchTween m_useBtnSwitchTween;

		// Token: 0x0402C25D RID: 180829
		[Token(Token = "0x402C25D")]
		[FieldOffset(Offset = "0x118")]
		private Tween m_switchAnim;

		// Token: 0x0402C25E RID: 180830
		[Token(Token = "0x402C25E")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_enterAnim;

		// Token: 0x0402C25F RID: 180831
		[Token(Token = "0x402C25F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNextBtnClicked;

		// Token: 0x0402C260 RID: 180832
		[Token(Token = "0x402C260")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNextBtnClicked;

		// Token: 0x0402C261 RID: 180833
		[Token(Token = "0x402C261")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onPrevBtnClicked;

		// Token: 0x0402C262 RID: 180834
		[Token(Token = "0x402C262")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onPrevBtnClicked;

		// Token: 0x0402C263 RID: 180835
		[Token(Token = "0x402C263")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onUseBtnClicked;

		// Token: 0x0402C264 RID: 180836
		[Token(Token = "0x402C264")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onUseBtnClicked;

		// Token: 0x0402C265 RID: 180837
		[Token(Token = "0x402C265")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onDropBtnClicked;

		// Token: 0x0402C266 RID: 180838
		[Token(Token = "0x402C266")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onDropBtnClicked;

		// Token: 0x0402C267 RID: 180839
		[Token(Token = "0x402C267")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0402C268 RID: 180840
		[Token(Token = "0x402C268")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0402C269 RID: 180841
		[Token(Token = "0x402C269")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402C26A RID: 180842
		[Token(Token = "0x402C26A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClicked;

		// Token: 0x0402C26B RID: 180843
		[Token(Token = "0x402C26B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnPrevBtnClicked;

		// Token: 0x0402C26C RID: 180844
		[Token(Token = "0x402C26C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnUseBtnClicked;

		// Token: 0x0402C26D RID: 180845
		[Token(Token = "0x402C26D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnDropBtnClicked;

		// Token: 0x0402C26E RID: 180846
		[Token(Token = "0x402C26E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C26F RID: 180847
		[Token(Token = "0x402C26F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GeneratePrevAnim;

		// Token: 0x0402C270 RID: 180848
		[Token(Token = "0x402C270")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GenerateNextAnim;

		// Token: 0x0402C271 RID: 180849
		[Token(Token = "0x402C271")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__KillSwitchAnimIfNecessary;

		// Token: 0x0402C272 RID: 180850
		[Token(Token = "0x402C272")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GenerateEnterAnim;

		// Token: 0x0402C273 RID: 180851
		[Token(Token = "0x402C273")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__KillEnterAnimIfNecessary;

		// Token: 0x0402C274 RID: 180852
		[Token(Token = "0x402C274")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
