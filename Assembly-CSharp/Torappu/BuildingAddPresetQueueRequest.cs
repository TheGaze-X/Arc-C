using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006A1 RID: 1697
	[Token(Token = "0x20006A1")]
	public class BuildingAddPresetQueueRequest : BuildingRequest
	{
		// Token: 0x060062DD RID: 25309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062DD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingAddPresetQueueRequest()
		{
		}

		// Token: 0x04002E8A RID: 11914
		[Token(Token = "0x4002E8A")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;
	}
}
