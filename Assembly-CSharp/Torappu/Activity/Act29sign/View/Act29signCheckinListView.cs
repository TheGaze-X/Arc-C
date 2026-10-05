using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x020074A5 RID: 29861
	[Token(Token = "0x20074A5")]
	public class Act29signCheckinListView : ActivityCheckinEntryView
	{
		// Token: 0x0602A1CE RID: 172494 RVA: 0x000D7730 File Offset: 0x000D5930
		[Token(Token = "0x602A1CE")]
		[Address(RVA = "0x25B3C40", Offset = "0x25B2840", VA = "0x1825B3C40")]
		private int _CountNormalizedPosition(int focusItem, int totalCount, int gap)
		{
			return 0;
		}

		// Token: 0x0602A1CF RID: 172495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1CF")]
		[Address(RVA = "0x25B4710", Offset = "0x25B3310", VA = "0x1825B4710")]
		private void _UpdateEntryInfo(bool isInit)
		{
		}

		// Token: 0x0602A1D0 RID: 172496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1D0")]
		[Address(RVA = "0x25B4390", Offset = "0x25B2F90", VA = "0x1825B4390")]
		private void _InitOrUpdateCheckinItems(bool isInit)
		{
		}

		// Token: 0x0602A1D1 RID: 172497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1D1")]
		[Address(RVA = "0x25B3CE0", Offset = "0x25B28E0", VA = "0x1825B3CE0")]
		private void _EventForDotClick(int focusItem, int checkinCount)
		{
		}

		// Token: 0x0602A1D2 RID: 172498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1D2")]
		[Address(RVA = "0x25B4630", Offset = "0x25B3230", VA = "0x1825B4630")]
		private IEnumerator _MoveToFocusItem(int focusItem, int checkinCount)
		{
			return null;
		}

		// Token: 0x0602A1D3 RID: 172499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1D3")]
		[Address(RVA = "0x25B3E50", Offset = "0x25B2A50", VA = "0x1825B3E50")]
		private void _InitIfNot(ActivityCommonCheckinViewModel outerViewModel)
		{
		}

		// Token: 0x0602A1D4 RID: 172500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1D4")]
		[Address(RVA = "0x25B3B30", Offset = "0x25B2730", VA = "0x1825B3B30", Slot = "4")]
		public override void RenderView(ActivityCommonCheckinViewModel outerViewModel)
		{
		}

		// Token: 0x0602A1D5 RID: 172501 RVA: 0x000D7748 File Offset: 0x000D5948
		[Token(Token = "0x602A1D5")]
		[Address(RVA = "0x25B3AD0", Offset = "0x25B26D0", VA = "0x1825B3AD0", Slot = "5")]
		public override ActivityCheckinEntryView.CheckinViewType GetViewType()
		{
			return ActivityCheckinEntryView.CheckinViewType.NONE;
		}

		// Token: 0x0602A1D6 RID: 172502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1D6")]
		[Address(RVA = "0x25B3920", Offset = "0x25B2520", VA = "0x1825B3920")]
		public void EventOnCloseBtnClick()
		{
		}

		// Token: 0x0602A1D7 RID: 172503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1D7")]
		[Address(RVA = "0x25B3980", Offset = "0x25B2580", VA = "0x1825B3980")]
		public void EventOnNormalItemClicked(int index)
		{
		}

		// Token: 0x0602A1D8 RID: 172504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1D8")]
		[Address(RVA = "0x25B3A30", Offset = "0x25B2630", VA = "0x1825B3A30")]
		public void EventOnSpecialItemClicked()
		{
		}

		// Token: 0x0602A1D9 RID: 172505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1D9")]
		[Address(RVA = "0x25B4F20", Offset = "0x25B3B20", VA = "0x1825B4F20")]
		public Act29signCheckinListView()
		{
		}

		// Token: 0x0403C783 RID: 247683
		[Token(Token = "0x403C783")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("General")]
		private Transform _dotViewContainer;

		// Token: 0x0403C784 RID: 247684
		[Token(Token = "0x403C784")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("General")]
		private Text _openTime;

		// Token: 0x0403C785 RID: 247685
		[Token(Token = "0x403C785")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("General")]
		private LoopHorizontalScrollRect _scrollRect;

		// Token: 0x0403C786 RID: 247686
		[Token(Token = "0x403C786")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("General")]
		private Text _apItemTime;

		// Token: 0x0403C787 RID: 247687
		[Token(Token = "0x403C787")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("General")]
		private Text[] _mainRewardCountdown;

		// Token: 0x0403C788 RID: 247688
		[Token(Token = "0x403C788")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("General")]
		private ActivityCommonCheckinDotView _dotView;

		// Token: 0x0403C789 RID: 247689
		[Token(Token = "0x403C789")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("General")]
		private Act29signCheckinItemAdapter _adapter;

		// Token: 0x0403C78A RID: 247690
		[Token(Token = "0x403C78A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("General")]
		private Image _moonCakeImg;

		// Token: 0x0403C78B RID: 247691
		[Token(Token = "0x403C78B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("General")]
		private Image _furnitureImg;

		// Token: 0x0403C78C RID: 247692
		[Token(Token = "0x403C78C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Normal Item Config")]
		private Color _mainColor;

		// Token: 0x0403C78D RID: 247693
		[Token(Token = "0x403C78D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Normal Item Config")]
		private Color _logoColor;

		// Token: 0x0403C78E RID: 247694
		[Token(Token = "0x403C78E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Normal Item Config")]
		private Color _acceptableLogoColor;

		// Token: 0x0403C78F RID: 247695
		[Token(Token = "0x403C78F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Normal Item Config")]
		private Color _maskColor;

		// Token: 0x0403C790 RID: 247696
		[Token(Token = "0x403C790")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Normal Item Config")]
		private Color _rewardBgColor;

		// Token: 0x0403C791 RID: 247697
		[Token(Token = "0x403C791")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Normal Item Config")]
		private Color _rewardMaskColor;

		// Token: 0x0403C792 RID: 247698
		[Token(Token = "0x403C792")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Normal Item Config")]
		private Color _rewardDotColor;

		// Token: 0x0403C793 RID: 247699
		[Token(Token = "0x403C793")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Normal Item Config")]
		private Color _acceptableLightColor;

		// Token: 0x0403C794 RID: 247700
		[Token(Token = "0x403C794")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Normal Item Config")]
		private Sprite _decSprite;

		// Token: 0x0403C795 RID: 247701
		[Token(Token = "0x403C795")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Special Item Config")]
		private Color _numIconColor;

		// Token: 0x0403C796 RID: 247702
		[Token(Token = "0x403C796")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Special Item Config")]
		private Color _progressTextColor;

		// Token: 0x0403C797 RID: 247703
		[Token(Token = "0x403C797")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Dot View Config")]
		private Sprite _normalDot;

		// Token: 0x0403C798 RID: 247704
		[Token(Token = "0x403C798")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Dot View Config")]
		private Sprite _bigDot;

		// Token: 0x0403C799 RID: 247705
		[Token(Token = "0x403C799")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Dot View Config")]
		private Sprite _acceptableDot;

		// Token: 0x0403C79A RID: 247706
		[Token(Token = "0x403C79A")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("Dot View Config")]
		private Color _outlineColor;

		// Token: 0x0403C79B RID: 247707
		[Token(Token = "0x403C79B")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("Dot View Config")]
		private Color _notGetColor;

		// Token: 0x0403C79C RID: 247708
		[Token(Token = "0x403C79C")]
		[FieldOffset(Offset = "0x178")]
		private Act29signCheckinListViewModel m_viewModel;

		// Token: 0x0403C79D RID: 247709
		[Token(Token = "0x403C79D")]
		[FieldOffset(Offset = "0x180")]
		private ActivityCommonCheckinViewModel m_outerViewModel;

		// Token: 0x0403C79E RID: 247710
		[Token(Token = "0x403C79E")]
		[FieldOffset(Offset = "0x188")]
		private bool m_hasInited;

		// Token: 0x0403C79F RID: 247711
		[Token(Token = "0x403C79F")]
		[FieldOffset(Offset = "0x190")]
		private ActivityCommonCheckinDotView m_dotView;

		// Token: 0x0403C7A0 RID: 247712
		[Token(Token = "0x403C7A0")]
		[FieldOffset(Offset = "0x198")]
		private DefaultCheckInData.CheckInDailyInfo[] m_ShowItemArray;

		// Token: 0x0403C7A1 RID: 247713
		[Token(Token = "0x403C7A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CountNormalizedPosition;

		// Token: 0x0403C7A2 RID: 247714
		[Token(Token = "0x403C7A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateEntryInfo;

		// Token: 0x0403C7A3 RID: 247715
		[Token(Token = "0x403C7A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitOrUpdateCheckinItems;

		// Token: 0x0403C7A4 RID: 247716
		[Token(Token = "0x403C7A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventForDotClick;

		// Token: 0x0403C7A5 RID: 247717
		[Token(Token = "0x403C7A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__MoveToFocusItem;

		// Token: 0x0403C7A6 RID: 247718
		[Token(Token = "0x403C7A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C7A7 RID: 247719
		[Token(Token = "0x403C7A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403C7A8 RID: 247720
		[Token(Token = "0x403C7A8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403C7A9 RID: 247721
		[Token(Token = "0x403C7A9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnCloseBtnClick;

		// Token: 0x0403C7AA RID: 247722
		[Token(Token = "0x403C7AA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnNormalItemClicked;

		// Token: 0x0403C7AB RID: 247723
		[Token(Token = "0x403C7AB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnSpecialItemClicked;

		// Token: 0x0403C7AC RID: 247724
		[Token(Token = "0x403C7AC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
