using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001016 RID: 4118
	[Token(Token = "0x2001016")]
	public class ResolutionSettingItemData
	{
		// Token: 0x06006D69 RID: 28009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D69")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ResolutionSettingItemData()
		{
		}

		// Token: 0x04005776 RID: 22390
		[Token(Token = "0x4005776")]
		[FieldOffset(Offset = "0x10")]
		public int sortId;

		// Token: 0x04005777 RID: 22391
		[Token(Token = "0x4005777")]
		[FieldOffset(Offset = "0x14")]
		public int resolutionWidth;

		// Token: 0x04005778 RID: 22392
		[Token(Token = "0x4005778")]
		[FieldOffset(Offset = "0x18")]
		public int resolutionHeight;

		// Token: 0x04005779 RID: 22393
		[Token(Token = "0x4005779")]
		[FieldOffset(Offset = "0x20")]
		public string resolutionText;

		// Token: 0x0400577A RID: 22394
		[Token(Token = "0x400577A")]
		[FieldOffset(Offset = "0x28")]
		public bool isFullScreen;

		// Token: 0x0400577B RID: 22395
		[Token(Token = "0x400577B")]
		[FieldOffset(Offset = "0x29")]
		public bool isBorderless;
	}
}
