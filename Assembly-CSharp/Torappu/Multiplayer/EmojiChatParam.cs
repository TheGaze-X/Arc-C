using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x02001542 RID: 5442
	[Token(Token = "0x2001542")]
	public class EmojiChatParam
	{
		// Token: 0x06007CAA RID: 31914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EmojiChatParam()
		{
		}

		// Token: 0x04007D09 RID: 32009
		[Token(Token = "0x4007D09")]
		[FieldOffset(Offset = "0x10")]
		public string emoticonThemeId;

		// Token: 0x04007D0A RID: 32010
		[Token(Token = "0x4007D0A")]
		[FieldOffset(Offset = "0x18")]
		public string emojiChatId;
	}
}
