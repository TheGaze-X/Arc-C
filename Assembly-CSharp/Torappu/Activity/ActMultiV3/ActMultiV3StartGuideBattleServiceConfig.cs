using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ED3 RID: 28371
	[Token(Token = "0x2006ED3")]
	public class ActMultiV3StartGuideBattleServiceConfig : StartBattleServiceConfig<ActMultiV3GuideBattleStartRequest, ActMultiV3GuideBattleStartResponse>
	{
		// Token: 0x0602854A RID: 165194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602854A")]
		[Address(RVA = "0x238D950", Offset = "0x238C550", VA = "0x18238D950")]
		public ActMultiV3StartGuideBattleServiceConfig(string actId, string stageId)
		{
		}

		// Token: 0x17005F45 RID: 24389
		// (get) Token: 0x0602854B RID: 165195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F45")]
		protected override string serviceCode
		{
			[Token(Token = "0x602854B")]
			[Address(RVA = "0x238DA00", Offset = "0x238C600", VA = "0x18238DA00", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602854C RID: 165196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602854C")]
		[Address(RVA = "0x238D8A0", Offset = "0x238C4A0", VA = "0x18238D8A0", Slot = "5")]
		protected override ActMultiV3GuideBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x04039542 RID: 234818
		[Token(Token = "0x4039542")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x04039543 RID: 234819
		[Token(Token = "0x4039543")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x04039544 RID: 234820
		[Token(Token = "0x4039544")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04039545 RID: 234821
		[Token(Token = "0x4039545")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x04039546 RID: 234822
		[Token(Token = "0x4039546")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
