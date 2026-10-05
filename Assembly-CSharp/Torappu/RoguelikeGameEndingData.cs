using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001234 RID: 4660
	[Token(Token = "0x2001234")]
	public class RoguelikeGameEndingData
	{
		// Token: 0x06007033 RID: 28723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007033")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameEndingData()
		{
		}

		// Token: 0x0400648F RID: 25743
		[Token(Token = "0x400648F")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006490 RID: 25744
		[Token(Token = "0x4006490")]
		[FieldOffset(Offset = "0x18")]
		public int familyId;

		// Token: 0x04006491 RID: 25745
		[Token(Token = "0x4006491")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04006492 RID: 25746
		[Token(Token = "0x4006492")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x04006493 RID: 25747
		[Token(Token = "0x4006493")]
		[FieldOffset(Offset = "0x30")]
		public string bgId;

		// Token: 0x04006494 RID: 25748
		[Token(Token = "0x4006494")]
		[FieldOffset(Offset = "0x38")]
		public List<RoguelikeGameEndingData.LevelIcon> icons;

		// Token: 0x04006495 RID: 25749
		[Token(Token = "0x4006495")]
		[FieldOffset(Offset = "0x40")]
		public int priority;

		// Token: 0x04006496 RID: 25750
		[Token(Token = "0x4006496")]
		[FieldOffset(Offset = "0x48")]
		public string changeEndingDesc;

		// Token: 0x04006497 RID: 25751
		[Token(Token = "0x4006497")]
		[FieldOffset(Offset = "0x50")]
		public string bossIconId;

		// Token: 0x02001235 RID: 4661
		[Token(Token = "0x2001235")]
		public class LevelIcon
		{
			// Token: 0x06007034 RID: 28724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007034")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LevelIcon()
			{
			}

			// Token: 0x04006498 RID: 25752
			[Token(Token = "0x4006498")]
			[FieldOffset(Offset = "0x10")]
			public int level;

			// Token: 0x04006499 RID: 25753
			[Token(Token = "0x4006499")]
			[FieldOffset(Offset = "0x18")]
			public string iconId;
		}
	}
}
