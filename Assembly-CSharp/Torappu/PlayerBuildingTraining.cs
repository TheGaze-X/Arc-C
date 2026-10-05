using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A81 RID: 2689
	[Token(Token = "0x2000A81")]
	public class PlayerBuildingTraining
	{
		// Token: 0x0600673C RID: 26428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600673C")]
		[Address(RVA = "0x1EF21A0", Offset = "0x1EF0DA0", VA = "0x181EF21A0")]
		public PlayerBuildingTraining()
		{
		}

		// Token: 0x040038F8 RID: 14584
		[Token(Token = "0x40038F8")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingTrainingBuff buff;

		// Token: 0x040038F9 RID: 14585
		[Token(Token = "0x40038F9")]
		[FieldOffset(Offset = "0x18")]
		public DateTime lastUpdateTime;

		// Token: 0x040038FA RID: 14586
		[Token(Token = "0x40038FA")]
		[FieldOffset(Offset = "0x20")]
		public PlayerBuildingTrainer trainer;

		// Token: 0x040038FB RID: 14587
		[Token(Token = "0x40038FB")]
		[FieldOffset(Offset = "0x28")]
		public PlayerBuildingTrainee trainee;

		// Token: 0x040038FC RID: 14588
		[Token(Token = "0x40038FC")]
		[FieldOffset(Offset = "0x30")]
		public DateTime completeWorkTime;
	}
}
