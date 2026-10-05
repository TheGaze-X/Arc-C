using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000640 RID: 1600
	[Token(Token = "0x2000640")]
	public class BuildingChangeManufactRequest : BuildingRequest
	{
		// Token: 0x0600626E RID: 25198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingChangeManufactRequest()
		{
		}

		// Token: 0x04002DF3 RID: 11763
		[Token(Token = "0x4002DF3")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		[FieldOffset(Offset = "0x18")]
		public string targetFormulaId;

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0x20")]
		public int solutionCount;
	}
}
