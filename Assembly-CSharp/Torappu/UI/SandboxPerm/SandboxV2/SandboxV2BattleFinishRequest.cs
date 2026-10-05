using System;
using Il2CppDummyDll;
using Torappu.Battle.Sandbox;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200440E RID: 17422
	[Token(Token = "0x200440E")]
	public class SandboxV2BattleFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x0601A9D0 RID: 109008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9D0")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SandboxV2BattleFinishRequest()
		{
		}

		// Token: 0x04021ECD RID: 138957
		[Token(Token = "0x4021ECD")]
		[FieldOffset(Offset = "0x20")]
		public string topicId;

		// Token: 0x04021ECE RID: 138958
		[Token(Token = "0x4021ECE")]
		[FieldOffset(Offset = "0x28")]
		public SandboxOutput sandboxV2Data;
	}
}
