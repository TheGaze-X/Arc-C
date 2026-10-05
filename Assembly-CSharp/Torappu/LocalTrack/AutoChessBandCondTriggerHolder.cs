using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200207C RID: 8316
	[Token(Token = "0x200207C")]
	public class AutoChessBandCondTriggerHolder : PlayerTrackTriggerHolder<AutoChessBandCondTrigger>, IHotfixable
	{
		// Token: 0x0600CD26 RID: 52518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD26")]
		[Address(RVA = "0x34F8230", Offset = "0x34F6E30", VA = "0x1834F8230", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD27 RID: 52519 RVA: 0x00049F08 File Offset: 0x00048108
		[Token(Token = "0x600CD27")]
		[Address(RVA = "0x34F8170", Offset = "0x34F6D70", VA = "0x1834F8170", Slot = "10")]
		protected override bool CheckIfToTrigger(AutoChessBandCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD28 RID: 52520 RVA: 0x00049F20 File Offset: 0x00048120
		[Token(Token = "0x600CD28")]
		[Address(RVA = "0x34F8320", Offset = "0x34F6F20", VA = "0x1834F8320")]
		private bool _CheckIfTeamUnlocked(string bandId, PlayerDataModel playerData)
		{
			return default(bool);
		}

		// Token: 0x0600CD29 RID: 52521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD29")]
		[Address(RVA = "0x34F8460", Offset = "0x34F7060", VA = "0x1834F8460")]
		public AutoChessBandCondTriggerHolder()
		{
		}

		// Token: 0x0400D867 RID: 55399
		[Token(Token = "0x400D867")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D868 RID: 55400
		[Token(Token = "0x400D868")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D869 RID: 55401
		[Token(Token = "0x400D869")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfTeamUnlocked;

		// Token: 0x0400D86A RID: 55402
		[Token(Token = "0x400D86A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
