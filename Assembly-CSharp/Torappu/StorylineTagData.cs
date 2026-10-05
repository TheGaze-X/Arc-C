using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001382 RID: 4994
	[Token(Token = "0x2001382")]
	[Serializable]
	public class StorylineTagData
	{
		// Token: 0x06007365 RID: 29541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007365")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StorylineTagData()
		{
		}

		// Token: 0x04006ED5 RID: 28373
		[Token(Token = "0x4006ED5")]
		[FieldOffset(Offset = "0x10")]
		public string tagId;

		// Token: 0x04006ED6 RID: 28374
		[Token(Token = "0x4006ED6")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04006ED7 RID: 28375
		[Token(Token = "0x4006ED7")]
		[FieldOffset(Offset = "0x20")]
		public string tagDesc;

		// Token: 0x04006ED8 RID: 28376
		[Token(Token = "0x4006ED8")]
		[FieldOffset(Offset = "0x28")]
		public string textColor;

		// Token: 0x04006ED9 RID: 28377
		[Token(Token = "0x4006ED9")]
		[FieldOffset(Offset = "0x30")]
		public string bkgColor;
	}
}
