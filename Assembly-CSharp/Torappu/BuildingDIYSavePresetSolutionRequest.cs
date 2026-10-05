using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200062C RID: 1580
	[Token(Token = "0x200062C")]
	public class BuildingDIYSavePresetSolutionRequest : BuildingRequest
	{
		// Token: 0x0600625C RID: 25180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600625C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingDIYSavePresetSolutionRequest()
		{
		}

		// Token: 0x04002DB9 RID: 11705
		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0x10")]
		public int solutionId;

		// Token: 0x04002DBA RID: 11706
		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x18")]
		public string roomType;

		// Token: 0x04002DBB RID: 11707
		[Token(Token = "0x4002DBB")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04002DBC RID: 11708
		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0x28")]
		public PlayerBuildingDIYSolution solution;

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x30")]
		public string thumbnail;
	}
}
