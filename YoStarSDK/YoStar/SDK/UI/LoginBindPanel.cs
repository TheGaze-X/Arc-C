using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x0200017B RID: 379
	[Token(Token = "0x200017B")]
	public class LoginBindPanel : BasePanel
	{
		// Token: 0x06000982 RID: 2434 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x5C64AC0", Offset = "0x5C636C0", VA = "0x185C64AC0")]
		public new void Awake()
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x5C64AD0", Offset = "0x5C636D0", VA = "0x185C64AD0")]
		private void FindComponent()
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x5C65150", Offset = "0x5C63D50", VA = "0x185C65150", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x5C65080", Offset = "0x5C63C80", VA = "0x185C65080")]
		private void OnClick(Button clickButton)
		{
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x5C65580", Offset = "0x5C64180", VA = "0x185C65580")]
		private void sevenDays()
		{
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public LoginBindPanel()
		{
		}

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x50")]
		private Text text;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x58")]
		private GameObject topCanvas;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x60")]
		private Button choiceButton;

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0x68")]
		private Button loginButton;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x70")]
		private Button closeButton;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x78")]
		private bool choice;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x80")]
		private EmailInputPanel emailInputPanel;
	}
}
