using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A4E RID: 2638
	[Token(Token = "0x2000A4E")]
	public class PlayerBuildingManufacture
	{
		// Token: 0x0600670D RID: 26381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600670D")]
		[Address(RVA = "0x1EF1800", Offset = "0x1EF0400", VA = "0x181EF1800")]
		public PlayerBuildingManufacture()
		{
		}

		// Token: 0x0400383C RID: 14396
		[Token(Token = "0x400383C")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingManufactureBuff buff;

		// Token: 0x0400383D RID: 14397
		[Token(Token = "0x400383D")]
		[FieldOffset(Offset = "0x18")]
		public PlayerRoomState state;

		// Token: 0x0400383E RID: 14398
		[Token(Token = "0x400383E")]
		[FieldOffset(Offset = "0x20")]
		public string formulaId;

		// Token: 0x0400383F RID: 14399
		[Token(Token = "0x400383F")]
		[FieldOffset(Offset = "0x28")]
		public int remainSolutionCnt;

		// Token: 0x04003840 RID: 14400
		[Token(Token = "0x4003840")]
		[FieldOffset(Offset = "0x2C")]
		public int outputSolutionCnt;

		// Token: 0x04003841 RID: 14401
		[Token(Token = "0x4003841")]
		[FieldOffset(Offset = "0x30")]
		public DateTime lastUpdateTime;

		// Token: 0x04003842 RID: 14402
		[Token(Token = "0x4003842")]
		[FieldOffset(Offset = "0x38")]
		public double processPoint;

		// Token: 0x04003843 RID: 14403
		[Token(Token = "0x4003843")]
		[FieldOffset(Offset = "0x40")]
		public long saveTime;

		// Token: 0x04003844 RID: 14404
		[Token(Token = "0x4003844")]
		[FieldOffset(Offset = "0x48")]
		public DateTime completeWorkTime;

		// Token: 0x04003845 RID: 14405
		[Token(Token = "0x4003845")]
		[FieldOffset(Offset = "0x50")]
		public int capacity;

		// Token: 0x04003846 RID: 14406
		[Token(Token = "0x4003846")]
		[FieldOffset(Offset = "0x54")]
		public int apCost;

		// Token: 0x04003847 RID: 14407
		[Token(Token = "0x4003847")]
		[FieldOffset(Offset = "0x58")]
		public BuildingBuffDisplay display;

		// Token: 0x04003848 RID: 14408
		[Token(Token = "0x4003848")]
		[FieldOffset(Offset = "0x60")]
		public List<List<int>> presetQueue;
	}
}
