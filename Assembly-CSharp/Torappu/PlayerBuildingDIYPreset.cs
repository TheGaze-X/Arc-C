using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A75 RID: 2677
	[Token(Token = "0x2000A75")]
	public class PlayerBuildingDIYPreset
	{
		// Token: 0x06006732 RID: 26418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006732")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingDIYPreset()
		{
		}

		// Token: 0x040038D3 RID: 14547
		[Token(Token = "0x40038D3")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040038D4 RID: 14548
		[Token(Token = "0x40038D4")]
		[FieldOffset(Offset = "0x18")]
		public string roomType;

		// Token: 0x040038D5 RID: 14549
		[Token(Token = "0x40038D5")]
		[FieldOffset(Offset = "0x20")]
		public PlayerBuildingDIYSolution solution;

		// Token: 0x040038D6 RID: 14550
		[Token(Token = "0x40038D6")]
		[FieldOffset(Offset = "0x28")]
		public string thumbnail;
	}
}
