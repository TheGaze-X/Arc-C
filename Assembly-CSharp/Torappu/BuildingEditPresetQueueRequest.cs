using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006A5 RID: 1701
	[Token(Token = "0x20006A5")]
	public class BuildingEditPresetQueueRequest : BuildingRequest
	{
		// Token: 0x060062E1 RID: 25313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingEditPresetQueueRequest()
		{
		}

		// Token: 0x04002E8D RID: 11917
		[Token(Token = "0x4002E8D")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x04002E8E RID: 11918
		[Token(Token = "0x4002E8E")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		// Token: 0x04002E8F RID: 11919
		[Token(Token = "0x4002E8F")]
		[FieldOffset(Offset = "0x20")]
		public List<int> queue;
	}
}
