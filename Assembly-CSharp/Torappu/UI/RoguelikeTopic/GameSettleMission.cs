using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004553 RID: 17747
	[Token(Token = "0x2004553")]
	public class GameSettleMission
	{
		// Token: 0x0601B0AB RID: 110763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0AB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GameSettleMission()
		{
		}

		// Token: 0x04022BF0 RID: 142320
		[Token(Token = "0x4022BF0")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerRoguelikeV2.OuterData.Mission.MissionItem> before;

		// Token: 0x04022BF1 RID: 142321
		[Token(Token = "0x4022BF1")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerRoguelikeV2.OuterData.Mission.MissionItem> after;
	}
}
