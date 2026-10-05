using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011F9 RID: 4601
	[Token(Token = "0x20011F9")]
	public class RoguelikeTopicMonthSquad
	{
		// Token: 0x06006FE8 RID: 28648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicMonthSquad()
		{
		}

		// Token: 0x040062E5 RID: 25317
		[Token(Token = "0x40062E5")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040062E6 RID: 25318
		[Token(Token = "0x40062E6")]
		[FieldOffset(Offset = "0x18")]
		public string teamName;

		// Token: 0x040062E7 RID: 25319
		[Token(Token = "0x40062E7")]
		[FieldOffset(Offset = "0x20")]
		public string teamSubName;

		// Token: 0x040062E8 RID: 25320
		[Token(Token = "0x40062E8")]
		[FieldOffset(Offset = "0x28")]
		public string teamFlavorDesc;

		// Token: 0x040062E9 RID: 25321
		[Token(Token = "0x40062E9")]
		[FieldOffset(Offset = "0x30")]
		public string teamDes;

		// Token: 0x040062EA RID: 25322
		[Token(Token = "0x40062EA")]
		[FieldOffset(Offset = "0x38")]
		public string teamColor;

		// Token: 0x040062EB RID: 25323
		[Token(Token = "0x40062EB")]
		[FieldOffset(Offset = "0x40")]
		public string teamMonth;

		// Token: 0x040062EC RID: 25324
		[Token(Token = "0x40062EC")]
		[FieldOffset(Offset = "0x48")]
		public string teamYear;

		// Token: 0x040062ED RID: 25325
		[Token(Token = "0x40062ED")]
		[FieldOffset(Offset = "0x50")]
		public string teamIndex;

		// Token: 0x040062EE RID: 25326
		[Token(Token = "0x40062EE")]
		[FieldOffset(Offset = "0x58")]
		public List<RoguelikeTopicMonthSquadTeamChar> teamChars;

		// Token: 0x040062EF RID: 25327
		[Token(Token = "0x40062EF")]
		[FieldOffset(Offset = "0x60")]
		public string zoneId;

		// Token: 0x040062F0 RID: 25328
		[Token(Token = "0x40062F0")]
		[FieldOffset(Offset = "0x68")]
		public string chatId;

		// Token: 0x040062F1 RID: 25329
		[Token(Token = "0x40062F1")]
		[FieldOffset(Offset = "0x70")]
		public int tokenRewardNum;

		// Token: 0x040062F2 RID: 25330
		[Token(Token = "0x40062F2")]
		[FieldOffset(Offset = "0x78")]
		public List<ItemBundle> items;

		// Token: 0x040062F3 RID: 25331
		[Token(Token = "0x40062F3")]
		[FieldOffset(Offset = "0x80")]
		public long startTime;

		// Token: 0x040062F4 RID: 25332
		[Token(Token = "0x40062F4")]
		[FieldOffset(Offset = "0x88")]
		public long endTime;

		// Token: 0x040062F5 RID: 25333
		[Token(Token = "0x40062F5")]
		[FieldOffset(Offset = "0x90")]
		public string taskDes;
	}
}
