using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F5E RID: 24414
	[Token(Token = "0x2005F5E")]
	public class CharacterLvlupHomeView : DataBinder<CharacterLvlupViewProperty>
	{
		// Token: 0x06023596 RID: 144790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023596")]
		[Address(RVA = "0x1DDCF50", Offset = "0x1DDBB50", VA = "0x181DDCF50", Slot = "7")]
		public override void OnValueChanged(CharacterLvlupViewProperty property)
		{
		}

		// Token: 0x06023597 RID: 144791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023597")]
		[Address(RVA = "0x1DDDA00", Offset = "0x1DDC600", VA = "0x181DDDA00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023598 RID: 144792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023598")]
		[Address(RVA = "0x1DDDE30", Offset = "0x1DDCA30", VA = "0x181DDDE30")]
		private void _OnModifyingCardNum(int index, int deltaNum)
		{
		}

		// Token: 0x06023599 RID: 144793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023599")]
		[Address(RVA = "0x1DDDED0", Offset = "0x1DDCAD0", VA = "0x181DDDED0")]
		private void _OnMoveToMaxValidLevel()
		{
		}

		// Token: 0x0602359A RID: 144794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602359A")]
		[Address(RVA = "0x1DDDF40", Offset = "0x1DDCB40", VA = "0x181DDDF40")]
		private void _OnWheelBeginDrag()
		{
		}

		// Token: 0x0602359B RID: 144795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602359B")]
		[Address(RVA = "0x1DDDFB0", Offset = "0x1DDCBB0", VA = "0x181DDDFB0")]
		private void _OnWheelItemClicked(int pageIndex)
		{
		}

		// Token: 0x0602359C RID: 144796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602359C")]
		[Address(RVA = "0x1DDE030", Offset = "0x1DDCC30", VA = "0x181DDE030")]
		private void _OnWheelScrollEnd(int index)
		{
		}

		// Token: 0x0602359D RID: 144797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602359D")]
		[Address(RVA = "0x1DDE0B0", Offset = "0x1DDCCB0", VA = "0x181DDE0B0")]
		private void _TryToFadeForCanvasGroup(CanvasGroup canvasGroup, bool isShow)
		{
		}

		// Token: 0x0602359E RID: 144798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602359E")]
		[Address(RVA = "0x1DDD7D0", Offset = "0x1DDC3D0", VA = "0x181DDD7D0")]
		private string _GeneLackExpStr(CharacterLvlupViewModel viewModel, int lackExp)
		{
			return null;
		}

		// Token: 0x0602359F RID: 144799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602359F")]
		[Address(RVA = "0x1DDD930", Offset = "0x1DDC530", VA = "0x181DDD930")]
		private string _GeneLackGoldStr(long lackGold)
		{
			return null;
		}

		// Token: 0x060235A0 RID: 144800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235A0")]
		[Address(RVA = "0x1DDE200", Offset = "0x1DDCE00", VA = "0x181DDE200")]
		public CharacterLvlupHomeView()
		{
		}

		// Token: 0x04030C9D RID: 199837
		[Token(Token = "0x4030C9D")]
		private const float FADE_DURATION = 0.15f;

		// Token: 0x04030C9E RID: 199838
		[Token(Token = "0x4030C9E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgCampLogo;

		// Token: 0x04030C9F RID: 199839
		[Token(Token = "0x4030C9F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterLvlupAttrAndExpInfoView _attrAndExpInfoView;

		// Token: 0x04030CA0 RID: 199840
		[Token(Token = "0x4030CA0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterLvlupItemCollectionView _itemCollectionView;

		// Token: 0x04030CA1 RID: 199841
		[Token(Token = "0x4030CA1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Lack Panel")]
		private GameObject _panelLackExp;

		// Token: 0x04030CA2 RID: 199842
		[Token(Token = "0x4030CA2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Lack Panel")]
		private GameObject _panelLackGold;

		// Token: 0x04030CA3 RID: 199843
		[Token(Token = "0x4030CA3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Lack Panel")]
		private Text _txtLackExp;

		// Token: 0x04030CA4 RID: 199844
		[Token(Token = "0x4030CA4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Lack Panel")]
		private Text _txtLackGold;

		// Token: 0x04030CA5 RID: 199845
		[Token(Token = "0x4030CA5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Scroll Panel")]
		private CharacterLvlupWheelPickerView _wheelPickerView;

		// Token: 0x04030CA6 RID: 199846
		[Token(Token = "0x4030CA6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Scroll Panel")]
		private GameObject _panelScrollTips;

		// Token: 0x04030CA7 RID: 199847
		[Token(Token = "0x4030CA7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Scroll Panel")]
		private GameObject _panelScrollLevelNormal;

		// Token: 0x04030CA8 RID: 199848
		[Token(Token = "0x4030CA8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Scroll Panel")]
		private GameObject _panelScrollLevelCounting;

		// Token: 0x04030CA9 RID: 199849
		[Token(Token = "0x4030CA9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Scroll Panel")]
		private RectTransform _rectTransformScrollTargetTag;

		// Token: 0x04030CAA RID: 199850
		[Token(Token = "0x4030CAA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Scroll Panel")]
		private CharacterLvlupExpCircleView _expCircleView;

		// Token: 0x04030CAB RID: 199851
		[Token(Token = "0x4030CAB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Scroll Panel")]
		private CanvasGroup _canvasGroupScrollReset;

		// Token: 0x04030CAC RID: 199852
		[Token(Token = "0x4030CAC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Scroll Panel")]
		private CanvasGroup _canvasGroupScrollBtn;

		// Token: 0x04030CAD RID: 199853
		[Token(Token = "0x4030CAD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Scroll Panel")]
		private RectTransform _rectTransformScrollBtn;

		// Token: 0x04030CAE RID: 199854
		[Token(Token = "0x4030CAE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Scroll Panel")]
		private GameObject _panelScrollConfirmInvalid;

		// Token: 0x04030CAF RID: 199855
		[Token(Token = "0x4030CAF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Scroll Panel")]
		private CanvasGroup _canvasGroupScrollCounting;

		// Token: 0x04030CB0 RID: 199856
		[Token(Token = "0x4030CB0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Scroll Panel")]
		private RectTransform _rectTransformScrollCounting;

		// Token: 0x04030CB1 RID: 199857
		[Token(Token = "0x4030CB1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CharacterLvlupLevelAnchorView _levelAnchorView;

		// Token: 0x04030CB2 RID: 199858
		[Token(Token = "0x4030CB2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CanvasGroup _canvasGroupBtnClear;

		// Token: 0x04030CB3 RID: 199859
		[Token(Token = "0x4030CB3")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CanvasGroup _canvasGroupBtnUpgrade;

		// Token: 0x04030CB4 RID: 199860
		[Token(Token = "0x4030CB4")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform _rectTransformBtnUpgrade;

		// Token: 0x04030CB5 RID: 199861
		[Token(Token = "0x4030CB5")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _panelUpgradeInvalid;

		// Token: 0x04030CB6 RID: 199862
		[Token(Token = "0x4030CB6")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CanvasGroup _canvasGroupWasteTips;

		// Token: 0x04030CB7 RID: 199863
		[Token(Token = "0x4030CB7")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _txtWasteExpTips;

		// Token: 0x04030CB8 RID: 199864
		[Token(Token = "0x4030CB8")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		public Action<int, int> onModifyingCardNum;

		// Token: 0x04030CB9 RID: 199865
		[Token(Token = "0x4030CB9")]
		[FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		public Action onWheelBeginDrag;

		// Token: 0x04030CBA RID: 199866
		[Token(Token = "0x4030CBA")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		public Action<int> onWheelScrollEnd;

		// Token: 0x04030CBB RID: 199867
		[Token(Token = "0x4030CBB")]
		[FieldOffset(Offset = "0x108")]
		[NonSerialized]
		public Action<int> onWheelItemClicked;

		// Token: 0x04030CBC RID: 199868
		[Token(Token = "0x4030CBC")]
		[FieldOffset(Offset = "0x110")]
		[NonSerialized]
		public Action onMoveToMaxValidLevel;

		// Token: 0x04030CBD RID: 199869
		[Token(Token = "0x4030CBD")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isInited;

		// Token: 0x04030CBE RID: 199870
		[Token(Token = "0x4030CBE")]
		[FieldOffset(Offset = "0x120")]
		private CharacterLvlupHomeView.CountingPartSwitchTween m_countingPartSwitchTween;

		// Token: 0x04030CBF RID: 199871
		[Token(Token = "0x4030CBF")]
		[FieldOffset(Offset = "0x128")]
		private CharacterLvlupHomeView.ScrollBtnSwitchTween m_scrollBtnSwitchTween;

		// Token: 0x04030CC0 RID: 199872
		[Token(Token = "0x4030CC0")]
		[FieldOffset(Offset = "0x130")]
		private CharacterLvlupHomeView.UpgradeBtnSwitchTween m_upgradeBtnSwitchTween;

		// Token: 0x04030CC1 RID: 199873
		[Token(Token = "0x4030CC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030CC2 RID: 199874
		[Token(Token = "0x4030CC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030CC3 RID: 199875
		[Token(Token = "0x4030CC3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnModifyingCardNum;

		// Token: 0x04030CC4 RID: 199876
		[Token(Token = "0x4030CC4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnMoveToMaxValidLevel;

		// Token: 0x04030CC5 RID: 199877
		[Token(Token = "0x4030CC5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnWheelBeginDrag;

		// Token: 0x04030CC6 RID: 199878
		[Token(Token = "0x4030CC6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnWheelItemClicked;

		// Token: 0x04030CC7 RID: 199879
		[Token(Token = "0x4030CC7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnWheelScrollEnd;

		// Token: 0x04030CC8 RID: 199880
		[Token(Token = "0x4030CC8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryToFadeForCanvasGroup;

		// Token: 0x04030CC9 RID: 199881
		[Token(Token = "0x4030CC9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GeneLackExpStr;

		// Token: 0x04030CCA RID: 199882
		[Token(Token = "0x4030CCA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GeneLackGoldStr;

		// Token: 0x04030CCB RID: 199883
		[Token(Token = "0x4030CCB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F5F RID: 24415
		[Token(Token = "0x2005F5F")]
		private class CountingPartSwitchTween : UISwitchTween
		{
			// Token: 0x060235A1 RID: 144801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235A1")]
			[Address(RVA = "0x1DE3210", Offset = "0x1DE1E10", VA = "0x181DE3210")]
			public CountingPartSwitchTween(CharacterLvlupHomeView closure)
			{
			}

			// Token: 0x060235A2 RID: 144802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235A2")]
			[Address(RVA = "0x1DE3020", Offset = "0x1DE1C20", VA = "0x181DE3020", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060235A3 RID: 144803 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235A3")]
			[Address(RVA = "0x1DE2E30", Offset = "0x1DE1A30", VA = "0x181DE2E30", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x04030CCC RID: 199884
			[Token(Token = "0x4030CCC")]
			private const float TAG_MOVE_OFFSET = 70f;

			// Token: 0x04030CCD RID: 199885
			[Token(Token = "0x4030CCD")]
			private const float COUNTING_MOVE_OFFSET = 176f;

			// Token: 0x04030CCE RID: 199886
			[Token(Token = "0x4030CCE")]
			private const float DURATION_SHOW_TWEEN = 0.15f;

			// Token: 0x04030CCF RID: 199887
			[Token(Token = "0x4030CCF")]
			private const float DURATION_HIDE_TWEEN = 0.1f;

			// Token: 0x04030CD0 RID: 199888
			[Token(Token = "0x4030CD0")]
			[FieldOffset(Offset = "0x48")]
			private CharacterLvlupHomeView m_closure;

			// Token: 0x04030CD1 RID: 199889
			[Token(Token = "0x4030CD1")]
			[FieldOffset(Offset = "0x50")]
			private Vector2 m_tagInitAnchorPos;

			// Token: 0x04030CD2 RID: 199890
			[Token(Token = "0x4030CD2")]
			[FieldOffset(Offset = "0x58")]
			private Vector2 m_countingAnchorPos;

			// Token: 0x04030CD3 RID: 199891
			[Token(Token = "0x4030CD3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030CD4 RID: 199892
			[Token(Token = "0x4030CD4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04030CD5 RID: 199893
			[Token(Token = "0x4030CD5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;
		}

		// Token: 0x02005F60 RID: 24416
		[Token(Token = "0x2005F60")]
		private class ScrollBtnSwitchTween : UISwitchTween
		{
			// Token: 0x060235A4 RID: 144804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235A4")]
			[Address(RVA = "0x1E111E0", Offset = "0x1E0FDE0", VA = "0x181E111E0")]
			public ScrollBtnSwitchTween(CharacterLvlupHomeView closure)
			{
			}

			// Token: 0x060235A5 RID: 144805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235A5")]
			[Address(RVA = "0x1E11030", Offset = "0x1E0FC30", VA = "0x181E11030", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060235A6 RID: 144806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235A6")]
			[Address(RVA = "0x1E10EC0", Offset = "0x1E0FAC0", VA = "0x181E10EC0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x04030CD6 RID: 199894
			[Token(Token = "0x4030CD6")]
			private const float BTN_MOVE_OFFSET = 185f;

			// Token: 0x04030CD7 RID: 199895
			[Token(Token = "0x4030CD7")]
			private const float DURATION_FOR_TWEEN = 0.15f;

			// Token: 0x04030CD8 RID: 199896
			[Token(Token = "0x4030CD8")]
			[FieldOffset(Offset = "0x48")]
			private CharacterLvlupHomeView m_closure;

			// Token: 0x04030CD9 RID: 199897
			[Token(Token = "0x4030CD9")]
			[FieldOffset(Offset = "0x50")]
			private Vector2 m_scrollBtnInitAnchorPos;

			// Token: 0x04030CDA RID: 199898
			[Token(Token = "0x4030CDA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030CDB RID: 199899
			[Token(Token = "0x4030CDB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04030CDC RID: 199900
			[Token(Token = "0x4030CDC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;
		}

		// Token: 0x02005F61 RID: 24417
		[Token(Token = "0x2005F61")]
		private class UpgradeBtnSwitchTween : UISwitchTween
		{
			// Token: 0x060235A7 RID: 144807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235A7")]
			[Address(RVA = "0x1E120C0", Offset = "0x1E10CC0", VA = "0x181E120C0")]
			public UpgradeBtnSwitchTween(CharacterLvlupHomeView closure)
			{
			}

			// Token: 0x060235A8 RID: 144808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235A8")]
			[Address(RVA = "0x1E11F30", Offset = "0x1E10B30", VA = "0x181E11F30", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060235A9 RID: 144809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235A9")]
			[Address(RVA = "0x1E11DC0", Offset = "0x1E109C0", VA = "0x181E11DC0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x04030CDD RID: 199901
			[Token(Token = "0x4030CDD")]
			private const float BTN_MOVE_OFFSET = 214f;

			// Token: 0x04030CDE RID: 199902
			[Token(Token = "0x4030CDE")]
			private const float DURATION_FOR_TWEEN = 0.15f;

			// Token: 0x04030CDF RID: 199903
			[Token(Token = "0x4030CDF")]
			[FieldOffset(Offset = "0x48")]
			private CharacterLvlupHomeView m_closure;

			// Token: 0x04030CE0 RID: 199904
			[Token(Token = "0x4030CE0")]
			[FieldOffset(Offset = "0x50")]
			private Vector2 m_upgradeBtnInitAnchorPos;

			// Token: 0x04030CE1 RID: 199905
			[Token(Token = "0x4030CE1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030CE2 RID: 199906
			[Token(Token = "0x4030CE2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04030CE3 RID: 199907
			[Token(Token = "0x4030CE3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;
		}
	}
}
