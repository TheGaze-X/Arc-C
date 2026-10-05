using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200069B RID: 1691
	[Token(Token = "0x200069B")]
	public class BuildingSendEmojiRequest : BuildingRequest
	{
		// Token: 0x060062D7 RID: 25303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingSendEmojiRequest()
		{
		}

		// Token: 0x04002E87 RID: 11911
		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x10")]
		public string friendId;

		// Token: 0x04002E88 RID: 11912
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x18")]
		public string emoji;
	}
}
