using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200064E RID: 1614
	[Token(Token = "0x200064E")]
	public class BuildingWorkshopSynthesisRequest : BuildingRequest
	{
		// Token: 0x0600627C RID: 25212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingWorkshopSynthesisRequest()
		{
		}

		// Token: 0x04002E01 RID: 11777
		[Token(Token = "0x4002E01")]
		[FieldOffset(Offset = "0x10")]
		public string formulaId;

		// Token: 0x04002E02 RID: 11778
		[Token(Token = "0x4002E02")]
		[FieldOffset(Offset = "0x18")]
		public int times;
	}
}
