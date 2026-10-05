using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200453D RID: 17725
	[Token(Token = "0x200453D")]
	public class RoguelikeTopicCreateGameRequest
	{
		// Token: 0x0601B095 RID: 110741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B095")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicCreateGameRequest()
		{
		}

		// Token: 0x04022BA9 RID: 142249
		[Token(Token = "0x4022BA9")]
		[FieldOffset(Offset = "0x10")]
		public string theme;

		// Token: 0x04022BAA RID: 142250
		[Token(Token = "0x4022BAA")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicMode mode;

		// Token: 0x04022BAB RID: 142251
		[Token(Token = "0x4022BAB")]
		[FieldOffset(Offset = "0x1C")]
		public int modeGrade;

		// Token: 0x04022BAC RID: 142252
		[Token(Token = "0x4022BAC")]
		[FieldOffset(Offset = "0x20")]
		public string predefinedId;

		// Token: 0x04022BAD RID: 142253
		[Token(Token = "0x4022BAD")]
		[FieldOffset(Offset = "0x28")]
		public string activityId;
	}
}
