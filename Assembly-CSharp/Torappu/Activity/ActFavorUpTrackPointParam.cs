using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D7F RID: 28031
	[Token(Token = "0x2006D7F")]
	public class ActFavorUpTrackPointParam
	{
		// Token: 0x06027EF2 RID: 163570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EF2")]
		[Address(RVA = "0x919A60", Offset = "0x918660", VA = "0x180919A60")]
		public void Clear()
		{
		}

		// Token: 0x06027EF3 RID: 163571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EF3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActFavorUpTrackPointParam()
		{
		}

		// Token: 0x040389A2 RID: 231842
		[Token(Token = "0x40389A2")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040389A3 RID: 231843
		[Token(Token = "0x40389A3")]
		[FieldOffset(Offset = "0x18")]
		public List<string> favorUpList;
	}
}
