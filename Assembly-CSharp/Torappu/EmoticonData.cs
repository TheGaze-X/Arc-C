using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200100C RID: 4108
	[Token(Token = "0x200100C")]
	public class EmoticonData
	{
		// Token: 0x06006D62 RID: 28002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D62")]
		[Address(RVA = "0x21019E0", Offset = "0x21005E0", VA = "0x1821019E0")]
		public EmoticonData()
		{
		}

		// Token: 0x0400571C RID: 22300
		[Token(Token = "0x400571C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, EmoticonData.EmojiData> emojiDataDict;

		// Token: 0x0400571D RID: 22301
		[Token(Token = "0x400571D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, List<string>> emoticonThemeDataDict;

		// Token: 0x0200100D RID: 4109
		[Token(Token = "0x200100D")]
		public class EmojiData
		{
			// Token: 0x06006D63 RID: 28003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006D63")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EmojiData()
			{
			}

			// Token: 0x0400571E RID: 22302
			[Token(Token = "0x400571E")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0400571F RID: 22303
			[Token(Token = "0x400571F")]
			[FieldOffset(Offset = "0x18")]
			public EmojiSceneType type;

			// Token: 0x04005720 RID: 22304
			[Token(Token = "0x4005720")]
			[FieldOffset(Offset = "0x1C")]
			public int sortId;

			// Token: 0x04005721 RID: 22305
			[Token(Token = "0x4005721")]
			[FieldOffset(Offset = "0x20")]
			public string picId;

			// Token: 0x04005722 RID: 22306
			[Token(Token = "0x4005722")]
			[FieldOffset(Offset = "0x28")]
			public string desc;
		}
	}
}
