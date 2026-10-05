using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200062A RID: 1578
	[Token(Token = "0x200062A")]
	public class BuildingDIYChangeDIYSolutionRequest : BuildingRequest
	{
		// Token: 0x0600625A RID: 25178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600625A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingDIYChangeDIYSolutionRequest()
		{
		}

		// Token: 0x04002DB7 RID: 11703
		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x04002DB8 RID: 11704
		[Token(Token = "0x4002DB8")]
		[FieldOffset(Offset = "0x18")]
		public PlayerBuildingDIYSolution solution;
	}
}
