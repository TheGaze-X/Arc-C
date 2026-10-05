using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x0200154B RID: 5451
	[Token(Token = "0x200154B")]
	public class SaveSquadParam
	{
		// Token: 0x06007CAF RID: 31919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SaveSquadParam()
		{
		}

		// Token: 0x04007D35 RID: 32053
		[Token(Token = "0x4007D35")]
		[FieldOffset(Offset = "0x10")]
		public bool isEmergency;

		// Token: 0x04007D36 RID: 32054
		[Token(Token = "0x4007D36")]
		[FieldOffset(Offset = "0x18")]
		public IList<TeamSquadSlotParam> squad;
	}
}
