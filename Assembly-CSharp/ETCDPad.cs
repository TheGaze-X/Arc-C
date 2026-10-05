using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000043 RID: 67
[Token(Token = "0x2000043")]
public class ETCDPad : ETCBase, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x4FF0F0", Offset = "0x4FDCF0", VA = "0x1804FF0F0")]
	public ETCDPad()
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x4FE930", Offset = "0x4FD530", VA = "0x1804FE930", Slot = "5")]
	public override void Start()
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x4FEA30", Offset = "0x4FD630", VA = "0x1804FEA30", Slot = "10")]
	protected override void UpdateControlState()
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x4FE220", Offset = "0x4FCE20", VA = "0x1804FE220", Slot = "13")]
	protected override void DoActionBeforeEndOfFrame()
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x4FE560", Offset = "0x4FD160", VA = "0x1804FE560", Slot = "15")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x4FE4D0", Offset = "0x4FD0D0", VA = "0x1804FE4D0", Slot = "14")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x4FE610", Offset = "0x4FD210", VA = "0x1804FE610", Slot = "16")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x4FEA40", Offset = "0x4FD640", VA = "0x1804FEA40")]
	private void UpdateDPad()
	{
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x4FE8D0", Offset = "0x4FD4D0", VA = "0x1804FE8D0", Slot = "11")]
	protected override void SetVisible(bool forceUnvisible = false)
	{
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x4FE790", Offset = "0x4FD390", VA = "0x1804FE790", Slot = "12")]
	protected override void SetActivated()
	{
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x4FE260", Offset = "0x4FCE60", VA = "0x1804FE260")]
	private void GetTouchDirection(Vector2 position, Camera cam)
	{
	}

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public ETCDPad.OnMoveStartHandler onMoveStart;

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public ETCDPad.OnMoveHandler onMove;

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public ETCDPad.OnMoveSpeedHandler onMoveSpeed;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public ETCDPad.OnMoveEndHandler onMoveEnd;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public ETCDPad.OnTouchStartHandler onTouchStart;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public ETCDPad.OnTouchUPHandler onTouchUp;

	// Token: 0x04000160 RID: 352
	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	public ETCDPad.OnDownUpHandler OnDownUp;

	// Token: 0x04000161 RID: 353
	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	public ETCDPad.OnDownDownHandler OnDownDown;

	// Token: 0x04000162 RID: 354
	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	public ETCDPad.OnDownLeftHandler OnDownLeft;

	// Token: 0x04000163 RID: 355
	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	public ETCDPad.OnDownRightHandler OnDownRight;

	// Token: 0x04000164 RID: 356
	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	public ETCDPad.OnDownUpHandler OnPressUp;

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	public ETCDPad.OnDownDownHandler OnPressDown;

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	public ETCDPad.OnDownLeftHandler OnPressLeft;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	public ETCDPad.OnDownRightHandler OnPressRight;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x148")]
	public ETCAxis axisX;

	// Token: 0x04000169 RID: 361
	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x150")]
	public ETCAxis axisY;

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x158")]
	public Sprite normalSprite;

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x160")]
	public Color normalColor;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x170")]
	public Sprite pressedSprite;

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x178")]
	public Color pressedColor;

	// Token: 0x0400016E RID: 366
	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x188")]
	private Vector2 tmpAxis;

	// Token: 0x0400016F RID: 367
	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x190")]
	private Vector2 OldTmpAxis;

	// Token: 0x04000170 RID: 368
	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x198")]
	private bool isOnTouch;

	// Token: 0x04000171 RID: 369
	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x1A0")]
	private Image cachedImage;

	// Token: 0x04000172 RID: 370
	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x1A8")]
	public float buttonSizeCoef;

	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[Serializable]
	public class OnMoveStartHandler : UnityEvent
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnMoveStartHandler()
		{
		}
	}

	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[Serializable]
	public class OnMoveHandler : UnityEvent<Vector2>
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x50BDA0", Offset = "0x50A9A0", VA = "0x18050BDA0")]
		public OnMoveHandler()
		{
		}
	}

	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[Serializable]
	public class OnMoveSpeedHandler : UnityEvent<Vector2>
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x50BDE0", Offset = "0x50A9E0", VA = "0x18050BDE0")]
		public OnMoveSpeedHandler()
		{
		}
	}

	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[Serializable]
	public class OnMoveEndHandler : UnityEvent
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnMoveEndHandler()
		{
		}
	}

	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[Serializable]
	public class OnTouchStartHandler : UnityEvent
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnTouchStartHandler()
		{
		}
	}

	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[Serializable]
	public class OnTouchUPHandler : UnityEvent
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnTouchUPHandler()
		{
		}
	}

	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[Serializable]
	public class OnDownUpHandler : UnityEvent
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownUpHandler()
		{
		}
	}

	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[Serializable]
	public class OnDownDownHandler : UnityEvent
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownDownHandler()
		{
		}
	}

	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[Serializable]
	public class OnDownLeftHandler : UnityEvent
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownLeftHandler()
		{
		}
	}

	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[Serializable]
	public class OnDownRightHandler : UnityEvent
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownRightHandler()
		{
		}
	}

	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[Serializable]
	public class OnPressUpHandler : UnityEvent
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressUpHandler()
		{
		}
	}

	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[Serializable]
	public class OnPressDownHandler : UnityEvent
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressDownHandler()
		{
		}
	}

	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[Serializable]
	public class OnPressLeftHandler : UnityEvent
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressLeftHandler()
		{
		}
	}

	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[Serializable]
	public class OnPressRightHandler : UnityEvent
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressRightHandler()
		{
		}
	}
}
