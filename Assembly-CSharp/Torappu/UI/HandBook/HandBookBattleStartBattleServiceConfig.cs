using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006669 RID: 26217
	[Token(Token = "0x2006669")]
	public class HandBookBattleStartBattleServiceConfig : StartBattleServiceConfig<HandBookAddonStageBattleStartRequest, HandBookAddonStageBattleStartResponse>
	{
		// Token: 0x17005939 RID: 22841
		// (get) Token: 0x06025A5A RID: 154202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005939")]
		protected override string serviceCode
		{
			[Token(Token = "0x6025A5A")]
			[Address(RVA = "0x208E8F0", Offset = "0x208D4F0", VA = "0x18208E8F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025A5B RID: 154203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A5B")]
		[Address(RVA = "0x208E820", Offset = "0x208D420", VA = "0x18208E820")]
		public HandBookBattleStartBattleServiceConfig(string charId, string stageId, CommonStartBattleRequest.SquadModel squad)
		{
		}

		// Token: 0x06025A5C RID: 154204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A5C")]
		[Address(RVA = "0x208E750", Offset = "0x208D350", VA = "0x18208E750", Slot = "5")]
		protected override HandBookAddonStageBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x04034E14 RID: 216596
		[Token(Token = "0x4034E14")]
		[FieldOffset(Offset = "0x10")]
		private string m_charId;

		// Token: 0x04034E15 RID: 216597
		[Token(Token = "0x4034E15")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x04034E16 RID: 216598
		[Token(Token = "0x4034E16")]
		[FieldOffset(Offset = "0x20")]
		private CommonStartBattleRequest.SquadModel m_squad;

		// Token: 0x04034E17 RID: 216599
		[Token(Token = "0x4034E17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x04034E18 RID: 216600
		[Token(Token = "0x4034E18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04034E19 RID: 216601
		[Token(Token = "0x4034E19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
