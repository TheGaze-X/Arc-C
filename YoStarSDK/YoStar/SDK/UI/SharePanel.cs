using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	public class SharePanel : BasePanel
	{
		// Token: 0x06000AA3 RID: 2723 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x5C7C040", Offset = "0x5C7AC40", VA = "0x185C7C040")]
		private new void Awake()
		{
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x5C7CA70", Offset = "0x5C7B670", VA = "0x185C7CA70")]
		private void FindComponent()
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x5C7CD00", Offset = "0x5C7B900", VA = "0x185C7CD00", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x5C7CC30", Offset = "0x5C7B830", VA = "0x185C7CC30")]
		private void OnClick(SharePanel.ButtonStyle buttonStyle)
		{
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x5C7D0E0", Offset = "0x5C7BCE0", VA = "0x185C7D0E0", Slot = "12")]
		public override void OnDestory()
		{
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void CopyImageToClipboard(string url)
		{
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x5C7C050", Offset = "0x5C7AC50", VA = "0x185C7C050")]
		private void DealLoginData()
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public SharePanel()
		{
		}

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x50")]
		private Text shareText;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x58")]
		private GameObject buttonView;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x60")]
		private Texture2D texture2D;

		// Token: 0x020001BB RID: 443
		[Token(Token = "0x20001BB")]
		private enum ButtonStyle
		{
			// Token: 0x04000731 RID: 1841
			[Token(Token = "0x4000731")]
			ys_share_twitter,
			// Token: 0x04000732 RID: 1842
			[Token(Token = "0x4000732")]
			ys_share_facebook,
			// Token: 0x04000733 RID: 1843
			[Token(Token = "0x4000733")]
			ys_close
		}
	}
}
