using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200063C RID: 1596
	[Token(Token = "0x200063C")]
	public class BuildingSettleManufactRequest : BuildingRequest
	{
		// Token: 0x0600626A RID: 25194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingSettleManufactRequest()
		{
		}

		// Token: 0x04002DEF RID: 11759
		[Token(Token = "0x4002DEF")]
		[FieldOffset(Offset = "0x10")]
		public List<string> roomSlotIdList;

		// Token: 0x04002DF0 RID: 11760
		[Token(Token = "0x4002DF0")]
		[FieldOffset(Offset = "0x18")]
		public int supplement;
	}
}
