using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066CC RID: 26316
	[Token(Token = "0x20066CC")]
	public class HandBookStoryViewModel
	{
		// Token: 0x06025C89 RID: 154761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C89")]
		[Address(RVA = "0x20BE380", Offset = "0x20BCF80", VA = "0x1820BE380")]
		public static HandBookStoryViewModel ConvertFromData(HandBookStoryViewData data, CharQuery charQuery)
		{
			return null;
		}

		// Token: 0x06025C8A RID: 154762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C8A")]
		[Address(RVA = "0x20BE630", Offset = "0x20BD230", VA = "0x1820BE630")]
		public HandBookStoryViewModel()
		{
		}

		// Token: 0x040351DA RID: 217562
		[Token(Token = "0x40351DA")]
		[FieldOffset(Offset = "0x10")]
		public List<HandBookStoryViewData.StoryText> stories;

		// Token: 0x040351DB RID: 217563
		[Token(Token = "0x40351DB")]
		[FieldOffset(Offset = "0x18")]
		public string storyTitle;

		// Token: 0x040351DC RID: 217564
		[Token(Token = "0x40351DC")]
		[FieldOffset(Offset = "0x20")]
		public bool unlockFlag;

		// Token: 0x040351DD RID: 217565
		[Token(Token = "0x40351DD")]
		[FieldOffset(Offset = "0x21")]
		public bool initFlag;
	}
}
