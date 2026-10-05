using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	public abstract class BaseField<TValueType> : BindableElement, INotifyValueChanged<TValueType>
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000171")]
		internal VisualElement visualInput
		{
			[Token(Token = "0x60006EB")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EC")]
			set
			{
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000172")]
		protected TValueType rawValue
		{
			[Token(Token = "0x60006ED")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EE")]
			set
			{
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000173")]
		public virtual TValueType value
		{
			[Token(Token = "0x60006EF")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F0")]
			set
			{
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000174")]
		public Label labelElement
		{
			[Token(Token = "0x60006F1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000175")]
		public string label
		{
			[Token(Token = "0x60006F3")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F4")]
			set
			{
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x17000176")]
		public bool showMixedValue
		{
			[Token(Token = "0x60006F5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000177")]
		protected Label mixedValueLabel
		{
			[Token(Token = "0x60006F6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F7")]
		internal BaseField(string label)
		{
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F8")]
		protected BaseField(string label, VisualElement visualInput)
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F9")]
		private void OnAttachToPanel(AttachToPanelEvent e)
		{
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FA")]
		private void OnCustomStyleResolved(CustomStyleResolvedEvent evt)
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FB")]
		private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FC")]
		private void AlignLabel()
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FD")]
		protected virtual void UpdateMixedValueContent()
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FE")]
		public virtual void SetValueWithoutNotify(TValueType newValue)
		{
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FF")]
		internal override void OnViewDataReady()
		{
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x6000700")]
		internal override Rect GetTooltipRect()
		{
			return default(Rect);
		}

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string labelUssClassName;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string inputUssClassName;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string noLabelVariantUssClassName;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string labelDraggerVariantUssClassName;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string mixedValueLabelUssClassName;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string alignedFieldUssClassName;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string inspectorFieldUssClassName;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x0")]
		protected internal static readonly string mixedValueString;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x0")]
		protected internal static readonly PropertyName serializedPropertyCopyName;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x0")]
		private static CustomStyleProperty<float> s_LabelWidthRatioProperty;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x0")]
		private static CustomStyleProperty<float> s_LabelExtraPaddingProperty;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x0")]
		private static CustomStyleProperty<float> s_LabelBaseMinWidthProperty;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x0")]
		private float m_LabelWidthRatio;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x0")]
		private float m_LabelExtraPadding;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x0")]
		private float m_LabelBaseMinWidth;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x0")]
		private VisualElement m_VisualInput;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TValueType m_Value;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x0")]
		private bool m_ShowMixedValue;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x0")]
		private Label m_MixedValueLabel;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x0")]
		private VisualElement m_CachedInspectorElement;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x0")]
		private int m_CachedListAndFoldoutDepth;

		// Token: 0x020000F0 RID: 240
		[Token(Token = "0x20000F0")]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x06000702 RID: 1794 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000702")]
			public UxmlTraits()
			{
			}

			// Token: 0x06000703 RID: 1795 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000703")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x06000704 RID: 1796 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6000704")]
			internal static List<string> ParseChoiceList(string choicesFromBag)
			{
				return null;
			}

			// Token: 0x04000377 RID: 887
			[Token(Token = "0x4000377")]
			[FieldOffset(Offset = "0x0")]
			private UxmlStringAttributeDescription m_Label;
		}
	}
}
