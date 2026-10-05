using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	internal class ButtonStripField : BaseField<int>
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700019F")]
		private List<Button> buttons
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x5AADA40", Offset = "0x5AAC640", VA = "0x185AADA40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x5AAD980", Offset = "0x5AAC580", VA = "0x185AAD980")]
		public ButtonStripField()
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x5AAD800", Offset = "0x5AAC400", VA = "0x185AAD800", Slot = "107")]
		public override void SetValueWithoutNotify(int newValue)
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x5AAD6E0", Offset = "0x5AAC2E0", VA = "0x185AAD6E0")]
		private void RefreshButtonsState()
		{
		}

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x408")]
		private List<Button> m_Buttons;

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		public new class UxmlFactory : UxmlFactory<ButtonStripField, ButtonStripField.UxmlTraits>
		{
			// Token: 0x060007B7 RID: 1975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x5ABD360", Offset = "0x5ABBF60", VA = "0x185ABD360")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000104 RID: 260
		[Token(Token = "0x2000104")]
		public new class UxmlTraits : BaseField<int>.UxmlTraits
		{
			// Token: 0x060007B8 RID: 1976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x5ABEE50", Offset = "0x5ABDA50", VA = "0x185ABEE50")]
			public UxmlTraits()
			{
			}
		}
	}
}
