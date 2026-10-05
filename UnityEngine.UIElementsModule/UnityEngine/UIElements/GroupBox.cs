using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	public class GroupBox : BindableElement, IGroupBox
	{
		// Token: 0x170001A8 RID: 424
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A8")]
		public string text
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x5AB3100", Offset = "0x5AB1D00", VA = "0x185AB3100")]
			set
			{
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x5AB3080", Offset = "0x5AB1C80", VA = "0x185AB3080")]
		public GroupBox()
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x5AB2FF0", Offset = "0x5AB1BF0", VA = "0x185AB2FF0")]
		public GroupBox(string text)
		{
		}

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string labelUssClassName;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x3C0")]
		private Label m_TitleLabel;

		// Token: 0x02000112 RID: 274
		[Token(Token = "0x2000112")]
		public new class UxmlFactory : UxmlFactory<GroupBox, GroupBox.UxmlTraits>
		{
			// Token: 0x060007FD RID: 2045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x5ABD460", Offset = "0x5ABC060", VA = "0x185ABD460")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000113 RID: 275
		[Token(Token = "0x2000113")]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x060007FE RID: 2046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x5ABE0F0", Offset = "0x5ABCCF0", VA = "0x185ABE0F0", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060007FF RID: 2047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x5ABECA0", Offset = "0x5ABD8A0", VA = "0x185ABECA0")]
			public UxmlTraits()
			{
			}

			// Token: 0x04000415 RID: 1045
			[Token(Token = "0x4000415")]
			[FieldOffset(Offset = "0x78")]
			private UxmlStringAttributeDescription m_Text;
		}
	}
}
