using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006179 RID: 24953
	[Token(Token = "0x2006179")]
	public class BossRushBattleStartConfig : StartBattleServiceConfig<BossRushStartBattleRequest, BossRushStartBattleResponse>
	{
		// Token: 0x170054FB RID: 21755
		// (get) Token: 0x0602400C RID: 147468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054FB")]
		protected override string serviceCode
		{
			[Token(Token = "0x602400C")]
			[Address(RVA = "0x1EA2B70", Offset = "0x1EA1770", VA = "0x181EA2B70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602400D RID: 147469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602400D")]
		[Address(RVA = "0x1EA2A60", Offset = "0x1EA1660", VA = "0x181EA2A60")]
		public BossRushBattleStartConfig(string activityId, string stageId, string teamId, List<RequestSquadSlot> ownSlots, SquadFriendData assistFriend)
		{
		}

		// Token: 0x0602400E RID: 147470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602400E")]
		[Address(RVA = "0x1EA2970", Offset = "0x1EA1570", VA = "0x181EA2970", Slot = "5")]
		protected override BossRushStartBattleRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0403203C RID: 204860
		[Token(Token = "0x403203C")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403203D RID: 204861
		[Token(Token = "0x403203D")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x0403203E RID: 204862
		[Token(Token = "0x403203E")]
		[FieldOffset(Offset = "0x20")]
		private string m_teamId;

		// Token: 0x0403203F RID: 204863
		[Token(Token = "0x403203F")]
		[FieldOffset(Offset = "0x28")]
		private List<RequestSquadSlot> m_ownSlots;

		// Token: 0x04032040 RID: 204864
		[Token(Token = "0x4032040")]
		[FieldOffset(Offset = "0x30")]
		private SquadFriendData m_assistFriend;

		// Token: 0x04032041 RID: 204865
		[Token(Token = "0x4032041")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x04032042 RID: 204866
		[Token(Token = "0x4032042")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04032043 RID: 204867
		[Token(Token = "0x4032043")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
