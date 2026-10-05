using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062C8 RID: 25288
	[Token(Token = "0x20062C8")]
	public class AutoChessModeChoicePopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060246F9 RID: 149241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246F9")]
		[Address(RVA = "0x1F42120", Offset = "0x1F40D20", VA = "0x181F42120")]
		public void Render(AutoChessModeChoiceViewModel viewModel, bool needFocus)
		{
		}

		// Token: 0x060246FA RID: 149242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246FA")]
		[Address(RVA = "0x1F42020", Offset = "0x1F40C20", VA = "0x181F42020")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x060246FB RID: 149243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246FB")]
		[Address(RVA = "0x1F42920", Offset = "0x1F41520", VA = "0x181F42920")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060246FC RID: 149244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246FC")]
		[Address(RVA = "0x1F42D40", Offset = "0x1F41940", VA = "0x181F42D40")]
		private void _RenderConfirmBtnPart(AutoChessModeChoiceConfirmBtnType confirmBtnType)
		{
		}

		// Token: 0x060246FD RID: 149245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246FD")]
		[Address(RVA = "0x1F42ED0", Offset = "0x1F41AD0", VA = "0x181F42ED0")]
		private void _RenderMatchRangePart(AutoChessModeChoiceViewModel viewModel, bool isFastMode)
		{
		}

		// Token: 0x060246FE RID: 149246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246FE")]
		[Address(RVA = "0x1F42E00", Offset = "0x1F41A00", VA = "0x181F42E00")]
		private void _RenderMatchFlagPart(bool matchFlag, bool isFastMode)
		{
		}

		// Token: 0x060246FF RID: 149247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246FF")]
		[Address(RVA = "0x1F43100", Offset = "0x1F41D00", VA = "0x181F43100")]
		private void _TryConsumeModeTrackOnConfirm()
		{
		}

		// Token: 0x06024700 RID: 149248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024700")]
		[Address(RVA = "0x1F424D0", Offset = "0x1F410D0", VA = "0x181F424D0")]
		private void _FocusToSelectedMode()
		{
		}

		// Token: 0x06024701 RID: 149249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024701")]
		[Address(RVA = "0x1F41E60", Offset = "0x1F40A60", VA = "0x181F41E60")]
		public void EventOnConfirmBtnClick()
		{
		}

		// Token: 0x06024702 RID: 149250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024702")]
		[Address(RVA = "0x1F41F90", Offset = "0x1F40B90", VA = "0x181F41F90")]
		public void EventOnSwitchMatchRangeClick()
		{
		}

		// Token: 0x06024703 RID: 149251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024703")]
		[Address(RVA = "0x1F41F00", Offset = "0x1F40B00", VA = "0x181F41F00")]
		public void EventOnSwitchMatchFlagClick()
		{
		}

		// Token: 0x06024704 RID: 149252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024704")]
		[Address(RVA = "0x1F41DD0", Offset = "0x1F409D0", VA = "0x181F41DD0")]
		public void EventOnBlankClick()
		{
		}

		// Token: 0x06024705 RID: 149253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024705")]
		[Address(RVA = "0x1F432F0", Offset = "0x1F41EF0", VA = "0x181F432F0")]
		public AutoChessModeChoicePopView()
		{
		}

		// Token: 0x04032BA5 RID: 207781
		[Token(Token = "0x4032BA5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasLeftMaskBg;

		// Token: 0x04032BA6 RID: 207782
		[Token(Token = "0x4032BA6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _choiceItemContent;

		// Token: 0x04032BA7 RID: 207783
		[Token(Token = "0x4032BA7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objMatchRangePart;

		// Token: 0x04032BA8 RID: 207784
		[Token(Token = "0x4032BA8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objMatchRangePartTeam;

		// Token: 0x04032BA9 RID: 207785
		[Token(Token = "0x4032BA9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animMatchRangeSwitch;

		// Token: 0x04032BAA RID: 207786
		[Token(Token = "0x4032BAA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animMatchRangeSwitchTeam;

		// Token: 0x04032BAB RID: 207787
		[Token(Token = "0x4032BAB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _animMatchFlagSwitchTeam;

		// Token: 0x04032BAC RID: 207788
		[Token(Token = "0x4032BAC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objConfirmBtnTraining;

		// Token: 0x04032BAD RID: 207789
		[Token(Token = "0x4032BAD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objConfirmBtnSingle;

		// Token: 0x04032BAE RID: 207790
		[Token(Token = "0x4032BAE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objConfirmBtnMultiSolo;

		// Token: 0x04032BAF RID: 207791
		[Token(Token = "0x4032BAF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _objConfirmBtnMultiTeam;

		// Token: 0x04032BB0 RID: 207792
		[Token(Token = "0x4032BB0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x04032BB1 RID: 207793
		[Token(Token = "0x4032BB1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04032BB2 RID: 207794
		[Token(Token = "0x4032BB2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelModeContainer;

		// Token: 0x04032BB3 RID: 207795
		[Token(Token = "0x4032BB3")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelModeStartBtn;

		// Token: 0x04032BB4 RID: 207796
		[Token(Token = "0x4032BB4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Focus")]
		private VerticalLayoutGroup _layout;

		// Token: 0x04032BB5 RID: 207797
		[Token(Token = "0x4032BB5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Focus")]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x04032BB6 RID: 207798
		[Token(Token = "0x4032BB6")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Focus")]
		private float _itemHeight;

		// Token: 0x04032BB7 RID: 207799
		[Token(Token = "0x4032BB7")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Focus")]
		private UILayoutDimensionListener _listener;

		// Token: 0x04032BB8 RID: 207800
		[Token(Token = "0x4032BB8")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hasInited;

		// Token: 0x04032BB9 RID: 207801
		[Token(Token = "0x4032BB9")]
		[FieldOffset(Offset = "0xD8")]
		private AutoChessModeChoicePopView.Adapter m_choiceItemListAdapter;

		// Token: 0x04032BBA RID: 207802
		[Token(Token = "0x4032BBA")]
		[FieldOffset(Offset = "0xE0")]
		private AutoChessModeChoiceViewModel m_cachedViewModel;

		// Token: 0x04032BBB RID: 207803
		[Token(Token = "0x4032BBB")]
		[FieldOffset(Offset = "0xE8")]
		private AutoChessModeChoiceConfirmBtnType m_cachedConfirmBtnType;

		// Token: 0x04032BBC RID: 207804
		[Token(Token = "0x4032BBC")]
		[FieldOffset(Offset = "0xF0")]
		private AnimationSwitchTween m_matchRangeSwitchTween;

		// Token: 0x04032BBD RID: 207805
		[Token(Token = "0x4032BBD")]
		[FieldOffset(Offset = "0xF8")]
		private AnimationSwitchTween m_matchRangeSwitchTweenSolo;

		// Token: 0x04032BBE RID: 207806
		[Token(Token = "0x4032BBE")]
		[FieldOffset(Offset = "0x100")]
		private AnimationSwitchTween m_matchRangeSwitchTweenTeam;

		// Token: 0x04032BBF RID: 207807
		[Token(Token = "0x4032BBF")]
		[FieldOffset(Offset = "0x108")]
		private AnimationSwitchTween m_matchFlagSwitchTween;

		// Token: 0x04032BC0 RID: 207808
		[Token(Token = "0x4032BC0")]
		[FieldOffset(Offset = "0x110")]
		private AutoChessModeChoicePopView.ShowSwitchTween m_showSwitchTween;

		// Token: 0x04032BC1 RID: 207809
		[Token(Token = "0x4032BC1")]
		[FieldOffset(Offset = "0x118")]
		private FadeSwitchTween m_leftMaskSwitchTween;

		// Token: 0x04032BC2 RID: 207810
		[Token(Token = "0x4032BC2")]
		[FieldOffset(Offset = "0x120")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04032BC3 RID: 207811
		[Token(Token = "0x4032BC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032BC4 RID: 207812
		[Token(Token = "0x4032BC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x04032BC5 RID: 207813
		[Token(Token = "0x4032BC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032BC6 RID: 207814
		[Token(Token = "0x4032BC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderConfirmBtnPart;

		// Token: 0x04032BC7 RID: 207815
		[Token(Token = "0x4032BC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderMatchRangePart;

		// Token: 0x04032BC8 RID: 207816
		[Token(Token = "0x4032BC8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderMatchFlagPart;

		// Token: 0x04032BC9 RID: 207817
		[Token(Token = "0x4032BC9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryConsumeModeTrackOnConfirm;

		// Token: 0x04032BCA RID: 207818
		[Token(Token = "0x4032BCA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FocusToSelectedMode;

		// Token: 0x04032BCB RID: 207819
		[Token(Token = "0x4032BCB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBtnClick;

		// Token: 0x04032BCC RID: 207820
		[Token(Token = "0x4032BCC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnSwitchMatchRangeClick;

		// Token: 0x04032BCD RID: 207821
		[Token(Token = "0x4032BCD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnSwitchMatchFlagClick;

		// Token: 0x04032BCE RID: 207822
		[Token(Token = "0x4032BCE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnBlankClick;

		// Token: 0x04032BCF RID: 207823
		[Token(Token = "0x4032BCF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062C9 RID: 25289
		[Token(Token = "0x20062C9")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06024706 RID: 149254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024706")]
			[Address(RVA = "0x1F379A0", Offset = "0x1F365A0", VA = "0x181F379A0")]
			public Adapter(AutoChessModeChoicePopView closure)
			{
			}

			// Token: 0x170055BF RID: 21951
			// (get) Token: 0x06024707 RID: 149255 RVA: 0x000C4278 File Offset: 0x000C2478
			[Token(Token = "0x170055BF")]
			public override int count
			{
				[Token(Token = "0x6024707")]
				[Address(RVA = "0x1F37A20", Offset = "0x1F36620", VA = "0x181F37A20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024708 RID: 149256 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024708")]
			[Address(RVA = "0x1F37770", Offset = "0x1F36370", VA = "0x181F37770", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04032BD0 RID: 207824
			[Token(Token = "0x4032BD0")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessModeChoicePopView m_closure;

			// Token: 0x04032BD1 RID: 207825
			[Token(Token = "0x4032BD1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032BD2 RID: 207826
			[Token(Token = "0x4032BD2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04032BD3 RID: 207827
			[Token(Token = "0x4032BD3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020062CA RID: 25290
		[Token(Token = "0x20062CA")]
		private class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x06024709 RID: 149257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024709")]
			[Address(RVA = "0x1F501C0", Offset = "0x1F4EDC0", VA = "0x181F501C0")]
			public ShowSwitchTween(AutoChessModeChoicePopView closure)
			{
			}

			// Token: 0x0602470A RID: 149258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602470A")]
			[Address(RVA = "0x1F4FD60", Offset = "0x1F4E960", VA = "0x181F4FD60", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602470B RID: 149259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602470B")]
			[Address(RVA = "0x1F4FEE0", Offset = "0x1F4EAE0", VA = "0x181F4FEE0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602470C RID: 149260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602470C")]
			[Address(RVA = "0x1F50080", Offset = "0x1F4EC80", VA = "0x181F50080", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602470D RID: 149261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602470D")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04032BD4 RID: 207828
			[Token(Token = "0x4032BD4")]
			[FieldOffset(Offset = "0x48")]
			private AutoChessModeChoicePopView m_closure;

			// Token: 0x04032BD5 RID: 207829
			[Token(Token = "0x4032BD5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032BD6 RID: 207830
			[Token(Token = "0x4032BD6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04032BD7 RID: 207831
			[Token(Token = "0x4032BD7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04032BD8 RID: 207832
			[Token(Token = "0x4032BD8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
