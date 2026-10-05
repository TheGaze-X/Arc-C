using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200209E RID: 8350
	[Token(Token = "0x200209E")]
	public class TemplateTrapCondTriggerHolder : PlayerTrackTriggerHolder<TemplateTrapCondTrigger>
	{
		// Token: 0x0600CD91 RID: 52625 RVA: 0x0004A1C0 File Offset: 0x000483C0
		[Token(Token = "0x600CD91")]
		[Address(RVA = "0x3504DF0", Offset = "0x35039F0", VA = "0x183504DF0", Slot = "10")]
		protected override bool CheckIfToTrigger(TemplateTrapCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD92 RID: 52626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD92")]
		[Address(RVA = "0x3504EA0", Offset = "0x3503AA0", VA = "0x183504EA0", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD93 RID: 52627 RVA: 0x0004A1D8 File Offset: 0x000483D8
		[Token(Token = "0x600CD93")]
		[Address(RVA = "0x3504F90", Offset = "0x3503B90", VA = "0x183504F90")]
		private bool _CheckIfSatisfied(TemplateTrapCondTrigger trigger, PlayerDataModel data)
		{
			return default(bool);
		}

		// Token: 0x0600CD94 RID: 52628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD94")]
		[Address(RVA = "0x35050D0", Offset = "0x3503CD0", VA = "0x1835050D0")]
		public TemplateTrapCondTriggerHolder()
		{
		}

		// Token: 0x0400D8E4 RID: 55524
		[Token(Token = "0x400D8E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D8E5 RID: 55525
		[Token(Token = "0x400D8E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D8E6 RID: 55526
		[Token(Token = "0x400D8E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfSatisfied;

		// Token: 0x0400D8E7 RID: 55527
		[Token(Token = "0x400D8E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
