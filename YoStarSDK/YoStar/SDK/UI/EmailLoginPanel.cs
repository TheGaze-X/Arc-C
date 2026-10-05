using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	public class EmailLoginPanel : BasePanel
	{
		// Token: 0x0600090C RID: 2316 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x5C61710", Offset = "0x5C60310", VA = "0x185C61710")]
		private new void Awake()
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x5C61720", Offset = "0x5C60320", VA = "0x185C61720")]
		private void FindComponent()
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x5C62080", Offset = "0x5C60C80", VA = "0x185C62080", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x5C62610", Offset = "0x5C61210", VA = "0x185C62610")]
		private void Update()
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x5C624F0", Offset = "0x5C610F0", VA = "0x185C624F0")]
		private void OnLogin()
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x5C61FB0", Offset = "0x5C60BB0", VA = "0x185C61FB0")]
		private void OnClosePanel()
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x5C61F50", Offset = "0x5C60B50", VA = "0x185C61F50")]
		private void OnBackPanel()
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public EmailLoginPanel()
		{
		}

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x50")]
		private Button closeBtn;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x58")]
		private Button loginBtn;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x60")]
		private Button backBtn;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x68")]
		private EmailInputPanel emailInputPanel;

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x70")]
		private LoginStylePanel loginStylePanel;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x78")]
		private Button accountRecoveryButton;
	}
}
