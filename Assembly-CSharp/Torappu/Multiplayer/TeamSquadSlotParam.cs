using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x02001549 RID: 5449
	[Token(Token = "0x2001549")]
	public class TeamSquadSlotParam
	{
		// Token: 0x06007CAD RID: 31917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TeamSquadSlotParam()
		{
		}

		// Token: 0x04007D2F RID: 32047
		[Token(Token = "0x4007D2F")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04007D30 RID: 32048
		[Token(Token = "0x4007D30")]
		[FieldOffset(Offset = "0x14")]
		public int skillIdx;

		// Token: 0x04007D31 RID: 32049
		[Token(Token = "0x4007D31")]
		[FieldOffset(Offset = "0x18")]
		public string equipId;
	}
}
