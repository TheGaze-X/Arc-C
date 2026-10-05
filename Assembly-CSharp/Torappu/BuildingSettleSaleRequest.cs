using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200063E RID: 1598
	[Token(Token = "0x200063E")]
	public class BuildingSettleSaleRequest : BuildingRequest
	{
		// Token: 0x0600626C RID: 25196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingSettleSaleRequest()
		{
		}

		// Token: 0x04002DF2 RID: 11762
		[Token(Token = "0x4002DF2")]
		[FieldOffset(Offset = "0x10")]
		public List<string> roomSlotIdList;
	}
}
