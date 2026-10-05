using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A3F RID: 14911
	[Token(Token = "0x2003A3F")]
	[SelectionBase]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[Hotfix(HotfixFlag.Stateless)]
	public class UIWrappedScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController, IWheelListener, IScrollNormalizedPosition
	{
		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x06017898 RID: 96408 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017899 RID: 96409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700386A")]
		public RectTransform content
		{
			[Token(Token = "0x6017898")]
			[Address(RVA = "0xFDED40", Offset = "0xFDD940", VA = "0x180FDED40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017899")]
			[Address(RVA = "0xFE0050", Offset = "0xFDEC50", VA = "0x180FE0050")]
			set
			{
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0601789A RID: 96410 RVA: 0x00097008 File Offset: 0x00095208
		// (set) Token: 0x0601789B RID: 96411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700386B")]
		public bool horizontal
		{
			[Token(Token = "0x601789A")]
			[Address(RVA = "0xFDF250", Offset = "0xFDDE50", VA = "0x180FDF250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601789B")]
			[Address(RVA = "0xFE0540", Offset = "0xFDF140", VA = "0x180FE0540")]
			set
			{
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0601789C RID: 96412 RVA: 0x00097020 File Offset: 0x00095220
		// (set) Token: 0x0601789D RID: 96413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700386C")]
		public bool vertical
		{
			[Token(Token = "0x601789C")]
			[Address(RVA = "0xFDFC50", Offset = "0xFDE850", VA = "0x180FDFC50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601789D")]
			[Address(RVA = "0xFE0C60", Offset = "0xFDF860", VA = "0x180FE0C60")]
			set
			{
			}
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0601789E RID: 96414 RVA: 0x00097038 File Offset: 0x00095238
		// (set) Token: 0x0601789F RID: 96415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700386D")]
		public UIWrappedScrollRect.MovementType movementType
		{
			[Token(Token = "0x601789E")]
			[Address(RVA = "0xFDF4F0", Offset = "0xFDE0F0", VA = "0x180FDF4F0")]
			get
			{
				return UIWrappedScrollRect.MovementType.Unrestricted;
			}
			[Token(Token = "0x601789F")]
			[Address(RVA = "0xFE0620", Offset = "0xFDF220", VA = "0x180FE0620")]
			set
			{
			}
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x060178A0 RID: 96416 RVA: 0x00097050 File Offset: 0x00095250
		// (set) Token: 0x060178A1 RID: 96417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700386E")]
		public float elasticity
		{
			[Token(Token = "0x60178A0")]
			[Address(RVA = "0xFDEE00", Offset = "0xFDDA00", VA = "0x180FDEE00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60178A1")]
			[Address(RVA = "0xFE0140", Offset = "0xFDED40", VA = "0x180FE0140")]
			set
			{
			}
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x060178A2 RID: 96418 RVA: 0x00097068 File Offset: 0x00095268
		// (set) Token: 0x060178A3 RID: 96419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700386F")]
		public bool inertia
		{
			[Token(Token = "0x60178A2")]
			[Address(RVA = "0xFDF2B0", Offset = "0xFDDEB0", VA = "0x180FDF2B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60178A3")]
			[Address(RVA = "0xFE05B0", Offset = "0xFDF1B0", VA = "0x180FE05B0")]
			set
			{
			}
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x060178A4 RID: 96420 RVA: 0x00097080 File Offset: 0x00095280
		// (set) Token: 0x060178A5 RID: 96421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003870")]
		public float decelerationRate
		{
			[Token(Token = "0x60178A4")]
			[Address(RVA = "0xFDEDA0", Offset = "0xFDD9A0", VA = "0x180FDEDA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60178A5")]
			[Address(RVA = "0xFE00D0", Offset = "0xFDECD0", VA = "0x180FE00D0")]
			set
			{
			}
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x060178A6 RID: 96422 RVA: 0x00097098 File Offset: 0x00095298
		// (set) Token: 0x060178A7 RID: 96423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003871")]
		public float scrollSensitivity
		{
			[Token(Token = "0x60178A6")]
			[Address(RVA = "0xFDF840", Offset = "0xFDE440", VA = "0x180FDF840")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60178A7")]
			[Address(RVA = "0xFE07E0", Offset = "0xFDF3E0", VA = "0x180FE07E0")]
			set
			{
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x060178A8 RID: 96424 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060178A9 RID: 96425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003872")]
		public RectTransform viewport
		{
			[Token(Token = "0x60178A8")]
			[Address(RVA = "0xFDFE10", Offset = "0xFDEA10", VA = "0x180FDFE10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60178A9")]
			[Address(RVA = "0xFE0CD0", Offset = "0xFDF8D0", VA = "0x180FE0CD0")]
			set
			{
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x060178AA RID: 96426 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060178AB RID: 96427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003873")]
		public Scrollbar horizontalScrollbar
		{
			[Token(Token = "0x60178AA")]
			[Address(RVA = "0xFDF1F0", Offset = "0xFDDDF0", VA = "0x180FDF1F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60178AB")]
			[Address(RVA = "0xFE0350", Offset = "0xFDEF50", VA = "0x180FE0350")]
			set
			{
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x060178AC RID: 96428 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060178AD RID: 96429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003874")]
		public Scrollbar verticalScrollbar
		{
			[Token(Token = "0x60178AC")]
			[Address(RVA = "0xFDFBF0", Offset = "0xFDE7F0", VA = "0x180FDFBF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60178AD")]
			[Address(RVA = "0xFE0A70", Offset = "0xFDF670", VA = "0x180FE0A70")]
			set
			{
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x060178AE RID: 96430 RVA: 0x000970B0 File Offset: 0x000952B0
		// (set) Token: 0x060178AF RID: 96431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003875")]
		public UIWrappedScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			[Token(Token = "0x60178AE")]
			[Address(RVA = "0xFDF190", Offset = "0xFDDD90", VA = "0x180FDF190")]
			get
			{
				return UIWrappedScrollRect.ScrollbarVisibility.Permanent;
			}
			[Token(Token = "0x60178AF")]
			[Address(RVA = "0xFE02D0", Offset = "0xFDEED0", VA = "0x180FE02D0")]
			set
			{
			}
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x060178B0 RID: 96432 RVA: 0x000970C8 File Offset: 0x000952C8
		// (set) Token: 0x060178B1 RID: 96433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003876")]
		public UIWrappedScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			[Token(Token = "0x60178B0")]
			[Address(RVA = "0xFDFB90", Offset = "0xFDE790", VA = "0x180FDFB90")]
			get
			{
				return UIWrappedScrollRect.ScrollbarVisibility.Permanent;
			}
			[Token(Token = "0x60178B1")]
			[Address(RVA = "0xFE09F0", Offset = "0xFDF5F0", VA = "0x180FE09F0")]
			set
			{
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x060178B2 RID: 96434 RVA: 0x000970E0 File Offset: 0x000952E0
		// (set) Token: 0x060178B3 RID: 96435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003877")]
		public float horizontalScrollbarSpacing
		{
			[Token(Token = "0x60178B2")]
			[Address(RVA = "0xFDF130", Offset = "0xFDDD30", VA = "0x180FDF130")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60178B3")]
			[Address(RVA = "0xFE0250", Offset = "0xFDEE50", VA = "0x180FE0250")]
			set
			{
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x060178B4 RID: 96436 RVA: 0x000970F8 File Offset: 0x000952F8
		// (set) Token: 0x060178B5 RID: 96437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003878")]
		public float verticalScrollbarSpacing
		{
			[Token(Token = "0x60178B4")]
			[Address(RVA = "0xFDFB30", Offset = "0xFDE730", VA = "0x180FDFB30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60178B5")]
			[Address(RVA = "0xFE0970", Offset = "0xFDF570", VA = "0x180FE0970")]
			set
			{
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x060178B6 RID: 96438 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060178B7 RID: 96439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003879")]
		public UIWrappedScrollRect.ScrollRectEvent onValueChanged
		{
			[Token(Token = "0x60178B6")]
			[Address(RVA = "0xFDF640", Offset = "0xFDE240", VA = "0x180FDF640")]
			get
			{
				return null;
			}
			[Token(Token = "0x60178B7")]
			[Address(RVA = "0xFE0760", Offset = "0xFDF360", VA = "0x180FE0760")]
			set
			{
			}
		}

		// Token: 0x060178B8 RID: 96440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178B8")]
		[Address(RVA = "0xFDE290", Offset = "0xFDCE90", VA = "0x180FDE290")]
		private void _LateUpdateApplyFling(Vector2 curDragLocalPos, float deltaTime)
		{
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x060178B9 RID: 96441 RVA: 0x00097110 File Offset: 0x00095310
		[Token(Token = "0x1700387A")]
		public bool nestedInParent
		{
			[Token(Token = "0x60178B9")]
			[Address(RVA = "0xFDF550", Offset = "0xFDE150", VA = "0x180FDF550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060178BA RID: 96442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178BA")]
		[Address(RVA = "0xFD8700", Offset = "0xFD7300", VA = "0x180FD8700")]
		public void EnableNestedInParent()
		{
		}

		// Token: 0x060178BB RID: 96443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178BB")]
		[Address(RVA = "0xFDB3C0", Offset = "0xFD9FC0", VA = "0x180FDB3C0")]
		public void SetDragDelegate(IDragHandler target)
		{
		}

		// Token: 0x060178BC RID: 96444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178BC")]
		[Address(RVA = "0xFDC5A0", Offset = "0xFDB1A0", VA = "0x180FDC5A0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060178BD RID: 96445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178BD")]
		[Address(RVA = "0xFDADB0", Offset = "0xFD99B0", VA = "0x180FDADB0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060178BE RID: 96446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178BE")]
		[Address(RVA = "0xFDE210", Offset = "0xFDCE10", VA = "0x180FDE210")]
		private void _FindScrollDelegateInParent()
		{
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x060178BF RID: 96447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700387B")]
		protected RectTransform viewRect
		{
			[Token(Token = "0x60178BF")]
			[Address(RVA = "0xFDFCB0", Offset = "0xFDE8B0", VA = "0x180FDFCB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x060178C0 RID: 96448 RVA: 0x00097128 File Offset: 0x00095328
		// (set) Token: 0x060178C1 RID: 96449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700387C")]
		public Vector2 velocity
		{
			[Token(Token = "0x60178C0")]
			[Address(RVA = "0xFDF950", Offset = "0xFDE550", VA = "0x180FDF950")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60178C1")]
			[Address(RVA = "0xFE0850", Offset = "0xFDF450", VA = "0x180FE0850")]
			set
			{
			}
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x060178C2 RID: 96450 RVA: 0x00097140 File Offset: 0x00095340
		[Token(Token = "0x1700387D")]
		public bool isDragging
		{
			[Token(Token = "0x60178C2")]
			[Address(RVA = "0xFDF310", Offset = "0xFDDF10", VA = "0x180FDF310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x060178C3 RID: 96451 RVA: 0x00097158 File Offset: 0x00095358
		[Token(Token = "0x1700387E")]
		public bool isScrolling
		{
			[Token(Token = "0x60178C3")]
			[Address(RVA = "0xFDF370", Offset = "0xFDDF70", VA = "0x180FDF370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060178C4 RID: 96452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178C4")]
		[Address(RVA = "0xFD87E0", Offset = "0xFD73E0", VA = "0x180FD87E0")]
		protected void EnsureCanvasScaler()
		{
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x060178C5 RID: 96453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700387F")]
		public ScrollWheelHandler wheelHandler
		{
			[Token(Token = "0x60178C5")]
			[Address(RVA = "0xFDFE70", Offset = "0xFDEA70", VA = "0x180FDFE70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x060178C6 RID: 96454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003880")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x60178C6")]
			[Address(RVA = "0xFDF760", Offset = "0xFDE360", VA = "0x180FDF760")]
			get
			{
				return null;
			}
		}

		// Token: 0x060178C7 RID: 96455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178C7")]
		[Address(RVA = "0xFDAEC0", Offset = "0xFD9AC0", VA = "0x180FDAEC0", Slot = "41")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x060178C8 RID: 96456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178C8")]
		[Address(RVA = "0xFD9DC0", Offset = "0xFD89C0", VA = "0x180FD9DC0", Slot = "42")]
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060178C9 RID: 96457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178C9")]
		[Address(RVA = "0xFD8C00", Offset = "0xFD7800", VA = "0x180FD8C00", Slot = "43")]
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x060178CA RID: 96458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178CA")]
		[Address(RVA = "0xFDD100", Offset = "0xFDBD00", VA = "0x180FDD100")]
		private void UpdateCachedData()
		{
		}

		// Token: 0x060178CB RID: 96459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178CB")]
		[Address(RVA = "0xFDDF70", Offset = "0xFDCB70", VA = "0x180FDDF70")]
		private void _BindWheelListener()
		{
		}

		// Token: 0x060178CC RID: 96460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178CC")]
		[Address(RVA = "0xFDA810", Offset = "0xFD9410", VA = "0x180FDA810", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060178CD RID: 96461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178CD")]
		[Address(RVA = "0xFDA110", Offset = "0xFD8D10", VA = "0x180FDA110", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060178CE RID: 96462 RVA: 0x00097170 File Offset: 0x00095370
		[Token(Token = "0x60178CE")]
		[Address(RVA = "0xFD91D0", Offset = "0xFD7DD0", VA = "0x180FD91D0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x060178CF RID: 96463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178CF")]
		[Address(RVA = "0xFD8990", Offset = "0xFD7590", VA = "0x180FD8990")]
		private void EnsureLayoutHasRebuilt()
		{
		}

		// Token: 0x060178D0 RID: 96464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178D0")]
		[Address(RVA = "0xFDC6A0", Offset = "0xFDB2A0", VA = "0x180FDC6A0", Slot = "44")]
		public virtual void StopMovement()
		{
		}

		// Token: 0x060178D1 RID: 96465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178D1")]
		[Address(RVA = "0xFDAD20", Offset = "0xFD9920", VA = "0x180FDAD20", Slot = "45")]
		public virtual void OnScroll(PointerEventData data)
		{
		}

		// Token: 0x060178D2 RID: 96466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178D2")]
		[Address(RVA = "0xFDABE0", Offset = "0xFD97E0", VA = "0x180FDABE0", Slot = "46")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060178D3 RID: 96467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178D3")]
		[Address(RVA = "0xFD9EA0", Offset = "0xFD8AA0", VA = "0x180FD9EA0", Slot = "47")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060178D4 RID: 96468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178D4")]
		[Address(RVA = "0xFDAB20", Offset = "0xFD9720", VA = "0x180FDAB20", Slot = "48")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060178D5 RID: 96469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178D5")]
		[Address(RVA = "0xFDA430", Offset = "0xFD9030", VA = "0x180FDA430", Slot = "49")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x060178D6 RID: 96470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003881")]
		private Canvas canvas
		{
			[Token(Token = "0x60178D6")]
			[Address(RVA = "0xFDEC60", Offset = "0xFDD860", VA = "0x180FDEC60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x060178D7 RID: 96471 RVA: 0x00097188 File Offset: 0x00095388
		// (set) Token: 0x060178D8 RID: 96472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003882")]
		public bool allowScroll
		{
			[Token(Token = "0x60178D7")]
			[Address(RVA = "0xFDEC00", Offset = "0xFDD800", VA = "0x180FDEC00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60178D8")]
			[Address(RVA = "0xFDFFD0", Offset = "0xFDEBD0", VA = "0x180FDFFD0")]
			set
			{
			}
		}

		// Token: 0x060178D9 RID: 96473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178D9")]
		[Address(RVA = "0xFD8640", Offset = "0xFD7240", VA = "0x180FD8640")]
		public void CancelCurrentDrag()
		{
		}

		// Token: 0x060178DA RID: 96474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178DA")]
		[Address(RVA = "0xFDE7A0", Offset = "0xFDD3A0", VA = "0x180FDE7A0")]
		private void _StopDraggingIfMultiTouch()
		{
		}

		// Token: 0x060178DB RID: 96475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178DB")]
		[Address(RVA = "0xFD9E20", Offset = "0xFD8A20", VA = "0x180FD9E20", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x060178DC RID: 96476 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060178DD RID: 96477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000081")]
		public event Action eventOnManuallyDragged
		{
			[Token(Token = "0x60178DC")]
			[Address(RVA = "0xFDEB10", Offset = "0xFDD710", VA = "0x180FDEB10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60178DD")]
			[Address(RVA = "0xFDFEE0", Offset = "0xFDEAE0", VA = "0x180FDFEE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060178DE RID: 96478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178DE")]
		[Address(RVA = "0xFDB080", Offset = "0xFD9C80", VA = "0x180FDB080", Slot = "50")]
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
		}

		// Token: 0x060178DF RID: 96479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178DF")]
		[Address(RVA = "0xFD9270", Offset = "0xFD7E70", VA = "0x180FD9270", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060178E0 RID: 96480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178E0")]
		[Address(RVA = "0xFD7F70", Offset = "0xFD6B70", VA = "0x180FD7F70")]
		private static void ApplyDeceleration(UIWrappedScrollRect.DecelerationConfig config, out Vector2 velocity)
		{
		}

		// Token: 0x060178E1 RID: 96481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178E1")]
		[Address(RVA = "0xFDD6F0", Offset = "0xFDC2F0", VA = "0x180FDD6F0")]
		protected void UpdatePrevData()
		{
		}

		// Token: 0x060178E2 RID: 96482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178E2")]
		[Address(RVA = "0xFDDCE0", Offset = "0xFDC8E0", VA = "0x180FDDCE0")]
		private void UpdateScrollbars(Vector2 offset)
		{
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x060178E3 RID: 96483 RVA: 0x000971A0 File Offset: 0x000953A0
		// (set) Token: 0x060178E4 RID: 96484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003883")]
		public Vector2 normalizedPosition
		{
			[Token(Token = "0x60178E3")]
			[Address(RVA = "0xFDF5B0", Offset = "0xFDE1B0", VA = "0x180FDF5B0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60178E4")]
			[Address(RVA = "0xFE0690", Offset = "0xFDF290", VA = "0x180FE0690")]
			set
			{
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x060178E5 RID: 96485 RVA: 0x000971B8 File Offset: 0x000953B8
		[Token(Token = "0x17003884")]
		private Vector2 position
		{
			[Token(Token = "0x60178E5")]
			[Address(RVA = "0xFDC970", Offset = "0xFDB570", VA = "0x180FDC970", Slot = "40")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x060178E6 RID: 96486 RVA: 0x000971D0 File Offset: 0x000953D0
		// (set) Token: 0x060178E7 RID: 96487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003885")]
		public float horizontalNormalizedPosition
		{
			[Token(Token = "0x60178E6")]
			[Address(RVA = "0xFDEFD0", Offset = "0xFDDBD0", VA = "0x180FDEFD0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60178E7")]
			[Address(RVA = "0xFE01B0", Offset = "0xFDEDB0", VA = "0x180FE01B0")]
			set
			{
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x060178E8 RID: 96488 RVA: 0x000971E8 File Offset: 0x000953E8
		// (set) Token: 0x060178E9 RID: 96489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003886")]
		public float verticalNormalizedPosition
		{
			[Token(Token = "0x60178E8")]
			[Address(RVA = "0xFDF9C0", Offset = "0xFDE5C0", VA = "0x180FDF9C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60178E9")]
			[Address(RVA = "0xFE08D0", Offset = "0xFDF4D0", VA = "0x180FE08D0")]
			set
			{
			}
		}

		// Token: 0x060178EA RID: 96490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178EA")]
		[Address(RVA = "0xFDB460", Offset = "0xFDA060", VA = "0x180FDB460")]
		private void SetHorizontalNormalizedPosition(float value)
		{
		}

		// Token: 0x060178EB RID: 96491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178EB")]
		[Address(RVA = "0xFDC500", Offset = "0xFDB100", VA = "0x180FDC500")]
		private void SetVerticalNormalizedPosition(float value)
		{
		}

		// Token: 0x060178EC RID: 96492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178EC")]
		[Address(RVA = "0xFDBF60", Offset = "0xFDAB60", VA = "0x180FDBF60", Slot = "52")]
		protected virtual void SetNormalizedPosition(float value, int axis)
		{
		}

		// Token: 0x060178ED RID: 96493 RVA: 0x00097200 File Offset: 0x00095400
		[Token(Token = "0x60178ED")]
		[Address(RVA = "0xFDAFB0", Offset = "0xFD9BB0", VA = "0x180FDAFB0")]
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return 0f;
		}

		// Token: 0x060178EE RID: 96494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178EE")]
		[Address(RVA = "0xFDACC0", Offset = "0xFD98C0", VA = "0x180FDACC0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x060178EF RID: 96495 RVA: 0x00097218 File Offset: 0x00095418
		[Token(Token = "0x17003887")]
		private bool hScrollingNeeded
		{
			[Token(Token = "0x60178EF")]
			[Address(RVA = "0xFDEF20", Offset = "0xFDDB20", VA = "0x180FDEF20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x060178F0 RID: 96496 RVA: 0x00097230 File Offset: 0x00095430
		[Token(Token = "0x17003888")]
		private bool vScrollingNeeded
		{
			[Token(Token = "0x60178F0")]
			[Address(RVA = "0xFDF8A0", Offset = "0xFDE4A0", VA = "0x180FDF8A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060178F1 RID: 96497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178F1")]
		[Address(RVA = "0xFD84D0", Offset = "0xFD70D0", VA = "0x180FD84D0", Slot = "53")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060178F2 RID: 96498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178F2")]
		[Address(RVA = "0xFD8530", Offset = "0xFD7130", VA = "0x180FD8530", Slot = "54")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x060178F3 RID: 96499 RVA: 0x00097248 File Offset: 0x00095448
		[Token(Token = "0x17003889")]
		public virtual float minWidth
		{
			[Token(Token = "0x60178F3")]
			[Address(RVA = "0xFDF490", Offset = "0xFDE090", VA = "0x180FDF490", Slot = "55")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x060178F4 RID: 96500 RVA: 0x00097260 File Offset: 0x00095460
		[Token(Token = "0x1700388A")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60178F4")]
			[Address(RVA = "0xFDF700", Offset = "0xFDE300", VA = "0x180FDF700", Slot = "56")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x060178F5 RID: 96501 RVA: 0x00097278 File Offset: 0x00095478
		[Token(Token = "0x1700388B")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60178F5")]
			[Address(RVA = "0xFDEEC0", Offset = "0xFDDAC0", VA = "0x180FDEEC0", Slot = "57")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x060178F6 RID: 96502 RVA: 0x00097290 File Offset: 0x00095490
		[Token(Token = "0x1700388C")]
		public virtual float minHeight
		{
			[Token(Token = "0x60178F6")]
			[Address(RVA = "0xFDF430", Offset = "0xFDE030", VA = "0x180FDF430", Slot = "58")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x060178F7 RID: 96503 RVA: 0x000972A8 File Offset: 0x000954A8
		[Token(Token = "0x1700388D")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60178F7")]
			[Address(RVA = "0xFDF6A0", Offset = "0xFDE2A0", VA = "0x180FDF6A0", Slot = "59")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x060178F8 RID: 96504 RVA: 0x000972C0 File Offset: 0x000954C0
		[Token(Token = "0x1700388E")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x60178F8")]
			[Address(RVA = "0xFDEE60", Offset = "0xFDDA60", VA = "0x180FDEE60", Slot = "60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x060178F9 RID: 96505 RVA: 0x000972D8 File Offset: 0x000954D8
		[Token(Token = "0x1700388F")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x60178F9")]
			[Address(RVA = "0xFDF3D0", Offset = "0xFDDFD0", VA = "0x180FDF3D0", Slot = "61")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060178FA RID: 96506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178FA")]
		[Address(RVA = "0xFDB500", Offset = "0xFDA100", VA = "0x180FDB500", Slot = "62")]
		public virtual void SetLayoutHorizontal()
		{
		}

		// Token: 0x060178FB RID: 96507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178FB")]
		[Address(RVA = "0xFDBDB0", Offset = "0xFDA9B0", VA = "0x180FDBDB0", Slot = "63")]
		public virtual void SetLayoutVertical()
		{
		}

		// Token: 0x060178FC RID: 96508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178FC")]
		[Address(RVA = "0xFDDC30", Offset = "0xFDC830", VA = "0x180FDDC30")]
		private void UpdateScrollbarVisibility()
		{
		}

		// Token: 0x060178FD RID: 96509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178FD")]
		[Address(RVA = "0xFDD5A0", Offset = "0xFDC1A0", VA = "0x180FDD5A0")]
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UIWrappedScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
		}

		// Token: 0x060178FE RID: 96510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178FE")]
		[Address(RVA = "0xFDD830", Offset = "0xFDC430", VA = "0x180FDD830")]
		private void UpdateScrollbarLayout()
		{
		}

		// Token: 0x060178FF RID: 96511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60178FF")]
		[Address(RVA = "0xFDC9D0", Offset = "0xFDB5D0", VA = "0x180FDC9D0")]
		protected void UpdateBounds()
		{
		}

		// Token: 0x06017900 RID: 96512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017900")]
		[Address(RVA = "0xFD7E00", Offset = "0xFD6A00", VA = "0x180FD7E00")]
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
		}

		// Token: 0x06017901 RID: 96513 RVA: 0x000972F0 File Offset: 0x000954F0
		[Token(Token = "0x6017901")]
		[Address(RVA = "0xFD8A30", Offset = "0xFD7630", VA = "0x180FD8A30")]
		private Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06017902 RID: 96514 RVA: 0x00097308 File Offset: 0x00095508
		[Token(Token = "0x6017902")]
		[Address(RVA = "0xFD8ED0", Offset = "0xFD7AD0", VA = "0x180FD8ED0")]
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			return default(Bounds);
		}

		// Token: 0x06017903 RID: 96515 RVA: 0x00097320 File Offset: 0x00095520
		[Token(Token = "0x6017903")]
		[Address(RVA = "0xFD8590", Offset = "0xFD7190", VA = "0x180FD8590")]
		private Vector2 CalculateOffset(Vector2 delta)
		{
			return default(Vector2);
		}

		// Token: 0x06017904 RID: 96516 RVA: 0x00097338 File Offset: 0x00095538
		[Token(Token = "0x6017904")]
		[Address(RVA = "0xFD8C60", Offset = "0xFD7860", VA = "0x180FD8C60")]
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, UIWrappedScrollRect.MovementType movementType, ref Vector2 delta)
		{
			return default(Vector2);
		}

		// Token: 0x06017905 RID: 96517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017905")]
		[Address(RVA = "0xFDB300", Offset = "0xFD9F00", VA = "0x180FDB300")]
		protected void SetDirty()
		{
		}

		// Token: 0x06017906 RID: 96518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017906")]
		[Address(RVA = "0xFDE4E0", Offset = "0xFDD0E0", VA = "0x180FDE4E0")]
		private void _OnScrollWork(Vector2 delta)
		{
		}

		// Token: 0x06017907 RID: 96519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017907")]
		[Address(RVA = "0xFDB210", Offset = "0xFD9E10", VA = "0x180FDB210")]
		protected void SetDirtyCaching()
		{
		}

		// Token: 0x06017908 RID: 96520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017908")]
		[Address(RVA = "0xFD8330", Offset = "0xFD6F30", VA = "0x180FD8330")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x06017909 RID: 96521 RVA: 0x00097350 File Offset: 0x00095550
		[Token(Token = "0x6017909")]
		[Address(RVA = "0xFD8BA0", Offset = "0xFD77A0", VA = "0x180FD8BA0", Slot = "38")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x0601790A RID: 96522 RVA: 0x00097368 File Offset: 0x00095568
		[Token(Token = "0x601790A")]
		[Address(RVA = "0xFDC740", Offset = "0xFDB340", VA = "0x180FDC740", Slot = "39")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x0601790B RID: 96523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601790B")]
		[Address(RVA = "0xFDE830", Offset = "0xFDD430", VA = "0x180FDE830")]
		public UIWrappedScrollRect()
		{
		}

		// Token: 0x0601790C RID: 96524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601790C")]
		[Address(RVA = "0xFDC910", Offset = "0xFDB510", VA = "0x180FDC910", Slot = "23")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0601790D RID: 96525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601790D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Start()
		{
		}

		// Token: 0x0601790E RID: 96526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601790E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnTransformParentChanged()
		{
		}

		// Token: 0x0601790F RID: 96527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601790F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06017910 RID: 96528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017910")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x06017911 RID: 96529 RVA: 0x00097380 File Offset: 0x00095580
		[Token(Token = "0x6017911")]
		[Address(RVA = "0xFA5600", Offset = "0xFA4200", VA = "0x180FA5600")]
		private bool <>xLuaBaseProxy_IsActive()
		{
			return default(bool);
		}

		// Token: 0x06017912 RID: 96530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017912")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnBeforeTransformParentChanged()
		{
		}

		// Token: 0x06017913 RID: 96531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017913")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x0401C6C4 RID: 116420
		[Token(Token = "0x401C6C4")]
		private const float DRAG_DIR_THRESHOLD = 225f;

		// Token: 0x0401C6C5 RID: 116421
		[Token(Token = "0x401C6C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform m_Content;

		// Token: 0x0401C6C6 RID: 116422
		[Token(Token = "0x401C6C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_Horizontal;

		// Token: 0x0401C6C7 RID: 116423
		[Token(Token = "0x401C6C7")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool m_Vertical;

		// Token: 0x0401C6C8 RID: 116424
		[Token(Token = "0x401C6C8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UIWrappedScrollRect.MovementType m_MovementType;

		// Token: 0x0401C6C9 RID: 116425
		[Token(Token = "0x401C6C9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_Elasticity;

		// Token: 0x0401C6CA RID: 116426
		[Token(Token = "0x401C6CA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Group("Inertia")]
		private bool m_Inertia;

		// Token: 0x0401C6CB RID: 116427
		[Token(Token = "0x401C6CB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Inertia")]
		private float m_DecelerationRate;

		// Token: 0x0401C6CC RID: 116428
		[Token(Token = "0x401C6CC")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Group("Inertia")]
		private bool m_Friction;

		// Token: 0x0401C6CD RID: 116429
		[Token(Token = "0x401C6CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Inertia")]
		private float m_FrictionValue;

		// Token: 0x0401C6CE RID: 116430
		[Token(Token = "0x401C6CE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_ScrollSensitivity;

		// Token: 0x0401C6CF RID: 116431
		[Token(Token = "0x401C6CF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform m_Viewport;

		// Token: 0x0401C6D0 RID: 116432
		[Token(Token = "0x401C6D0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		// Token: 0x0401C6D1 RID: 116433
		[Token(Token = "0x401C6D1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		// Token: 0x0401C6D2 RID: 116434
		[Token(Token = "0x401C6D2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIWrappedScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;

		// Token: 0x0401C6D3 RID: 116435
		[Token(Token = "0x401C6D3")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private UIWrappedScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;

		// Token: 0x0401C6D4 RID: 116436
		[Token(Token = "0x401C6D4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		// Token: 0x0401C6D5 RID: 116437
		[Token(Token = "0x401C6D5")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		// Token: 0x0401C6D6 RID: 116438
		[Token(Token = "0x401C6D6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIWrappedScrollRect.ScrollRectEvent m_OnValueChanged;

		// Token: 0x0401C6D7 RID: 116439
		[Token(Token = "0x401C6D7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIWrappedScrollRect.FlingConfig _flingConfig;

		// Token: 0x0401C6D8 RID: 116440
		[Token(Token = "0x401C6D8")]
		[FieldOffset(Offset = "0x78")]
		private UIFlingGesture m_fling;

		// Token: 0x0401C6D9 RID: 116441
		[Token(Token = "0x401C6D9")]
		[FieldOffset(Offset = "0x80")]
		private int m_dragPointerId;

		// Token: 0x0401C6DA RID: 116442
		[Token(Token = "0x401C6DA")]
		[FieldOffset(Offset = "0x88")]
		private Camera m_dragCamera;

		// Token: 0x0401C6DB RID: 116443
		[Token(Token = "0x401C6DB")]
		[FieldOffset(Offset = "0x90")]
		private UIWrappedScrollRect.NormPosRequest m_normPosDuringInactive;

		// Token: 0x0401C6DC RID: 116444
		[Token(Token = "0x401C6DC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Tooltip("When ticked, the scroll would auto find dragger in parent and try to use it as a drag delegate.")]
		private bool _nestedInParent;

		// Token: 0x0401C6DD RID: 116445
		[Token(Token = "0x401C6DD")]
		[FieldOffset(Offset = "0xA8")]
		private UIWrappedScrollRect.DragDelegate m_dragDelegate;

		// Token: 0x0401C6DE RID: 116446
		[Token(Token = "0x401C6DE")]
		[FieldOffset(Offset = "0xB0")]
		private LatchUtils.InvokeWhenUnlock m_findDelegateLatch;

		// Token: 0x0401C6DF RID: 116447
		[Token(Token = "0x401C6DF")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 m_PointerStartLocalCursor;

		// Token: 0x0401C6E0 RID: 116448
		[Token(Token = "0x401C6E0")]
		[FieldOffset(Offset = "0xC0")]
		protected Vector2 m_ContentStartPosition;

		// Token: 0x0401C6E1 RID: 116449
		[Token(Token = "0x401C6E1")]
		[FieldOffset(Offset = "0xC8")]
		private RectTransform m_ViewRect;

		// Token: 0x0401C6E2 RID: 116450
		[Token(Token = "0x401C6E2")]
		[FieldOffset(Offset = "0xD0")]
		protected Bounds m_ContentBounds;

		// Token: 0x0401C6E3 RID: 116451
		[Token(Token = "0x401C6E3")]
		[FieldOffset(Offset = "0xE8")]
		private Bounds m_ViewBounds;

		// Token: 0x0401C6E4 RID: 116452
		[Token(Token = "0x401C6E4")]
		[FieldOffset(Offset = "0x100")]
		private Vector2 m_Velocity;

		// Token: 0x0401C6E5 RID: 116453
		[Token(Token = "0x401C6E5")]
		[FieldOffset(Offset = "0x108")]
		private bool m_Dragging;

		// Token: 0x0401C6E6 RID: 116454
		[Token(Token = "0x401C6E6")]
		[FieldOffset(Offset = "0x109")]
		private bool m_Scrolling;

		// Token: 0x0401C6E7 RID: 116455
		[Token(Token = "0x401C6E7")]
		[FieldOffset(Offset = "0x10C")]
		private Vector2 m_PrevPosition;

		// Token: 0x0401C6E8 RID: 116456
		[Token(Token = "0x401C6E8")]
		[FieldOffset(Offset = "0x114")]
		private Bounds m_PrevContentBounds;

		// Token: 0x0401C6E9 RID: 116457
		[Token(Token = "0x401C6E9")]
		[FieldOffset(Offset = "0x12C")]
		private Bounds m_PrevViewBounds;

		// Token: 0x0401C6EA RID: 116458
		[Token(Token = "0x401C6EA")]
		[FieldOffset(Offset = "0x148")]
		private Canvas m_CacheCanvas;

		// Token: 0x0401C6EB RID: 116459
		[Token(Token = "0x401C6EB")]
		[FieldOffset(Offset = "0x150")]
		private CanvasScaler m_CacheCanvasScaler;

		// Token: 0x0401C6EC RID: 116460
		[Token(Token = "0x401C6EC")]
		[FieldOffset(Offset = "0x158")]
		[NonSerialized]
		private bool m_HasRebuiltLayout;

		// Token: 0x0401C6ED RID: 116461
		[Token(Token = "0x401C6ED")]
		[FieldOffset(Offset = "0x159")]
		private bool m_HSliderExpand;

		// Token: 0x0401C6EE RID: 116462
		[Token(Token = "0x401C6EE")]
		[FieldOffset(Offset = "0x15A")]
		private bool m_VSliderExpand;

		// Token: 0x0401C6EF RID: 116463
		[Token(Token = "0x401C6EF")]
		[FieldOffset(Offset = "0x15C")]
		private float m_HSliderHeight;

		// Token: 0x0401C6F0 RID: 116464
		[Token(Token = "0x401C6F0")]
		[FieldOffset(Offset = "0x160")]
		private float m_VSliderWidth;

		// Token: 0x0401C6F1 RID: 116465
		[Token(Token = "0x401C6F1")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private InertiaTickHandler.Option m_Option;

		// Token: 0x0401C6F2 RID: 116466
		[Token(Token = "0x401C6F2")]
		[FieldOffset(Offset = "0x170")]
		private ScrollWheelHandler m_ScrollWheelHandler;

		// Token: 0x0401C6F3 RID: 116467
		[Token(Token = "0x401C6F3")]
		[FieldOffset(Offset = "0x178")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x0401C6F4 RID: 116468
		[Token(Token = "0x401C6F4")]
		[FieldOffset(Offset = "0x180")]
		private RectTransform m_HorizontalScrollbarRect;

		// Token: 0x0401C6F5 RID: 116469
		[Token(Token = "0x401C6F5")]
		[FieldOffset(Offset = "0x188")]
		private RectTransform m_VerticalScrollbarRect;

		// Token: 0x0401C6F6 RID: 116470
		[Token(Token = "0x401C6F6")]
		[FieldOffset(Offset = "0x190")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0401C6F7 RID: 116471
		[Token(Token = "0x401C6F7")]
		[FieldOffset(Offset = "0x198")]
		[NonSerialized]
		private Canvas m_cacheCanvas;

		// Token: 0x0401C6F8 RID: 116472
		[Token(Token = "0x401C6F8")]
		[FieldOffset(Offset = "0x1A0")]
		private bool m_allowScroll;

		// Token: 0x0401C6FA RID: 116474
		[Token(Token = "0x401C6FA")]
		[FieldOffset(Offset = "0x1B0")]
		private readonly Vector3[] m_Corners;

		// Token: 0x0401C6FB RID: 116475
		[Token(Token = "0x401C6FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_content;

		// Token: 0x0401C6FC RID: 116476
		[Token(Token = "0x401C6FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_content;

		// Token: 0x0401C6FD RID: 116477
		[Token(Token = "0x401C6FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_horizontal;

		// Token: 0x0401C6FE RID: 116478
		[Token(Token = "0x401C6FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_horizontal;

		// Token: 0x0401C6FF RID: 116479
		[Token(Token = "0x401C6FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_vertical;

		// Token: 0x0401C700 RID: 116480
		[Token(Token = "0x401C700")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_vertical;

		// Token: 0x0401C701 RID: 116481
		[Token(Token = "0x401C701")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_movementType;

		// Token: 0x0401C702 RID: 116482
		[Token(Token = "0x401C702")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_movementType;

		// Token: 0x0401C703 RID: 116483
		[Token(Token = "0x401C703")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_elasticity;

		// Token: 0x0401C704 RID: 116484
		[Token(Token = "0x401C704")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_elasticity;

		// Token: 0x0401C705 RID: 116485
		[Token(Token = "0x401C705")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_inertia;

		// Token: 0x0401C706 RID: 116486
		[Token(Token = "0x401C706")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_inertia;

		// Token: 0x0401C707 RID: 116487
		[Token(Token = "0x401C707")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_decelerationRate;

		// Token: 0x0401C708 RID: 116488
		[Token(Token = "0x401C708")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_decelerationRate;

		// Token: 0x0401C709 RID: 116489
		[Token(Token = "0x401C709")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_scrollSensitivity;

		// Token: 0x0401C70A RID: 116490
		[Token(Token = "0x401C70A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_scrollSensitivity;

		// Token: 0x0401C70B RID: 116491
		[Token(Token = "0x401C70B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_viewport;

		// Token: 0x0401C70C RID: 116492
		[Token(Token = "0x401C70C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_viewport;

		// Token: 0x0401C70D RID: 116493
		[Token(Token = "0x401C70D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_horizontalScrollbar;

		// Token: 0x0401C70E RID: 116494
		[Token(Token = "0x401C70E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_horizontalScrollbar;

		// Token: 0x0401C70F RID: 116495
		[Token(Token = "0x401C70F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_verticalScrollbar;

		// Token: 0x0401C710 RID: 116496
		[Token(Token = "0x401C710")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_verticalScrollbar;

		// Token: 0x0401C711 RID: 116497
		[Token(Token = "0x401C711")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_horizontalScrollbarVisibility;

		// Token: 0x0401C712 RID: 116498
		[Token(Token = "0x401C712")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_horizontalScrollbarVisibility;

		// Token: 0x0401C713 RID: 116499
		[Token(Token = "0x401C713")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_verticalScrollbarVisibility;

		// Token: 0x0401C714 RID: 116500
		[Token(Token = "0x401C714")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_verticalScrollbarVisibility;

		// Token: 0x0401C715 RID: 116501
		[Token(Token = "0x401C715")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_horizontalScrollbarSpacing;

		// Token: 0x0401C716 RID: 116502
		[Token(Token = "0x401C716")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_horizontalScrollbarSpacing;

		// Token: 0x0401C717 RID: 116503
		[Token(Token = "0x401C717")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_verticalScrollbarSpacing;

		// Token: 0x0401C718 RID: 116504
		[Token(Token = "0x401C718")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_verticalScrollbarSpacing;

		// Token: 0x0401C719 RID: 116505
		[Token(Token = "0x401C719")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_onValueChanged;

		// Token: 0x0401C71A RID: 116506
		[Token(Token = "0x401C71A")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_onValueChanged;

		// Token: 0x0401C71B RID: 116507
		[Token(Token = "0x401C71B")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__LateUpdateApplyFling;

		// Token: 0x0401C71C RID: 116508
		[Token(Token = "0x401C71C")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_nestedInParent;

		// Token: 0x0401C71D RID: 116509
		[Token(Token = "0x401C71D")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_EnableNestedInParent;

		// Token: 0x0401C71E RID: 116510
		[Token(Token = "0x401C71E")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_SetDragDelegate;

		// Token: 0x0401C71F RID: 116511
		[Token(Token = "0x401C71F")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401C720 RID: 116512
		[Token(Token = "0x401C720")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnTransformParentChanged;

		// Token: 0x0401C721 RID: 116513
		[Token(Token = "0x401C721")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__FindScrollDelegateInParent;

		// Token: 0x0401C722 RID: 116514
		[Token(Token = "0x401C722")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_viewRect;

		// Token: 0x0401C723 RID: 116515
		[Token(Token = "0x401C723")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_velocity;

		// Token: 0x0401C724 RID: 116516
		[Token(Token = "0x401C724")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_set_velocity;

		// Token: 0x0401C725 RID: 116517
		[Token(Token = "0x401C725")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_isDragging;

		// Token: 0x0401C726 RID: 116518
		[Token(Token = "0x401C726")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_isScrolling;

		// Token: 0x0401C727 RID: 116519
		[Token(Token = "0x401C727")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_EnsureCanvasScaler;

		// Token: 0x0401C728 RID: 116520
		[Token(Token = "0x401C728")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_wheelHandler;

		// Token: 0x0401C729 RID: 116521
		[Token(Token = "0x401C729")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_rectTransform;

		// Token: 0x0401C72A RID: 116522
		[Token(Token = "0x401C72A")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_Rebuild;

		// Token: 0x0401C72B RID: 116523
		[Token(Token = "0x401C72B")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_LayoutComplete;

		// Token: 0x0401C72C RID: 116524
		[Token(Token = "0x401C72C")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GraphicUpdateComplete;

		// Token: 0x0401C72D RID: 116525
		[Token(Token = "0x401C72D")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_UpdateCachedData;

		// Token: 0x0401C72E RID: 116526
		[Token(Token = "0x401C72E")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__BindWheelListener;

		// Token: 0x0401C72F RID: 116527
		[Token(Token = "0x401C72F")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401C730 RID: 116528
		[Token(Token = "0x401C730")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401C731 RID: 116529
		[Token(Token = "0x401C731")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_IsActive;

		// Token: 0x0401C732 RID: 116530
		[Token(Token = "0x401C732")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_EnsureLayoutHasRebuilt;

		// Token: 0x0401C733 RID: 116531
		[Token(Token = "0x401C733")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_StopMovement;

		// Token: 0x0401C734 RID: 116532
		[Token(Token = "0x401C734")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x0401C735 RID: 116533
		[Token(Token = "0x401C735")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_OnInitializePotentialDrag;

		// Token: 0x0401C736 RID: 116534
		[Token(Token = "0x401C736")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0401C737 RID: 116535
		[Token(Token = "0x401C737")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x0401C738 RID: 116536
		[Token(Token = "0x401C738")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0401C739 RID: 116537
		[Token(Token = "0x401C739")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_get_canvas;

		// Token: 0x0401C73A RID: 116538
		[Token(Token = "0x401C73A")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_get_allowScroll;

		// Token: 0x0401C73B RID: 116539
		[Token(Token = "0x401C73B")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_set_allowScroll;

		// Token: 0x0401C73C RID: 116540
		[Token(Token = "0x401C73C")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_CancelCurrentDrag;

		// Token: 0x0401C73D RID: 116541
		[Token(Token = "0x401C73D")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__StopDraggingIfMultiTouch;

		// Token: 0x0401C73E RID: 116542
		[Token(Token = "0x401C73E")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_OnBeforeTransformParentChanged;

		// Token: 0x0401C73F RID: 116543
		[Token(Token = "0x401C73F")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_add_eventOnManuallyDragged;

		// Token: 0x0401C740 RID: 116544
		[Token(Token = "0x401C740")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_remove_eventOnManuallyDragged;

		// Token: 0x0401C741 RID: 116545
		[Token(Token = "0x401C741")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_SetContentAnchoredPosition;

		// Token: 0x0401C742 RID: 116546
		[Token(Token = "0x401C742")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0401C743 RID: 116547
		[Token(Token = "0x401C743")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_ApplyDeceleration;

		// Token: 0x0401C744 RID: 116548
		[Token(Token = "0x401C744")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_UpdatePrevData;

		// Token: 0x0401C745 RID: 116549
		[Token(Token = "0x401C745")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_UpdateScrollbars;

		// Token: 0x0401C746 RID: 116550
		[Token(Token = "0x401C746")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_get_normalizedPosition;

		// Token: 0x0401C747 RID: 116551
		[Token(Token = "0x401C747")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_set_normalizedPosition;

		// Token: 0x0401C748 RID: 116552
		[Token(Token = "0x401C748")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge get_position;

		// Token: 0x0401C749 RID: 116553
		[Token(Token = "0x401C749")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_get_horizontalNormalizedPosition;

		// Token: 0x0401C74A RID: 116554
		[Token(Token = "0x401C74A")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_set_horizontalNormalizedPosition;

		// Token: 0x0401C74B RID: 116555
		[Token(Token = "0x401C74B")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_get_verticalNormalizedPosition;

		// Token: 0x0401C74C RID: 116556
		[Token(Token = "0x401C74C")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_set_verticalNormalizedPosition;

		// Token: 0x0401C74D RID: 116557
		[Token(Token = "0x401C74D")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_SetHorizontalNormalizedPosition;

		// Token: 0x0401C74E RID: 116558
		[Token(Token = "0x401C74E")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_SetVerticalNormalizedPosition;

		// Token: 0x0401C74F RID: 116559
		[Token(Token = "0x401C74F")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_SetNormalizedPosition;

		// Token: 0x0401C750 RID: 116560
		[Token(Token = "0x401C750")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_RubberDelta;

		// Token: 0x0401C751 RID: 116561
		[Token(Token = "0x401C751")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_OnRectTransformDimensionsChange;

		// Token: 0x0401C752 RID: 116562
		[Token(Token = "0x401C752")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_get_hScrollingNeeded;

		// Token: 0x0401C753 RID: 116563
		[Token(Token = "0x401C753")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_get_vScrollingNeeded;

		// Token: 0x0401C754 RID: 116564
		[Token(Token = "0x401C754")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x0401C755 RID: 116565
		[Token(Token = "0x401C755")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x0401C756 RID: 116566
		[Token(Token = "0x401C756")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_get_minWidth;

		// Token: 0x0401C757 RID: 116567
		[Token(Token = "0x401C757")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0401C758 RID: 116568
		[Token(Token = "0x401C758")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_get_flexibleWidth;

		// Token: 0x0401C759 RID: 116569
		[Token(Token = "0x401C759")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_get_minHeight;

		// Token: 0x0401C75A RID: 116570
		[Token(Token = "0x401C75A")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0401C75B RID: 116571
		[Token(Token = "0x401C75B")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_get_flexibleHeight;

		// Token: 0x0401C75C RID: 116572
		[Token(Token = "0x401C75C")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_get_layoutPriority;

		// Token: 0x0401C75D RID: 116573
		[Token(Token = "0x401C75D")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_SetLayoutHorizontal;

		// Token: 0x0401C75E RID: 116574
		[Token(Token = "0x401C75E")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_SetLayoutVertical;

		// Token: 0x0401C75F RID: 116575
		[Token(Token = "0x401C75F")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_UpdateScrollbarVisibility;

		// Token: 0x0401C760 RID: 116576
		[Token(Token = "0x401C760")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_UpdateOneScrollbarVisibility;

		// Token: 0x0401C761 RID: 116577
		[Token(Token = "0x401C761")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_UpdateScrollbarLayout;

		// Token: 0x0401C762 RID: 116578
		[Token(Token = "0x401C762")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_UpdateBounds;

		// Token: 0x0401C763 RID: 116579
		[Token(Token = "0x401C763")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_AdjustBounds;

		// Token: 0x0401C764 RID: 116580
		[Token(Token = "0x401C764")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_GetBounds;

		// Token: 0x0401C765 RID: 116581
		[Token(Token = "0x401C765")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_InternalGetBounds;

		// Token: 0x0401C766 RID: 116582
		[Token(Token = "0x401C766")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_CalculateOffset;

		// Token: 0x0401C767 RID: 116583
		[Token(Token = "0x401C767")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_InternalCalculateOffset;

		// Token: 0x0401C768 RID: 116584
		[Token(Token = "0x401C768")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_SetDirty;

		// Token: 0x0401C769 RID: 116585
		[Token(Token = "0x401C769")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0__OnScrollWork;

		// Token: 0x0401C76A RID: 116586
		[Token(Token = "0x401C76A")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_SetDirtyCaching;

		// Token: 0x0401C76B RID: 116587
		[Token(Token = "0x401C76B")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0401C76C RID: 116588
		[Token(Token = "0x401C76C")]
		[FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x0401C76D RID: 116589
		[Token(Token = "0x401C76D")]
		[FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x0401C76E RID: 116590
		[Token(Token = "0x401C76E")]
		[FieldOffset(Offset = "0x398")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C76F RID: 116591
		[Token(Token = "0x401C76F")]
		[FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge get_transform;

		// Token: 0x02003A40 RID: 14912
		[Token(Token = "0x2003A40")]
		[Serializable]
		private class FlingConfig
		{
			// Token: 0x06017914 RID: 96532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017914")]
			[Address(RVA = "0xFEA4C0", Offset = "0xFE90C0", VA = "0x180FEA4C0")]
			public FlingConfig()
			{
			}

			// Token: 0x0401C770 RID: 116592
			[Token(Token = "0x401C770")]
			[FieldOffset(Offset = "0x10")]
			public bool enabled;

			// Token: 0x0401C771 RID: 116593
			[Token(Token = "0x401C771")]
			[FieldOffset(Offset = "0x14")]
			public float maxVelocity;

			// Token: 0x0401C772 RID: 116594
			[Token(Token = "0x401C772")]
			[FieldOffset(Offset = "0x18")]
			public float factor;
		}

		// Token: 0x02003A41 RID: 14913
		[Token(Token = "0x2003A41")]
		private struct DecelerationConfig
		{
			// Token: 0x0401C773 RID: 116595
			[Token(Token = "0x401C773")]
			[FieldOffset(Offset = "0x0")]
			public bool useInertia;

			// Token: 0x0401C774 RID: 116596
			[Token(Token = "0x401C774")]
			[FieldOffset(Offset = "0x1")]
			public bool useFriction;

			// Token: 0x0401C775 RID: 116597
			[Token(Token = "0x401C775")]
			[FieldOffset(Offset = "0x4")]
			public float frictionVal;

			// Token: 0x0401C776 RID: 116598
			[Token(Token = "0x401C776")]
			[FieldOffset(Offset = "0x8")]
			public float decelerationRate;

			// Token: 0x0401C777 RID: 116599
			[Token(Token = "0x401C777")]
			[FieldOffset(Offset = "0xC")]
			public float deltaTime;

			// Token: 0x0401C778 RID: 116600
			[Token(Token = "0x401C778")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 velocity;
		}

		// Token: 0x02003A42 RID: 14914
		[Token(Token = "0x2003A42")]
		public abstract class Wrapper
		{
			// Token: 0x06017915 RID: 96533 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017915")]
			[Address(RVA = "0xFF9470", Offset = "0xFF8070", VA = "0x180FF9470")]
			public static UIWrappedScrollRect.Wrapper WrapScrollComponent(Component host)
			{
				return null;
			}

			// Token: 0x17003890 RID: 14480
			// (get) Token: 0x06017916 RID: 96534
			// (set) Token: 0x06017917 RID: 96535
			[Token(Token = "0x17003890")]
			public abstract bool vertical { [Token(Token = "0x6017916")] get; [Token(Token = "0x6017917")] set; }

			// Token: 0x17003891 RID: 14481
			// (get) Token: 0x06017918 RID: 96536
			// (set) Token: 0x06017919 RID: 96537
			[Token(Token = "0x17003891")]
			public abstract bool horizontal { [Token(Token = "0x6017918")] get; [Token(Token = "0x6017919")] set; }

			// Token: 0x17003892 RID: 14482
			// (get) Token: 0x0601791A RID: 96538
			// (set) Token: 0x0601791B RID: 96539
			[Token(Token = "0x17003892")]
			public abstract RectTransform content { [Token(Token = "0x601791A")] get; [Token(Token = "0x601791B")] set; }

			// Token: 0x17003893 RID: 14483
			// (get) Token: 0x0601791C RID: 96540
			[Token(Token = "0x17003893")]
			public abstract Vector2 wholeContentSize { [Token(Token = "0x601791C")] get; }

			// Token: 0x17003894 RID: 14484
			// (get) Token: 0x0601791D RID: 96541
			// (set) Token: 0x0601791E RID: 96542
			[Token(Token = "0x17003894")]
			public abstract RectTransform viewport { [Token(Token = "0x601791D")] get; [Token(Token = "0x601791E")] set; }

			// Token: 0x17003895 RID: 14485
			// (get) Token: 0x0601791F RID: 96543
			// (set) Token: 0x06017920 RID: 96544
			[Token(Token = "0x17003895")]
			public abstract float verticalNormalizedPosition { [Token(Token = "0x601791F")] get; [Token(Token = "0x6017920")] set; }

			// Token: 0x17003896 RID: 14486
			// (get) Token: 0x06017921 RID: 96545
			// (set) Token: 0x06017922 RID: 96546
			[Token(Token = "0x17003896")]
			public abstract float horizontalNormalizedPosition { [Token(Token = "0x6017921")] get; [Token(Token = "0x6017922")] set; }

			// Token: 0x17003897 RID: 14487
			// (get) Token: 0x06017923 RID: 96547
			// (set) Token: 0x06017924 RID: 96548
			[Token(Token = "0x17003897")]
			public abstract Vector2 normalizedPosition { [Token(Token = "0x6017923")] get; [Token(Token = "0x6017924")] set; }

			// Token: 0x06017925 RID: 96549
			[Token(Token = "0x6017925")]
			public abstract void AddOnValueChangedListener(UnityAction<Vector2> callback);

			// Token: 0x06017926 RID: 96550
			[Token(Token = "0x6017926")]
			public abstract void RemoveOnValueChangedListener(UnityAction<Vector2> callback);

			// Token: 0x06017927 RID: 96551
			[Token(Token = "0x6017927")]
			public abstract void AddOnPostLayoutListener(Action onLayoutRebuilt);

			// Token: 0x06017928 RID: 96552
			[Token(Token = "0x6017928")]
			public abstract void RemoveOnPostLayoutListener(Action onLayoutRebuilt);

			// Token: 0x06017929 RID: 96553
			[Token(Token = "0x6017929")]
			public abstract void StopMovement();

			// Token: 0x0601792A RID: 96554
			[Token(Token = "0x601792A")]
			public abstract void TriggerWheelBinding(PointerEventData eventData);

			// Token: 0x0601792B RID: 96555
			[Token(Token = "0x601792B")]
			public abstract ScrollWheelHandler GetWheelBinding();

			// Token: 0x0601792C RID: 96556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601792C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected Wrapper()
			{
			}
		}

		// Token: 0x02003A43 RID: 14915
		[Token(Token = "0x2003A43")]
		private class ScrollRectWrapper : UIWrappedScrollRect.Wrapper
		{
			// Token: 0x0601792D RID: 96557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601792D")]
			[Address(RVA = "0xFEE710", Offset = "0xFED310", VA = "0x180FEE710")]
			public ScrollRectWrapper(IDragHandler iDragHandler)
			{
			}

			// Token: 0x17003898 RID: 14488
			// (get) Token: 0x0601792E RID: 96558 RVA: 0x00097398 File Offset: 0x00095598
			// (set) Token: 0x0601792F RID: 96559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003898")]
			public override bool vertical
			{
				[Token(Token = "0x601792E")]
				[Address(RVA = "0xFEE8A0", Offset = "0xFED4A0", VA = "0x180FEE8A0", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x601792F")]
				[Address(RVA = "0xFEEA00", Offset = "0xFED600", VA = "0x180FEEA00", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17003899 RID: 14489
			// (get) Token: 0x06017930 RID: 96560 RVA: 0x000973B0 File Offset: 0x000955B0
			// (set) Token: 0x06017931 RID: 96561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003899")]
			public override bool horizontal
			{
				[Token(Token = "0x6017930")]
				[Address(RVA = "0xFEE840", Offset = "0xFED440", VA = "0x180FEE840", Slot = "6")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6017931")]
				[Address(RVA = "0xFEE9A0", Offset = "0xFED5A0", VA = "0x180FEE9A0", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x1700389A RID: 14490
			// (get) Token: 0x06017932 RID: 96562 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017933 RID: 96563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700389A")]
			public override RectTransform content
			{
				[Token(Token = "0x6017932")]
				[Address(RVA = "0x5B5460", Offset = "0x5B4060", VA = "0x1805B5460", Slot = "8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6017933")]
				[Address(RVA = "0xFEE950", Offset = "0xFED550", VA = "0x180FEE950", Slot = "9")]
				set
				{
				}
			}

			// Token: 0x1700389B RID: 14491
			// (get) Token: 0x06017934 RID: 96564 RVA: 0x000973C8 File Offset: 0x000955C8
			[Token(Token = "0x1700389B")]
			public override Vector2 wholeContentSize
			{
				[Token(Token = "0x6017934")]
				[Address(RVA = "0xFEE8E0", Offset = "0xFED4E0", VA = "0x180FEE8E0", Slot = "10")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x1700389C RID: 14492
			// (get) Token: 0x06017935 RID: 96565 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017936 RID: 96566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700389C")]
			public override RectTransform viewport
			{
				[Token(Token = "0x6017935")]
				[Address(RVA = "0xFEE8C0", Offset = "0xFED4C0", VA = "0x180FEE8C0", Slot = "11")]
				get
				{
					return null;
				}
				[Token(Token = "0x6017936")]
				[Address(RVA = "0xFEEA20", Offset = "0xFED620", VA = "0x180FEEA20", Slot = "12")]
				set
				{
				}
			}

			// Token: 0x1700389D RID: 14493
			// (get) Token: 0x06017937 RID: 96567 RVA: 0x000973E0 File Offset: 0x000955E0
			// (set) Token: 0x06017938 RID: 96568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700389D")]
			public override float verticalNormalizedPosition
			{
				[Token(Token = "0x6017937")]
				[Address(RVA = "0xFEE880", Offset = "0xFED480", VA = "0x180FEE880", Slot = "13")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6017938")]
				[Address(RVA = "0xFEE9E0", Offset = "0xFED5E0", VA = "0x180FEE9E0", Slot = "14")]
				set
				{
				}
			}

			// Token: 0x1700389E RID: 14494
			// (get) Token: 0x06017939 RID: 96569 RVA: 0x000973F8 File Offset: 0x000955F8
			// (set) Token: 0x0601793A RID: 96570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700389E")]
			public override float horizontalNormalizedPosition
			{
				[Token(Token = "0x6017939")]
				[Address(RVA = "0xFEE820", Offset = "0xFED420", VA = "0x180FEE820", Slot = "15")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x601793A")]
				[Address(RVA = "0xFEE980", Offset = "0xFED580", VA = "0x180FEE980", Slot = "16")]
				set
				{
				}
			}

			// Token: 0x1700389F RID: 14495
			// (get) Token: 0x0601793B RID: 96571 RVA: 0x00097410 File Offset: 0x00095610
			// (set) Token: 0x0601793C RID: 96572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700389F")]
			public override Vector2 normalizedPosition
			{
				[Token(Token = "0x601793B")]
				[Address(RVA = "0xFEE860", Offset = "0xFED460", VA = "0x180FEE860", Slot = "17")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x601793C")]
				[Address(RVA = "0xFEE9C0", Offset = "0xFED5C0", VA = "0x180FEE9C0", Slot = "18")]
				set
				{
				}
			}

			// Token: 0x0601793D RID: 96573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601793D")]
			[Address(RVA = "0xFEE4C0", Offset = "0xFED0C0", VA = "0x180FEE4C0", Slot = "19")]
			public override void AddOnValueChangedListener(UnityAction<Vector2> callback)
			{
			}

			// Token: 0x0601793E RID: 96574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601793E")]
			[Address(RVA = "0xFEE640", Offset = "0xFED240", VA = "0x180FEE640", Slot = "20")]
			public override void RemoveOnValueChangedListener(UnityAction<Vector2> callback)
			{
			}

			// Token: 0x0601793F RID: 96575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601793F")]
			[Address(RVA = "0xFEE3B0", Offset = "0xFECFB0", VA = "0x180FEE3B0", Slot = "21")]
			public override void AddOnPostLayoutListener(Action onLayoutRebuilt)
			{
			}

			// Token: 0x06017940 RID: 96576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017940")]
			[Address(RVA = "0xFEE540", Offset = "0xFED140", VA = "0x180FEE540", Slot = "22")]
			public override void RemoveOnPostLayoutListener(Action onLayoutRebuilt)
			{
			}

			// Token: 0x06017941 RID: 96577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017941")]
			[Address(RVA = "0xFEE6A0", Offset = "0xFED2A0", VA = "0x180FEE6A0", Slot = "23")]
			public override void StopMovement()
			{
			}

			// Token: 0x06017942 RID: 96578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017942")]
			[Address(RVA = "0xFEE6E0", Offset = "0xFED2E0", VA = "0x180FEE6E0", Slot = "24")]
			public override void TriggerWheelBinding(PointerEventData eventData)
			{
			}

			// Token: 0x06017943 RID: 96579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017943")]
			[Address(RVA = "0xFEE520", Offset = "0xFED120", VA = "0x180FEE520", Slot = "25")]
			public override ScrollWheelHandler GetWheelBinding()
			{
				return null;
			}

			// Token: 0x0401C779 RID: 116601
			[Token(Token = "0x401C779")]
			[FieldOffset(Offset = "0x10")]
			private ScrollRect m_inst;
		}

		// Token: 0x02003A44 RID: 14916
		[Token(Token = "0x2003A44")]
		private class LoopScrollRectWrapper : UIWrappedScrollRect.Wrapper
		{
			// Token: 0x06017944 RID: 96580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017944")]
			[Address(RVA = "0xFEA910", Offset = "0xFE9510", VA = "0x180FEA910")]
			public LoopScrollRectWrapper(IDragHandler iDragHandler)
			{
			}

			// Token: 0x170038A0 RID: 14496
			// (get) Token: 0x06017945 RID: 96581 RVA: 0x00097428 File Offset: 0x00095628
			// (set) Token: 0x06017946 RID: 96582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038A0")]
			public override bool vertical
			{
				[Token(Token = "0x6017945")]
				[Address(RVA = "0xFEAAD0", Offset = "0xFE96D0", VA = "0x180FEAAD0", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6017946")]
				[Address(RVA = "0xFEAC10", Offset = "0xFE9810", VA = "0x180FEAC10", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x170038A1 RID: 14497
			// (get) Token: 0x06017947 RID: 96583 RVA: 0x00097440 File Offset: 0x00095640
			// (set) Token: 0x06017948 RID: 96584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038A1")]
			public override bool horizontal
			{
				[Token(Token = "0x6017947")]
				[Address(RVA = "0xFEAA60", Offset = "0xFE9660", VA = "0x180FEAA60", Slot = "6")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6017948")]
				[Address(RVA = "0xFEABA0", Offset = "0xFE97A0", VA = "0x180FEABA0", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x170038A2 RID: 14498
			// (get) Token: 0x06017949 RID: 96585 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601794A RID: 96586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038A2")]
			public override RectTransform content
			{
				[Token(Token = "0x6017949")]
				[Address(RVA = "0xFEAA20", Offset = "0xFE9620", VA = "0x180FEAA20", Slot = "8")]
				get
				{
					return null;
				}
				[Token(Token = "0x601794A")]
				[Address(RVA = "0xFEAB60", Offset = "0xFE9760", VA = "0x180FEAB60", Slot = "9")]
				set
				{
				}
			}

			// Token: 0x170038A3 RID: 14499
			// (get) Token: 0x0601794B RID: 96587 RVA: 0x00097458 File Offset: 0x00095658
			[Token(Token = "0x170038A3")]
			public override Vector2 wholeContentSize
			{
				[Token(Token = "0x601794B")]
				[Address(RVA = "0xFEAB40", Offset = "0xFE9740", VA = "0x180FEAB40", Slot = "10")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x170038A4 RID: 14500
			// (get) Token: 0x0601794C RID: 96588 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601794D RID: 96589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038A4")]
			public override RectTransform viewport
			{
				[Token(Token = "0x601794C")]
				[Address(RVA = "0xFEAB20", Offset = "0xFE9720", VA = "0x180FEAB20", Slot = "11")]
				get
				{
					return null;
				}
				[Token(Token = "0x601794D")]
				[Address(RVA = "0xFEAC60", Offset = "0xFE9860", VA = "0x180FEAC60", Slot = "12")]
				set
				{
				}
			}

			// Token: 0x170038A5 RID: 14501
			// (get) Token: 0x0601794E RID: 96590 RVA: 0x00097470 File Offset: 0x00095670
			// (set) Token: 0x0601794F RID: 96591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038A5")]
			public override float verticalNormalizedPosition
			{
				[Token(Token = "0x601794E")]
				[Address(RVA = "0xFEAAB0", Offset = "0xFE96B0", VA = "0x180FEAAB0", Slot = "13")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x601794F")]
				[Address(RVA = "0xFEABF0", Offset = "0xFE97F0", VA = "0x180FEABF0", Slot = "14")]
				set
				{
				}
			}

			// Token: 0x170038A6 RID: 14502
			// (get) Token: 0x06017950 RID: 96592 RVA: 0x00097488 File Offset: 0x00095688
			// (set) Token: 0x06017951 RID: 96593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038A6")]
			public override float horizontalNormalizedPosition
			{
				[Token(Token = "0x6017950")]
				[Address(RVA = "0xFEAA40", Offset = "0xFE9640", VA = "0x180FEAA40", Slot = "15")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6017951")]
				[Address(RVA = "0xFEAB80", Offset = "0xFE9780", VA = "0x180FEAB80", Slot = "16")]
				set
				{
				}
			}

			// Token: 0x170038A7 RID: 14503
			// (get) Token: 0x06017952 RID: 96594 RVA: 0x000974A0 File Offset: 0x000956A0
			// (set) Token: 0x06017953 RID: 96595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038A7")]
			public override Vector2 normalizedPosition
			{
				[Token(Token = "0x6017952")]
				[Address(RVA = "0xF3CBB0", Offset = "0xF3B7B0", VA = "0x180F3CBB0", Slot = "17")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6017953")]
				[Address(RVA = "0xF3CBD0", Offset = "0xF3B7D0", VA = "0x180F3CBD0", Slot = "18")]
				set
				{
				}
			}

			// Token: 0x06017954 RID: 96596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017954")]
			[Address(RVA = "0xFEA760", Offset = "0xFE9360", VA = "0x180FEA760", Slot = "19")]
			public override void AddOnValueChangedListener(UnityAction<Vector2> callback)
			{
			}

			// Token: 0x06017955 RID: 96597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017955")]
			[Address(RVA = "0xFEA810", Offset = "0xFE9410", VA = "0x180FEA810", Slot = "20")]
			public override void RemoveOnValueChangedListener(UnityAction<Vector2> callback)
			{
			}

			// Token: 0x06017956 RID: 96598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017956")]
			[Address(RVA = "0xFEA740", Offset = "0xFE9340", VA = "0x180FEA740", Slot = "21")]
			public override void AddOnPostLayoutListener(Action onLayoutRebuilt)
			{
			}

			// Token: 0x06017957 RID: 96599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017957")]
			[Address(RVA = "0xFEA7F0", Offset = "0xFE93F0", VA = "0x180FEA7F0", Slot = "22")]
			public override void RemoveOnPostLayoutListener(Action onLayoutRebuilt)
			{
			}

			// Token: 0x06017958 RID: 96600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017958")]
			[Address(RVA = "0xFEA880", Offset = "0xFE9480", VA = "0x180FEA880", Slot = "23")]
			public override void StopMovement()
			{
			}

			// Token: 0x06017959 RID: 96601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017959")]
			[Address(RVA = "0xFEA8C0", Offset = "0xFE94C0", VA = "0x180FEA8C0", Slot = "24")]
			public override void TriggerWheelBinding(PointerEventData eventData)
			{
			}

			// Token: 0x0601795A RID: 96602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601795A")]
			[Address(RVA = "0xFEA7D0", Offset = "0xFE93D0", VA = "0x180FEA7D0", Slot = "25")]
			public override ScrollWheelHandler GetWheelBinding()
			{
				return null;
			}

			// Token: 0x0401C77A RID: 116602
			[Token(Token = "0x401C77A")]
			[FieldOffset(Offset = "0x10")]
			private LoopScrollRect m_inst;
		}

		// Token: 0x02003A45 RID: 14917
		[Token(Token = "0x2003A45")]
		private class SelfWrapper : UIWrappedScrollRect.Wrapper
		{
			// Token: 0x0601795B RID: 96603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601795B")]
			[Address(RVA = "0xFEEDA0", Offset = "0xFED9A0", VA = "0x180FEEDA0")]
			public SelfWrapper(IDragHandler iDragHandler)
			{
			}

			// Token: 0x170038A8 RID: 14504
			// (get) Token: 0x0601795C RID: 96604 RVA: 0x000974B8 File Offset: 0x000956B8
			// (set) Token: 0x0601795D RID: 96605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038A8")]
			public override bool vertical
			{
				[Token(Token = "0x601795C")]
				[Address(RVA = "0xFEEF50", Offset = "0xFEDB50", VA = "0x180FEEF50", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x601795D")]
				[Address(RVA = "0xFEF030", Offset = "0xFEDC30", VA = "0x180FEF030", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x170038A9 RID: 14505
			// (get) Token: 0x0601795E RID: 96606 RVA: 0x000974D0 File Offset: 0x000956D0
			// (set) Token: 0x0601795F RID: 96607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038A9")]
			public override bool horizontal
			{
				[Token(Token = "0x601795E")]
				[Address(RVA = "0xFEEEF0", Offset = "0xFEDAF0", VA = "0x180FEEEF0", Slot = "6")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x601795F")]
				[Address(RVA = "0xFEEFD0", Offset = "0xFEDBD0", VA = "0x180FEEFD0", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x170038AA RID: 14506
			// (get) Token: 0x06017960 RID: 96608 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017961 RID: 96609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038AA")]
			public override RectTransform content
			{
				[Token(Token = "0x6017960")]
				[Address(RVA = "0xFEEEB0", Offset = "0xFEDAB0", VA = "0x180FEEEB0", Slot = "8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6017961")]
				[Address(RVA = "0xFEEF90", Offset = "0xFEDB90", VA = "0x180FEEF90", Slot = "9")]
				set
				{
				}
			}

			// Token: 0x170038AB RID: 14507
			// (get) Token: 0x06017962 RID: 96610 RVA: 0x000974E8 File Offset: 0x000956E8
			[Token(Token = "0x170038AB")]
			public override Vector2 wholeContentSize
			{
				[Token(Token = "0x6017962")]
				[Address(RVA = "0xFEE8E0", Offset = "0xFED4E0", VA = "0x180FEE8E0", Slot = "10")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x170038AC RID: 14508
			// (get) Token: 0x06017963 RID: 96611 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017964 RID: 96612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038AC")]
			public override RectTransform viewport
			{
				[Token(Token = "0x6017963")]
				[Address(RVA = "0xFEEF70", Offset = "0xFEDB70", VA = "0x180FEEF70", Slot = "11")]
				get
				{
					return null;
				}
				[Token(Token = "0x6017964")]
				[Address(RVA = "0xFEF050", Offset = "0xFEDC50", VA = "0x180FEF050", Slot = "12")]
				set
				{
				}
			}

			// Token: 0x170038AD RID: 14509
			// (get) Token: 0x06017965 RID: 96613 RVA: 0x00097500 File Offset: 0x00095700
			// (set) Token: 0x06017966 RID: 96614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038AD")]
			public override float verticalNormalizedPosition
			{
				[Token(Token = "0x6017965")]
				[Address(RVA = "0xFEEF30", Offset = "0xFEDB30", VA = "0x180FEEF30", Slot = "13")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6017966")]
				[Address(RVA = "0xFEF010", Offset = "0xFEDC10", VA = "0x180FEF010", Slot = "14")]
				set
				{
				}
			}

			// Token: 0x170038AE RID: 14510
			// (get) Token: 0x06017967 RID: 96615 RVA: 0x00097518 File Offset: 0x00095718
			// (set) Token: 0x06017968 RID: 96616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038AE")]
			public override float horizontalNormalizedPosition
			{
				[Token(Token = "0x6017967")]
				[Address(RVA = "0xFEEED0", Offset = "0xFEDAD0", VA = "0x180FEEED0", Slot = "15")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6017968")]
				[Address(RVA = "0xFEEFB0", Offset = "0xFEDBB0", VA = "0x180FEEFB0", Slot = "16")]
				set
				{
				}
			}

			// Token: 0x170038AF RID: 14511
			// (get) Token: 0x06017969 RID: 96617 RVA: 0x00097530 File Offset: 0x00095730
			// (set) Token: 0x0601796A RID: 96618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038AF")]
			public override Vector2 normalizedPosition
			{
				[Token(Token = "0x6017969")]
				[Address(RVA = "0xFEEF10", Offset = "0xFEDB10", VA = "0x180FEEF10", Slot = "17")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x601796A")]
				[Address(RVA = "0xFEEFF0", Offset = "0xFEDBF0", VA = "0x180FEEFF0", Slot = "18")]
				set
				{
				}
			}

			// Token: 0x0601796B RID: 96619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601796B")]
			[Address(RVA = "0xFEEB50", Offset = "0xFED750", VA = "0x180FEEB50", Slot = "19")]
			public override void AddOnValueChangedListener(UnityAction<Vector2> callback)
			{
			}

			// Token: 0x0601796C RID: 96620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601796C")]
			[Address(RVA = "0xFEECE0", Offset = "0xFED8E0", VA = "0x180FEECE0", Slot = "20")]
			public override void RemoveOnValueChangedListener(UnityAction<Vector2> callback)
			{
			}

			// Token: 0x0601796D RID: 96621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601796D")]
			[Address(RVA = "0xFEEA40", Offset = "0xFED640", VA = "0x180FEEA40", Slot = "21")]
			public override void AddOnPostLayoutListener(Action onLayoutRebuilt)
			{
			}

			// Token: 0x0601796E RID: 96622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601796E")]
			[Address(RVA = "0xFEEBE0", Offset = "0xFED7E0", VA = "0x180FEEBE0", Slot = "22")]
			public override void RemoveOnPostLayoutListener(Action onLayoutRebuilt)
			{
			}

			// Token: 0x0601796F RID: 96623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601796F")]
			[Address(RVA = "0xFEE6A0", Offset = "0xFED2A0", VA = "0x180FEE6A0", Slot = "23")]
			public override void StopMovement()
			{
			}

			// Token: 0x06017970 RID: 96624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017970")]
			[Address(RVA = "0xFEED50", Offset = "0xFED950", VA = "0x180FEED50", Slot = "24")]
			public override void TriggerWheelBinding(PointerEventData eventData)
			{
			}

			// Token: 0x06017971 RID: 96625 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017971")]
			[Address(RVA = "0xFEEBC0", Offset = "0xFED7C0", VA = "0x180FEEBC0", Slot = "25")]
			public override ScrollWheelHandler GetWheelBinding()
			{
				return null;
			}

			// Token: 0x0401C77B RID: 116603
			[Token(Token = "0x401C77B")]
			[FieldOffset(Offset = "0x10")]
			private UIWrappedScrollRect m_inst;
		}

		// Token: 0x02003A46 RID: 14918
		[Token(Token = "0x2003A46")]
		public enum MovementType
		{
			// Token: 0x0401C77D RID: 116605
			[Token(Token = "0x401C77D")]
			Unrestricted,
			// Token: 0x0401C77E RID: 116606
			[Token(Token = "0x401C77E")]
			Elastic,
			// Token: 0x0401C77F RID: 116607
			[Token(Token = "0x401C77F")]
			Clamped
		}

		// Token: 0x02003A47 RID: 14919
		[Token(Token = "0x2003A47")]
		public enum ScrollbarVisibility
		{
			// Token: 0x0401C781 RID: 116609
			[Token(Token = "0x401C781")]
			Permanent,
			// Token: 0x0401C782 RID: 116610
			[Token(Token = "0x401C782")]
			AutoHide,
			// Token: 0x0401C783 RID: 116611
			[Token(Token = "0x401C783")]
			AutoHideAndExpandViewport
		}

		// Token: 0x02003A48 RID: 14920
		[Token(Token = "0x2003A48")]
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			// Token: 0x06017972 RID: 96626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017972")]
			[Address(RVA = "0xFEE370", Offset = "0xFECF70", VA = "0x180FEE370")]
			public ScrollRectEvent()
			{
			}
		}

		// Token: 0x02003A49 RID: 14921
		[Token(Token = "0x2003A49")]
		private struct NormPosRequest
		{
			// Token: 0x170038B0 RID: 14512
			// (get) Token: 0x06017973 RID: 96627 RVA: 0x00097548 File Offset: 0x00095748
			// (set) Token: 0x06017974 RID: 96628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038B0")]
			public bool hasHoriAxis
			{
				[Token(Token = "0x6017973")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x6017974")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170038B1 RID: 14513
			// (get) Token: 0x06017975 RID: 96629 RVA: 0x00097560 File Offset: 0x00095760
			// (set) Token: 0x06017976 RID: 96630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038B1")]
			public float horiVal
			{
				[Token(Token = "0x6017975")]
				[Address(RVA = "0x877280", Offset = "0x875E80", VA = "0x180877280")]
				[CompilerGenerated]
				readonly get
				{
					return 0f;
				}
				[Token(Token = "0x6017976")]
				[Address(RVA = "0x8772B0", Offset = "0x875EB0", VA = "0x1808772B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170038B2 RID: 14514
			// (get) Token: 0x06017977 RID: 96631 RVA: 0x00097578 File Offset: 0x00095778
			// (set) Token: 0x06017978 RID: 96632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038B2")]
			public bool hasVertAxis
			{
				[Token(Token = "0x6017977")]
				[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x6017978")]
				[Address(RVA = "0xFEDEE0", Offset = "0xFECAE0", VA = "0x180FEDEE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170038B3 RID: 14515
			// (get) Token: 0x06017979 RID: 96633 RVA: 0x00097590 File Offset: 0x00095790
			// (set) Token: 0x0601797A RID: 96634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038B3")]
			public float vertVal
			{
				[Token(Token = "0x6017979")]
				[Address(RVA = "0x877270", Offset = "0x875E70", VA = "0x180877270")]
				[CompilerGenerated]
				readonly get
				{
					return 0f;
				}
				[Token(Token = "0x601797A")]
				[Address(RVA = "0x8772A0", Offset = "0x875EA0", VA = "0x1808772A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601797B RID: 96635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601797B")]
			[Address(RVA = "0xFEDEA0", Offset = "0xFECAA0", VA = "0x180FEDEA0")]
			public void Request(float val, int axis)
			{
			}
		}

		// Token: 0x02003A4A RID: 14922
		[Token(Token = "0x2003A4A")]
		private class DragDelegate
		{
			// Token: 0x170038B4 RID: 14516
			// (get) Token: 0x0601797C RID: 96636 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601797D RID: 96637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038B4")]
			public IDragHandler target
			{
				[Token(Token = "0x601797C")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601797D")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601797E RID: 96638 RVA: 0x000975A8 File Offset: 0x000957A8
			[Token(Token = "0x601797E")]
			[Address(RVA = "0xFE9700", Offset = "0xFE8300", VA = "0x180FE9700")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0601797F RID: 96639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601797F")]
			[Address(RVA = "0xFE94E0", Offset = "0xFE80E0", VA = "0x180FE94E0")]
			public void FindDelegateInParent(UIWrappedScrollRect current)
			{
			}

			// Token: 0x06017980 RID: 96640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017980")]
			[Address(RVA = "0xFE97B0", Offset = "0xFE83B0", VA = "0x180FE97B0")]
			public void SetDelegate(UIWrappedScrollRect current, IDragHandler handler)
			{
			}

			// Token: 0x06017981 RID: 96641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017981")]
			[Address(RVA = "0xFE9AD0", Offset = "0xFE86D0", VA = "0x180FE9AD0")]
			private void _SetDelegateImpl(UIWrappedScrollRect current, IDragHandler handler)
			{
			}

			// Token: 0x06017982 RID: 96642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017982")]
			[Address(RVA = "0xFE95B0", Offset = "0xFE81B0", VA = "0x180FE95B0")]
			public void InitDrag(PointerEventData eventData)
			{
			}

			// Token: 0x06017983 RID: 96643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017983")]
			[Address(RVA = "0xFE9820", Offset = "0xFE8420", VA = "0x180FE9820")]
			public void UpdateDrag(PointerEventData eventData, out bool isDragValid, out bool interruptDragThisFrame)
			{
			}

			// Token: 0x06017984 RID: 96644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017984")]
			[Address(RVA = "0xFE9480", Offset = "0xFE8080", VA = "0x180FE9480")]
			public void EndDrag(PointerEventData eventData)
			{
			}

			// Token: 0x06017985 RID: 96645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017985")]
			[Address(RVA = "0xFE97C0", Offset = "0xFE83C0", VA = "0x180FE97C0")]
			public void StopCurrentDrag()
			{
			}

			// Token: 0x06017986 RID: 96646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017986")]
			[Address(RVA = "0xFE9BE0", Offset = "0xFE87E0", VA = "0x180FE9BE0")]
			public DragDelegate()
			{
			}

			// Token: 0x0401C789 RID: 116617
			[Token(Token = "0x401C789")]
			[FieldOffset(Offset = "0x18")]
			private IInitializePotentialDragHandler m_initDragHandler;

			// Token: 0x0401C78A RID: 116618
			[Token(Token = "0x401C78A")]
			[FieldOffset(Offset = "0x20")]
			private IBeginDragHandler m_beginDragHandler;

			// Token: 0x0401C78B RID: 116619
			[Token(Token = "0x401C78B")]
			[FieldOffset(Offset = "0x28")]
			private IEndDragHandler m_endDragHandler;

			// Token: 0x0401C78C RID: 116620
			[Token(Token = "0x401C78C")]
			[FieldOffset(Offset = "0x30")]
			private UIWrappedScrollRect m_current;

			// Token: 0x0401C78D RID: 116621
			[Token(Token = "0x401C78D")]
			private const int SYS_DISABLED = 0;

			// Token: 0x0401C78E RID: 116622
			[Token(Token = "0x401C78E")]
			private const int DRAG_UNKNOWN = 1;

			// Token: 0x0401C78F RID: 116623
			[Token(Token = "0x401C78F")]
			private const int DRAG_ACCEPTED = 2;

			// Token: 0x0401C790 RID: 116624
			[Token(Token = "0x401C790")]
			private const int DRAG_DELEGATED = 3;

			// Token: 0x0401C791 RID: 116625
			[Token(Token = "0x401C791")]
			[FieldOffset(Offset = "0x38")]
			private int m_dragStatus;

			// Token: 0x0401C792 RID: 116626
			[Token(Token = "0x401C792")]
			[FieldOffset(Offset = "0x40")]
			private PointerEventData m_beginDragEvt;

			// Token: 0x0401C793 RID: 116627
			[Token(Token = "0x401C793")]
			[FieldOffset(Offset = "0x48")]
			private Vector2 m_beginDragPos;
		}
	}
}
