using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	public class HelpBox : VisualElement
	{
		// Token: 0x170001A9 RID: 425
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A9")]
		public string text
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x5AB3A80", Offset = "0x5AB2680", VA = "0x185AB3A80")]
			set
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AA")]
		public HelpBoxMessageType messageType
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x5AB3A60", Offset = "0x5AB2660", VA = "0x185AB3A60")]
			set
			{
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x5AB36E0", Offset = "0x5AB22E0", VA = "0x185AB36E0")]
		public HelpBox()
		{
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x5AB38B0", Offset = "0x5AB24B0", VA = "0x185AB38B0")]
		public HelpBox(string text, HelpBoxMessageType messageType)
		{
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x5AB3260", Offset = "0x5AB1E60", VA = "0x185AB3260")]
		private string GetIconClass(HelpBoxMessageType messageType)
		{
			return null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x5AB3330", Offset = "0x5AB1F30", VA = "0x185AB3330")]
		private void UpdateIcon(HelpBoxMessageType messageType)
		{
		}

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string labelUssClassName;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string iconUssClassName;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string iconInfoUssClassName;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string iconwarningUssClassName;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string iconErrorUssClassName;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x3B0")]
		private HelpBoxMessageType m_HelpBoxMessageType;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x3B8")]
		private VisualElement m_Icon;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x3C0")]
		private string m_IconClass;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x3C8")]
		private Label m_Label;

		// Token: 0x02000116 RID: 278
		[Token(Token = "0x2000116")]
		public new class UxmlFactory : UxmlFactory<HelpBox, HelpBox.UxmlTraits>
		{
			// Token: 0x06000807 RID: 2055 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x5ABD4E0", Offset = "0x5ABC0E0", VA = "0x185ABD4E0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000117 RID: 279
		[Token(Token = "0x2000117")]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x06000808 RID: 2056 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x5ABDF20", Offset = "0x5ABCB20", VA = "0x185ABDF20", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x06000809 RID: 2057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x5ABEEE0", Offset = "0x5ABDAE0", VA = "0x185ABEEE0")]
			public UxmlTraits()
			{
			}

			// Token: 0x04000425 RID: 1061
			[Token(Token = "0x4000425")]
			[FieldOffset(Offset = "0x70")]
			private UxmlStringAttributeDescription m_Text;

			// Token: 0x04000426 RID: 1062
			[Token(Token = "0x4000426")]
			[FieldOffset(Offset = "0x78")]
			private UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType;
		}
	}
}
