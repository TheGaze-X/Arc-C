using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A7E RID: 2686
	[Token(Token = "0x2000A7E")]
	public class PlayerBuildingTrainee
	{
		// Token: 0x06006739 RID: 26425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006739")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingTrainee()
		{
		}

		// Token: 0x040038EF RID: 14575
		[Token(Token = "0x40038EF")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingTraineeState state;

		// Token: 0x040038F0 RID: 14576
		[Token(Token = "0x40038F0")]
		[FieldOffset(Offset = "0x14")]
		public int charInstId;

		// Token: 0x040038F1 RID: 14577
		[Token(Token = "0x40038F1")]
		[FieldOffset(Offset = "0x18")]
		public double processPoint;

		// Token: 0x040038F2 RID: 14578
		[Token(Token = "0x40038F2")]
		[FieldOffset(Offset = "0x20")]
		public float speed;

		// Token: 0x040038F3 RID: 14579
		[Token(Token = "0x40038F3")]
		[FieldOffset(Offset = "0x24")]
		public int targetSkill;
	}
}
