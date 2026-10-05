using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	public class Scroller : VisualElement
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060008B2 RID: 2226 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000014")]
		public event Action<float> valueChanged
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x5AC92A0", Offset = "0x5AC7EA0", VA = "0x185AC92A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x5AC9450", Offset = "0x5AC8050", VA = "0x185AC9450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CA")]
		public Slider slider
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x5AC93F0", Offset = "0x5AC7FF0", VA = "0x185AC93F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x5A26460", Offset = "0x5A25060", VA = "0x185A26460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CB")]
		public RepeatButton lowButton
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x5A8FDB0", Offset = "0x5A8E9B0", VA = "0x185A8FDB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x5A8FDC0", Offset = "0x5A8E9C0", VA = "0x185A8FDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CC")]
		public RepeatButton highButton
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x5AAFE90", Offset = "0x5AAEA90", VA = "0x185AAFE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x5A8FD00", Offset = "0x5A8E900", VA = "0x185A8FD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00005358 File Offset: 0x00003558
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CD")]
		public float value
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x5AC9400", Offset = "0x5AC8000", VA = "0x185AC9400")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x5AC9760", Offset = "0x5AC8360", VA = "0x185AC9760")]
			set
			{
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00005370 File Offset: 0x00003570
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CE")]
		public float lowValue
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x5AC93A0", Offset = "0x5AC7FA0", VA = "0x185AC93A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x5AC9700", Offset = "0x5AC8300", VA = "0x185AC9700")]
			set
			{
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00005388 File Offset: 0x00003588
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CF")]
		public float highValue
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x5AC9350", Offset = "0x5AC7F50", VA = "0x185AC9350")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x5AC96A0", Offset = "0x5AC82A0", VA = "0x185AC96A0")]
			set
			{
			}
		}

		// Token: 0x170001D0 RID: 464
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D0")]
		public SliderDirection direction
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x5AC9500", Offset = "0x5AC8100", VA = "0x185AC9500")]
			set
			{
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x5AC8E20", Offset = "0x5AC7A20", VA = "0x185AC8E20")]
		public Scroller()
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x5AC8E50", Offset = "0x5AC7A50", VA = "0x185AC8E50")]
		public Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical)
		{
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x5AC84A0", Offset = "0x5AC70A0", VA = "0x185AC84A0")]
		public void Adjust(float factor)
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x5AC8520", Offset = "0x5AC7120", VA = "0x185AC8520")]
		private void OnSliderValueChange(ChangeEvent<float> evt)
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x5AC8A90", Offset = "0x5AC7690", VA = "0x185AC8A90")]
		public void ScrollPageUp()
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x5AC87A0", Offset = "0x5AC73A0", VA = "0x185AC87A0")]
		public void ScrollPageDown()
		{
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x5AC8910", Offset = "0x5AC7510", VA = "0x185AC8910")]
		public void ScrollPageUp(float factor)
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x5AC8620", Offset = "0x5AC7220", VA = "0x185AC8620")]
		public void ScrollPageDown(float factor)
		{
		}

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string horizontalVariantUssClassName;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string verticalVariantUssClassName;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string sliderUssClassName;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string lowButtonUssClassName;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string highButtonUssClassName;

		// Token: 0x0200013A RID: 314
		[Token(Token = "0x200013A")]
		public new class UxmlFactory : UxmlFactory<Scroller, Scroller.UxmlTraits>
		{
			// Token: 0x060008CA RID: 2250 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x5AD2F70", Offset = "0x5AD1B70", VA = "0x185AD2F70")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x0200013B RID: 315
		[Token(Token = "0x200013B")]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x060008CB RID: 2251 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x5AD4150", Offset = "0x5AD2D50", VA = "0x185AD4150", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060008CC RID: 2252 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x5AD6560", Offset = "0x5AD5160", VA = "0x185AD6560")]
			public UxmlTraits()
			{
			}

			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40004BA")]
			[FieldOffset(Offset = "0x70")]
			private UxmlFloatAttributeDescription m_LowValue;

			// Token: 0x040004BB RID: 1211
			[Token(Token = "0x40004BB")]
			[FieldOffset(Offset = "0x78")]
			private UxmlFloatAttributeDescription m_HighValue;

			// Token: 0x040004BC RID: 1212
			[Token(Token = "0x40004BC")]
			[FieldOffset(Offset = "0x80")]
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction;

			// Token: 0x040004BD RID: 1213
			[Token(Token = "0x40004BD")]
			[FieldOffset(Offset = "0x88")]
			private UxmlFloatAttributeDescription m_Value;
		}
	}
}
