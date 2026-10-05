using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043D3 RID: 17363
	[Token(Token = "0x20043D3")]
	public class SandboxV2EventChoiceResponse : PlayerDeltaResponse
	{
		// Token: 0x0601A97E RID: 108926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A97E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SandboxV2EventChoiceResponse()
		{
		}

		// Token: 0x04021E64 RID: 138852
		[Token(Token = "0x4021E64")]
		[FieldOffset(Offset = "0x28")]
		public bool success;

		// Token: 0x04021E65 RID: 138853
		[Token(Token = "0x4021E65")]
		[FieldOffset(Offset = "0x30")]
		public List<RewardItemModel> items;

		// Token: 0x04021E66 RID: 138854
		[Token(Token = "0x4021E66")]
		[FieldOffset(Offset = "0x38")]
		public bool finish;
	}
}
