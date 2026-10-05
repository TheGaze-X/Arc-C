using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	public class DropdownField : BaseField<string>
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001A0")]
		protected TextElement textElement
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x5AAF290", Offset = "0x5AADE90", VA = "0x185AAF290")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x5AAE710", Offset = "0x5AAD310", VA = "0x185AAE710")]
		internal string GetValueToDisplay()
		{
			return null;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x5AAE650", Offset = "0x5AAD250", VA = "0x185AAE650")]
		internal string GetListItemToDisplay(string value)
		{
			return null;
		}

		// Token: 0x170001A1 RID: 417
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A1")]
		public int index
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x5AAF370", Offset = "0x5AADF70", VA = "0x185AAF370")]
			set
			{
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x5AAF280", Offset = "0x5AADE80", VA = "0x185AAF280")]
		public DropdownField()
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x5AAEEC0", Offset = "0x5AADAC0", VA = "0x185AAEEC0")]
		public DropdownField(string label)
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x5AAE080", Offset = "0x5AACC80", VA = "0x185AAE080")]
		internal void AddMenuItems(IGenericMenu menu)
		{
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x5AAE400", Offset = "0x5AAD000", VA = "0x185AAE400")]
		private void ChangeValueFromMenu(string menuItem)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A2")]
		public virtual List<string> choices
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x5AAF2E0", Offset = "0x5AADEE0", VA = "0x185AAF2E0", Slot = "108")]
			set
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A3")]
		public override string value
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x5AAF2A0", Offset = "0x5AADEA0", VA = "0x185AAF2A0", Slot = "102")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x5AAF440", Offset = "0x5AAE040", VA = "0x185AAF440", Slot = "103")]
			set
			{
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x5AAE7E0", Offset = "0x5AAD3E0", VA = "0x185AAE7E0", Slot = "107")]
		public override void SetValueWithoutNotify(string newValue)
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x5AAE450", Offset = "0x5AAD050", VA = "0x185AAE450", Slot = "11")]
		protected override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x5AAE940", Offset = "0x5AAD540", VA = "0x185AAE940")]
		private void ShowMenu()
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x5AAEB20", Offset = "0x5AAD720", VA = "0x185AAEB20", Slot = "106")]
		protected override void UpdateMixedValueContent()
		{
		}

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x408")]
		internal List<string> m_Choices;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x410")]
		private TextElement m_TextElement;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x418")]
		private VisualElement m_ArrowElement;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x420")]
		internal Func<string, string> m_FormatSelectedValueCallback;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x428")]
		internal Func<string, string> m_FormatListItemCallback;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x430")]
		internal Func<IGenericMenu> createMenuCallback;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x438")]
		private int m_Index;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly string ussClassNameBasePopupField;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly string textUssClassNameBasePopupField;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly string arrowUssClassNameBasePopupField;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly string labelUssClassNameBasePopupField;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly string inputUssClassNameBasePopupField;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly string ussClassNamePopupField;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly string labelUssClassNamePopupField;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly string inputUssClassNamePopupField;

		// Token: 0x02000106 RID: 262
		[Token(Token = "0x2000106")]
		public new class UxmlFactory : UxmlFactory<DropdownField, DropdownField.UxmlTraits>
		{
			// Token: 0x060007C9 RID: 1993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x5ABD320", Offset = "0x5ABBF20", VA = "0x185ABD320")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000107 RID: 263
		[Token(Token = "0x2000107")]
		public new class UxmlTraits : BaseField<string>.UxmlTraits
		{
			// Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x5ABE2B0", Offset = "0x5ABCEB0", VA = "0x185ABE2B0", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x5ABED30", Offset = "0x5ABD930", VA = "0x185ABED30")]
			public UxmlTraits()
			{
			}

			// Token: 0x040003EB RID: 1003
			[Token(Token = "0x40003EB")]
			[FieldOffset(Offset = "0x80")]
			private UxmlIntAttributeDescription m_Index;

			// Token: 0x040003EC RID: 1004
			[Token(Token = "0x40003EC")]
			[FieldOffset(Offset = "0x88")]
			private UxmlStringAttributeDescription m_Choices;
		}

		// Token: 0x02000108 RID: 264
		[Token(Token = "0x2000108")]
		private class PopupTextElement : TextElement
		{
			// Token: 0x060007CC RID: 1996 RVA: 0x00005028 File Offset: 0x00003228
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x5ABBFD0", Offset = "0x5ABABD0", VA = "0x185ABBFD0", Slot = "95")]
			protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
			{
				return default(Vector2);
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x5ABC0A0", Offset = "0x5ABACA0", VA = "0x185ABC0A0")]
			public PopupTextElement()
			{
			}
		}
	}
}
