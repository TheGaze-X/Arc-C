using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039AB RID: 14763
	[Token(Token = "0x20039AB")]
	[RequireComponent(typeof(ScrollRect))]
	public class ScrollViewPager : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, ITimeWatcher, IHotfixable, IWheelListener
	{
		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0601754B RID: 95563 RVA: 0x00096078 File Offset: 0x00094278
		// (set) Token: 0x0601754C RID: 95564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037E5")]
		[Inspect]
		protected bool _enableDrag
		{
			[Token(Token = "0x601754B")]
			[Address(RVA = "0xFB56C0", Offset = "0xFB42C0", VA = "0x180FB56C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601754C")]
			[Address(RVA = "0xFB58E0", Offset = "0xFB44E0", VA = "0x180FB58E0")]
			set
			{
			}
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0601754D RID: 95565 RVA: 0x00096090 File Offset: 0x00094290
		[Token(Token = "0x170037E6")]
		public float scrollState
		{
			[Token(Token = "0x601754D")]
			[Address(RVA = "0xFB5850", Offset = "0xFB4450", VA = "0x180FB5850")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0601754E RID: 95566 RVA: 0x000960A8 File Offset: 0x000942A8
		[Token(Token = "0x170037E7")]
		public bool isUpdating
		{
			[Token(Token = "0x601754E")]
			[Address(RVA = "0xFB5780", Offset = "0xFB4380", VA = "0x180FB5780")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0601754F RID: 95567 RVA: 0x000960C0 File Offset: 0x000942C0
		// (set) Token: 0x06017550 RID: 95568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037E8")]
		public int pageCount
		{
			[Token(Token = "0x601754F")]
			[Address(RVA = "0xFB57F0", Offset = "0xFB43F0", VA = "0x180FB57F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6017550")]
			[Address(RVA = "0xFB5A40", Offset = "0xFB4640", VA = "0x180FB5A40")]
			set
			{
			}
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x06017551 RID: 95569 RVA: 0x000960D8 File Offset: 0x000942D8
		// (set) Token: 0x06017552 RID: 95570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037E9")]
		public int currentPage
		{
			[Token(Token = "0x6017551")]
			[Address(RVA = "0xFB5720", Offset = "0xFB4320", VA = "0x180FB5720")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6017552")]
			[Address(RVA = "0xFB59C0", Offset = "0xFB45C0", VA = "0x180FB59C0")]
			set
			{
			}
		}

		// Token: 0x06017553 RID: 95571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017553")]
		[Address(RVA = "0xFB4BF0", Offset = "0xFB37F0", VA = "0x180FB4BF0")]
		public void SetEnableDragFlag(bool flag)
		{
		}

		// Token: 0x06017554 RID: 95572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017554")]
		[Address(RVA = "0xFB3FA0", Offset = "0xFB2BA0", VA = "0x180FB3FA0")]
		public void AddUpdatingListener(Action<float> listener)
		{
		}

		// Token: 0x06017555 RID: 95573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017555")]
		[Address(RVA = "0xFB4B00", Offset = "0xFB3700", VA = "0x180FB4B00")]
		public void RemoveUpdatingListener(Action<float> listener)
		{
		}

		// Token: 0x06017556 RID: 95574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017556")]
		[Address(RVA = "0xFB3E10", Offset = "0xFB2A10", VA = "0x180FB3E10")]
		public void AddPageIndexListener(Action<int> listener)
		{
		}

		// Token: 0x06017557 RID: 95575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017557")]
		[Address(RVA = "0xFB4A10", Offset = "0xFB3610", VA = "0x180FB4A10")]
		public void RemovePageIndexListener(Action<int> listener)
		{
		}

		// Token: 0x06017558 RID: 95576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017558")]
		[Address(RVA = "0xFB3C90", Offset = "0xFB2890", VA = "0x180FB3C90")]
		public void AddPageIndexChangedListener(Action<int> listener)
		{
		}

		// Token: 0x06017559 RID: 95577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017559")]
		[Address(RVA = "0xFB4910", Offset = "0xFB3510", VA = "0x180FB4910")]
		public void RemovePageIndexChangedListener(Action<int> listener)
		{
		}

		// Token: 0x0601755A RID: 95578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601755A")]
		[Address(RVA = "0xFB4F20", Offset = "0xFB3B20", VA = "0x180FB4F20", Slot = "7")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x0601755B RID: 95579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601755B")]
		[Address(RVA = "0xFB4350", Offset = "0xFB2F50", VA = "0x180FB4350", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601755C RID: 95580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601755C")]
		[Address(RVA = "0xFB3630", Offset = "0xFB2230", VA = "0x180FB3630", Slot = "10")]
		protected virtual void _OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601755D RID: 95581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601755D")]
		[Address(RVA = "0xFB4880", Offset = "0xFB3480", VA = "0x180FB4880", Slot = "5")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601755E RID: 95582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601755E")]
		[Address(RVA = "0xFB3700", Offset = "0xFB2300", VA = "0x180FB3700", Slot = "11")]
		protected virtual void _OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601755F RID: 95583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601755F")]
		[Address(RVA = "0xFB45B0", Offset = "0xFB31B0", VA = "0x180FB45B0", Slot = "6")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06017560 RID: 95584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017560")]
		[Address(RVA = "0xFB42D0", Offset = "0xFB2ED0", VA = "0x180FB42D0")]
		public void MoveToPage(int pageIndex)
		{
		}

		// Token: 0x06017561 RID: 95585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017561")]
		[Address(RVA = "0xFB4640", Offset = "0xFB3240", VA = "0x180FB4640")]
		private void OnEnable()
		{
		}

		// Token: 0x06017562 RID: 95586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017562")]
		[Address(RVA = "0xFB4410", Offset = "0xFB3010", VA = "0x180FB4410")]
		private void OnDisable()
		{
		}

		// Token: 0x06017563 RID: 95587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017563")]
		[Address(RVA = "0xFB5370", Offset = "0xFB3F70", VA = "0x180FB5370")]
		private void _ReleaseDragWhenDisabled()
		{
		}

		// Token: 0x06017564 RID: 95588 RVA: 0x000960F0 File Offset: 0x000942F0
		[Token(Token = "0x6017564")]
		[Address(RVA = "0xFB37E0", Offset = "0xFB23E0", VA = "0x180FB37E0", Slot = "12")]
		protected virtual float _ScrollValue2PageIndex(float value)
		{
			return 0f;
		}

		// Token: 0x06017565 RID: 95589 RVA: 0x00096108 File Offset: 0x00094308
		[Token(Token = "0x6017565")]
		[Address(RVA = "0xFB52E0", Offset = "0xFB3EE0", VA = "0x180FB52E0")]
		private float _PageIndex2ScrollValue(float index)
		{
			return 0f;
		}

		// Token: 0x06017566 RID: 95590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017566")]
		[Address(RVA = "0xFB54C0", Offset = "0xFB40C0", VA = "0x180FB54C0")]
		protected void _SwitchToPage(int targetIndex, bool useTween)
		{
		}

		// Token: 0x06017567 RID: 95591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017567")]
		[Address(RVA = "0xFB5120", Offset = "0xFB3D20", VA = "0x180FB5120")]
		[Inspect(InspectorLevel.Debug)]
		protected void _AutoAlign()
		{
		}

		// Token: 0x06017568 RID: 95592 RVA: 0x00096120 File Offset: 0x00094320
		[Token(Token = "0x6017568")]
		[Address(RVA = "0xFB51D0", Offset = "0xFB3DD0", VA = "0x180FB51D0")]
		private bool _CheckPageDirtyElastical(int pageIndex)
		{
			return default(bool);
		}

		// Token: 0x06017569 RID: 95593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017569")]
		[Address(RVA = "0xFB4130", Offset = "0xFB2D30", VA = "0x180FB4130")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x0601756A RID: 95594 RVA: 0x00096138 File Offset: 0x00094338
		[Token(Token = "0x601756A")]
		[Address(RVA = "0xFB4270", Offset = "0xFB2E70", VA = "0x180FB4270", Slot = "8")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x0601756B RID: 95595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601756B")]
		[Address(RVA = "0xFB4D70", Offset = "0xFB3970", VA = "0x180FB4D70")]
		public void TriggerListener(Vector2 scrollDelta)
		{
		}

		// Token: 0x0601756C RID: 95596 RVA: 0x00096150 File Offset: 0x00094350
		[Token(Token = "0x601756C")]
		[Address(RVA = "0xFB4CE0", Offset = "0xFB38E0", VA = "0x180FB4CE0", Slot = "9")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x0601756D RID: 95597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601756D")]
		[Address(RVA = "0xFB5650", Offset = "0xFB4250", VA = "0x180FB5650")]
		public ScrollViewPager()
		{
		}

		// Token: 0x0401C295 RID: 115349
		[Token(Token = "0x401C295")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The scroll bar used to control the scroll view")]
		private Scrollbar _scrollbar;

		// Token: 0x0401C296 RID: 115350
		[Token(Token = "0x401C296")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 2f)]
		[Toolbar("Animation duration for page switch and rollback")]
		private float _animationDuration;

		// Token: 0x0401C297 RID: 115351
		[Token(Token = "0x401C297")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Component _scrollView;

		// Token: 0x0401C298 RID: 115352
		[Token(Token = "0x401C298")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private bool m_enableDrag;

		// Token: 0x0401C299 RID: 115353
		[Token(Token = "0x401C299")]
		[FieldOffset(Offset = "0x34")]
		protected int m_pageCount;

		// Token: 0x0401C29A RID: 115354
		[Token(Token = "0x401C29A")]
		[FieldOffset(Offset = "0x38")]
		protected int m_currentPage;

		// Token: 0x0401C29B RID: 115355
		[Token(Token = "0x401C29B")]
		[FieldOffset(Offset = "0x3C")]
		private float m_lastUpdateTime;

		// Token: 0x0401C29C RID: 115356
		[Token(Token = "0x401C29C")]
		[FieldOffset(Offset = "0x40")]
		protected bool m_isDragging;

		// Token: 0x0401C29D RID: 115357
		[Token(Token = "0x401C29D")]
		[FieldOffset(Offset = "0x48")]
		private PointerEventData m_lastActiveDrag;

		// Token: 0x0401C29E RID: 115358
		[Token(Token = "0x401C29E")]
		[FieldOffset(Offset = "0x50")]
		private int m_fromPage;

		// Token: 0x0401C29F RID: 115359
		[Token(Token = "0x401C29F")]
		[FieldOffset(Offset = "0x54")]
		private int m_toPage;

		// Token: 0x0401C2A0 RID: 115360
		[Token(Token = "0x401C2A0")]
		[FieldOffset(Offset = "0x58")]
		private float m_tweenStartTime;

		// Token: 0x0401C2A1 RID: 115361
		[Token(Token = "0x401C2A1")]
		[FieldOffset(Offset = "0x5C")]
		private float m_tweenStartValue;

		// Token: 0x0401C2A2 RID: 115362
		[Token(Token = "0x401C2A2")]
		[FieldOffset(Offset = "0x60")]
		private float m_tweenTargetValue;

		// Token: 0x0401C2A3 RID: 115363
		[Token(Token = "0x401C2A3")]
		[FieldOffset(Offset = "0x64")]
		private bool m_tweenScrollDirty;

		// Token: 0x0401C2A4 RID: 115364
		[Token(Token = "0x401C2A4")]
		[FieldOffset(Offset = "0x65")]
		protected bool m_isTweening;

		// Token: 0x0401C2A5 RID: 115365
		[Token(Token = "0x401C2A5")]
		[FieldOffset(Offset = "0x68")]
		private ScrollWheelHandler m_handler;

		// Token: 0x0401C2A6 RID: 115366
		[Token(Token = "0x401C2A6")]
		[FieldOffset(Offset = "0x70")]
		private Action<float> m_updatingListeners;

		// Token: 0x0401C2A7 RID: 115367
		[Token(Token = "0x401C2A7")]
		[FieldOffset(Offset = "0x78")]
		private Action<int> m_pageChangedListeners;

		// Token: 0x0401C2A8 RID: 115368
		[Token(Token = "0x401C2A8")]
		[FieldOffset(Offset = "0x80")]
		private Action<int> m_pageChangeFinishListeners;

		// Token: 0x0401C2A9 RID: 115369
		[Token(Token = "0x401C2A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get__enableDrag;

		// Token: 0x0401C2AA RID: 115370
		[Token(Token = "0x401C2AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set__enableDrag;

		// Token: 0x0401C2AB RID: 115371
		[Token(Token = "0x401C2AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_scrollState;

		// Token: 0x0401C2AC RID: 115372
		[Token(Token = "0x401C2AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isUpdating;

		// Token: 0x0401C2AD RID: 115373
		[Token(Token = "0x401C2AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_pageCount;

		// Token: 0x0401C2AE RID: 115374
		[Token(Token = "0x401C2AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_pageCount;

		// Token: 0x0401C2AF RID: 115375
		[Token(Token = "0x401C2AF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_currentPage;

		// Token: 0x0401C2B0 RID: 115376
		[Token(Token = "0x401C2B0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_currentPage;

		// Token: 0x0401C2B1 RID: 115377
		[Token(Token = "0x401C2B1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetEnableDragFlag;

		// Token: 0x0401C2B2 RID: 115378
		[Token(Token = "0x401C2B2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AddUpdatingListener;

		// Token: 0x0401C2B3 RID: 115379
		[Token(Token = "0x401C2B3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RemoveUpdatingListener;

		// Token: 0x0401C2B4 RID: 115380
		[Token(Token = "0x401C2B4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AddPageIndexListener;

		// Token: 0x0401C2B5 RID: 115381
		[Token(Token = "0x401C2B5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RemovePageIndexListener;

		// Token: 0x0401C2B6 RID: 115382
		[Token(Token = "0x401C2B6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_AddPageIndexChangedListener;

		// Token: 0x0401C2B7 RID: 115383
		[Token(Token = "0x401C2B7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RemovePageIndexChangedListener;

		// Token: 0x0401C2B8 RID: 115384
		[Token(Token = "0x401C2B8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0401C2B9 RID: 115385
		[Token(Token = "0x401C2B9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0401C2BA RID: 115386
		[Token(Token = "0x401C2BA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBeginDrag;

		// Token: 0x0401C2BB RID: 115387
		[Token(Token = "0x401C2BB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x0401C2BC RID: 115388
		[Token(Token = "0x401C2BC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnEndDrag;

		// Token: 0x0401C2BD RID: 115389
		[Token(Token = "0x401C2BD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0401C2BE RID: 115390
		[Token(Token = "0x401C2BE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_MoveToPage;

		// Token: 0x0401C2BF RID: 115391
		[Token(Token = "0x401C2BF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401C2C0 RID: 115392
		[Token(Token = "0x401C2C0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401C2C1 RID: 115393
		[Token(Token = "0x401C2C1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ReleaseDragWhenDisabled;

		// Token: 0x0401C2C2 RID: 115394
		[Token(Token = "0x401C2C2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ScrollValue2PageIndex;

		// Token: 0x0401C2C3 RID: 115395
		[Token(Token = "0x401C2C3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__PageIndex2ScrollValue;

		// Token: 0x0401C2C4 RID: 115396
		[Token(Token = "0x401C2C4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SwitchToPage;

		// Token: 0x0401C2C5 RID: 115397
		[Token(Token = "0x401C2C5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__AutoAlign;

		// Token: 0x0401C2C6 RID: 115398
		[Token(Token = "0x401C2C6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckPageDirtyElastical;

		// Token: 0x0401C2C7 RID: 115399
		[Token(Token = "0x401C2C7")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0401C2C8 RID: 115400
		[Token(Token = "0x401C2C8")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x0401C2C9 RID: 115401
		[Token(Token = "0x401C2C9")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_TriggerListener;

		// Token: 0x0401C2CA RID: 115402
		[Token(Token = "0x401C2CA")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x0401C2CB RID: 115403
		[Token(Token = "0x401C2CB")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
