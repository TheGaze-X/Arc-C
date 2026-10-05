using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006177 RID: 24951
	[Token(Token = "0x2006177")]
	public class BossRushStartBattleRequest
	{
		// Token: 0x06024006 RID: 147462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024006")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BossRushStartBattleRequest()
		{
		}

		// Token: 0x04032037 RID: 204855
		[Token(Token = "0x4032037")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04032038 RID: 204856
		[Token(Token = "0x4032038")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04032039 RID: 204857
		[Token(Token = "0x4032039")]
		[FieldOffset(Offset = "0x20")]
		public string teamId;

		// Token: 0x0403203A RID: 204858
		[Token(Token = "0x403203A")]
		[FieldOffset(Offset = "0x28")]
		public List<RequestSquadSlot> ownSlots;

		// Token: 0x0403203B RID: 204859
		[Token(Token = "0x403203B")]
		[FieldOffset(Offset = "0x30")]
		public SquadFriendData assistFriend;
	}
}
