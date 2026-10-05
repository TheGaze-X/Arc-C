using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E3E RID: 3646
	[Token(Token = "0x2000E3E")]
	public class ActMultiV3SquadInfoData
	{
		// Token: 0x06006B0C RID: 27404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3SquadInfoData()
		{
		}

		// Token: 0x04004BEC RID: 19436
		[Token(Token = "0x4004BEC")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04004BED RID: 19437
		[Token(Token = "0x4004BED")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004BEE RID: 19438
		[Token(Token = "0x4004BEE")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04004BEF RID: 19439
		[Token(Token = "0x4004BEF")]
		[FieldOffset(Offset = "0x28")]
		public ActMultiV3MapModeType modeType;
	}
}
