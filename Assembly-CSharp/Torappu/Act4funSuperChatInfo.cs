using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EA9 RID: 3753
	[Token(Token = "0x2000EA9")]
	public class Act4funSuperChatInfo
	{
		// Token: 0x06006B7B RID: 27515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4funSuperChatInfo()
		{
		}

		// Token: 0x04004F42 RID: 20290
		[Token(Token = "0x4004F42")]
		[FieldOffset(Offset = "0x10")]
		public string superChatId;

		// Token: 0x04004F43 RID: 20291
		[Token(Token = "0x4004F43")]
		[FieldOffset(Offset = "0x18")]
		public Act4funSuperChatType chatType;

		// Token: 0x04004F44 RID: 20292
		[Token(Token = "0x4004F44")]
		[FieldOffset(Offset = "0x20")]
		public string userName;

		// Token: 0x04004F45 RID: 20293
		[Token(Token = "0x4004F45")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x04004F46 RID: 20294
		[Token(Token = "0x4004F46")]
		[FieldOffset(Offset = "0x30")]
		public string valueEffectId;

		// Token: 0x04004F47 RID: 20295
		[Token(Token = "0x4004F47")]
		[FieldOffset(Offset = "0x38")]
		public string performId;

		// Token: 0x04004F48 RID: 20296
		[Token(Token = "0x4004F48")]
		[FieldOffset(Offset = "0x40")]
		public string superChatTxt;
	}
}
