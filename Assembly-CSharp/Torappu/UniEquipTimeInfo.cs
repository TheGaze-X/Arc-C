using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013B2 RID: 5042
	[Token(Token = "0x20013B2")]
	public class UniEquipTimeInfo
	{
		// Token: 0x0600739D RID: 29597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniEquipTimeInfo()
		{
		}

		// Token: 0x0400700A RID: 28682
		[Token(Token = "0x400700A")]
		[FieldOffset(Offset = "0x10")]
		public long timeStamp;

		// Token: 0x0400700B RID: 28683
		[Token(Token = "0x400700B")]
		[FieldOffset(Offset = "0x18")]
		public List<UniEquipTrack> trackList;
	}
}
