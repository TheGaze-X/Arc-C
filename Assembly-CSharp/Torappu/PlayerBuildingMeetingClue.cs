using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A61 RID: 2657
	[Token(Token = "0x2000A61")]
	public class PlayerBuildingMeetingClue
	{
		// Token: 0x06006720 RID: 26400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006720")]
		[Address(RVA = "0x1EF1870", Offset = "0x1EF0470", VA = "0x181EF1870")]
		public PlayerBuildingMeetingClue()
		{
		}

		// Token: 0x0400387B RID: 14459
		[Token(Token = "0x400387B")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400387C RID: 14460
		[Token(Token = "0x400387C")]
		[FieldOffset(Offset = "0x18")]
		public string type;

		// Token: 0x0400387D RID: 14461
		[Token(Token = "0x400387D")]
		[FieldOffset(Offset = "0x20")]
		public int number;

		// Token: 0x0400387E RID: 14462
		[Token(Token = "0x400387E")]
		[FieldOffset(Offset = "0x24")]
		public int uid;

		// Token: 0x0400387F RID: 14463
		[Token(Token = "0x400387F")]
		[FieldOffset(Offset = "0x28")]
		public string nickNum;

		// Token: 0x04003880 RID: 14464
		[Token(Token = "0x4003880")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x04003881 RID: 14465
		[Token(Token = "0x4003881")]
		[FieldOffset(Offset = "0x38")]
		public List<PlayerBuildingMeetingClueChar> chars;

		// Token: 0x04003882 RID: 14466
		[Token(Token = "0x4003882")]
		[FieldOffset(Offset = "0x40")]
		public int inUse;

		// Token: 0x04003883 RID: 14467
		[Token(Token = "0x4003883")]
		[FieldOffset(Offset = "0x48")]
		public long ts;
	}
}
