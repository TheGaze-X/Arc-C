using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002089 RID: 8329
	[Token(Token = "0x2002089")]
	public class FireworkPlateCondTriggerHolder : PlayerTrackTriggerHolder<FireworkPlateCondTrigger>
	{
		// Token: 0x0600CD4D RID: 52557 RVA: 0x00049FF8 File Offset: 0x000481F8
		[Token(Token = "0x600CD4D")]
		[Address(RVA = "0x34FF080", Offset = "0x34FDC80", VA = "0x1834FF080", Slot = "10")]
		protected override bool CheckIfToTrigger(FireworkPlateCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD4E RID: 52558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD4E")]
		[Address(RVA = "0x34FF140", Offset = "0x34FDD40", VA = "0x1834FF140", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD4F RID: 52559 RVA: 0x0004A010 File Offset: 0x00048210
		[Token(Token = "0x600CD4F")]
		[Address(RVA = "0x34FF250", Offset = "0x34FDE50", VA = "0x1834FF250")]
		private bool _CheckIfPlateUnlocked(string plateId, PlayerDataModel data)
		{
			return default(bool);
		}

		// Token: 0x0600CD50 RID: 52560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD50")]
		[Address(RVA = "0x34FF340", Offset = "0x34FDF40", VA = "0x1834FF340")]
		public FireworkPlateCondTriggerHolder()
		{
		}

		// Token: 0x0400D898 RID: 55448
		[Token(Token = "0x400D898")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D899 RID: 55449
		[Token(Token = "0x400D899")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D89A RID: 55450
		[Token(Token = "0x400D89A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfPlateUnlocked;

		// Token: 0x0400D89B RID: 55451
		[Token(Token = "0x400D89B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
