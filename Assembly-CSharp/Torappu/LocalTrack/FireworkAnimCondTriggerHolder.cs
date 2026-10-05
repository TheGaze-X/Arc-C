using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002087 RID: 8327
	[Token(Token = "0x2002087")]
	public class FireworkAnimCondTriggerHolder : PlayerTrackTriggerHolder<FireworkAnimCondTrigger>
	{
		// Token: 0x0600CD47 RID: 52551 RVA: 0x00049FC8 File Offset: 0x000481C8
		[Token(Token = "0x600CD47")]
		[Address(RVA = "0x34FEC80", Offset = "0x34FD880", VA = "0x1834FEC80", Slot = "10")]
		protected override bool CheckIfToTrigger(FireworkAnimCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD48 RID: 52552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD48")]
		[Address(RVA = "0x34FED40", Offset = "0x34FD940", VA = "0x1834FED40", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD49 RID: 52553 RVA: 0x00049FE0 File Offset: 0x000481E0
		[Token(Token = "0x600CD49")]
		[Address(RVA = "0x34FEE50", Offset = "0x34FDA50", VA = "0x1834FEE50")]
		private bool _CheckIfAnimUnlocked(string animId, PlayerDataModel data)
		{
			return default(bool);
		}

		// Token: 0x0600CD4A RID: 52554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD4A")]
		[Address(RVA = "0x34FEF50", Offset = "0x34FDB50", VA = "0x1834FEF50")]
		public FireworkAnimCondTriggerHolder()
		{
		}

		// Token: 0x0400D892 RID: 55442
		[Token(Token = "0x400D892")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D893 RID: 55443
		[Token(Token = "0x400D893")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D894 RID: 55444
		[Token(Token = "0x400D894")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfAnimUnlocked;

		// Token: 0x0400D895 RID: 55445
		[Token(Token = "0x400D895")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
