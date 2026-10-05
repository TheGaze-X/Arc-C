using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002097 RID: 8343
	[Token(Token = "0x2002097")]
	public class NameCardSkinTriggerHolder : PlayerTrackTriggerHolder<NameCardSkinTrigger>
	{
		// Token: 0x0600CD77 RID: 52599 RVA: 0x0004A0D0 File Offset: 0x000482D0
		[Token(Token = "0x600CD77")]
		[Address(RVA = "0x3504370", Offset = "0x3502F70", VA = "0x183504370", Slot = "10")]
		protected override bool CheckIfToTrigger(NameCardSkinTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD78 RID: 52600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD78")]
		[Address(RVA = "0x3504430", Offset = "0x3503030", VA = "0x183504430", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD79 RID: 52601 RVA: 0x0004A0E8 File Offset: 0x000482E8
		[Token(Token = "0x600CD79")]
		[Address(RVA = "0x3504540", Offset = "0x3503140", VA = "0x183504540")]
		private bool _CheckIfNameCardSkinUnlocked(string skinId, PlayerDataModel playerData)
		{
			return default(bool);
		}

		// Token: 0x0600CD7A RID: 52602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD7A")]
		[Address(RVA = "0x3504650", Offset = "0x3503250", VA = "0x183504650")]
		public NameCardSkinTriggerHolder()
		{
		}

		// Token: 0x0400D8C3 RID: 55491
		[Token(Token = "0x400D8C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D8C4 RID: 55492
		[Token(Token = "0x400D8C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D8C5 RID: 55493
		[Token(Token = "0x400D8C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfNameCardSkinUnlocked;

		// Token: 0x0400D8C6 RID: 55494
		[Token(Token = "0x400D8C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
