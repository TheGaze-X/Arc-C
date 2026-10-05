using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x0200153D RID: 5437
	[Token(Token = "0x200153D")]
	public class TeamChatParam
	{
		// Token: 0x06007CA8 RID: 31912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TeamChatParam()
		{
		}

		// Token: 0x04007CDB RID: 31963
		[Token(Token = "0x4007CDB")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04007CDC RID: 31964
		[Token(Token = "0x4007CDC")]
		[FieldOffset(Offset = "0x18")]
		public string emoticonThemeId;

		// Token: 0x04007CDD RID: 31965
		[Token(Token = "0x4007CDD")]
		[FieldOffset(Offset = "0x20")]
		public string emojiChatId;
	}
}
