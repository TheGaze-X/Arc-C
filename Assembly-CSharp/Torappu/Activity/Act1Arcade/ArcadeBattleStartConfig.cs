using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200791A RID: 31002
	[Token(Token = "0x200791A")]
	public class ArcadeBattleStartConfig : StartBattleServiceConfig<ArcadeStartBattleRequest, ArcadeStartBattleResponse>
	{
		// Token: 0x170065E7 RID: 26087
		// (get) Token: 0x0602B7EB RID: 178155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065E7")]
		protected override string serviceCode
		{
			[Token(Token = "0x602B7EB")]
			[Address(RVA = "0x277ADE0", Offset = "0x27799E0", VA = "0x18277ADE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B7EC RID: 178156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7EC")]
		[Address(RVA = "0x277ACE0", Offset = "0x27798E0", VA = "0x18277ACE0")]
		public ArcadeBattleStartConfig(string activityId, string stageId, CommonStartBattleRequest.SquadModel squadModel, SquadFriendData assistFriend)
		{
		}

		// Token: 0x0602B7ED RID: 178157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7ED")]
		[Address(RVA = "0x277AC10", Offset = "0x2779810", VA = "0x18277AC10", Slot = "5")]
		protected override ArcadeStartBattleRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0403EE24 RID: 257572
		[Token(Token = "0x403EE24")]
		[FieldOffset(Offset = "0x10")]
		private string m_stageId;

		// Token: 0x0403EE25 RID: 257573
		[Token(Token = "0x403EE25")]
		[FieldOffset(Offset = "0x18")]
		private string m_activityId;

		// Token: 0x0403EE26 RID: 257574
		[Token(Token = "0x403EE26")]
		[FieldOffset(Offset = "0x20")]
		private CommonStartBattleRequest.SquadModel m_squadModel;

		// Token: 0x0403EE27 RID: 257575
		[Token(Token = "0x403EE27")]
		[FieldOffset(Offset = "0x28")]
		private SquadFriendData m_assistFriend;

		// Token: 0x0403EE28 RID: 257576
		[Token(Token = "0x403EE28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403EE29 RID: 257577
		[Token(Token = "0x403EE29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403EE2A RID: 257578
		[Token(Token = "0x403EE2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
