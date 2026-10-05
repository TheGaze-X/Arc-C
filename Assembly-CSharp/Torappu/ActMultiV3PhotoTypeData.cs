using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E4A RID: 3658
	[Token(Token = "0x2000E4A")]
	public class ActMultiV3PhotoTypeData
	{
		// Token: 0x06006B18 RID: 27416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B18")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3PhotoTypeData()
		{
		}

		// Token: 0x04004C2F RID: 19503
		[Token(Token = "0x4004C2F")]
		[FieldOffset(Offset = "0x10")]
		public string photoTypeName;

		// Token: 0x04004C30 RID: 19504
		[Token(Token = "0x4004C30")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004C31 RID: 19505
		[Token(Token = "0x4004C31")]
		[FieldOffset(Offset = "0x20")]
		public string background;

		// Token: 0x04004C32 RID: 19506
		[Token(Token = "0x4004C32")]
		[FieldOffset(Offset = "0x28")]
		public string photoDesc;

		// Token: 0x04004C33 RID: 19507
		[Token(Token = "0x4004C33")]
		[FieldOffset(Offset = "0x30")]
		public List<ActMultiV3PhotoSlotData> slots;
	}
}
