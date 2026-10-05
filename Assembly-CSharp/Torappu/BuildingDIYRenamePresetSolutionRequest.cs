using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200062E RID: 1582
	[Token(Token = "0x200062E")]
	public class BuildingDIYRenamePresetSolutionRequest : BuildingRequest
	{
		// Token: 0x0600625E RID: 25182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600625E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingDIYRenamePresetSolutionRequest()
		{
		}

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x10")]
		public int solutionId;

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0x18")]
		public string name;
	}
}
