using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	public class PassPanel : BasePanel
	{
		// Token: 0x06000A06 RID: 2566 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x5C73310", Offset = "0x5C71F10", VA = "0x185C73310")]
		private new void Awake()
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x5C73320", Offset = "0x5C71F20", VA = "0x185C73320")]
		private void FindComponent()
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x5C73BF0", Offset = "0x5C727F0", VA = "0x185C73BF0")]
		private void OnClearAction()
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x5C73DC0", Offset = "0x5C729C0", VA = "0x185C73DC0", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x5C74640", Offset = "0x5C73240", VA = "0x185C74640")]
		private void SetButtonProperty()
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x5C746B0", Offset = "0x5C732B0", VA = "0x185C746B0")]
		private void Start()
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x5C744C0", Offset = "0x5C730C0", VA = "0x185C744C0")]
		private void OnInputFieldFocusChanged(bool isFocused)
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x5C74540", Offset = "0x5C73140", VA = "0x185C74540")]
		public void OnValueChanged(string value)
		{
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x5C73D20", Offset = "0x5C72920", VA = "0x185C73D20")]
		private void OnClick()
		{
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public PassPanel()
		{
		}

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		[FieldOffset(Offset = "0x50")]
		private Button closeBtn;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0x58")]
		private Text title;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x60")]
		private Text messageText;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x68")]
		private InputField inputField;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x70")]
		private InputFieldFocusDetector inputFieldFocusDetector;

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x78")]
		private Button loginButton;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0x80")]
		private Text wordText;

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x88")]
		private PassType passType;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x90")]
		private Button clearButton;
	}
}
