using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001383 RID: 4995
	[Token(Token = "0x2001383")]
	[Serializable]
	public class StorylineConstData
	{
		// Token: 0x06007366 RID: 29542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007366")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StorylineConstData()
		{
		}

		// Token: 0x04006EDA RID: 28378
		[Token(Token = "0x4006EDA")]
		[FieldOffset(Offset = "0x10")]
		public string recommendHideGuideGroupId;

		// Token: 0x04006EDB RID: 28379
		[Token(Token = "0x4006EDB")]
		[FieldOffset(Offset = "0x18")]
		public string tutorialSelectStorylineId;

		// Token: 0x04006EDC RID: 28380
		[Token(Token = "0x4006EDC")]
		[FieldOffset(Offset = "0x20")]
		public string mainlineStorylineId;
	}
}
