using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	public class PopupWindow : TextElement
	{
		// Token: 0x0600087C RID: 2172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x5ABFC70", Offset = "0x5ABE870", VA = "0x185ABFC70")]
		public PopupWindow()
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001C3")]
		public override VisualElement contentContainer
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x5AADFF0", Offset = "0x5AACBF0", VA = "0x185AADFF0", Slot = "96")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x478")]
		private VisualElement m_ContentContainer;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string contentUssClassName;

		// Token: 0x0200012A RID: 298
		[Token(Token = "0x200012A")]
		public new class UxmlFactory : UxmlFactory<PopupWindow, PopupWindow.UxmlTraits>
		{
			// Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x5AD2C70", Offset = "0x5AD1870", VA = "0x185AD2C70")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x0200012B RID: 299
		[Token(Token = "0x200012B")]
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x06000880 RID: 2176 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x5ABE550", Offset = "0x5ABD150", VA = "0x185ABE550")]
			public UxmlTraits()
			{
			}
		}
	}
}
