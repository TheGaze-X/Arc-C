using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E52 RID: 3666
	[Token(Token = "0x2000E52")]
	public class ActMultiV3SailBoatBlockPoolData : IItemWithWeight
	{
		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06006B20 RID: 27424 RVA: 0x00031230 File Offset: 0x0002F430
		[Token(Token = "0x17000D02")]
		public float weightValue
		{
			[Token(Token = "0x6006B20")]
			[Address(RVA = "0x1FFA6E0", Offset = "0x1FF92E0", VA = "0x181FFA6E0", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B21")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3SailBoatBlockPoolData()
		{
		}

		// Token: 0x04004C51 RID: 19537
		[Token(Token = "0x4004C51")]
		[FieldOffset(Offset = "0x10")]
		public string blockPool;

		// Token: 0x04004C52 RID: 19538
		[Token(Token = "0x4004C52")]
		[FieldOffset(Offset = "0x18")]
		public string blockId;

		// Token: 0x04004C53 RID: 19539
		[Token(Token = "0x4004C53")]
		[FieldOffset(Offset = "0x20")]
		public ActMultiV3BlockDirType startDirType;

		// Token: 0x04004C54 RID: 19540
		[Token(Token = "0x4004C54")]
		[FieldOffset(Offset = "0x24")]
		public ActMultiV3BlockDirType endDirType;

		// Token: 0x04004C55 RID: 19541
		[Token(Token = "0x4004C55")]
		[FieldOffset(Offset = "0x28")]
		public int weight;
	}
}
