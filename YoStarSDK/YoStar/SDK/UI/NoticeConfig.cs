using System;
using Il2CppDummyDll;

namespace YoStar.SDK.UI
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	public class NoticeConfig
	{
		// Token: 0x06000A05 RID: 2565 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NoticeConfig()
		{
		}

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x18")]
		public string content;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x20")]
		public string leftButtonContent;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x28")]
		public string rightButtonContent;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x30")]
		public bool showButtonCanvas;

		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		[FieldOffset(Offset = "0x31")]
		public bool showCloseButton;

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x32")]
		public bool showBackButton;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x38")]
		public Action closeAction;

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0x40")]
		public Action backAction;

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x48")]
		public Action leftAction;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x50")]
		public Action rightAction;
	}
}
