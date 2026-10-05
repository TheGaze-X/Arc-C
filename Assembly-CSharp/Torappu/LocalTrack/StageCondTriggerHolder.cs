using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002099 RID: 8345
	[Token(Token = "0x2002099")]
	public class StageCondTriggerHolder : PlayerTrackTriggerHolder<StageCondTrigger>
	{
		// Token: 0x0600CD7D RID: 52605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD7D")]
		[Address(RVA = "0x3504AA0", Offset = "0x35036A0", VA = "0x183504AA0", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD7E RID: 52606 RVA: 0x0004A100 File Offset: 0x00048300
		[Token(Token = "0x600CD7E")]
		[Address(RVA = "0x3504990", Offset = "0x3503590", VA = "0x183504990", Slot = "10")]
		protected override bool CheckIfToTrigger(StageCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD7F RID: 52607 RVA: 0x0004A118 File Offset: 0x00048318
		[Token(Token = "0x600CD7F")]
		[Address(RVA = "0x3504B90", Offset = "0x3503790", VA = "0x183504B90")]
		private bool _CheckIfStageRankSatisfied(string stageId, PlayerStageState target, PlayerDataModel data)
		{
			return default(bool);
		}

		// Token: 0x0600CD80 RID: 52608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD80")]
		[Address(RVA = "0x3504CB0", Offset = "0x35038B0", VA = "0x183504CB0")]
		public StageCondTriggerHolder()
		{
		}

		// Token: 0x0400D8CB RID: 55499
		[Token(Token = "0x400D8CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D8CC RID: 55500
		[Token(Token = "0x400D8CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D8CD RID: 55501
		[Token(Token = "0x400D8CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfStageRankSatisfied;

		// Token: 0x0400D8CE RID: 55502
		[Token(Token = "0x400D8CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
