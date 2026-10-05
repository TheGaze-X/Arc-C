using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A36 RID: 2614
	[Token(Token = "0x2000A36")]
	public class PlayerBuildingWorkshopStatus
	{
		// Token: 0x060066F4 RID: 26356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingWorkshopStatus()
		{
		}

		// Token: 0x04003801 RID: 14337
		[Token(Token = "0x4003801")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, List<int>> bonus;
	}
}
