using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006013 RID: 24595
	[Token(Token = "0x2006013")]
	public class CGGalleryInspectView : DataBinder<CGGalleryProperty>
	{
		// Token: 0x17005405 RID: 21509
		// (get) Token: 0x0602391A RID: 145690 RVA: 0x000C1458 File Offset: 0x000BF658
		[Token(Token = "0x17005405")]
		public bool isDraggingOrPinching
		{
			[Token(Token = "0x602391A")]
			[Address(RVA = "0x1E370B0", Offset = "0x1E35CB0", VA = "0x181E370B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005406 RID: 21510
		// (get) Token: 0x0602391B RID: 145691 RVA: 0x000C1470 File Offset: 0x000BF670
		[Token(Token = "0x17005406")]
		public bool isUISwitching
		{
			[Token(Token = "0x602391B")]
			[Address(RVA = "0x1E37120", Offset = "0x1E35D20", VA = "0x181E37120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005407 RID: 21511
		// (get) Token: 0x0602391C RID: 145692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005407")]
		public TouchHandler touchHandler
		{
			[Token(Token = "0x602391C")]
			[Address(RVA = "0x1E37190", Offset = "0x1E35D90", VA = "0x181E37190")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602391D RID: 145693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602391D")]
		[Address(RVA = "0x1E35F50", Offset = "0x1E34B50", VA = "0x181E35F50")]
		private void _InitDragContext()
		{
		}

		// Token: 0x0602391E RID: 145694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602391E")]
		[Address(RVA = "0x1E36410", Offset = "0x1E35010", VA = "0x181E36410")]
		private void _RebindDragView(CGGalleryImageContainer newDragTarget)
		{
		}

		// Token: 0x0602391F RID: 145695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602391F")]
		[Address(RVA = "0x1E35840", Offset = "0x1E34440", VA = "0x181E35840")]
		private void _BindDragViewInternal(CGGalleryImageContainer imageContainer)
		{
		}

		// Token: 0x06023920 RID: 145696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023920")]
		[Address(RVA = "0x1E35620", Offset = "0x1E34220", VA = "0x181E35620")]
		public void ResetImageStatus()
		{
		}

		// Token: 0x06023921 RID: 145697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023921")]
		[Address(RVA = "0x1E35440", Offset = "0x1E34040", VA = "0x181E35440", Slot = "7")]
		public override void OnValueChanged(CGGalleryProperty property)
		{
		}

		// Token: 0x06023922 RID: 145698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023922")]
		[Address(RVA = "0x1E362B0", Offset = "0x1E34EB0", VA = "0x181E362B0")]
		private void _InitUIIfNot()
		{
		}

		// Token: 0x06023923 RID: 145699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023923")]
		[Address(RVA = "0x1E367E0", Offset = "0x1E353E0", VA = "0x181E367E0")]
		private void _RenderView(CGGalleryViewModel viewModel)
		{
		}

		// Token: 0x06023924 RID: 145700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023924")]
		[Address(RVA = "0x1E36610", Offset = "0x1E35210", VA = "0x181E36610")]
		private void _RenderStagePart(CGGalleryDisplayViewModel displayModel)
		{
		}

		// Token: 0x06023925 RID: 145701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023925")]
		[Address(RVA = "0x1E364F0", Offset = "0x1E350F0", VA = "0x181E364F0")]
		private void _RenderChapterIcon()
		{
		}

		// Token: 0x06023926 RID: 145702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023926")]
		[Address(RVA = "0x1E36F80", Offset = "0x1E35B80", VA = "0x181E36F80")]
		private void _TryHideBtn(CGGalleryViewModel viewModel)
		{
		}

		// Token: 0x06023927 RID: 145703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023927")]
		[Address(RVA = "0x1E35C20", Offset = "0x1E34820", VA = "0x181E35C20")]
		private void _EnsureFavTween()
		{
		}

		// Token: 0x06023928 RID: 145704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023928")]
		[Address(RVA = "0x1E35740", Offset = "0x1E34340", VA = "0x181E35740")]
		private void Start()
		{
		}

		// Token: 0x06023929 RID: 145705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023929")]
		[Address(RVA = "0x1E35910", Offset = "0x1E34510", VA = "0x181E35910")]
		private void _CgViewHandler(CGGalleryViewModel viewModel)
		{
		}

		// Token: 0x0602392A RID: 145706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602392A")]
		[Address(RVA = "0x1E35DC0", Offset = "0x1E349C0", VA = "0x181E35DC0")]
		private void _InitCgView(CGGalleryCGViewModel cgViewModel)
		{
		}

		// Token: 0x0602392B RID: 145707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602392B")]
		[Address(RVA = "0x1E36CD0", Offset = "0x1E358D0", VA = "0x181E36CD0")]
		private void _TransitionTo(CGGalleryCGViewModel targetCgViewModel, bool forward, bool isSameDisplay)
		{
		}

		// Token: 0x0602392C RID: 145708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602392C")]
		[Address(RVA = "0x1E35CF0", Offset = "0x1E348F0", VA = "0x181E35CF0")]
		private void _EnsureUISwitch()
		{
		}

		// Token: 0x0602392D RID: 145709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602392D")]
		[Address(RVA = "0x1E36340", Offset = "0x1E34F40", VA = "0x181E36340")]
		private void _OnTransitionEndInternal()
		{
		}

		// Token: 0x0602392E RID: 145710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602392E")]
		[Address(RVA = "0x1E35330", Offset = "0x1E33F30", VA = "0x181E35330")]
		public void OnTwComplete()
		{
		}

		// Token: 0x0602392F RID: 145711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602392F")]
		[Address(RVA = "0x1E356A0", Offset = "0x1E342A0", VA = "0x181E356A0")]
		public void SetUIState(bool hide)
		{
		}

		// Token: 0x06023930 RID: 145712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023930")]
		[Address(RVA = "0x1E34BD0", Offset = "0x1E337D0", VA = "0x181E34BD0")]
		public void EventOnFavCG()
		{
		}

		// Token: 0x06023931 RID: 145713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023931")]
		[Address(RVA = "0x1E35090", Offset = "0x1E33C90", VA = "0x181E35090")]
		public void EventOnRemFavCG()
		{
		}

		// Token: 0x06023932 RID: 145714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023932")]
		[Address(RVA = "0x1E34E50", Offset = "0x1E33A50", VA = "0x181E34E50")]
		public void EventOnNextClicked()
		{
		}

		// Token: 0x06023933 RID: 145715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023933")]
		[Address(RVA = "0x1E34F70", Offset = "0x1E33B70", VA = "0x181E34F70")]
		public void EventOnPrevClicked()
		{
		}

		// Token: 0x06023934 RID: 145716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023934")]
		[Address(RVA = "0x1E35210", Offset = "0x1E33E10", VA = "0x181E35210")]
		public void EventOnStoryClicked()
		{
		}

		// Token: 0x06023935 RID: 145717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023935")]
		[Address(RVA = "0x1E34D50", Offset = "0x1E33950", VA = "0x181E34D50")]
		public void EventOnHideUIClicked()
		{
		}

		// Token: 0x06023936 RID: 145718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023936")]
		[Address(RVA = "0x1E357C0", Offset = "0x1E343C0", VA = "0x181E357C0")]
		private void Update()
		{
		}

		// Token: 0x06023937 RID: 145719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023937")]
		[Address(RVA = "0x1E37030", Offset = "0x1E35C30", VA = "0x181E37030")]
		public CGGalleryInspectView()
		{
		}

		// Token: 0x0403137B RID: 201595
		[Token(Token = "0x403137B")]
		private const float MIN_SCALE = 1f;

		// Token: 0x0403137C RID: 201596
		[Token(Token = "0x403137C")]
		private const float MAX_SCALE = 3f;

		// Token: 0x0403137D RID: 201597
		[Token(Token = "0x403137D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _favoriteBtnAnimLoc;

		// Token: 0x0403137E RID: 201598
		[Token(Token = "0x403137E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _uiSwitchAnimLoc;

		// Token: 0x0403137F RID: 201599
		[Token(Token = "0x403137F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _prevBtnObj;

		// Token: 0x04031380 RID: 201600
		[Token(Token = "0x4031380")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _nextBtnObj;

		// Token: 0x04031381 RID: 201601
		[Token(Token = "0x4031381")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _cgSetObj;

		// Token: 0x04031382 RID: 201602
		[Token(Token = "0x4031382")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _cgCountText;

		// Token: 0x04031383 RID: 201603
		[Token(Token = "0x4031383")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _cgCountLimitText;

		// Token: 0x04031384 RID: 201604
		[Token(Token = "0x4031384")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _cgTitle;

		// Token: 0x04031385 RID: 201605
		[Token(Token = "0x4031385")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _cgDescription;

		// Token: 0x04031386 RID: 201606
		[Token(Token = "0x4031386")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIDynImage _storyLineIcon;

		// Token: 0x04031387 RID: 201607
		[Token(Token = "0x4031387")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _storyBtn;

		// Token: 0x04031388 RID: 201608
		[Token(Token = "0x4031388")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _storyCode;

		// Token: 0x04031389 RID: 201609
		[Token(Token = "0x4031389")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _storyTitle;

		// Token: 0x0403138A RID: 201610
		[Token(Token = "0x403138A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _storyTag;

		// Token: 0x0403138B RID: 201611
		[Token(Token = "0x403138B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _storyInfoObj;

		// Token: 0x0403138C RID: 201612
		[Token(Token = "0x403138C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button _addFavBtn;

		// Token: 0x0403138D RID: 201613
		[Token(Token = "0x403138D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Button _remFavBtn;

		// Token: 0x0403138E RID: 201614
		[Token(Token = "0x403138E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform _cgDragBound;

		// Token: 0x0403138F RID: 201615
		[Token(Token = "0x403138F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CGGalleryInspectImageViewScaleHandler _scaleHandler;

		// Token: 0x04031390 RID: 201616
		[Token(Token = "0x4031390")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CGGalleryImageContainer _foreImageContainer;

		// Token: 0x04031391 RID: 201617
		[Token(Token = "0x4031391")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CGGalleryImageContainer _backImageContainer;

		// Token: 0x04031392 RID: 201618
		[Token(Token = "0x4031392")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _uiContainerObj;

		// Token: 0x04031393 RID: 201619
		[Token(Token = "0x4031393")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CGGalleryDragAndPinchView _dragAndPinchView;

		// Token: 0x04031394 RID: 201620
		[Token(Token = "0x4031394")]
		[FieldOffset(Offset = "0xE8")]
		private UIStateFinder m_finder;

		// Token: 0x04031395 RID: 201621
		[Token(Token = "0x4031395")]
		[FieldOffset(Offset = "0xF8")]
		private CGGalleryDisplayViewModel m_viewModel;

		// Token: 0x04031396 RID: 201622
		[Token(Token = "0x4031396")]
		[FieldOffset(Offset = "0x100")]
		private string m_cachedIconId;

		// Token: 0x04031397 RID: 201623
		[Token(Token = "0x4031397")]
		[FieldOffset(Offset = "0x108")]
		private string m_cachedCgId;

		// Token: 0x04031398 RID: 201624
		[Token(Token = "0x4031398")]
		[FieldOffset(Offset = "0x110")]
		private TouchHandler<DragAndPinchWithTargetContext> m_touchHandler;

		// Token: 0x04031399 RID: 201625
		[Token(Token = "0x4031399")]
		[FieldOffset(Offset = "0x118")]
		private DragAndPinchWithTargetContext m_context;

		// Token: 0x0403139A RID: 201626
		[Token(Token = "0x403139A")]
		[FieldOffset(Offset = "0x120")]
		private bool m_cgViewInited;

		// Token: 0x0403139B RID: 201627
		[Token(Token = "0x403139B")]
		[FieldOffset(Offset = "0x121")]
		private bool m_uiInited;

		// Token: 0x0403139C RID: 201628
		[Token(Token = "0x403139C")]
		[FieldOffset(Offset = "0x128")]
		private UISwitchTween m_favTw;

		// Token: 0x0403139D RID: 201629
		[Token(Token = "0x403139D")]
		[FieldOffset(Offset = "0x130")]
		private UISwitchTween m_uiHideTw;

		// Token: 0x0403139E RID: 201630
		[Token(Token = "0x403139E")]
		[FieldOffset(Offset = "0x138")]
		private bool m_isForeActive;

		// Token: 0x0403139F RID: 201631
		[Token(Token = "0x403139F")]
		[FieldOffset(Offset = "0x139")]
		private bool m_isTransition;

		// Token: 0x040313A0 RID: 201632
		[Token(Token = "0x40313A0")]
		[FieldOffset(Offset = "0x13C")]
		private int m_activeTweenCount;

		// Token: 0x040313A1 RID: 201633
		[Token(Token = "0x40313A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isDraggingOrPinching;

		// Token: 0x040313A2 RID: 201634
		[Token(Token = "0x40313A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isUISwitching;

		// Token: 0x040313A3 RID: 201635
		[Token(Token = "0x40313A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_touchHandler;

		// Token: 0x040313A4 RID: 201636
		[Token(Token = "0x40313A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitDragContext;

		// Token: 0x040313A5 RID: 201637
		[Token(Token = "0x40313A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RebindDragView;

		// Token: 0x040313A6 RID: 201638
		[Token(Token = "0x40313A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__BindDragViewInternal;

		// Token: 0x040313A7 RID: 201639
		[Token(Token = "0x40313A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ResetImageStatus;

		// Token: 0x040313A8 RID: 201640
		[Token(Token = "0x40313A8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040313A9 RID: 201641
		[Token(Token = "0x40313A9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitUIIfNot;

		// Token: 0x040313AA RID: 201642
		[Token(Token = "0x40313AA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x040313AB RID: 201643
		[Token(Token = "0x40313AB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderStagePart;

		// Token: 0x040313AC RID: 201644
		[Token(Token = "0x40313AC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderChapterIcon;

		// Token: 0x040313AD RID: 201645
		[Token(Token = "0x40313AD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryHideBtn;

		// Token: 0x040313AE RID: 201646
		[Token(Token = "0x40313AE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EnsureFavTween;

		// Token: 0x040313AF RID: 201647
		[Token(Token = "0x40313AF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040313B0 RID: 201648
		[Token(Token = "0x40313B0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CgViewHandler;

		// Token: 0x040313B1 RID: 201649
		[Token(Token = "0x40313B1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitCgView;

		// Token: 0x040313B2 RID: 201650
		[Token(Token = "0x40313B2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TransitionTo;

		// Token: 0x040313B3 RID: 201651
		[Token(Token = "0x40313B3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EnsureUISwitch;

		// Token: 0x040313B4 RID: 201652
		[Token(Token = "0x40313B4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnTransitionEndInternal;

		// Token: 0x040313B5 RID: 201653
		[Token(Token = "0x40313B5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnTwComplete;

		// Token: 0x040313B6 RID: 201654
		[Token(Token = "0x40313B6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetUIState;

		// Token: 0x040313B7 RID: 201655
		[Token(Token = "0x40313B7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnFavCG;

		// Token: 0x040313B8 RID: 201656
		[Token(Token = "0x40313B8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnRemFavCG;

		// Token: 0x040313B9 RID: 201657
		[Token(Token = "0x40313B9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_EventOnNextClicked;

		// Token: 0x040313BA RID: 201658
		[Token(Token = "0x40313BA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_EventOnPrevClicked;

		// Token: 0x040313BB RID: 201659
		[Token(Token = "0x40313BB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_EventOnStoryClicked;

		// Token: 0x040313BC RID: 201660
		[Token(Token = "0x40313BC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_EventOnHideUIClicked;

		// Token: 0x040313BD RID: 201661
		[Token(Token = "0x40313BD")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040313BE RID: 201662
		[Token(Token = "0x40313BE")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
