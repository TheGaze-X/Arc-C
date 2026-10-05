using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A6A RID: 2666
	[Token(Token = "0x2000A6A")]
	public class PlayerBuildingHire
	{
		// Token: 0x06006728 RID: 26408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006728")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingHire()
		{
		}

		// Token: 0x040038A6 RID: 14502
		[Token(Token = "0x40038A6")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingHireBuff buff;

		// Token: 0x040038A7 RID: 14503
		[Token(Token = "0x40038A7")]
		[FieldOffset(Offset = "0x18")]
		public int recruitSlotId;

		// Token: 0x040038A8 RID: 14504
		[Token(Token = "0x40038A8")]
		[FieldOffset(Offset = "0x1C")]
		public PlayerBuildingHiringState state;

		// Token: 0x040038A9 RID: 14505
		[Token(Token = "0x40038A9")]
		[FieldOffset(Offset = "0x20")]
		public double processPoint;

		// Token: 0x040038AA RID: 14506
		[Token(Token = "0x40038AA")]
		[FieldOffset(Offset = "0x28")]
		public float speed;

		// Token: 0x040038AB RID: 14507
		[Token(Token = "0x40038AB")]
		[FieldOffset(Offset = "0x30")]
		public DateTime lastUpdateTime;

		// Token: 0x040038AC RID: 14508
		[Token(Token = "0x40038AC")]
		[FieldOffset(Offset = "0x38")]
		public int refreshCount;

		// Token: 0x040038AD RID: 14509
		[Token(Token = "0x40038AD")]
		[FieldOffset(Offset = "0x40")]
		public DateTime completeWorkTime;

		// Token: 0x040038AE RID: 14510
		[Token(Token = "0x40038AE")]
		[FieldOffset(Offset = "0x48")]
		public List<List<int>> presetQueue;
	}
}
