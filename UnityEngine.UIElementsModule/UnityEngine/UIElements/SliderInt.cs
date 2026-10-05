using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	public class SliderInt : BaseSlider<int>
	{
		// Token: 0x0600092C RID: 2348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x5AC9EC0", Offset = "0x5AC8AC0", VA = "0x185AC9EC0")]
		public SliderInt()
		{
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x5AC9FF0", Offset = "0x5AC8BF0", VA = "0x185AC9FF0")]
		public SliderInt(string label, int start = 0, int end = 10, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
		{
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00005610 File Offset: 0x00003810
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EA")]
		public override float pageSize
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x5ACA150", Offset = "0x5AC8D50", VA = "0x185ACA150", Slot = "108")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x5ACA190", Offset = "0x5AC8D90", VA = "0x185ACA190", Slot = "109")]
			set
			{
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x5AC9D40", Offset = "0x5AC8940", VA = "0x185AC9D40", Slot = "112")]
		internal override int SliderLerpUnclamped(int a, int b, float interpolant)
		{
			return 0;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x5AC9D70", Offset = "0x5AC8970", VA = "0x185AC9D70", Slot = "113")]
		internal override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue)
		{
			return 0f;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x5AC9D10", Offset = "0x5AC8910", VA = "0x185AC9D10", Slot = "114")]
		internal override int ParseStringToValue(string stringValue)
		{
			return 0;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x5AC97C0", Offset = "0x5AC83C0", VA = "0x185AC97C0", Slot = "116")]
		internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
		{
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x5AC9AE0", Offset = "0x5AC86E0", VA = "0x185AC9AE0", Slot = "115")]
		internal override void ComputeValueFromKey(BaseSlider<int>.SliderKey sliderKey, bool isShift)
		{
		}

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x8")]
		public new static readonly string labelUssClassName;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x10")]
		public new static readonly string inputUssClassName;

		// Token: 0x02000148 RID: 328
		[Token(Token = "0x2000148")]
		public new class UxmlFactory : UxmlFactory<SliderInt, SliderInt.UxmlTraits>
		{
			// Token: 0x06000936 RID: 2358 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x5AD2E30", Offset = "0x5AD1A30", VA = "0x185AD2E30")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000149 RID: 329
		[Token(Token = "0x2000149")]
		public new class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
		{
			// Token: 0x06000937 RID: 2359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x5AD3180", Offset = "0x5AD1D80", VA = "0x185AD3180", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x06000938 RID: 2360 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x5AD6850", Offset = "0x5AD5450", VA = "0x185AD6850")]
			public UxmlTraits()
			{
			}

			// Token: 0x04000521 RID: 1313
			[Token(Token = "0x4000521")]
			[FieldOffset(Offset = "0x88")]
			private UxmlIntAttributeDescription m_LowValue;

			// Token: 0x04000522 RID: 1314
			[Token(Token = "0x4000522")]
			[FieldOffset(Offset = "0x90")]
			private UxmlIntAttributeDescription m_HighValue;

			// Token: 0x04000523 RID: 1315
			[Token(Token = "0x4000523")]
			[FieldOffset(Offset = "0x98")]
			private UxmlIntAttributeDescription m_PageSize;

			// Token: 0x04000524 RID: 1316
			[Token(Token = "0x4000524")]
			[FieldOffset(Offset = "0xA0")]
			private UxmlBoolAttributeDescription m_ShowInputField;

			// Token: 0x04000525 RID: 1317
			[Token(Token = "0x4000525")]
			[FieldOffset(Offset = "0xA8")]
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction;

			// Token: 0x04000526 RID: 1318
			[Token(Token = "0x4000526")]
			[FieldOffset(Offset = "0xB0")]
			private UxmlBoolAttributeDescription m_Inverted;
		}
	}
}
