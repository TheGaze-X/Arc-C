using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C91 RID: 23697
	[Token(Token = "0x2005C91")]
	public class ClimbTowerBattleStartConfig : StartBattleServiceConfig<ClimbTowerBattleStartRequest, ClimbTowerBattleStartResponse>
	{
		// Token: 0x0602250D RID: 140557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602250D")]
		[Address(RVA = "0x1CB8FC0", Offset = "0x1CB7BC0", VA = "0x181CB8FC0")]
		public ClimbTowerBattleStartConfig(string stageId, CommonStartBattleRequest.SquadModel squad)
		{
		}

		// Token: 0x0602250E RID: 140558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602250E")]
		[Address(RVA = "0x1CB8F10", Offset = "0x1CB7B10", VA = "0x181CB8F10", Slot = "5")]
		protected override ClimbTowerBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x17005098 RID: 20632
		// (get) Token: 0x0602250F RID: 140559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005098")]
		protected override string serviceCode
		{
			[Token(Token = "0x602250F")]
			[Address(RVA = "0x1CB9070", Offset = "0x1CB7C70", VA = "0x181CB9070", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0402F1D7 RID: 192983
		[Token(Token = "0x402F1D7")]
		[FieldOffset(Offset = "0x10")]
		private string m_stageId;

		// Token: 0x0402F1D8 RID: 192984
		[Token(Token = "0x402F1D8")]
		[FieldOffset(Offset = "0x18")]
		private CommonStartBattleRequest.SquadModel m_squad;

		// Token: 0x0402F1D9 RID: 192985
		[Token(Token = "0x402F1D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402F1DA RID: 192986
		[Token(Token = "0x402F1DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ParseRequest;

		// Token: 0x0402F1DB RID: 192987
		[Token(Token = "0x402F1DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_serviceCode;
	}
}
