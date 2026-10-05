using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001083 RID: 4227
	[Token(Token = "0x2001083")]
	public class HalfIdleEquipPanelParams
	{
		// Token: 0x06006E13 RID: 28179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E13")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HalfIdleEquipPanelParams()
		{
		}

		// Token: 0x04005A46 RID: 23110
		[Token(Token = "0x4005A46")]
		[FieldOffset(Offset = "0x10")]
		public List<Act1VHalfIdleEquipType> autoUpgradedTypes;
	}
}
