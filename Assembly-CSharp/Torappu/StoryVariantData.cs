using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001011 RID: 4113
	[Token(Token = "0x2001011")]
	public class StoryVariantData
	{
		// Token: 0x06006D66 RID: 28006 RVA: 0x00031C80 File Offset: 0x0002FE80
		[Token(Token = "0x6006D66")]
		[Address(RVA = "0x2116640", Offset = "0x2115240", VA = "0x182116640")]
		public static int Compare(StoryVariantData lhs, StoryVariantData rhs)
		{
			return 0;
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D67")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoryVariantData()
		{
		}

		// Token: 0x0400575E RID: 22366
		[Token(Token = "0x400575E")]
		[FieldOffset(Offset = "0x10")]
		public string plotTaskId;

		// Token: 0x0400575F RID: 22367
		[Token(Token = "0x400575F")]
		[FieldOffset(Offset = "0x18")]
		public string spStoryId;

		// Token: 0x04005760 RID: 22368
		[Token(Token = "0x4005760")]
		[FieldOffset(Offset = "0x20")]
		public string storyId;

		// Token: 0x04005761 RID: 22369
		[Token(Token = "0x4005761")]
		[FieldOffset(Offset = "0x28")]
		public int priority;

		// Token: 0x04005762 RID: 22370
		[Token(Token = "0x4005762")]
		[FieldOffset(Offset = "0x30")]
		public long startTime;

		// Token: 0x04005763 RID: 22371
		[Token(Token = "0x4005763")]
		[FieldOffset(Offset = "0x38")]
		public long endTime;

		// Token: 0x04005764 RID: 22372
		[Token(Token = "0x4005764")]
		[FieldOffset(Offset = "0x40")]
		public string template;

		// Token: 0x04005765 RID: 22373
		[Token(Token = "0x4005765")]
		[FieldOffset(Offset = "0x48")]
		public string[] param;
	}
}
