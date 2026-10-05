using System;
using EaseFunctions;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006913 RID: 26899
	[Token(Token = "0x2006913")]
	public class StageMainZoneMapContainer : DataBinder<ZoneViewProperty>, IStageMainZoneMapController, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler, IDragHandler, IEndDragHandler, IWheelListener, IScrollHandler, IScrollNormalizedPosition
	{
		// Token: 0x17005AF9 RID: 23289
		// (get) Token: 0x0602687E RID: 157822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AF9")]
		public StageZoneDiffSelectHolder diffHolder
		{
			[Token(Token = "0x602687E")]
			[Address(RVA = "0x219A9B0", Offset = "0x21995B0", VA = "0x18219A9B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602687F RID: 157823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602687F")]
		[Address(RVA = "0x2197CF0", Offset = "0x21968F0", VA = "0x182197CF0")]
		private void OnEnable()
		{
		}

		// Token: 0x06026880 RID: 157824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026880")]
		[Address(RVA = "0x2197890", Offset = "0x2196490", VA = "0x182197890")]
		public void DoOnceAfterUpdate(Action work)
		{
		}

		// Token: 0x06026881 RID: 157825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026881")]
		[Address(RVA = "0x2199140", Offset = "0x2197D40", VA = "0x182199140")]
		private void _OnStageClicked(string stageId)
		{
		}

		// Token: 0x06026882 RID: 157826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026882")]
		[Address(RVA = "0x21991D0", Offset = "0x2197DD0", VA = "0x1821991D0")]
		private void _OnStageFogClicked(string stageId)
		{
		}

		// Token: 0x06026883 RID: 157827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026883")]
		[Address(RVA = "0x21990B0", Offset = "0x2197CB0", VA = "0x1821990B0")]
		private void _OnSpecialStageRewardClicked(string stageId)
		{
		}

		// Token: 0x06026884 RID: 157828 RVA: 0x000CB850 File Offset: 0x000C9A50
		[Token(Token = "0x6026884")]
		[Address(RVA = "0x2199F50", Offset = "0x2198B50", VA = "0x182199F50")]
		private float _UniformPositionValueViaMap(float positionVal)
		{
			return 0f;
		}

		// Token: 0x06026885 RID: 157829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026885")]
		[Address(RVA = "0x2198B50", Offset = "0x2197750", VA = "0x182198B50")]
		private void _FocusToStage(string stageId)
		{
		}

		// Token: 0x06026886 RID: 157830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026886")]
		[Address(RVA = "0x2198E10", Offset = "0x2197A10", VA = "0x182198E10")]
		private void _FocusToValue(float val)
		{
		}

		// Token: 0x06026887 RID: 157831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026887")]
		[Address(RVA = "0x2198AA0", Offset = "0x21976A0", VA = "0x182198AA0")]
		private void _FocusCancel()
		{
		}

		// Token: 0x06026888 RID: 157832 RVA: 0x000CB868 File Offset: 0x000C9A68
		[Token(Token = "0x6026888")]
		[Address(RVA = "0x2198EE0", Offset = "0x2197AE0", VA = "0x182198EE0")]
		private Vector2 _IntertiaProcess(Vector2 dualHist, float factor, float threshold)
		{
			return default(Vector2);
		}

		// Token: 0x06026889 RID: 157833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026889")]
		[Address(RVA = "0x219A380", Offset = "0x2198F80", VA = "0x18219A380")]
		private void _UpdateInertia()
		{
		}

		// Token: 0x0602688A RID: 157834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602688A")]
		[Address(RVA = "0x219A0B0", Offset = "0x2198CB0", VA = "0x18219A0B0")]
		private void _UpdateEaseMove()
		{
		}

		// Token: 0x0602688B RID: 157835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602688B")]
		[Address(RVA = "0x219A650", Offset = "0x2199250", VA = "0x18219A650")]
		private void _UpdatePositionTween()
		{
		}

		// Token: 0x0602688C RID: 157836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602688C")]
		[Address(RVA = "0x219A260", Offset = "0x2198E60", VA = "0x18219A260")]
		private void _UpdateExtensionOffsetMove()
		{
		}

		// Token: 0x0602688D RID: 157837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602688D")]
		[Address(RVA = "0x2198970", Offset = "0x2197570", VA = "0x182198970")]
		private void _ClearCachedMap()
		{
		}

		// Token: 0x0602688E RID: 157838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602688E")]
		[Address(RVA = "0x21989F0", Offset = "0x21975F0", VA = "0x1821989F0")]
		private void _ClearUpdateCache()
		{
		}

		// Token: 0x0602688F RID: 157839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602688F")]
		[Address(RVA = "0x21996F0", Offset = "0x21982F0", VA = "0x1821996F0")]
		private void _Setup(ZoneViewModel model)
		{
		}

		// Token: 0x06026890 RID: 157840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026890")]
		[Address(RVA = "0x2199C10", Offset = "0x2198810", VA = "0x182199C10")]
		private void _TweenPositionTo(float targetVal, float maxTweenDis = -1f)
		{
		}

		// Token: 0x06026891 RID: 157841 RVA: 0x000CB880 File Offset: 0x000C9A80
		[Token(Token = "0x6026891")]
		[Address(RVA = "0x2199260", Offset = "0x2197E60", VA = "0x182199260")]
		private bool _SetupZoneMapIfNeeded(ZoneViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026892 RID: 157842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026892")]
		[Address(RVA = "0x2198140", Offset = "0x2196D40", VA = "0x182198140", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x06026893 RID: 157843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026893")]
		[Address(RVA = "0x2198720", Offset = "0x2197320", VA = "0x182198720")]
		public void Update()
		{
		}

		// Token: 0x06026894 RID: 157844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026894")]
		[Address(RVA = "0x2197A80", Offset = "0x2196680", VA = "0x182197A80")]
		private void OnDestroy()
		{
		}

		// Token: 0x17005AFA RID: 23290
		// (get) Token: 0x06026895 RID: 157845 RVA: 0x000CB898 File Offset: 0x000C9A98
		[Token(Token = "0x17005AFA")]
		public float positionValue
		{
			[Token(Token = "0x6026895")]
			[Address(RVA = "0x219AB90", Offset = "0x2199790", VA = "0x18219AB90", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17005AFB RID: 23291
		// (get) Token: 0x06026896 RID: 157846 RVA: 0x000CB8B0 File Offset: 0x000C9AB0
		[Token(Token = "0x17005AFB")]
		public float backgroundImageRefValue
		{
			[Token(Token = "0x6026896")]
			[Address(RVA = "0x219A940", Offset = "0x2199540", VA = "0x18219A940", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06026897 RID: 157847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026897")]
		[Address(RVA = "0x2197990", Offset = "0x2196590", VA = "0x182197990", Slot = "10")]
		public UIPage GetPage()
		{
			return null;
		}

		// Token: 0x06026898 RID: 157848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026898")]
		[Address(RVA = "0x2198020", Offset = "0x2196C20", VA = "0x182198020", Slot = "11")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		// Token: 0x06026899 RID: 157849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026899")]
		[Address(RVA = "0x2197F10", Offset = "0x2196B10", VA = "0x182197F10", Slot = "14")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		// Token: 0x0602689A RID: 157850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602689A")]
		[Address(RVA = "0x2197F80", Offset = "0x2196B80", VA = "0x182197F80", Slot = "12")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		// Token: 0x0602689B RID: 157851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602689B")]
		[Address(RVA = "0x2197AE0", Offset = "0x21966E0", VA = "0x182197AE0", Slot = "13")]
		public void OnDrag(PointerEventData data)
		{
		}

		// Token: 0x0602689C RID: 157852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602689C")]
		[Address(RVA = "0x2198FC0", Offset = "0x2197BC0", VA = "0x182198FC0")]
		private void _OnScroll(Vector2 delta)
		{
		}

		// Token: 0x0602689D RID: 157853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602689D")]
		[Address(RVA = "0x2197710", Offset = "0x2196310", VA = "0x182197710")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x0602689E RID: 157854 RVA: 0x000CB8C8 File Offset: 0x000C9AC8
		[Token(Token = "0x602689E")]
		[Address(RVA = "0x2197A20", Offset = "0x2196620", VA = "0x182197A20", Slot = "15")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x0602689F RID: 157855 RVA: 0x000CB8E0 File Offset: 0x000C9AE0
		[Token(Token = "0x602689F")]
		[Address(RVA = "0x2198480", Offset = "0x2197080", VA = "0x182198480", Slot = "16")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x060268A0 RID: 157856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268A0")]
		[Address(RVA = "0x21980B0", Offset = "0x2196CB0", VA = "0x1821980B0", Slot = "17")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x17005AFC RID: 23292
		// (get) Token: 0x060268A1 RID: 157857 RVA: 0x000CB8F8 File Offset: 0x000C9AF8
		[Token(Token = "0x17005AFC")]
		private Vector2 position
		{
			[Token(Token = "0x60268A1")]
			[Address(RVA = "0x2198510", Offset = "0x2197110", VA = "0x182198510", Slot = "18")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060268A2 RID: 157858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268A2")]
		[Address(RVA = "0x219A810", Offset = "0x2199410", VA = "0x18219A810")]
		public StageMainZoneMapContainer()
		{
		}

		// Token: 0x04036541 RID: 222529
		[Token(Token = "0x4036541")]
		private const float POS_TWEEN_SPEED = 2000f;

		// Token: 0x04036542 RID: 222530
		[Token(Token = "0x4036542")]
		private const float POS_TWEEN_MIN_DUR = 0.16f;

		// Token: 0x04036543 RID: 222531
		[Token(Token = "0x4036543")]
		private const float INIT_POS_TWEEN_MAX_DIS = 600f;

		// Token: 0x04036544 RID: 222532
		[Token(Token = "0x4036544")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageMainZoneMapContainer.StageClickEvent _stageSelectEvent;

		// Token: 0x04036545 RID: 222533
		[Token(Token = "0x4036545")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _dragFactor;

		// Token: 0x04036546 RID: 222534
		[Token(Token = "0x4036546")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _easeMoveCurve;

		// Token: 0x04036547 RID: 222535
		[Token(Token = "0x4036547")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _easeMoveDuration;

		// Token: 0x04036548 RID: 222536
		[Token(Token = "0x4036548")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _ineriaFactor;

		// Token: 0x04036549 RID: 222537
		[Token(Token = "0x4036549")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _ineriaIteratorPeriod;

		// Token: 0x0403654A RID: 222538
		[Token(Token = "0x403654A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStringEvent _stageFogUnlockEvent;

		// Token: 0x0403654B RID: 222539
		[Token(Token = "0x403654B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _diffHolderContainer;

		// Token: 0x0403654C RID: 222540
		[Token(Token = "0x403654C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIDiffGroupEvent _selectDiffAction;

		// Token: 0x0403654D RID: 222541
		[Token(Token = "0x403654D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UnityEvent _onDiffSelectDetail;

		// Token: 0x0403654E RID: 222542
		[Token(Token = "0x403654E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UnityEvent _onAddedReceiveCacheEvent;

		// Token: 0x0403654F RID: 222543
		[Token(Token = "0x403654F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _scrollSen;

		// Token: 0x04036550 RID: 222544
		[Token(Token = "0x4036550")]
		[FieldOffset(Offset = "0x78")]
		private StageZoneDiffSelectHolder m_diffHolder;

		// Token: 0x04036551 RID: 222545
		[Token(Token = "0x4036551")]
		[FieldOffset(Offset = "0x80")]
		private Action<string> _specialStageRewardEvent;

		// Token: 0x04036552 RID: 222546
		[Token(Token = "0x4036552")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIStringEvent _eventMapNotFound;

		// Token: 0x04036553 RID: 222547
		[Token(Token = "0x4036553")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIStringEvent _eventMapLoadFinish;

		// Token: 0x04036554 RID: 222548
		[Token(Token = "0x4036554")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _mapContainer;

		// Token: 0x04036555 RID: 222549
		[Token(Token = "0x4036555")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Tooltip("Area for stage buttons to focus into")]
		private RectTransform _focusBound;

		// Token: 0x04036556 RID: 222550
		[Token(Token = "0x4036556")]
		[FieldOffset(Offset = "0xA8")]
		private Vector2 m_dragOrigin;

		// Token: 0x04036557 RID: 222551
		[Token(Token = "0x4036557")]
		[FieldOffset(Offset = "0xB0")]
		private float m_positionValue;

		// Token: 0x04036558 RID: 222552
		[Token(Token = "0x4036558")]
		[FieldOffset(Offset = "0xB8")]
		private StageMainZoneMap m_mainZoneMap;

		// Token: 0x04036559 RID: 222553
		[Token(Token = "0x4036559")]
		[FieldOffset(Offset = "0xC0")]
		private string m_zoneMapAssetPathCache;

		// Token: 0x0403655A RID: 222554
		[Token(Token = "0x403655A")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_pressing;

		// Token: 0x0403655B RID: 222555
		[Token(Token = "0x403655B")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_dragging;

		// Token: 0x0403655C RID: 222556
		[Token(Token = "0x403655C")]
		[FieldOffset(Offset = "0xD0")]
		private string m_currentZoneId;

		// Token: 0x0403655D RID: 222557
		[Token(Token = "0x403655D")]
		[FieldOffset(Offset = "0xD8")]
		private StageDiffGroup m_cacheDiffGroup;

		// Token: 0x0403655E RID: 222558
		[Token(Token = "0x403655E")]
		[FieldOffset(Offset = "0xE0")]
		private string m_focusedStageId;

		// Token: 0x0403655F RID: 222559
		[Token(Token = "0x403655F")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_focus;

		// Token: 0x04036560 RID: 222560
		[Token(Token = "0x4036560")]
		[FieldOffset(Offset = "0xF0")]
		private double m_easeMoveBaseTime;

		// Token: 0x04036561 RID: 222561
		[Token(Token = "0x4036561")]
		[FieldOffset(Offset = "0xF8")]
		private float m_easeMoveVal0;

		// Token: 0x04036562 RID: 222562
		[Token(Token = "0x4036562")]
		[FieldOffset(Offset = "0xFC")]
		private float m_easeMoveVal1;

		// Token: 0x04036563 RID: 222563
		[Token(Token = "0x4036563")]
		[FieldOffset(Offset = "0x100")]
		private float m_extensionOffset;

		// Token: 0x04036564 RID: 222564
		[Token(Token = "0x4036564")]
		[FieldOffset(Offset = "0x104")]
		private float m_extensionBaseTime;

		// Token: 0x04036565 RID: 222565
		[Token(Token = "0x4036565")]
		[FieldOffset(Offset = "0x108")]
		private float m_extensionOffsetMoveVal0;

		// Token: 0x04036566 RID: 222566
		[Token(Token = "0x4036566")]
		[FieldOffset(Offset = "0x10C")]
		private float m_lastPositionValue;

		// Token: 0x04036567 RID: 222567
		[Token(Token = "0x4036567")]
		[FieldOffset(Offset = "0x110")]
		private ScrollWheelHandler m_handler;

		// Token: 0x04036568 RID: 222568
		[Token(Token = "0x4036568")]
		[FieldOffset(Offset = "0x118")]
		private StageMainZoneMapContainer.PositionTween m_posTween;

		// Token: 0x04036569 RID: 222569
		[Token(Token = "0x4036569")]
		[FieldOffset(Offset = "0x138")]
		private UIPageListener m_pageListener;

		// Token: 0x0403656A RID: 222570
		[Token(Token = "0x403656A")]
		[FieldOffset(Offset = "0x140")]
		private Action m_onceWorkAfterUpdate;

		// Token: 0x0403656B RID: 222571
		[Token(Token = "0x403656B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_diffHolder;

		// Token: 0x0403656C RID: 222572
		[Token(Token = "0x403656C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403656D RID: 222573
		[Token(Token = "0x403656D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoOnceAfterUpdate;

		// Token: 0x0403656E RID: 222574
		[Token(Token = "0x403656E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnStageClicked;

		// Token: 0x0403656F RID: 222575
		[Token(Token = "0x403656F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnStageFogClicked;

		// Token: 0x04036570 RID: 222576
		[Token(Token = "0x4036570")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSpecialStageRewardClicked;

		// Token: 0x04036571 RID: 222577
		[Token(Token = "0x4036571")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UniformPositionValueViaMap;

		// Token: 0x04036572 RID: 222578
		[Token(Token = "0x4036572")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FocusToStage;

		// Token: 0x04036573 RID: 222579
		[Token(Token = "0x4036573")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FocusToValue;

		// Token: 0x04036574 RID: 222580
		[Token(Token = "0x4036574")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FocusCancel;

		// Token: 0x04036575 RID: 222581
		[Token(Token = "0x4036575")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__IntertiaProcess;

		// Token: 0x04036576 RID: 222582
		[Token(Token = "0x4036576")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateInertia;

		// Token: 0x04036577 RID: 222583
		[Token(Token = "0x4036577")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateEaseMove;

		// Token: 0x04036578 RID: 222584
		[Token(Token = "0x4036578")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdatePositionTween;

		// Token: 0x04036579 RID: 222585
		[Token(Token = "0x4036579")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateExtensionOffsetMove;

		// Token: 0x0403657A RID: 222586
		[Token(Token = "0x403657A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ClearCachedMap;

		// Token: 0x0403657B RID: 222587
		[Token(Token = "0x403657B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearUpdateCache;

		// Token: 0x0403657C RID: 222588
		[Token(Token = "0x403657C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__Setup;

		// Token: 0x0403657D RID: 222589
		[Token(Token = "0x403657D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TweenPositionTo;

		// Token: 0x0403657E RID: 222590
		[Token(Token = "0x403657E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SetupZoneMapIfNeeded;

		// Token: 0x0403657F RID: 222591
		[Token(Token = "0x403657F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036580 RID: 222592
		[Token(Token = "0x4036580")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04036581 RID: 222593
		[Token(Token = "0x4036581")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04036582 RID: 222594
		[Token(Token = "0x4036582")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_positionValue;

		// Token: 0x04036583 RID: 222595
		[Token(Token = "0x4036583")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_backgroundImageRefValue;

		// Token: 0x04036584 RID: 222596
		[Token(Token = "0x4036584")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetPage;

		// Token: 0x04036585 RID: 222597
		[Token(Token = "0x4036585")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnPointerUp;

		// Token: 0x04036586 RID: 222598
		[Token(Token = "0x4036586")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x04036587 RID: 222599
		[Token(Token = "0x4036587")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x04036588 RID: 222600
		[Token(Token = "0x4036588")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x04036589 RID: 222601
		[Token(Token = "0x4036589")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnScroll;

		// Token: 0x0403658A RID: 222602
		[Token(Token = "0x403658A")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0403658B RID: 222603
		[Token(Token = "0x403658B")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x0403658C RID: 222604
		[Token(Token = "0x403658C")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x0403658D RID: 222605
		[Token(Token = "0x403658D")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x0403658E RID: 222606
		[Token(Token = "0x403658E")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge get_position;

		// Token: 0x0403658F RID: 222607
		[Token(Token = "0x403658F")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006914 RID: 26900
		[Token(Token = "0x2006914")]
		private struct PositionTween
		{
			// Token: 0x17005AFD RID: 23293
			// (get) Token: 0x060268A3 RID: 157859 RVA: 0x000CB910 File Offset: 0x000C9B10
			[Token(Token = "0x17005AFD")]
			public bool isEmpty
			{
				[Token(Token = "0x60268A3")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060268A4 RID: 157860 RVA: 0x000CB928 File Offset: 0x000C9B28
			[Token(Token = "0x60268A4")]
			[Address(RVA = "0x2195310", Offset = "0x2193F10", VA = "0x182195310")]
			public static StageMainZoneMapContainer.PositionTween StartTween(float startVal, float endVal, float seconds, Interpolator.EaseType easeType = Interpolator.EaseType.easeInOutQuad)
			{
				return default(StageMainZoneMapContainer.PositionTween);
			}

			// Token: 0x04036590 RID: 222608
			[Token(Token = "0x4036590")]
			[FieldOffset(Offset = "0x0")]
			public static readonly StageMainZoneMapContainer.PositionTween EMPTY;

			// Token: 0x04036591 RID: 222609
			[Token(Token = "0x4036591")]
			[FieldOffset(Offset = "0x0")]
			private bool m_isEmpty;

			// Token: 0x04036592 RID: 222610
			[Token(Token = "0x4036592")]
			[FieldOffset(Offset = "0x4")]
			public float startVal;

			// Token: 0x04036593 RID: 222611
			[Token(Token = "0x4036593")]
			[FieldOffset(Offset = "0x8")]
			public float endVal;

			// Token: 0x04036594 RID: 222612
			[Token(Token = "0x4036594")]
			[FieldOffset(Offset = "0xC")]
			public float startTime;

			// Token: 0x04036595 RID: 222613
			[Token(Token = "0x4036595")]
			[FieldOffset(Offset = "0x10")]
			public float endTime;

			// Token: 0x04036596 RID: 222614
			[Token(Token = "0x4036596")]
			[FieldOffset(Offset = "0x18")]
			public Interpolator.EasingFunction easeFunc;
		}

		// Token: 0x02006915 RID: 26901
		[Token(Token = "0x2006915")]
		[Serializable]
		public class StageClickEvent : UnityEvent<string>
		{
			// Token: 0x060268A6 RID: 157862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60268A6")]
			[Address(RVA = "0x21976D0", Offset = "0x21962D0", VA = "0x1821976D0")]
			public StageClickEvent()
			{
			}
		}
	}
}
