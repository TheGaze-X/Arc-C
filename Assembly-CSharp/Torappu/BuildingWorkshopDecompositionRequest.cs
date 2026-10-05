using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000650 RID: 1616
	[Token(Token = "0x2000650")]
	public class BuildingWorkshopDecompositionRequest : BuildingRequest
	{
		// Token: 0x0600627E RID: 25214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingWorkshopDecompositionRequest()
		{
		}

		// Token: 0x04002E06 RID: 11782
		[Token(Token = "0x4002E06")]
		[FieldOffset(Offset = "0x10")]
		public string furniId;

		// Token: 0x04002E07 RID: 11783
		[Token(Token = "0x4002E07")]
		[FieldOffset(Offset = "0x18")]
		public int times;
	}
}
