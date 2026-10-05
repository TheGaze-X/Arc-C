using System;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[AddComponentMenu("UI/Slider", 34)]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement, IWheelListener, IScrollHandler, IScrollNormalizedPosition
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000139")]
		public RectTransform fillRect
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x5B7BAD0", Offset = "0x5B7A6D0", VA = "0x185B7BAD0")]
			set
			{
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013A")]
		public RectTransform handleRect
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x5B7BB40", Offset = "0x5B7A740", VA = "0x185B7BB40")]
			set
			{
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00003D50 File Offset: 0x00001F50
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013B")]
		public Slider.Direction direction
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x5A12510", Offset = "0x5A11110", VA = "0x185A12510")]
			get
			{
				return Slider.Direction.LeftToRight;
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x5B7BA70", Offset = "0x5B7A670", VA = "0x185B7BA70")]
			set
			{
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00003D68 File Offset: 0x00001F68
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013C")]
		public float minValue
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x5B7B8E0", Offset = "0x5B7A4E0", VA = "0x185B7B8E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x5B7BC40", Offset = "0x5B7A840", VA = "0x185B7BC40")]
			set
			{
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00003D80 File Offset: 0x00001F80
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013D")]
		public float maxValue
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x5B7B8D0", Offset = "0x5B7A4D0", VA = "0x185B7B8D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x5B7BBB0", Offset = "0x5B7A7B0", VA = "0x185B7BBB0")]
			set
			{
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00003D98 File Offset: 0x00001F98
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013E")]
		public bool wholeNumbers
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x5B7BA60", Offset = "0x5B7A660", VA = "0x185B7BA60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x5B7BDA0", Offset = "0x5B7A9A0", VA = "0x185B7BDA0")]
			set
			{
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00003DB0 File Offset: 0x00001FB0
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013F")]
		public virtual float value
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x5B7BA40", Offset = "0x5B7A640", VA = "0x185B7BA40", Slot = "52")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x5B7BD50", Offset = "0x5B7A950", VA = "0x185B7BD50", Slot = "53")]
			set
			{
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x5B7A970", Offset = "0x5B79570", VA = "0x185B7A970", Slot = "54")]
		public virtual void SetValueWithoutNotify(float input)
		{
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00003DC8 File Offset: 0x00001FC8
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000140")]
		public float normalizedValue
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x5B7B8F0", Offset = "0x5B7A4F0", VA = "0x185B7B8F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x5B7BCD0", Offset = "0x5B7A8D0", VA = "0x185B7BCD0")]
			set
			{
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000141")]
		public Slider.SliderEvent onValueChanged
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x55FB9F0", Offset = "0x55FA5F0", VA = "0x1855FB9F0")]
			set
			{
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x17000142")]
		private float stepSize
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x5B7BA10", Offset = "0x5B7A610", VA = "0x185B7BA10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x5B7B7B0", Offset = "0x5B7A3B0", VA = "0x185B7B7B0")]
		protected Slider()
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "55")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "56")]
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "57")]
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x5B7B660", Offset = "0x5B7A260", VA = "0x185B7B660")]
		private void _BindWheelListener()
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x5B7A0A0", Offset = "0x5B78CA0", VA = "0x185B7A0A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x5B79FD0", Offset = "0x5B78BD0", VA = "0x185B79FD0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x5B7B5D0", Offset = "0x5B7A1D0", VA = "0x185B7B5D0", Slot = "58")]
		protected virtual void Update()
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x5B79D40", Offset = "0x5B78940", VA = "0x185B79D40", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x5B7ABA0", Offset = "0x5B797A0", VA = "0x185B7ABA0")]
		private void UpdateCachedReferences()
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x5B79C50", Offset = "0x5B78850", VA = "0x185B79C50")]
		private float ClampValue(float input)
		{
			return 0f;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x5B7AA50", Offset = "0x5B79650", VA = "0x185B7AA50", Slot = "59")]
		protected virtual void Set(float input, bool sendCallback = true)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x5B7A750", Offset = "0x5B79350", VA = "0x185B7A750", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x17000143")]
		private Slider.Axis axis
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x5B7B8C0", Offset = "0x5B7A4C0", VA = "0x185B7B8C0")]
			get
			{
				return Slider.Axis.Horizontal;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x17000144")]
		private bool reverseValue
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x5B7B9F0", Offset = "0x5B7A5F0", VA = "0x185B7B9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x17000145")]
		public Vector2 position
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x5B7B9B0", Offset = "0x5B7A5B0", VA = "0x185B7B9B0", Slot = "51")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x5B7B230", Offset = "0x5B79E30", VA = "0x185B7B230")]
		private void UpdateVisuals()
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x5B7AF20", Offset = "0x5B79B20", VA = "0x185B7AF20")]
		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xF9B980", Offset = "0xF9A580", VA = "0x180F9B980")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x5B7A4C0", Offset = "0x5B790C0", VA = "0x185B7A4C0", Slot = "34")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x5B7A000", Offset = "0x5B78C00", VA = "0x185B7A000", Slot = "60")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x5B7A250", Offset = "0x5B78E50", VA = "0x185B7A250", Slot = "33")]
		public override void OnMove(AxisEventData eventData)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x5B79CB0", Offset = "0x5B788B0", VA = "0x185B79CB0", Slot = "29")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x5B79CE0", Offset = "0x5B788E0", VA = "0x185B79CE0", Slot = "30")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x5B79D10", Offset = "0x5B78910", VA = "0x185B79D10", Slot = "31")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x5B79C80", Offset = "0x5B78880", VA = "0x185B79C80", Slot = "32")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x5B75690", Offset = "0x5B74290", VA = "0x185B75690", Slot = "61")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x5B7A7C0", Offset = "0x5B793C0", VA = "0x185B7A7C0")]
		public void SetDirection(Slider.Direction direction, bool includeRectLayouts)
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x5B7A9C0", Offset = "0x5B795C0", VA = "0x185B7A9C0")]
		private void SetValue(Vector2 delta)
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x5B79B40", Offset = "0x5B78740", VA = "0x185B79B40")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "48")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x5B7AB30", Offset = "0x5B79730", VA = "0x185B7AB30", Slot = "49")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x5B7A7A0", Offset = "0x5B793A0", VA = "0x185B7A7A0", Slot = "50")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x589F680", Offset = "0x589E280", VA = "0x18589F680", Slot = "44")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform m_FillRect;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool m_BindWheelOnStart;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private InertiaTickHandler.Option m_WheelOption;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x110")]
		private ScrollWheelHandler m_ScrollWheelHandler;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private RectTransform m_HandleRect;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x120")]
		[Space]
		[SerializeField]
		private Slider.Direction m_Direction;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private float m_MinValue;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private float m_MaxValue;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private bool m_WholeNumbers;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected float m_Value;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Space]
		private Slider.SliderEvent m_OnValueChanged;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x140")]
		private Image m_FillImage;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x148")]
		private Transform m_FillTransform;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x150")]
		private RectTransform m_FillContainerRect;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x158")]
		private Transform m_HandleTransform;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x160")]
		private RectTransform m_HandleContainerRect;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x168")]
		private Vector2 m_Offset;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x170")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x171")]
		private bool m_DelayedUpdateVisuals;

		// Token: 0x0200006C RID: 108
		[Token(Token = "0x200006C")]
		public enum Direction
		{
			// Token: 0x04000246 RID: 582
			[Token(Token = "0x4000246")]
			LeftToRight,
			// Token: 0x04000247 RID: 583
			[Token(Token = "0x4000247")]
			RightToLeft,
			// Token: 0x04000248 RID: 584
			[Token(Token = "0x4000248")]
			BottomToTop,
			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			TopToBottom
		}

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
			// Token: 0x060004C6 RID: 1222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x5B79B00", Offset = "0x5B78700", VA = "0x185B79B00")]
			public SliderEvent()
			{
			}
		}

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		private enum Axis
		{
			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			Horizontal,
			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			Vertical
		}
	}
}
