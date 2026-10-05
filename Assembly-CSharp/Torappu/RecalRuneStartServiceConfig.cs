using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020007D2 RID: 2002
	[Token(Token = "0x20007D2")]
	public class RecalRuneStartServiceConfig : CrisisStartBattleServiceConfig<RecalRuneBattleStartRequest, RecalRuneBattleStartResponse>
	{
		// Token: 0x06006457 RID: 25687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006457")]
		[Address(RVA = "0x1F002F0", Offset = "0x1EFEEF0", VA = "0x181F002F0")]
		public RecalRuneStartServiceConfig(string seasonId, string stageId, List<string> runes)
		{
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06006458 RID: 25688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDF")]
		protected override string serviceCode
		{
			[Token(Token = "0x6006458")]
			[Address(RVA = "0x1F003C0", Offset = "0x1EFEFC0", VA = "0x181F003C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006459")]
		[Address(RVA = "0x1F00200", Offset = "0x1EFEE00", VA = "0x181F00200", Slot = "6")]
		protected override RecalRuneBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x040030E1 RID: 12513
		[Token(Token = "0x40030E1")]
		[FieldOffset(Offset = "0x20")]
		private readonly string m_seasonId;

		// Token: 0x040030E2 RID: 12514
		[Token(Token = "0x40030E2")]
		[FieldOffset(Offset = "0x28")]
		private readonly string m_stageId;

		// Token: 0x040030E3 RID: 12515
		[Token(Token = "0x40030E3")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<string> m_runes;

		// Token: 0x040030E4 RID: 12516
		[Token(Token = "0x40030E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040030E5 RID: 12517
		[Token(Token = "0x40030E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x040030E6 RID: 12518
		[Token(Token = "0x40030E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
