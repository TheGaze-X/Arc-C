using System;
using Il2CppDummyDll;

namespace YoStar.SDK.UI
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	public class UserCenterObject
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserCenterObject()
		{
		}

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x18")]
		public ActionType actionType;
	}
}
