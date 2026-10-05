using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200634E RID: 25422
	[Token(Token = "0x200634E")]
	public class AutoChessShopMainView : DataBinder<AutoChessShopProperty>
	{
		// Token: 0x1700569C RID: 22172
		// (get) Token: 0x06024AE2 RID: 150242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700569C")]
		public AutoChessShopSkillAndModuleEditCharListView multiEditCharListView
		{
			[Token(Token = "0x6024AE2")]
			[Address(RVA = "0x1F8BB10", Offset = "0x1F8A710", VA = "0x181F8BB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700569D RID: 22173
		// (get) Token: 0x06024AE3 RID: 150243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700569D")]
		public AutoChessShopCharListView charListView
		{
			[Token(Token = "0x6024AE3")]
			[Address(RVA = "0x1F8BAB0", Offset = "0x1F8A6B0", VA = "0x181F8BAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024AE4 RID: 150244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AE4")]
		[Address(RVA = "0x1F8A650", Offset = "0x1F89250", VA = "0x181F8A650")]
		public void Init(AutoChessShopPage page)
		{
		}

		// Token: 0x06024AE5 RID: 150245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AE5")]
		[Address(RVA = "0x1F8A930", Offset = "0x1F89530", VA = "0x181F8A930")]
		public void OnEnter()
		{
		}

		// Token: 0x06024AE6 RID: 150246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AE6")]
		[Address(RVA = "0x1F8AA30", Offset = "0x1F89630", VA = "0x181F8AA30", Slot = "7")]
		public override void OnValueChanged(AutoChessShopProperty property)
		{
		}

		// Token: 0x06024AE7 RID: 150247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AE7")]
		[Address(RVA = "0x1F8B3B0", Offset = "0x1F89FB0", VA = "0x181F8B3B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024AE8 RID: 150248 RVA: 0x000C5328 File Offset: 0x000C3528
		[Token(Token = "0x6024AE8")]
		[Address(RVA = "0x1F8B2D0", Offset = "0x1F89ED0", VA = "0x181F8B2D0")]
		private FadeSwitchTween.Builder _GetListFadeBuilder(CanvasGroup canvasGroup)
		{
			return default(FadeSwitchTween.Builder);
		}

		// Token: 0x06024AE9 RID: 150249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AE9")]
		[Address(RVA = "0x1F8B7E0", Offset = "0x1F8A3E0", VA = "0x181F8B7E0")]
		private void _TryStartTutorial()
		{
		}

		// Token: 0x06024AEA RID: 150250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024AEA")]
		[Address(RVA = "0x1F8B990", Offset = "0x1F8A590", VA = "0x181F8B990")]
		private IEnumerator _TutorialOnly_TryRaiseAVGSignal()
		{
			return null;
		}

		// Token: 0x06024AEB RID: 150251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AEB")]
		[Address(RVA = "0x1F8B240", Offset = "0x1F89E40", VA = "0x181F8B240")]
		private void _EventOnReturnClick()
		{
		}

		// Token: 0x06024AEC RID: 150252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AEC")]
		[Address(RVA = "0x1F8BA40", Offset = "0x1F8A640", VA = "0x181F8BA40")]
		public AutoChessShopMainView()
		{
		}

		// Token: 0x0403331B RID: 209691
		[Token(Token = "0x403331B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasCharList;

		// Token: 0x0403331C RID: 209692
		[Token(Token = "0x403331C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _transCharListViewContainer;

		// Token: 0x0403331D RID: 209693
		[Token(Token = "0x403331D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessShopCharListView _charListViewPrefab;

		// Token: 0x0403331E RID: 209694
		[Token(Token = "0x403331E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasTrapList;

		// Token: 0x0403331F RID: 209695
		[Token(Token = "0x403331F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _transTrapListViewContainer;

		// Token: 0x04033320 RID: 209696
		[Token(Token = "0x4033320")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AutoChessShopTrapListView _trapListViewPrefab;

		// Token: 0x04033321 RID: 209697
		[Token(Token = "0x4033321")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasMenuView;

		// Token: 0x04033322 RID: 209698
		[Token(Token = "0x4033322")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _transMenuViewContainer;

		// Token: 0x04033323 RID: 209699
		[Token(Token = "0x4033323")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AutoChessShopMenuView _menuViewPrefab;

		// Token: 0x04033324 RID: 209700
		[Token(Token = "0x4033324")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasTopView;

		// Token: 0x04033325 RID: 209701
		[Token(Token = "0x4033325")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _transTopViewContainer;

		// Token: 0x04033326 RID: 209702
		[Token(Token = "0x4033326")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AutoChessShopTopView _topViewPrefab;

		// Token: 0x04033327 RID: 209703
		[Token(Token = "0x4033327")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasDetailView;

		// Token: 0x04033328 RID: 209704
		[Token(Token = "0x4033328")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _detailViewContainer;

		// Token: 0x04033329 RID: 209705
		[Token(Token = "0x4033329")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AutoChessShopDetailView _detailViewPrefab;

		// Token: 0x0403332A RID: 209706
		[Token(Token = "0x403332A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasDetailCharList;

		// Token: 0x0403332B RID: 209707
		[Token(Token = "0x403332B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _transDetailCharListViewContainer;

		// Token: 0x0403332C RID: 209708
		[Token(Token = "0x403332C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AutoChessShopDetailCharListView _detailCharListViewPrefab;

		// Token: 0x0403332D RID: 209709
		[Token(Token = "0x403332D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CanvasGroup _canvasSkillAndModuleEditCharList;

		// Token: 0x0403332E RID: 209710
		[Token(Token = "0x403332E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform _transSkillAndModuleEditCharListViewContainer;

		// Token: 0x0403332F RID: 209711
		[Token(Token = "0x403332F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AutoChessShopSkillAndModuleEditCharListView _skillAndModuleEditListViewPrefab;

		// Token: 0x04033330 RID: 209712
		[Token(Token = "0x4033330")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform _rectTopMenuContainer;

		// Token: 0x04033331 RID: 209713
		[Token(Token = "0x4033331")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hasInited;

		// Token: 0x04033332 RID: 209714
		[Token(Token = "0x4033332")]
		[FieldOffset(Offset = "0xD8")]
		private AutoChessShopCharListView m_charListView;

		// Token: 0x04033333 RID: 209715
		[Token(Token = "0x4033333")]
		[FieldOffset(Offset = "0xE0")]
		private AutoChessShopTrapListView m_trapListView;

		// Token: 0x04033334 RID: 209716
		[Token(Token = "0x4033334")]
		[FieldOffset(Offset = "0xE8")]
		private AutoChessShopMenuView m_menuView;

		// Token: 0x04033335 RID: 209717
		[Token(Token = "0x4033335")]
		[FieldOffset(Offset = "0xF0")]
		private AutoChessShopTopView m_topView;

		// Token: 0x04033336 RID: 209718
		[Token(Token = "0x4033336")]
		[FieldOffset(Offset = "0xF8")]
		private AutoChessShopDetailView m_detailView;

		// Token: 0x04033337 RID: 209719
		[Token(Token = "0x4033337")]
		[FieldOffset(Offset = "0x100")]
		private AutoChessShopDetailCharListView m_detailCharListView;

		// Token: 0x04033338 RID: 209720
		[Token(Token = "0x4033338")]
		[FieldOffset(Offset = "0x108")]
		private AutoChessShopSkillAndModuleEditCharListView m_skillAndModuleEditCharListView;

		// Token: 0x04033339 RID: 209721
		[Token(Token = "0x4033339")]
		[FieldOffset(Offset = "0x110")]
		private FadeSwitchTween m_tweenCharList;

		// Token: 0x0403333A RID: 209722
		[Token(Token = "0x403333A")]
		[FieldOffset(Offset = "0x118")]
		private FadeSwitchTween m_tweenDetailCharList;

		// Token: 0x0403333B RID: 209723
		[Token(Token = "0x403333B")]
		[FieldOffset(Offset = "0x120")]
		private FadeSwitchTween m_tweenSkillAndModuleEditCharList;

		// Token: 0x0403333C RID: 209724
		[Token(Token = "0x403333C")]
		[FieldOffset(Offset = "0x128")]
		private FadeSwitchTween m_tweenTrapList;

		// Token: 0x0403333D RID: 209725
		[Token(Token = "0x403333D")]
		[FieldOffset(Offset = "0x130")]
		private FadeSwitchTween m_tweenMenuView;

		// Token: 0x0403333E RID: 209726
		[Token(Token = "0x403333E")]
		[FieldOffset(Offset = "0x138")]
		private FadeSwitchTween m_tweenTopView;

		// Token: 0x0403333F RID: 209727
		[Token(Token = "0x403333F")]
		[FieldOffset(Offset = "0x140")]
		private FadeSwitchTween m_tweenDetailView;

		// Token: 0x04033340 RID: 209728
		[Token(Token = "0x4033340")]
		[FieldOffset(Offset = "0x148")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04033341 RID: 209729
		[Token(Token = "0x4033341")]
		[FieldOffset(Offset = "0x158")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x04033342 RID: 209730
		[Token(Token = "0x4033342")]
		[FieldOffset(Offset = "0x160")]
		private AutoChessShopPage m_page;

		// Token: 0x04033343 RID: 209731
		[Token(Token = "0x4033343")]
		private const float LIST_SWITCH_TWEEN_DURATION = 0.3f;

		// Token: 0x04033344 RID: 209732
		[Token(Token = "0x4033344")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_multiEditCharListView;

		// Token: 0x04033345 RID: 209733
		[Token(Token = "0x4033345")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charListView;

		// Token: 0x04033346 RID: 209734
		[Token(Token = "0x4033346")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04033347 RID: 209735
		[Token(Token = "0x4033347")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04033348 RID: 209736
		[Token(Token = "0x4033348")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04033349 RID: 209737
		[Token(Token = "0x4033349")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403334A RID: 209738
		[Token(Token = "0x403334A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetListFadeBuilder;

		// Token: 0x0403334B RID: 209739
		[Token(Token = "0x403334B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryStartTutorial;

		// Token: 0x0403334C RID: 209740
		[Token(Token = "0x403334C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRaiseAVGSignal;

		// Token: 0x0403334D RID: 209741
		[Token(Token = "0x403334D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnReturnClick;

		// Token: 0x0403334E RID: 209742
		[Token(Token = "0x403334E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
