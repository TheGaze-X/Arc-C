using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007345 RID: 29509
	[Token(Token = "0x2007345")]
	public class Act42D0ChallengeStartServiceConfig : CrisisStartBattleServiceConfig<Act42D0ChallengeBattleStartRequest, Act42D0ChallengeBattleStartResponse>
	{
		// Token: 0x06029BB7 RID: 170935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BB7")]
		[Address(RVA = "0x2557130", Offset = "0x2555D30", VA = "0x182557130")]
		public Act42D0ChallengeStartServiceConfig(string actId, string stageId)
		{
		}

		// Token: 0x17006286 RID: 25222
		// (get) Token: 0x06029BB8 RID: 170936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006286")]
		protected override string serviceCode
		{
			[Token(Token = "0x6029BB8")]
			[Address(RVA = "0x25571E0", Offset = "0x2555DE0", VA = "0x1825571E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029BB9 RID: 170937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BB9")]
		[Address(RVA = "0x2557060", Offset = "0x2555C60", VA = "0x182557060", Slot = "6")]
		protected override Act42D0ChallengeBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0403BBBF RID: 244671
		[Token(Token = "0x403BBBF")]
		[FieldOffset(Offset = "0x20")]
		private string m_actId;

		// Token: 0x0403BBC0 RID: 244672
		[Token(Token = "0x403BBC0")]
		[FieldOffset(Offset = "0x28")]
		private string m_stageId;

		// Token: 0x0403BBC1 RID: 244673
		[Token(Token = "0x403BBC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403BBC2 RID: 244674
		[Token(Token = "0x403BBC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403BBC3 RID: 244675
		[Token(Token = "0x403BBC3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
