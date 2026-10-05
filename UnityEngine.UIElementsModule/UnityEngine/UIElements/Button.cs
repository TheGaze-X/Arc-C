using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public class Button : TextElement
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019E")]
		public Clickable clickable
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x5AADFF0", Offset = "0x5AACBF0", VA = "0x185AADFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x5AAE000", Offset = "0x5AACC00", VA = "0x185AAE000")]
			set
			{
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x5AADFE0", Offset = "0x5AACBE0", VA = "0x185AADFE0")]
		public Button()
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x5AADDE0", Offset = "0x5AAC9E0", VA = "0x185AADDE0")]
		public Button(Action clickEvent)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x5AADCF0", Offset = "0x5AAC8F0", VA = "0x185AADCF0")]
		private void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x5AADC30", Offset = "0x5AAC830", VA = "0x185AADC30")]
		private void OnKeyDown(KeyDownEvent evt)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x5AADB40", Offset = "0x5AAC740", VA = "0x185AADB40", Slot = "95")]
		protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return default(Vector2);
		}

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x478")]
		private Clickable m_Clickable;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string NonEmptyString;

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		public new class UxmlFactory : UxmlFactory<Button, Button.UxmlTraits>
		{
			// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x5ABD3E0", Offset = "0x5ABBFE0", VA = "0x185ABD3E0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000101 RID: 257
		[Token(Token = "0x2000101")]
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x060007B2 RID: 1970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x5ABEE90", Offset = "0x5ABDA90", VA = "0x185ABEE90")]
			public UxmlTraits()
			{
			}
		}
	}
}
