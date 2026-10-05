using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007551 RID: 30033
	[Token(Token = "0x2007551")]
	public class Act24sideBattleStartServiceConfig : SquadCustomStartBattleServiceConfig<Act24sideBattleStartRequest, Act24sideBattleStartResponse>
	{
		// Token: 0x17006399 RID: 25497
		// (get) Token: 0x0602A4D3 RID: 173267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006399")]
		protected override string serviceCode
		{
			[Token(Token = "0x602A4D3")]
			[Address(RVA = "0x25F6160", Offset = "0x25F4D60", VA = "0x1825F6160", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A4D4 RID: 173268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4D4")]
		[Address(RVA = "0x25F6020", Offset = "0x25F4C20", VA = "0x1825F6020", Slot = "7")]
		protected override void OnParseRequest(Act24sideBattleStartRequest request)
		{
		}

		// Token: 0x0602A4D5 RID: 173269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4D5")]
		[Address(RVA = "0x25F60C0", Offset = "0x25F4CC0", VA = "0x1825F60C0")]
		public Act24sideBattleStartServiceConfig(SquadHomeStartBattleServicePluginBase.Param param)
		{
		}

		// Token: 0x0403CD2A RID: 249130
		[Token(Token = "0x403CD2A")]
		[FieldOffset(Offset = "0x18")]
		private string m_activityId;

		// Token: 0x0403CD2B RID: 249131
		[Token(Token = "0x403CD2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403CD2C RID: 249132
		[Token(Token = "0x403CD2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnParseRequest;

		// Token: 0x0403CD2D RID: 249133
		[Token(Token = "0x403CD2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
