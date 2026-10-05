using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A50 RID: 2640
	[Token(Token = "0x2000A50")]
	public class PlayerBuildingShopStock
	{
		// Token: 0x0600670F RID: 26383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600670F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingShopStock()
		{
		}

		// Token: 0x0400384B RID: 14411
		[Token(Token = "0x400384B")]
		[FieldOffset(Offset = "0x10")]
		public float buffSpeed;

		// Token: 0x0400384C RID: 14412
		[Token(Token = "0x400384C")]
		[FieldOffset(Offset = "0x14")]
		public PlayerRoomState state;

		// Token: 0x0400384D RID: 14413
		[Token(Token = "0x400384D")]
		[FieldOffset(Offset = "0x18")]
		public string formulaId;

		// Token: 0x0400384E RID: 14414
		[Token(Token = "0x400384E")]
		[FieldOffset(Offset = "0x20")]
		public int itemCnt;

		// Token: 0x0400384F RID: 14415
		[Token(Token = "0x400384F")]
		[FieldOffset(Offset = "0x28")]
		public double processPoint;

		// Token: 0x04003850 RID: 14416
		[Token(Token = "0x4003850")]
		[FieldOffset(Offset = "0x30")]
		public DateTime lastUpdateTime;

		// Token: 0x04003851 RID: 14417
		[Token(Token = "0x4003851")]
		[FieldOffset(Offset = "0x38")]
		public long saveTime;

		// Token: 0x04003852 RID: 14418
		[Token(Token = "0x4003852")]
		[FieldOffset(Offset = "0x40")]
		public DateTime completeWorkTime;
	}
}
