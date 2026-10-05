using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A60 RID: 2656
	[Token(Token = "0x2000A60")]
	public class PlayerBuildingMeetingClueChar
	{
		// Token: 0x0600671F RID: 26399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600671F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingMeetingClueChar()
		{
		}

		// Token: 0x04003878 RID: 14456
		[Token(Token = "0x4003878")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04003879 RID: 14457
		[Token(Token = "0x4003879")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x0400387A RID: 14458
		[Token(Token = "0x400387A")]
		[FieldOffset(Offset = "0x1C")]
		public int evolvePhase;
	}
}
