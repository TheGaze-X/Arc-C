using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	internal struct PointerModel
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x1700037C")]
		public UIPointerType pointerType
		{
			[Token(Token = "0x6000D56")]
			[Address(RVA = "0x56C91A0", Offset = "0x56C7DA0", VA = "0x1856C91A0")]
			get
			{
				return UIPointerType.None;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00006828 File Offset: 0x00004A28
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037D")]
		public Vector2 screenPosition
		{
			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x56C9200", Offset = "0x56C7E00", VA = "0x1856C9200")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000D58")]
			[Address(RVA = "0x56C9330", Offset = "0x56C7F30", VA = "0x1856C9330")]
			set
			{
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00006840 File Offset: 0x00004A40
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037E")]
		public Vector3 worldPosition
		{
			[Token(Token = "0x6000D59")]
			[Address(RVA = "0x56C9260", Offset = "0x56C7E60", VA = "0x1856C9260")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000D5A")]
			[Address(RVA = "0x56C9460", Offset = "0x56C8060", VA = "0x1856C9460")]
			set
			{
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00006858 File Offset: 0x00004A58
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037F")]
		public Quaternion worldOrientation
		{
			[Token(Token = "0x6000D5B")]
			[Address(RVA = "0x56C9250", Offset = "0x56C7E50", VA = "0x1856C9250")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000D5C")]
			[Address(RVA = "0x56C93F0", Offset = "0x56C7FF0", VA = "0x1856C93F0")]
			set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00006870 File Offset: 0x00004A70
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000380")]
		public Vector2 scrollDelta
		{
			[Token(Token = "0x6000D5D")]
			[Address(RVA = "0x56C9220", Offset = "0x56C7E20", VA = "0x1856C9220")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000D5E")]
			[Address(RVA = "0x56C9380", Offset = "0x56C7F80", VA = "0x1856C9380")]
			set
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00006888 File Offset: 0x00004A88
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000381")]
		public float pressure
		{
			[Token(Token = "0x6000D5F")]
			[Address(RVA = "0x56C91D0", Offset = "0x56C7DD0", VA = "0x1856C91D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D60")]
			[Address(RVA = "0x56C92C0", Offset = "0x56C7EC0", VA = "0x1856C92C0")]
			set
			{
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000068A0 File Offset: 0x00004AA0
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000382")]
		public float azimuthAngle
		{
			[Token(Token = "0x6000D61")]
			[Address(RVA = "0x56C9190", Offset = "0x56C7D90", VA = "0x1856C9190")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D62")]
			[Address(RVA = "0x56C92A0", Offset = "0x56C7EA0", VA = "0x1856C92A0")]
			set
			{
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x000068B8 File Offset: 0x00004AB8
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000383")]
		public float altitudeAngle
		{
			[Token(Token = "0x6000D63")]
			[Address(RVA = "0x56C9180", Offset = "0x56C7D80", VA = "0x1856C9180")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D64")]
			[Address(RVA = "0x56C9280", Offset = "0x56C7E80", VA = "0x1856C9280")]
			set
			{
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x000068D0 File Offset: 0x00004AD0
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000384")]
		public float twist
		{
			[Token(Token = "0x6000D65")]
			[Address(RVA = "0x56C9240", Offset = "0x56C7E40", VA = "0x1856C9240")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D66")]
			[Address(RVA = "0x56C93D0", Offset = "0x56C7FD0", VA = "0x1856C93D0")]
			set
			{
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000068E8 File Offset: 0x00004AE8
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000385")]
		public Vector2 radius
		{
			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x56C91E0", Offset = "0x56C7DE0", VA = "0x1856C91E0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000D68")]
			[Address(RVA = "0x56C92E0", Offset = "0x56C7EE0", VA = "0x1856C92E0")]
			set
			{
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x56C9050", Offset = "0x56C7C50", VA = "0x1856C9050")]
		public PointerModel(ExtendedPointerEventData eventData)
		{
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x56C8FD0", Offset = "0x56C7BD0", VA = "0x1856C8FD0")]
		public void OnFrameFinished()
		{
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x56C8ED0", Offset = "0x56C7AD0", VA = "0x1856C8ED0")]
		public void CopyTouchOrPenStateFrom(PointerEventData eventData)
		{
		}

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x0")]
		public bool changedThisFrame;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x8")]
		public PointerModel.ButtonState leftButton;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0xA0")]
		public PointerModel.ButtonState rightButton;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x138")]
		public PointerModel.ButtonState middleButton;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x1D0")]
		public ExtendedPointerEventData eventData;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x1D8")]
		private Vector2 m_ScreenPosition;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x1E0")]
		private Vector2 m_ScrollDelta;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x1E8")]
		private Vector3 m_WorldPosition;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x1F4")]
		private Quaternion m_WorldOrientation;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0x204")]
		private float m_Pressure;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x208")]
		private float m_AzimuthAngle;

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x20C")]
		private float m_AltitudeAngle;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x210")]
		private float m_Twist;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x214")]
		private Vector2 m_Radius;

		// Token: 0x02000118 RID: 280
		[Token(Token = "0x2000118")]
		public struct ButtonState
		{
			// Token: 0x17000386 RID: 902
			// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00006900 File Offset: 0x00004B00
			// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000386")]
			public bool isPressed
			{
				[Token(Token = "0x6000D6C")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D6D")]
				[Address(RVA = "0x56B8C00", Offset = "0x56B7800", VA = "0x1856B8C00")]
				set
				{
				}
			}

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00006918 File Offset: 0x00004B18
			// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000387")]
			public bool ignoreNextClick
			{
				[Token(Token = "0x6000D6E")]
				[Address(RVA = "0x56B8BA0", Offset = "0x56B77A0", VA = "0x1856B8BA0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D6F")]
				[Address(RVA = "0x56B8BF0", Offset = "0x56B77F0", VA = "0x1856B8BF0")]
				set
				{
				}
			}

			// Token: 0x17000388 RID: 904
			// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00006930 File Offset: 0x00004B30
			// (set) Token: 0x06000D71 RID: 3441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000388")]
			public float pressTime
			{
				[Token(Token = "0x6000D70")]
				[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000D71")]
				[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
				set
				{
				}
			}

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00006948 File Offset: 0x00004B48
			// (set) Token: 0x06000D73 RID: 3443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000389")]
			public bool clickedOnSameGameObject
			{
				[Token(Token = "0x6000D72")]
				[Address(RVA = "0x51AACC0", Offset = "0x51A98C0", VA = "0x1851AACC0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D73")]
				[Address(RVA = "0x56B8BE0", Offset = "0x56B77E0", VA = "0x1856B8BE0")]
				set
				{
				}
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00006960 File Offset: 0x00004B60
			[Token(Token = "0x1700038A")]
			public bool wasPressedThisFrame
			{
				[Token(Token = "0x6000D74")]
				[Address(RVA = "0x56B8BB0", Offset = "0x56B77B0", VA = "0x1856B8BB0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700038B RID: 907
			// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00006978 File Offset: 0x00004B78
			[Token(Token = "0x1700038B")]
			public bool wasReleasedThisFrame
			{
				[Token(Token = "0x6000D75")]
				[Address(RVA = "0x56B8BD0", Offset = "0x56B77D0", VA = "0x1856B8BD0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000D76 RID: 3446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x56B8A90", Offset = "0x56B7690", VA = "0x1856B8A90")]
			public void CopyPressStateTo(PointerEventData eventData)
			{
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x56B89A0", Offset = "0x56B75A0", VA = "0x1856B89A0")]
			public void CopyPressStateFrom(PointerEventData eventData)
			{
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D78")]
			[Address(RVA = "0x56B8B90", Offset = "0x56B7790", VA = "0x1856B8B90")]
			public void OnEndFrame()
			{
			}

			// Token: 0x04000659 RID: 1625
			[Token(Token = "0x4000659")]
			[FieldOffset(Offset = "0x0")]
			private bool m_IsPressed;

			// Token: 0x0400065A RID: 1626
			[Token(Token = "0x400065A")]
			[FieldOffset(Offset = "0x4")]
			private PointerEventData.FramePressState m_FramePressState;

			// Token: 0x0400065B RID: 1627
			[Token(Token = "0x400065B")]
			[FieldOffset(Offset = "0x8")]
			private float m_PressTime;

			// Token: 0x0400065C RID: 1628
			[Token(Token = "0x400065C")]
			[FieldOffset(Offset = "0x10")]
			private RaycastResult m_PressRaycast;

			// Token: 0x0400065D RID: 1629
			[Token(Token = "0x400065D")]
			[FieldOffset(Offset = "0x60")]
			private GameObject m_PressObject;

			// Token: 0x0400065E RID: 1630
			[Token(Token = "0x400065E")]
			[FieldOffset(Offset = "0x68")]
			private GameObject m_RawPressObject;

			// Token: 0x0400065F RID: 1631
			[Token(Token = "0x400065F")]
			[FieldOffset(Offset = "0x70")]
			private GameObject m_LastPressObject;

			// Token: 0x04000660 RID: 1632
			[Token(Token = "0x4000660")]
			[FieldOffset(Offset = "0x78")]
			private GameObject m_DragObject;

			// Token: 0x04000661 RID: 1633
			[Token(Token = "0x4000661")]
			[FieldOffset(Offset = "0x80")]
			private Vector2 m_PressPosition;

			// Token: 0x04000662 RID: 1634
			[Token(Token = "0x4000662")]
			[FieldOffset(Offset = "0x88")]
			private float m_ClickTime;

			// Token: 0x04000663 RID: 1635
			[Token(Token = "0x4000663")]
			[FieldOffset(Offset = "0x8C")]
			private int m_ClickCount;

			// Token: 0x04000664 RID: 1636
			[Token(Token = "0x4000664")]
			[FieldOffset(Offset = "0x90")]
			private bool m_Dragging;

			// Token: 0x04000665 RID: 1637
			[Token(Token = "0x4000665")]
			[FieldOffset(Offset = "0x91")]
			private bool m_ClickedOnSameGameObject;

			// Token: 0x04000666 RID: 1638
			[Token(Token = "0x4000666")]
			[FieldOffset(Offset = "0x92")]
			private bool m_IgnoreNextClick;
		}
	}
}
