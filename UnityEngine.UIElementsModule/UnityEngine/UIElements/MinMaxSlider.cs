using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	public class MinMaxSlider : BaseField<Vector2>
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BA")]
		internal VisualElement dragElement
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x45A7900", Offset = "0x45A6500", VA = "0x1845A7900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x45A7CF0", Offset = "0x45A68F0", VA = "0x1845A7CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BB")]
		internal VisualElement dragMinThumb
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x4432F60", Offset = "0x4431B60", VA = "0x184432F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x45A7D00", Offset = "0x45A6900", VA = "0x1845A7D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BC")]
		internal VisualElement dragMaxThumb
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x45A78F0", Offset = "0x45A64F0", VA = "0x1845A78F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x4432F70", Offset = "0x4431B70", VA = "0x184432F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BD")]
		internal ClampedDragger<float> clampedDragger
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x45A7930", Offset = "0x45A6530", VA = "0x1845A7930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x45A7EE0", Offset = "0x45A6AE0", VA = "0x1845A7EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00005208 File Offset: 0x00003408
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BE")]
		public float minValue
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x5ABBBD0", Offset = "0x5ABA7D0", VA = "0x185ABBBD0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x5ABBEE0", Offset = "0x5ABAAE0", VA = "0x185ABBEE0")]
			set
			{
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00005220 File Offset: 0x00003420
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BF")]
		public float maxValue
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x5ABBB90", Offset = "0x5ABA790", VA = "0x185ABBB90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x5ABBE50", Offset = "0x5ABAA50", VA = "0x185ABBE50")]
			set
			{
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00005238 File Offset: 0x00003438
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C0")]
		public override Vector2 value
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x5ABBC10", Offset = "0x5ABA810", VA = "0x185ABBC10", Slot = "102")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x5ABBF70", Offset = "0x5ABAB70", VA = "0x185ABBF70", Slot = "103")]
			set
			{
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x5ABA240", Offset = "0x5AB8E40", VA = "0x185ABA240", Slot = "107")]
		public override void SetValueWithoutNotify(Vector2 newValue)
		{
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00005250 File Offset: 0x00003450
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C1")]
		public float lowLimit
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x5ABBB80", Offset = "0x5ABA780", VA = "0x185ABBB80")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x5ABBD50", Offset = "0x5ABA950", VA = "0x185ABBD50")]
			set
			{
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00005268 File Offset: 0x00003468
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C2")]
		public float highLimit
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x5ABBB70", Offset = "0x5ABA770", VA = "0x185ABBB70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x5ABBC50", Offset = "0x5ABA850", VA = "0x185ABBC50")]
			set
			{
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x5ABB270", Offset = "0x5AB9E70", VA = "0x185ABB270")]
		public MinMaxSlider()
		{
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x5ABB2B0", Offset = "0x5AB9EB0", VA = "0x185ABB2B0")]
		public MinMaxSlider(string label, float minValue = 0f, float maxValue = 10f, float minLimit = -3.4028235E+38f, float maxLimit = 3.4028235E+38f)
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x5AB9620", Offset = "0x5AB8220", VA = "0x185AB9620")]
		private Vector2 ClampValues(Vector2 valueToClamp)
		{
			return default(Vector2);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x5ABAF50", Offset = "0x5AB9B50", VA = "0x185ABAF50")]
		private void UpdateDragElementPosition(GeometryChangedEvent evt)
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x5ABA2F0", Offset = "0x5AB8EF0", VA = "0x185ABA2F0")]
		private void UpdateDragElementPosition()
		{
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x5ABA2B0", Offset = "0x5AB8EB0", VA = "0x185ABA2B0")]
		internal float SliderLerpUnclamped(float a, float b, float interpolant)
		{
			return 0f;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x5ABA2D0", Offset = "0x5AB8ED0", VA = "0x185ABA2D0")]
		internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return 0f;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x5AB9A10", Offset = "0x5AB8610", VA = "0x185AB9A10")]
		private float ComputeValueFromPosition(float positionToConvert)
		{
			return 0f;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x5AB9B70", Offset = "0x5AB8770", VA = "0x185AB9B70", Slot = "12")]
		protected override void ExecuteDefaultAction(EventBase evt)
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x5ABA1B0", Offset = "0x5AB8DB0", VA = "0x185ABA1B0")]
		private void SetSliderValueFromDrag()
		{
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x5AB9D10", Offset = "0x5AB8910", VA = "0x185AB9D10")]
		private void SetSliderValueFromClick()
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x5AB96B0", Offset = "0x5AB82B0", VA = "0x185AB96B0")]
		private void ComputeValueDragStateNoThumb(float lowLimitPosition, float highLimitPosition, float dragElementPos)
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x5AB97B0", Offset = "0x5AB83B0", VA = "0x185AB97B0")]
		private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos)
		{
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "106")]
		protected override void UpdateMixedValueContent()
		{
		}

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x428")]
		private Vector2 m_DragElementStartPos;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x430")]
		private Vector2 m_ValueStartPos;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x438")]
		private Rect m_DragMinThumbRect;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x448")]
		private Rect m_DragMaxThumbRect;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x458")]
		private MinMaxSlider.DragState m_DragState;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x45C")]
		private float m_MinLimit;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x460")]
		private float m_MaxLimit;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x8")]
		public new static readonly string labelUssClassName;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x10")]
		public new static readonly string inputUssClassName;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string trackerUssClassName;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string draggerUssClassName;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string minThumbUssClassName;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string maxThumbUssClassName;

		// Token: 0x02000126 RID: 294
		[Token(Token = "0x2000126")]
		public new class UxmlFactory : UxmlFactory<MinMaxSlider, MinMaxSlider.UxmlTraits>
		{
			// Token: 0x06000879 RID: 2169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x5AD2D30", Offset = "0x5AD1930", VA = "0x185AD2D30")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000127 RID: 295
		[Token(Token = "0x2000127")]
		public new class UxmlTraits : BaseField<Vector2>.UxmlTraits
		{
			// Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x5AD3540", Offset = "0x5AD2140", VA = "0x185AD3540", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x0600087B RID: 2171 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x5AD62E0", Offset = "0x5AD4EE0", VA = "0x185AD62E0")]
			public UxmlTraits()
			{
			}

			// Token: 0x04000483 RID: 1155
			[Token(Token = "0x4000483")]
			[FieldOffset(Offset = "0x80")]
			private UxmlFloatAttributeDescription m_MinValue;

			// Token: 0x04000484 RID: 1156
			[Token(Token = "0x4000484")]
			[FieldOffset(Offset = "0x88")]
			private UxmlFloatAttributeDescription m_MaxValue;

			// Token: 0x04000485 RID: 1157
			[Token(Token = "0x4000485")]
			[FieldOffset(Offset = "0x90")]
			private UxmlFloatAttributeDescription m_LowLimit;

			// Token: 0x04000486 RID: 1158
			[Token(Token = "0x4000486")]
			[FieldOffset(Offset = "0x98")]
			private UxmlFloatAttributeDescription m_HighLimit;
		}

		// Token: 0x02000128 RID: 296
		[Token(Token = "0x2000128")]
		private enum DragState
		{
			// Token: 0x04000488 RID: 1160
			[Token(Token = "0x4000488")]
			NoThumb,
			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4000489")]
			MinThumb,
			// Token: 0x0400048A RID: 1162
			[Token(Token = "0x400048A")]
			MiddleThumb,
			// Token: 0x0400048B RID: 1163
			[Token(Token = "0x400048B")]
			MaxThumb
		}
	}
}
