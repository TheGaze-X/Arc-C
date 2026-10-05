using System;
using Il2CppDummyDll;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046FE RID: 18174
	[Token(Token = "0x20046FE")]
	public struct BuildTagModel
	{
		// Token: 0x04023B22 RID: 146210
		[Token(Token = "0x4023B22")]
		[FieldOffset(Offset = "0x0")]
		public int tagId;

		// Token: 0x04023B23 RID: 146211
		[Token(Token = "0x4023B23")]
		[FieldOffset(Offset = "0x4")]
		public bool isSpecial;

		// Token: 0x04023B24 RID: 146212
		[Token(Token = "0x4023B24")]
		[FieldOffset(Offset = "0x8")]
		public BuildTagType type;

		// Token: 0x04023B25 RID: 146213
		[Token(Token = "0x4023B25")]
		[FieldOffset(Offset = "0x10")]
		public string content;
	}
}
