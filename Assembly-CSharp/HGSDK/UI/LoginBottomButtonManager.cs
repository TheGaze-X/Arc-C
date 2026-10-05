using System;
using Il2CppDummyDll;

namespace HGSDK.UI
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	public class LoginBottomButtonManager
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1AD38C0", Offset = "0x1AD24C0", VA = "0x181AD38C0")]
		public void OnInit(LoginBottomButton[] buttons)
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1AD3940", Offset = "0x1AD2540", VA = "0x181AD3940")]
		public void UpdateVisibility(SDKLoginPage.BottomButtonType bottomBtnMask)
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginBottomButtonManager()
		{
		}

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0x10")]
		private LoginBottomButton[] m_buttons;
	}
}
