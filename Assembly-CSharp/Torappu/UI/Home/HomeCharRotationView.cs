using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BDF RID: 19423
	[Token(Token = "0x2004BDF")]
	public class HomeCharRotationView : DataBinder<HomeCharRotationProperty>, IHotfixable
	{
		// Token: 0x170044A9 RID: 17577
		// (get) Token: 0x0601D304 RID: 119556 RVA: 0x000AAD78 File Offset: 0x000A8F78
		[Token(Token = "0x170044A9")]
		public bool isRotationCharListTweening
		{
			[Token(Token = "0x601D304")]
			[Address(RVA = "0x16C1870", Offset = "0x16C0470", VA = "0x1816C1870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D305 RID: 119557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D305")]
		[Address(RVA = "0x16C0A50", Offset = "0x16BF650", VA = "0x1816C0A50", Slot = "7")]
		public override void OnValueChanged(HomeCharRotationProperty property)
		{
		}

		// Token: 0x0601D306 RID: 119558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D306")]
		[Address(RVA = "0x16C1260", Offset = "0x16BFE60", VA = "0x1816C1260")]
		private void _RenderCharRotationPanel(HomeCharRotationViewModel model)
		{
		}

		// Token: 0x0601D307 RID: 119559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D307")]
		[Address(RVA = "0x16C0F00", Offset = "0x16BFB00", VA = "0x1816C0F00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D308 RID: 119560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D308")]
		[Address(RVA = "0x16C1690", Offset = "0x16C0290", VA = "0x1816C1690")]
		private void _SetRotationListActive(bool active)
		{
		}

		// Token: 0x0601D309 RID: 119561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D309")]
		[Address(RVA = "0x16C15D0", Offset = "0x16C01D0", VA = "0x1816C15D0")]
		private void _SetButtonsActive(bool active)
		{
		}

		// Token: 0x0601D30A RID: 119562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D30A")]
		[Address(RVA = "0x16C0640", Offset = "0x16BF240", VA = "0x1816C0640")]
		public void OnPresetLeftBtnClicked()
		{
		}

		// Token: 0x0601D30B RID: 119563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D30B")]
		[Address(RVA = "0x16C0720", Offset = "0x16BF320", VA = "0x1816C0720")]
		public void OnPresetRightBtnClicked()
		{
		}

		// Token: 0x0601D30C RID: 119564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D30C")]
		[Address(RVA = "0x16C0890", Offset = "0x16BF490", VA = "0x1816C0890")]
		public void OnSkinLeftBtnClicked()
		{
		}

		// Token: 0x0601D30D RID: 119565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D30D")]
		[Address(RVA = "0x16C0970", Offset = "0x16BF570", VA = "0x1816C0970")]
		public void OnSkinRightBtnClicked()
		{
		}

		// Token: 0x0601D30E RID: 119566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D30E")]
		[Address(RVA = "0x16C04B0", Offset = "0x16BF0B0", VA = "0x1816C04B0")]
		public void ChangeRotationList(bool show)
		{
		}

		// Token: 0x0601D30F RID: 119567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D30F")]
		[Address(RVA = "0x16C0C80", Offset = "0x16BF880", VA = "0x1816C0C80")]
		public void OpenChangeSecretaryState()
		{
		}

		// Token: 0x0601D310 RID: 119568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D310")]
		[Address(RVA = "0x16C0BF0", Offset = "0x16BF7F0", VA = "0x1816C0BF0")]
		public void OpenChangeBackgroundState()
		{
		}

		// Token: 0x0601D311 RID: 119569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D311")]
		[Address(RVA = "0x16C0D10", Offset = "0x16BF910", VA = "0x1816C0D10")]
		public void OpenChangeThemeState()
		{
		}

		// Token: 0x0601D312 RID: 119570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D312")]
		[Address(RVA = "0x16C0E30", Offset = "0x16BFA30", VA = "0x1816C0E30")]
		public void OpenIllustEditState()
		{
		}

		// Token: 0x0601D313 RID: 119571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D313")]
		[Address(RVA = "0x16C0DA0", Offset = "0x16BF9A0", VA = "0x1816C0DA0")]
		public void OpenCharRotationPresetListViewDialog()
		{
		}

		// Token: 0x0601D314 RID: 119572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D314")]
		[Address(RVA = "0x16C0800", Offset = "0x16BF400", VA = "0x1816C0800")]
		public void OnSetDisplayBtnClicked()
		{
		}

		// Token: 0x0601D315 RID: 119573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D315")]
		[Address(RVA = "0x16C05B0", Offset = "0x16BF1B0", VA = "0x1816C05B0")]
		public void OnBackgroundClicked()
		{
		}

		// Token: 0x0601D316 RID: 119574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D316")]
		[Address(RVA = "0x16C1740", Offset = "0x16C0340", VA = "0x1816C1740")]
		public HomeCharRotationView()
		{
		}

		// Token: 0x04026512 RID: 156946
		[Token(Token = "0x4026512")]
		private const string TOTAL_SKIN_NUM_FORMAT = "/{0}";

		// Token: 0x04026513 RID: 156947
		[Token(Token = "0x4026513")]
		private const string SKIN_NAME_FORMAT = "{0} {1}";

		// Token: 0x04026514 RID: 156948
		[Token(Token = "0x4026514")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCurrPresetName;

		// Token: 0x04026515 RID: 156949
		[Token(Token = "0x4026515")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlPresetLeftBtn;

		// Token: 0x04026516 RID: 156950
		[Token(Token = "0x4026516")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlPresetRightBtn;

		// Token: 0x04026517 RID: 156951
		[Token(Token = "0x4026517")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCurrSkinNum;

		// Token: 0x04026518 RID: 156952
		[Token(Token = "0x4026518")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTotalSkinNum;

		// Token: 0x04026519 RID: 156953
		[Token(Token = "0x4026519")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textCurrSkinName;

		// Token: 0x0402651A RID: 156954
		[Token(Token = "0x402651A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasSkinLeftBtn;

		// Token: 0x0402651B RID: 156955
		[Token(Token = "0x402651B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasSkinRightBtn;

		// Token: 0x0402651C RID: 156956
		[Token(Token = "0x402651C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _alphaSkinBtnDisabled;

		// Token: 0x0402651D RID: 156957
		[Token(Token = "0x402651D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _charRotationListContainer;

		// Token: 0x0402651E RID: 156958
		[Token(Token = "0x402651E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeCharRotationListPanel _listPanelPrefab;

		// Token: 0x0402651F RID: 156959
		[Token(Token = "0x402651F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _pnlRotationListRaycast;

		// Token: 0x04026520 RID: 156960
		[Token(Token = "0x4026520")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TwoStateToggle _setCharToggle;

		// Token: 0x04026521 RID: 156961
		[Token(Token = "0x4026521")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _charRotationListPnlAnimShow;

		// Token: 0x04026522 RID: 156962
		[Token(Token = "0x4026522")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UICommonTrackPoint _presetDialogTrackPoint;

		// Token: 0x04026523 RID: 156963
		[Token(Token = "0x4026523")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UICommonTrackPoint _homeBGTrackPoint;

		// Token: 0x04026524 RID: 156964
		[Token(Token = "0x4026524")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UICommonTrackPoint _homeThemeTrackPoint;

		// Token: 0x04026525 RID: 156965
		[Token(Token = "0x4026525")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _pnlRaycastRight;

		// Token: 0x04026526 RID: 156966
		[Token(Token = "0x4026526")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _canvasChangeThemeBtn;

		// Token: 0x04026527 RID: 156967
		[Token(Token = "0x4026527")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CanvasGroup _canvasChangeBackgroundBtn;

		// Token: 0x04026528 RID: 156968
		[Token(Token = "0x4026528")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CanvasGroup _canvasContainerTop;

		// Token: 0x04026529 RID: 156969
		[Token(Token = "0x4026529")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _nowUsingPresetDecor;

		// Token: 0x0402652A RID: 156970
		[Token(Token = "0x402652A")]
		[FieldOffset(Offset = "0xD8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402652B RID: 156971
		[Token(Token = "0x402652B")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_cacheShowRotationList;

		// Token: 0x0402652C RID: 156972
		[Token(Token = "0x402652C")]
		[FieldOffset(Offset = "0xF0")]
		private HomeCharRotationListPanel m_listPanel;

		// Token: 0x0402652D RID: 156973
		[Token(Token = "0x402652D")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_hasInited;

		// Token: 0x0402652E RID: 156974
		[Token(Token = "0x402652E")]
		[FieldOffset(Offset = "0xFC")]
		private int m_enterSeqNum;

		// Token: 0x0402652F RID: 156975
		[Token(Token = "0x402652F")]
		[FieldOffset(Offset = "0x100")]
		private UISwitchTween m_charRotationListPnlShowTween;

		// Token: 0x04026530 RID: 156976
		[Token(Token = "0x4026530")]
		[FieldOffset(Offset = "0x108")]
		private TrackPointViewProperty m_presetTrackProperty;

		// Token: 0x04026531 RID: 156977
		[Token(Token = "0x4026531")]
		[FieldOffset(Offset = "0x110")]
		private TrackPointViewProperty m_homeBGTrackProperty;

		// Token: 0x04026532 RID: 156978
		[Token(Token = "0x4026532")]
		[FieldOffset(Offset = "0x118")]
		private TrackPointViewProperty m_homeThemeTrackProperty;

		// Token: 0x04026533 RID: 156979
		[Token(Token = "0x4026533")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isRotationCharListTweening;

		// Token: 0x04026534 RID: 156980
		[Token(Token = "0x4026534")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026535 RID: 156981
		[Token(Token = "0x4026535")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCharRotationPanel;

		// Token: 0x04026536 RID: 156982
		[Token(Token = "0x4026536")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026537 RID: 156983
		[Token(Token = "0x4026537")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetRotationListActive;

		// Token: 0x04026538 RID: 156984
		[Token(Token = "0x4026538")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetButtonsActive;

		// Token: 0x04026539 RID: 156985
		[Token(Token = "0x4026539")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPresetLeftBtnClicked;

		// Token: 0x0402653A RID: 156986
		[Token(Token = "0x402653A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPresetRightBtnClicked;

		// Token: 0x0402653B RID: 156987
		[Token(Token = "0x402653B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSkinLeftBtnClicked;

		// Token: 0x0402653C RID: 156988
		[Token(Token = "0x402653C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnSkinRightBtnClicked;

		// Token: 0x0402653D RID: 156989
		[Token(Token = "0x402653D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ChangeRotationList;

		// Token: 0x0402653E RID: 156990
		[Token(Token = "0x402653E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OpenChangeSecretaryState;

		// Token: 0x0402653F RID: 156991
		[Token(Token = "0x402653F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OpenChangeBackgroundState;

		// Token: 0x04026540 RID: 156992
		[Token(Token = "0x4026540")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OpenChangeThemeState;

		// Token: 0x04026541 RID: 156993
		[Token(Token = "0x4026541")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OpenIllustEditState;

		// Token: 0x04026542 RID: 156994
		[Token(Token = "0x4026542")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OpenCharRotationPresetListViewDialog;

		// Token: 0x04026543 RID: 156995
		[Token(Token = "0x4026543")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnSetDisplayBtnClicked;

		// Token: 0x04026544 RID: 156996
		[Token(Token = "0x4026544")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnBackgroundClicked;

		// Token: 0x04026545 RID: 156997
		[Token(Token = "0x4026545")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
