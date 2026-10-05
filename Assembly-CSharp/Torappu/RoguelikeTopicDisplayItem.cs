using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011EE RID: 4590
	[Token(Token = "0x20011EE")]
	public class RoguelikeTopicDisplayItem
	{
		// Token: 0x06006FDF RID: 28639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FDF")]
		[Address(RVA = "0x2114530", Offset = "0x2113130", VA = "0x182114530")]
		public string GetDisplayStr()
		{
			return null;
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FE0")]
		[Address(RVA = "0x21145D0", Offset = "0x21131D0", VA = "0x1821145D0")]
		public string GetDisplayValueStr()
		{
			return null;
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicDisplayItem()
		{
		}

		// Token: 0x040062A5 RID: 25253
		[Token(Token = "0x40062A5")]
		[FieldOffset(Offset = "0x10")]
		public string displayType;

		// Token: 0x040062A6 RID: 25254
		[Token(Token = "0x40062A6")]
		[FieldOffset(Offset = "0x18")]
		public int displayNum;

		// Token: 0x040062A7 RID: 25255
		[Token(Token = "0x40062A7")]
		[FieldOffset(Offset = "0x1C")]
		public RoguelikeTopicDevTokenDisplayForm displayForm;

		// Token: 0x040062A8 RID: 25256
		[Token(Token = "0x40062A8")]
		[FieldOffset(Offset = "0x20")]
		public string tokenDesc;

		// Token: 0x040062A9 RID: 25257
		[Token(Token = "0x40062A9")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;
	}
}
