using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A74 RID: 2676
	[Token(Token = "0x2000A74")]
	public class PlayerBuildingDIYSolution
	{
		// Token: 0x06006731 RID: 26417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006731")]
		[Address(RVA = "0x1EF1740", Offset = "0x1EF0340", VA = "0x181EF1740")]
		public PlayerBuildingDIYSolution()
		{
		}

		// Token: 0x040038CF RID: 14543
		[Token(Token = "0x40038CF")]
		[FieldOffset(Offset = "0x10")]
		public string wallPaper;

		// Token: 0x040038D0 RID: 14544
		[Token(Token = "0x40038D0")]
		[FieldOffset(Offset = "0x18")]
		public string floor;

		// Token: 0x040038D1 RID: 14545
		[Token(Token = "0x40038D1")]
		[FieldOffset(Offset = "0x20")]
		public List<PlayerBuildingFurniturePositionInfo> carpet;

		// Token: 0x040038D2 RID: 14546
		[Token(Token = "0x40038D2")]
		[FieldOffset(Offset = "0x28")]
		public List<PlayerBuildingFurniturePositionInfo> other;
	}
}
