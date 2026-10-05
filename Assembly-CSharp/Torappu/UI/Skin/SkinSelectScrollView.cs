using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EE8 RID: 16104
	[Token(Token = "0x2003EE8")]
	public class SkinSelectScrollView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IHotfixable, IScrollHandler, IWheelListener
	{
		// Token: 0x06018FA6 RID: 102310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FA6")]
		[Address(RVA = "0x11A0F90", Offset = "0x119FB90", VA = "0x1811A0F90")]
		private void OnEnable()
		{
		}

		// Token: 0x06018FA7 RID: 102311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FA7")]
		[Address(RVA = "0x11A1280", Offset = "0x119FE80", VA = "0x1811A1280")]
		public void RefreshDetailView()
		{
		}

		// Token: 0x06018FA8 RID: 102312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FA8")]
		[Address(RVA = "0x11A0980", Offset = "0x119F580", VA = "0x1811A0980")]
		public void InitData(List<SkinSelectViewModel> viewModelList, string focusSkinId, UIPage page)
		{
		}

		// Token: 0x06018FA9 RID: 102313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FA9")]
		[Address(RVA = "0x11A1690", Offset = "0x11A0290", VA = "0x1811A1690")]
		public void TweenToState(float state)
		{
		}

		// Token: 0x06018FAA RID: 102314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FAA")]
		[Address(RVA = "0x11A0DA0", Offset = "0x119F9A0", VA = "0x1811A0DA0", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06018FAB RID: 102315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FAB")]
		[Address(RVA = "0x11A0E70", Offset = "0x119FA70", VA = "0x1811A0E70", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06018FAC RID: 102316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FAC")]
		[Address(RVA = "0x11A0250", Offset = "0x119EE50", VA = "0x1811A0250")]
		public void ApplyState(float state, float trickState = -1f)
		{
		}

		// Token: 0x06018FAD RID: 102317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FAD")]
		[Address(RVA = "0x11A1AC0", Offset = "0x11A06C0", VA = "0x1811A1AC0")]
		public void Update()
		{
		}

		// Token: 0x06018FAE RID: 102318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018FAE")]
		[Address(RVA = "0x11A2530", Offset = "0x11A1130", VA = "0x1811A2530")]
		private IEnumerator _ToState(float startTarget, float finishTarget, int count = 5)
		{
			return null;
		}

		// Token: 0x06018FAF RID: 102319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018FAF")]
		[Address(RVA = "0x11A2420", Offset = "0x11A1020", VA = "0x1811A2420")]
		private IEnumerator _ToStateTrick(float startTarget, float finishTarget, int count, Action finishAction)
		{
			return null;
		}

		// Token: 0x06018FB0 RID: 102320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FB0")]
		[Address(RVA = "0x11A1180", Offset = "0x119FD80", VA = "0x1811A1180", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06018FB1 RID: 102321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FB1")]
		[Address(RVA = "0x11A1B40", Offset = "0x11A0740", VA = "0x1811A1B40")]
		private void _DoEndDrag()
		{
		}

		// Token: 0x06018FB2 RID: 102322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FB2")]
		[Address(RVA = "0x11A1E60", Offset = "0x11A0A60", VA = "0x1811A1E60")]
		private void _RefreshLeftView(int state)
		{
		}

		// Token: 0x06018FB3 RID: 102323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FB3")]
		[Address(RVA = "0x11A1310", Offset = "0x119FF10", VA = "0x1811A1310")]
		public void SetSkinIllustsVisible(bool isVisible)
		{
		}

		// Token: 0x06018FB4 RID: 102324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018FB4")]
		[Address(RVA = "0x11A2620", Offset = "0x11A1220", VA = "0x1811A2620")]
		private SkinSelectViewModel _TryGetViewModel(float index)
		{
			return null;
		}

		// Token: 0x06018FB5 RID: 102325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018FB5")]
		[Address(RVA = "0x11A1630", Offset = "0x11A0230", VA = "0x1811A1630")]
		public SkinSelectViewModel TryGetCurrentSkinModel()
		{
			return null;
		}

		// Token: 0x06018FB6 RID: 102326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FB6")]
		[Address(RVA = "0x11A07E0", Offset = "0x119F3E0", VA = "0x1811A07E0")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x06018FB7 RID: 102327 RVA: 0x0009C810 File Offset: 0x0009AA10
		[Token(Token = "0x6018FB7")]
		[Address(RVA = "0x11A0920", Offset = "0x119F520", VA = "0x1811A0920", Slot = "8")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x06018FB8 RID: 102328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FB8")]
		[Address(RVA = "0x11A1530", Offset = "0x11A0130", VA = "0x1811A1530")]
		public void TriggerListener(Vector2 scrollDelta)
		{
		}

		// Token: 0x06018FB9 RID: 102329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FB9")]
		[Address(RVA = "0x11A11F0", Offset = "0x119FDF0", VA = "0x1811A11F0", Slot = "7")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x06018FBA RID: 102330 RVA: 0x0009C828 File Offset: 0x0009AA28
		[Token(Token = "0x6018FBA")]
		[Address(RVA = "0x11A14A0", Offset = "0x11A00A0", VA = "0x1811A14A0", Slot = "9")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x06018FBB RID: 102331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FBB")]
		[Address(RVA = "0x11A2700", Offset = "0x11A1300", VA = "0x1811A2700")]
		public SkinSelectScrollView()
		{
		}

		// Token: 0x0401EDBC RID: 126396
		[Token(Token = "0x401EDBC")]
		private const string DEFAULT_SKIN_GROUP_ID = "DEFAULT";

		// Token: 0x0401EDBD RID: 126397
		[Token(Token = "0x401EDBD")]
		[FieldOffset(Offset = "0x18")]
		private List<SkinSelectScrollItemView> m_itemViewLists;

		// Token: 0x0401EDBE RID: 126398
		[Token(Token = "0x401EDBE")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, SkinGroupCommonView> m_commonViewList;

		// Token: 0x0401EDBF RID: 126399
		[Token(Token = "0x401EDBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x0401EDC0 RID: 126400
		[Token(Token = "0x401EDC0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _scrollItemContainer;

		// Token: 0x0401EDC1 RID: 126401
		[Token(Token = "0x401EDC1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SkinSelectGroupView _groupView;

		// Token: 0x0401EDC2 RID: 126402
		[Token(Token = "0x401EDC2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SkinSelectScrollItemView _scrollItemView;

		// Token: 0x0401EDC3 RID: 126403
		[Token(Token = "0x401EDC3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SkinSelectDetailView _detailView;

		// Token: 0x0401EDC4 RID: 126404
		[Token(Token = "0x401EDC4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("arrow")]
		private GameObject _leftArrow;

		// Token: 0x0401EDC5 RID: 126405
		[Token(Token = "0x401EDC5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("arrow")]
		private GameObject _rightArrow;

		// Token: 0x0401EDC6 RID: 126406
		[Token(Token = "0x401EDC6")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public float m_state;

		// Token: 0x0401EDC7 RID: 126407
		[Token(Token = "0x401EDC7")]
		[FieldOffset(Offset = "0x64")]
		[NonSerialized]
		public bool shopTitleBarFlag;

		// Token: 0x0401EDC8 RID: 126408
		[Token(Token = "0x401EDC8")]
		[FieldOffset(Offset = "0x68")]
		private ScrollWheelHandler m_scrollWheelHandler;

		// Token: 0x0401EDC9 RID: 126409
		[Token(Token = "0x401EDC9")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 m_startPoint;

		// Token: 0x0401EDCA RID: 126410
		[Token(Token = "0x401EDCA")]
		[FieldOffset(Offset = "0x78")]
		private float m_startState;

		// Token: 0x0401EDCB RID: 126411
		[Token(Token = "0x401EDCB")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_dragFlag;

		// Token: 0x0401EDCC RID: 126412
		[Token(Token = "0x401EDCC")]
		[FieldOffset(Offset = "0x80")]
		private DateTime m_startClickTime;

		// Token: 0x0401EDCD RID: 126413
		[Token(Token = "0x401EDCD")]
		public const int MAX_ITEM_COUNT = 9;

		// Token: 0x0401EDCE RID: 126414
		[Token(Token = "0x401EDCE")]
		public const int MID_ITEM_INDEX = 4;

		// Token: 0x0401EDCF RID: 126415
		[Token(Token = "0x401EDCF")]
		public const int REMOVE_LENGTH = 4;

		// Token: 0x0401EDD0 RID: 126416
		[Token(Token = "0x401EDD0")]
		public const int DELTA_TIME = 5;

		// Token: 0x0401EDD1 RID: 126417
		[Token(Token = "0x401EDD1")]
		public const int DELTA_TIME_CLICK = 15;

		// Token: 0x0401EDD2 RID: 126418
		[Token(Token = "0x401EDD2")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<int, SkinGroupCommonView> m_viewLists;

		// Token: 0x0401EDD3 RID: 126419
		[Token(Token = "0x401EDD3")]
		[FieldOffset(Offset = "0x90")]
		private List<SkinSelectViewModel> m_viewModelListCache;

		// Token: 0x0401EDD4 RID: 126420
		[Token(Token = "0x401EDD4")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0401EDD5 RID: 126421
		[Token(Token = "0x401EDD5")]
		[FieldOffset(Offset = "0xA0")]
		private UIPage m_page;

		// Token: 0x0401EDD6 RID: 126422
		[Token(Token = "0x401EDD6")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EDD7 RID: 126423
		[Token(Token = "0x401EDD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401EDD8 RID: 126424
		[Token(Token = "0x401EDD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshDetailView;

		// Token: 0x0401EDD9 RID: 126425
		[Token(Token = "0x401EDD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401EDDA RID: 126426
		[Token(Token = "0x401EDDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TweenToState;

		// Token: 0x0401EDDB RID: 126427
		[Token(Token = "0x401EDDB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0401EDDC RID: 126428
		[Token(Token = "0x401EDDC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0401EDDD RID: 126429
		[Token(Token = "0x401EDDD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyState;

		// Token: 0x0401EDDE RID: 126430
		[Token(Token = "0x401EDDE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401EDDF RID: 126431
		[Token(Token = "0x401EDDF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ToState;

		// Token: 0x0401EDE0 RID: 126432
		[Token(Token = "0x401EDE0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ToStateTrick;

		// Token: 0x0401EDE1 RID: 126433
		[Token(Token = "0x401EDE1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x0401EDE2 RID: 126434
		[Token(Token = "0x401EDE2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoEndDrag;

		// Token: 0x0401EDE3 RID: 126435
		[Token(Token = "0x401EDE3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RefreshLeftView;

		// Token: 0x0401EDE4 RID: 126436
		[Token(Token = "0x401EDE4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetSkinIllustsVisible;

		// Token: 0x0401EDE5 RID: 126437
		[Token(Token = "0x401EDE5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryGetViewModel;

		// Token: 0x0401EDE6 RID: 126438
		[Token(Token = "0x401EDE6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryGetCurrentSkinModel;

		// Token: 0x0401EDE7 RID: 126439
		[Token(Token = "0x401EDE7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0401EDE8 RID: 126440
		[Token(Token = "0x401EDE8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x0401EDE9 RID: 126441
		[Token(Token = "0x401EDE9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_TriggerListener;

		// Token: 0x0401EDEA RID: 126442
		[Token(Token = "0x401EDEA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x0401EDEB RID: 126443
		[Token(Token = "0x401EDEB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x0401EDEC RID: 126444
		[Token(Token = "0x401EDEC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
