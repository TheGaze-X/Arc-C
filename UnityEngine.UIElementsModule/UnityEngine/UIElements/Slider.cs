using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public class Slider : BaseSlider<float>
	{
		// Token: 0x06000921 RID: 2337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x5ACA980", Offset = "0x5AC9580", VA = "0x185ACA980")]
		public Slider()
		{
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x5ACA9B0", Offset = "0x5AC95B0", VA = "0x185ACA9B0")]
		public Slider(float start, float end, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x5ACA820", Offset = "0x5AC9420", VA = "0x185ACA820")]
		public Slider(string label, float start = 0f, float end = 10f, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x5ACA4E0", Offset = "0x5AC90E0", VA = "0x185ACA4E0", Slot = "112")]
		internal override float SliderLerpUnclamped(float a, float b, float interpolant)
		{
			return 0f;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x5ABA2D0", Offset = "0x5AB8ED0", VA = "0x185ABA2D0", Slot = "113")]
		internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return 0f;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x5ACA410", Offset = "0x5AC9010", VA = "0x185ACA410", Slot = "114")]
		internal override float ParseStringToValue(string stringValue)
		{
			return 0f;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x5ACA1F0", Offset = "0x5AC8DF0", VA = "0x185ACA1F0", Slot = "115")]
		internal override void ComputeValueFromKey(BaseSlider<float>.SliderKey sliderKey, bool isShift)
		{
		}

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x8")]
		public new static readonly string labelUssClassName;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x10")]
		public new static readonly string inputUssClassName;

		// Token: 0x02000145 RID: 325
		[Token(Token = "0x2000145")]
		public new class UxmlFactory : UxmlFactory<Slider, Slider.UxmlTraits>
		{
			// Token: 0x06000929 RID: 2345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x5AD2E70", Offset = "0x5AD1A70", VA = "0x185AD2E70")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000146 RID: 326
		[Token(Token = "0x2000146")]
		public new class UxmlTraits : BaseFieldTraits<float, UxmlFloatAttributeDescription>
		{
			// Token: 0x0600092A RID: 2346 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x5AD3990", Offset = "0x5AD2590", VA = "0x185AD3990", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x0600092B RID: 2347 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x5AD6030", Offset = "0x5AD4C30", VA = "0x185AD6030")]
			public UxmlTraits()
			{
			}

			// Token: 0x04000518 RID: 1304
			[Token(Token = "0x4000518")]
			[FieldOffset(Offset = "0x88")]
			private UxmlFloatAttributeDescription m_LowValue;

			// Token: 0x04000519 RID: 1305
			[Token(Token = "0x4000519")]
			[FieldOffset(Offset = "0x90")]
			private UxmlFloatAttributeDescription m_HighValue;

			// Token: 0x0400051A RID: 1306
			[Token(Token = "0x400051A")]
			[FieldOffset(Offset = "0x98")]
			private UxmlFloatAttributeDescription m_PageSize;

			// Token: 0x0400051B RID: 1307
			[Token(Token = "0x400051B")]
			[FieldOffset(Offset = "0xA0")]
			private UxmlBoolAttributeDescription m_ShowInputField;

			// Token: 0x0400051C RID: 1308
			[Token(Token = "0x400051C")]
			[FieldOffset(Offset = "0xA8")]
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction;

			// Token: 0x0400051D RID: 1309
			[Token(Token = "0x400051D")]
			[FieldOffset(Offset = "0xB0")]
			private UxmlBoolAttributeDescription m_Inverted;
		}
	}
}
