using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E9E RID: 28318
	[Token(Token = "0x2006E9E")]
	public class VecBreakV2OffenseStartBattleConfig : StartBattleServiceConfig<VecBreakV2OffenseStartBattleRequest, VecBreakV2OffenseStartBattleResponse>
	{
		// Token: 0x17005F32 RID: 24370
		// (get) Token: 0x060284BC RID: 165052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F32")]
		protected override string serviceCode
		{
			[Token(Token = "0x60284BC")]
			[Address(RVA = "0x23A6A60", Offset = "0x23A5660", VA = "0x1823A6A60", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060284BD RID: 165053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284BD")]
		[Address(RVA = "0x23A6960", Offset = "0x23A5560", VA = "0x1823A6960")]
		public VecBreakV2OffenseStartBattleConfig(string activityId, string stageId, CommonStartBattleRequest.SquadModel squadModel, SquadFriendData assistFriend)
		{
		}

		// Token: 0x060284BE RID: 165054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284BE")]
		[Address(RVA = "0x23A6890", Offset = "0x23A5490", VA = "0x1823A6890", Slot = "5")]
		protected override VecBreakV2OffenseStartBattleRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x04039450 RID: 234576
		[Token(Token = "0x4039450")]
		[FieldOffset(Offset = "0x10")]
		private string m_activityId;

		// Token: 0x04039451 RID: 234577
		[Token(Token = "0x4039451")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x04039452 RID: 234578
		[Token(Token = "0x4039452")]
		[FieldOffset(Offset = "0x20")]
		private CommonStartBattleRequest.SquadModel m_squadModel;

		// Token: 0x04039453 RID: 234579
		[Token(Token = "0x4039453")]
		[FieldOffset(Offset = "0x28")]
		private SquadFriendData m_assistFriend;

		// Token: 0x04039454 RID: 234580
		[Token(Token = "0x4039454")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x04039455 RID: 234581
		[Token(Token = "0x4039455")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04039456 RID: 234582
		[Token(Token = "0x4039456")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
