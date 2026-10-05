using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	[AddComponentMenu("UI/Scrollbar", 36)]
	public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement, IScrollHandler, IWheelListener
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FB")]
		public RectTransform handleRect
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x5B76930", Offset = "0x5B75530", VA = "0x185B76930")]
			set
			{
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00003750 File Offset: 0x00001950
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FC")]
		public Scrollbar.Direction direction
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2451100", Offset = "0x244FD00", VA = "0x182451100")]
			get
			{
				return Scrollbar.Direction.LeftToRight;
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x5B768D0", Offset = "0x5B754D0", VA = "0x185B768D0")]
			set
			{
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x5B76700", Offset = "0x5B75300", VA = "0x185B76700")]
		protected Scrollbar()
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00003768 File Offset: 0x00001968
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FD")]
		public float value
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x5B76880", Offset = "0x5B75480", VA = "0x185B76880")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x5B76A90", Offset = "0x5B75690", VA = "0x185B76A90")]
			set
			{
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x5B75DC0", Offset = "0x5B749C0", VA = "0x185B75DC0", Slot = "52")]
		public virtual void SetValueWithoutNotify(float input)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00003780 File Offset: 0x00001980
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FE")]
		public float size
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x5B76840", Offset = "0x5B75440", VA = "0x185B76840")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x5B76A10", Offset = "0x5B75610", VA = "0x185B76A10")]
			set
			{
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00003798 File Offset: 0x00001998
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FF")]
		public int numberOfSteps
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x53B40C0", Offset = "0x53B2CC0", VA = "0x1853B40C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x5B769A0", Offset = "0x5B755A0", VA = "0x185B769A0")]
			set
			{
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000100")]
		public Scrollbar.ScrollEvent onValueChanged
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x22F8A30", Offset = "0x22F7630", VA = "0x1822F8A30")]
			set
			{
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003BE RID: 958 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x17000101")]
		private float stepSize
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x5B76850", Offset = "0x5B75450", VA = "0x185B76850")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "53")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "54")]
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "55")]
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x5B755C0", Offset = "0x5B741C0", VA = "0x185B755C0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x5B754A0", Offset = "0x5B740A0", VA = "0x185B754A0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x5B766E0", Offset = "0x5B752E0", VA = "0x185B766E0", Slot = "56")]
		protected virtual void Update()
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x5B76000", Offset = "0x5B74C00", VA = "0x185B76000")]
		private void UpdateCachedReferences()
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x5B75E70", Offset = "0x5B74A70", VA = "0x185B75E70")]
		private void Set(float input, bool sendCallback = true)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x5B75BA0", Offset = "0x5B747A0", VA = "0x185B75BA0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x17000102")]
		private Scrollbar.Axis axis
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x5B76810", Offset = "0x5B75410", VA = "0x185B76810")]
			get
			{
				return Scrollbar.Axis.Horizontal;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x17000103")]
		private bool reverseValue
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x5B76820", Offset = "0x5B75420", VA = "0x185B76820")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x5B764B0", Offset = "0x5B750B0", VA = "0x185B764B0")]
		private void UpdateVisuals()
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x5B76110", Offset = "0x5B74D10", VA = "0x185B76110")]
		private void UpdateDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x5B75050", Offset = "0x5B73C50", VA = "0x185B75050")]
		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xF9B980", Offset = "0xF9A580", VA = "0x180F9B980")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x5B751D0", Offset = "0x5B73DD0", VA = "0x185B751D0", Slot = "57")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x5B754D0", Offset = "0x5B740D0", VA = "0x185B754D0", Slot = "58")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x5B75A30", Offset = "0x5B74630", VA = "0x185B75A30", Slot = "34")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x5B74FD0", Offset = "0x5B73BD0", VA = "0x185B74FD0")]
		protected IEnumerator ClickRepeat(PointerEventData eventData)
		{
			return null;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x5B74F20", Offset = "0x5B73B20", VA = "0x185B74F20")]
		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera)
		{
			return null;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x5B75B60", Offset = "0x5B74760", VA = "0x185B75B60", Slot = "35")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x5B756B0", Offset = "0x5B742B0", VA = "0x185B756B0", Slot = "33")]
		public override void OnMove(AxisEventData eventData)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x5B75140", Offset = "0x5B73D40", VA = "0x185B75140", Slot = "29")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x5B75170", Offset = "0x5B73D70", VA = "0x185B75170", Slot = "30")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x5B751A0", Offset = "0x5B73DA0", VA = "0x185B751A0", Slot = "31")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x5B75110", Offset = "0x5B73D10", VA = "0x185B75110", Slot = "32")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x5B75690", Offset = "0x5B74290", VA = "0x185B75690", Slot = "59")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x5B75C10", Offset = "0x5B74810", VA = "0x185B75C10")]
		public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x5B74ED0", Offset = "0x5B73AD0", VA = "0x185B74ED0")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "50")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x5B75FA0", Offset = "0x5B74BA0", VA = "0x185B75FA0", Slot = "51")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x5B75BF0", Offset = "0x5B747F0", VA = "0x185B75BF0", Slot = "49")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x589F680", Offset = "0x589E280", VA = "0x18589F680", Slot = "45")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform m_HandleRect;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Scrollbar.Direction m_Direction;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x104")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Value;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x108")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Size;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		[Range(0f, 11f)]
		private int m_NumberOfSteps;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x110")]
		[Space(6f)]
		[SerializeField]
		private Scrollbar.ScrollEvent m_OnValueChanged;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x118")]
		private RectTransform m_ContainerRect;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x120")]
		private Vector2 m_Offset;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x128")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x130")]
		private Coroutine m_PointerDownRepeat;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x138")]
		private bool isPointerDownAndNotDragging;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x140")]
		private ScrollWheelHandler m_handler;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x148")]
		private bool m_DelayedUpdateVisuals;

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x200005F")]
		public enum Direction
		{
			// Token: 0x040001D9 RID: 473
			[Token(Token = "0x40001D9")]
			LeftToRight,
			// Token: 0x040001DA RID: 474
			[Token(Token = "0x40001DA")]
			RightToLeft,
			// Token: 0x040001DB RID: 475
			[Token(Token = "0x40001DB")]
			BottomToTop,
			// Token: 0x040001DC RID: 476
			[Token(Token = "0x40001DC")]
			TopToBottom
		}

		// Token: 0x02000060 RID: 96
		[Token(Token = "0x2000060")]
		[Serializable]
		public class ScrollEvent : UnityEvent<float>
		{
			// Token: 0x060003E0 RID: 992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x5B6F880", Offset = "0x5B6E480", VA = "0x185B6F880")]
			public ScrollEvent()
			{
			}
		}

		// Token: 0x02000061 RID: 97
		[Token(Token = "0x2000061")]
		private enum Axis
		{
			// Token: 0x040001DE RID: 478
			[Token(Token = "0x40001DE")]
			Horizontal,
			// Token: 0x040001DF RID: 479
			[Token(Token = "0x40001DF")]
			Vertical
		}
	}
}
