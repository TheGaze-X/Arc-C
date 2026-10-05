using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x200065A")]
	public class BuildingManufactLaborAccelRequest
	{
		// Token: 0x06006288 RID: 25224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006288")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingManufactLaborAccelRequest()
		{
		}

		// Token: 0x04002E13 RID: 11795
		[Token(Token = "0x4002E13")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x04002E14 RID: 11796
		[Token(Token = "0x4002E14")]
		[FieldOffset(Offset = "0x18")]
		public int cost;
	}
}
