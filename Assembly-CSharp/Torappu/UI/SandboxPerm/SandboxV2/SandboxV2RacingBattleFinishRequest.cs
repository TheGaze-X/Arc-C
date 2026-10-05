using System;
using Il2CppDummyDll;
using Torappu.Battle.Racing;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004411 RID: 17425
	[Token(Token = "0x2004411")]
	public class SandboxV2RacingBattleFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x0601A9D9 RID: 109017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9D9")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SandboxV2RacingBattleFinishRequest()
		{
		}

		// Token: 0x04021ED6 RID: 138966
		[Token(Token = "0x4021ED6")]
		[FieldOffset(Offset = "0x20")]
		public string topicId;

		// Token: 0x04021ED7 RID: 138967
		[Token(Token = "0x4021ED7")]
		[FieldOffset(Offset = "0x28")]
		public RacingOutput racingData;
	}
}
