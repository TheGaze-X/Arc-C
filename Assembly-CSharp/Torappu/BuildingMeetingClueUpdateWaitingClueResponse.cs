using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000679 RID: 1657
	[Token(Token = "0x2000679")]
	public class BuildingMeetingClueUpdateWaitingClueResponse : PlayerDeltaResponse
	{
		// Token: 0x060062A7 RID: 25255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A7")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingMeetingClueUpdateWaitingClueResponse()
		{
		}

		// Token: 0x04002E33 RID: 11827
		[Token(Token = "0x4002E33")]
		[FieldOffset(Offset = "0x28")]
		public List<BuildingMeetingClueUpdateWaitingClueResponse.Clue> box;

		// Token: 0x0200067A RID: 1658
		[Token(Token = "0x200067A")]
		public class Clue
		{
			// Token: 0x060062A8 RID: 25256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062A8")]
			[Address(RVA = "0x1DE9960", Offset = "0x1DE8560", VA = "0x181DE9960")]
			public Clue()
			{
			}

			// Token: 0x04002E34 RID: 11828
			[Token(Token = "0x4002E34")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04002E35 RID: 11829
			[Token(Token = "0x4002E35")]
			[FieldOffset(Offset = "0x18")]
			public string type;

			// Token: 0x04002E36 RID: 11830
			[Token(Token = "0x4002E36")]
			[FieldOffset(Offset = "0x20")]
			public int number;

			// Token: 0x04002E37 RID: 11831
			[Token(Token = "0x4002E37")]
			[FieldOffset(Offset = "0x24")]
			public int uid;

			// Token: 0x04002E38 RID: 11832
			[Token(Token = "0x4002E38")]
			[FieldOffset(Offset = "0x28")]
			public string nickNum;

			// Token: 0x04002E39 RID: 11833
			[Token(Token = "0x4002E39")]
			[FieldOffset(Offset = "0x30")]
			public string name;

			// Token: 0x04002E3A RID: 11834
			[Token(Token = "0x4002E3A")]
			[FieldOffset(Offset = "0x38")]
			public List<PlayerBuildingMeetingClueChar> chars;

			// Token: 0x04002E3B RID: 11835
			[Token(Token = "0x4002E3B")]
			[FieldOffset(Offset = "0x40")]
			public int inUse;

			// Token: 0x04002E3C RID: 11836
			[Token(Token = "0x4002E3C")]
			[FieldOffset(Offset = "0x48")]
			public long ts;
		}
	}
}
