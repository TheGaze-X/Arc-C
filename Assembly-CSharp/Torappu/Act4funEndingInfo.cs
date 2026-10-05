using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EAC RID: 3756
	[Token(Token = "0x2000EAC")]
	public class Act4funEndingInfo
	{
		// Token: 0x06006B7E RID: 27518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4funEndingInfo()
		{
		}

		// Token: 0x04004F4E RID: 20302
		[Token(Token = "0x4004F4E")]
		[FieldOffset(Offset = "0x10")]
		public string endingId;

		// Token: 0x04004F4F RID: 20303
		[Token(Token = "0x4004F4F")]
		[FieldOffset(Offset = "0x18")]
		public string endingAvg;

		// Token: 0x04004F50 RID: 20304
		[Token(Token = "0x4004F50")]
		[FieldOffset(Offset = "0x20")]
		public string endingDesc;

		// Token: 0x04004F51 RID: 20305
		[Token(Token = "0x4004F51")]
		[FieldOffset(Offset = "0x28")]
		public string stageId;

		// Token: 0x04004F52 RID: 20306
		[Token(Token = "0x4004F52")]
		[FieldOffset(Offset = "0x30")]
		public bool isGoodEnding;
	}
}
