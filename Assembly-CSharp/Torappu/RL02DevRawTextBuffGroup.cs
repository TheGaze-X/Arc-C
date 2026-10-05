using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011F4 RID: 4596
	[Token(Token = "0x20011F4")]
	public class RL02DevRawTextBuffGroup
	{
		// Token: 0x06006FE4 RID: 28644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL02DevRawTextBuffGroup()
		{
		}

		// Token: 0x040062D1 RID: 25297
		[Token(Token = "0x40062D1")]
		[FieldOffset(Offset = "0x10")]
		public string[] nodeIdList;

		// Token: 0x040062D2 RID: 25298
		[Token(Token = "0x40062D2")]
		[FieldOffset(Offset = "0x18")]
		public bool useLevelMark;

		// Token: 0x040062D3 RID: 25299
		[Token(Token = "0x40062D3")]
		[FieldOffset(Offset = "0x20")]
		public string groupIconId;

		// Token: 0x040062D4 RID: 25300
		[Token(Token = "0x40062D4")]
		[FieldOffset(Offset = "0x28")]
		public bool useUpBreak;

		// Token: 0x040062D5 RID: 25301
		[Token(Token = "0x40062D5")]
		[FieldOffset(Offset = "0x2C")]
		public int sortId;
	}
}
