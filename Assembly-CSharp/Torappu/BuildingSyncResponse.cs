using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200061F RID: 1567
	[Token(Token = "0x200061F")]
	public class BuildingSyncResponse : PlayerDeltaResponse
	{
		// Token: 0x0600624D RID: 25165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624D")]
		[Address(RVA = "0x1DE9930", Offset = "0x1DE8530", VA = "0x181DE9930")]
		public BuildingSyncResponse()
		{
		}

		// Token: 0x04002DA6 RID: 11686
		[Token(Token = "0x4002DA6")]
		[FieldOffset(Offset = "0x28")]
		public long ts;
	}
}
