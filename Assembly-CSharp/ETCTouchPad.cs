using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
[Serializable]
public class ETCTouchPad : ETCBase, IBeginDragHandler, IEventSystemHandler, IDragHandler, IPointerEnterHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
	// Token: 0x0600019E RID: 414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x511C50", Offset = "0x510850", VA = "0x180511C50")]
	public ETCTouchPad()
	{
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x510B70", Offset = "0x50F770", VA = "0x180510B70", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x510D30", Offset = "0x50F930", VA = "0x180510D30", Slot = "6")]
	public override void OnEnable()
	{
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x511530", Offset = "0x510130", VA = "0x180511530", Slot = "5")]
	public override void Start()
	{
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x511600", Offset = "0x510200", VA = "0x180511600", Slot = "10")]
	protected override void UpdateControlState()
	{
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x4FE220", Offset = "0x4FCE20", VA = "0x1804FE220", Slot = "13")]
	protected override void DoActionBeforeEndOfFrame()
	{
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x510E70", Offset = "0x50FA70", VA = "0x180510E70", Slot = "16")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x510BD0", Offset = "0x50F7D0", VA = "0x180510BD0", Slot = "14")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x510C10", Offset = "0x50F810", VA = "0x180510C10", Slot = "15")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x510DE0", Offset = "0x50F9E0", VA = "0x180510DE0", Slot = "17")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x5110E0", Offset = "0x50FCE0", VA = "0x1805110E0", Slot = "18")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x5110A0", Offset = "0x50FCA0", VA = "0x1805110A0", Slot = "19")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x511610", Offset = "0x510210", VA = "0x180511610")]
	private void UpdateTouchPad()
	{
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x5114A0", Offset = "0x5100A0", VA = "0x1805114A0", Slot = "11")]
	protected override void SetVisible(bool forceUnvisible = false)
	{
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x511370", Offset = "0x50FF70", VA = "0x180511370", Slot = "12")]
	protected override void SetActivated()
	{
	}

	// Token: 0x040001B1 RID: 433
	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public ETCTouchPad.OnMoveStartHandler onMoveStart;

	// Token: 0x040001B2 RID: 434
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public ETCTouchPad.OnMoveHandler onMove;

	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public ETCTouchPad.OnMoveSpeedHandler onMoveSpeed;

	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public ETCTouchPad.OnMoveEndHandler onMoveEnd;

	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public ETCTouchPad.OnTouchStartHandler onTouchStart;

	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public ETCTouchPad.OnTouchUPHandler onTouchUp;

	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	public ETCTouchPad.OnDownUpHandler OnDownUp;

	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	public ETCTouchPad.OnDownDownHandler OnDownDown;

	// Token: 0x040001B9 RID: 441
	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	public ETCTouchPad.OnDownLeftHandler OnDownLeft;

	// Token: 0x040001BA RID: 442
	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	public ETCTouchPad.OnDownRightHandler OnDownRight;

	// Token: 0x040001BB RID: 443
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	public ETCTouchPad.OnDownUpHandler OnPressUp;

	// Token: 0x040001BC RID: 444
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	public ETCTouchPad.OnDownDownHandler OnPressDown;

	// Token: 0x040001BD RID: 445
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	public ETCTouchPad.OnDownLeftHandler OnPressLeft;

	// Token: 0x040001BE RID: 446
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	public ETCTouchPad.OnDownRightHandler OnPressRight;

	// Token: 0x040001BF RID: 447
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x148")]
	public ETCAxis axisX;

	// Token: 0x040001C0 RID: 448
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x150")]
	public ETCAxis axisY;

	// Token: 0x040001C1 RID: 449
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x158")]
	public bool isDPI;

	// Token: 0x040001C2 RID: 450
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x160")]
	private Image cachedImage;

	// Token: 0x040001C3 RID: 451
	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x168")]
	private Vector2 tmpAxis;

	// Token: 0x040001C4 RID: 452
	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x170")]
	private Vector2 OldTmpAxis;

	// Token: 0x040001C5 RID: 453
	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x178")]
	private GameObject previousDargObject;

	// Token: 0x040001C6 RID: 454
	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x180")]
	private bool isOut;

	// Token: 0x040001C7 RID: 455
	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x181")]
	private bool isOnTouch;

	// Token: 0x040001C8 RID: 456
	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x182")]
	private bool cachedVisible;

	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[Serializable]
	public class OnMoveStartHandler : UnityEvent
	{
		// Token: 0x060001AD RID: 429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnMoveStartHandler()
		{
		}
	}

	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[Serializable]
	public class OnMoveHandler : UnityEvent<Vector2>
	{
		// Token: 0x060001AE RID: 430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x5132A0", Offset = "0x511EA0", VA = "0x1805132A0")]
		public OnMoveHandler()
		{
		}
	}

	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[Serializable]
	public class OnMoveSpeedHandler : UnityEvent<Vector2>
	{
		// Token: 0x060001AF RID: 431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x513320", Offset = "0x511F20", VA = "0x180513320")]
		public OnMoveSpeedHandler()
		{
		}
	}

	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Serializable]
	public class OnMoveEndHandler : UnityEvent
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnMoveEndHandler()
		{
		}
	}

	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[Serializable]
	public class OnTouchStartHandler : UnityEvent
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnTouchStartHandler()
		{
		}
	}

	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Serializable]
	public class OnTouchUPHandler : UnityEvent
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnTouchUPHandler()
		{
		}
	}

	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[Serializable]
	public class OnDownUpHandler : UnityEvent
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownUpHandler()
		{
		}
	}

	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[Serializable]
	public class OnDownDownHandler : UnityEvent
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownDownHandler()
		{
		}
	}

	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[Serializable]
	public class OnDownLeftHandler : UnityEvent
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownLeftHandler()
		{
		}
	}

	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Serializable]
	public class OnDownRightHandler : UnityEvent
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownRightHandler()
		{
		}
	}

	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[Serializable]
	public class OnPressUpHandler : UnityEvent
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressUpHandler()
		{
		}
	}

	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	[Serializable]
	public class OnPressDownHandler : UnityEvent
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressDownHandler()
		{
		}
	}

	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[Serializable]
	public class OnPressLeftHandler : UnityEvent
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressLeftHandler()
		{
		}
	}

	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[Serializable]
	public class OnPressRightHandler : UnityEvent
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressRightHandler()
		{
		}
	}
}
