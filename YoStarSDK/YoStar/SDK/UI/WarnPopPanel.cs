using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	public class WarnPopPanel : BasePanel
	{
		// Token: 0x06000AEE RID: 2798 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x5C9C950", Offset = "0x5C9B550", VA = "0x185C9C950")]
		public new void Awake()
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x5C9CEF0", Offset = "0x5C9BAF0", VA = "0x185C9CEF0")]
		private void OnClick(Button button)
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x5C9CA60", Offset = "0x5C9B660", VA = "0x185C9CA60")]
		private void FindComponent()
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x5C9CDF0", Offset = "0x5C9B9F0", VA = "0x185C9CDF0")]
		private void OnAddEvent()
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x5C9CF70", Offset = "0x5C9BB70", VA = "0x185C9CF70", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x5C9D360", Offset = "0x5C9BF60", VA = "0x185C9D360")]
		private void Update()
		{
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public WarnPopPanel()
		{
		}

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x50")]
		private Text title;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x58")]
		private Text subTitle;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x60")]
		private Button cancelButton;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x68")]
		private Button confirmButton;

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x70")]
		public Action<bool> OnClickAction;
	}
}
