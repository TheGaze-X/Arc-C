using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E49 RID: 3657
	[Token(Token = "0x2000E49")]
	public class ActMultiV3PhotoSlotData
	{
		// Token: 0x06006B17 RID: 27415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B17")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3PhotoSlotData()
		{
		}

		// Token: 0x04004C2A RID: 19498
		[Token(Token = "0x4004C2A")]
		[FieldOffset(Offset = "0x10")]
		public float slotPosX;

		// Token: 0x04004C2B RID: 19499
		[Token(Token = "0x4004C2B")]
		[FieldOffset(Offset = "0x14")]
		public float slotPosY;

		// Token: 0x04004C2C RID: 19500
		[Token(Token = "0x4004C2C")]
		[FieldOffset(Offset = "0x18")]
		public int slotRotZ;

		// Token: 0x04004C2D RID: 19501
		[Token(Token = "0x4004C2D")]
		[FieldOffset(Offset = "0x1C")]
		public float slotScale;

		// Token: 0x04004C2E RID: 19502
		[Token(Token = "0x4004C2E")]
		[FieldOffset(Offset = "0x20")]
		public string slotAnimName;
	}
}
