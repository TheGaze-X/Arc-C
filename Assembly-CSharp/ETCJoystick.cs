using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x02000053 RID: 83
[Token(Token = "0x2000053")]
[Serializable]
public class ETCJoystick : ETCBase, IPointerEnterHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IPointerDownHandler, IPointerUpHandler
{
	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000173 RID: 371 RVA: 0x000027F0 File Offset: 0x000009F0
	// (set) Token: 0x06000172 RID: 370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000028")]
	public bool isStarted
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x5082F0", Offset = "0x506EF0", VA = "0x1805082F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x508700", Offset = "0x507300", VA = "0x180508700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000174 RID: 372 RVA: 0x00002808 File Offset: 0x00000A08
	// (set) Token: 0x06000175 RID: 373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000029")]
	public bool IsNoReturnThumb
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x5082E0", Offset = "0x506EE0", VA = "0x1805082E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x5086F0", Offset = "0x5072F0", VA = "0x1805086F0")]
		set
		{
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000176 RID: 374 RVA: 0x00002820 File Offset: 0x00000A20
	// (set) Token: 0x06000177 RID: 375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700002A")]
	public bool IsNoOffsetThumb
	{
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x5082D0", Offset = "0x506ED0", VA = "0x1805082D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x5086E0", Offset = "0x5072E0", VA = "0x1805086E0")]
		set
		{
		}
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x508110", Offset = "0x506D10", VA = "0x180508110")]
	public ETCJoystick()
	{
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x5059A0", Offset = "0x5045A0", VA = "0x1805059A0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x506E30", Offset = "0x505A30", VA = "0x180506E30", Slot = "5")]
	public override void Start()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x507C30", Offset = "0x506830", VA = "0x180507C30", Slot = "7")]
	public override void Update()
	{
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x5064D0", Offset = "0x5050D0", VA = "0x1805064D0", Slot = "9")]
	public override void LateUpdate()
	{
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x506170", Offset = "0x504D70", VA = "0x180506170")]
	private void InitCameraLookAt()
	{
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x507220", Offset = "0x505E20", VA = "0x180507220", Slot = "10")]
	protected override void UpdateControlState()
	{
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x506910", Offset = "0x505510", VA = "0x180506910", Slot = "14")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x5068B0", Offset = "0x5054B0", VA = "0x1805068B0", Slot = "17")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x506550", Offset = "0x505150", VA = "0x180506550", Slot = "15")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x5069D0", Offset = "0x5055D0", VA = "0x1805069D0", Slot = "18")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x506A00", Offset = "0x505600", VA = "0x180506A00")]
	private void OnUp(bool real = true)
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x505B60", Offset = "0x504760", VA = "0x180505B60", Slot = "13")]
	protected override void DoActionBeforeEndOfFrame()
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x507250", Offset = "0x505E50", VA = "0x180507250")]
	private void UpdateJoystick()
	{
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002838 File Offset: 0x00000A38
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x5085D0", Offset = "0x5071D0", VA = "0x1805085D0")]
	private bool isTouchOverJoystickArea(ref Vector2 localPosition, ref Vector2 screenPosition)
	{
		return default(bool);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002850 File Offset: 0x00000A50
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x508300", Offset = "0x506F00", VA = "0x180508300")]
	private bool isScreenPointOverArea(Vector2 screenPosition, ref Vector2 localPosition)
	{
		return default(bool);
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x506140", Offset = "0x504D40", VA = "0x180506140")]
	private int GetTouchCount()
	{
		return 0;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002880 File Offset: 0x00000A80
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x5060C0", Offset = "0x504CC0", VA = "0x1805060C0")]
	public float GetRadius()
	{
		return 0f;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x506CF0", Offset = "0x5058F0", VA = "0x180506CF0", Slot = "12")]
	protected override void SetActivated()
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x506D60", Offset = "0x505960", VA = "0x180506D60", Slot = "11")]
	protected override void SetVisible(bool visible = true)
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x505BA0", Offset = "0x5047A0", VA = "0x180505BA0")]
	private void DoTurnAndMove()
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x5062E0", Offset = "0x504EE0", VA = "0x1805062E0")]
	public void InitCurve()
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x506450", Offset = "0x505050", VA = "0x180506450")]
	public void InitTurnMoveCurve()
	{
	}

	// Token: 0x04000178 RID: 376
	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public ETCJoystick.OnMoveStartHandler onMoveStart;

	// Token: 0x04000179 RID: 377
	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public ETCJoystick.OnMoveHandler onMove;

	// Token: 0x0400017A RID: 378
	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public ETCJoystick.OnMoveSpeedHandler onMoveSpeed;

	// Token: 0x0400017B RID: 379
	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public ETCJoystick.OnMoveEndHandler onMoveEnd;

	// Token: 0x0400017C RID: 380
	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public ETCJoystick.OnTouchStartHandler onTouchStart;

	// Token: 0x0400017D RID: 381
	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public ETCJoystick.OnTouchUpHandler onTouchUp;

	// Token: 0x0400017E RID: 382
	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	public ETCJoystick.OnDownUpHandler OnDownUp;

	// Token: 0x0400017F RID: 383
	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	public ETCJoystick.OnDownDownHandler OnDownDown;

	// Token: 0x04000180 RID: 384
	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	public ETCJoystick.OnDownLeftHandler OnDownLeft;

	// Token: 0x04000181 RID: 385
	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	public ETCJoystick.OnDownRightHandler OnDownRight;

	// Token: 0x04000182 RID: 386
	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	public ETCJoystick.OnDownUpHandler OnPressUp;

	// Token: 0x04000183 RID: 387
	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	public ETCJoystick.OnDownDownHandler OnPressDown;

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	public ETCJoystick.OnDownLeftHandler OnPressLeft;

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	public ETCJoystick.OnDownRightHandler OnPressRight;

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x148")]
	public ETCJoystick.JoystickType joystickType;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x14C")]
	public bool allowJoystickOverTouchPad;

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x150")]
	public ETCJoystick.RadiusBase radiusBase;

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x154")]
	public float radiusBaseValue;

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x158")]
	public ETCAxis axisX;

	// Token: 0x0400018B RID: 395
	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x160")]
	public ETCAxis axisY;

	// Token: 0x0400018C RID: 396
	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x168")]
	public RectTransform thumb;

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x170")]
	public ETCJoystick.JoystickArea joystickArea;

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x178")]
	public RectTransform userArea;

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x180")]
	public bool isTurnAndMove;

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x184")]
	public float tmSpeed;

	// Token: 0x04000191 RID: 401
	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x188")]
	public float tmAdditionnalRotation;

	// Token: 0x04000192 RID: 402
	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x190")]
	public AnimationCurve tmMoveCurve;

	// Token: 0x04000193 RID: 403
	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x198")]
	public bool tmLockInJump;

	// Token: 0x04000194 RID: 404
	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x19C")]
	private Vector3 tmLastMove;

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x1AC")]
	private Vector2 thumbPosition;

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x1B4")]
	private bool isDynamicActif;

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x1B8")]
	private Vector2 tmpAxis;

	// Token: 0x04000199 RID: 409
	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x1C0")]
	private Vector2 OldTmpAxis;

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x1C8")]
	private bool isOnTouch;

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x1C9")]
	[SerializeField]
	private bool isNoReturnThumb;

	// Token: 0x0400019C RID: 412
	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x1CC")]
	private Vector2 noReturnPosition;

	// Token: 0x0400019D RID: 413
	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x1D4")]
	private Vector2 noReturnOffset;

	// Token: 0x0400019E RID: 414
	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x1DC")]
	[SerializeField]
	private bool isNoOffsetThumb;

	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[Serializable]
	public class OnMoveStartHandler : UnityEvent
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnMoveStartHandler()
		{
		}
	}

	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[Serializable]
	public class OnMoveSpeedHandler : UnityEvent<Vector2>
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x513360", Offset = "0x511F60", VA = "0x180513360")]
		public OnMoveSpeedHandler()
		{
		}
	}

	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[Serializable]
	public class OnMoveHandler : UnityEvent<Vector2>
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5132E0", Offset = "0x511EE0", VA = "0x1805132E0")]
		public OnMoveHandler()
		{
		}
	}

	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[Serializable]
	public class OnMoveEndHandler : UnityEvent
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnMoveEndHandler()
		{
		}
	}

	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[Serializable]
	public class OnTouchStartHandler : UnityEvent
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnTouchStartHandler()
		{
		}
	}

	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[Serializable]
	public class OnTouchUpHandler : UnityEvent
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnTouchUpHandler()
		{
		}
	}

	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Serializable]
	public class OnDownUpHandler : UnityEvent
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownUpHandler()
		{
		}
	}

	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[Serializable]
	public class OnDownDownHandler : UnityEvent
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownDownHandler()
		{
		}
	}

	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[Serializable]
	public class OnDownLeftHandler : UnityEvent
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownLeftHandler()
		{
		}
	}

	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[Serializable]
	public class OnDownRightHandler : UnityEvent
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownRightHandler()
		{
		}
	}

	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[Serializable]
	public class OnPressUpHandler : UnityEvent
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressUpHandler()
		{
		}
	}

	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[Serializable]
	public class OnPressDownHandler : UnityEvent
	{
		// Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressDownHandler()
		{
		}
	}

	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[Serializable]
	public class OnPressLeftHandler : UnityEvent
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressLeftHandler()
		{
		}
	}

	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[Serializable]
	public class OnPressRightHandler : UnityEvent
	{
		// Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressRightHandler()
		{
		}
	}

	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	public enum JoystickArea
	{
		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		UserDefined,
		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		FullScreen,
		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		Left,
		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		Right,
		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		Top,
		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		Bottom,
		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		TopLeft,
		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		TopRight,
		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		BottomLeft,
		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		BottomRight
	}

	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public enum JoystickType
	{
		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		Dynamic,
		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		Static
	}

	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public enum RadiusBase
	{
		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		Width,
		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		Height,
		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		UserDefined
	}
}
