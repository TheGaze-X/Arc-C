using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	public abstract class BaseSlider<TValueType> : BaseField<TValueType> where TValueType : IComparable<TValueType>
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000178")]
		internal VisualElement dragContainer
		{
			[Token(Token = "0x6000707")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000708")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000179")]
		internal VisualElement dragElement
		{
			[Token(Token = "0x6000709")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600070A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017A")]
		internal VisualElement dragBorderElement
		{
			[Token(Token = "0x600070B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600070C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017B")]
		internal TextField inputTextField
		{
			[Token(Token = "0x600070D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600070E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017C")]
		public TValueType lowValue
		{
			[Token(Token = "0x600070F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000710")]
			set
			{
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017D")]
		public TValueType highValue
		{
			[Token(Token = "0x6000711")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000712")]
			set
			{
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000713")]
		internal void SetHighValueWithoutNotify(TValueType newHighValue)
		{
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00004E48 File Offset: 0x00003048
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017E")]
		public virtual float pageSize
		{
			[Token(Token = "0x6000714")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000715")]
			set
			{
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00004E60 File Offset: 0x00003060
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017F")]
		public virtual bool showInputField
		{
			[Token(Token = "0x6000716")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000717")]
			set
			{
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00004E78 File Offset: 0x00003078
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000180")]
		internal bool clamped
		{
			[Token(Token = "0x6000718")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000719")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000181")]
		internal ClampedDragger<TValueType> clampedDragger
		{
			[Token(Token = "0x600071A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600071B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600071C")]
		private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound)
		{
			return null;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600071D")]
		private TValueType GetClampedValue(TValueType newValue)
		{
			return null;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		public override TValueType value
		{
			[Token(Token = "0x600071E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071F")]
			set
			{
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000720")]
		public override void SetValueWithoutNotify(TValueType newValue)
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00004E90 File Offset: 0x00003090
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000183")]
		public SliderDirection direction
		{
			[Token(Token = "0x6000721")]
			get
			{
				return SliderDirection.Horizontal;
			}
			[Token(Token = "0x6000722")]
			set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00004EA8 File Offset: 0x000030A8
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		public bool inverted
		{
			[Token(Token = "0x6000723")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000724")]
			set
			{
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000725")]
		internal BaseSlider(string label, TValueType start, TValueType end, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
		{
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x6000726")]
		protected static float GetClosestPowerOfTen(float positiveNumber)
		{
			return 0f;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x6000727")]
		protected static float RoundToMultipleOf(float value, float roundingValue)
		{
			return 0f;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000728")]
		private void ClampValue()
		{
		}

		// Token: 0x06000729 RID: 1833
		[Token(Token = "0x6000729")]
		internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant);

		// Token: 0x0600072A RID: 1834
		[Token(Token = "0x600072A")]
		internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue);

		// Token: 0x0600072B RID: 1835
		[Token(Token = "0x600072B")]
		internal abstract TValueType ParseStringToValue(string stringValue);

		// Token: 0x0600072C RID: 1836
		[Token(Token = "0x600072C")]
		internal abstract void ComputeValueFromKey(BaseSlider<TValueType>.SliderKey sliderKey, bool isShift);

		// Token: 0x0600072D RID: 1837 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600072D")]
		private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant)
		{
			return null;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072E")]
		private void SetSliderValueFromDrag()
		{
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072F")]
		private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos)
		{
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000730")]
		private void SetSliderValueFromClick()
		{
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000731")]
		private void OnKeyDown(KeyDownEvent evt)
		{
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000732")]
		internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000733")]
		public void AdjustDragElement(float factor)
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000734")]
		private void UpdateDragElementPosition(GeometryChangedEvent evt)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000735")]
		internal override void OnViewDataReady()
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x6000736")]
		private bool SameValues(float a, float b, float epsilon)
		{
			return default(bool);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000737")]
		private void UpdateDragElementPosition()
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000738")]
		protected override void ExecuteDefaultAction(EventBase evt)
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000739")]
		private void UpdateTextFieldVisibility()
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073A")]
		private void UpdateTextFieldValue()
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073B")]
		private void OnTextFieldFocusOut(FocusOutEvent evt)
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073C")]
		private void OnTextFieldValueChange(ChangeEvent<string> evt)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073D")]
		protected override void UpdateMixedValueContent()
		{
		}

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TValueType m_LowValue;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TValueType m_HighValue;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x0")]
		private float m_PageSize;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x0")]
		private bool m_ShowInputField;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x0")]
		private Rect m_DragElementStartPos;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x0")]
		private SliderDirection m_Direction;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x0")]
		private bool m_Inverted;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string labelUssClassName;

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string inputUssClassName;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string horizontalVariantUssClassName;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string verticalVariantUssClassName;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string dragContainerUssClassName;

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string trackerUssClassName;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string draggerUssClassName;

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string draggerBorderUssClassName;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string textFieldClassName;

		// Token: 0x020000F4 RID: 244
		[Token(Token = "0x20000F4")]
		internal enum SliderKey
		{
			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000394")]
			None,
			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4000395")]
			Lowest,
			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4000396")]
			LowerPage,
			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000397")]
			Lower,
			// Token: 0x04000398 RID: 920
			[Token(Token = "0x4000398")]
			Higher,
			// Token: 0x04000399 RID: 921
			[Token(Token = "0x4000399")]
			HigherPage,
			// Token: 0x0400039A RID: 922
			[Token(Token = "0x400039A")]
			Highest
		}
	}
}
