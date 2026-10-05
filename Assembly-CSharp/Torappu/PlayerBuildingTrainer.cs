using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A7D RID: 2685
	[Token(Token = "0x2000A7D")]
	public class PlayerBuildingTrainer
	{
		// Token: 0x06006738 RID: 26424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006738")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingTrainer()
		{
		}

		// Token: 0x040038ED RID: 14573
		[Token(Token = "0x40038ED")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingTrainerState state;

		// Token: 0x040038EE RID: 14574
		[Token(Token = "0x40038EE")]
		[FieldOffset(Offset = "0x14")]
		public int charInstId;
	}
}
